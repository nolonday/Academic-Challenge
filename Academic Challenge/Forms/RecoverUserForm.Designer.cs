﻿namespace Academic_Challenge.Forms
{
    partial class RecoverUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverUserForm));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Recover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Recover_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonRecover = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxCode = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Recover)).BeginInit();
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
            // Recover
            // 
            this.Recover.Image = global::Academic_Challenge.Properties.Resources.recover;
            this.Recover.ImageRotate = 0F;
            this.Recover.Location = new System.Drawing.Point(21, 98);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(374, 344);
            this.Recover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Recover.TabIndex = 6;
            this.Recover.TabStop = false;
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
            // 
            // Recover_Text
            // 
            this.Recover_Text.BackColor = System.Drawing.Color.Transparent;
            this.Recover_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 30F, System.Drawing.FontStyle.Bold);
            this.Recover_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Recover_Text.IsSelectionEnabled = false;
            this.Recover_Text.Location = new System.Drawing.Point(427, 88);
            this.Recover_Text.Name = "Recover_Text";
            this.Recover_Text.Size = new System.Drawing.Size(351, 47);
            this.Recover_Text.TabIndex = 7;
            this.Recover_Text.Text = "Восстановление";
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
            this.TextBoxPass.Location = new System.Drawing.Point(468, 266);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '●';
            this.TextBoxPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxPass.PlaceholderText = "Пароль";
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.Size = new System.Drawing.Size(300, 50);
            this.TextBoxPass.TabIndex = 14;
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
            this.TextBoxLogin.Location = new System.Drawing.Point(468, 158);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PasswordChar = '\0';
            this.TextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxLogin.PlaceholderText = "Логин";
            this.TextBoxLogin.SelectedText = "";
            this.TextBoxLogin.Size = new System.Drawing.Size(300, 50);
            this.TextBoxLogin.TabIndex = 13;
            //this.TextBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLogin_KeyDown);
            // 
            // ButtonRecover
            // 
            this.ButtonRecover.Animated = true;
            this.ButtonRecover.BorderRadius = 10;
            this.ButtonRecover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRecover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRecover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRecover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRecover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ButtonRecover.Font = new System.Drawing.Font("Kanit Cyrillic", 22F, System.Drawing.FontStyle.Bold);
            this.ButtonRecover.ForeColor = System.Drawing.Color.White;
            this.ButtonRecover.Location = new System.Drawing.Point(468, 372);
            this.ButtonRecover.Name = "ButtonRecover";
            this.ButtonRecover.Size = new System.Drawing.Size(300, 60);
            this.ButtonRecover.TabIndex = 15;
            this.ButtonRecover.Text = "Востановить";
            this.ButtonRecover.Click += new System.EventHandler(this.ButtonRecover_Click);
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
            this.TextBoxCode.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxCode.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxCode.Location = new System.Drawing.Point(468, 212);
            this.TextBoxCode.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.PasswordChar = '\0';
            this.TextBoxCode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxCode.PlaceholderText = "Код";
            this.TextBoxCode.SelectedText = "";
            this.TextBoxCode.Size = new System.Drawing.Size(300, 50);
            this.TextBoxCode.TabIndex = 16;
            this.TextBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCode_KeyDown);
            // 
            // RecoverUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.ButtonRecover);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.Recover_Text);
            this.Controls.Add(this.Recover);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "RecoverUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановить Пароль";
            ((System.ComponentModel.ISupportInitialize)(this.Recover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2PictureBox Recover;
        private Guna.UI2.WinForms.Guna2HtmlLabel Recover_Text;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLogin;
        private Guna.UI2.WinForms.Guna2Button ButtonRecover;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCode;
    }
}