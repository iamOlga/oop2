namespace _1_2lab
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер коллекции:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(60, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Сгенерировать коллекцию";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(317, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 22);
            this.textBox5.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(60, 106);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(239, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "По возрастанию";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(60, 151);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(239, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "По убыванию";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(317, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 22);
            this.textBox6.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(60, 200);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(239, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Максимальный эл-т";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(60, 245);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(239, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "Минимальный эл-т";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(60, 296);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(239, 23);
            this.button12.TabIndex = 9;
            this.button12.Text = "Отрицательные эл-ты";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 405);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

