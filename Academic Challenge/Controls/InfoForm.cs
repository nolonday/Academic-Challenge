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
    }
}
