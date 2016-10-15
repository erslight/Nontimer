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
            this.radioButtonThrough = new System.Windows.Forms.RadioButton();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.offtextBoxIn = new System.Windows.Forms.TextBox();
            this.offlabelIn = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.okayButton.Location = new System.Drawing.Point(96, 144);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.button1_Click);
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
            this.offHourLabel.Location = new System.Drawing.Point(9, 102);
            this.offHourLabel.Name = "offHourLabel";
            this.offHourLabel.Size = new System.Drawing.Size(38, 13);
            this.offHourLabel.TabIndex = 3;
            this.offHourLabel.Text = "Часы:";
            // 
            // offHourTextBox
            // 
            this.offHourTextBox.Location = new System.Drawing.Point(12, 118);
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
            this.minuteLabel.Location = new System.Drawing.Point(74, 102);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(49, 13);
            this.minuteLabel.TabIndex = 6;
            this.minuteLabel.Text = "Минуты:";
            // 
            // offMinuteTextBox
            // 
            this.offMinuteTextBox.Location = new System.Drawing.Point(77, 118);
            this.offMinuteTextBox.Name = "offMinuteTextBox";
            this.offMinuteTextBox.Size = new System.Drawing.Size(46, 20);
            this.offMinuteTextBox.TabIndex = 7;
            this.offMinuteTextBox.TextChanged += offMinuteTextChanged;
            // 
            // radioButtonThrough
            // 
            this.radioButtonThrough.AutoSize = true;
            this.radioButtonThrough.Location = new System.Drawing.Point(12, 71);
            this.radioButtonThrough.Name = "radioButtonThrough";
            this.radioButtonThrough.Size = new System.Drawing.Size(60, 17);
            this.radioButtonThrough.TabIndex = 8;
            this.radioButtonThrough.TabStop = true;
            this.radioButtonThrough.Text = "Через:";
            this.radioButtonThrough.UseVisualStyleBackColor = true;
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(173, 71);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(35, 17);
            this.radioButtonIn.TabIndex = 9;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "В:";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            // 
            // offtextBoxIn
            // 
            this.offtextBoxIn.Location = new System.Drawing.Point(173, 118);
            this.offtextBoxIn.Name = "offtextBoxIn";
            this.offtextBoxIn.Size = new System.Drawing.Size(140, 20);
            this.offtextBoxIn.TabIndex = 10;
            // 
            // offlabelIn
            // 
            this.offlabelIn.AutoSize = true;
            this.offlabelIn.Location = new System.Drawing.Point(173, 102);
            this.offlabelIn.Name = "offlabelIn";
            this.offlabelIn.Size = new System.Drawing.Size(76, 13);
            this.offlabelIn.TabIndex = 11;
            this.offlabelIn.Text = "Выключить в:";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(217, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Enabled = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sleep
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 179);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.offlabelIn);
            this.Controls.Add(this.offtextBoxIn);
            this.Controls.Add(this.radioButtonIn);
            this.Controls.Add(this.radioButtonThrough);
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


        /*
         * Метод, который постоянно обновляет 
         * время в timeBox
         * */
        private void timer1_tick(object sender, System.EventArgs e)
        {
            this.timeBox.Text = System.DateTime.Now.ToString();
            radioCheck();
            
        }       


        /*
         * проверка состяния radiobutton-ов
         * */
        private void radioCheck()
        {
            if (!this.radioButtonThrough.Checked)
            {
                this.offMinuteTextBox.Enabled = false;
                this.offHourTextBox.Enabled = false;
                
            }
            else
            {
                this.offMinuteTextBox.Enabled = true;
                this.offHourTextBox.Enabled = true;
                this.offIn = false;
                this.chbEn = true;
                checkButton();
            }
            if (!this.radioButtonIn.Checked)
            {
                this.offtextBoxIn.Enabled = false;
            }
            else
            {
                this.offtextBoxIn.Enabled = true;
                this.offIn = true;
                this.chbEn = true;
                this.okayButton.Enabled = true;
                           
            }

          
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


        private void OfftextBoxIn_TextChanged(object sender, EventArgs e)
        {
            Cut(offtextBoxIn.Text);
        }

        /* проверка состояния кнопки ОК
         * */
        private void checkButton()
        {
            if ((offHourTextBox.Text == string.Empty) && (offMinuteTextBox.Text == string.Empty))
            {
                okayButton.Enabled = false;
            }
        }
        /*вычленение из второго текстбокса
         * часов и минут */
        private void Cut(string text)
        {
            string hours = text.Substring(text.IndexOf(':'));
            string mins = text.Substring(text.LastIndexOf(':') + 1);
            double h; Double.TryParse(hours, out h); shutInHours = System.Convert.ToInt32(h);
            double m; Double.TryParse(mins, out m); shutInMins = System.Convert.ToInt32(m); 
            double overallTime = h * 3600 + m * 60;
            this.overallInTime = overallTime;
        }


        /* выключение компьютера через н секунд */
        private void shutdown (double seconds)
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t " + seconds);
        }

        private void cancel_shutdown()
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown /a");
        }

        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Timer timer1; //timeBox
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label offHourLabel;
        private System.Windows.Forms.TextBox offHourTextBox;
        private double shutHours;
        private double shutMinutes;
        private Regex off_regex = new Regex("\\d{1,2}");
        private Regex offin_regex = new Regex("\\d[:]{,5}");
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.TextBox offMinuteTextBox;
        private System.Windows.Forms.RadioButton radioButtonThrough;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.TextBox offtextBoxIn;
        private System.Windows.Forms.Label offlabelIn;
        private System.Windows.Forms.Timer timer3;
        private int shutInHours;
        private int shutInMins;
        private double overallInTime;
        private bool chbEn = false;
        private bool offIn = false;
        private System.Windows.Forms.Button cancelButton;
    }

}

