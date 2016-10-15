using System;
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
            this.offHourLabel = new System.Windows.Forms.Label();
            this.offHourTextBox = new System.Windows.Forms.TextBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.offMinuteTextBox = new System.Windows.Forms.TextBox();
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
            this.okayButton.Enabled = false;
            this.okayButton.Location = new System.Drawing.Point(96, 133);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.button1_Click);
            this.okayButton.Enabled = false;
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
            // offHourLabel
            // 
            this.offHourLabel.AutoSize = true;
            this.offHourLabel.Location = new System.Drawing.Point(9, 91);
            this.offHourLabel.Name = "offHourLabel";
            this.offHourLabel.Size = new System.Drawing.Size(38, 13);
            this.offHourLabel.TabIndex = 3;
            this.offHourLabel.Text = "Часы:";
            // 
            // offHourTextBox
            // 
            this.offHourTextBox.Location = new System.Drawing.Point(12, 107);
            this.offHourTextBox.Name = "offHourTextBox";
            this.offHourTextBox.Size = new System.Drawing.Size(42, 20);
            this.offHourTextBox.TabIndex = 4;
            this.offHourTextBox.TextChanged += offHourTextBox_TextChanged;
            
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(12, 54);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(131, 13);
            this.settingsLabel.TabIndex = 5;
            this.settingsLabel.Text = "Настройки выключения:";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(74, 91);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(49, 13);
            this.minuteLabel.TabIndex = 6;
            this.minuteLabel.Text = "Минуты:";
            // 
            // offMinuteTextBox
            // 
            this.offMinuteTextBox.Location = new System.Drawing.Point(77, 106);
            this.offMinuteTextBox.Name = "offMinuteTextBox";
            this.offMinuteTextBox.Size = new System.Drawing.Size(46, 20);
            this.offMinuteTextBox.TabIndex = 7;
            this.offMinuteTextBox.TextChanged += offMinuteTextChanged;
            // 
            // Sleep
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 159);
            this.Controls.Add(this.offMinuteTextBox);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.offHourTextBox);
            this.Controls.Add(this.offHourLabel);
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


        /* часовое поле
         * Проверка валидности введенных данных
         * выключение компьютера по данным
         * */
        private void offHourTextBox_TextChanged(object sender, System.EventArgs e)
        {       
            double time = 24.0;
            double bufTime = 0.0;
            System.Double.TryParse(offHourTextBox.Text, out bufTime);
            if (!off_regex.IsMatch(offHourTextBox.Text) | (bufTime > time))
            {
                offHourTextBox.Clear();
            }
           
            this.okayButton.Enabled = true;
            this.shutHours = bufTime;
            checkButton();

        }

        /* минутное поле
         * */
        private void offMinuteTextChanged(object sender, EventArgs e)
        {
            double time = 60.0;
            double bufTime = 0.0;
            System.Double.TryParse(offMinuteTextBox.Text, out bufTime);
            if (!off_regex.IsMatch(offMinuteTextBox.Text) | (bufTime > time))
            {
                offMinuteTextBox.Clear();
            }

            this.okayButton.Enabled = true;
            this.shutMinutes = bufTime;
            checkButton();
        }

        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label offHourLabel;
        private System.Windows.Forms.TextBox offHourTextBox;
        private double shutHours;
        private double shutMinutes;

        Regex off_regex = new Regex("\\d{1,2}");
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.TextBox offMinuteTextBox;

        private void checkButton()
        {
            if ((offHourTextBox.Text == string.Empty) && (offMinuteTextBox.Text == string.Empty))
            {
                okayButton.Enabled = false;
            }
        }
    }

}

