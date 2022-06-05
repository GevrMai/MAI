
namespace Geography_Quiz
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.UserError = new System.Windows.Forms.Label();
            this.LoginErrorLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RegError = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.UserRegError = new System.Windows.Forms.Label();
            this.UserReg = new System.Windows.Forms.TextBox();
            this.RegConf = new System.Windows.Forms.Button();
            this.PassReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserInput.Location = new System.Drawing.Point(124, 61);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(171, 31);
            this.UserInput.TabIndex = 2;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(124, 214);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(171, 31);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // Confirm
            // 
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm.Location = new System.Drawing.Point(16, 305);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(279, 44);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Подтвердить";
            this.Confirm.UseMnemonic = false;
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // UserError
            // 
            this.UserError.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserError.ForeColor = System.Drawing.Color.IndianRed;
            this.UserError.Location = new System.Drawing.Point(124, 93);
            this.UserError.Name = "UserError";
            this.UserError.Size = new System.Drawing.Size(171, 25);
            this.UserError.TabIndex = 7;
            this.UserError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginErrorLabel
            // 
            this.LoginErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.LoginErrorLabel.Location = new System.Drawing.Point(16, 376);
            this.LoginErrorLabel.Name = "LoginErrorLabel";
            this.LoginErrorLabel.Size = new System.Drawing.Size(279, 25);
            this.LoginErrorLabel.TabIndex = 9;
            this.LoginErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 465);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LoginErrorLabel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.UserError);
            this.tabPage1.Controls.Add(this.UserInput);
            this.tabPage1.Controls.Add(this.Confirm);
            this.tabPage1.Controls.Add(this.PasswordInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RegError);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.UserRegError);
            this.tabPage2.Controls.Add(this.UserReg);
            this.tabPage2.Controls.Add(this.RegConf);
            this.tabPage2.Controls.Add(this.PassReg);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RegError
            // 
            this.RegError.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegError.ForeColor = System.Drawing.Color.IndianRed;
            this.RegError.Location = new System.Drawing.Point(76, 371);
            this.RegError.Name = "RegError";
            this.RegError.Size = new System.Drawing.Size(171, 41);
            this.RegError.TabIndex = 19;
            this.RegError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // UserRegError
            // 
            this.UserRegError.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserRegError.ForeColor = System.Drawing.Color.IndianRed;
            this.UserRegError.Location = new System.Drawing.Point(76, 100);
            this.UserRegError.Name = "UserRegError";
            this.UserRegError.Size = new System.Drawing.Size(171, 25);
            this.UserRegError.TabIndex = 17;
            this.UserRegError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserReg
            // 
            this.UserReg.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserReg.Location = new System.Drawing.Point(76, 66);
            this.UserReg.Name = "UserReg";
            this.UserReg.Size = new System.Drawing.Size(171, 31);
            this.UserReg.TabIndex = 12;
            this.UserReg.TextChanged += new System.EventHandler(this.UserReg_TextChanged);
            // 
            // RegConf
            // 
            this.RegConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegConf.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegConf.Location = new System.Drawing.Point(76, 310);
            this.RegConf.Name = "RegConf";
            this.RegConf.Size = new System.Drawing.Size(171, 33);
            this.RegConf.TabIndex = 16;
            this.RegConf.Text = "Подтвердить";
            this.RegConf.UseMnemonic = false;
            this.RegConf.UseVisualStyleBackColor = true;
            this.RegConf.Click += new System.EventHandler(this.RegConf_Click);
            // 
            // PassReg
            // 
            this.PassReg.Location = new System.Drawing.Point(76, 219);
            this.PassReg.Name = "PassReg";
            this.PassReg.Size = new System.Drawing.Size(171, 31);
            this.PassReg.TabIndex = 13;
            this.PassReg.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(76, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Имя пользователя:";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 469);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label UserError;
        private System.Windows.Forms.Label LoginErrorLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label RegError;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label UserRegError;
        private System.Windows.Forms.TextBox UserReg;
        private System.Windows.Forms.Button RegConf;
        private System.Windows.Forms.TextBox PassReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

