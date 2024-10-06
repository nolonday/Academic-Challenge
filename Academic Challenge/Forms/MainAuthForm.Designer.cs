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
            resources.ApplyResources(this.PanelUp, "PanelUp");
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUp_MouseDown);
            // 
            // Top
            // 
            this.Top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Top.Image = global::Academic_Challenge.Properties.Resources.topUsers;
            this.Top.ImageRotate = 0F;
            resources.ApplyResources(this.Top, "Top");
            this.Top.Name = "Top";
            this.Top.TabStop = false;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // PictureUsers
            // 
            this.PictureUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureUsers.Image = global::Academic_Challenge.Properties.Resources.users;
            this.PictureUsers.ImageRotate = 0F;
            resources.ApplyResources(this.PictureUsers, "PictureUsers");
            this.PictureUsers.Name = "PictureUsers";
            this.PictureUsers.TabStop = false;
            this.PictureUsers.Click += new System.EventHandler(this.PictureUsers_Click);
            // 
            // TextAdmin
            // 
            this.TextAdmin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TextAdmin, "TextAdmin");
            this.TextAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextAdmin.IsSelectionEnabled = false;
            this.TextAdmin.Name = "TextAdmin";
            // 
            // ProfileAvatar
            // 
            this.ProfileAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ProfileAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileAvatar.Image = global::Academic_Challenge.Properties.Resources.profile;
            this.ProfileAvatar.ImageRotate = 0F;
            resources.ApplyResources(this.ProfileAvatar, "ProfileAvatar");
            this.ProfileAvatar.Name = "ProfileAvatar";
            this.ProfileAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileAvatar.TabStop = false;
            this.ProfileAvatar.Click += new System.EventHandler(this.ProfileAvatar_Click);
            // 
            // Info
            // 
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Image = global::Academic_Challenge.Properties.Resources.info;
            this.Info.ImageRotate = 0F;
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Logo_Text
            // 
            this.Logo_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Logo_Text, "Logo_Text");
            this.Logo_Text.ForeColor = System.Drawing.Color.White;
            this.Logo_Text.IsSelectionEnabled = false;
            this.Logo_Text.Name = "Logo_Text";
            this.Logo_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_Text_MouseDown);
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
            // panelSwitched
            // 
            resources.ApplyResources(this.panelSwitched, "panelSwitched");
            this.panelSwitched.Name = "panelSwitched";
            this.panelSwitched.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSwitched_MouseDown);
            // 
            // MainAuthForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSwitched);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAuthForm";
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