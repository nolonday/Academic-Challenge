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
            this.Auth_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 40F, System.Drawing.FontStyle.Bold);
            this.Auth_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Auth_Text.IsSelectionEnabled = false;
            this.Auth_Text.Location = new System.Drawing.Point(427, 88);
            this.Auth_Text.Name = "Auth_Text";
            this.Auth_Text.Size = new System.Drawing.Size(372, 62);
            this.Auth_Text.TabIndex = 7;
            this.Auth_Text.Text = "Авторизация";
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
            this.ButtonEnter.Font = new System.Drawing.Font("Kanit Cyrillic", 22F, System.Drawing.FontStyle.Bold);
            this.ButtonEnter.ForeColor = System.Drawing.Color.White;
            this.ButtonEnter.Location = new System.Drawing.Point(468, 372);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(300, 60);
            this.ButtonEnter.TabIndex = 13;
            this.ButtonEnter.Text = "Войти";
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
            this.TextBoxPass.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxPass.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxPass.Location = new System.Drawing.Point(468, 269);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '●';
            this.TextBoxPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxPass.PlaceholderText = "Пароль";
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.Size = new System.Drawing.Size(300, 50);
            this.TextBoxPass.TabIndex = 12;
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
            this.TextBoxLogin.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxLogin.Location = new System.Drawing.Point(468, 211);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PasswordChar = '\0';
            this.TextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxLogin.PlaceholderText = "Логин";
            this.TextBoxLogin.SelectedText = "";
            this.TextBoxLogin.Size = new System.Drawing.Size(300, 50);
            this.TextBoxLogin.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            this.RegistrationForm.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationForm.Font = new System.Drawing.Font("Kanit Cyrillic", 22F);
            this.RegistrationForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.RegistrationForm.IsSelectionEnabled = false;
            this.RegistrationForm.Location = new System.Drawing.Point(520, 438);
            this.RegistrationForm.Name = "RegistrationForm";
            this.RegistrationForm.Size = new System.Drawing.Size(191, 35);
            this.RegistrationForm.TabIndex = 14;
            this.RegistrationForm.Text = "Регистрация";
            this.RegistrationForm.Click += new System.EventHandler(this.RegistrationForm_Click);
            // 
            // ReturnPass
            // 
            this.ReturnPass.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPass.Font = new System.Drawing.Font("Kanit Cyrillic", 15F, System.Drawing.FontStyle.Bold);
            this.ReturnPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ReturnPass.IsSelectionEnabled = false;
            this.ReturnPass.Location = new System.Drawing.Point(589, 324);
            this.ReturnPass.Name = "ReturnPass";
            this.ReturnPass.Size = new System.Drawing.Size(179, 25);
            this.ReturnPass.TabIndex = 15;
            this.ReturnPass.Text = "Забыли пароль?";
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
            this.Book1.Location = new System.Drawing.Point(21, 88);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(400, 344);
            this.Book1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Book1.TabIndex = 6;
            this.Book1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::Academic_Challenge.Properties.Resources.logo;
            this.Logo.ImageRotate = 0F;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ReturnPass);
            this.Controls.Add(this.RegistrationForm);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.Auth_Text);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
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