using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class MainForm : Form
    {
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Объект для перетаскивания окна
        private Timer internetCheckTimer; // Объект таймера

        // Конструктор основной формы
        public MainForm()
        {
            InitializeTimer(); // Инициализация таймера
            InitializeCulture(); // Инициализация культуры
            InitializeComponent(); // Инициализация компонентов формы
            ApplyLanguage();
            ApplyTheme(); // Применение темы           
        }

        // Загрузка формы при запуске
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Проверяем наличие интернета при загрузке формы
            if (!IsInternetAvailable())
            {
                MessageBox.Show("Нет соединения с интернетом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit(); // Закрытие приложения, если интернет недоступен
            }
            else
            {
                InitializeTimer(); // Инициализация таймера только если интернет доступен
            }
        }

        // Инициальзация культуры формы(интерфейса)
        private void InitializeCulture()
        {
            // Установка культуры интерфейса в зависимости от настроек
            var cultureName = Properties.Settings.Default.Language;
            if (!string.IsNullOrEmpty(cultureName))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(cultureName);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(cultureName);
            }
        }

        // Инициальзация таймера
        private void InitializeTimer()
        {
            // Инициализация таймера для проверки интернет-соединения
            internetCheckTimer = new Timer();
            internetCheckTimer.Interval = 10000; // Проверка каждые 10 секунд
            internetCheckTimer.Tick += InternetCheckTimer_Tick; // Подписка на событие тика таймера
            internetCheckTimer.Start(); // Запуск таймера
        }

        // Таймер проверки интернета
        private void InternetCheckTimer_Tick(object sender, EventArgs e)
        {
            // Проверяем наличие интернета при каждом тике таймера
            if (!IsInternetAvailable())
            {
                MessageBox.Show("Нет соединения с интернетом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit(); // Закрытие приложения, если интернет недоступен
            }
        }

        // Метод для проверки наличия интернет-соединения
        private bool IsInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                {
                    return true; // Если удалось открыть сайт, значит интернет доступен
                }
            }
            catch
            {
                return false; // Если произошла ошибка, интернет недоступен
            }
        }

        // Метод, вызываемый при нажатии на логотип (выход из приложения)
        private void Logo_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрытие приложения
        }

        // Метод, вызываемый при нажатии на кнопку "Тесты"
        private void Button_Tests_Click(object sender, EventArgs e)
        {
            var savedUsername = Properties.Settings.Default.Login;
            var savedPassword = Properties.Settings.Default.Pass;

            if (!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(savedPassword))
            {
                this.Hide(); // Скрытие текущей формы
                MainAuthForm authForm = new MainAuthForm(savedUsername); // Создание формы авторизации
                authForm.Show(); // Показ формы авторизации
            }
            else
            {
                string message = Properties.Settings.Default.Language == "ru-RU" ? "Войдите в аккаунт или зарегистрируйтесь!" : "Please log in or register!";
                MessageBox.Show(message);
            }

        }

        // Метод, вызываемый при нажатии на кнопку "Профиль"
        private void Profile_Click(object sender, EventArgs e)
        {            
            this.Hide(); // Скрытие текущей формы
            AuthorizationForm authorizationForm = new AuthorizationForm(); // Создание формы авторизации
            authorizationForm.Show(); // Показ формы авторизации          
        }

        // Метод для перетаскивания окна при нажатии на текст логотипа
        private void Logo_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Перетаскивание окна
        }

        // Метод для перетаскивания окна при нажатии на верхнюю панель
        private void PanelUp_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this); // Перетаскивание окна
        }

        // Установка темы 
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                PanelUp.BackColor = Color.FromArgb(7, 8, 91); // Цвет верхней панели
                Button_Tests.FillColor = Color.FromArgb(7, 8, 91); // Цвет кнопки "Тесты"
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                PanelUp.BackColor = Color.Black; // Цвет верхней панели для темы "Чёрный"
                Button_Tests.FillColor = Color.Black; // Цвет кнопки "Тесты" для темы "Чёрный"
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                Tests_Text.Text = "Образовательные \r\nТесты";
                Text1.Text = "✓ Различные уровни сложности";
                Text2.Text = "✓ Разные виды тестов";
                Text3.Text = "✓ Доска лидеров\r\n";
                Button_Tests.Text = "К тестам";

            }
            else
            {
                Tests_Text.Text = "Educational tests";
                Text1.Text = "✓ Various difficulty levels";
                Text2.Text = "✓ Different types of tests";
                Text3.Text = "✓ Leaderboard\r\n";
                Button_Tests.Text = "To the tests";
            }
        }
    }
}
