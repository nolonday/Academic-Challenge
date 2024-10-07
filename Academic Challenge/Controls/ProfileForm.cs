using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Academic_Challenge
{
    public partial class ProfileForm : UserControl
    {
        private DataBase db = new DataBase(); // Объект базы данных
        public event EventHandler LogoutRequested; // Событие для выхода из аккаунта
        public event EventHandler AvatarUpdated; // Событие для обновления аватара
        public event EventHandler UpdateTheme; // Событие для обновления темы
        private string selectedAvatarPath; // Путь к выбранному аватару
        private Methods methods = new Methods(); // Объект для работы с методами
        private MainAuthForm mainAuthForm; // Ссылка на основную форму авторизации

        // Конструктор формы профиля
        public ProfileForm(MainAuthForm mainAuthForm)
        {
            this.Update();
            InitializeCulture(); // Инициализация культуры
            InitializeComponent(); // Инициализация компонентов
            this.mainAuthForm = mainAuthForm;

            // Получаем ID пользователя и загружаем данные профиля
            int userId = Methods.User_ID;
            LoadUserProfile(userId); // Загружаем профиль пользователя
            LoadGrid(userId); // Загружаем результаты тестов в DataGrid
            ApplyLanguage();
            ApplyTheme(); // Применение темы
        }

        // Метод для инициализации культуры в зависимости от настроек пользователя
        private void InitializeCulture()
        {
            var cultureName = Properties.Settings.Default.Language;
            if (!string.IsNullOrEmpty(cultureName))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(cultureName);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(cultureName);
            }
        }

        // Метод для загрузки профиля пользователя
        private void LoadUserProfile(int userId)
        {
            // Заполняем поля профиля информацией о пользователе
            TextBoxEmail.Text = Methods.Email;
            TextBoxLogin.Text = Methods.Login;
            TextBoxPass.Text = Methods.Password;
            DateRegText.Text = Methods.DateReg.ToString();
            SwitchPass.Checked = true; // По умолчанию скрываем пароль
            TextBoxPass.UseSystemPasswordChar = true; // Используем символы пароля

            // Загружаем аватар пользователя
            byte[] avatarData = methods.GetAvatarByLogin(Methods.Login);
            if (avatarData != null)
            {
                using (var ms = new MemoryStream(avatarData))
                {
                    PictureAvatar.Image = Image.FromStream(ms); // Устанавливаем аватар
                }
            }
        }

        // Метод для конвертации изображения в массив байтов
        private byte[] ConvertImageToBytes(string imagePath)
        {
            return File.ReadAllBytes(imagePath); // Читаем файл изображения в массив байтов
        }

        // Обработчик для выхода из аккаунта
        private void ExitAccaunt_Click(object sender, EventArgs e)
        {
            // Очищаем сохраненные данные логина и пароля
            Properties.Settings.Default.Login = string.Empty;
            Properties.Settings.Default.Pass = string.Empty;
            Properties.Settings.Default.Language = "ru-RU"; // Сброс языка на русский
            Properties.Settings.Default.Theme = "Default"; // Сброс темы на стандартную
            Properties.Settings.Default.Save(); // Сохраняем изменения

            // Запрашиваем выход из аккаунта
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        // Метод для загрузки результатов тестов в DataGrid
        public void LoadGrid(int id)
        {
            string query = $"SELECT Tests.Name AS Тест, Tests.Description AS Описание, Score AS Оценка, Completed AS Дата_Прохождения " +
                           $"FROM TestScores INNER JOIN Tests ON TestScores.Test_ID = Tests.Test_ID WHERE User_ID={id}";

            db.SqlDataReader(query, DataGridTestsResult); // Выполняем запрос и загружаем данные

            // Устанавливаем заголовки колонок в зависимости от языка
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                DataGridTestsResult.Columns["Тест"].HeaderText = "Тест";
                DataGridTestsResult.Columns["Описание"].HeaderText = "Описание";
                DataGridTestsResult.Columns["Оценка"].HeaderText = "Оценка";
                DataGridTestsResult.Columns["Дата_Прохождения"].HeaderText = "Дата Прохождения"; // Замените на правильное имя
            }
            else
            {
                DataGridTestsResult.Columns["Тест"].HeaderText = "Test";
                DataGridTestsResult.Columns["Описание"].HeaderText = "Description";
                DataGridTestsResult.Columns["Оценка"].HeaderText = "Score";
                DataGridTestsResult.Columns["Дата_Прохождения"].HeaderText = "Completion Date"; // Замените на правильное имя
            }
            CenterAlignGridColumns(); // Выравниваем заголовки и содержимое ячеек
        }

        // Метод для выравнивания заголовков и содержимого ячеек в DataGrid
        private void CenterAlignGridColumns()
        {
            foreach (DataGridViewColumn column in DataGridTestsResult.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравниваем содержимое
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравниваем заголовки
            }
        }

        // Обработчик для обновления аватара
        private void UpdateAvatar_Click(object sender, EventArgs e)
        {
            byte[] avatar = null; // Массив байтов для хранения аватара
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Фильтр для выбора изображения
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedAvatarPath = openFileDialog.FileName; // Получаем путь к выбранному файлу
                    PictureAvatar.Image = Image.FromFile(selectedAvatarPath); // Устанавливаем изображение аватара
                }
            }

            // Определяем тексты для сообщений в зависимости от языка
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить аватарку?" : "Change your avatar?";
            string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно изменено!" : "Successfully changed!";
            string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Возникла ошибка {0}" : "An error occurred: {0}";

            if (MessageBox.Show(confirmMessage, "Оповещение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    avatar = ConvertImageToBytes(selectedAvatarPath); // Конвертируем изображение в массив байтов
                    methods.UpdateAvatar(Methods.User_ID, avatar); // Обновляем аватар в базе данных
                    MessageBox.Show(successMessage, "Оповещение"); // Уведомление об успешном изменении
                    AvatarUpdated?.Invoke(this, EventArgs.Empty); // Вызываем событие обновления аватара
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(errorMessage, ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Обработка ошибок
                }
            }
        }

        // Обработчик изменения состояния переключателя показа пароля
        private void SwitchPass_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPass.UseSystemPasswordChar = SwitchPass.Checked; // Показываем или скрываем пароль
        }

        // Обработчик для обновления информации о пользователе
        private void UpdateInformation_Click(object sender, EventArgs e)
        {
            // Определяем тексты для сообщений в зависимости от языка
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить информацию?" : "Change the information?";
            string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно изменено!" : "Successfully changed!";
            string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Возникла ошибка {0}" : "An error occurred: {0}";

            // Подтверждение изменения информации
            if (MessageBox.Show(confirmMessage, "Оповещение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    methods.UpdateUser(Methods.User_ID, TextBoxEmail.Text, TextBoxLogin.Text, TextBoxPass.Text); // Обновляем информацию о пользователе
                    MessageBox.Show(successMessage, "Оповещение"); // Уведомление об успешном изменении
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(errorMessage, ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Обработка ошибок
                }
            }
        }

        // Обработчик для изменения языка на русский
        private void ButtonRussia_Click(object sender, EventArgs e)
        {
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить язык на Русский?" : "Change the language to Russian?";

            if (MessageBox.Show(confirmMessage, Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Language = "ru-RU"; // Устанавливаем язык
                Properties.Settings.Default.Save(); // Сохраняем настройки

                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно" : "Successfully";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";
                MessageBox.Show(successMessage, successTitle); // Уведомление об успешном изменении

                InitializeCulture(); // Инициализация культуры
                mainAuthForm.LoadProfile(); // Перезагружаем профиль
                
            }
        }

        // Обработчик для изменения языка на английский
        private void ButtonUsa_Click(object sender, EventArgs e)
        {
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить язык на Английский?" : "Change the language to English?";
            if (MessageBox.Show(confirmMessage, Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Language = "en-US"; // Устанавливаем язык
                Properties.Settings.Default.Save(); // Сохраняем настройки

                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно" : "Successfully";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";
                MessageBox.Show(successMessage, successTitle); // Уведомление об успешном изменении

                InitializeCulture(); // Инициализация культуры
                mainAuthForm.LoadProfile(); // Перезагружаем профиль
            }
        }

        // Обработчик для изменения темы на стандартную
        private void ButtonBlue_Click(object sender, EventArgs e)
        {
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить тему на обычную?" : "Change the theme to a regular one?";

            if (MessageBox.Show(confirmMessage, Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Theme = "Default"; // Устанавливаем тему
                Properties.Settings.Default.Save(); // Сохраняем настройки

                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно" : "Successfully";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";
                MessageBox.Show(successMessage, successTitle); // Уведомление об успешном изменении

                ApplyTheme(); // Применяем тему
                UpdateTheme?.Invoke(this, EventArgs.Empty); // Вызываем событие обновления темы
            }
        }

        // Обработчик для изменения темы на темную
        private void ButtonBlack_Click(object sender, EventArgs e)
        {
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить тему на тёмную?" : "Change the theme to dark?";

            if (MessageBox.Show(confirmMessage, Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Theme = "Black"; // Устанавливаем тему
                Properties.Settings.Default.Save(); // Сохраняем настройки

                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно" : "Successfully";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";
                MessageBox.Show(successMessage, successTitle); // Уведомление об успешном изменении

                ApplyTheme(); // Применяем тему
                UpdateTheme?.Invoke(this, EventArgs.Empty); // Вызываем событие обновления темы
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
                TextBoxPass.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                GroupAvatar.CustomBorderColor = Color.FromArgb(7, 8, 91);
                UpdateAvatar.FillColor = Color.FromArgb(7, 8, 91);
                GroupInfo.CustomBorderColor = Color.FromArgb(7, 8, 91);
                UpdateInformation.FillColor = Color.FromArgb(7, 8, 91);
                GroupSettings.CustomBorderColor = Color.FromArgb(7, 8, 91);
                LabelLanguage.ForeColor = Color.FromArgb(7, 8, 91);
                LabelTheme.ForeColor = Color.FromArgb(7, 8, 91);
                ExitAccaunt.FillColor = Color.FromArgb(7, 8, 91);
                GroupResult.CustomBorderColor = Color.FromArgb(7, 8, 91);
                DataGridTestsResult.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridTestsResult.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                TextBoxEmail.FocusedState.BorderColor = Color.Black;
                TextBoxLogin.FocusedState.BorderColor = Color.Black;
                TextBoxPass.FocusedState.BorderColor = Color.Black;
                GroupAvatar.CustomBorderColor = Color.Black;
                UpdateAvatar.FillColor = Color.Black;
                GroupInfo.CustomBorderColor = Color.Black;
                UpdateInformation.FillColor = Color.Black;
                GroupSettings.CustomBorderColor = Color.Black;
                LabelLanguage.ForeColor = Color.Black;
                LabelTheme.ForeColor = Color.Black;
                ExitAccaunt.FillColor = Color.Black;
                GroupResult.CustomBorderColor = Color.Black;
                DataGridTestsResult.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridTestsResult.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                GroupInfo.Text = "Информация";
                TextBoxLogin.PlaceholderText = LanguageStrings.Login;
                TextBoxPass.PlaceholderText = LanguageStrings.Password;
                UpdateInformation.Text = "Изменить";
                GroupAvatar.Text = "Аватар";
                UpdateAvatar.Text = "Изменить";
                GroupResult.Text = "Результаты";
                GroupSettings.Text = "Настройки";
                LabelLanguage.Text = "Язык";
                LabelTheme.Text = "Тема";
                ExitAccaunt.Text = "Выход из аккаунта";
            }
            else
            {
                GroupInfo.Text = "Information";
                TextBoxLogin.PlaceholderText = LanguageStrings.Login_US;
                TextBoxPass.PlaceholderText = LanguageStrings.Password_US;
                UpdateInformation.Text = "Change";
                GroupAvatar.Text = "Avatar";
                UpdateAvatar.Text = "Change";
                GroupResult.Text = "Results";
                GroupSettings.Text = "Settings";
                LabelLanguage.Text = "Language";
                LabelTheme.Text = "Theme";
                ExitAccaunt.Text = "Log out of your account";
            }
        }
    }
}
