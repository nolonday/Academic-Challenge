namespace Academic_Challenge
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.Auth_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonEnter = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegistrationForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ReturnPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Book1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Auth_Text
            // 
            this.Auth_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Auth_Text, "Auth_Text");
            this.Auth_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Auth_Text.IsSelectionEnabled = false;
            this.Auth_Text.Name = "Auth_Text";
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Animated = true;
            this.ButtonEnter.BorderRadius = 10;
            this.ButtonEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.ButtonEnter, "ButtonEnter");
            this.ButtonEnter.ForeColor = System.Drawing.Color.White;
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
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
            // RegistrationForm
            // 
            this.RegistrationForm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.RegistrationForm, "RegistrationForm");
            this.RegistrationForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.RegistrationForm.IsSelectionEnabled = false;
            this.RegistrationForm.Name = "RegistrationForm";
            this.RegistrationForm.Click += new System.EventHandler(this.RegistrationForm_Click);
            // 
            // ReturnPass
            // 
            this.ReturnPass.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ReturnPass, "ReturnPass");
            this.ReturnPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ReturnPass.IsSelectionEnabled = false;
            this.ReturnPass.Name = "ReturnPass";
            this.ReturnPass.Click += new System.EventHandler(this.ReturnPass_Click);
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
            // Book1
            // 
            this.Book1.Image = global::Academic_Challenge.Properties.Resources.book3;
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
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // AuthorizationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReturnPass);
            this.Controls.Add(this.RegistrationForm);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.Auth_Text);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2PictureBox Book1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Auth_Text;
        private Guna.UI2.WinForms.Guna2Button ButtonEnter;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel RegistrationForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel ReturnPass;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
    }
}