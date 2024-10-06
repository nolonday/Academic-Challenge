using Academic_Challenge.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge.Forms
{
    public partial class ChangeQuestionForm : Form
    {
        private DragDropWindow dragDropWindow = new DragDropWindow();
        private int question_id; // Идентификатор вопроса
        private Methods methods = new Methods();
        private AllQuestionForm allQuestionForm; // Ссылка на форму всех вопросов
        private int test_id; // Идентификатор теста

        // Конструктор формы
        public ChangeQuestionForm(int test_id, int question_id, AllQuestionForm allQuestionForm)
        {
            InitializeComponent();
            this.question_id = question_id; // Инициализация идентификатора вопроса
            this.allQuestionForm = allQuestionForm; // Инициализация ссылки на форму всех вопросов
            this.test_id = test_id; // Инициализация идентификатора теста
            methods.QuestionNameResult(question_id); // Получение данных вопроса по идентификатору
            TextBoxName.Text = Methods.Question_Text; // Заполнение текстового поля вопроса
            TextBoxA.Text = Methods.Answer_A; // Заполнение текстового поля ответа A
            TextBoxB.Text = Methods.Answer_B; // Заполнение текстового поля ответа B
            TextBoxC.Text = Methods.Answer_C; // Заполнение текстового поля ответа C
            TextBoxD.Text = Methods.Answer_D; // Заполнение текстового поля ответа D
            ComboBoxAnswer.Text = Methods.Correct_Answer; // Установка правильного ответа в комбобокс
            TextBoxName.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Question_US : LanguageStrings.Question);
            TextBoxA.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerA_US : LanguageStrings.AnswerA);
            TextBoxB.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerB_US : LanguageStrings.AnswerB);
            TextBoxC.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerC_US : LanguageStrings.AnswerC);
            TextBoxD.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerD_US : LanguageStrings.AnswerD);
            ApplyTheme(); // Применение темы оформления
        }
        // Обработчик текста на изменение позиции
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        // Обработчик текста на изменение позиции
        private void Test_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Начало перетаскивания формы
        }

        // Обработчик кнопки на изменение вопроса
        private void ChgQuestion_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(TextBoxName.Text) ||
                string.IsNullOrEmpty(TextBoxA.Text) ||
                string.IsNullOrEmpty(TextBoxB.Text) ||
                string.IsNullOrEmpty(TextBoxC.Text) ||
                string.IsNullOrEmpty(TextBoxD.Text))
            {
                // Сообщение об ошибке
                string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Введите данные, поля не могут быть пустыми!" : "Please enter data, fields cannot be empty!";
                string errorTitle = Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error";

                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Выход из метода
            }

            try
            {
                // Обновление данных теста
                methods.UpdateQuestion(question_id, TextBoxName.Text, TextBoxA.Text, TextBoxB.Text, TextBoxC.Text, TextBoxD.Text, ComboBoxAnswer.Text);

                // Сообщение об успешном обновлении
                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно обновлено!" : "Successfully updated!";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";

                MessageBox.Show(successMessage, successTitle);

                allQuestionForm.LoadGrid(test_id); // Обновление данных на форме тестов

                // Очистка полей
                TextBoxName.Text = "";
                TextBoxA.Text = "";
                TextBoxB.Text = "";
                TextBoxC.Text = "";
                TextBoxD.Text = "";
                ComboBoxAnswer.SelectedIndex = -1; // Сброс выбора правильного ответа
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
                ChgQuestion.FillColor = Color.FromArgb(7, 8, 91);
                TextBoxName.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxA.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxB.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxC.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxD.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ComboBoxAnswer.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                ChgQuestion.FillColor = Color.Black;
                TextBoxName.FocusedState.BorderColor = Color.Black;
                TextBoxA.FocusedState.BorderColor = Color.Black;
                TextBoxB.FocusedState.BorderColor = Color.Black;
                TextBoxC.FocusedState.BorderColor = Color.Black;
                TextBoxD.FocusedState.BorderColor = Color.Black;
                ComboBoxAnswer.FocusedState.BorderColor = Color.Black;
            }
        }
    }
}
