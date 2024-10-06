using Academic_Challenge.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent(); // Инициализация компонентов формы
            ApplyTheme();
            TextBoxLogin.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Login_US : LanguageStrings.Login);
            TextBoxPass.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Password_US : LanguageStrings.Password);
        }

        // Метод, вызываемый при нажатии на кнопку "Регистрация"
        private void RegistrationForm_Click(object sender, EventArgs e)
        {
            RegistrationsForm reg = new RegistrationsForm(); // Создаем экземпляр формы регистрации
            reg.Show(); // Показываем форму регистрации
            this.Close(); // Закрываем текущую форму авторизации
        }

        // Метод, вызываемый при нажатии на логотип
        private void Logo_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(); // Создаем экземпляр главной формы
            mainForm.Show(); // Показываем главную форму
            this.Close(); // Закрываем текущую форму авторизации
        }

        // Метод, вызываемый при нажатии кнопки "Войти"
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            // Сохранение настроек языка и темы
            Properties.Settings.Default.Language = "ru-RU";
            Properties.Settings.Default.Theme = "Default";
            Properties.Settings.Default.Save(); // Сохранение изменений

            var login = TextBoxLogin.Text; // Получаем логин из текстового поля
            var password = TextBoxPass.Text; // Получаем пароль из текстового поля

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                string emptyFieldsMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поля не могут быть пустыми!" : "Please enter data, fields cannot be empty!";
                MessageBox.Show(emptyFieldsMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода
            }

            // Проверка на минимальную длину логина и пароля
            if (login.Length < 5 || password.Length < 5)
            {
                string shortCredentialsMessage = Properties.Settings.Default.Language == "ru-RU" ? "Логин или пароль не может быть меньше 5!" : "Login or password cannot be less than 5 characters!";
                MessageBox.Show(shortCredentialsMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода
            }

            var methods = new Methods(); // Создаем объект для работы с методами
                                         // Проверка пользователя
            if (methods.AuthUser(login, password))
            {
                // Сохранение данных пользователя в настройках
                Properties.Settings.Default.Login = login;
                Properties.Settings.Default.Pass = password;
                Properties.Settings.Default.DateReg = Methods.DateReg;
                Properties.Settings.Default.Role = Methods.Role;
                Properties.Settings.Default.Save();

                string welcomeMessage = Properties.Settings.Default.Language == "ru-RU" ? "Добро пожаловать" : "Welcome";
                MessageBox.Show(welcomeMessage, "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainAuthForm mainAuthForm = new MainAuthForm(login); // Создаем главную форму для авторизованного пользователя
                mainAuthForm.Show(); // Показываем главную форму
                mainAuthForm.LoadSubjects();
                this.Hide(); // Скрываем текущую форму авторизации
            }
            else
            {
                string authErrorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка, такого аккаунта не существует" : "Error, such an account does not exist";
                MessageBox.Show(authErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Метод, вызываемый при двойном щелчке на логотипе
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из приложения
        }

        // Метод, вызываемый при нажатии на кнопку восстановления пароля
        private void ReturnPass_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем текущую форму
            RecoverUserForm recoverUserForm = new RecoverUserForm(); // Создаем форму восстановления пароля
            recoverUserForm.Show(); // Показываем форму восстановления пароля
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                TextBoxLogin.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxPass.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ButtonEnter.FillColor = Color.FromArgb(7, 8, 91); 
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                TextBoxLogin.FocusedState.BorderColor = Color.Black;
                TextBoxPass.FocusedState.BorderColor = Color.Black;
                ButtonEnter.FillColor = Color.Black;
            }
        }
    }
}
