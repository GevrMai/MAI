using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Quiz
{
    class LoginSignUP
    {
        public static string CheckUserString(int UserInputLength)     // проверка имени пользователя на макс. длину 20 символов
        {
            if (UserInputLength > 20)
            {
                return "Cлишком длинное имя";
            }
            else return "";
        }
    }
}
