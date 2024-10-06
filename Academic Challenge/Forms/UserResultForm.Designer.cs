namespace Academic_Challenge
{
    partial class UserResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserResultForm));
            this.ComboBoxScore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UpdateScore = new Guna.UI2.WinForms.Guna2Button();
            this.Score_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxScore
            // 
            this.ComboBoxScore.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxScore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboBoxScore.BorderThickness = 3;
            this.ComboBoxScore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ComboBoxScore.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ComboBoxScore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.ComboBoxScore, "ComboBoxScore");
            this.ComboBoxScore.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxScore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.ComboBoxScore.Items.AddRange(new object[] {
            resources.GetString("ComboBoxScore.Items"),
            resources.GetString("ComboBoxScore.Items1"),
            resources.GetString("ComboBoxScore.Items2"),
            resources.GetString("ComboBoxScore.Items3")});
            this.ComboBoxScore.Name = "ComboBoxScore";
            // 
            // UpdateScore
            // 
            this.UpdateScore.Animated = true;
            this.UpdateScore.BorderRadius = 10;
            this.UpdateScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.UpdateScore, "UpdateScore");
            this.UpdateScore.ForeColor = System.Drawing.Color.White;
            this.UpdateScore.Name = "UpdateScore";
            this.UpdateScore.Click += new System.EventHandler(this.UpdateScore_Click);
            // 
            // Score_Text
            // 
            this.Score_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Score_Text, "Score_Text");
            this.Score_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Score_Text.IsSelectionEnabled = false;
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Score_Text_MouseDown);
            // 
            // FormSettings
            // 
            this.FormSettings.AnimateWindow = true;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DockIndicatorTransparencyValue = 0.6D;
            this.FormSettings.DragStartTransparencyValue = 1D;
            this.FormSettings.TransparentWhileDrag = true;
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
            // UserResultForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.UpdateScore);
            this.Controls.Add(this.ComboBoxScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxScore;
        private Guna.UI2.WinForms.Guna2Button UpdateScore;
        private Guna.UI2.WinForms.Guna2HtmlLabel Score_Text;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
    }
}