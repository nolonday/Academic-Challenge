using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class ChangeTestForm : Form
    {
        private TestsForm testsForm; // Ссылка на форму тестов
        private Methods methods = new Methods(); // Объект для работы с методами
        private int test_id; // ID изменяемого теста
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Объект для перетаскивания окна

        // Конструктор формы изменения теста
        public ChangeTestForm(int test_id, TestsForm testsForm)
        {
            InitializeComponent(); // Инициализация компонентов формы
            this.test_id = test_id; // Сохранение ID теста
            this.testsForm = testsForm; // Сохранение ссылки на форму тестов

            // Получение данных о тесте и заполнение полей
            methods.TestNameResult(test_id);
            TextBoxName.Text = Methods.TestName;
            TextBoxDesc.Text = Methods.TestDesc;
            ComboBoxComplexity.Text = Methods.TestComplexity;
            ApplyLanguage();
            ApplyTheme();
        }

        // Метод, вызываемый при двойном щелчке на логотипе
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        // Метод, вызываемый при нажатии кнопки "Изменить тест"
        private void ChgTest_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxDesc.Text))
            {
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поля не могут быть пустыми!" : "Please enter data, fields cannot be empty!";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выход из метода
            }

            try
            {
                // Обновление данных теста
                methods.UpdateTest(test_id, TextBoxName.Text, TextBoxDesc.Text, ComboBoxComplexity.Text);

                // Сообщение об успешном обновлении
                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно обновлено!" : "Successfully updated!";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";

                MessageBox.Show(successMessage, successTitle);

                testsForm.LoadGrid(); // Обновление данных на форме тестов

                // Очистка полей
                TextBoxName.Text = "";
                TextBoxDesc.Text = "";
                ComboBoxComplexity.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Определяем сообщение об ошибке на основе языка
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? $"Возникла ошибка: {ex.Message}" : $"An error occurred: {ex.Message}";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                // Обработка ошибок
                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Метод, вызываемый при нажатии на текстовое поле теста
        private void Test_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Перетаскивание окна
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                ChgTest.FillColor = Color.FromArgb(7, 8, 91);
                TextBoxName.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxDesc.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ComboBoxComplexity.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                ChgTest.FillColor = Color.Black;
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
                Test_Text.Text = "Изменить тест";
                ChgTest.Text = "Изменить";

            }
            else
            {
                TextBoxName.PlaceholderText = LanguageStrings.NameTest_US;
                TextBoxDesc.PlaceholderText = LanguageStrings.DescriptionTest_US;
                Test_Text.Text = "Change the test";
                ChgTest.Text = "Change";
            }
        }
    }
}
