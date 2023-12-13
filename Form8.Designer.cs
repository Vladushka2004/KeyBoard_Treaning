
namespace vladik_kurs
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.button1 = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exampleTextArea = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.myText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "СТАРТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(7, 69);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(69, 13);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "Правильно: ";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Location = new System.Drawing.Point(7, 89);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(78, 13);
            this.lblWrong.TabIndex = 2;
            this.lblWrong.Text = "Неправильно:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Всего написано";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вводимый текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Исходный текст";
            // 
            // exampleTextArea
            // 
            this.exampleTextArea.Location = new System.Drawing.Point(174, 75);
            this.exampleTextArea.Name = "exampleTextArea";
            this.exampleTextArea.Size = new System.Drawing.Size(603, 307);
            this.exampleTextArea.TabIndex = 6;
            this.exampleTextArea.Text = "";
            this.exampleTextArea.TextChanged += new System.EventHandler(this.exampleTextArea_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "60",
            "120",
            "180"});
            this.comboBox1.Location = new System.Drawing.Point(13, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // myText
            // 
            this.myText.Location = new System.Drawing.Point(172, 401);
            this.myText.Name = "myText";
            this.myText.Size = new System.Drawing.Size(327, 20);
            this.myText.TabIndex = 8;
            this.myText.TextChanged += new System.EventHandler(this.myText_TextChanged);
            this.myText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myText_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(10, 349);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(92, 13);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "Выберите время";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "ВЕРНУТЬСЯ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.myText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exampleTextArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Уровень 1 \"Тренировка быстрой печати\"";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox exampleTextArea;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox myText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button button2;
    }
}