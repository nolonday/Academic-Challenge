using Academic_Challenge.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge.Controls
{
    public partial class AllQuestionForm : UserControl
    {
        private DataBase db = new DataBase();
        private MainAuthForm mainAuthForm;
        private int test_id;
        private int subject_id;

        // Конструктор формы, принимающий идентификатор теста и основную форму авторизации
        public AllQuestionForm(int test_id, MainAuthForm mainAuthForm,int subject_id)
        {
            InitializeComponent();
            this.test_id = test_id;
            this.subject_id = subject_id;
            this.mainAuthForm = mainAuthForm;
            LoadGrid(test_id); // Загружаем данные в таблицу
            ApplyLanguage();
            ApplyTheme(); // Применяем тему
        }

        // Метод для загрузки данных в DataGrid
        public void LoadGrid(int test_id)
        {
            DataGridQuestions.Columns.Clear(); // Очищаем колонки DataGrid

            // Определяем названия колонок на основе языка
            string QuestionColumn = Properties.Settings.Default.Language == "ru-RU" ? "Вопрос" : "Question";
            string AnswerAColumn = Properties.Settings.Default.Language == "ru-RU" ? "Ответ_A" : "Answer_A";
            string AnswerBColumn = Properties.Settings.Default.Language == "ru-RU" ? "Ответ_B" : "Answer_B";
            string AnswerCColumn = Properties.Settings.Default.Language == "ru-RU" ? "Ответ_C" : "Answer_C";
            string AnswerDColumn = Properties.Settings.Default.Language == "ru-RU" ? "Ответ_D" : "Answer_D";
            string CorrectAnswer = Properties.Settings.Default.Language == "ru-RU" ? "Ответ" : "CorrectAnswer";

            // SQL-запрос для получения тестов по предмету
            string query = $"SELECT Question_ID AS ID, Question_Text AS `{QuestionColumn}`, Answer_A AS `{AnswerAColumn}`, Answer_B AS `{AnswerBColumn}`, Answer_C AS `{AnswerCColumn}`, Answer_D AS `{AnswerDColumn}`, Correct_Answer AS `{CorrectAnswer}` FROM Questions WHERE Test_ID = {test_id}";

            db.SqlDataReader(query, DataGridQuestions); // Выполняем запрос и загружаем данные

            // Проверка на наличие колонок
            if (DataGridQuestions.Columns.Count == 0)
            {
                MessageBox.Show("No columns found. Please check the SQL query."); // Если нет колонок, выводим сообщение
                return; // Выход, если нет колонок
            }

            // Скрываем колонку ID
            if (DataGridQuestions.Columns["ID"] != null)
            {
                DataGridQuestions.Columns["ID"].Visible = false; // Скрываем колонку ID
            }

            // Добавляем кнопки "Изменить" и "Удалить"
            AddButtonColumn("ChgButton", Properties.Settings.Default.Language == "ru-RU" ? "Изменить" : "Edit");
            AddButtonColumn("DelButton", Properties.Settings.Default.Language == "ru-RU" ? "Удалить" : "Delete");

            // Выравниваем заголовки и содержимое по центру
            CenterAlignGridColumns();
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
            DataGridQuestions.Columns.Add(btnColumn); // Добавляем кнопку в DataGrid
        }

        // Метод для выравнивания заголовков и содержимого по центру
        private void CenterAlignGridColumns()
        {
            foreach (DataGridViewColumn column in DataGridQuestions.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание содержимого
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание заголовка
            }
        }

        // Обработчик события для кнопки "Добавить"
        private void Add_Click(object sender, EventArgs e)
        {
            AddQuestionsForm addQuestionsForm = new AddQuestionsForm(test_id, mainAuthForm, subject_id);
            addQuestionsForm.QuestionAdded += () => LoadGrid(test_id); // Перезагружаем данные после добавления вопроса
            addQuestionsForm.Show(); // Показываем форму добавления вопросов
        }

        // Обработчик события для клика по ячейкам DataGrid
        private void DataGridQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Обработка кнопки "Изменить"
                if (e.ColumnIndex == DataGridQuestions.Columns["ChgButton"].Index)
                {
                    int id = Convert.ToInt32(DataGridQuestions.Rows[e.RowIndex].Cells["ID"].Value);
                    ChangeQuestionForm changeQuestionForm = new ChangeQuestionForm(test_id, id, this);
                    changeQuestionForm.ShowDialog(); // Показываем форму изменения вопроса
                }

                // Обработка кнопки "Удалить"
                if (e.ColumnIndex == DataGridQuestions.Columns["DelButton"].Index)
                {
                    // Определяем сообщение подтверждения на основе языка
                    string confirmationMessage = Properties.Settings.Default.Language == "ru-RU" ? "Вы уверены, что хотите удалить этот вопрос?" : "Are you sure you want to delete this question?";

                    DialogResult result = MessageBox.Show(confirmationMessage, Properties.Settings.Default.Language == "ru-RU" ? "Подтверждение" : "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(DataGridQuestions.Rows[e.RowIndex].Cells["ID"].Value);

                        // Удаляем связанные вопросы с поддержкой языка
                        db.queryExecute($"DELETE FROM Questions WHERE Question_ID = {id}");

                        LoadGrid(test_id); // Перезагружаем данные
                    }
                }
            }
        }

        // Метод для применения темы в интерфейсе
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                DataGridQuestions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridQuestions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                DataGridQuestions.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridQuestions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        // Обработчик события клика по метке вопросов
        private void LabelQuestions_Click(object sender, EventArgs e)
        {
            mainAuthForm.LoadTests(subject_id); // Загружаем тесты
        }
        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                LabelQuestions.Text = "Вопросы";
            }
            else
            {
                LabelQuestions.Text = "Questions";
            }
        }
    }
}
