using Academic_Challenge.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Academic_Challenge
{
    public partial class MainAuthForm : Form
    {
        private ProfileForm profileForm; // Ссылка на форму профиля
        private DataBase db = new DataBase(); // Объект базы данных
        private Methods methods = new Methods(); // Объект для работы с методами
        private SubjectsForm subjectsForm; // Ссылка на форму предметов
        private DragDropWindow dragDropWindow = new DragDropWindow(); // Объект для перетаскивания окна

        // Конструктор формы авторизации
        public MainAuthForm(string login)
        {
            this.Refresh();
            InitializeComponent(); // Инициализация компонентов формы

            // Проверка роли пользователя и обновление интерфейса
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {               
                TextAdmin.ForeColor = Color.Red; // Изменение цвета текста для админа
                PictureUsers.Image = Properties.Resources.usersA; // Установка изображения пользователей
            }
            else
            {
                TextAdmin.ForeColor = (Properties.Settings.Default.Theme == "Black" ? Color.Black : Color.FromArgb(7, 8, 91));
                PictureUsers.Visible = false; // Скрытие иконки пользователей для неадминов
            }

            // Установка аватара пользователя
            if (Methods.Avatar != null)
            {
                using (var ms = new MemoryStream(Methods.Avatar))
                {
                    ProfileAvatar.Image = Image.FromStream(ms);
                }
            }
            AutoLogin(); // Попытка автоматического входа
            LoadSubjects(); // Загрузка предметов
            ApplyTheme();
        }

        // Метод, вызываемый при нажатии на логотип
        private void Logo_Click(object sender, EventArgs e)
        {
            LoadSubjects(); // Перезагрузка списка предметов
        }

        // Метод для загрузки информации
        private void Info_Click(object sender, EventArgs e)
        {
            LoadInfo(); // Загрузка информации
        }

        // Метод для перетаскивания панели при нажатии
        private void PanelUp_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this);
        }

        // Метод для перетаскивания таблицы предметов
        private void datagridsubject_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this);
        }

        // Метод для автоматического входа
        private void AutoLogin()
        {
            var savedUsername = Properties.Settings.Default.Login;
            var savedPassword = Properties.Settings.Default.Pass;

            if (methods.AuthUser(savedUsername, savedPassword))
            {
                UpdateAvatar(savedUsername); // Обновление аватара
                LoadSubjects(); // Загрузка предметов
            }
            else
            {
                MessageBox.Show("Не удалось выполнить автоматический вход.");
                this.Hide(); // Скрытие формы
            }
        }

        // Метод для обновления аватара пользователя
        public void UpdateAvatar(string login)
        {
            byte[] avatarData = methods.GetAvatarByLogin(login); // Получение данных аватара

            if (avatarData != null)
            {
                using (var ms = new MemoryStream(avatarData))
                {
                    ProfileAvatar.Image = Image.FromStream(ms); // Установка аватара
                }
            }
        }

        // Метод для перетаскивания панели переключения
        private void panelSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this);
        }

        // Метод для загрузки предметов
        public void LoadSubjects()
        {
            this.Update();
            subjectsForm = new SubjectsForm(this); // Создание формы предметов
            panelSwitched.Controls.Clear(); // Очистка панели
            panelSwitched.Controls.Add(subjectsForm); // Добавление формы предметов на панель
        }

        // Метод для загрузки тестов
        public void LoadTests(int subject_id)
        {
            TestsForm testsForm = new TestsForm(subject_id, this);
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(testsForm);
        }

        // Метод для загрузки профиля
        public void LoadProfile()
        {
            profileForm = new ProfileForm(this);
            profileForm.LogoutRequested += ProfileForm_LogoutRequested; // Подписка на событие выхода
            profileForm.AvatarUpdated += ProfileForm_AvatarUpdated; // Подписка на событие обновления аватара
            profileForm.UpdateTheme += ProfileForm_UpdateTheme;
            panelSwitched.Controls.Clear(); // Очистка панели
            panelSwitched.Controls.Add(profileForm); // Добавление формы профиля на панель
        }

        // Метод для загрузки информации
        public void LoadInfo()
        {
            InfoForm infoForm = new InfoForm();
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(infoForm); // Добавление формы информации на панель
        }

        // Метод для загрузки вопросов
        public void LoadQuestions(int test_id, int subject)
        {
            QuestionsForm questionsForm = new QuestionsForm(test_id, subject, this);
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(questionsForm); // Добавление формы вопросов на панель
        }

        // Метод для загрузки формы пользователей
        public void LoadUsersForm()
        {
            UsersForm usersForm = new UsersForm(this);
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(usersForm); // Добавление формы пользователей на панель
        }

        // Метод для загрузки информации о пользователе
        public void LoadInfoUserForm(int id)
        {
            InformationUserForm informationUserForm = new InformationUserForm(id, this);
            informationUserForm.AvatarUpdated += ProfileForm_AvatarUpdated; // Подписка на событие обновления аватара
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(informationUserForm); // Добавление формы информации о пользователе на панель
        }

        // Метод для загрузки топа пользователей
        public void LoadTopUserForm()
        {
            TopUserForm topUserForm = new TopUserForm();
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(topUserForm); // Добавление формы топа пользователей на панель
        }

        // Метод для загрузки всех вопросов
        public void LoadQuestionsAllForm(int id_test,int subject_id)
        {
            AllQuestionForm allQuestionForm = new AllQuestionForm(id_test,this,subject_id);
            panelSwitched.Controls.Clear();
            panelSwitched.Controls.Add(allQuestionForm); // Добавление формы топа пользователей на панель
        }

        // Метод для перетаскивания панели переключения
        private void panelSwitched_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this);
        }

        // Метод для загрузки профиля при клике на аватар
        private void ProfileAvatar_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        // Метод для выхода из приложения при двойном щелчке на логотип
        private void Logo_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Метод, вызываемый при запросе выхода из профиля
        private void ProfileForm_LogoutRequested(object sender, EventArgs e)
        {
            this.Hide(); // Скрытие текущей формы
            MainForm mainForm = new MainForm(); // Создание новой формы
            mainForm.ShowDialog(); // Показ формы
        }

        // Метод для обновления аватара после изменения в профиле
        private void ProfileForm_AvatarUpdated(object sender, EventArgs e)
        {
            UpdateAvatar(Methods.Login); // Обновление аватара
        }

        // Метод обновление темы 
        private void ProfileForm_UpdateTheme(object sender, EventArgs e)
        {
            if (Methods.Role == "Админ" || Properties.Settings.Default.Role == "Админ")
            {
                TextAdmin.ForeColor = Color.Red;
            }
            else
            {
                TextAdmin.ForeColor = (Properties.Settings.Default.Theme == "Black" ? Color.Black : Color.FromArgb(7, 8, 91));
            }            
            ApplyTheme();
        }

        // Метод для загрузки формы пользователей при клике на иконку
        private void PictureUsers_Click(object sender, EventArgs e)
        {
            LoadUsersForm();
        }

        // Метод для загрузки формы топа пользователей
        private void Top_Click(object sender, EventArgs e)
        {
            LoadTopUserForm();
        }

        // Метод для перетаскивания окна при нажатии на текст логотипа
        private void Logo_Text_MouseDown(object sender, MouseEventArgs e)
        {
            dragDropWindow.Drag(this);
        }

        // Отключени кнопок
        public void DisableClick()
        {
            Logo.Click -= Logo_Click;
            Logo.DoubleClick -= Logo_DoubleClick;
            ProfileAvatar.Click -= ProfileAvatar_Click;
            Info.Click -= Info_Click;
            Top.Click -= Top_Click;
        }

        // Включени кнопок
        public void EnableClick()
        {
            Logo.Click += Logo_Click;
            Logo.DoubleClick += Logo_DoubleClick;
            ProfileAvatar.Click += ProfileAvatar_Click;
            Info.Click += Info_Click;
            Top.Click += Top_Click;
        }

        // Метод темы
        private void ApplyTheme()
        {
            // Применение темы в интерфейсе
            if (Properties.Settings.Default.Theme == "Default")
            {
                PanelUp.BackColor = Color.FromArgb(7, 8, 91);
            }
            else if (Properties.Settings.Default.Theme == "Black")
            {
                PanelUp.BackColor = Color.Black;
            }
        }
    }
}
