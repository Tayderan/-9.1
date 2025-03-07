namespace Лаб9._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonTime = new System.Windows.Forms.Button();
            this.buttonChampion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Соревнования по триатлону";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Андрей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Егор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Михаил";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Плавает (м/с)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Бег (км/ч)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Велосипед (км/ч)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Общее время (мин)";
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(103, 381);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(75, 23);
            this.buttonTime.TabIndex = 10;
            this.buttonTime.Text = "Время";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // buttonChampion
            // 
            this.buttonChampion.Location = new System.Drawing.Point(407, 381);
            this.buttonChampion.Name = "buttonChampion";
            this.buttonChampion.Size = new System.Drawing.Size(75, 23);
            this.buttonChampion.TabIndex = 11;
            this.buttonChampion.Text = "Чемпион";
            this.buttonChampion.UseVisualStyleBackColor = true;
            this.buttonChampion.Click += new System.EventHandler(this.buttonChampion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(412, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(548, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(412, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(70, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(548, 225);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(70, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(261, 274);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(412, 274);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(70, 20);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(548, 274);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(70, 20);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(261, 321);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(70, 20);
            this.textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(412, 321);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(70, 20);
            this.textBox11.TabIndex = 22;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(548, 321);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(70, 20);
            this.textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(548, 381);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(70, 20);
            this.textBox13.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(667, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 44);
            this.label4.TabIndex = 25;
            this.label4.Text = "Нажмите F1 во время ввода для получения подсказки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonChampion);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.Button buttonChampion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label4;
    }
}

