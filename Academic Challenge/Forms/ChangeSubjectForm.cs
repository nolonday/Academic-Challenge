using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class ChangeSubjectForm : Form
    {
        private Methods methods = new Methods(); // Объект для работы с методами
        private SubjectsForm subjectsForm; // Ссылка на форму с предметами
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Объект для обработки перетаскивания окна
        private int subject_id; // ID изменяемого предмета

        // Конструктор формы изменения предмета
        public ChangeSubjectForm(int subject_id, SubjectsForm subjectsForm)
        {
            InitializeComponent(); // Инициализация компонентов формы
            this.subject_id = subject_id; // Сохранение ID предмета
            this.subjectsForm = subjectsForm; // Сохранение ссылки на форму с предметами

            // Получение названия предмета и заполнение текстового поля
            methods.SubjectNameResult(subject_id);
            TextBoxSubject.Text = Methods.SubjectName;
            TextBoxSubject.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Subject_US : LanguageStrings.Subject);
            ApplyTheme();
        }

        // Метод, вызываемый при нажатии на текстовое поле предмета
        private void Subject_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Перетаскивание окна
        }

        // Метод, вызываемый при двойном щелчке на логотипе
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        // Метод, вызываемый при нажатии кнопки "Изменить предмет"
        private void ChgSubject_Click(object sender, EventArgs e)
        {
            // Проверка на пустое поле
            if (string.IsNullOrEmpty(TextBoxSubject.Text))
            {
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поле не может быть пустым!" : "Please enter data, the field cannot be empty!";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выход из метода
            }

            try
            {
                // Обновление названия предмета
                methods.UpdateSubject(subject_id, TextBoxSubject.Text);

                // Сообщение об успешном обновлении
                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно обновлено!" : "Successfully updated!";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";

                MessageBox.Show(successMessage, successTitle);
                subjectsForm.LoadGrid(); // Обновление данных на форме предметов
                TextBoxSubject.Text = ""; // Очистка текстового поля
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

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                ChgSubject.FillColor = Color.FromArgb(7, 8, 91);
                TextBoxSubject.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                ChgSubject.FillColor = Color.Black;
                TextBoxSubject.FocusedState.BorderColor = Color.Black;
            }
        }
    }
}
