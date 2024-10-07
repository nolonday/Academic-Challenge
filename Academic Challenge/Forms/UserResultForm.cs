using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class UserResultForm : Form
    {
        DataBase db = new DataBase(); // Объект для работы с базой данных
        private Methods methods = new Methods(); // Объект для работы с методами
        private InformationUserForm informationUserForml; // Ссылка на форму с информацией о пользователе
        private int score_id; // ID оценки
        private int id; // ID пользователя
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Объект для перетаскивания окна

        // Конструктор формы, инициализирует поля и загружает результат пользователя
        public UserResultForm(int score_id, int id, InformationUserForm informationUserForml)
        {
            InitializeComponent(); // Инициализация компонентов формы
            this.score_id = score_id; // Установка ID оценки
            this.id = id; // Установка ID пользователя
            methods.UserResult(score_id); // Получение результата пользователя
            ComboBoxScore.Text = Methods.ScoreResult.ToString(); // Установка текста в комбобокс
            this.informationUserForml = informationUserForml; // Сохранение ссылки на форму пользователя
            ApplyLanguage();
            ApplyTheme();
        }

        // Метод для закрытия формы при двойном щелчке на текст оценки
        private void Score_Text_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        // Метод для обновления оценки
        private void UpdateAvatar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Settings.Default.Language == "ru-RU" ? "Изменить оценку?" : "Change the score?", Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Если пользователь согласен на изменение
            {
                try
                {
                    // SQL запрос для обновления оценки в базе данных
                    string updatescore = $"UPDATE TestScores SET Score = {ComboBoxScore.Text} WHERE Score_ID = {score_id}";
                    db.queryExecute(updatescore); // Выполнение запроса
                    MessageBox.Show(Properties.Settings.Default.Language == "ru-RU" ? "Успешно изменено!" : "Successfully updated!", Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification"); // Сообщение об успешном обновлении

                    informationUserForml.LoadGrid(id); // Обновление грида на форме пользователя
                }
                catch (Exception ex) // Обработка возможных ошибок
                {
                    MessageBox.Show($"{(Properties.Settings.Default.Language == "ru-RU" ? "Возникла ошибка" : "An error occurred")} {ex.Message}", Properties.Settings.Default.Language == "ru-RU"? "Ошибка" : "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                return; // Если пользователь не согласен, выходим из метода
            }

        }

        // Метод для закрытия формы при двойном щелчке на логотип
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        // Метод для перетаскивания окна
        private void Score_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Перетаскивание окна
        }

        // Обработчик кнопки
        private void UpdateScore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Settings.Default.Language == "ru-RU" ? "Изменить оценку?" : "Change the score?", Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Если пользователь согласен на изменение
            {
                try
                {
                    // SQL запрос для обновления оценки в базе данных
                    string updatescore = $"UPDATE TestScores SET Score = {ComboBoxScore.Text} WHERE Score_ID = {score_id}";
                    db.queryExecute(updatescore); // Выполнение запроса
                    MessageBox.Show(Properties.Settings.Default.Language == "ru-RU" ? "Успешно изменено!" : "Successfully updated!", Properties.Settings.Default.Language == "ru-RU" ? "Оповещение" : "Notification"); // Сообщение об успешном обновлении

                    informationUserForml.LoadGrid(id); // Обновление грида на форме пользователя
                }
                catch (Exception ex) // Обработка возможных ошибок
                {
                    MessageBox.Show($"{(Properties.Settings.Default.Language == "ru-RU" ? "Возникла ошибка" : "An error occurred")} {ex.Message}", Properties.Settings.Default.Language == "ru-RU" ? "Ошибка" : "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return; // Если пользователь не согласен, выходим из метода
            }
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                UpdateScore.FillColor = Color.FromArgb(7, 8, 91);

            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                UpdateScore.FillColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                Score_Text.Text = "Оценка";
                UpdateScore.Text = "Изменить";
            }
            else
            {
                Score_Text.Text = "Rating";
                UpdateScore.Text = "Edit";
            }
        }
    }
}
