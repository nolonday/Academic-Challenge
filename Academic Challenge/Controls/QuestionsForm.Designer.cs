namespace Academic_Challenge
{
    partial class QuestionsForm
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
            this.Question_Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Save_Question = new Guna.UI2.WinForms.Guna2Button();
            this.Desc_Text = new System.Windows.Forms.Label();
            this.PanelText = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxAnswer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ButtonD = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ButtonC = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ButtonB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ButtonA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PanelText.SuspendLayout();
            this.GroupBoxAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question_Text
            // 
            this.Question_Text.BackColor = System.Drawing.Color.Transparent;
            this.Question_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 40F, System.Drawing.FontStyle.Bold);
            this.Question_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.Question_Text.IsSelectionEnabled = false;
            this.Question_Text.Location = new System.Drawing.Point(20, 34);
            this.Question_Text.Name = "Question_Text";
            this.Question_Text.Size = new System.Drawing.Size(210, 62);
            this.Question_Text.TabIndex = 13;
            this.Question_Text.Text = "Вопрос";
            // 
            // Save_Question
            // 
            this.Save_Question.Animated = true;
            this.Save_Question.BorderRadius = 10;
            this.Save_Question.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save_Question.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save_Question.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save_Question.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save_Question.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(91)))));
            this.Save_Question.Font = new System.Drawing.Font("Kanit Cyrillic", 13F);
            this.Save_Question.ForeColor = System.Drawing.Color.White;
            this.Save_Question.Location = new System.Drawing.Point(185, 593);
            this.Save_Question.Name = "Save_Question";
            this.Save_Question.Size = new System.Drawing.Size(847, 48);
            this.Save_Question.TabIndex = 19;
            this.Save_Question.Text = "Ответить";
            this.Save_Question.Click += new System.EventHandler(this.Save_Question_Click);
            // 
            // Desc_Text
            // 
            this.Desc_Text.AutoSize = true;
            this.Desc_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desc_Text.Font = new System.Drawing.Font("Kanit Cyrillic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_Text.ForeColor = System.Drawing.Color.Black;
            this.Desc_Text.Location = new System.Drawing.Point(3, 0);
            this.Desc_Text.MaximumSize = new System.Drawing.Size(0, 125);
            this.Desc_Text.Name = "Desc_Text";
            this.Desc_Text.Size = new System.Drawing.Size(93, 24);
            this.Desc_Text.TabIndex = 0;
            this.Desc_Text.Text = "Вопрос";
            // 
            // PanelText
            // 
            this.PanelText.Controls.Add(this.Desc_Text);
            this.PanelText.Location = new System.Drawing.Point(480, 34);
            this.PanelText.Name = "PanelText";
            this.PanelText.Size = new System.Drawing.Size(697, 59);
            this.PanelText.TabIndex = 22;
            // 
            // GroupBoxAnswer
            // 
            this.GroupBoxAnswer.BorderColor = System.Drawing.Color.White;
            this.GroupBoxAnswer.Controls.Add(this.ButtonD);
            this.GroupBoxAnswer.Controls.Add(this.ButtonC);
            this.GroupBoxAnswer.Controls.Add(this.ButtonB);
            this.GroupBoxAnswer.Controls.Add(this.ButtonA);
            this.GroupBoxAnswer.CustomBorderColor = System.Drawing.Color.White;
            this.GroupBoxAnswer.Font = new System.Drawing.Font("Kanit Cyrillic", 20F, System.Drawing.FontStyle.Bold);
            this.GroupBoxAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.GroupBoxAnswer.Location = new System.Drawing.Point(185, 169);
            this.GroupBoxAnswer.Name = "GroupBoxAnswer";
            this.GroupBoxAnswer.Size = new System.Drawing.Size(847, 359);
            this.GroupBoxAnswer.TabIndex = 3;
            this.GroupBoxAnswer.Text = "Ответы";
            this.GroupBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonD
            // 
            this.ButtonD.AutoSize = true;
            this.ButtonD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonD.CheckedState.BorderThickness = 0;
            this.ButtonD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonD.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ButtonD.CheckedState.InnerOffset = -4;
            this.ButtonD.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonD.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.ButtonD.Location = new System.Drawing.Point(0, 199);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonD.Size = new System.Drawing.Size(847, 53);
            this.ButtonD.TabIndex = 0;
            this.ButtonD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ButtonD.UncheckedState.BorderThickness = 2;
            this.ButtonD.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonD.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ButtonC
            // 
            this.ButtonC.AutoSize = true;
            this.ButtonC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonC.CheckedState.BorderThickness = 0;
            this.ButtonC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonC.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ButtonC.CheckedState.InnerOffset = -4;
            this.ButtonC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonC.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.ButtonC.Location = new System.Drawing.Point(0, 146);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonC.Size = new System.Drawing.Size(847, 53);
            this.ButtonC.TabIndex = 2;
            this.ButtonC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ButtonC.UncheckedState.BorderThickness = 2;
            this.ButtonC.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonC.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ButtonB
            // 
            this.ButtonB.AutoSize = true;
            this.ButtonB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonB.CheckedState.BorderThickness = 0;
            this.ButtonB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ButtonB.CheckedState.InnerOffset = -4;
            this.ButtonB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonB.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.ButtonB.Location = new System.Drawing.Point(0, 93);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonB.Size = new System.Drawing.Size(847, 53);
            this.ButtonB.TabIndex = 2;
            this.ButtonB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ButtonB.UncheckedState.BorderThickness = 2;
            this.ButtonB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ButtonA
            // 
            this.ButtonA.AutoSize = true;
            this.ButtonA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonA.CheckedState.BorderThickness = 0;
            this.ButtonA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ButtonA.CheckedState.InnerOffset = -4;
            this.ButtonA.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonA.Font = new System.Drawing.Font("Kanit Cyrillic", 14F);
            this.ButtonA.Location = new System.Drawing.Point(0, 40);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonA.Size = new System.Drawing.Size(847, 53);
            this.ButtonA.TabIndex = 2;
            this.ButtonA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ButtonA.UncheckedState.BorderThickness = 2;
            this.ButtonA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ButtonA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBoxAnswer);
            this.Controls.Add(this.PanelText);
            this.Controls.Add(this.Save_Question);
            this.Controls.Add(this.Question_Text);
            this.Name = "QuestionsForm";
            this.Size = new System.Drawing.Size(1200, 689);
            this.PanelText.ResumeLayout(false);
            this.PanelText.PerformLayout();
            this.GroupBoxAnswer.ResumeLayout(false);
            this.GroupBoxAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Question_Text;
        private Guna.UI2.WinForms.Guna2Button Save_Question;
        private System.Windows.Forms.Label Desc_Text;
        private System.Windows.Forms.FlowLayoutPanel PanelText;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxAnswer;
        private Guna.UI2.WinForms.Guna2RadioButton ButtonA;
        private Guna.UI2.WinForms.Guna2RadioButton ButtonD;
        private Guna.UI2.WinForms.Guna2RadioButton ButtonB;
        private Guna.UI2.WinForms.Guna2RadioButton ButtonC;
    }
}
