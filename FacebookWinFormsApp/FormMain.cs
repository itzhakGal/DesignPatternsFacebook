using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form, IFacebookObserver
    {
        private readonly FacebookManager r_FacebookManager;
        private int m_CurrentPhotoIndex = 0;
        private Album m_SelectedAlbum;

        public FormMain(FacebookManager i_FacebookManager)
        {
            InitializeComponent();
            r_FacebookManager = i_FacebookManager;
            r_FacebookManager.RegisterObserver(this);
            applyCustomStyling();
            initializeForm();
        }

        private void initializeForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (r_FacebookManager.LoginResult != null && !string.IsNullOrEmpty(r_FacebookManager.LoginResult.AccessToken))
            {
                updateUI();
            }
            else
            {
                MessageBox.Show("No valid user is logged in. Please log in again.");
            }
        }

        private void updateUI()
        {
            var userInfo = r_FacebookManager.GetUserInfo();
            labelWelcome.Text = $"Welcome {userInfo[0].Split(':')[1].Trim()}";
            pictureBoxImageUser.ImageLocation = r_FacebookManager.LoginResult.LoggedInUser.PictureNormalURL;
            pictureBoxImageUserTop.ImageLocation = r_FacebookManager.LoginResult.LoggedInUser.PictureNormalURL;

            buttonLogout.Enabled = true;
            menu.Enabled = true;
            PersonalGoalManager.Instance.LoadGoalsFromFile(r_FacebookManager.GetCurrentUserId());
            showPanel(panelPosts);
            fetchPosts();
        }

        public void UpdateLoginStatus(bool isLoggedIn)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => updateLoginStatusUI(isLoggedIn)));
            }
            else
            {
                updateLoginStatusUI(isLoggedIn);
            }
        }

        public void UpdateUserData(User user)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => updateUserDataUI(user)));
            }
            else
            {
                updateUserDataUI(user);
            }
        }

        private void updateLoginStatusUI(bool isLoggedIn)
        {
            buttonLogout.Enabled = isLoggedIn;
            menu.Enabled = isLoggedIn;

            if (isLoggedIn)
            {
                showPanel(panelPosts);
                fetchPosts();
            }
            else
            {
                showPanel(panelPosts);
            }
        }

        private void updateUserDataUI(User user)
        {
            labelWelcome.Text = $"Welcome {user.Name}";
            pictureBoxImageUser.ImageLocation = user.PictureNormalURL;
            pictureBoxImageUserTop.ImageLocation = user.PictureNormalURL;

            PersonalGoalManager.Instance.LoadGoalsFromFile(r_FacebookManager.GetCurrentUserId());
            initialPanelGoals();
        }

        private void applyCustomStyling()
        {
            panelSidebar.BackColor = Color.FromArgb(233, 235, 238);
            foreach (Control control in menu.Controls)
            {
                if (control is Button button)
                {
                    applyButtonStyling(button);
                }
            }
            applyListBoxStyling(listBoxPosts);
            applyListBoxStyling(listBoxPages);
            applyListBoxStyling(listBoxGroups);
            applyListBoxStyling(listBoxAlbums);

            applyButtonStyling(buttonPost);
            applyButtonStyling(buttonPrevPhoto);
            applyButtonStyling(buttonNextPhoto);

            applyPictureBoxStyling(pictureBoxSelectedPage);
            applyPictureBoxStyling(pictureBoxSelectedGroup);
            applyPictureBoxStyling(pictureBoxAlbums);
        }

        private void showPanel(Panel i_PanelToShow)
        {
            panelPosts.Visible = false;
            panelPages.Visible = false;
            panelAlbums.Visible = false;
            panelGroups.Visible = false;
            panelPersonalityInsights.Visible = false;
            panelGoals.Visible = false;
            i_PanelToShow.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                PersonalGoalManager.Instance.SaveGoalsToFile(r_FacebookManager.GetCurrentUserId());
                Close();
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                string statusText = customRichTextBoxPanelNewPost.GetText();
                MessageBox.Show($"Your status update is ready to go! 🚀\n\n\"{statusText}\"\n\nKeep the positive vibes going! Remember, sharing is caring, even if it's just with yourself! 😉",
                                "Status Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customRichTextBoxPanelNewPost.SetText(string.Empty);
                customRichTextBoxPanelNewPost.PlaceholderText = "What\'s on your mind?";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong, but don't worry! You're still awesome! 😎\n\nError: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            r_FacebookManager.UnregisterObserver(this);
            base.OnFormClosing(e);
            PersonalGoalManager.Instance.SaveGoalsToFile(r_FacebookManager.GetCurrentUserId());
            FormLogin loginForm = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();

            if (loginForm == null)
            {
                loginForm = new FormLogin();
            }

            loginForm.FormClosed += (s, args) => Application.Exit();

            loginForm.Show();
        }

        private void postsButton_Click(object sender, EventArgs e)
        {
            showPanel(panelPosts);
            new Thread(fetchPosts).Start(); 
        }

        private void fetchPosts()
        {
            var posts = r_FacebookManager.GetPosts();

            Invoke(new Action(() =>
            {
                listBoxPosts.Items.Clear();
                listBoxPosts.DisplayMember = "DisplayText";

                foreach (var post in posts)
                {
                    string displayText = $"{post.CreatedTime?.ToString("MM/dd/yyyy HH:mm")}: {post.Message ?? post.Caption ?? $"[{post.Type}]"}";
                    ComboBoxPostItem listBoxItem = new ComboBoxPostItem { Post = post, DisplayText = displayText };
                    listBoxPosts.Items.Add(listBoxItem);
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No posts to show :(");
                }
            }));
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem is ComboBoxPostItem selectedItem)
            {
                customRichTextBoxPostDetails.Visible = true;
                string message = selectedItem.Post.Message;
                string caption = selectedItem.Post.Caption;
                string type = selectedItem.Post.Type.ToString();

                string fullPostText = message ?? caption ?? $"[{type}]";
                customRichTextBoxPostDetails.SetText(fullPostText);

                if (selectedItem.Post.PictureURL != null)
                {
                    pictureBoxSelectedPost.Visible = true;
                    pictureBoxSelectedPost.LoadAsync(selectedItem.Post.PictureURL);
                }
                else
                {
                    pictureBoxSelectedPost.Visible = false;
                }
            }
        }

        private void pagesButton_Click(object sender, EventArgs e)
        {
            showPanel(panelPages);
            new Thread(fetchPages).Start(); 
        }

        private void fetchPages()
        {
            var pages = r_FacebookManager.GetLikedPages();

            Invoke(new Action(() =>
            {
                pageBindingSource.DataSource = pages;
                if (listBoxPages.Items.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }));
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxSelectedPage.LoadAsync(selectedPage.PictureNormalURL);
                pictureBoxSelectedPage.Visible = true;
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            showPanel(panelAlbums);
            new Thread(fetchAlbums).Start(); 
        }

        private void fetchAlbums()
        {
            var albums = r_FacebookManager.GetAlbums();

            Invoke(new Action(() =>
            {
                listBoxAlbums.Items.Clear();
                listBoxAlbums.DisplayMember = "Name";

                foreach (var album in albums)
                {
                    listBoxAlbums.Items.Add(album);
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }));
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    m_SelectedAlbum = selectedAlbum;
                    m_CurrentPhotoIndex = 0;

                    new Thread(loadPhotoAtCurrentIndex).Start(); // שימוש בפונקציה החיצונית עם thread נפרד
                }
                else
                {
                    pictureBoxImageUserTop.Image = pictureBoxImageUserTop.ErrorImage;
                }
            }
        }

        private void loadPhotoAtCurrentIndex()
        {
            if (m_SelectedAlbum.Photos.Count > 0 && m_CurrentPhotoIndex >= 0 && m_CurrentPhotoIndex < m_SelectedAlbum.Photos.Count)
            {
                var photoUrl = m_SelectedAlbum.Photos[m_CurrentPhotoIndex].PictureNormalURL;

                Invoke(new Action(() =>
                {
                    pictureBoxAlbums.LoadAsync(photoUrl);
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    pictureBoxAlbums.Image = null;
                }));
            }
        }

        private void buttonNextPhoto_Click(object sender, EventArgs e)
        {
            if (m_SelectedAlbum != null && m_CurrentPhotoIndex < m_SelectedAlbum.Photos.Count - 1)
            {
                m_CurrentPhotoIndex++;
                new Thread(loadPhotoAtCurrentIndex).Start(); 
            }
            else
            {
                MessageBox.Show("This is the last photo in the album.");
            }
        }

        private void buttonPrevPhoto_Click(object sender, EventArgs e)
        {
            if (m_SelectedAlbum != null && m_CurrentPhotoIndex > 0)
            {
                m_CurrentPhotoIndex--;
                new Thread(loadPhotoAtCurrentIndex).Start(); 
            }
            else
            {
                MessageBox.Show("This is the first photo in the album.");
            }
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            showPanel(panelGroups);
            new Thread(fetchGroups).Start(); 
        }

        private void fetchGroups()
        {
            var groups = r_FacebookManager.GetGroups();

            Invoke(new Action(() =>
            {
                listBoxGroups.Items.Clear();
                listBoxGroups.DisplayMember = "Name";

                foreach (var group in groups)
                {
                    listBoxGroups.Items.Add(group);
                }

                if (listBoxGroups.Items.Count == 0)
                {
                    MessageBox.Show("No groups to retrieve :(");
                }
            }));
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxSelectedGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void applyListBoxStyling(ListBox i_ListBox)
        {
            i_ListBox.BorderStyle = BorderStyle.None;
            i_ListBox.BackColor = Color.FromArgb(236, 240, 241);
            i_ListBox.ForeColor = Color.Black;
            i_ListBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            i_ListBox.ItemHeight = 50;

            i_ListBox.DrawMode = DrawMode.OwnerDrawFixed;
            i_ListBox.DrawItem += (sender, e) =>
            {
                e.DrawBackground();

                if (e.Index >= 0)
                {
                    var brush = new SolidBrush(e.ForeColor);
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        brush = new SolidBrush(Color.FromArgb(41, 128, 185));
                        e.Graphics.FillRectangle(brush, e.Bounds);
                        brush = new SolidBrush(Color.White);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(new SolidBrush(i_ListBox.BackColor), e.Bounds);
                    }

                    e.Graphics.DrawString(
                        i_ListBox.GetItemText(i_ListBox.Items[e.Index]),
                        e.Font,
                        brush,
                        e.Bounds.Left + 10,
                        e.Bounds.Top + 10);
                }

                e.DrawFocusRectangle();
            };
        }

        private void applyButtonStyling(Button i_Button)
        {
            i_Button.FlatStyle = FlatStyle.Flat;
            i_Button.FlatAppearance.BorderSize = 0;
            i_Button.BackColor = Color.FromArgb(66, 103, 178);
            i_Button.ForeColor = Color.White;
            i_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            i_Button.Cursor = Cursors.Hand;

            i_Button.Region = new Region(getRoundedRectanglePath(i_Button.ClientRectangle, 20));

            i_Button.MouseEnter += (sender, e) =>
            {
                i_Button.BackColor = Color.FromArgb(86, 123, 198);
            };

            i_Button.MouseLeave += (sender, e) =>
            {
                i_Button.BackColor = Color.FromArgb(66, 103, 178);
            };

            i_Button.MouseDown += (sender, e) =>
            {
                i_Button.BackColor = Color.FromArgb(46, 83, 158);
            };

            i_Button.MouseUp += (sender, e) =>
            {
                i_Button.BackColor = Color.FromArgb(86, 123, 198);
            };
        }

        private GraphicsPath getRoundedRectanglePath(Rectangle i_Rect, int i_Radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(i_Rect.X, i_Rect.Y, i_Radius, i_Radius, 180, 90);
            path.AddArc(i_Rect.Right - i_Radius, i_Rect.Y, i_Radius, i_Radius, 270, 90);
            path.AddArc(i_Rect.Right - i_Radius, i_Rect.Bottom - i_Radius, i_Radius, i_Radius, 0, 90);
            path.AddArc(i_Rect.X, i_Rect.Bottom - i_Radius, i_Radius, i_Radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void applyPictureBoxStyling(PictureBox i_PictureBox)
        {
            i_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            i_PictureBox.BackColor = Color.White;
            i_PictureBox.BorderStyle = BorderStyle.None;
            i_PictureBox.Paint += pictureBox_Paint;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                int cornerRadius = 20;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                    path.AddArc(pictureBox.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
                    path.AddArc(pictureBox.Width - cornerRadius * 2, pictureBox.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                    path.AddArc(0, pictureBox.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                    path.CloseFigure();

                    pictureBox.Region = new Region(path);

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.FromArgb(66, 103, 178), 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private void ButtonPersonalityAnalyzer_Click(object sender, EventArgs e)
        {
            showPanel(panelPersonalityInsights);
            customRichTextBoxPanelTopTopics.SetText("Analyzing data... Please wait.");
            Task.Run(() => showPersonalityInsights());
        }

        private void showPersonalityInsights()
        {
            Thread.Sleep(3000);
            PersonalityAnalyzer analyzer = new PersonalityAnalyzer(r_FacebookManager.LoginResult.LoggedInUser);
            PersonalityProfile profile = analyzer.AnalyzePersonality();

            Invoke(new Action(() =>
            {
                if (profile.TopTopics != null && profile.TopTopics.Any())
                {
                    customRichTextBoxPanelTopTopics.SetText(string.Join(Environment.NewLine, profile.TopTopics));
                }
                else
                {
                    customRichTextBoxPanelTopTopics.SetText("No significant topics found.");
                }

                progressBar1.Value = (int)(profile.SentimentScore * 100);
                labelSentimentScoreValue.Text = profile.SentimentScore.ToString("P");

                if (profile.MainInterests != null && profile.MainInterests.Any())
                {
                    customRichTextBoxPanelMainInterest.SetText(string.Join(Environment.NewLine, profile.MainInterests));
                }
                else
                {
                    customRichTextBoxPanelMainInterest.SetText("No main interests identified.");
                }

                labelMostActiveHour.Text = $"Most Active Hour: {profile.ActivityPattern.MostActiveHour}:00";
                labelPostFrequency.Text = $"Post Frequency: {profile.ActivityPattern.PostFrequency:F2} posts per day";

                labelTotalPhotos.Text = $"Total Photos: {profile.PhotoPreferences.TotalPhotos}";
                labelPhotosPerMonth.Text = $"Photos Per Month: {profile.PhotoPreferences.PhotosPerMonth:F2}";
                labelMostCommonPhotoType.Text = $"Most Common Photo Type: {profile.PhotoPreferences.MostCommonPhotoType}";
            }));
        }

        private void listBoxGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is PersonalGoal selectedGoal)
            {
                customTextBoxGoalName.Text = selectedGoal.Name;
                cmbCategory.SelectedItem = selectedGoal.Category;
                dtpTargetDate.Value = selectedGoal.TargetDate;
                progressBar.Value = selectedGoal.Progress;
                numericUpDownProgress.Value = selectedGoal.Progress;
                findRelevantPages(selectedGoal.Category);
            }
        }

        private void findRelevantPages(string i_Category)
        {
            var relevantPages = r_FacebookManager.SearchPages(i_Category);
            listBoxRelevantPages.Items.Clear();

            foreach (var page in relevantPages)
            {
                listBoxRelevantPages.Items.Add(page.Name);
            }
        }

        private void buttonAddGoal_Click(object sender, EventArgs e)
        {
            try
            {
                var newGoal = new PersonalGoal(
                    customTextBoxGoalName.Text,
                    cmbCategory.SelectedItem.ToString(),
                    dtpTargetDate.Value
                );
                int initialProgress = (int)numericUpDownProgress.Value;
                PersonalGoalManager.Instance.AddGoal(newGoal, initialProgress);
                listBoxGoals.Items.Add(newGoal);
                findRelevantPages(cmbCategory.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdateProgress_Click(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is PersonalGoal selectedGoal)
            {
                PersonalGoalManager.Instance.UpdateGoalProgress(selectedGoal, (int)numericUpDownProgress.Value);
                listBoxGoals.Items[listBoxGoals.SelectedIndex] = selectedGoal;
            }
            else
            {
                MessageBox.Show("Please select a goal to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanPanelGoals()
        {
            customTextBoxGoalName.Clear();
            progressBar.Value = 0;
            cmbCategory.SelectedIndex = 0;
            dtpTargetDate.Value = DateTime.Today;
            numericUpDownProgress.Value = 0;
            listBoxRelevantPages.Items.Clear();
            listBoxGoals.ClearSelected();
            listBoxGoals.Items.Clear();
        }

        private void buttonGoals_Click(object sender, EventArgs e)
        {
            initialPanelGoals();
            showPanel(panelGoals);
        }

        private void initialPanelGoals()
        {
            customTextBoxGoalName.Clear();
            cmbCategory.Items.AddRange(new string[]
            {
                "Learning",
                "Fitness",
                "Habits",
                "Other",
                "Health",
                "Work",
                "Travel",
                "Family",
                "Personal Development"
            });

            cleanPanelGoals();
            listBoxGoals.DisplayMember = "Name";

            foreach (var goal in PersonalGoalManager.Instance.Goals)
            {
                listBoxGoals.Items.Add(goal);
            }
        }

        private void buttonShareGoal_Click(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is PersonalGoal selectedGoal)
            {
                string goalText = $"I'm working on my goal: {selectedGoal.Name} in the category of {selectedGoal.Category}. I've made {selectedGoal.Progress}% progress so far!";

                try
                {
                    r_FacebookManager.PostStatus(goalText);
                    MessageBox.Show("Goal shared successfully on Facebook!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to share the goal on Facebook. But keep up the great work! Remember, every step you take is a step closer to achieving your dreams. 💪\n\nError: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a goal to share.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearDetails_Click(object sender, EventArgs e)
        {
            cleanPanelGoals();
            initialPanelGoals();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is PersonalGoal selectedGoal)
            {
                PersonalGoalManager.Instance.RemoveGoal(selectedGoal);
                cleanPanelGoals();
                MessageBox.Show("Goal removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a goal to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownProgress_ValueChanged_1(object sender, EventArgs e)
        {
            progressBar.Value = (int)numericUpDownProgress.Value;
        }
    }
}
