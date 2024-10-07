using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace Academic_Challenge
{
    internal class Methods
    {
        private DataBase db = new DataBase();

        // Свойства для хранения данных пользователя
        public static int User_ID { get; private set; }
        public static string Email { get; private set; }
        public static string Login { get; private set; }
        public static string Password { get; private set; }
        public static string Role { get; private set; }
        public static byte[] Avatar { get; private set; }
        public static DateTime DateReg { get; private set; }
        public static string Email_User { get; private set; }
        public static string Login_User { get; private set; }
        public static string Password_User { get; private set; }
        public static string Role_User { get; private set; }
        public static byte[] Avatar_User { get; private set; }
        public static int CompletedTests_User { get; private set; }
        public static int ScoreResult { get; private set; }
        public static string SubjectName { get; private set; }
        public static string TestName { get; private set; }
        public static string TestDesc { get; private set; }
        public static string TestComplexity { get; private set; }
        public static string Question_Text { get; private set; }
        public static string Answer_A { get; private set; }
        public static string Answer_B { get; private set; }
        public static string Answer_C { get; private set; }
        public static string Answer_D { get; private set; }
        public static string Correct_Answer { get; private set; }

        // Метод для авторизации пользователя
        public bool AuthUser(string login, string password)
        {
            // SQL-запрос для поиска пользователя
            var query = "SELECT * FROM Users WHERE Login = @Login AND Password = @Password";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    // Параметры для SQL-запроса
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Проверяем, есть ли строки в результате
                        if (reader.Read())
                        {
                            // Считываем данные пользователя
                            User_ID = (int)reader["User_ID"];
                            Login = reader["Login"].ToString();
                            Password = reader["Password"].ToString();
                            Email = reader["Mail"].ToString();
                            Avatar = reader["Avatar"] as byte[];
                            Role = reader["Role"].ToString();
                            DateReg = (DateTime)reader["Created"];
                            return true; // Успешная авторизация
                        }
                    }
                }
            }
            return false; // Неудачная авторизация
        }

        // Метод для проверки восстановления доступа к аккаунту
        public bool CheckUserRecovery(string login, string code)
        {
            var query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Code = @Code";

            using (MySqlConnection connection = new MySqlConnection(db.Con()))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Явное указание параметров
                    command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
                    command.Parameters.Add("@Code", MySqlDbType.VarChar).Value = code;

                    // Используем ExecuteScalar для получения единственного значения
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    return userCount > 0; // Возвращаем true, если найден хотя бы один пользователь
                }
            }
        }

        // Метод для получения информации о пользователе
        public bool UserInfo(int user_id)
        {
            var query = "SELECT Mail, Login, Password, Role, Avatar, CompletedTests FROM Users WHERE User_ID = @User_ID";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    command.Parameters.AddWithValue("@User_ID", user_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Считываем данные пользователя
                            Email_User = reader["Mail"].ToString();
                            Login_User = reader["Login"].ToString();
                            Password_User = reader["Password"].ToString();
                            Role_User = reader["Role"].ToString();
                            Avatar_User = reader["Avatar"] as byte[];
                            CompletedTests_User = (int)reader["CompletedTests"];
                            return true; // Успешно считана информация
                        }
                    }
                }
            }
            return false; // Не удалось получить информацию
        }

        // Метод для получения результата пользователя по идентификатору оценки
        public bool UserResult(int score_id)
        {
            var query = "SELECT Score FROM TestScores WHERE Score_ID = @Score_ID";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    command.Parameters.AddWithValue("@Score_ID", score_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ScoreResult = (int)reader["Score"]; // Считываем результат
                            return true; // Успешно считан результат
                        }
                    }
                }
            }
            return false; // Не удалось получить результат
        }

        // Метод для получения названия предмета по его идентификатору
        public bool SubjectNameResult(int subject_id)
        {
            var query = "SELECT Name FROM Subjects WHERE Subject_ID = @Subject_ID";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    // Параметр для SQL-запроса
                    command.Parameters.AddWithValue("@Subject_ID", subject_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Проверяем, есть ли строки в результате
                        if (reader.Read())
                        {
                            SubjectName = reader["Name"].ToString(); // Считываем название
                            return true; // Успешно считано
                        }
                    }
                }
            }
            return false; // Не удалось найти предмет
        }

        // Метод для получения информации о тесте по его идентификатору
        public bool TestNameResult(int test_id)
        {
            var query = "SELECT Name, Description, Complexity FROM Tests WHERE Test_ID = @Test_ID";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    // Параметр для SQL-запроса
                    command.Parameters.AddWithValue("@Test_ID", test_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TestName = reader["Name"].ToString(); // Считываем название теста
                            TestDesc = reader["Description"].ToString(); // Считываем описание
                            TestComplexity = reader["Complexity"].ToString(); // Считываем сложность
                            return true; // Успешно считано
                        }
                    }
                }
            }
            return false; // Не удалось найти тест
        }

        public bool QuestionNameResult(int question_id)
        {
            var query = "SELECT Question_Text, Answer_A, Answer_B, Answer_C, Answer_D, Correct_Answer FROM Questions WHERE Question_ID = @Question_ID";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    // Параметр для SQL-запроса
                    command.Parameters.AddWithValue("@Question_ID", question_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Question_Text = reader["Question_Text"].ToString(); 
                            Answer_A = reader["Answer_A"].ToString();
                            Answer_B = reader["Answer_B"].ToString();
                            Answer_C = reader["Answer_C"].ToString();
                            Answer_D = reader["Answer_D"].ToString();
                            Correct_Answer = reader["Correct_Answer"].ToString();
                            return true; // Успешно считано
                        }
                    }
                }
            }
            return false; // Не удалось найти тест
        }

        // Метод для регистрации нового пользователя
        public bool RegUser(string mail, string login, string password, DateTime created, byte[] avatar,string code)
        {
            string query = "INSERT INTO Users (Mail, Login, Password, Created, Role, Avatar, CompletedTests,Code) VALUES (@Mail, @Login, @Password, @Created, @Role, @Avatar, @CompletedTests, @Code)";

            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@Mail", mail);
                    comm.Parameters.AddWithValue("@Login", login);
                    comm.Parameters.AddWithValue("@Password", password);
                    comm.Parameters.AddWithValue("@Created", created);
                    comm.Parameters.AddWithValue("@Role", "Пользователь");
                    comm.Parameters.AddWithValue("@Avatar", avatar);
                    comm.Parameters.AddWithValue("@CompletedTests", 0);
                    comm.Parameters.AddWithValue("@Code", code);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если запись успешно добавлена
                }
            }
        }

        // Метод для добавления вопроса в тест
        public bool AddQuestion(int test_id, string name, string answA, string answB, string answC, string answD, string correctAnsw)
        {
            string query = "INSERT INTO Questions (Test_ID, Question_Text, Answer_A, Answer_B, Answer_C, Answer_D, Correct_Answer) VALUES (@Test_ID, @Question_Text, @Answer_A, @Answer_B, @Answer_C, @Answer_D, @Correct_Answer)";

            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@Test_ID", test_id);
                    comm.Parameters.AddWithValue("@Question_Text", name);
                    comm.Parameters.AddWithValue("@Answer_A", answA);
                    comm.Parameters.AddWithValue("@Answer_B", answB);
                    comm.Parameters.AddWithValue("@Answer_C", answC);
                    comm.Parameters.AddWithValue("@Answer_D", answD);
                    comm.Parameters.AddWithValue("@Correct_Answer", correctAnsw);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если вопрос успешно добавлен
                }
            }
        }

        // Метод для добавления нового предмета
        public bool AddSubject(string name)
        {
            string query = "INSERT INTO Subjects (Name, Count_Tests) VALUES (@Name, 0)";

            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    comm.Parameters.AddWithValue("@Name", name);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если предмет успешно добавлен
                }
            }
        }

        // Метод для добавления нового теста
        public bool AddTest(int subject_id, string name, string description, string complexity)
        {
            string query = "INSERT INTO Tests (Subject_ID, Name, Description, Complexity) VALUES (@Subject_ID, @Name, @Description, @Complexity)";

            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@Subject_ID", subject_id);
                    comm.Parameters.AddWithValue("@Name", name);
                    comm.Parameters.AddWithValue("@Description", description);
                    comm.Parameters.AddWithValue("@Complexity", complexity);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если тест успешно добавлен
                }
            }
        }

        // Метод для обновления аватара пользователя
        public bool UpdateAvatar(int userId, byte[] avatar)
        {
            string query = "UPDATE Users SET Avatar = @Avatar WHERE User_ID = @User_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@User_ID", userId);
                    comm.Parameters.AddWithValue("@Avatar", avatar);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если аватар успешно обновлен
                }
            }
        }

        // Метод для обновления названия предмета
        public bool UpdateSubject(int subject_id, string name)
        {
            string query = "UPDATE Subjects SET Name = @Name WHERE Subject_ID = @Subject_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    comm.Parameters.AddWithValue("@Subject_ID", subject_id);
                    comm.Parameters.AddWithValue("@Name", name);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если предмет успешно обновлен
                }
            }
        }

        // Метод для обновления информации о тесте
        public bool UpdateTest(int test_id, string name, string desc, string complexity)
        {
            string query = "UPDATE Tests SET Name = @Name, Description = @Description, Complexity = @Complexity WHERE Test_ID = @Test_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@Test_ID", test_id);
                    comm.Parameters.AddWithValue("@Name", name);
                    comm.Parameters.AddWithValue("@Description", desc);
                    comm.Parameters.AddWithValue("@Complexity", complexity);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если тест успешно обновлен
                }
            }
        }

        // Метод для обновления информации о тесте
        public bool UpdateQuestion(int quesion_id, string text, string answerA, string answerB, string answerC, string answerD, string answercorrect)
        {
            string query = "UPDATE Questions SET Question_Text = @Qustion_Text, Answer_A = @Answer_A, Answer_B = @Answer_B,Answer_C = @Answer_C,Answer_D = @Answer_D,Correct_Answer = @Correct_Answer WHERE Question_ID = @Question_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@Question_ID", quesion_id);
                    comm.Parameters.AddWithValue("@Qustion_Text", text);
                    comm.Parameters.AddWithValue("@Answer_A", answerA);
                    comm.Parameters.AddWithValue("@Answer_B", answerB);
                    comm.Parameters.AddWithValue("@Answer_C", answerC);
                    comm.Parameters.AddWithValue("@Answer_D", answerD);
                    comm.Parameters.AddWithValue("@Correct_Answer", answercorrect);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если тест успешно обновлен
                }
            }
        }

        // Метод для проверки существования пользователя по логину и почте
        public bool CheckUser(string mail, string login)
        {
            string query = "SELECT User_ID, Login, Mail FROM Users WHERE Login = @Login AND Mail = @Mail";
            using (MySqlConnection con = new MySqlConnection(db.Con()))
            {
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Login", login);

                    con.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows; // Возвращаем true, если пользователь найден
                    }
                }
            }
        }

        // Метод для обновления информации о пользователе
        public bool UpdateUser(int user_id, string mail, string login, string pass)
        {
            string query = "UPDATE Users SET Mail = @Mail, Login = @Login, Password = @Password WHERE User_ID = @User_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@User_ID", user_id);
                    comm.Parameters.AddWithValue("@Mail", mail);
                    comm.Parameters.AddWithValue("@Login", login);
                    comm.Parameters.AddWithValue("@Password", pass);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если пользователь успешно обновлен
                }
            }
        }

        // Метод для восстановления пароля пользователя
        public bool RecoveryUser(string login, string pass)
        {
            string query = "UPDATE Users SET Password = @Password WHERE Login = @Login";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // SQL parameters
                    comm.Parameters.AddWithValue("@Login", login);
                    comm.Parameters.AddWithValue("@Password", pass);

                    return comm.ExecuteNonQuery() == 1; // Возвращает значение true, если пароль был успешно обновлен
                }
            }
        }

        // Метод для обновления информации о пользователе администратором
        public bool UpdateUserAdmin(int user_id, string mail, string login, string pass, string role, int tests)
        {
            string query = "UPDATE Users SET Mail = @Mail, Login = @Login, Password = @Password, Role = @Role, CompletedTests = @CompletedTests WHERE User_ID = @User_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@User_ID", user_id);
                    comm.Parameters.AddWithValue("@Mail", mail);
                    comm.Parameters.AddWithValue("@Login", login);
                    comm.Parameters.AddWithValue("@Password", pass);
                    comm.Parameters.AddWithValue("@Role", role);
                    comm.Parameters.AddWithValue("@CompletedTests", tests);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если данные пользователя успешно обновлены
                }
            }
        }

        // Метод для получения аватара пользователя по логину
        public byte[] GetAvatarByLogin(string login)
        {
            var query = "SELECT Avatar FROM Users WHERE Login = @Login";
            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Avatar"] as byte[]; // Возвращаем аватар пользователя
                        }
                    }
                }
            }
            return null; // Если аватар не найден, возвращаем null
        }

        // Метод для загрузки вопроса по индексу
        public void LoadQuestionByIndex(int testId, int questionIndex, System.Windows.Forms.Label questionLabel, Guna2RadioButton buttonA, Guna2RadioButton buttonB, Guna2RadioButton buttonC, Guna2RadioButton buttonD)
        {
            string query = "SELECT Question_Text, Answer_A, Answer_B, Answer_C, Answer_D FROM Questions WHERE Test_ID = @TestID ORDER BY Question_ID LIMIT 1 OFFSET @Offset";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    command.Parameters.AddWithValue("@TestID", testId);
                    command.Parameters.AddWithValue("@Offset", questionIndex);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill UI elements with the question and answers
                            questionLabel.Text = reader["Question_Text"].ToString();
                            buttonA.Text = reader["Answer_A"].ToString();
                            buttonB.Text = reader["Answer_B"].ToString();
                            buttonC.Text = reader["Answer_C"].ToString();
                            buttonD.Text = reader["Answer_D"].ToString();
                        }
                    }
                }
            }
        }

        // Метод для получения правильного ответа на вопрос
        public string GetCorrectAnswer(int testId, int questionIndex)
        {
            // Corrected query for MySQL
            string query = "SELECT Correct_Answer FROM Questions WHERE Test_ID = @TestID ORDER BY Question_ID LIMIT 1 OFFSET @Offset";

            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    command.Parameters.AddWithValue("@TestID", testId);
                    command.Parameters.AddWithValue("@Offset", questionIndex);
                    return command.ExecuteScalar()?.ToString(); // Возвращаем правильный ответ
                }
            }
        }

        // Метод для получения общего количества вопросов в тесте
        public int GetTotalQuestionCount(int testId)
        {
            string query = "SELECT COUNT(*) FROM Questions WHERE Test_ID = @TestID";
            using (MySqlConnection conect = new MySqlConnection(db.Con()))
            {
                conect.Open();
                using (MySqlCommand command = new MySqlCommand(query, conect))
                {
                    command.Parameters.AddWithValue("@TestID", testId);
                    object result = command.ExecuteScalar();

                    // Check if result is null and return 0 if it is
                    if (result == null)
                    {
                        return 0; // No questions found
                    }

                    // Safely convert the result to an int
                    return Convert.ToInt32(result);
                }
            }
        }

        // Метод для расчета и сохранения результата теста
        public bool CalculateAndSaveScore(int userId, int testId, int correctAnswers)
        {
            int totalQuestions = GetTotalQuestionCount(testId);
            int score = 0;

            if (totalQuestions > 0)
            {
                decimal percentage = (correctAnswers * 100.0m) / totalQuestions;

                // Определяем оценку на основе процента правильных ответов
                if (percentage < 40)
                    score = 2;
                else if (percentage < 60)
                    score = 3;
                else if (percentage < 80)
                    score = 4;
                else
                    score = 5;
            }

            // Updated query for MySQL
            string query = "INSERT INTO TestScores (User_ID, Test_ID, Score, Completed) VALUES (@UserID, @TestID, @Score, NOW())";

            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    // Параметры для SQL-запроса
                    comm.Parameters.AddWithValue("@UserID", userId);
                    comm.Parameters.AddWithValue("@TestID", testId);
                    comm.Parameters.AddWithValue("@Score", score);

                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если оценка успешно сохранена
                }
            }
        }

        // Метод для получения идентификаторов завершенных тестов пользователем
        public List<int> GetCompletedTestIds(int userId, int subjectId)
        {
            List<int> completedTestIds = new List<int>();
            string query = "SELECT Test_ID FROM TestScores WHERE User_ID = @UserID";

            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand command = new MySqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            completedTestIds.Add(reader.GetInt32(0)); // Добавляем идентификатор завершенного теста
                        }
                    }
                }
            }

            return completedTestIds; // Возвращаем список завершенных тестов
        }

        // Метод для обновления счетчика завершенных тестов у пользователя
        public bool UpdateUserCompletedTest(int user_id)
        {
            string query = "UPDATE Users SET CompletedTests = CompletedTests + 1 WHERE User_ID = @User_ID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand comm = new MySqlCommand(query, connect))
                {
                    comm.Parameters.AddWithValue("@User_ID", user_id);
                    return comm.ExecuteNonQuery() == 1; // Возвращаем true, если счетчик успешно обновлен
                }
            }
        }

        // Метод для проверки наличия вопросов в тесте
        public bool HasQuestions(int testId)
        {
            string query = "SELECT COUNT(*) FROM Questions WHERE Test_ID = @TestID";
            using (MySqlConnection connect = new MySqlConnection(db.Con()))
            {
                connect.Open();
                using (MySqlCommand command = new MySqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@TestID", testId);
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        return count > 0; // Returns true if there are questions
                    }
                    return false; // No questions found or count is null
                }
            }
        }
    }
}
