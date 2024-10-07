namespace Academic_Challenge
{
    partial class AddTestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTestsForm));
            this.TextBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxComplexity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddTest = new Guna.UI2.WinForms.Guna2Button();
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Test_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Animated = true;
            this.TextBoxName.BorderRadius = 10;
            this.TextBoxName.BorderThickness = 3;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.DefaultText = "";
            this.TextBoxName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxName.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.TextBoxName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxName.Location = new System.Drawing.Point(12, 97);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxName.PlaceholderText = "Name of the test";
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.Size = new System.Drawing.Size(504, 50);
            this.TextBoxName.TabIndex = 27;
            // 
            // TextBoxDesc
            // 
            this.TextBoxDesc.Animated = true;
            this.TextBoxDesc.BorderRadius = 10;
            this.TextBoxDesc.BorderThickness = 3;
            this.TextBoxDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDesc.DefaultText = "";
            this.TextBoxDesc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxDesc.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.TextBoxDesc.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxDesc.Location = new System.Drawing.Point(12, 151);
            this.TextBoxDesc.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.PasswordChar = '\0';
            this.TextBoxDesc.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxDesc.PlaceholderText = "Description of the test";
            this.TextBoxDesc.SelectedText = "";
            this.TextBoxDesc.Size = new System.Drawing.Size(504, 50);
            this.TextBoxDesc.TabIndex = 25;
            // 
            // ComboBoxComplexity
            // 
            this.ComboBoxComplexity.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxComplexity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboBoxComplexity.BorderThickness = 3;
            this.ComboBoxComplexity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxComplexity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxComplexity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ComboBoxComplexity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ComboBoxComplexity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ComboBoxComplexity.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.ComboBoxComplexity.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxComplexity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.ComboBoxComplexity.ItemHeight = 30;
            this.ComboBoxComplexity.Items.AddRange(new object[] {
            "Средний",
            "Сложный",
            "Легкий"});
            this.ComboBoxComplexity.Location = new System.Drawing.Point(12, 206);
            this.ComboBoxComplexity.Name = "ComboBoxComplexity";
            this.ComboBoxComplexity.Size = new System.Drawing.Size(504, 36);
            this.ComboBoxComplexity.TabIndex = 28;
            // 
            // AddTest
            // 
            this.AddTest.Animated = true;
            this.AddTest.BorderRadius = 10;
            this.AddTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddTest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.AddTest.Font = new System.Drawing.Font("Kanit Cyrillic", 13F);
            this.AddTest.ForeColor = System.Drawing.Color.White;
            this.AddTest.Location = new System.Drawing.Point(12, 248);
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(504, 40);
            this.AddTest.TabIndex = 29;
            this.AddTest.Text = "Добавить";
            this.AddTest.Click += new System.EventHandler(this.AddTest_Click);
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
            // Test_Text
            // 
            this.Test_Text.BackColor = System.Drawing.Color.Transparent;
            this.Test_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 40F, System.Drawing.FontStyle.Bold);
            this.Test_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Test_Text.IsSelectionEnabled = false;
            this.Test_Text.Location = new System.Drawing.Point(98, 21);
            this.Test_Text.Name = "Test_Text";
            this.Test_Text.Size = new System.Drawing.Size(418, 62);
            this.Test_Text.TabIndex = 30;
            this.Test_Text.Text = "Добавить тест";
            this.Test_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Test_Text_MouseDown);
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
            this.Logo.TabIndex = 31;
            this.Logo.TabStop = false;
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // AddTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 300);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Test_Text);
            this.Controls.Add(this.AddTest);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxDesc);
            this.Controls.Add(this.ComboBoxComplexity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(535, 300);
            this.MinimumSize = new System.Drawing.Size(535, 300);
            this.Name = "AddTestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить Тест";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBoxName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDesc;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxComplexity;
        private Guna.UI2.WinForms.Guna2Button AddTest;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2HtmlLabel Test_Text;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
    }
}