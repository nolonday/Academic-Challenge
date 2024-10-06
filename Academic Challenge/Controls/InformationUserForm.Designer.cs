namespace Academic_Challenge
{
    partial class InformationUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationUserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Question_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GroupResult = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridResultUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GroupInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TextBoxTests = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateInformation = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.GroupAvatar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.UpdateAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.PictureAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxInfo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GroupResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResultUsers)).BeginInit();
            this.GroupInfo.SuspendLayout();
            this.GroupAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Question_Text
            // 
            this.Question_Text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Question_Text, "Question_Text");
            this.Question_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Question_Text.IsSelectionEnabled = false;
            this.Question_Text.Name = "Question_Text";
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboBoxRole.BorderThickness = 3;
            this.ComboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ComboBoxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ComboBoxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.ComboBoxRole, "ComboBoxRole");
            this.ComboBoxRole.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.ComboBoxRole.Items.AddRange(new object[] {
            resources.GetString("ComboBoxRole.Items"),
            resources.GetString("ComboBoxRole.Items1")});
            this.ComboBoxRole.Name = "ComboBoxRole";
            // 
            // GroupResult
            // 
            this.GroupResult.Controls.Add(this.DataGridResultUsers);
            this.GroupResult.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupResult.FillColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.GroupResult, "GroupResult");
            this.GroupResult.ForeColor = System.Drawing.Color.White;
            this.GroupResult.Name = "GroupResult";
            this.GroupResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridResultUsers
            // 
            this.DataGridResultUsers.AllowUserToAddRows = false;
            this.DataGridResultUsers.AllowUserToDeleteRows = false;
            this.DataGridResultUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kanit Cyrillic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.DataGridResultUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridResultUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kanit Cyrillic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridResultUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.DataGridResultUsers, "DataGridResultUsers");
            this.DataGridResultUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kanit Cyrillic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridResultUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridResultUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DataGridResultUsers.Name = "DataGridResultUsers";
            this.DataGridResultUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Kanit Cyrillic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridResultUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridResultUsers.RowHeadersVisible = false;
            this.DataGridResultUsers.RowTemplate.Height = 35;
            this.DataGridResultUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridResultUsers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Kanit Cyrillic", 15F);
            this.DataGridResultUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridResultUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridResultUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridResultUsers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DataGridResultUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DataGridResultUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridResultUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridResultUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Kanit Cyrillic", 15F);
            this.DataGridResultUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridResultUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridResultUsers.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridResultUsers.ThemeStyle.ReadOnly = false;
            this.DataGridResultUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridResultUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridResultUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Kanit Cyrillic", 10F);
            this.DataGridResultUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridResultUsers.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridResultUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridResultUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridResultUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridResultUsers_CellClick);
            // 
            // GroupInfo
            // 
            this.GroupInfo.Controls.Add(this.TextBoxTests);
            this.GroupInfo.Controls.Add(this.UpdateInformation);
            this.GroupInfo.Controls.Add(this.TextBoxEmail);
            this.GroupInfo.Controls.Add(this.TextBoxPass);
            this.GroupInfo.Controls.Add(this.TextBoxLogin);
            this.GroupInfo.Controls.Add(this.ComboBoxRole);
            this.GroupInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupInfo.FillColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.GroupInfo, "GroupInfo");
            this.GroupInfo.ForeColor = System.Drawing.Color.White;
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxTests
            // 
            this.TextBoxTests.Animated = true;
            this.TextBoxTests.BorderRadius = 10;
            this.TextBoxTests.BorderThickness = 3;
            this.TextBoxTests.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTests.DefaultText = "";
            this.TextBoxTests.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxTests.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxTests, "TextBoxTests");
            this.TextBoxTests.ForeColor = System.Drawing.Color.Black;
            this.TextBoxTests.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxTests.Name = "TextBoxTests";
            this.TextBoxTests.PasswordChar = '\0';
            this.TextBoxTests.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxTests.PlaceholderText = "Number of tests";
            this.TextBoxTests.SelectedText = "";
            // 
            // UpdateInformation
            // 
            this.UpdateInformation.Animated = true;
            this.UpdateInformation.BorderRadius = 10;
            this.UpdateInformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateInformation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.UpdateInformation, "UpdateInformation");
            this.UpdateInformation.ForeColor = System.Drawing.Color.White;
            this.UpdateInformation.Name = "UpdateInformation";
            this.UpdateInformation.Click += new System.EventHandler(this.UpdateInformation_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Animated = true;
            this.TextBoxEmail.BorderRadius = 10;
            this.TextBoxEmail.BorderThickness = 3;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.TextBoxEmail, "TextBoxEmail");
            this.TextBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxEmail.PlaceholderText = "Email";
            this.TextBoxEmail.SelectedText = "";
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
            resources.ApplyResources(this.TextBoxPass, "TextBoxPass");
            this.TextBoxPass.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '\0';
            this.TextBoxPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxPass.PlaceholderText = "Password";
            this.TextBoxPass.SelectedText = "";
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
            resources.ApplyResources(this.TextBoxLogin, "TextBoxLogin");
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PasswordChar = '\0';
            this.TextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxLogin.PlaceholderText = "Login";
            this.TextBoxLogin.SelectedText = "";
            // 
            // GroupAvatar
            // 
            this.GroupAvatar.Controls.Add(this.UpdateAvatar);
            this.GroupAvatar.Controls.Add(this.PictureAvatar);
            this.GroupAvatar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupAvatar.FillColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.GroupAvatar, "GroupAvatar");
            this.GroupAvatar.ForeColor = System.Drawing.Color.White;
            this.GroupAvatar.Name = "GroupAvatar";
            this.GroupAvatar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateAvatar
            // 
            this.UpdateAvatar.Animated = true;
            this.UpdateAvatar.BorderRadius = 10;
            this.UpdateAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.UpdateAvatar, "UpdateAvatar");
            this.UpdateAvatar.ForeColor = System.Drawing.Color.White;
            this.UpdateAvatar.Name = "UpdateAvatar";
            this.UpdateAvatar.Click += new System.EventHandler(this.UpdateAvatar_Click);
            // 
            // PictureAvatar
            // 
            this.PictureAvatar.BackColor = System.Drawing.Color.White;
            this.PictureAvatar.Image = global::Academic_Challenge.Properties.Resources.profile;
            this.PictureAvatar.ImageRotate = 0F;
            resources.ApplyResources(this.PictureAvatar, "PictureAvatar");
            this.PictureAvatar.Name = "PictureAvatar";
            this.PictureAvatar.TabStop = false;
            // 
            // PictureBoxInfo
            // 
            this.PictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxInfo.FillColor = System.Drawing.Color.DarkGray;
            this.PictureBoxInfo.Image = global::Academic_Challenge.Properties.Resources.userinfo;
            this.PictureBoxInfo.ImageRotate = 0F;
            resources.ApplyResources(this.PictureBoxInfo, "PictureBoxInfo");
            this.PictureBoxInfo.Name = "PictureBoxInfo";
            this.PictureBoxInfo.TabStop = false;
            // 
            // InformationUserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureBoxInfo);
            this.Controls.Add(this.GroupResult);
            this.Controls.Add(this.GroupInfo);
            this.Controls.Add(this.GroupAvatar);
            this.Controls.Add(this.Question_Text);
            this.Name = "InformationUserForm";
            this.GroupResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResultUsers)).EndInit();
            this.GroupInfo.ResumeLayout(false);
            this.GroupAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Question_Text;
        private Guna.UI2.WinForms.Guna2PictureBox PictureAvatar;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxRole;
        private Guna.UI2.WinForms.Guna2GroupBox GroupResult;
        private Guna.UI2.WinForms.Guna2GroupBox GroupInfo;
        private Guna.UI2.WinForms.Guna2Button UpdateInformation;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLogin;
        private Guna.UI2.WinForms.Guna2GroupBox GroupAvatar;
        private Guna.UI2.WinForms.Guna2Button UpdateAvatar;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTests;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxInfo;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridResultUsers;
    }
}
