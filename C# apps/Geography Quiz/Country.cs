using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Quiz
{
    class Country
    {
        string RightAnswer;
        string FlagAdress;
        string BorderAdress;

        public static Country[] Get_Data(Country[] country)
        {
            try
            {
                var cs = "Host=localhost;Username=postgres;Password=12345;Database=Geography Quiz";
                var con = new NpgsqlConnection(cs);
                con.Open();
                string sql = "SELECT * FROM countries";
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    country[i] = new Country();
                    country[i].RightAnswer = rdr.GetString(0);
                    country[i].FlagAdress = rdr.GetString(1);
                    country[i].BorderAdress = rdr.GetString(2);
                    i++;
                }
                con.Close();
            }
            catch
            {
                Console.WriteLine("Произошла ошибка!");
            }
            return country;
        }
        public static string[,] GenerateQuestions(int n, Country[] country)
        {
            int[] used = new int[n];
            for (int i = 0; i < n; i++) { used[i] = 0; }
            Random rnd = new Random();
            string[,] generated_questions = new string[10, 3];      // возвращаемый массив
            int index;      // генерируемый индекс
            for (int i = 0; i < 10; i++)
            {
                index = rnd.Next(0, n);
                while (used[index] == 1)
                {
                    index = rnd.Next(0, n);
                }
                used[index] = 1;
                generated_questions[i, 0] = country[index].RightAnswer;
                generated_questions[i, 1] = country[index].FlagAdress;
                generated_questions[i, 2] = country[index].BorderAdress;
            }
            return generated_questions;
        }
    }
}
