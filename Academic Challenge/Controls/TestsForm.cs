using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class TestsForm : UserControl
    {
        private DataBase db = new DataBase(); // Объект для работы с базой данных
        private int subject_id; // ID предмета, для которого загружаются тесты
        private MainAuthForm mainAuthForm; // Ссылка на основную форму авторизации
        private Methods methods = new Methods(); // Объект для работы с методами
        private List<int> completedTestIds; // Список ID пройденных тестов

        // Конструктор формы
        public TestsForm(int subject_id, MainAuthForm mainAuthForm)
        {
            InitializeComponent();
            this.subject_id = subject_id; // Сохраняем ID предмета
            this.mainAuthForm = mainAuthForm; // Сохраняем ссылку на основную форму
            ApplyLanguage();
            ApplyTheme();
        }

        // Обработчик загрузки формы
        private void TestsForm_Load(object sender, EventArgs e)
        {
            // Проверяем роль пользователя для отображения кнопки "Добавить"
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {
                Add.Image = Properties.Resources.Add; // Устанавливаем иконку для кнопки "Добавить"
            }
            else
            {
                Add.Visible = false; // Скрываем кнопку, если не администратор
            }

            LoadGrid(); // Загружаем данные в DataGrid
        }

        // Метод для загрузки данных в DataGrid
        public void LoadGrid()
        {
            DataGridTests.Columns.Clear(); // Очищаем колонки DataGrid
            completedTestIds = methods.GetCompletedTestIds(Methods.User_ID, subject_id); // Получаем ID пройденных тестов

            // Определяем названия колонок на основе языка
            string nameColumn = Properties.Settings.Default.Language == "ru-RU" ? "Название" : "Name";
            string descriptionColumn = Properties.Settings.Default.Language == "ru-RU" ? "Описание" : "Description";
            string complexityColumn = Properties.Settings.Default.Language == "ru-RU" ? "Сложность" : "Complexity";

            // SQL-запрос для получения тестов по предмету
            string query = $"SELECT Test_ID AS ID, Name AS {nameColumn}, Description AS {descriptionColumn}, Complexity AS {complexityColumn} FROM Tests WHERE Subject_ID = {subject_id}";
            db.SqlDataReader(query, DataGridTests); // Выполняем запрос и загружаем данные

            DataGridTests.Columns["ID"].Visible = false; // Скрываем колонку ID

            // Добавляем кнопку "Пройти" в DataGrid с поддержкой языка
            AddButtonColumn("PassButton", Properties.Settings.Default.Language == "ru-RU" ? "Пройти" : "Pass");

            // Добавляем кнопки "Изменить", "Добавить" и "Удалить" для администраторов с поддержкой языка
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {
                AddButtonColumn("ChgButton", Properties.Settings.Default.Language == "ru-RU" ? "Изменить" : "Edit");
                AddButtonColumn("QuestButton", Properties.Settings.Default.Language == "ru-RU" ? "Вопросы" : "Questions");
                AddButtonColumn("DelButton", Properties.Settings.Default.Language == "ru-RU" ? "Удалить" : "Delete");
            }

            // Выравниваем заголовки и содержимое по центру
            CenterAlignGridColumns();

            // Делаем кнопку "Пройти" недоступной для пройденных тестов
            MarkCompletedTests();

        }

        // Метод для добавления кнопок в DataGrid
        private void AddButtonColumn(string columnName, string headerText)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                HeaderText = headerText,
                Name = columnName,
                Text = headerText,
                UseColumnTextForButtonValue = true
            };
            DataGridTests.Columns.Add(btnColumn); // Добавляем кнопку в DataGrid
        }

        // Метод для выравнивания заголовков и содержимого по центру
        private void CenterAlignGridColumns()
        {
            foreach (DataGridViewColumn column in DataGridTests.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание заголовка
            }
        }

        // Метод для отметки пройденных тестов
        private void MarkCompletedTests()
        {
            foreach (DataGridViewRow row in DataGridTests.Rows)
            {
                int testId = Convert.ToInt32(row.Cells["ID"].Value);
                if (completedTestIds.Contains(testId))
                {
                    row.Cells["PassButton"].ReadOnly = true; // Делаем кнопку недоступной
                    row.Cells["PassButton"].Value = "Пройден"; // Меняем текст кнопки
                }
            }
        }

        // Обработчик клика по элементам управления
        private void DataGridTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверка роли администратора для изменения, добавления или удаления тестов
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {
                if (e.RowIndex >= 0)
                {
                    // Обработка кнопки "Изменить"
                    if (e.ColumnIndex == DataGridTests.Columns["ChgButton"].Index)
                    {
                        int id = Convert.ToInt32(DataGridTests.Rows[e.RowIndex].Cells["ID"].Value);
                        ChangeTestForm changeTestForm = new ChangeTestForm(id, this);
                        changeTestForm.ShowDialog(); // Открываем форму изменения теста
                    }

                    // Обработка кнопки "Добавить"
                    if (e.ColumnIndex == DataGridTests.Columns["QuestButton"].Index)
                    {
                        int id = Convert.ToInt32(DataGridTests.Rows[e.RowIndex].Cells["ID"].Value);
                        mainAuthForm.LoadQuestionsAllForm(id,subject_id);
                    }

                    // Обработка кнопки "Удалить"
                    if (e.ColumnIndex == DataGridTests.Columns["DelButton"].Index)
                    {
                        // Определяем сообщение подтверждения на основе языка
                        string confirmationMessage = Properties.Settings.Default.Language == "ru-RU" ? "Вы уверены, что хотите удалить этот тест?" : "Are you sure you want to delete this test?";

                        DialogResult result = MessageBox.Show(confirmationMessage, Properties.Settings.Default.Language == "ru-RU" ? "Подтверждение" : "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(DataGridTests.Rows[e.RowIndex].Cells["ID"].Value);

                            // Удаляем связанные вопросы и результаты с поддержкой языка
                            db.queryExecute($"DELETE FROM Questions WHERE Test_ID = {id}");
                            db.queryExecute($"DELETE FROM TestScores WHERE Test_ID = {id}");
                            db.queryExecute($"DELETE FROM Tests WHERE Test_ID = {id}");

                            LoadGrid(); // Перезагружаем данные
                        }

                    }
                }
            }

            // Обработка кнопки "Пройти"
            if (e.RowIndex >= 0 && e.ColumnIndex == DataGridTests.Columns["PassButton"].Index)
            {
                int id = Convert.ToInt32(DataGridTests.Rows[e.RowIndex].Cells["ID"].Value);
                if (!completedTestIds.Contains(id))
                {
                    if (methods.HasQuestions(id))
                    {
                        mainAuthForm.LoadQuestions(id, subject_id); // Загружаем вопросы теста
                        if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
                        {
                            mainAuthForm.EnableClick();
                        }
                        else
                        {
                            mainAuthForm.DisableClick();
                        }
                    }
                    else
                    {
                        // Уведомление о недостатке вопросов с поддержкой языка
                        string message = Properties.Settings.Default.Language == "ru-RU" ? "Тест в разработке, вопросы еще не добавлены." : "The test is under development, questions have not been added yet.";
                        MessageBox.Show(message);
                    }
                }
                else
                {
                    // Уведомление о том, что тест уже пройден с поддержкой языка
                    string completedMessage = Properties.Settings.Default.Language == "ru-RU" ? "Тест пройден!" : "Test completed!";
                    MessageBox.Show(completedMessage);
                }

            }
        }

        // Обработчик клика по кнопке "Добавить"
        private void Add_Click(object sender, EventArgs e)
        {
            AddTestsForm addTestsForm = new AddTestsForm(subject_id, this);
            addTestsForm.ShowDialog(); // Открываем форму добавления теста
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                DataGridTests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridTests.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                DataGridTests.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridTests.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        // Метод открытие предметов
        private void LabelTest_Click_1(object sender, EventArgs e)
        {
            mainAuthForm.LoadSubjects();
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                LabelTest.Text = "Выберите Тест";
            }
            else
            {
                LabelTest.Text = "Select Test";
            }
        }
    }
}
