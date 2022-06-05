using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz
{
    public partial class GameForm : Form
    {
        int seconds = 0, minutes = 0, hours = 0;        // время текущего вопроса
        int SECONDS = 0, MINUTES = 0, HOURS = 0;        // общее время
        int n = 82;                                     // кол-во стран
        int QuizType = 0;                               // тип: флаги или границы
        int current_question = 1;                       // номер текущего вопроса
        Country[] countries = new Country[82];          // массив всех стран
        string[,] GeneratedQuestions = new string[10, 3];       //матрица сгенерированных вопросов
        bool isRunning = false;                                 // идет ли уже викторина

        private void StartBorder_Click(object sender, EventArgs e)
        {
            if (!isRunning)     // если не запущена викторина
            {
                QuizType = 2;                                   // отгадываем границы стран
                QueNumberLabel.Text = "1";
                GeneratedQuestions = Country.GenerateQuestions(n, countries);
                BorderPictureBox.Image = Image.FromFile(GeneratedQuestions[0, 2]);
                timer.Enabled = true;
                isRunning = true;
                NotAFlag.Text = "Сейчас идет другая викторина. Переключитесь на другую страницу.";
                StartFlag.Enabled = false;                      // нельзя нажать кнопку начала другой викторины
                StartBorder.Enabled = false;
            }
            else if (isRunning)         // если уже идет, то нажатие на "начать" - выход
            {
                isRunning = false;
                Results.correct = 0;        // обнуление верных ответов
                Hide();
                AuthorizationForm loginform = new AuthorizationForm();
                loginform.ShowDialog();
            }
        }

        public GameForm()
        {
            InitializeComponent();
            Country.Get_Data(countries);            // получение из БД стран
        }

        private void StartFlag_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                QuizType = 1;
                QueNumberLabel.Text = "1";
                GeneratedQuestions = Country.GenerateQuestions(n, countries);
                FlagPictureBox.Image = Image.FromFile(GeneratedQuestions[0, 1]);
                timer.Enabled = true;
                isRunning = true;
                NotABorder.Text = "Сейчас идет другая викторина. Переключитесь на другую страницу.";
                StartBorder.Enabled = false;
                StartFlag.Enabled = false;
            }
            else if(isRunning)
            {
                isRunning = false;
                Results.correct = 0;
                Hide();
                AuthorizationForm loginform = new AuthorizationForm();
                loginform.ShowDialog();
            }
        }

        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)        // нажатие на ENTER - ввод ответа
        {
            if (e.KeyCode == Keys.Enter && AnswerTextBox.Text != "" && current_question <= 10)
            {
                e.Handled = true;                   // убрать системный звук при нажатии Enter
                e.SuppressKeyPress = true;
                WrongRightLabel.Text = Results.CheckAnswer(AnswerTextBox.Text, GeneratedQuestions[current_question-1, 0]);    // проверка правильности
                if (WrongRightLabel.Text == "Верно") { WrongRightLabel.ForeColor = Color.Green; }
                else { WrongRightLabel.ForeColor = Color.Red; }
                current_question++;
                RightAnsLabel.Text = Convert.ToString(Results.correct);
                QueNumberLabel.Text = Convert.ToString(current_question);
                if (current_question <= 10)                                                       // отображение следующего вопроса
                {
                    if(QuizType == 1) { FlagPictureBox.Image = Image.FromFile(GeneratedQuestions[current_question-1, 1]); }
                    else { BorderPictureBox.Image = Image.FromFile(GeneratedQuestions[current_question-1, 2]); }
                    seconds = hours = minutes = 0;
                }
                else      // конец викторины
                {
                    WrongRightLabel.Text = "Викторина завершилась. Верных ответов - " + Convert.ToString(Results.correct) + ". Повторите вход или выйдете из программы";
                    timer.Enabled = false;
                    Results.time = Convert.ToString(HOURS + ":" + MINUTES + ":" + SECONDS);
                    WrongRightLabel.ForeColor = Color.Black;
                    Results.toDB();                                                 //запись резутатов в БД
                    StartBorder.Enabled = true;
                    StartFlag.Enabled = true;
                }
                AnswerTextBox.Text = "";
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            SECONDS++;      // время с начала викторины
            seconds++;      // время с начала вопроса
            if (seconds == 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 59)
            {
                hours++;
                minutes = 0;
            }
            if (SECONDS == 59)
            {
                MINUTES++;
                SECONDS = 0;
            }
            if (MINUTES == 59)
            {
                HOURS++;
                MINUTES = 0;
            }
            FullTimeLabel.Text = Convert.ToString(HOURS + ":" + MINUTES + ":" + SECONDS);
            QuestionTimeLabel.Text = Convert.ToString(hours + ":" + minutes + ":" + seconds);
        }
    }
}
