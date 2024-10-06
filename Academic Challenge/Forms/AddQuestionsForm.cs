using Academic_Challenge.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge.Forms
{
    public partial class AddQuestionsForm : Form
    {
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Окно для перетаскивания
        private int id; // Идентификатор теста
        private Methods methods = new Methods(); // Объект для работы с методами
        private AllQuestionForm allQuestionForm;
        public event Action QuestionAdded; // Событие, которое вызывается при добавлении вопроса
        private MainAuthForm mainAuthForm;

        // Конструктор формы, принимает идентификатор теста и основную форму авторизации
        public AddQuestionsForm(int id, MainAuthForm mainAuthForm, int subject_id)
        {
            InitializeComponent();
            this.id = id; // Сохраняем идентификатор теста
            this.mainAuthForm = mainAuthForm;
            allQuestionForm = new AllQuestionForm(id, mainAuthForm,subject_id); // Инициализируем форму со всеми вопросами
            // Устанавливаем текст подсказки для полей ввода на основе языка
            TextBoxName.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.Question_US : LanguageStrings.Question);
            TextBoxA.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerA_US : LanguageStrings.AnswerA);
            TextBoxB.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerB_US : LanguageStrings.AnswerB);
            TextBoxC.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerC_US : LanguageStrings.AnswerC);
            TextBoxD.PlaceholderText = (Properties.Settings.Default.Language == "en-US" ? LanguageStrings.AnswerD_US : LanguageStrings.AnswerD);
            ApplyTheme(); // Применяем тему
        }

        // Метод, вызываемый при нажатии мыши на текст поле теста
        private void Test_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Запускаем перетаскивание окна
        }

        // Метод, вызываемый при двойном щелчке по логотипу
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму
        }

        // Метод, вызываемый при нажатии кнопки "Добавить вопрос"
        private void AddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                // Добавляем вопрос с помощью метода и передаем параметры
                methods.AddQuestion(id, TextBoxName.Text, TextBoxA.Text, TextBoxB.Text, TextBoxC.Text, TextBoxD.Text, ComboBoxAnswer.Text);

                // Определяем сообщение на основе языка
                string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Успешно добавлено!" : "Successfully added!";
                string successTitle = Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification";

                MessageBox.Show(successMessage, successTitle); // Сообщение об успешном добавлении

                // Очищаем поля ввода после добавления
                TextBoxName.Clear();
                TextBoxA.Clear();
                TextBoxB.Clear();
                TextBoxC.Clear();
                TextBoxD.Clear();
                ComboBoxAnswer.SelectedIndex = -1; // Сбрасываем выбор в ComboBox
                QuestionAdded?.Invoke(); // Вызываем событие добавления вопроса
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

        // Метод для применения темы в интерфейсе
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                AddQuestion.FillColor = Color.FromArgb(7, 8, 91); // Цвет кнопки "Добавить вопрос"
                TextBoxName.FocusedState.BorderColor = Color.FromArgb(7, 8, 91); // Цвет рамки поля ввода
                TextBoxA.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxB.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxC.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                TextBoxD.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
                ComboBoxAnswer.FocusedState.BorderColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                AddQuestion.FillColor = Color.Black; // Цвет кнопки "Добавить вопрос" для черной темы
                TextBoxName.FocusedState.BorderColor = Color.Black; // Цвет рамки поля ввода для черной темы
                TextBoxA.FocusedState.BorderColor = Color.Black;
                TextBoxB.FocusedState.BorderColor = Color.Black;
                TextBoxC.FocusedState.BorderColor = Color.Black;
                TextBoxD.FocusedState.BorderColor = Color.Black;
                ComboBoxAnswer.FocusedState.BorderColor = Color.Black;
            }
        }
    }
}
