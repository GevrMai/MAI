using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Quiz
{
    class Results
    {
        public static string user { get; set; }
        public static int correct { get; set; }
        public static string time;

        public static string CheckAnswer(string user_ans, string right_answer)
        {
            user_ans = user_ans.ToLower();
            string[] right_ans = right_answer.Split('/');
            foreach(string str in right_ans)
            {
                if(user_ans == str) { correct++; return "Верно"; }
            }
            return "Неверно";
        }
        public static void toDB()
        {
            try        // запись в БД результатов
            {
                var cs = "Host=localhost;Username=postgres;Password=12345;Database=Geography Quiz";
                var con = new NpgsqlConnection(cs);
                con.Open();
                string sql = "INSERT into results (username, correct, time) VALUES (@v1, @v2, @v3)";
                var cmd = new NpgsqlCommand(sql, con);

                cmd.Parameters.AddWithValue("v1", user);
                cmd.Parameters.AddWithValue("v2", correct);
                cmd.Parameters.AddWithValue("v3", time);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Console.WriteLine("Произошла ошибка при записи данных!");
            }
        }
    }
}
