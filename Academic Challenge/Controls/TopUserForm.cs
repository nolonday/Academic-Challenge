using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class TopUserForm : UserControl
    {
        private DataBase db = new DataBase(); // Объект для работы с базой данных
        private string avatarColumn;
        private string loginColumn;
        private string completedTestsColumn;


        // Конструктор формы
        public TopUserForm()
        {
            InitializeComponent();
            LoadGrid(); // Загружаем данные в DataGrid при инициализации
            ApplyTheme();
        }

        // Метод для загрузки данных в DataGrid
        private void LoadGrid()
        {
            // Определяем названия колонок на основе языка
            avatarColumn = Properties.Settings.Default.Language == "ru-RU" ? "Аватар" : "Avatar";
            loginColumn = Properties.Settings.Default.Language == "ru-RU" ? "Логин" : "Login";
            completedTestsColumn = Properties.Settings.Default.Language == "ru-RU" ? "Пройдено Тестов" : "Completed Tests";

            // SQL-запрос для получения аватаров, логинов и количества пройденных тестов пользователей
            string query = $"SELECT Avatar AS `{avatarColumn}`, Login AS `{loginColumn}`, CompletedTests AS `{completedTestsColumn}` FROM Users ORDER BY CompletedTests DESC";
            db.SqlDataReader(query, DataGridTops); // Выполняем запрос и заполняем DataGrid

            // Настройка ширины и выравнивания колонок
            DataGridTops.Columns[avatarColumn].Width = 100; // Задаем фиксированную ширину для колонки с аватарами
            CenterAlignColumns(); // Выравнивание заголовков и содержимого по центру

            // Подписка на событие отрисовки ячеек для отображения аватаров
            DataGridTops.CellPainting += DataGridTops_CellPainting;
        }

        // Метод для выравнивания заголовков и содержимого всех колонок по центру
        private void CenterAlignColumns()
        {
            foreach (DataGridViewColumn column in DataGridTops.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание содержимого
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание заголовка
            }
        }

        // Обработчик события отрисовки ячеек DataGrid
        private void DataGridTops_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Проверка, что это колонка с аватарами и индекс строки не отрицательный
            if (e.ColumnIndex == DataGridTops.Columns[avatarColumn].Index && e.RowIndex >= 0)
            {
                // Преобразуем байтовый массив аватара в изображение
                var avatarBytes = (byte[])e.Value;
                using (var ms = new MemoryStream(avatarBytes))
                {
                    var image = Image.FromStream(ms);
                    // Рисуем изображение в ячейку
                    e.Graphics.DrawImage(image, e.CellBounds);
                }
                e.Handled = true; // Указываем, что ячейка была обработана
            }
        }
        
        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                DataGridTops.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(7, 8, 91);
                DataGridTops.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                DataGridTops.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DataGridTops.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }
    }
}
