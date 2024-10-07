using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class InfoForm : UserControl
    {
        // Конструктор формы
        public InfoForm()
        {
            InitializeComponent();
            ApplyLanguage();
            ApplyTheme(); // Применить тему
        }

        // Обработчик события клика по кнопке "Открыть"
        private void Open_Click(object sender, EventArgs e)
        {
            // Используем WebClient для загрузки информации о версии
            using (WebClient client = new WebClient())
            {
                try
                {
                    // Загружаем строку с информацией о версии
                    string versionInfo = client.DownloadString("https://pastebin.com/NpawUSrv");

                    // Определяем сообщения в зависимости от языка
                    string latestVersionMessage = Properties.Settings.Default.Language == "ru-RU" ? "Последняя версия!" : "The latest version!";
                    string newVersionMessage = Properties.Settings.Default.Language == "ru-RU" ? "Вышла новая версия, можете скачать по ссылке!" : "A new version has been released, you can download it from the link!";

                    // Проверяем, соответствует ли версия актуальной
                    if (versionInfo.Contains("v.1.0.0"))
                    {
                        MessageBox.Show(latestVersionMessage); // Уведомляем о последней версии
                    }
                    else
                    {
                        MessageBox.Show(newVersionMessage); // Уведомляем о новой версии
                    }
                }
                catch (WebException ex)
                {
                    // Обрабатываем ошибки загрузки
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}"); // Показываем ошибку
                }
            }
        }

        // Обработчик события клика по изображению Telegram
        private void PictureBoxTG_Click(object sender, EventArgs e)
        {
            // Открываем ссылку на Telegram в браузере
            OpenUrl("https://t.me/nolonday");
        }

        // Обработчик события клика по изображению ВКонтакте
        private void PictureBoxVK_Click(object sender, EventArgs e)
        {
            // Открываем ссылку на ВКонтакте в браузере
            OpenUrl("https://vk.com/nolonday");
        }

        // Метод для открытия URL в браузере
        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }); // Открытие URL
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                LabelAuditoria.ForeColor = Color.FromArgb(7, 8, 91);
                LabelUser.ForeColor = Color.FromArgb(7, 8, 91);
                LabelVersion.ForeColor = Color.FromArgb(7, 8, 91);
                GroupApp.CustomBorderColor = Color.FromArgb(7, 8, 91);
                GroupAuditoria.CustomBorderColor = Color.FromArgb(7, 8, 91);
                GroupSupport.CustomBorderColor = Color.FromArgb(7, 8, 91);
                GroupVersion.CustomBorderColor = Color.FromArgb(7, 8, 91);
                GroupSocial.CustomBorderColor = Color.FromArgb(7, 8, 91);
                Open.FillColor = Color.FromArgb(7, 8, 91);
                App.ForeColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                LabelAuditoria.ForeColor = Color.Black;
                LabelUser.ForeColor = Color.Black;
                LabelVersion.ForeColor = Color.Black;
                GroupApp.CustomBorderColor = Color.Black;
                GroupAuditoria.CustomBorderColor = Color.Black;
                GroupSupport.CustomBorderColor = Color.Black;
                GroupVersion.CustomBorderColor = Color.Black;
                GroupSocial.CustomBorderColor = Color.Black;
                Open.FillColor = Color.Black;
                App.ForeColor = Color.Black;
            }
        }

        // Метод для смены языка
        private void ApplyLanguage()
        {
            if (Properties.Settings.Default.Language == "ru-RU")
            {
                GroupApp.Text = "Приложение";
                Desc.Text = "Это интерактивное приложение для подготовки к тестам. Оно предлагает пользователям широкий спектр тестов \r\n" +
                    "по различным предметам, помогает улучшить знания и уверенность перед важными испытаниями.";
                GroupAuditoria.Text = "Аудитория";
                LabelAuditoria.Text = "Целевая аудитория";
                Desk_audotiria.Text = "Студенты, школьники и все, кто хочет улучшить свои \r\nзнания.\r\n";
                GroupSupport.Text = "Поддержка";
                LabelUser.Text = "Поддержка пользователей";
                Support.Text = "Для технической поддержки обращайтесь на \r\n[support@academicchallenge.com]";
                GroupVersion.Text = "Версия Приложения";
                LabelVersion.Text = "Версия";
                Open.Text = "Проверить Обновления";
                GroupSocial.Text = "Социальные сети";
            }
            else
            {
                GroupApp.Text = "Application";
                Desc.Text = "This is an interactive application for test preparation. It offers users a wide range of tests \r\n" +
                    "across various subjects, helping to improve knowledge and confidence before important exams.";
                GroupAuditoria.Text = "Audience";
                LabelAuditoria.Text = "Target Audience";
                Desk_audotiria.Text = "Students, schoolchildren, and anyone looking to enhance their \r\nknowledge.\r\n";
                GroupSupport.Text = "Support";
                LabelUser.Text = "User Support";
                Support.Text = "For technical support, please contact \r\n[support@academicchallenge.com]";
                GroupVersion.Text = "Application Version";
                LabelVersion.Text = "Version";
                Open.Text = "Check for Updates";
                GroupSocial.Text = "Social Media";
            }
        }
    }
}
