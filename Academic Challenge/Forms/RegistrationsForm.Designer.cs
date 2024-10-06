namespace Academic_Challenge
{
    partial class RegistrationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationsForm));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Reg_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.Open = new Guna.UI2.WinForms.Guna2Button();
            this.File_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.AutificationForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.Book1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TextBoxCode = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).BeginInit();
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
            // Reg_Text
            // 
            this.Reg_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Reg_Text, "Reg_Text");
            this.Reg_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Reg_Text.IsSelectionEnabled = false;
            this.Reg_Text.Name = "Reg_Text";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Animated = true;
            this.TextBoxLogin.BorderRadius = 10;
            this.TextBoxLogin.BorderThickness = 3;
            this.TextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLogin.DefaultText = "";
            this.TextBoxLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxLogin, "TextBoxLogin");
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PasswordChar = '\0';
            this.TextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxLogin.PlaceholderText = "Логин";
            this.TextBoxLogin.SelectedText = "";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Animated = true;
            this.TextBoxPass.BorderRadius = 10;
            this.TextBoxPass.BorderThickness = 3;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.DefaultText = "";
            this.TextBoxPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxPass, "TextBoxPass");
            this.TextBoxPass.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '●';
            this.TextBoxPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxPass.PlaceholderText = "Пароль";
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // Open
            // 
            this.Open.Animated = true;
            this.Open.BorderRadius = 10;
            this.Open.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Open.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Open.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Open.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.Open, "Open");
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Name = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // File_Text
            // 
            this.File_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.File_Text, "File_Text");
            this.File_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.File_Text.IsSelectionEnabled = false;
            this.File_Text.Name = "File_Text";
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Animated = true;
            this.ButtonRegistration.BorderRadius = 10;
            this.ButtonRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.ButtonRegistration, "ButtonRegistration");
            this.ButtonRegistration.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // AutificationForm
            // 
            this.AutificationForm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.AutificationForm, "AutificationForm");
            this.AutificationForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.AutificationForm.IsSelectionEnabled = false;
            this.AutificationForm.Name = "AutificationForm";
            this.AutificationForm.Click += new System.EventHandler(this.AutificationForm_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Animated = true;
            this.TextBoxEmail.BorderRadius = 10;
            this.TextBoxEmail.BorderThickness = 3;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxEmail, "TextBoxEmail");
            this.TextBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxEmail.PlaceholderText = "Email";
            this.TextBoxEmail.SelectedText = "";
            // 
            // Book1
            // 
            this.Book1.Image = global::Academic_Challenge.Properties.Resources.book2;
            this.Book1.ImageRotate = 0F;
            resources.ApplyResources(this.Book1, "Book1");
            this.Book1.Name = "Book1";
            this.Book1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::Academic_Challenge.Properties.Resources.logo;
            this.Logo.ImageRotate = 0F;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Animated = true;
            this.TextBoxCode.BorderRadius = 10;
            this.TextBoxCode.BorderThickness = 3;
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCode.DefaultText = "";
            this.TextBoxCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxCode, "TextBoxCode");
            this.TextBoxCode.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.PasswordChar = '●';
            this.TextBoxCode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxCode.PlaceholderText = "Код";
            this.TextBoxCode.SelectedText = "";
            this.TextBoxCode.UseSystemPasswordChar = true;
            // 
            // RegistrationsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.AutificationForm);
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.File_Text);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.Reg_Text);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Reg_Text;
        private Guna.UI2.WinForms.Guna2PictureBox Book1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLogin;
        private Guna.UI2.WinForms.Guna2Button Open;
        private Guna.UI2.WinForms.Guna2HtmlLabel File_Text;
        private Guna.UI2.WinForms.Guna2Button ButtonRegistration;
        private Guna.UI2.WinForms.Guna2HtmlLabel AutificationForm;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCode;
    }
}