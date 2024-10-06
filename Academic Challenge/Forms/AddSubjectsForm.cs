using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class AddSubjectsForm : Form
    {
        private DataBase db = new DataBase(); // Объект для работы с базой данных
        private Methods methods = new Methods(); // Объект для работы с методами
        private SubjectsForm subjectsForm; // Ссылка на форму со списком предметов
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Окно для перетаскивания

        // Конструктор формы, принимает ссылку на SubjectsForm
        public AddSubjectsForm(SubjectsForm subjectsForm)
        {
            InitializeComponent();
            this.subjectsForm = subjectsForm; // Сохраняем ссылку на форму со списком предметов
            TextBoxSubject.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Subject_US : LanguageStrings.Subject);
            ApplyTheme();
        }

        // Метод, вызываемый при нажатии кнопки "Добавить предмет"
        private void AddSubject_Click(object sender, EventArgs e)
        {
            // Проверяем, заполнено ли поле ввода
            if (string.IsNullOrEmpty(TextBoxSubject.Text))
            {
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поле не может быть пустым!" : "Please enter data, the field cannot be empty!";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выходим из метода, если поле пустое
            }

            try
            {
                // Добавляем новый предмет
                methods.AddSubject(TextBoxSubject.Text);

                // Сообщение об успешном добавлении
                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно добавлено!" : "Successfully added!";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";

                MessageBox.Show(successMessage, successTitle); // Сообщение об успешном добавлении
                subjectsForm.LoadGrid(); // Обновляем список предметов в родительской форме
                TextBoxSubject.Text = ""; // Очищаем поле ввода
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

        // Метод, вызываемый при двойном щелчке по логотипу
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму
        }

        // Метод, вызываемый при нажатии мыши на текстовое поле предмета
        private void Subject_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Запускаем перетаскивание окна
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                AddSubject.FillColor = Color.FromArgb(7, 8, 91);
                TextBoxSubject.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                AddSubject.FillColor = Color.Black;
                TextBoxSubject.FocusedState.BorderColor = Color.Black;
            }
        }
    }
}
