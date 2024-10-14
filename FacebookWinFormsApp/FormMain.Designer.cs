using BasicFacebookFeatures.Properties;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxImageUserTop = new System.Windows.Forms.PictureBox();
            this.imageFacebook = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelNewPost = new System.Windows.Forms.Panel();
            this.pictureBoxImageUser = new System.Windows.Forms.PictureBox();
            this.customRichTextBoxPanelNewPost = new BasicFacebookFeatures.CustomRichTextBoxPanel();
            this.buttonPost = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.postsButton = new System.Windows.Forms.Button();
            this.pagesButton = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.ButtonPersonalityAnalyzer = new System.Windows.Forms.Button();
            this.buttonGoals = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelPages = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxSelectedPage = new System.Windows.Forms.PictureBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.panelGoals = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCleanDetails = new System.Windows.Forms.Button();
            this.listBoxRelevantPages = new System.Windows.Forms.ListBox();
            this.labelRelevantPages = new System.Windows.Forms.Label();
            this.buttonShareGoal = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownProgress = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxGoals = new System.Windows.Forms.ListBox();
            this.buttonAddGoal = new System.Windows.Forms.Button();
            this.buttonUpdateProgress = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTargetDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customTextBoxGoalName = new BasicFacebookFeatures.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelPersonalityInsights = new System.Windows.Forms.Panel();
            this.pictureBoxActivityPattern = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhotoPreferences = new System.Windows.Forms.PictureBox();
            this.pictureBoxMainInterest = new System.Windows.Forms.PictureBox();
            this.pictureBoxTopTopic = new System.Windows.Forms.PictureBox();
            this.pictureBoxSentimentScore = new System.Windows.Forms.PictureBox();
            this.labelMostCommonPhotoType = new System.Windows.Forms.Label();
            this.labelPostFrequency = new System.Windows.Forms.Label();
            this.labelTotalPhotos = new System.Windows.Forms.Label();
            this.labelPhotosPerMonth = new System.Windows.Forms.Label();
            this.labelMostActiveHour = new System.Windows.Forms.Label();
            this.customRichTextBoxPanelMainInterest = new BasicFacebookFeatures.CustomRichTextBoxPanel();
            this.labelSentimentScoreValue = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.customRichTextBoxPanelTopTopics = new BasicFacebookFeatures.CustomRichTextBoxPanel();
            this.labelPersonalityInsight = new System.Windows.Forms.Label();
            this.labelPhotoPreferences = new System.Windows.Forms.Label();
            this.labelActivityPattern = new System.Windows.Forms.Label();
            this.labelMainInterests = new System.Windows.Forms.Label();
            this.labelSentimentScore = new System.Windows.Forms.Label();
            this.labelTopTopics = new System.Windows.Forms.Label();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSelectedGroup = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelGroups = new System.Windows.Forms.Label();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonNextPhoto = new System.Windows.Forms.Button();
            this.buttonPrevPhoto = new System.Windows.Forms.Button();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.customRichTextBoxPostDetails = new BasicFacebookFeatures.CustomRichTextBoxPanel();
            this.labelShowPosts = new System.Windows.Forms.Label();
            this.pictureBoxSelectedPost = new System.Windows.Forms.PictureBox();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelPersonalityInsights = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUserTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFacebook)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelNewPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUser)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.menu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPage)).BeginInit();
            this.panelGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProgress)).BeginInit();
            this.panelPersonalityInsights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivityPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoPreferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSentimentScore)).BeginInit();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedGroup)).BeginInit();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            this.panelPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPost)).BeginInit();
            this.SuspendLayout();
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.labelWelcome);
            this.panelTop.Controls.Add(this.pictureBoxImageUserTop);
            this.panelTop.Controls.Add(this.imageFacebook);
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(909, 51);
            this.panelTop.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelWelcome.Location = new System.Drawing.Point(421, 17);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(85, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "label1";
            // 
            // pictureBoxImageUserTop
            // 
            this.pictureBoxImageUserTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImageUserTop.InitialImage = global::BasicFacebookFeatures.Properties.Resources.user;
            this.pictureBoxImageUserTop.Location = new System.Drawing.Point(858, 5);
            this.pictureBoxImageUserTop.Name = "pictureBoxImageUserTop";
            this.pictureBoxImageUserTop.Size = new System.Drawing.Size(46, 41);
            this.pictureBoxImageUserTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageUserTop.TabIndex = 21;
            this.pictureBoxImageUserTop.TabStop = false;
            this.pictureBoxImageUserTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxImageUser_Paint);
            // 
            // imageFacebook
            // 
            this.imageFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.facebook;
            this.imageFacebook.Location = new System.Drawing.Point(18, 10);
            this.imageFacebook.Margin = new System.Windows.Forms.Padding(2);
            this.imageFacebook.Name = "imageFacebook";
            this.imageFacebook.Size = new System.Drawing.Size(27, 23);
            this.imageFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageFacebook.TabIndex = 3;
            this.imageFacebook.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.labelHeader.Location = new System.Drawing.Point(52, 10);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(97, 25);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Facebook";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelNewPost);
            this.panelMain.Controls.Add(this.panelSidebar);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 51);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(909, 597);
            this.panelMain.TabIndex = 1;
            // 
            // panelNewPost
            // 
            this.panelNewPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNewPost.BackColor = System.Drawing.Color.White;
            this.panelNewPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNewPost.Controls.Add(this.pictureBoxImageUser);
            this.panelNewPost.Controls.Add(this.customRichTextBoxPanelNewPost);
            this.panelNewPost.Controls.Add(this.buttonPost);
            this.panelNewPost.Location = new System.Drawing.Point(171, 1);
            this.panelNewPost.Margin = new System.Windows.Forms.Padding(2);
            this.panelNewPost.Name = "panelNewPost";
            this.panelNewPost.Size = new System.Drawing.Size(736, 140);
            this.panelNewPost.TabIndex = 33;
            // 
            // pictureBoxImageUser
            // 
            this.pictureBoxImageUser.InitialImage = global::BasicFacebookFeatures.Properties.Resources.user;
            this.pictureBoxImageUser.Location = new System.Drawing.Point(55, 26);
            this.pictureBoxImageUser.Name = "pictureBoxImageUser";
            this.pictureBoxImageUser.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageUser.TabIndex = 10;
            this.pictureBoxImageUser.TabStop = false;
            this.pictureBoxImageUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxImageUser_Paint);
            // 
            // customRichTextBoxPanelNewPost
            // 
            this.customRichTextBoxPanelNewPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customRichTextBoxPanelNewPost.ForeColor = System.Drawing.Color.CadetBlue;
            this.customRichTextBoxPanelNewPost.Location = new System.Drawing.Point(191, 23);
            this.customRichTextBoxPanelNewPost.Name = "customRichTextBoxPanelNewPost";
            this.customRichTextBoxPanelNewPost.Padding = new System.Windows.Forms.Padding(15);
            this.customRichTextBoxPanelNewPost.PlaceholderText = "What\'s on your mind?";
            this.customRichTextBoxPanelNewPost.RichTextBoxFont = new System.Drawing.Font("Segoe UI", 12F);
            this.customRichTextBoxPanelNewPost.Size = new System.Drawing.Size(495, 53);
            this.customRichTextBoxPanelNewPost.TabIndex = 9;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPost.ForeColor = System.Drawing.Color.Black;
            this.buttonPost.Image = global::BasicFacebookFeatures.Properties.Resources.publish;
            this.buttonPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPost.Location = new System.Drawing.Point(613, 100);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Padding = new System.Windows.Forms.Padding(2);
            this.buttonPost.Size = new System.Drawing.Size(80, 31);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panelSidebar.Controls.Add(this.menu);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(167, 597);
            this.panelSidebar.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu.Controls.Add(this.postsButton);
            this.menu.Controls.Add(this.pagesButton);
            this.menu.Controls.Add(this.buttonAlbums);
            this.menu.Controls.Add(this.groupsButton);
            this.menu.Controls.Add(this.ButtonPersonalityAnalyzer);
            this.menu.Controls.Add(this.buttonGoals);
            this.menu.Controls.Add(this.buttonLogout);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(2);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.menu.Size = new System.Drawing.Size(167, 597);
            this.menu.TabIndex = 12;
            // 
            // postsButton
            // 
            this.postsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.postsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.postsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.postsButton.ForeColor = System.Drawing.Color.Black;
            this.postsButton.Image = global::BasicFacebookFeatures.Properties.Resources.post;
            this.postsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postsButton.Location = new System.Drawing.Point(9, 8);
            this.postsButton.Margin = new System.Windows.Forms.Padding(2);
            this.postsButton.Name = "postsButton";
            this.postsButton.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.postsButton.Size = new System.Drawing.Size(149, 40);
            this.postsButton.TabIndex = 16;
            this.postsButton.Text = "Posts";
            this.postsButton.UseVisualStyleBackColor = false;
            this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
            // 
            // pagesButton
            // 
            this.pagesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.pagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pagesButton.ForeColor = System.Drawing.Color.Black;
            this.pagesButton.Image = global::BasicFacebookFeatures.Properties.Resources.pages;
            this.pagesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagesButton.Location = new System.Drawing.Point(9, 52);
            this.pagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.pagesButton.Name = "pagesButton";
            this.pagesButton.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pagesButton.Size = new System.Drawing.Size(149, 40);
            this.pagesButton.TabIndex = 14;
            this.pagesButton.Text = "Pages";
            this.pagesButton.UseVisualStyleBackColor = false;
            this.pagesButton.Click += new System.EventHandler(this.pagesButton_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonAlbums.ForeColor = System.Drawing.Color.Black;
            this.buttonAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.album;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(9, 96);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonAlbums.Size = new System.Drawing.Size(149, 40);
            this.buttonAlbums.TabIndex = 19;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupsButton.ForeColor = System.Drawing.Color.Black;
            this.groupsButton.Image = global::BasicFacebookFeatures.Properties.Resources.groups;
            this.groupsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsButton.Location = new System.Drawing.Point(9, 140);
            this.groupsButton.Margin = new System.Windows.Forms.Padding(2);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.groupsButton.Size = new System.Drawing.Size(149, 40);
            this.groupsButton.TabIndex = 15;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // ButtonPersonalityAnalyzer
            // 
            this.ButtonPersonalityAnalyzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonPersonalityAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPersonalityAnalyzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonPersonalityAnalyzer.ForeColor = System.Drawing.Color.Black;
            this.ButtonPersonalityAnalyzer.Image = global::BasicFacebookFeatures.Properties.Resources.recruitment;
            this.ButtonPersonalityAnalyzer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPersonalityAnalyzer.Location = new System.Drawing.Point(9, 184);
            this.ButtonPersonalityAnalyzer.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPersonalityAnalyzer.Name = "ButtonPersonalityAnalyzer";
            this.ButtonPersonalityAnalyzer.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ButtonPersonalityAnalyzer.Size = new System.Drawing.Size(149, 40);
            this.ButtonPersonalityAnalyzer.TabIndex = 17;
            this.ButtonPersonalityAnalyzer.Text = " Insights";
            this.ButtonPersonalityAnalyzer.UseVisualStyleBackColor = false;
            this.ButtonPersonalityAnalyzer.Click += new System.EventHandler(this.ButtonPersonalityAnalyzer_Click);
            // 
            // buttonGoals
            // 
            this.buttonGoals.AutoSize = true;
            this.buttonGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonGoals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonGoals.ForeColor = System.Drawing.Color.Black;
            this.buttonGoals.Image = global::BasicFacebookFeatures.Properties.Resources.leadership;
            this.buttonGoals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoals.Location = new System.Drawing.Point(9, 228);
            this.buttonGoals.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoals.Name = "buttonGoals";
            this.buttonGoals.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonGoals.Size = new System.Drawing.Size(149, 40);
            this.buttonGoals.TabIndex = 21;
            this.buttonGoals.Text = "Goals";
            this.buttonGoals.UseVisualStyleBackColor = false;
            this.buttonGoals.Click += new System.EventHandler(this.buttonGoals_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Image = global::BasicFacebookFeatures.Properties.Resources.logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(9, 272);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(149, 40);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelPages);
            this.panelContent.Controls.Add(this.panelGoals);
            this.panelContent.Controls.Add(this.panelPersonalityInsights);
            this.panelContent.Controls.Add(this.panelGroups);
            this.panelContent.Controls.Add(this.panelAlbums);
            this.panelContent.Controls.Add(this.panelPosts);
            this.panelContent.Location = new System.Drawing.Point(171, 148);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(738, 457);
            this.panelContent.TabIndex = 1;
            // 
            // panelPages
            // 
            this.panelPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPages.AutoSize = true;
            this.panelPages.BackColor = System.Drawing.Color.White;
            this.panelPages.Controls.Add(this.pictureBox9);
            this.panelPages.Controls.Add(this.pictureBox8);
            this.panelPages.Controls.Add(this.listBoxPages);
            this.panelPages.Controls.Add(this.pictureBoxSelectedPage);
            this.panelPages.Controls.Add(this.labelPages);
            this.panelPages.ForeColor = System.Drawing.Color.White;
            this.panelPages.Location = new System.Drawing.Point(0, 0);
            this.panelPages.Margin = new System.Windows.Forms.Padding(2);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(821, 521);
            this.panelPages.TabIndex = 35;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::BasicFacebookFeatures.Properties.Resources.landing_page;
            this.pictureBox9.Location = new System.Drawing.Point(616, 14);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(87, 79);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::BasicFacebookFeatures.Properties.Resources.landing_page__1_;
            this.pictureBox8.Location = new System.Drawing.Point(113, 8);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(44, 41);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.DisplayMember = "Name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(16, 63);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(296, 290);
            this.listBoxPages.TabIndex = 3;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureBoxSelectedPage
            // 
            this.pictureBoxSelectedPage.Location = new System.Drawing.Point(327, 88);
            this.pictureBoxSelectedPage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSelectedPage.Name = "pictureBoxSelectedPage";
            this.pictureBoxSelectedPage.Size = new System.Drawing.Size(219, 241);
            this.pictureBoxSelectedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedPage.TabIndex = 2;
            this.pictureBoxSelectedPage.TabStop = false;
            this.pictureBoxSelectedPage.Visible = false;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPages.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPages.Location = new System.Drawing.Point(13, 13);
            this.labelPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(90, 30);
            this.labelPages.TabIndex = 0;
            this.labelPages.Text = "Pages";
            // 
            // panelGoals
            // 
            this.panelGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGoals.AutoSize = true;
            this.panelGoals.Controls.Add(this.buttonRemove);
            this.panelGoals.Controls.Add(this.buttonCleanDetails);
            this.panelGoals.Controls.Add(this.listBoxRelevantPages);
            this.panelGoals.Controls.Add(this.labelRelevantPages);
            this.panelGoals.Controls.Add(this.buttonShareGoal);
            this.panelGoals.Controls.Add(this.pictureBox3);
            this.panelGoals.Controls.Add(this.pictureBox2);
            this.panelGoals.Controls.Add(this.label9);
            this.panelGoals.Controls.Add(this.numericUpDownProgress);
            this.panelGoals.Controls.Add(this.label8);
            this.panelGoals.Controls.Add(this.listBoxGoals);
            this.panelGoals.Controls.Add(this.buttonAddGoal);
            this.panelGoals.Controls.Add(this.buttonUpdateProgress);
            this.panelGoals.Controls.Add(this.progressBar);
            this.panelGoals.Controls.Add(this.label7);
            this.panelGoals.Controls.Add(this.dtpTargetDate);
            this.panelGoals.Controls.Add(this.label6);
            this.panelGoals.Controls.Add(this.cmbCategory);
            this.panelGoals.Controls.Add(this.label5);
            this.panelGoals.Controls.Add(this.customTextBoxGoalName);
            this.panelGoals.Controls.Add(this.label3);
            this.panelGoals.Controls.Add(this.label4);
            this.panelGoals.Controls.Add(this.labelTitle);
            this.panelGoals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGoals.Location = new System.Drawing.Point(0, 0);
            this.panelGoals.Name = "panelGoals";
            this.panelGoals.Size = new System.Drawing.Size(732, 457);
            this.panelGoals.TabIndex = 7;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemove.Location = new System.Drawing.Point(478, 232);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCleanDetails
            // 
            this.buttonCleanDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCleanDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCleanDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanDetails.ForeColor = System.Drawing.Color.White;
            this.buttonCleanDetails.Location = new System.Drawing.Point(216, 378);
            this.buttonCleanDetails.Name = "buttonCleanDetails";
            this.buttonCleanDetails.Size = new System.Drawing.Size(112, 23);
            this.buttonCleanDetails.TabIndex = 21;
            this.buttonCleanDetails.Text = "Clean Details";
            this.buttonCleanDetails.UseVisualStyleBackColor = false;
            this.buttonCleanDetails.Click += new System.EventHandler(this.buttonClearDetails_Click);
            // 
            // listBoxRelevantPages
            // 
            this.listBoxRelevantPages.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRelevantPages.FormattingEnabled = true;
            this.listBoxRelevantPages.ItemHeight = 16;
            this.listBoxRelevantPages.Location = new System.Drawing.Point(485, 273);
            this.listBoxRelevantPages.Name = "listBoxRelevantPages";
            this.listBoxRelevantPages.Size = new System.Drawing.Size(170, 132);
            this.listBoxRelevantPages.TabIndex = 20;
            // 
            // labelRelevantPages
            // 
            this.labelRelevantPages.AutoSize = true;
            this.labelRelevantPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelevantPages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRelevantPages.Location = new System.Drawing.Point(357, 276);
            this.labelRelevantPages.Name = "labelRelevantPages";
            this.labelRelevantPages.Size = new System.Drawing.Size(122, 16);
            this.labelRelevantPages.TabIndex = 19;
            this.labelRelevantPages.Text = "Relevant Pages:";
            // 
            // buttonShareGoal
            // 
            this.buttonShareGoal.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonShareGoal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShareGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShareGoal.Location = new System.Drawing.Point(564, 232);
            this.buttonShareGoal.Name = "buttonShareGoal";
            this.buttonShareGoal.Size = new System.Drawing.Size(91, 23);
            this.buttonShareGoal.TabIndex = 18;
            this.buttonShareGoal.Text = "Share Goal";
            this.buttonShareGoal.UseVisualStyleBackColor = false;
            this.buttonShareGoal.Click += new System.EventHandler(this.buttonShareGoal_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BasicFacebookFeatures.Properties.Resources.goals;
            this.pictureBox3.Location = new System.Drawing.Point(518, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BasicFacebookFeatures.Properties.Resources.leadership__1_;
            this.pictureBox2.Location = new System.Drawing.Point(617, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(25, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Select Progress Amount:";
            // 
            // numericUpDownProgress
            // 
            this.numericUpDownProgress.Location = new System.Drawing.Point(225, 284);
            this.numericUpDownProgress.Name = "numericUpDownProgress";
            this.numericUpDownProgress.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownProgress.TabIndex = 14;
            this.numericUpDownProgress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProgress.ValueChanged += new System.EventHandler(this.numericUpDownProgress_ValueChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(355, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Your Goals:";
            // 
            // listBoxGoals
            // 
            this.listBoxGoals.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGoals.FormattingEnabled = true;
            this.listBoxGoals.ItemHeight = 16;
            this.listBoxGoals.Location = new System.Drawing.Point(478, 84);
            this.listBoxGoals.Name = "listBoxGoals";
            this.listBoxGoals.Size = new System.Drawing.Size(177, 132);
            this.listBoxGoals.TabIndex = 12;
            this.listBoxGoals.SelectedIndexChanged += new System.EventHandler(this.listBoxGoals_SelectedIndexChanged);
            // 
            // buttonAddGoal
            // 
            this.buttonAddGoal.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddGoal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGoal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddGoal.Location = new System.Drawing.Point(253, 328);
            this.buttonAddGoal.Name = "buttonAddGoal";
            this.buttonAddGoal.Size = new System.Drawing.Size(75, 25);
            this.buttonAddGoal.TabIndex = 11;
            this.buttonAddGoal.Text = "Add Goal";
            this.buttonAddGoal.UseVisualStyleBackColor = false;
            this.buttonAddGoal.Click += new System.EventHandler(this.buttonAddGoal_Click);
            // 
            // buttonUpdateProgress
            // 
            this.buttonUpdateProgress.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdateProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdateProgress.Location = new System.Drawing.Point(100, 328);
            this.buttonUpdateProgress.Name = "buttonUpdateProgress";
            this.buttonUpdateProgress.Size = new System.Drawing.Size(127, 25);
            this.buttonUpdateProgress.TabIndex = 10;
            this.buttonUpdateProgress.Text = "Update Progress";
            this.buttonUpdateProgress.UseVisualStyleBackColor = false;
            this.buttonUpdateProgress.Click += new System.EventHandler(this.buttonUpdateProgress_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.SteelBlue;
            this.progressBar.Location = new System.Drawing.Point(134, 236);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(179, 23);
            this.progressBar.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Progress: ";
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.Location = new System.Drawing.Point(135, 195);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(198, 20);
            this.dtpTargetDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Target Date:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(135, 139);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(178, 24);
            this.cmbCategory.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category: ";
            // 
            // customTextBoxGoalName
            // 
            this.customTextBoxGoalName.Location = new System.Drawing.Point(136, 92);
            this.customTextBoxGoalName.Name = "customTextBoxGoalName";
            this.customTextBoxGoalName.PlaceholderText = null;
            this.customTextBoxGoalName.Size = new System.Drawing.Size(178, 20);
            this.customTextBoxGoalName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Goal Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Set and Track Your Personal Goals";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTitle.Location = new System.Drawing.Point(18, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Personal Goal Tracker";
            // 
            // panelPersonalityInsights
            // 
            this.panelPersonalityInsights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPersonalityInsights.AutoSize = true;
            this.panelPersonalityInsights.BackColor = System.Drawing.Color.White;
            this.panelPersonalityInsights.Controls.Add(this.pictureBoxActivityPattern);
            this.panelPersonalityInsights.Controls.Add(this.pictureBoxPhotoPreferences);
            this.panelPersonalityInsights.Controls.Add(this.pictureBoxMainInterest);
            this.panelPersonalityInsights.Controls.Add(this.pictureBoxTopTopic);
            this.panelPersonalityInsights.Controls.Add(this.pictureBoxSentimentScore);
            this.panelPersonalityInsights.Controls.Add(this.labelMostCommonPhotoType);
            this.panelPersonalityInsights.Controls.Add(this.labelPostFrequency);
            this.panelPersonalityInsights.Controls.Add(this.labelTotalPhotos);
            this.panelPersonalityInsights.Controls.Add(this.labelPhotosPerMonth);
            this.panelPersonalityInsights.Controls.Add(this.labelMostActiveHour);
            this.panelPersonalityInsights.Controls.Add(this.customRichTextBoxPanelMainInterest);
            this.panelPersonalityInsights.Controls.Add(this.labelSentimentScoreValue);
            this.panelPersonalityInsights.Controls.Add(this.progressBar1);
            this.panelPersonalityInsights.Controls.Add(this.customRichTextBoxPanelTopTopics);
            this.panelPersonalityInsights.Controls.Add(this.labelPersonalityInsight);
            this.panelPersonalityInsights.Controls.Add(this.labelPhotoPreferences);
            this.panelPersonalityInsights.Controls.Add(this.labelActivityPattern);
            this.panelPersonalityInsights.Controls.Add(this.labelMainInterests);
            this.panelPersonalityInsights.Controls.Add(this.labelSentimentScore);
            this.panelPersonalityInsights.Controls.Add(this.labelTopTopics);
            this.panelPersonalityInsights.ForeColor = System.Drawing.Color.White;
            this.panelPersonalityInsights.Location = new System.Drawing.Point(0, 0);
            this.panelPersonalityInsights.Margin = new System.Windows.Forms.Padding(2);
            this.panelPersonalityInsights.Name = "panelPersonalityInsights";
            this.panelPersonalityInsights.Size = new System.Drawing.Size(738, 535);
            this.panelPersonalityInsights.TabIndex = 4;
            this.panelPersonalityInsights.Visible = false;
            // 
            // pictureBoxActivityPattern
            // 
            this.pictureBoxActivityPattern.Image = global::BasicFacebookFeatures.Properties.Resources.to_do_list;
            this.pictureBoxActivityPattern.Location = new System.Drawing.Point(551, 188);
            this.pictureBoxActivityPattern.Name = "pictureBoxActivityPattern";
            this.pictureBoxActivityPattern.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxActivityPattern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxActivityPattern.TabIndex = 24;
            this.pictureBoxActivityPattern.TabStop = false;
            // 
            // pictureBoxPhotoPreferences
            // 
            this.pictureBoxPhotoPreferences.Image = global::BasicFacebookFeatures.Properties.Resources.gallery;
            this.pictureBoxPhotoPreferences.Location = new System.Drawing.Point(554, 63);
            this.pictureBoxPhotoPreferences.Name = "pictureBoxPhotoPreferences";
            this.pictureBoxPhotoPreferences.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxPhotoPreferences.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoPreferences.TabIndex = 23;
            this.pictureBoxPhotoPreferences.TabStop = false;
            // 
            // pictureBoxMainInterest
            // 
            this.pictureBoxMainInterest.Image = global::BasicFacebookFeatures.Properties.Resources.mental_health;
            this.pictureBoxMainInterest.Location = new System.Drawing.Point(215, 268);
            this.pictureBoxMainInterest.Name = "pictureBoxMainInterest";
            this.pictureBoxMainInterest.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxMainInterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainInterest.TabIndex = 22;
            this.pictureBoxMainInterest.TabStop = false;
            // 
            // pictureBoxTopTopic
            // 
            this.pictureBoxTopTopic.Image = global::BasicFacebookFeatures.Properties.Resources.chat;
            this.pictureBoxTopTopic.Location = new System.Drawing.Point(215, 79);
            this.pictureBoxTopTopic.Name = "pictureBoxTopTopic";
            this.pictureBoxTopTopic.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxTopTopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTopTopic.TabIndex = 21;
            this.pictureBoxTopTopic.TabStop = false;
            // 
            // pictureBoxSentimentScore
            // 
            this.pictureBoxSentimentScore.Image = global::BasicFacebookFeatures.Properties.Resources.satisfaction;
            this.pictureBoxSentimentScore.Location = new System.Drawing.Point(202, 188);
            this.pictureBoxSentimentScore.Name = "pictureBoxSentimentScore";
            this.pictureBoxSentimentScore.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxSentimentScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSentimentScore.TabIndex = 20;
            this.pictureBoxSentimentScore.TabStop = false;
            // 
            // labelMostCommonPhotoType
            // 
            this.labelMostCommonPhotoType.AutoSize = true;
            this.labelMostCommonPhotoType.BackColor = System.Drawing.Color.White;
            this.labelMostCommonPhotoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostCommonPhotoType.ForeColor = System.Drawing.Color.Black;
            this.labelMostCommonPhotoType.Location = new System.Drawing.Point(378, 137);
            this.labelMostCommonPhotoType.Name = "labelMostCommonPhotoType";
            this.labelMostCommonPhotoType.Size = new System.Drawing.Size(158, 13);
            this.labelMostCommonPhotoType.TabIndex = 19;
            this.labelMostCommonPhotoType.Text = "Most Common Photo Type:";
            // 
            // labelPostFrequency
            // 
            this.labelPostFrequency.AutoSize = true;
            this.labelPostFrequency.BackColor = System.Drawing.Color.White;
            this.labelPostFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostFrequency.ForeColor = System.Drawing.Color.Black;
            this.labelPostFrequency.Location = new System.Drawing.Point(374, 242);
            this.labelPostFrequency.Name = "labelPostFrequency";
            this.labelPostFrequency.Size = new System.Drawing.Size(99, 13);
            this.labelPostFrequency.TabIndex = 18;
            this.labelPostFrequency.Text = "Post Frequency:";
            // 
            // labelTotalPhotos
            // 
            this.labelTotalPhotos.AutoSize = true;
            this.labelTotalPhotos.BackColor = System.Drawing.Color.White;
            this.labelTotalPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPhotos.ForeColor = System.Drawing.Color.Black;
            this.labelTotalPhotos.Location = new System.Drawing.Point(375, 73);
            this.labelTotalPhotos.Name = "labelTotalPhotos";
            this.labelTotalPhotos.Size = new System.Drawing.Size(83, 13);
            this.labelTotalPhotos.TabIndex = 17;
            this.labelTotalPhotos.Text = "Total Photos:";
            this.labelTotalPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhotosPerMonth
            // 
            this.labelPhotosPerMonth.AutoSize = true;
            this.labelPhotosPerMonth.BackColor = System.Drawing.Color.White;
            this.labelPhotosPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotosPerMonth.ForeColor = System.Drawing.Color.Black;
            this.labelPhotosPerMonth.Location = new System.Drawing.Point(374, 105);
            this.labelPhotosPerMonth.Name = "labelPhotosPerMonth";
            this.labelPhotosPerMonth.Size = new System.Drawing.Size(118, 13);
            this.labelPhotosPerMonth.TabIndex = 15;
            this.labelPhotosPerMonth.Text = "Phostos Per Month:";
            this.labelPhotosPerMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMostActiveHour
            // 
            this.labelMostActiveHour.AutoSize = true;
            this.labelMostActiveHour.BackColor = System.Drawing.Color.White;
            this.labelMostActiveHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostActiveHour.ForeColor = System.Drawing.Color.Black;
            this.labelMostActiveHour.Location = new System.Drawing.Point(375, 206);
            this.labelMostActiveHour.Name = "labelMostActiveHour";
            this.labelMostActiveHour.Size = new System.Drawing.Size(109, 13);
            this.labelMostActiveHour.TabIndex = 14;
            this.labelMostActiveHour.Text = "Most Active Hour:";
            // 
            // customRichTextBoxPanelMainInterest
            // 
            this.customRichTextBoxPanelMainInterest.Location = new System.Drawing.Point(27, 268);
            this.customRichTextBoxPanelMainInterest.Name = "customRichTextBoxPanelMainInterest";
            this.customRichTextBoxPanelMainInterest.Padding = new System.Windows.Forms.Padding(15);
            this.customRichTextBoxPanelMainInterest.PlaceholderText = null;
            this.customRichTextBoxPanelMainInterest.RichTextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRichTextBoxPanelMainInterest.Size = new System.Drawing.Size(169, 71);
            this.customRichTextBoxPanelMainInterest.TabIndex = 12;
            // 
            // labelSentimentScoreValue
            // 
            this.labelSentimentScoreValue.AutoSize = true;
            this.labelSentimentScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.labelSentimentScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentScoreValue.ForeColor = System.Drawing.Color.Black;
            this.labelSentimentScoreValue.Location = new System.Drawing.Point(155, 212);
            this.labelSentimentScoreValue.Name = "labelSentimentScoreValue";
            this.labelSentimentScoreValue.Size = new System.Drawing.Size(41, 13);
            this.labelSentimentScoreValue.TabIndex = 13;
            this.labelSentimentScoreValue.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 24);
            this.progressBar1.TabIndex = 12;
            // 
            // customRichTextBoxPanelTopTopics
            // 
            this.customRichTextBoxPanelTopTopics.Location = new System.Drawing.Point(27, 79);
            this.customRichTextBoxPanelTopTopics.Name = "customRichTextBoxPanelTopTopics";
            this.customRichTextBoxPanelTopTopics.Padding = new System.Windows.Forms.Padding(15);
            this.customRichTextBoxPanelTopTopics.PlaceholderText = null;
            this.customRichTextBoxPanelTopTopics.RichTextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRichTextBoxPanelTopTopics.Size = new System.Drawing.Size(169, 71);
            this.customRichTextBoxPanelTopTopics.TabIndex = 11;
            // 
            // labelPersonalityInsight
            // 
            this.labelPersonalityInsight.AutoSize = true;
            this.labelPersonalityInsight.BackColor = System.Drawing.Color.White;
            this.labelPersonalityInsight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalityInsight.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPersonalityInsight.Location = new System.Drawing.Point(15, 8);
            this.labelPersonalityInsight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPersonalityInsight.Name = "labelPersonalityInsight";
            this.labelPersonalityInsight.Size = new System.Drawing.Size(248, 26);
            this.labelPersonalityInsight.TabIndex = 10;
            this.labelPersonalityInsight.Text = "Personality Insights";
            // 
            // labelPhotoPreferences
            // 
            this.labelPhotoPreferences.AutoSize = true;
            this.labelPhotoPreferences.BackColor = System.Drawing.Color.Transparent;
            this.labelPhotoPreferences.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoPreferences.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPhotoPreferences.Location = new System.Drawing.Point(370, 47);
            this.labelPhotoPreferences.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhotoPreferences.Name = "labelPhotoPreferences";
            this.labelPhotoPreferences.Size = new System.Drawing.Size(157, 19);
            this.labelPhotoPreferences.TabIndex = 8;
            this.labelPhotoPreferences.Text = "Photo Preferences";
            // 
            // labelActivityPattern
            // 
            this.labelActivityPattern.AutoSize = true;
            this.labelActivityPattern.BackColor = System.Drawing.Color.White;
            this.labelActivityPattern.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivityPattern.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelActivityPattern.Location = new System.Drawing.Point(370, 173);
            this.labelActivityPattern.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivityPattern.Name = "labelActivityPattern";
            this.labelActivityPattern.Size = new System.Drawing.Size(142, 19);
            this.labelActivityPattern.TabIndex = 6;
            this.labelActivityPattern.Text = "Activity Pattern";
            // 
            // labelMainInterests
            // 
            this.labelMainInterests.AutoSize = true;
            this.labelMainInterests.BackColor = System.Drawing.Color.White;
            this.labelMainInterests.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainInterests.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelMainInterests.Location = new System.Drawing.Point(20, 238);
            this.labelMainInterests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainInterests.Name = "labelMainInterests";
            this.labelMainInterests.Size = new System.Drawing.Size(126, 19);
            this.labelMainInterests.TabIndex = 4;
            this.labelMainInterests.Text = "Main Interests";
            // 
            // labelSentimentScore
            // 
            this.labelSentimentScore.AutoSize = true;
            this.labelSentimentScore.BackColor = System.Drawing.Color.White;
            this.labelSentimentScore.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelSentimentScore.Location = new System.Drawing.Point(17, 173);
            this.labelSentimentScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSentimentScore.Name = "labelSentimentScore";
            this.labelSentimentScore.Size = new System.Drawing.Size(141, 19);
            this.labelSentimentScore.TabIndex = 2;
            this.labelSentimentScore.Text = "Sentiment Score\r\n";
            // 
            // labelTopTopics
            // 
            this.labelTopTopics.AutoSize = true;
            this.labelTopTopics.BackColor = System.Drawing.Color.White;
            this.labelTopTopics.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopTopics.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTopTopics.Location = new System.Drawing.Point(18, 45);
            this.labelTopTopics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTopTopics.Name = "labelTopTopics";
            this.labelTopTopics.Size = new System.Drawing.Size(99, 19);
            this.labelTopTopics.TabIndex = 0;
            this.labelTopTopics.Text = "Top Topics";
            // 
            // panelGroups
            // 
            this.panelGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroups.BackColor = System.Drawing.Color.White;
            this.panelGroups.Controls.Add(this.pictureBox11);
            this.panelGroups.Controls.Add(this.pictureBox10);
            this.panelGroups.Controls.Add(this.pictureBoxSelectedGroup);
            this.panelGroups.Controls.Add(this.listBoxGroups);
            this.panelGroups.Controls.Add(this.labelGroups);
            this.panelGroups.ForeColor = System.Drawing.Color.White;
            this.panelGroups.Location = new System.Drawing.Point(0, 0);
            this.panelGroups.Margin = new System.Windows.Forms.Padding(2);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(738, 457);
            this.panelGroups.TabIndex = 5;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::BasicFacebookFeatures.Properties.Resources.meeting;
            this.pictureBox11.Location = new System.Drawing.Point(596, 17);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 83);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 4;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::BasicFacebookFeatures.Properties.Resources.meeting__1_;
            this.pictureBox10.Location = new System.Drawing.Point(127, 10);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(61, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBoxSelectedGroup
            // 
            this.pictureBoxSelectedGroup.Location = new System.Drawing.Point(316, 101);
            this.pictureBoxSelectedGroup.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSelectedGroup.Name = "pictureBoxSelectedGroup";
            this.pictureBoxSelectedGroup.Size = new System.Drawing.Size(191, 177);
            this.pictureBoxSelectedGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedGroup.TabIndex = 2;
            this.pictureBoxSelectedGroup.TabStop = false;
            this.pictureBoxSelectedGroup.Visible = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(19, 65);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(258, 277);
            this.listBoxGroups.TabIndex = 1;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroups.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelGroups.Location = new System.Drawing.Point(15, 22);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(107, 30);
            this.labelGroups.TabIndex = 0;
            this.labelGroups.Text = "Groups";
            // 
            // panelAlbums
            // 
            this.panelAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAlbums.BackColor = System.Drawing.Color.White;
            this.panelAlbums.Controls.Add(this.pictureBox7);
            this.panelAlbums.Controls.Add(this.pictureBox6);
            this.panelAlbums.Controls.Add(this.buttonNextPhoto);
            this.panelAlbums.Controls.Add(this.buttonPrevPhoto);
            this.panelAlbums.Controls.Add(this.pictureBoxAlbums);
            this.panelAlbums.Controls.Add(this.listBoxAlbums);
            this.panelAlbums.Controls.Add(this.labelAlbums);
            this.panelAlbums.ForeColor = System.Drawing.Color.White;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(738, 457);
            this.panelAlbums.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BasicFacebookFeatures.Properties.Resources.book;
            this.pictureBox7.Location = new System.Drawing.Point(607, 14);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 69);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BasicFacebookFeatures.Properties.Resources.photo;
            this.pictureBox6.Location = new System.Drawing.Point(150, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.Font = new System.Drawing.Font("Guttman Mantova-Decor", 9.749998F, System.Drawing.FontStyle.Bold);
            this.buttonNextPhoto.Image = global::BasicFacebookFeatures.Properties.Resources.next;
            this.buttonNextPhoto.Location = new System.Drawing.Point(450, 283);
            this.buttonNextPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(50, 58);
            this.buttonNextPhoto.TabIndex = 4;
            this.buttonNextPhoto.Text = "next";
            this.buttonNextPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNextPhoto.UseVisualStyleBackColor = true;
            this.buttonNextPhoto.Click += new System.EventHandler(this.buttonNextPhoto_Click);
            // 
            // buttonPrevPhoto
            // 
            this.buttonPrevPhoto.Font = new System.Drawing.Font("Guttman Mantova-Decor", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPrevPhoto.Image = global::BasicFacebookFeatures.Properties.Resources.back;
            this.buttonPrevPhoto.Location = new System.Drawing.Point(383, 283);
            this.buttonPrevPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrevPhoto.Name = "buttonPrevPhoto";
            this.buttonPrevPhoto.Size = new System.Drawing.Size(50, 58);
            this.buttonPrevPhoto.TabIndex = 3;
            this.buttonPrevPhoto.Text = "prev";
            this.buttonPrevPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrevPhoto.UseVisualStyleBackColor = true;
            this.buttonPrevPhoto.Click += new System.EventHandler(this.buttonPrevPhoto_Click);
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Location = new System.Drawing.Point(358, 101);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(166, 177);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 2;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(32, 64);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(264, 277);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelAlbums.Location = new System.Drawing.Point(28, 21);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(114, 30);
            this.labelAlbums.TabIndex = 0;
            this.labelAlbums.Text = "Albums";
            // 
            // panelPosts
            // 
            this.panelPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPosts.BackColor = System.Drawing.Color.White;
            this.panelPosts.Controls.Add(this.pictureBox1);
            this.panelPosts.Controls.Add(this.pictureBoxPost);
            this.panelPosts.Controls.Add(this.listBoxPosts);
            this.panelPosts.Controls.Add(this.customRichTextBoxPostDetails);
            this.panelPosts.Controls.Add(this.labelShowPosts);
            this.panelPosts.Controls.Add(this.pictureBoxSelectedPost);
            this.panelPosts.ForeColor = System.Drawing.Color.White;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(738, 457);
            this.panelPosts.TabIndex = 34;
            this.panelPosts.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.guest_post;
            this.pictureBox1.Location = new System.Drawing.Point(612, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.like;
            this.pictureBoxPost.Image = global::BasicFacebookFeatures.Properties.Resources.chat;
            this.pictureBoxPost.InitialImage = global::BasicFacebookFeatures.Properties.Resources.like;
            this.pictureBoxPost.Location = new System.Drawing.Point(120, 11);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(42, 34);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPost.TabIndex = 7;
            this.pictureBoxPost.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(16, 74);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(226, 277);
            this.listBoxPosts.TabIndex = 6;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // customRichTextBoxPostDetails
            // 
            this.customRichTextBoxPostDetails.Location = new System.Drawing.Point(267, 73);
            this.customRichTextBoxPostDetails.Margin = new System.Windows.Forms.Padding(2);
            this.customRichTextBoxPostDetails.Name = "customRichTextBoxPostDetails";
            this.customRichTextBoxPostDetails.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.customRichTextBoxPostDetails.PlaceholderText = null;
            this.customRichTextBoxPostDetails.RichTextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRichTextBoxPostDetails.Size = new System.Drawing.Size(294, 93);
            this.customRichTextBoxPostDetails.TabIndex = 4;
            this.customRichTextBoxPostDetails.Visible = false;
            // 
            // labelShowPosts
            // 
            this.labelShowPosts.AutoSize = true;
            this.labelShowPosts.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPosts.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelShowPosts.Location = new System.Drawing.Point(24, 11);
            this.labelShowPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowPosts.Name = "labelShowPosts";
            this.labelShowPosts.Size = new System.Drawing.Size(84, 30);
            this.labelShowPosts.TabIndex = 2;
            this.labelShowPosts.Text = "Posts";
            // 
            // pictureBoxSelectedPost
            // 
            this.pictureBoxSelectedPost.Location = new System.Drawing.Point(301, 193);
            this.pictureBoxSelectedPost.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSelectedPost.Name = "pictureBoxSelectedPost";
            this.pictureBoxSelectedPost.Size = new System.Drawing.Size(172, 158);
            this.pictureBoxSelectedPost.TabIndex = 1;
            this.pictureBoxSelectedPost.TabStop = false;
            this.pictureBoxSelectedPost.Visible = false;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelPersonalityInsights
            // 
            this.labelPersonalityInsights.Location = new System.Drawing.Point(0, 0);
            this.labelPersonalityInsights.Name = "labelPersonalityInsights";
            this.labelPersonalityInsights.Size = new System.Drawing.Size(100, 23);
            this.labelPersonalityInsights.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 648);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUserTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFacebook)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelNewPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUser)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPage)).EndInit();
            this.panelGoals.ResumeLayout(false);
            this.panelGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProgress)).EndInit();
            this.panelPersonalityInsights.ResumeLayout(false);
            this.panelPersonalityInsights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivityPattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoPreferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSentimentScore)).EndInit();
            this.panelGroups.ResumeLayout(false);
            this.panelGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedGroup)).EndInit();
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPost)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBoxImageUser_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null && pb.Image != null)
            {
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);
                Region rg = new Region(gp);
                pb.Region = rg;

                e.Graphics.SetClip(gp);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawImage(pb.Image, 0, 0, pb.Width, pb.Height);
            }
        }




        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox imageFacebook;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Button pagesButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button postsButton;
        private System.Windows.Forms.Button ButtonPersonalityAnalyzer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelNewPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private BasicFacebookFeatures.CustomRichTextBoxPanel customRichTextBoxPanelNewPost;
        private System.Windows.Forms.PictureBox pictureBoxImageUser;
        private PictureBox pictureBoxImageUserTop;
        private Panel panelPosts;
        private PictureBox pictureBoxSelectedPost;
        private Label labelShowPosts;
        private CustomRichTextBoxPanel customRichTextBoxPostDetails;
        private Label labelWelcome;
        private Panel panelPages;
        private PictureBox pictureBoxSelectedPage;
        private Label labelPages;
        private ListBox listBoxPages;
        private Button buttonAlbums;
        private Panel panelAlbums;
        private Label labelAlbums;
        private Button buttonNextPhoto;
        private Button buttonPrevPhoto;
        private PictureBox pictureBoxAlbums;
        private ListBox listBoxAlbums;
        private Panel panelGroups;
        private Label labelGroups;
        private PictureBox pictureBoxSelectedGroup;
        private ListBox listBoxGroups;
        private Panel panelPersonalityInsights;
        private Label labelPersonalityInsights;
        private Label labelTopTopics;
        private Label labelActivityPattern;
        private Label labelMainInterests;
        private Label labelSentimentScore;
        private Label labelPhotoPreferences;
        private Label labelPersonalityInsight;
        private ListBox listBoxPosts;
        private PictureBox pictureBoxPost;
        private CustomRichTextBoxPanel customRichTextBoxPanelTopTopics;
        private ProgressBar progressBar1;
        private Label labelSentimentScoreValue;
        private CustomRichTextBoxPanel customRichTextBoxPanelMainInterest;
        private Label labelPostFrequency;
        private Label labelTotalPhotos;
        private Label labelPhotosPerMonth;
        private Label labelMostActiveHour;
        private Label labelMostCommonPhotoType;
        private PictureBox pictureBoxSentimentScore;
        private PictureBox pictureBoxActivityPattern;
        private PictureBox pictureBoxPhotoPreferences;
        private PictureBox pictureBoxMainInterest;
        private PictureBox pictureBoxTopTopic;
        private Button buttonGoals;
        private Panel panelGoals;
        private Label label4;
        private Label labelTitle;
        private Label label6;
        private ComboBox cmbCategory;
        private Label label5;
        private CustomTextBox customTextBoxGoalName;
        private Label label3;
        private ProgressBar progressBar;
        private Label label7;
        private DateTimePicker dtpTargetDate;
        private Label label8;
        private ListBox listBoxGoals;
        private Button buttonAddGoal;
        private Button buttonUpdateProgress;
        private NumericUpDown numericUpDownProgress;
        private Label label9;
        private PictureBox pictureBox2;
        private Button buttonShareGoal;
        private PictureBox pictureBox3;
        private Label labelRelevantPages;
        private ListBox listBoxRelevantPages;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private Button buttonCleanDetails;
        private Button buttonRemove;
        private BindingSource pageBindingSource;
    }
}
