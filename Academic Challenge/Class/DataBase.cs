using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Academic_Challenge
{
    internal class DataBase
    {

        // Метод для получения строки подключения к базе данных
        public string Con()
        {
            return ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
        }

        // Метод для выполнения SQL-запроса и заполнения DataGridView
        public DataTable SqlDataReader(string query, DataGridView gridView)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Con())) // Создаем подключение
                {
                    connection.Open(); // Открываем подключение

                    // Проверяем состояние подключения
                    if (connection.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Нет подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable(); // Создаем DataTable для хранения данных
                        adapter.Fill(dt); // Заполняем DataTable данными из запроса
                        gridView.DataSource = dt; // Устанавливаем источник данных для DataGridView
                        return dt; // Возвращаем заполненный DataTable
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Возникла ошибка SQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Возвращаем null в случае ошибки
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Возвращаем null в случае ошибки
            }
        }

        // Метод для выполнения SQL-запросов, которые не возвращают данные
        public void queryExecute(string query, List<MySqlParameter> parameters = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Con())) // Создаем подключение
                {
                    connection.Open(); // Открываем подключение

                    using (MySqlCommand command = new MySqlCommand(query, connection)) // Создаем команду
                    {
                        // Если есть параметры, добавляем их к команде
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                command.Parameters.Add(parameter); // Добавляем параметры
                            }
                        }

                        command.ExecuteNonQuery(); // Выполняем запрос
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка SQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
