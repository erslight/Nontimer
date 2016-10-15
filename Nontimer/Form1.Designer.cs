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
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(12, 27);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(159, 20);
            this.timeBox.TabIndex = 0;



            //
            // Timer in TextBox
            //
            timer1.Tick += new System.EventHandler(timer1_tick);
            timer1.Interval = 100;
            timer1.Start(); 
            
             
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(12, 69);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sleep
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 125);
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
    }

}

