using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class SubjectsForm : UserControl
    {
        private DataBase db = new DataBase(); // Объект для работы с базой данных
        private MainAuthForm mainAuthForm; // Ссылка на основную форму авторизации

        // Конструктор формы
        public SubjectsForm(MainAuthForm mainAuthForm)
        {         
            InitializeComponent();
            LabelSubject.Text = (Properties.Settings.Default.Language == "en-US" ? "Choose a Subject" : "Выберите Предмет");
            this.mainAuthForm = mainAuthForm; // Сохраняем ссылку на основную форму
            ApplyTheme();
        }

        // Обработчик загрузки формы
        private void SubjectsForm_Load(object sender, EventArgs e)
        {         
            LoadGrid(); // Загружаем данные в DataGrid
            AddButtonColumnPass(); // Добавляем колонку "Выбрать"

            // Проверяем роль пользователя для отображения дополнительных кнопок
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {
                Add.Image = Properties.Resources.Add; // Устанавливаем иконку для кнопки "Добавить"
                AddButtonColumnChange(); // Добавляем колонку "Изменить"
                AddButtonColumnDelete(); // Добавляем колонку "Удалить"
            }
            else
            {
                Add.Visible = false; // Скрываем кнопку "Добавить", если пользователь не админ
            }
        }

        // Метод для загрузки данных в DataGrid
        public void LoadGrid()
        {
            string query = "SELECT Subjects.Subject_ID AS ID,Subjects.Name AS Предмет,COUNT(Tests.Test_ID) AS Количество " +
                            "FROM Subjects " +
                            "LEFT JOIN Tests ON Tests.Subject_ID = Subjects.Subject_ID " +
                            "GROUP BY Subjects.Subject_ID, Subjects.Name;";

            db.SqlDataReader(query, DataGridSubjects);
            DataGridSubjects.Columns["ID"].Visible = false;
            DataGridSubjects.ReadOnly = false;

            // Устанавливаем заголовки колонок в зависимости от языка
            SetColumnHeaders();

            // Выравнивание заголовков и содержимого по центру
            CenterAlignColumns(DataGridSubjects.Columns);
        }

        // Устанавливаем заголовки колонок
        private void SetColumnHeaders()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                DataGridSubjects.Columns["Предмет"].HeaderText = "Предмет";
                DataGridSubjects.Columns["Количество"].HeaderText = "Количество";
            }
            else
            {
                DataGridSubjects.Columns["Предмет"].HeaderText = "Subject";
                DataGridSubjects.Columns["Количество"].HeaderText = "Count";
            }
        }

        // Центрируем выравнивание колонок
        private void CenterAlignColumns(DataGridViewColumnCollection columns)
        {
            foreach (DataGridViewColumn column in columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // Метод для добавления кнопки в DataGrid
        private void AddButtonColumn(string headerText, string buttonName)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                HeaderText = headerText,
                Name = buttonName,
                Text = headerText,
                UseColumnTextForButtonValue = true
            };
            DataGridSubjects.Columns.Add(btnColumn);
            // Центрируем заголовок кнопки
            DataGridSubjects.Columns[buttonName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Метод для добавления кнопки "Выбрать"
        private void AddButtonColumnPass()
        {
            string headerText = Properties.Settings.Default.Language == "ru-RU" ? "Выбрать" : "Choose";
            AddButtonColumn(headerText, "ChooseButton");
        }

        // Метод для добавления кнопки "Изменить"
        private void AddButtonColumnChange()
        {
            string headerText = Properties.Settings.Default.Language == "ru-RU" ? "Изменить" : "Edit";
            AddButtonColumn(headerText, "ChgButton");
        }

        // Метод для добавления кнопки "Удалить"
        private void AddButtonColumnDelete()
        {
            string headerText = Properties.Settings.Default.Language == "ru-RU" ? "Удалить" : "Delete";
            AddButtonColumn(headerText, "DelButton");
        }

        // Обработчик кликов по ячейкам DataGrid
        private void DataGridSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем роль пользователя для отображения кнопок "Изменить" и "Удалить"
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {
                // Обработка нажатия кнопки "Изменить"
                if (e.RowIndex >= 0 && e.ColumnIndex == DataGridSubjects.Columns["ChgButton"].Index)
                {
                    int id = Convert.ToInt32(DataGridSubjects.Rows[e.RowIndex].Cells["ID"].Value);
                    ChangeSubjectForm changeSubjectForm = new ChangeSubjectForm(id, this);
                    changeSubjectForm.ShowDialog(); // Открываем форму изменения предмета
                }

                // Обработка нажатия кнопки "Удалить"
                if (e.RowIndex >= 0 && e.ColumnIndex == DataGridSubjects.Columns["DelButton"].Index)
                {
                    // Определяем текст сообщения на основе языка
                    string confirmDeleteMessage = Properties.Settings.Default.Language == "ru-RU" ? "Вы уверены, что хотите удалить этот предмет?" : "Are you sure you want to delete this subject?";
                    string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Предмет успешно удалён!" : "Subject successfully deleted!";
                    string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Произошла ошибка при удалении предмета." : "An error occurred while deleting the subject.";

                    DialogResult result = MessageBox.Show(confirmDeleteMessage, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int id = Convert.ToInt32(DataGridSubjects.Rows[e.RowIndex].Cells["ID"].Value);

                            // Сначала удаляем связанные записи из Questions
                            db.queryExecute($"DELETE FROM Questions WHERE Test_ID IN (SELECT Test_ID FROM Tests WHERE Subject_ID = {id})");

                            // Затем удаляем связанные тесты и результаты
                            db.queryExecute($"DELETE FROM TestScores WHERE Test_ID IN (SELECT Test_ID FROM Tests WHERE Subject_ID = {id})");
                            db.queryExecute($"DELETE FROM Tests WHERE Subject_ID = {id}");

                            // И только потом удаляем сам предмет
                            db.queryExecute($"DELETE FROM Subjects WHERE Subject_ID = {id}");

                            MessageBox.Show(successMessage); // Уведомление об успешном удалении
                            LoadGrid(); // Перезагружаем данные
                        }
                        catch (Exception ex)
                        {
                            // Обработка ошибок
                            MessageBox.Show($"{errorMessage} {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }

            // Обработка нажатия кнопки "Выбрать"
            if (e.RowIndex >= 0 && e.ColumnIndex == DataGridSubjects.Columns["ChooseButton"].Index)
            {
                int id = Convert.ToInt32(DataGridSubjects.Rows[e.RowIndex].Cells["ID"].Value);
                mainAuthForm.LoadTests(id); // Загружаем тесты по выбранному предмету
            }
        }

        // Обработчик нажатия кнопки "Добавить"
        private void Add_Click(object sender, EventArgs e)
        {
            AddSubjectsForm addSubjectsForm = new AddSubjectsForm(this);
            addSubjectsForm.ShowDialog(); // Открываем форму добавления предмета
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                DataGridSubjects.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridSubjects.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                DataGridSubjects.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridSubjects.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }
    }
}
