using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public class CustomTextBox : TextBox
    {
        private readonly int r_CornerRadius = 15;
        private string m_PlaceholderText;

        public string PlaceholderText
        {
            get { return m_PlaceholderText; }
            set
            {
                m_PlaceholderText = value;
                setPlaceholder();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, r_CornerRadius, r_CornerRadius, 180, 90);
                path.AddArc(Width - r_CornerRadius, 0, r_CornerRadius, r_CornerRadius, 270, 90);
                path.AddArc(Width - r_CornerRadius, Height - r_CornerRadius, r_CornerRadius, r_CornerRadius, 0, 90);
                path.AddArc(0, Height - r_CornerRadius, r_CornerRadius, r_CornerRadius, 90, 90);
                path.CloseFigure();

                Region = new Region(path);

                using (Pen pen = new Pen(Color.Gray))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            base.OnPaint(e);
        }

        private void setPlaceholder()
        {
            if (IsHandleCreated && string.IsNullOrEmpty(Text))
            {
                SendMessage(this.Handle, 0x1501, 0, m_PlaceholderText);
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            setPlaceholder();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            setPlaceholder();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (Text == m_PlaceholderText)
            {
                Text = string.Empty;
                ForeColor = SystemColors.WindowText;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (string.IsNullOrEmpty(Text))
            {
                Text = m_PlaceholderText;
                ForeColor = SystemColors.GrayText;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
    }
}
