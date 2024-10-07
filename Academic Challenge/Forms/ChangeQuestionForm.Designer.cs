namespace Academic_Challenge.Forms
{
    partial class ChangeQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeQuestionForm));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Test_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChgQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxAnswer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxD = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxC = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxB = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxA = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxName = new Guna.UI2.WinForms.Guna2TextBox();
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
            // Test_Text
            // 
            this.Test_Text.BackColor = System.Drawing.Color.Transparent;
            this.Test_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 37F, System.Drawing.FontStyle.Bold);
            this.Test_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Test_Text.IsSelectionEnabled = false;
            this.Test_Text.Location = new System.Drawing.Point(98, 19);
            this.Test_Text.Name = "Test_Text";
            this.Test_Text.Size = new System.Drawing.Size(458, 57);
            this.Test_Text.TabIndex = 36;
            this.Test_Text.Text = "Изменить вопрос";
            this.Test_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Test_Text_MouseDown);
            // 
            // ChgQuestion
            // 
            this.ChgQuestion.Animated = true;
            this.ChgQuestion.BorderRadius = 10;
            this.ChgQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChgQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChgQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChgQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChgQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ChgQuestion.Font = new System.Drawing.Font("Kanit Cyrillic", 13F);
            this.ChgQuestion.ForeColor = System.Drawing.Color.White;
            this.ChgQuestion.Location = new System.Drawing.Point(12, 404);
            this.ChgQuestion.Name = "ChgQuestion";
            this.ChgQuestion.Size = new System.Drawing.Size(549, 40);
            this.ChgQuestion.TabIndex = 49;
            this.ChgQuestion.Text = "Изменить";
            this.ChgQuestion.Click += new System.EventHandler(this.ChgQuestion_Click);
            // 
            // ComboBoxAnswer
            // 
            this.ComboBoxAnswer.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboBoxAnswer.BorderThickness = 3;
            this.ComboBoxAnswer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAnswer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ComboBoxAnswer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ComboBoxAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ComboBoxAnswer.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.ComboBoxAnswer.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.ComboBoxAnswer.ItemHeight = 30;
            this.ComboBoxAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.ComboBoxAnswer.Location = new System.Drawing.Point(12, 362);
            this.ComboBoxAnswer.Name = "ComboBoxAnswer";
            this.ComboBoxAnswer.Size = new System.Drawing.Size(549, 36);
            this.ComboBoxAnswer.TabIndex = 48;
            // 
            // TextBoxD
            // 
            this.TextBoxD.Animated = true;
            this.TextBoxD.BorderRadius = 10;
            this.TextBoxD.BorderThickness = 3;
            this.TextBoxD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxD.DefaultText = "";
            this.TextBoxD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxD.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxD.ForeColor = System.Drawing.Color.Black;
            this.TextBoxD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxD.Location = new System.Drawing.Point(12, 307);
            this.TextBoxD.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.PasswordChar = '\0';
            this.TextBoxD.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxD.PlaceholderText = "Ответ D";
            this.TextBoxD.SelectedText = "";
            this.TextBoxD.Size = new System.Drawing.Size(549, 50);
            this.TextBoxD.TabIndex = 47;
            // 
            // TextBoxC
            // 
            this.TextBoxC.Animated = true;
            this.TextBoxC.BorderRadius = 10;
            this.TextBoxC.BorderThickness = 3;
            this.TextBoxC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxC.DefaultText = "";
            this.TextBoxC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxC.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxC.ForeColor = System.Drawing.Color.Black;
            this.TextBoxC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxC.Location = new System.Drawing.Point(12, 253);
            this.TextBoxC.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.PasswordChar = '\0';
            this.TextBoxC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxC.PlaceholderText = "Ответ C";
            this.TextBoxC.SelectedText = "";
            this.TextBoxC.Size = new System.Drawing.Size(549, 50);
            this.TextBoxC.TabIndex = 46;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Animated = true;
            this.TextBoxB.BorderRadius = 10;
            this.TextBoxB.BorderThickness = 3;
            this.TextBoxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxB.DefaultText = "";
            this.TextBoxB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxB.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxB.ForeColor = System.Drawing.Color.Black;
            this.TextBoxB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxB.Location = new System.Drawing.Point(11, 199);
            this.TextBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.PasswordChar = '\0';
            this.TextBoxB.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxB.PlaceholderText = "Ответ B";
            this.TextBoxB.SelectedText = "";
            this.TextBoxB.Size = new System.Drawing.Size(549, 50);
            this.TextBoxB.TabIndex = 45;
            // 
            // TextBoxA
            // 
            this.TextBoxA.Animated = true;
            this.TextBoxA.BorderRadius = 10;
            this.TextBoxA.BorderThickness = 3;
            this.TextBoxA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxA.DefaultText = "";
            this.TextBoxA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxA.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxA.ForeColor = System.Drawing.Color.Black;
            this.TextBoxA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxA.Location = new System.Drawing.Point(12, 145);
            this.TextBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.PasswordChar = '\0';
            this.TextBoxA.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxA.PlaceholderText = "Ответ А";
            this.TextBoxA.SelectedText = "";
            this.TextBoxA.Size = new System.Drawing.Size(549, 50);
            this.TextBoxA.TabIndex = 44;
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
            this.TextBoxName.Font = new System.Drawing.Font("Kanit Cyrillic", 18F);
            this.TextBoxName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxName.Location = new System.Drawing.Point(12, 91);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxName.PlaceholderText = "Вопрос";
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.Size = new System.Drawing.Size(549, 50);
            this.TextBoxName.TabIndex = 43;
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::Academic_Challenge.Properties.Resources.logo;
            this.Logo.ImageRotate = 0F;
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(12, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 37;
            this.Logo.TabStop = false;
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // ChangeQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.ChgQuestion);
            this.Controls.Add(this.ComboBoxAnswer);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.TextBoxC);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.TextBoxA);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Test_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(575, 450);
            this.MinimumSize = new System.Drawing.Size(575, 450);
            this.Name = "ChangeQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить Вопрос";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Test_Text;
        private Guna.UI2.WinForms.Guna2Button ChgQuestion;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxAnswer;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxD;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxC;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxB;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxA;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxName;
    }
}