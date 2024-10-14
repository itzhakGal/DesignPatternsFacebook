using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public class CustomRichTextBoxPanel : Panel
    {
        private readonly RichTextBox m_RichTextBox;
        private string m_PlaceholderText;
        private bool m_IsPlaceholderActive;
        private const int k_CornerRadius = 15;

        public CustomRichTextBoxPanel()
        {
            m_RichTextBox = new RichTextBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Multiline = true,
                ForeColor = SystemColors.GrayText
            };

            m_IsPlaceholderActive = true;

            this.Click += (s, e) => m_RichTextBox.Focus();
            m_RichTextBox.Click += (s, e) => m_RichTextBox.Focus();

            m_RichTextBox.GotFocus += removePlaceholderText;
            m_RichTextBox.LostFocus += setPlaceholderText;

            this.Controls.Add(m_RichTextBox);
            this.Padding = new Padding(k_CornerRadius);
        }

        public string PlaceholderText
        {
            get { return m_PlaceholderText; }
            set
            {
                m_PlaceholderText = value;
                setPlaceholderText(this, EventArgs.Empty);
            }
        }

        public Font RichTextBoxFont
        {
            get { return m_RichTextBox.Font; }
            set { m_RichTextBox.Font = value; }
        }

        private void removePlaceholderText(object sender, EventArgs e)
        {
            if (m_IsPlaceholderActive)
            {
                m_RichTextBox.Text = string.Empty;
                m_RichTextBox.ForeColor = SystemColors.WindowText;
                m_IsPlaceholderActive = false;
            }
        }

        private void setPlaceholderText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_RichTextBox.Text))
            {
                m_IsPlaceholderActive = true;
                m_RichTextBox.Text = m_PlaceholderText;
                m_RichTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, k_CornerRadius, k_CornerRadius, 180, 90);
                path.AddArc(Width - k_CornerRadius - 1, 0, k_CornerRadius, k_CornerRadius, 270, 90);
                path.AddArc(Width - k_CornerRadius - 1, Height - k_CornerRadius - 1, k_CornerRadius, k_CornerRadius, 0, 90);
                path.AddArc(0, Height - k_CornerRadius - 1, k_CornerRadius, k_CornerRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(Color.Gray, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public RichTextBox GetRichTextBox()
        {
            return m_RichTextBox;
        }

        public string GetText()
        {
            return m_RichTextBox.Text;
        }

        public void SetText(string i_Text)
        {
            m_RichTextBox.Text = i_Text;
            m_IsPlaceholderActive = false;
            m_RichTextBox.ForeColor = SystemColors.WindowText;
        }
    }
}
