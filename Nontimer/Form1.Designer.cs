using System.Text.RegularExpressions;

namespace Nontimer
{
    partial class Sleep
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
            this.components = new System.ComponentModel.Container();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.okayButton = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.offTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(12, 27);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(159, 20);
            this.timeBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(96, 133);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.button1_Click);
            if (offTextBox.Text == string.Empty)
            {
                okayButton.Enabled = false;
            }

            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(13, 8);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(90, 13);
            this.currentLabel.TabIndex = 2;
            this.currentLabel.Text = "Текущее время:";
            // 
            // offLabel
            // 
            this.offLabel.AutoSize = true;
            this.offLabel.Location = new System.Drawing.Point(12, 65);
            this.offLabel.Name = "offLabel";
            this.offLabel.Size = new System.Drawing.Size(193, 13);
            this.offLabel.TabIndex = 3;
            this.offLabel.Text = "Через сколько часов выключить:";
            // 
            // offTextBox
            // 
            this.offTextBox.Location = new System.Drawing.Point(12, 81);
            this.offTextBox.Name = "offTextBox";
            this.offTextBox.Size = new System.Drawing.Size(193, 20);
            this.offTextBox.TabIndex = 4;
            this.offTextBox.TextChanged += offTextBox_TextChanged;

            // 
            // Sleep
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 159);
            this.Controls.Add(this.offTextBox);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.timeBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sleep";
            this.Text = "sleep baka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button okayButton;


        /*
         * Метод, который постоянно обновляет 
         * время в timeBox
         * */       
        private void timer1_tick(object sender, System.EventArgs e)
        {
            this.timeBox.Text = System.DateTime.Now.ToString();
        }


        /* Проверка валидности введенных данных
         * выключение компьютера по данным
         * */
        private void offTextBox_TextChanged(object sender, System.EventArgs e)
        {

            double time = 24.0;
            double bufTime = 0.0;
            System.Double.TryParse(offTextBox.Text, out bufTime);
            //TextBox tb = sender as TextBox;
            if (!off_regex.IsMatch(offTextBox.Text) | (bufTime > time))
            {
                offTextBox.Clear();
            }
           
            this.okayButton.Enabled = true;
            this.shutTime = bufTime;
        
        }

        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.TextBox offTextBox;
        private double shutTime;

        Regex off_regex = new Regex("\\d{1,2}");
    }

}

