
namespace laba1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Авторизация = new System.Windows.Forms.GroupBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.textBox1_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Авторизация.SuspendLayout();
            this.SuspendLayout();
            // 
            // Авторизация
            // 
            this.Авторизация.Controls.Add(this.label3);
            this.Авторизация.Controls.Add(this.button1_ok);
            this.Авторизация.Controls.Add(this.textBox2_password);
            this.Авторизация.Controls.Add(this.textBox1_login);
            this.Авторизация.Controls.Add(this.label2);
            this.Авторизация.Controls.Add(this.label1);
            this.Авторизация.Location = new System.Drawing.Point(13, 13);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(433, 219);
            this.Авторизация.TabIndex = 0;
            this.Авторизация.TabStop = false;
            this.Авторизация.Text = "Авторизация";
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(102, 105);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.PasswordChar = '*';
            this.textBox2_password.Size = new System.Drawing.Size(200, 31);
            this.textBox2_password.TabIndex = 3;
            // 
            // textBox1_login
            // 
            this.textBox1_login.Location = new System.Drawing.Point(102, 68);
            this.textBox1_login.Name = "textBox1_login";
            this.textBox1_login.Size = new System.Drawing.Size(200, 31);
            this.textBox1_login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "логин";
            // 
            // button1_ok
            // 
            this.button1_ok.Location = new System.Drawing.Point(102, 152);
            this.button1_ok.Name = "button1_ok";
            this.button1_ok.Size = new System.Drawing.Size(95, 49);
            this.button1_ok.TabIndex = 4;
            this.button1_ok.Text = "Пуск";
            this.button1_ok.UseVisualStyleBackColor = true;
            this.button1_ok.Click += new System.EventHandler(this.button1_ok_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(217, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 721);
            this.Controls.Add(this.Авторизация);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Авторизация.ResumeLayout(false);
            this.Авторизация.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Авторизация;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.TextBox textBox1_login;
        private System.Windows.Forms.Button button1_ok;
        private System.Windows.Forms.Label label3;
    }
}

