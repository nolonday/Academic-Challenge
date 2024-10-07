using MySqlX.XDevAPI.Common;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Academic_Challenge
{
    public partial class InformationUserForm : UserControl
    {
        private Methods methods = new Methods(); // Объект для работы с методами
        private string selectedAvatarPath; // Путь к выбранному аватару
        public event EventHandler AvatarUpdated; // Событие для обновления аватара
        private DataBase db = new DataBase(); // Объект базы данных
        private MainAuthForm mainAuthForm; // Ссылка на основную форму авторизации
        private int id; // ID пользователя

        // Конструктор формы
        public InformationUserForm(int id, MainAuthForm mainAuthForm)
        {
            InitializeComponent();
            this.id = id; // Инициализация ID пользователя
            this.mainAuthForm = mainAuthForm; // Сохранение ссылки на основную форму

            // Получаем информацию о пользователе и заполняем поля
            methods.UserInfo(id); // Загружаем информацию о пользователе
            TextBoxEmail.Text = Methods.Email_User; // Заполняем поле Email
            TextBoxLogin.Text = Methods.Login_User; // Заполняем поле Логин
            TextBoxPass.Text = Methods.Password_User; // Заполняем поле Пароль
            ComboBoxRole.Text = Methods.Role_User; // Заполняем поле Роль

            // Загружаем аватар пользователя
            byte[] avatarData = methods.GetAvatarByLogin(Methods.Login_User);
            if (avatarData != null)
            {
                using (var ms = new MemoryStream(avatarData))
                {
                    PictureAvatar.Image = Image.FromStream(ms); // Устанавливаем аватар
                }
            }

            TextBoxTests.Text = Methods.CompletedTests_User.ToString(); // Заполняем количество завершенных тестов
            LoadGrid(id); // Загружаем данные в DataGrid
            ApplyLanguage();
            ApplyTheme();
        }

        // Метод для загрузки данных в DataGrid
        public void LoadGrid(int id)
        {
            DataGridResultUsers.Columns.Clear(); // Очищаем существующие колонки

            // SQL-запрос для получения данных
            string query = $"SELECT Score_ID AS ID, Tests.Name AS `Тест`, Tests.Description AS `Описание`, Score AS `Оценка`, Completed AS `Дата Прохождения` " +
                           $"FROM TestScores INNER JOIN Tests ON TestScores.Test_ID = Tests.Test_ID WHERE User_ID = {id}";

            db.SqlDataReader(query, DataGridResultUsers); // Выполняем запрос и загружаем данные

            // Проверка на наличие колонок
            if (DataGridResultUsers.Columns.Count == 0)
            {
                MessageBox.Show("No columns found. Please check the SQL query.");
                return; // Выход, если нет колонок
            }

            // Скрываем колонку ID
            if (DataGridResultUsers.Columns["ID"] != null)
            {
                DataGridResultUsers.Columns["ID"].Visible = false;
            }

            // Устанавливаем заголовки колонок в зависимости от языка
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                DataGridResultUsers.Columns["Тест"].HeaderText = "Тест";
                DataGridResultUsers.Columns["Описание"].HeaderText = "Описание";
                DataGridResultUsers.Columns["Оценка"].HeaderText = "Оценка";
                DataGridResultUsers.Columns["Дата Прохождения"].HeaderText = "Дата Прохождения";
            }
            else
            {
                DataGridResultUsers.Columns["Тест"].HeaderText = "Test";
                DataGridResultUsers.Columns["Описание"].HeaderText = "Description";
                DataGridResultUsers.Columns["Оценка"].HeaderText = "Score";
                DataGridResultUsers.Columns["Дата Прохождения"].HeaderText = "Completion Date";
            }

            // Добавляем кнопки для изменения и удаления
            AddGridButtons();

            // Выравниваем заголовки и содержимое по центру
            CenterAlignGridColumns();
        }

        // Метод для добавления кнопок "Изменить" и "Удалить" в DataGrid
        private void AddGridButtons()
        {
            // Определение текстов для кнопок в зависимости от языка
            string changeButtonText = Properties.Settings.Default.Language == "ru-RU" ? "Изменить" : "Change";
            string deleteButtonText = Properties.Settings.Default.Language == "ru-RU" ? "Удалить" : "Delete";

            // Кнопка "Изменить"
            DataGridViewButtonColumn changeButton = new DataGridViewButtonColumn
            {
                HeaderText = Properties.Settings.Default.Language == "ru-RU" ? "Изменить" : "Edit",
                Name = "ChgButton",
                Text = changeButtonText,
                UseColumnTextForButtonValue = true
            };
            DataGridResultUsers.Columns.Add(changeButton); // Добавляем кнопку в DataGrid

            // Кнопка "Удалить"
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = Properties.Settings.Default.Language == "ru-RU" ? "Удалить" : "Delete",
                Name = "DelButton",
                Text = deleteButtonText,
                UseColumnTextForButtonValue = true
            };
            DataGridResultUsers.Columns.Add(deleteButton); // Добавляем кнопку в DataGrid
        }

        // Метод для выравнивания заголовков и содержимого ячеек в DataGrid
        private void CenterAlignGridColumns()
        {
            foreach (DataGridViewColumn column in DataGridResultUsers.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравниваем содержимое
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравниваем заголовки
            }
        }

        // Метод для обновления аватара
        private void UpdateAvatar_Click(object sender, EventArgs e)
        {
            byte[] avatar = null; // Массив байтов для хранения аватара
            string selectedAvatarPath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Фильтр для выбора изображения
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedAvatarPath = openFileDialog.FileName; // Получаем путь к выбранному файлу
                    PictureAvatar.Image = Image.FromFile(selectedAvatarPath); // Устанавливаем изображение аватара
                }
            }

            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить аватарку?" : "Change your avatar?";
            string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно изменено!" : "Successfully changed!";
            string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Возникла ошибка {0}" : "An error occurred: {0}";

            if (MessageBox.Show(confirmMessage, "Оповещение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    avatar = ConvertImageToBytes(selectedAvatarPath); // Конвертируем изображение в массив байтов
                    methods.UpdateAvatar(id, avatar); // Обновляем аватар в базе данных
                    MessageBox.Show(successMessage, "Оповещение"); // Уведомление об успешном изменении
                    AvatarUpdated?.Invoke(this, EventArgs.Empty); // Вызываем событие обновления аватара
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(errorMessage, ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Обработка ошибок
                }
            }
        }

        // Метод для конвертации изображения в массив байтов
        private byte[] ConvertImageToBytes(string imagePath)
        {
            return File.ReadAllBytes(imagePath); // Читаем файл изображения в массив байтов
        }

        // Метод для обновления информации о пользователе
        private void UpdateInformation_Click(object sender, EventArgs e)
        {
            // Determine the language-specific messages
            string confirmMessage = Properties.Settings.Default.Language == "ru-RU" ? "Изменить информацию?" : "Change the information?";
            string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно изменено!" : "Successfully changed!";
            string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Возникла ошибка {0}" : "An error occurred: {0}";

            // Confirm information change
            if (MessageBox.Show(confirmMessage, "Оповещение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Update user information
                    methods.UpdateUserAdmin(id, TextBoxEmail.Text, TextBoxLogin.Text, TextBoxPass.Text, ComboBoxRole.Text, Convert.ToInt32(TextBoxTests.Text));
                    MessageBox.Show(successMessage, "Оповещение"); // Notify successful change
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(errorMessage, ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error handling
                }
            }
        }

        // Обработка клика по ячейкам DataGrid
        private void DataGridResultUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Проверка, что индекс строки корректен
            {
                // Определение текстов для подтверждения удаления в зависимости от языка
                string deleteConfirmationMessage = Properties.Settings.Default.Language == "ru-RU" ? "Вы уверены, что хотите удалить этот тест?" : "Are you sure you want to delete this test?";
                string deleteConfirmationTitle = Properties.Settings.Default.Language == "ru-RU" ? "Подтверждение" : "Confirmation";

                if (e.ColumnIndex == DataGridResultUsers.Columns["DelButton"].Index) // Проверка на нажатие кнопки "Удалить"
                {
                    // Подтверждение удаления теста
                    if (MessageBox.Show(deleteConfirmationMessage, deleteConfirmationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id_testscore = Convert.ToInt32(DataGridResultUsers.Rows[e.RowIndex].Cells["ID"].Value); // Получаем ID теста
                        string deleteTestScoresQuery = $"DELETE FROM TestScores WHERE User_ID = {id} AND Score_ID = {id_testscore}"; // Запрос на удаление
                        db.queryExecute(deleteTestScoresQuery); // Выполняем запрос
                        LoadGrid(id); // Перезагружаем данные
                    }
                }
                else if (e.ColumnIndex == DataGridResultUsers.Columns["ChgButton"].Index) // Проверка на нажатие кнопки "Изменить"
                {
                    // Открытие формы для изменения результата
                    int id_score = Convert.ToInt32(DataGridResultUsers.Rows[e.RowIndex].Cells["ID"].Value); // Получаем ID результата
                    UserResultForm userResultForm = new UserResultForm(id_score, id, this); // Создаем новую форму
                    userResultForm.ShowDialog(); // Показываем диалог
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
                TextBoxPass.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxTests.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ComboBoxRole.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                GroupAvatar.CustomBorderColor = Color.FromArgb(7, 8, 91);
                UpdateAvatar.FillColor = Color.FromArgb(7, 8, 91);
                UpdateInformation.FillColor = Color.FromArgb(7, 8, 91);
                GroupInfo.CustomBorderColor = Color.FromArgb(7, 8, 91);
                UpdateInformation.FillColor = Color.FromArgb(7, 8, 91);
                GroupResult.CustomBorderColor = Color.FromArgb(7, 8, 91);
                DataGridResultUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridResultUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                TextBoxEmail.FocusedState.BorderColor = Color.Black;
                TextBoxLogin.FocusedState.BorderColor = Color.Black;
                TextBoxPass.FocusedState.BorderColor = Color.Black;
                TextBoxTests.FocusedState.BorderColor = Color.Black;
                ComboBoxRole.FocusedState.BorderColor = Color.Black;
                GroupAvatar.CustomBorderColor = Color.Black;
                UpdateAvatar.FillColor = Color.Black;
                UpdateInformation.FillColor = Color.Black;
                GroupInfo.CustomBorderColor = Color.Black;
                UpdateInformation.FillColor = Color.Black;
                GroupResult.CustomBorderColor = Color.Black;
                DataGridResultUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridResultUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                Question_Text.Text = "Информация о пользователе";
                GroupInfo.Text = "Информация";
                TextBoxLogin.PlaceholderText = LanguageStrings.Login;
                TextBoxPass.PlaceholderText = LanguageStrings.Password;
                TextBoxTests.PlaceholderText = LanguageStrings.NumberTest;
                UpdateInformation.Text = "Изменить";
                GroupAvatar.Text = "Аватар";
                UpdateAvatar.Text = "Изменить";
                GroupResult.Text = "Результаты";
            }
            else
            {
                Question_Text.Text = "User Information";
                GroupInfo.Text = "Information";
                TextBoxLogin.PlaceholderText = LanguageStrings.Login_US;
                TextBoxPass.PlaceholderText = LanguageStrings.Password_US;
                TextBoxTests.PlaceholderText = LanguageStrings.NumberTest_US;
                UpdateInformation.Text = "Change";
                GroupAvatar.Text = "Avatar";
                UpdateAvatar.Text = "Change";
                GroupResult.Text = "Results";
            }
        }
    }
}
