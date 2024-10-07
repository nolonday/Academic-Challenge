using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class AddTestsForm : Form
    {
        private Methods methods = new Methods(); // Объект для работы с методами
        private TestsForm testsForm; // Ссылка на форму со списком тестов
        private int subject_id; // ID предмета
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Окно для перетаскивания

        // Конструктор формы, принимает ID предмета и ссылку на TestsForm
        public AddTestsForm(int subject_id, TestsForm testsForm)
        {
            InitializeComponent();
            this.subject_id = subject_id; // Сохраняем ID предмета
            this.testsForm = testsForm; // Сохраняем ссылку на форму со списком тестов
            ApplyLanguage();
            ApplyTheme();
        }

        // Метод, вызываемый при двойном щелчке по логотипу
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму
        }

        // Метод, вызываемый при нажатии мыши на текстовое поле теста
        private void Test_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Запускаем перетаскивание окна
        }

        // Метод, вызываемый при нажатии кнопки "Добавить тест"
        private void AddTest_Click(object sender, EventArgs e)
        {
            // Проверяем, заполнены ли все необходимые поля
            if (string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxDesc.Text) || ComboBoxComplexity.SelectedIndex == -1)
            {
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поля не могут быть пустыми!" : "Please enter data, fields cannot be empty!";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода, если поля пустые
            }

            try
            {
                // Добавляем новый тест
                methods.AddTest(subject_id, TextBoxName.Text, TextBoxDesc.Text, ComboBoxComplexity.Text);

                // Сообщение об успешном добавлении
                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно добавлено!" : "Successfully added!";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";

                MessageBox.Show(successMessage, successTitle); // Сообщение об успешном добавлении

                testsForm.LoadGrid(); // Обновляем список тестов в родительской форме

                // Очищаем поля ввода
                TextBoxName.Clear();
                TextBoxDesc.Clear();
                ComboBoxComplexity.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Определяем сообщение об ошибке на основе языка
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? $"Возникла ошибка: {ex.Message}" : $"An error occurred: {ex.Message}";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                // Обработка исключений: выводим сообщение об ошибке
                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                AddTest.FillColor = Color.FromArgb(7, 8, 91);
                TextBoxName.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxDesc.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ComboBoxComplexity.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                AddTest.FillColor = Color.Black;
                TextBoxName.FocusedState.BorderColor = Color.Black;
                TextBoxDesc.FocusedState.BorderColor = Color.Black;
                ComboBoxComplexity.FocusedState.BorderColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                TextBoxName.PlaceholderText = LanguageStrings.NameTest;
                TextBoxDesc.PlaceholderText = LanguageStrings.DescriptionTest;
                Test_Text.Text = "Добавить тест";
                AddTest.Text = "Добавить";

            }
            else
            {
                TextBoxName.PlaceholderText = LanguageStrings.NameTest_US;
                TextBoxDesc.PlaceholderText = LanguageStrings.DescriptionTest_US;
                Test_Text.Text = "Add a test";
                AddTest.Text = "Add";
            }
        }
    }
}