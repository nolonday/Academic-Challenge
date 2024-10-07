namespace Academic_Challenge
{
    partial class MainAuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAuthForm));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PanelUp = new Guna.UI2.WinForms.Guna2Panel();
            this.Top = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureUsers = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TextAdmin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProfileAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Info = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Logo_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelSwitched = new System.Windows.Forms.Panel();
            this.PanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FormSettings
            // 
            this.FormSettings.AnimateWindow = true;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DockIndicatorTransparencyValue = 0.6D;
            this.FormSettings.DragStartTransparencyValue = 1D;
            this.FormSettings.TransparentWhileDrag = true;
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.PanelUp.Controls.Add(this.Top);
            this.PanelUp.Controls.Add(this.PictureUsers);
            this.PanelUp.Controls.Add(this.TextAdmin);
            this.PanelUp.Controls.Add(this.ProfileAvatar);
            this.PanelUp.Controls.Add(this.Info);
            this.PanelUp.Controls.Add(this.Logo_Text);
            this.PanelUp.Controls.Add(this.Logo);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(1200, 111);
            this.PanelUp.TabIndex = 1;
            this.PanelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUp_MouseDown);
            // 
            // Top
            // 
            this.Top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Top.Image = global::Academic_Challenge.Properties.Resources.topUsers;
            this.Top.ImageRotate = 0F;
            this.Top.Location = new System.Drawing.Point(1016, 31);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(50, 50);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 8;
            this.Top.TabStop = false;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // PictureUsers
            // 
            this.PictureUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureUsers.Image = global::Academic_Challenge.Properties.Resources.users;
            this.PictureUsers.ImageRotate = 0F;
            this.PictureUsers.Location = new System.Drawing.Point(960, 31);
            this.PictureUsers.Name = "PictureUsers";
            this.PictureUsers.Size = new System.Drawing.Size(50, 50);
            this.PictureUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUsers.TabIndex = 7;
            this.PictureUsers.TabStop = false;
            this.PictureUsers.Click += new System.EventHandler(this.PictureUsers_Click);
            // 
            // TextAdmin
            // 
            this.TextAdmin.BackColor = System.Drawing.Color.Transparent;
            this.TextAdmin.Font = new System.Drawing.Font("Kanit Cyrillic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextAdmin.IsSelectionEnabled = false;
            this.TextAdmin.Location = new System.Drawing.Point(1131, 3);
            this.TextAdmin.Name = "TextAdmin";
            this.TextAdmin.Size = new System.Drawing.Size(57, 20);
            this.TextAdmin.TabIndex = 6;
            this.TextAdmin.Text = "Admin";
            // 
            // ProfileAvatar
            // 
            this.ProfileAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ProfileAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileAvatar.Image = global::Academic_Challenge.Properties.Resources.profile;
            this.ProfileAvatar.ImageRotate = 0F;
            this.ProfileAvatar.Location = new System.Drawing.Point(1128, 26);
            this.ProfileAvatar.Name = "ProfileAvatar";
            this.ProfileAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileAvatar.Size = new System.Drawing.Size(60, 60);
            this.ProfileAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileAvatar.TabIndex = 5;
            this.ProfileAvatar.TabStop = false;
            this.ProfileAvatar.Click += new System.EventHandler(this.ProfileAvatar_Click);
            // 
            // Info
            // 
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Image = global::Academic_Challenge.Properties.Resources.info;
            this.Info.ImageRotate = 0F;
            this.Info.Location = new System.Drawing.Point(1072, 31);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(50, 50);
            this.Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Info.TabIndex = 4;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Logo_Text
            // 
            this.Logo_Text.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 35F);
            this.Logo_Text.ForeColor = System.Drawing.Color.White;
            this.Logo_Text.IsSelectionEnabled = false;
            this.Logo_Text.Location = new System.Drawing.Point(98, 26);
            this.Logo_Text.Name = "Logo_Text";
            this.Logo_Text.Size = new System.Drawing.Size(479, 55);
            this.Logo_Text.TabIndex = 2;
            this.Logo_Text.Text = "Academic Challenge";
            this.Logo_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_Text_MouseDown);
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
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // panelSwitched
            // 
            this.panelSwitched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSwitched.Location = new System.Drawing.Point(0, 111);
            this.panelSwitched.Name = "panelSwitched";
            this.panelSwitched.Size = new System.Drawing.Size(1200, 689);
            this.panelSwitched.TabIndex = 2;
            this.panelSwitched.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSwitched_MouseDown);
            // 
            // MainAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelSwitched);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2Panel PanelUp;
        private Guna.UI2.WinForms.Guna2PictureBox Info;
        private Guna.UI2.WinForms.Guna2HtmlLabel Logo_Text;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileAvatar;
        private System.Windows.Forms.Panel panelSwitched;
        private Guna.UI2.WinForms.Guna2HtmlLabel TextAdmin;
        private Guna.UI2.WinForms.Guna2PictureBox PictureUsers;
        private Guna.UI2.WinForms.Guna2PictureBox Top;
    }
}