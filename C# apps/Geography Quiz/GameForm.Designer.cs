
namespace Geography_Quiz
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NotAFlag = new System.Windows.Forms.Label();
            this.StartFlag = new System.Windows.Forms.Button();
            this.FlagPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NotABorder = new System.Windows.Forms.Label();
            this.StartBorder = new System.Windows.Forms.Button();
            this.BorderPictureBox = new System.Windows.Forms.PictureBox();
            this.WrongRightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTimeLabel = new System.Windows.Forms.Label();
            this.FullTimeLabel = new System.Windows.Forms.Label();
            this.RightAnsLabel = new System.Windows.Forms.Label();
            this.QueNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.NotAFlag);
            this.tabPage1.Controls.Add(this.StartFlag);
            this.tabPage1.Controls.Add(this.FlagPictureBox);
            this.tabPage1.Name = "tabPage1";
            // 
            // NotAFlag
            // 
            resources.ApplyResources(this.NotAFlag, "NotAFlag");
            this.NotAFlag.ForeColor = System.Drawing.Color.Maroon;
            this.NotAFlag.Name = "NotAFlag";
            // 
            // StartFlag
            // 
            resources.ApplyResources(this.StartFlag, "StartFlag");
            this.StartFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartFlag.Name = "StartFlag";
            this.StartFlag.UseVisualStyleBackColor = true;
            this.StartFlag.Click += new System.EventHandler(this.StartFlag_Click);
            this.StartFlag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTextBox_KeyDown);
            // 
            // FlagPictureBox
            // 
            resources.ApplyResources(this.FlagPictureBox, "FlagPictureBox");
            this.FlagPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlagPictureBox.Name = "FlagPictureBox";
            this.FlagPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.NotABorder);
            this.tabPage2.Controls.Add(this.StartBorder);
            this.tabPage2.Controls.Add(this.BorderPictureBox);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NotABorder
            // 
            resources.ApplyResources(this.NotABorder, "NotABorder");
            this.NotABorder.ForeColor = System.Drawing.Color.Maroon;
            this.NotABorder.Name = "NotABorder";
            // 
            // StartBorder
            // 
            resources.ApplyResources(this.StartBorder, "StartBorder");
            this.StartBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBorder.Name = "StartBorder";
            this.StartBorder.UseVisualStyleBackColor = true;
            this.StartBorder.Click += new System.EventHandler(this.StartBorder_Click);
            // 
            // BorderPictureBox
            // 
            resources.ApplyResources(this.BorderPictureBox, "BorderPictureBox");
            this.BorderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderPictureBox.Name = "BorderPictureBox";
            this.BorderPictureBox.TabStop = false;
            // 
            // WrongRightLabel
            // 
            resources.ApplyResources(this.WrongRightLabel, "WrongRightLabel");
            this.WrongRightLabel.Name = "WrongRightLabel";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // AnswerTextBox
            // 
            resources.ApplyResources(this.AnswerTextBox, "AnswerTextBox");
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTextBox_KeyDown);
            // 
            // QuestionTimeLabel
            // 
            resources.ApplyResources(this.QuestionTimeLabel, "QuestionTimeLabel");
            this.QuestionTimeLabel.Name = "QuestionTimeLabel";
            // 
            // FullTimeLabel
            // 
            resources.ApplyResources(this.FullTimeLabel, "FullTimeLabel");
            this.FullTimeLabel.Name = "FullTimeLabel";
            // 
            // RightAnsLabel
            // 
            resources.ApplyResources(this.RightAnsLabel, "RightAnsLabel");
            this.RightAnsLabel.Name = "RightAnsLabel";
            // 
            // QueNumberLabel
            // 
            resources.ApplyResources(this.QueNumberLabel, "QueNumberLabel");
            this.QueNumberLabel.Name = "QueNumberLabel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.WrongRightLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FullTimeLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RightAnsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QueNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlagPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BorderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label QuestionTimeLabel;
        private System.Windows.Forms.Label FullTimeLabel;
        private System.Windows.Forms.Label RightAnsLabel;
        private System.Windows.Forms.Label QueNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FlagPictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label WrongRightLabel;
        private System.Windows.Forms.PictureBox BorderPictureBox;
        private System.Windows.Forms.Button StartFlag;
        private System.Windows.Forms.Button StartBorder;
        private System.Windows.Forms.Label NotAFlag;
        private System.Windows.Forms.Label NotABorder;
    }
}