using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Geography_Quiz
{
    class Users
    {
        private static List<string> UserName = new List<string>();
        private static List<string> Password = new List<string>();
        public static void GetUsers()       // получение всех польхователей из БД
        {
            try
            {
                var cs = "Host=localhost;Username=postgres;Password=12345;Database=Geography Quiz";
                var con = new NpgsqlConnection(cs);
                con.Open();
                string sql = "SELECT * FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserName.Add(rdr.GetString(0));
                    Password.Add(rdr.GetString(1));
                }
                con.Close();
            }
            catch
            {
                Console.WriteLine("Произошла ошибка!");
            }
        }
        public static string CheckLogin(string user, string password)       // проверка для входа в само приложение
        {
            if(!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password))      // если поля ввода не пустые
            {
                if (UserName.Contains(user))
                {
                    if( (UserName.IndexOf(user) == Password.IndexOf(password)) && (password == Password[Password.IndexOf(password)]) )
                    {
                        return "";
                    }
                    else { return "Пароль неверный"; }
                }
                else { return "Пользователь не найден";}
            }
            else{ return "Введена пустая строка"; }
        }

        public static string RegisterUser(string user, string password)             // регистрация пользователя
        {
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password))      // не пустые строки
            {
                user = user.Trim();                     //удаление пробелов с конца и начала
                password = password.Trim();
                if (!Users.UserName.Contains(user))
                {
                    try        // запись в БД пользователя
                    {
                        var cs = "Host=localhost;Username=postgres;Password=12345;Database=Geography Quiz";
                        var con = new NpgsqlConnection(cs);
                        con.Open();
                        string sql = "INSERT into users (name_of_user, password) VALUES (@v1, @v2)";
                        var cmd = new NpgsqlCommand(sql, con);

                        cmd.Parameters.AddWithValue("v1", user);
                        cmd.Parameters.AddWithValue("v2", password);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Users.UserName.Clear();
                        Users.Password.Clear();
                        Users.GetUsers();
                        return "Пользователь успешно добавлен";
                    }
                    catch
                    {
                        return "Произошла ошибка";
                    }
                }
                else
                {
                    return "Такой пользователь уже существует";
                }
            }
            else { return "Введена пустая строка"; }
        }
    }
}
