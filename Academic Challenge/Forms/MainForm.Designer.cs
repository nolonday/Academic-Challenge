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
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(1200, 111);
            this.PanelUp.TabIndex = 0;
            this.PanelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUp_MouseDown);
            // 
            // Profile
            // 
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Image = global::Academic_Challenge.Properties.Resources.profile;
            this.Profile.ImageRotate = 0F;
            this.Profile.Location = new System.Drawing.Point(1128, 26);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(60, 60);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile.TabIndex = 3;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
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
            this.Text1.Font = new System.Drawing.Font("Kanit Cyrillic", 26F, System.Drawing.FontStyle.Italic);
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Text1.IsSelectionEnabled = false;
            this.Text1.Location = new System.Drawing.Point(608, 278);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(580, 41);
            this.Text1.TabIndex = 4;
            this.Text1.Text = "✓ Различные уровни сложности";
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Kanit Cyrillic", 26F, System.Drawing.FontStyle.Italic);
            this.Text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Text2.IsSelectionEnabled = false;
            this.Text2.Location = new System.Drawing.Point(608, 325);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(405, 41);
            this.Text2.TabIndex = 5;
            this.Text2.Text = "✓ Разные виды тестов";
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Kanit Cyrillic", 26F, System.Drawing.FontStyle.Italic);
            this.Text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.Text3.IsSelectionEnabled = false;
            this.Text3.Location = new System.Drawing.Point(608, 372);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(306, 41);
            this.Text3.TabIndex = 6;
            this.Text3.Text = "✓ Доска лидеров\r\n";
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
            this.Button_Tests.Font = new System.Drawing.Font("Kanit Cyrillic", 32F, System.Drawing.FontStyle.Bold);
            this.Button_Tests.ForeColor = System.Drawing.Color.White;
            this.Button_Tests.Location = new System.Drawing.Point(708, 548);
            this.Button_Tests.Name = "Button_Tests";
            this.Button_Tests.Size = new System.Drawing.Size(400, 100);
            this.Button_Tests.TabIndex = 7;
            this.Button_Tests.Text = "К тестам";
            this.Button_Tests.Click += new System.EventHandler(this.Button_Tests_Click);
            // 
            // Tests_Text
            // 
            this.Tests_Text.BackColor = System.Drawing.Color.Transparent;
            this.Tests_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 40F, System.Drawing.FontStyle.Bold);
            this.Tests_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Tests_Text.IsSelectionEnabled = false;
            this.Tests_Text.Location = new System.Drawing.Point(487, 180);
            this.Tests_Text.Name = "Tests_Text";
            this.Tests_Text.Size = new System.Drawing.Size(701, 62);
            this.Tests_Text.TabIndex = 3;
            this.Tests_Text.Text = "Образовательные \r\nТесты";
            // 
            // Book1
            // 
            this.Book1.Image = global::Academic_Challenge.Properties.Resources.book1;
            this.Book1.ImageRotate = 0F;
            this.Book1.Location = new System.Drawing.Point(12, 248);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(600, 400);
            this.Book1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Book1.TabIndex = 1;
            this.Book1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.Button_Tests);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Tests_Text);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
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

