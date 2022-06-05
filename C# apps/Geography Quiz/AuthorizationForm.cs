using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Users.GetUsers();       // получение списка пользователей
        }

        private void UserInput_TextChanged(object sender, EventArgs e)      // ввод имени пользователя
        {
            UserError.Text = LoginSignUP.CheckUserString(UserInput.Text.Length);        // если превышено 20 символов - выдаем ошибку
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            LoginErrorLabel.Text = Users.CheckLogin(UserInput.Text, PasswordInput.Text);        // если неверное - выдает ошибку. верно - пустая строка
            if ( LoginErrorLabel.Text == "")
            {
                Results.user = UserInput.Text;
                Hide();                                                     // прячем окно авторизации
                GameForm game = new GameForm();
                game.ShowDialog();
            }
        }

        private void UserReg_TextChanged(object sender, EventArgs e)
        {
            UserRegError.Text = LoginSignUP.CheckUserString(UserReg.Text.Length);        // если превышено 20 символов - выдаем ошибку
        }

        private void RegConf_Click(object sender, EventArgs e)          // регистрация пользователя
        {
            if(LoginSignUP.CheckUserString(UserReg.Text.Length) == "")
            {
                RegError.Text = Users.RegisterUser(UserReg.Text, PassReg.Text);
            }
        }
    }
}
