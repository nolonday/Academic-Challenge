using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class QuestionsForm : UserControl
    {
        private readonly DataBase db = new DataBase(); // Объект базы данных
        private readonly Methods methods = new Methods(); // Объект для работы с методами
        private MainAuthForm authForm; // Ссылка на основную форму авторизации
        private int currentQuestionIndex = 0; // Индекс текущего вопроса
        private readonly int test_id; // ID теста
        private readonly int subjectId; // ID предмета
        private int correctAnswersCount = 0; // Счетчик правильных ответов

        public QuestionsForm(int test_id, int subjectId, MainAuthForm mainAuthForm)
        {
            InitializeComponent();
            this.test_id = test_id;
            this.subjectId = subjectId;
            this.authForm = mainAuthForm;
            LoadQuestion(); // Загружаем текущий вопрос
            ApplyLanguage();
            ApplyTheme();
        }

        // Метод для загрузки текущего вопроса
        public void LoadQuestion()
        {
            // Сброс выбора ответов
            ButtonA.Checked = false;
            ButtonB.Checked = false;
            ButtonC.Checked = false;
            ButtonD.Checked = false;           
            ApplyTheme();

            // Проверяем, есть ли еще вопросы
            if (currentQuestionIndex >= methods.GetTotalQuestionCount(test_id))
            {
                SaveTestResults(); // Если вопросов больше нет, сохраняем результаты теста
                return;
            }

            // Загружаем вопрос по индексу
            methods.LoadQuestionByIndex(test_id, currentQuestionIndex, Desc_Text, ButtonA, ButtonB, ButtonC, ButtonD);


            // Обновляем текст вопроса только здесь
            Question_Text.Text = Properties.Settings.Default.Language == "ru-RU" ? $"Вопрос {currentQuestionIndex + 1}" : $"Question {currentQuestionIndex + 1}"; // Обновляем текст вопроса
        }

        // Метод для получения выбранного ответа
        private string GetSelectedAnswer()
        {
            if (ButtonA.Checked) return "A";
            if (ButtonB.Checked) return "B";
            if (ButtonC.Checked) return "C";
            if (ButtonD.Checked) return "D";
            return null; // Если ответ не выбран
        }

        // Обработчик кнопки "Сохранить ответ"
        private void Save_Question_Click(object sender, EventArgs e)
        {
            SaveAnswerAndLoadNextQuestion(); // Сохраняем ответ и загружаем следующий вопрос
        }

        // Метод для сохранения ответа и загрузки следующего вопроса
        private void SaveAnswerAndLoadNextQuestion()
        {
            string selectedAnswer = GetSelectedAnswer(); // Получаем выбранный ответ
            if (selectedAnswer == null)
            {
                // Определяем сообщение в зависимости от языка
                string warningMessage = Properties.Settings.Default.Language == "ru-RU" ? "Выберите ответ!" : "Please select an answer!";
                MessageBox.Show(warningMessage); // Если ответ не выбран, показываем сообщение
                return;
            }

            // Проверяем правильность ответа
            string correctAnswer = methods.GetCorrectAnswer(test_id, currentQuestionIndex);
            Color correctColor = Color.Green; // Цвет для правильного ответа
            Color incorrectColor = Color.Red; // Цвет для неправильного ответа

            // Изменяем цвет текста выбранного ответа
            if (selectedAnswer == correctAnswer)
            {
                // Если ответ правильный, красим в зеленый
                switch (selectedAnswer)
                {
                    case "A":
                        ButtonA.ForeColor = correctColor;
                        break;
                    case "B":
                        ButtonB.ForeColor = correctColor;
                        break;
                    case "C":
                        ButtonC.ForeColor = correctColor;
                        break;
                    case "D":
                        ButtonD.ForeColor = correctColor;
                        break;
                }
                correctAnswersCount++; // Увеличиваем счетчик правильных ответов
            }
            else
            {
                // Если ответ неправильный, красим в красный
                switch (selectedAnswer)
                {
                    case "A":
                        ButtonA.ForeColor = incorrectColor;
                        break;
                    case "B":
                        ButtonB.ForeColor = incorrectColor;
                        break;
                    case "C":
                        ButtonC.ForeColor = incorrectColor;
                        break;
                    case "D":
                        ButtonD.ForeColor = incorrectColor;
                        break;
                }

                // Выделяем правильный ответ
                switch (correctAnswer)
                {
                    case "A":
                        ButtonA.ForeColor = correctColor;
                        break;
                    case "B":
                        ButtonB.ForeColor = correctColor;
                        break;
                    case "C":
                        ButtonC.ForeColor = correctColor;
                        break;
                    case "D":
                        ButtonD.ForeColor = correctColor;
                        break;
                }
            }

            // Показать правильный и выбранный ответ
            string message = Properties.Settings.Default.Language == "ru-RU" ? $"Ваш ответ: {selectedAnswer}\nПравильный ответ: {correctAnswer}" : $"Your answer: {selectedAnswer}\nCorrect answer: {correctAnswer}";
            MessageBox.Show(message);
            // Переходим к следующему вопросу
            currentQuestionIndex++; // Переходим к следующему вопросу
            LoadQuestion(); // Загружаем следующий вопрос
        }

        // Метод для сохранения результатов теста
        private void SaveTestResults()
        {
            // Сохраняем результаты теста и обновляем информацию о пользователе
            bool resultSaved = methods.CalculateAndSaveScore(Methods.User_ID, test_id, correctAnswersCount);
            bool update = methods.UpdateUserCompletedTest(Methods.User_ID);

           

            // Определяем сообщения в зависимости от языка
            string successMessage = Properties.Settings.Default.Language == "ru-RU" ? "Тест пройден, результаты можно посмотреть в профиле!" : "Test completed, you can view the results in your profile!";
            string errorMessage = Properties.Settings.Default.Language == "ru-RU" ? "Произошла ошибка при сохранении результатов." : "An error occurred while saving the results.";

            if (resultSaved && update)
            {
                MessageBox.Show(successMessage); // Успешное прохождение теста
            }
            else
            {
                MessageBox.Show(errorMessage); // Ошибка сохранения
            }

            authForm.EnableClick();
            authForm.LoadSubjects(); // Загружаем предметы в основной форме
        }
        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                Desc_Text.ForeColor = Color.FromArgb(7, 8, 91);
                Save_Question.FillColor = Color.FromArgb(7, 8, 91);
                ButtonD.ForeColor = Color.FromArgb(7, 8, 91);
                ButtonC.ForeColor = Color.FromArgb(7, 8, 91);
                ButtonA.ForeColor = Color.FromArgb(7, 8, 91);
                ButtonB.ForeColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                Desc_Text.ForeColor = Color.Black;
                Save_Question.FillColor = Color.Black;
                ButtonD.ForeColor = Color.Black;
                ButtonC.ForeColor = Color.Black;
                ButtonA.ForeColor = Color.Black;
                ButtonB.ForeColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                Question_Text.Text = "Вопрос";
                GroupBoxAnswer.Text = "Ответы";
                Save_Question.Text = "Ответить";
            }
            else
            {
                Question_Text.Text = "Question";
                GroupBoxAnswer.Text = "Answers";
                Save_Question.Text = "Answer";
            }
        }
    }
}
