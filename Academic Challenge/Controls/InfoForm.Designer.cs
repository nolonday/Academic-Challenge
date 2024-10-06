namespace Academic_Challenge
{
    partial class InfoForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.App = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.LabelAuditoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Desk_audotiria = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.LabelVersion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Open = new Guna.UI2.WinForms.Guna2Button();
            this.GroupApp = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GroupSocial = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PictureBoxTG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxVK = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GroupVersion = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GroupSupport = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Support = new System.Windows.Forms.Label();
            this.LabelUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Book1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GroupAuditoria = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GroupApp.SuspendLayout();
            this.GroupSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVK)).BeginInit();
            this.GroupVersion.SuspendLayout();
            this.GroupSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).BeginInit();
            this.GroupAuditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // App
            // 
            resources.ApplyResources(this.App, "App");
            this.App.BackColor = System.Drawing.Color.Transparent;
            this.App.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.App.Name = "App";
            // 
            // Desc
            // 
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.BackColor = System.Drawing.Color.Transparent;
            this.Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Desc.Name = "Desc";
            // 
            // LabelAuditoria
            // 
            resources.ApplyResources(this.LabelAuditoria, "LabelAuditoria");
            this.LabelAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.LabelAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.LabelAuditoria.IsSelectionEnabled = false;
            this.LabelAuditoria.Name = "LabelAuditoria";
            // 
            // Desk_audotiria
            // 
            resources.ApplyResources(this.Desk_audotiria, "Desk_audotiria");
            this.Desk_audotiria.BackColor = System.Drawing.Color.Transparent;
            this.Desk_audotiria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Desk_audotiria.Name = "Desk_audotiria";
            // 
            // Version
            // 
            resources.ApplyResources(this.Version, "Version");
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.ForeColor = System.Drawing.Color.Red;
            this.Version.Name = "Version";
            // 
            // LabelVersion
            // 
            resources.ApplyResources(this.LabelVersion, "LabelVersion");
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.LabelVersion.IsSelectionEnabled = false;
            this.LabelVersion.Name = "LabelVersion";
            // 
            // Open
            // 
            resources.ApplyResources(this.Open, "Open");
            this.Open.Animated = true;
            this.Open.BorderRadius = 10;
            this.Open.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Open.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Open.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Open.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Name = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // GroupApp
            // 
            resources.ApplyResources(this.GroupApp, "GroupApp");
            this.GroupApp.Controls.Add(this.GroupSocial);
            this.GroupApp.Controls.Add(this.App);
            this.GroupApp.Controls.Add(this.GroupVersion);
            this.GroupApp.Controls.Add(this.Desc);
            this.GroupApp.Controls.Add(this.GroupSupport);
            this.GroupApp.Controls.Add(this.Book1);
            this.GroupApp.Controls.Add(this.GroupAuditoria);
            this.GroupApp.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupApp.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupApp.ForeColor = System.Drawing.Color.White;
            this.GroupApp.Name = "GroupApp";
            this.GroupApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupSocial
            // 
            resources.ApplyResources(this.GroupSocial, "GroupSocial");
            this.GroupSocial.Controls.Add(this.PictureBoxTG);
            this.GroupSocial.Controls.Add(this.PictureBoxVK);
            this.GroupSocial.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupSocial.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupSocial.ForeColor = System.Drawing.Color.White;
            this.GroupSocial.Name = "GroupSocial";
            this.GroupSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBoxTG
            // 
            resources.ApplyResources(this.PictureBoxTG, "PictureBoxTG");
            this.PictureBoxTG.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTG.Image = global::Academic_Challenge.Properties.Resources.tg;
            this.PictureBoxTG.ImageRotate = 0F;
            this.PictureBoxTG.Name = "PictureBoxTG";
            this.PictureBoxTG.TabStop = false;
            this.PictureBoxTG.Click += new System.EventHandler(this.PictureBoxTG_Click);
            // 
            // PictureBoxVK
            // 
            resources.ApplyResources(this.PictureBoxVK, "PictureBoxVK");
            this.PictureBoxVK.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxVK.Image = global::Academic_Challenge.Properties.Resources.vk;
            this.PictureBoxVK.ImageRotate = 0F;
            this.PictureBoxVK.Name = "PictureBoxVK";
            this.PictureBoxVK.TabStop = false;
            this.PictureBoxVK.Click += new System.EventHandler(this.PictureBoxVK_Click);
            // 
            // GroupVersion
            // 
            resources.ApplyResources(this.GroupVersion, "GroupVersion");
            this.GroupVersion.Controls.Add(this.LabelVersion);
            this.GroupVersion.Controls.Add(this.Version);
            this.GroupVersion.Controls.Add(this.Open);
            this.GroupVersion.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupVersion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupVersion.ForeColor = System.Drawing.Color.White;
            this.GroupVersion.Name = "GroupVersion";
            this.GroupVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupSupport
            // 
            resources.ApplyResources(this.GroupSupport, "GroupSupport");
            this.GroupSupport.Controls.Add(this.Support);
            this.GroupSupport.Controls.Add(this.LabelUser);
            this.GroupSupport.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupSupport.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupSupport.ForeColor = System.Drawing.Color.White;
            this.GroupSupport.Name = "GroupSupport";
            this.GroupSupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Support
            // 
            resources.ApplyResources(this.Support, "Support");
            this.Support.BackColor = System.Drawing.Color.Transparent;
            this.Support.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Support.Name = "Support";
            // 
            // LabelUser
            // 
            resources.ApplyResources(this.LabelUser, "LabelUser");
            this.LabelUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.LabelUser.IsSelectionEnabled = false;
            this.LabelUser.Name = "LabelUser";
            // 
            // Book1
            // 
            resources.ApplyResources(this.Book1, "Book1");
            this.Book1.Image = global::Academic_Challenge.Properties.Resources.book4;
            this.Book1.ImageRotate = 0F;
            this.Book1.Name = "Book1";
            this.Book1.TabStop = false;
            // 
            // GroupAuditoria
            // 
            resources.ApplyResources(this.GroupAuditoria, "GroupAuditoria");
            this.GroupAuditoria.Controls.Add(this.LabelAuditoria);
            this.GroupAuditoria.Controls.Add(this.Desk_audotiria);
            this.GroupAuditoria.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupAuditoria.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupAuditoria.ForeColor = System.Drawing.Color.White;
            this.GroupAuditoria.Name = "GroupAuditoria";
            this.GroupAuditoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupApp);
            this.Name = "InfoForm";
            this.GroupApp.ResumeLayout(false);
            this.GroupApp.PerformLayout();
            this.GroupSocial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVK)).EndInit();
            this.GroupVersion.ResumeLayout(false);
            this.GroupVersion.PerformLayout();
            this.GroupSupport.ResumeLayout(false);
            this.GroupSupport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).EndInit();
            this.GroupAuditoria.ResumeLayout(false);
            this.GroupAuditoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label App;
        private System.Windows.Forms.Label Desc;
        private Guna.UI2.WinForms.Guna2PictureBox Book1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelAuditoria;
        private System.Windows.Forms.Label Desk_audotiria;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxTG;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxVK;
        private System.Windows.Forms.Label Version;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelVersion;
        private Guna.UI2.WinForms.Guna2Button Open;
        private Guna.UI2.WinForms.Guna2GroupBox GroupApp;
        private Guna.UI2.WinForms.Guna2GroupBox GroupAuditoria;
        private Guna.UI2.WinForms.Guna2GroupBox GroupSupport;
        private System.Windows.Forms.Label Support;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelUser;
        private Guna.UI2.WinForms.Guna2GroupBox GroupVersion;
        private Guna.UI2.WinForms.Guna2GroupBox GroupSocial;
    }
}
