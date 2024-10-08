using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class RegistrationsForm : Form
    {
        Methods methods = new Methods(); // Объект для работы с методами
        private string selectedAvatarPath; // Путь к выбранному аватару

        // Коструктор формы
        public RegistrationsForm()
        {
            InitializeComponent(); // Инициализация компонентов формы
            ApplyLanguage();
            ApplyTheme();           
        }

        // Метод для перехода на форму авторизации
        private void AutificationForm_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm(); // Создание формы авторизации
            authorizationForm.Show(); // Показ формы
            this.Close(); // Закрытие текущей формы
        }

        // Метод для перехода форму авторизации
        private void Logo_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
            this.Close();
        }

        // Конвертация изображения в массив байтов
        private byte[] ConvertImageToBytes(string imagePath)
        {
            return File.ReadAllBytes(imagePath); // Чтение файла в массив байтов
        }

        // Проверка корректности электронной почты
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Регулярное выражение для проверки email
            return Regex.IsMatch(email, pattern); // Возвращает true, если email корректный
        }

        // Метод для обработки нажатия кнопки регистрации
        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            // Получение данных
            var mail = TextBoxEmail.Text; // Получение email
            var login = TextBoxLogin.Text; // Получение логина
            var password = TextBoxPass.Text; // Получение пароля
            var code = TextBoxCode.Text;
            DateTime created = DateTime.Now; // Дата создания аккаунта
            byte[] avatar = null; // Массив байтов для аватара

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(code))
            {
                string emptyFieldsMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поля не могут быть пустыми!" : "Please enter data, fields cannot be empty!";
                MessageBox.Show(emptyFieldsMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка существования пользователя
            if (methods.CheckUser(mail, login))
            {
                string userExistsMessage = Properties.Settings.Default.Language == "ru-RU" ? "Такой пользователь есть!" : "User already exists!";
                MessageBox.Show(userExistsMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Конвертация аватара, если он выбран
            if (!string.IsNullOrWhiteSpace(selectedAvatarPath))
            {
                avatar = ConvertImageToBytes(selectedAvatarPath);
            }
            else
            {
                string selectAvatarMessage = Properties.Settings.Default.Language == "ru-RU" ? "Выберите аватар!" : "Please select an avatar!";
                MessageBox.Show(selectAvatarMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка корректности email
            if (!IsValidEmail(mail))
            {
                string invalidEmailMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите корректный адрес электронной почты!" : "Please enter a valid email address!";
                MessageBox.Show(invalidEmailMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка длины логина и пароля
            if (login.Length < 5 || password.Length < 5)
            {
                string shortCredentialsMessage = Properties.Settings.Default.Language == "ru-RU" ? "Логин или пароль не может быть меньше 5!" : "Login or password cannot be less than 5 characters!";
                MessageBox.Show(shortCredentialsMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Регистрация пользователя
                if (methods.RegUser(mail, login, password, created, avatar, code))
                {
                    string registrationSuccessMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешная регистрация" : "Registration successful";
                    MessageBox.Show(registrationSuccessMessage, "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthorizationForm form = new AuthorizationForm(); // Создание формы авторизации
                    form.Show(); // Показ формы
                    this.Close(); // Закрытие текущей формы
                }
                else
                {
                    string registrationErrorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка при регистрации" : "Registration error";
                    MessageBox.Show(registrationErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string generalErrorMessage = string.Format(Properties.Settings.Default.Language == "ru-RU" ? "Произошла ошибка: {0}" : "An error occurred: {0}", ex.Message);
                MessageBox.Show(generalErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для открытия диалога выбора файла изображения
        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Фильтр для выбора изображений
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedAvatarPath = openFileDialog.FileName; // Сохранение пути к выбранному файлу
                    string fileSelectedMessage = Properties.Settings.Default.Language == "ru-RU" ? "Файл выбран" : "File selected";
                    File_Text.Text = fileSelectedMessage; // Обновление текста для отображения статуса
                }
                else
                {
                    string fileNotSelectedMessage = Properties.Settings.Default.Language == "ru-RU" ? "Файл не выбран..." : "File not selected...";
                    File_Text.Text = fileNotSelectedMessage; // Обновление текста при отмене выбора файла
                }
            }

        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                TextBoxEmail.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxLogin.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxCode.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxPass.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ButtonRegistration.FillColor = Color.FromArgb(7, 8, 91);
                Open.FillColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                TextBoxEmail.FocusedState.BorderColor = Color.Black;
                TextBoxLogin.FocusedState.BorderColor = Color.Black;
                TextBoxCode.FocusedState.BorderColor = Color.Black;
                TextBoxPass.FocusedState.BorderColor = Color.Black;
                ButtonRegistration.FillColor = Color.Black;
                Open.FillColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                TextBoxLogin.PlaceholderText = LanguageStrings.Login;
                TextBoxCode.PlaceholderText = LanguageStrings.Code;
                TextBoxPass.PlaceholderText = LanguageStrings.Password;
                File_Text.Text = "Файл не выбран...";
                Reg_Text.Text = "Регистрация";
                Open.Text = "Обзор";
                ButtonRegistration.Text = "Регистрация";
                AutificationForm.Text = "Авторизация";
            }
            else
            {
                TextBoxLogin.PlaceholderText = LanguageStrings.Login_US;
                TextBoxCode.PlaceholderText = LanguageStrings.Code_US;
                TextBoxPass.PlaceholderText = LanguageStrings.Password_US;
                File_Text.Text = "File not selected...";
                Reg_Text.Text = "Registration";
                Open.Text = "Overview";
                ButtonRegistration.Text = "Registration";
                AutificationForm.Text = "Authorization";
            }
        }
    }
}
