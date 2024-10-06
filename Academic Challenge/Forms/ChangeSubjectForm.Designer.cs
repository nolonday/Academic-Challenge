namespace Academic_Challenge
{
    partial class ChangeSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSubjectForm));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Subject_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxSubject = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChgSubject = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FormSettings
            // 
            this.FormSettings.AnimateWindow = true;
            this.FormSettings.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DockIndicatorTransparencyValue = 0.6D;
            this.FormSettings.DragStartTransparencyValue = 1D;
            this.FormSettings.TransparentWhileDrag = true;
            // 
            // Subject_Text
            // 
            this.Subject_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Subject_Text, "Subject_Text");
            this.Subject_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Subject_Text.IsSelectionEnabled = false;
            this.Subject_Text.Name = "Subject_Text";
            this.Subject_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Subject_Text_MouseDown);
            // 
            // TextBoxSubject
            // 
            this.TextBoxSubject.Animated = true;
            this.TextBoxSubject.BorderRadius = 10;
            this.TextBoxSubject.BorderThickness = 3;
            this.TextBoxSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSubject.DefaultText = "";
            this.TextBoxSubject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxSubject, "TextBoxSubject");
            this.TextBoxSubject.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxSubject.Name = "TextBoxSubject";
            this.TextBoxSubject.PasswordChar = '\0';
            this.TextBoxSubject.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxSubject.PlaceholderText = "Subject";
            this.TextBoxSubject.SelectedText = "";
            // 
            // ChgSubject
            // 
            this.ChgSubject.Animated = true;
            this.ChgSubject.BorderRadius = 10;
            this.ChgSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChgSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChgSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChgSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChgSubject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.ChgSubject, "ChgSubject");
            this.ChgSubject.ForeColor = System.Drawing.Color.White;
            this.ChgSubject.Name = "ChgSubject";
            this.ChgSubject.Click += new System.EventHandler(this.ChgSubject_Click);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::Academic_Challenge.Properties.Resources.logo;
            this.Logo.ImageRotate = 0F;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // ChangeSubjectForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChgSubject);
            this.Controls.Add(this.TextBoxSubject);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Subject_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeSubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Subject_Text;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSubject;
        private Guna.UI2.WinForms.Guna2Button ChgSubject;
    }
}