namespace Academic_Challenge
{
    partial class ChangeTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTestForm));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ChgTest = new Guna.UI2.WinForms.Guna2Button();
            this.Test_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxComplexity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
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
            // ChgTest
            // 
            this.ChgTest.Animated = true;
            this.ChgTest.BorderRadius = 10;
            this.ChgTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChgTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChgTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChgTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChgTest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.ChgTest, "ChgTest");
            this.ChgTest.ForeColor = System.Drawing.Color.White;
            this.ChgTest.Name = "ChgTest";
            this.ChgTest.Click += new System.EventHandler(this.ChgTest_Click);
            // 
            // Test_Text
            // 
            this.Test_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Test_Text, "Test_Text");
            this.Test_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Test_Text.IsSelectionEnabled = false;
            this.Test_Text.Name = "Test_Text";
            this.Test_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Test_Text_MouseDown);
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
            resources.ApplyResources(this.TextBoxName, "TextBoxName");
            this.TextBoxName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxName.PlaceholderText = "Name of the test";
            this.TextBoxName.SelectedText = "";
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
            resources.ApplyResources(this.TextBoxDesc, "TextBoxDesc");
            this.TextBoxDesc.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.PasswordChar = '\0';
            this.TextBoxDesc.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxDesc.PlaceholderText = "Description of the test";
            this.TextBoxDesc.SelectedText = "";
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
            resources.ApplyResources(this.ComboBoxComplexity, "ComboBoxComplexity");
            this.ComboBoxComplexity.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxComplexity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.ComboBoxComplexity.Items.AddRange(new object[] {
            resources.GetString("ComboBoxComplexity.Items"),
            resources.GetString("ComboBoxComplexity.Items1"),
            resources.GetString("ComboBoxComplexity.Items2")});
            this.ComboBoxComplexity.Name = "ComboBoxComplexity";
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::Academic_Challenge.Properties.Resources.logo;
            this.Logo.ImageRotate = 0F;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // ChangeTestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxDesc);
            this.Controls.Add(this.ComboBoxComplexity);
            this.Controls.Add(this.ChgTest);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Test_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2Button ChgTest;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Test_Text;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDesc;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxComplexity;
    }
}