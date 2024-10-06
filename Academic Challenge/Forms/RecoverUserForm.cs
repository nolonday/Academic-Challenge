using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge.Forms
{
    public partial class RecoverUserForm : Form
    {
        private Methods methods = new Methods();

        //Коструктор формы
        public RecoverUserForm()
        {
            InitializeComponent();
            TextBoxPass.Visible = false; // Скрыть поле ввода пароля при инициализации
            ApplyTheme(); // Применить тему
            // Установка текста подсказки для полей ввода в зависимости от языка
            TextBoxLogin.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Login_US : LanguageStrings.Login);
            TextBoxCode.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Code_US : LanguageStrings.Code);
            TextBoxPass.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Password_US : LanguageStrings.Password);
        }

        // Обработчик события клика по логотипу
        private void Logo_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрыть текущую форму
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.ShowDialog(); // Показать форму авторизации
        }

        // Обработчик события нажатия кнопки восстановления
        private void ButtonRecover_Click(object sender, EventArgs e)
        {
            // Попытка восстановить пользователя и показать поле пароля, если успешно
            if (methods.RecoveryUser(TextBoxLogin.Text, TextBoxPass.Text))
            {
                string recoverySuccessMessage = Properties.Settings.Default.Language == "ru-RU" ? "Пароль успешно обновлён!" : "Password successfully updated!";
                string recoverySuccessTitle = Properties.Settings.Default.Language == "ru-RU" ? "Успех" : "Success";

                MessageBox.Show(recoverySuccessMessage, recoverySuccessTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Очистка полей ввода
                TextBoxLogin.Text = "";
                TextBoxCode.Text = "";
                TextBoxPass.Text = "";
            }
            else
            {
                string recoveryErrorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Не удалось восстановить пользователя. Пожалуйста, проверьте ваши данные." : "Failed to recover user. Please check your credentials.";
                string recoveryErrorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                MessageBox.Show(recoveryErrorMessage, recoveryErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для проверки существования пользователя
        private void CheckUserRecovery()
        {
            // Проверка, существует ли пользователь с указанным логином
            if (methods.CheckUserRecovery(TextBoxLogin.Text, TextBoxCode.Text))
            {
                TextBoxPass.Visible = true; // Показать поле пароля, если пользователь найден
            }
            else
            {
                // Определяем сообщение на основе языка
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Эта учетная запись не существует." : "This account does not exist.";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                // Показать сообщение об ошибке, если пользователь не найден
                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxPass.Visible = false; // Скрыть поле пароля
            }
        }

        // Обработчик события нажатия клавиши в поле ввода логина
        private void TextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserRecovery(); // Проверка существования пользователя при нажатии Enter
                e.SuppressKeyPress = true; // Подавить нажатие клавиши Enter
            }
        }

        // Обработчик события нажатия клавиши в поле ввода кода
        private void TextBoxCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserRecovery(); // Проверка существования пользователя при нажатии Enter
                e.SuppressKeyPress = true; // Подавить нажатие клавиши Enter
            }
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                TextBoxLogin.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxCode.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxPass.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ButtonRecover.FillColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                TextBoxLogin.FocusedState.BorderColor = Color.Black;
                TextBoxCode.FocusedState.BorderColor = Color.Black;
                TextBoxPass.FocusedState.BorderColor = Color.Black;
                ButtonRecover.FillColor = Color.Black;
            }
        }
    }
}
