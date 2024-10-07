using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class UsersForm : UserControl
    {
        private DataBase db = new DataBase(); // Объект для работы с базой данных
        private MainAuthForm mainAuthForm; // Ссылка на основную форму авторизации

        // Конструктор формы
        public UsersForm(MainAuthForm mainAuthForm)
        {
            InitializeComponent();
            this.mainAuthForm = mainAuthForm; // Сохраняем ссылку на основную форму
            LoadGrid(); // Загружаем данные в DataGrid при инициализации
            ApplyLanguage();
            ApplyTheme();
        }

        // Метод для загрузки данных пользователей в DataGrid
        public void LoadGrid()
        {
            DataGridUsers.Columns.Clear(); // Очищаем колонки перед загрузкой новых данных

            // Определяем названия колонок на основе языка
            string emailColumn = Properties.Settings.Default.Language == "ru-RU" ? "Почта" : "Email";
            string loginColumn = Properties.Settings.Default.Language == "ru-RU" ? "Логин" : "Login";
            string passwordColumn = Properties.Settings.Default.Language == "ru-RU" ? "Пароль" : "Password";
            string dateColumn = Properties.Settings.Default.Language == "ru-RU" ? "Дата" : "Date";
            string roleColumn = Properties.Settings.Default.Language == "ru-RU" ? "Роль" : "Role";

            // SQL-запрос для получения информации о пользователях
            string query = $"SELECT User_ID AS ID, Mail AS `{emailColumn}`, Login AS `{loginColumn}`, Password AS `{passwordColumn}`, Created AS `{dateColumn}`, Role AS `{roleColumn}` FROM Users";
            db.SqlDataReader(query, DataGridUsers); // Выполняем запрос и заполняем DataGrid

            // Скрываем колонку ID
            if (DataGridUsers.Columns["ID"] != null)
            {
                DataGridUsers.Columns["ID"].Visible = false; // Скрываем колонку ID
            }

            // Добавляем кнопку "Изменить"
            AddButtonColumn("ChgButton", Properties.Settings.Default.Language == "ru-RU" ? "Изменить" : "Edit");
            // Добавляем кнопку "Удалить"
            AddButtonColumn("DelButton", Properties.Settings.Default.Language == "ru-RU" ? "Удалить" : "Delete");

            // Выравнивание заголовков и содержимого всех колонок по центру
            CenterAlignColumns();
        }

        // Метод для добавления кнопок в DataGrid
        private void AddButtonColumn(string columnName, string headerText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = headerText,
                Name = columnName,
                Text = headerText,
                UseColumnTextForButtonValue = true // Используем текст кнопки
            };
            DataGridUsers.Columns.Add(buttonColumn); // Добавляем колонку кнопок в DataGrid
        }

        // Метод для выравнивания заголовков и содержимого всех колонок по центру
        private void CenterAlignColumns()
        {
            foreach (DataGridViewColumn column in DataGridUsers.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание содержимого
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание заголовка
            }
        }

        // Обработчик события клика по ячейкам DataGrid
        private void DataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Удаление пользователя
            if (e.RowIndex >= 0 && e.ColumnIndex == DataGridUsers.Columns["DelButton"].Index)
            {
                // Определяем текст сообщения на основе языка
                string confirmationMessage = Properties.Settings.Default.Language == "ru-RU" ? "Вы уверены, что хотите удалить этого пользователя?" : "Are you sure you want to delete this user?";
                string confirmationTitle = Properties.Settings.Default.Language == "ru-RU" ? "Подтверждение" : "Confirmation";

                DialogResult result = MessageBox.Show(confirmationMessage, confirmationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DataGridUsers.Rows[e.RowIndex].Cells["ID"].Value);

                    // Удаление тестов пользователя
                    string deleteTestScoresQuery = $"DELETE FROM TestScores WHERE User_ID = {id}";
                    db.queryExecute(deleteTestScoresQuery);

                    // Удаление пользователя
                    string deleteQuery = $"DELETE FROM Users WHERE User_ID = {id}";
                    db.queryExecute(deleteQuery);

                    LoadGrid(); // Перезагружаем данные
                }
            }

            // Изменение информации о пользователе
            else if (e.RowIndex >= 0 && e.ColumnIndex == DataGridUsers.Columns["ChgButton"].Index)
            {
                int id = Convert.ToInt32(DataGridUsers.Rows[e.RowIndex].Cells["ID"].Value);
                mainAuthForm.LoadInfoUserForm(id); // Загружаем форму информации о пользователе
            }
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                DataGridUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                DataGridUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                User_Text.Text = "Пользователи";
            }
            else
            {
                User_Text.Text = "Users";
            }
        }
    }
}
