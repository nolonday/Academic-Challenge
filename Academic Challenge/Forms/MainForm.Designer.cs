namespace Academic_Challenge
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelUp = new Guna.UI2.WinForms.Guna2Panel();
            this.Profile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Logo_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Text1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Text2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Text3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Tests = new Guna.UI2.WinForms.Guna2Button();
            this.Tests_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Book1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.PanelUp.Controls.Add(this.Profile);
            this.PanelUp.Controls.Add(this.Logo_Text);
            this.PanelUp.Controls.Add(this.Logo);
            resources.ApplyResources(this.PanelUp, "PanelUp");
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUp_MouseDown);
            // 
            // Profile
            // 
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Image = global::Academic_Challenge.Properties.Resources.profile;
            this.Profile.ImageRotate = 0F;
            resources.ApplyResources(this.Profile, "Profile");
            this.Profile.Name = "Profile";
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
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
            // 
            // FormSettings
            // 
            this.FormSettings.AnimateWindow = true;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DockIndicatorTransparencyValue = 0.6D;
            this.FormSettings.DragStartTransparencyValue = 1D;
            this.FormSettings.TransparentWhileDrag = true;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Text1, "Text1");
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Text1.IsSelectionEnabled = false;
            this.Text1.Name = "Text1";
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Text2, "Text2");
            this.Text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Text2.IsSelectionEnabled = false;
            this.Text2.Name = "Text2";
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Text3, "Text3");
            this.Text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Text3.IsSelectionEnabled = false;
            this.Text3.Name = "Text3";
            // 
            // Button_Tests
            // 
            this.Button_Tests.Animated = true;
            this.Button_Tests.BorderRadius = 10;
            this.Button_Tests.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Tests.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Tests.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Tests.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Tests.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.Button_Tests, "Button_Tests");
            this.Button_Tests.ForeColor = System.Drawing.Color.White;
            this.Button_Tests.Name = "Button_Tests";
            this.Button_Tests.Click += new System.EventHandler(this.Button_Tests_Click);
            // 
            // Tests_Text
            // 
            this.Tests_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Tests_Text, "Tests_Text");
            this.Tests_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Tests_Text.IsSelectionEnabled = false;
            this.Tests_Text.Name = "Tests_Text";
            // 
            // Book1
            // 
            this.Book1.Image = global::Academic_Challenge.Properties.Resources.book1;
            this.Book1.ImageRotate = 0F;
            resources.ApplyResources(this.Book1, "Book1");
            this.Book1.Name = "Book1";
            this.Book1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Button_Tests);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Tests_Text);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelUp;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Logo_Text;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox Book1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Text1;
        private Guna.UI2.WinForms.Guna2Button Button_Tests;
        private Guna.UI2.WinForms.Guna2HtmlLabel Text3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Text2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Tests_Text;
        private Guna.UI2.WinForms.Guna2PictureBox Profile;
    }
}

