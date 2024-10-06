namespace Academic_Challenge
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupAvatar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.UpdateAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.PictureAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GroupInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DateRegText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SwitchPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.UpdateInformation = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.GroupSettings = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ButtonBlack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonBlue = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonUsa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonRussia = new Guna.UI2.WinForms.Guna2CircleButton();
            this.LabelTheme = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelLanguage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ExitAccaunt = new Guna.UI2.WinForms.Guna2Button();
            this.GroupResult = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridTestsResult = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Book1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GroupAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).BeginInit();
            this.GroupInfo.SuspendLayout();
            this.GroupSettings.SuspendLayout();
            this.GroupResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTestsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupAvatar
            // 
            resources.ApplyResources(this.GroupAvatar, "GroupAvatar");
            this.GroupAvatar.Controls.Add(this.UpdateAvatar);
            this.GroupAvatar.Controls.Add(this.PictureAvatar);
            this.GroupAvatar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupAvatar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupAvatar.ForeColor = System.Drawing.Color.White;
            this.GroupAvatar.Name = "GroupAvatar";
            this.GroupAvatar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateAvatar
            // 
            resources.ApplyResources(this.UpdateAvatar, "UpdateAvatar");
            this.UpdateAvatar.Animated = true;
            this.UpdateAvatar.BorderRadius = 10;
            this.UpdateAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.UpdateAvatar.ForeColor = System.Drawing.Color.White;
            this.UpdateAvatar.Name = "UpdateAvatar";
            this.UpdateAvatar.Click += new System.EventHandler(this.UpdateAvatar_Click);
            // 
            // PictureAvatar
            // 
            resources.ApplyResources(this.PictureAvatar, "PictureAvatar");
            this.PictureAvatar.Image = global::Academic_Challenge.Properties.Resources.profile;
            this.PictureAvatar.ImageRotate = 0F;
            this.PictureAvatar.Name = "PictureAvatar";
            this.PictureAvatar.TabStop = false;
            // 
            // GroupInfo
            // 
            resources.ApplyResources(this.GroupInfo, "GroupInfo");
            this.GroupInfo.Controls.Add(this.DateRegText);
            this.GroupInfo.Controls.Add(this.SwitchPass);
            this.GroupInfo.Controls.Add(this.UpdateInformation);
            this.GroupInfo.Controls.Add(this.TextBoxEmail);
            this.GroupInfo.Controls.Add(this.TextBoxPass);
            this.GroupInfo.Controls.Add(this.TextBoxLogin);
            this.GroupInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupInfo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupInfo.ForeColor = System.Drawing.Color.White;
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateRegText
            // 
            resources.ApplyResources(this.DateRegText, "DateRegText");
            this.DateRegText.BackColor = System.Drawing.Color.Transparent;
            this.DateRegText.ForeColor = System.Drawing.Color.Red;
            this.DateRegText.IsSelectionEnabled = false;
            this.DateRegText.Name = "DateRegText";
            // 
            // SwitchPass
            // 
            resources.ApplyResources(this.SwitchPass, "SwitchPass");
            this.SwitchPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwitchPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwitchPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchPass.Name = "SwitchPass";
            this.SwitchPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchPass.CheckedChanged += new System.EventHandler(this.SwitchPass_CheckedChanged);
            // 
            // UpdateInformation
            // 
            resources.ApplyResources(this.UpdateInformation, "UpdateInformation");
            this.UpdateInformation.Animated = true;
            this.UpdateInformation.BorderRadius = 10;
            this.UpdateInformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateInformation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.UpdateInformation.ForeColor = System.Drawing.Color.White;
            this.UpdateInformation.Name = "UpdateInformation";
            this.UpdateInformation.Click += new System.EventHandler(this.UpdateInformation_Click);
            // 
            // TextBoxEmail
            // 
            resources.ApplyResources(this.TextBoxEmail, "TextBoxEmail");
            this.TextBoxEmail.Animated = true;
            this.TextBoxEmail.BorderRadius = 10;
            this.TextBoxEmail.BorderThickness = 3;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
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
            resources.ApplyResources(this.TextBoxPass, "TextBoxPass");
            this.TextBoxPass.Animated = true;
            this.TextBoxPass.BorderRadius = 10;
            this.TextBoxPass.BorderThickness = 3;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.DefaultText = "";
            this.TextBoxPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
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
            resources.ApplyResources(this.TextBoxLogin, "TextBoxLogin");
            this.TextBoxLogin.Animated = true;
            this.TextBoxLogin.BorderRadius = 10;
            this.TextBoxLogin.BorderThickness = 3;
            this.TextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLogin.DefaultText = "";
            this.TextBoxLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TextBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PasswordChar = '\0';
            this.TextBoxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.TextBoxLogin.PlaceholderText = "Login";
            this.TextBoxLogin.SelectedText = "";
            // 
            // GroupSettings
            // 
            resources.ApplyResources(this.GroupSettings, "GroupSettings");
            this.GroupSettings.Controls.Add(this.ButtonBlack);
            this.GroupSettings.Controls.Add(this.ButtonBlue);
            this.GroupSettings.Controls.Add(this.ButtonUsa);
            this.GroupSettings.Controls.Add(this.ButtonRussia);
            this.GroupSettings.Controls.Add(this.LabelTheme);
            this.GroupSettings.Controls.Add(this.LabelLanguage);
            this.GroupSettings.Controls.Add(this.ExitAccaunt);
            this.GroupSettings.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupSettings.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupSettings.ForeColor = System.Drawing.Color.White;
            this.GroupSettings.Name = "GroupSettings";
            this.GroupSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonBlack
            // 
            resources.ApplyResources(this.ButtonBlack, "ButtonBlack");
            this.ButtonBlack.Animated = true;
            this.ButtonBlack.BackgroundImage = global::Academic_Challenge.Properties.Resources.black;
            this.ButtonBlack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBlack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBlack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBlack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBlack.FillColor = System.Drawing.Color.Transparent;
            this.ButtonBlack.ForeColor = System.Drawing.Color.White;
            this.ButtonBlack.Name = "ButtonBlack";
            this.ButtonBlack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonBlack.Click += new System.EventHandler(this.ButtonBlack_Click);
            // 
            // ButtonBlue
            // 
            resources.ApplyResources(this.ButtonBlue, "ButtonBlue");
            this.ButtonBlue.Animated = true;
            this.ButtonBlue.BackgroundImage = global::Academic_Challenge.Properties.Resources.blue;
            this.ButtonBlue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBlue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBlue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBlue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBlue.FillColor = System.Drawing.Color.Transparent;
            this.ButtonBlue.ForeColor = System.Drawing.Color.White;
            this.ButtonBlue.Name = "ButtonBlue";
            this.ButtonBlue.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonBlue.Click += new System.EventHandler(this.ButtonBlue_Click);
            // 
            // ButtonUsa
            // 
            resources.ApplyResources(this.ButtonUsa, "ButtonUsa");
            this.ButtonUsa.Animated = true;
            this.ButtonUsa.BackgroundImage = global::Academic_Challenge.Properties.Resources.usa;
            this.ButtonUsa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUsa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUsa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonUsa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonUsa.FillColor = System.Drawing.Color.Transparent;
            this.ButtonUsa.ForeColor = System.Drawing.Color.White;
            this.ButtonUsa.Name = "ButtonUsa";
            this.ButtonUsa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUsa.Click += new System.EventHandler(this.ButtonUsa_Click);
            // 
            // ButtonRussia
            // 
            resources.ApplyResources(this.ButtonRussia, "ButtonRussia");
            this.ButtonRussia.Animated = true;
            this.ButtonRussia.BackgroundImage = global::Academic_Challenge.Properties.Resources.russia;
            this.ButtonRussia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRussia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRussia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRussia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRussia.FillColor = System.Drawing.Color.Transparent;
            this.ButtonRussia.ForeColor = System.Drawing.Color.White;
            this.ButtonRussia.Name = "ButtonRussia";
            this.ButtonRussia.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonRussia.Click += new System.EventHandler(this.ButtonRussia_Click);
            // 
            // LabelTheme
            // 
            resources.ApplyResources(this.LabelTheme, "LabelTheme");
            this.LabelTheme.BackColor = System.Drawing.Color.Transparent;
            this.LabelTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.LabelTheme.IsSelectionEnabled = false;
            this.LabelTheme.Name = "LabelTheme";
            // 
            // LabelLanguage
            // 
            resources.ApplyResources(this.LabelLanguage, "LabelLanguage");
            this.LabelLanguage.BackColor = System.Drawing.Color.Transparent;
            this.LabelLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.LabelLanguage.IsSelectionEnabled = false;
            this.LabelLanguage.Name = "LabelLanguage";
            // 
            // ExitAccaunt
            // 
            resources.ApplyResources(this.ExitAccaunt, "ExitAccaunt");
            this.ExitAccaunt.Animated = true;
            this.ExitAccaunt.BorderRadius = 10;
            this.ExitAccaunt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitAccaunt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitAccaunt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitAccaunt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitAccaunt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.ExitAccaunt.ForeColor = System.Drawing.Color.White;
            this.ExitAccaunt.Name = "ExitAccaunt";
            this.ExitAccaunt.Click += new System.EventHandler(this.ExitAccaunt_Click);
            // 
            // GroupResult
            // 
            resources.ApplyResources(this.GroupResult, "GroupResult");
            this.GroupResult.Controls.Add(this.DataGridTestsResult);
            this.GroupResult.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.GroupResult.FillColor = System.Drawing.Color.WhiteSmoke;
            this.GroupResult.ForeColor = System.Drawing.Color.White;
            this.GroupResult.Name = "GroupResult";
            this.GroupResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridTestsResult
            // 
            resources.ApplyResources(this.DataGridTestsResult, "DataGridTestsResult");
            this.DataGridTestsResult.AllowUserToAddRows = false;
            this.DataGridTestsResult.AllowUserToDeleteRows = false;
            this.DataGridTestsResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kanit Cyrillic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.DataGridTestsResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridTestsResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kanit Cyrillic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTestsResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridTestsResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kanit Cyrillic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridTestsResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridTestsResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DataGridTestsResult.Name = "DataGridTestsResult";
            this.DataGridTestsResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Kanit Cyrillic", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTestsResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridTestsResult.RowHeadersVisible = false;
            this.DataGridTestsResult.RowTemplate.Height = 25;
            this.DataGridTestsResult.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTestsResult.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Kanit Cyrillic", 15F);
            this.DataGridTestsResult.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTestsResult.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTestsResult.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridTestsResult.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DataGridTestsResult.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DataGridTestsResult.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridTestsResult.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridTestsResult.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Kanit Cyrillic", 15F);
            this.DataGridTestsResult.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridTestsResult.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridTestsResult.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridTestsResult.ThemeStyle.ReadOnly = false;
            this.DataGridTestsResult.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTestsResult.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridTestsResult.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Kanit Cyrillic", 10F);
            this.DataGridTestsResult.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.DataGridTestsResult.ThemeStyle.RowsStyle.Height = 25;
            this.DataGridTestsResult.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTestsResult.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            // 
            // Book1
            // 
            resources.ApplyResources(this.Book1, "Book1");
            this.Book1.Image = global::Academic_Challenge.Properties.Resources.book1;
            this.Book1.ImageRotate = 0F;
            this.Book1.Name = "Book1";
            this.Book1.TabStop = false;
            // 
            // ProfileForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupResult);
            this.Controls.Add(this.GroupSettings);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.GroupInfo);
            this.Controls.Add(this.GroupAvatar);
            this.Name = "ProfileForm";
            this.GroupAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).EndInit();
            this.GroupInfo.ResumeLayout(false);
            this.GroupInfo.PerformLayout();
            this.GroupSettings.ResumeLayout(false);
            this.GroupSettings.PerformLayout();
            this.GroupResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTestsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupAvatar;
        private Guna.UI2.WinForms.Guna2PictureBox PictureAvatar;
        private Guna.UI2.WinForms.Guna2Button UpdateAvatar;
        private Guna.UI2.WinForms.Guna2GroupBox GroupInfo;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLogin;
        private Guna.UI2.WinForms.Guna2Button UpdateInformation;
        private Guna.UI2.WinForms.Guna2PictureBox Book1;
        private Guna.UI2.WinForms.Guna2GroupBox GroupSettings;
        private Guna.UI2.WinForms.Guna2Button ExitAccaunt;
        private Guna.UI2.WinForms.Guna2GroupBox GroupResult;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridTestsResult;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SwitchPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel DateRegText;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelTheme;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelLanguage;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonRussia;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonUsa;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonBlack;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonBlue;
    }
}
