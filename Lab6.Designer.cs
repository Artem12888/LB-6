﻿namespace Lab6
{
    partial class Lab6
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
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowTime = new System.Windows.Forms.Button();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.Color.White;
            this.txtSeconds.ForeColor = System.Drawing.Color.Black;
            this.txtSeconds.Location = new System.Drawing.Point(95, 11);
            this.txtSeconds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(104, 20);
            this.txtSeconds.TabIndex = 0;
            this.txtSeconds.Text = "0";
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.White;
            this.txtMinutes.ForeColor = System.Drawing.Color.Black;
            this.txtMinutes.Location = new System.Drawing.Point(95, 54);
            this.txtMinutes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(104, 20);
            this.txtMinutes.TabIndex = 1;
            this.txtMinutes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "мин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "сек";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(138, 93);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(67, 93);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(61, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShowTime
            // 
            this.btnShowTime.Location = new System.Drawing.Point(271, 121);
            this.btnShowTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowTime.Name = "btnShowTime";
            this.btnShowTime.Size = new System.Drawing.Size(102, 28);
            this.btnShowTime.TabIndex = 7;
            this.btnShowTime.Text = "Tекущее время";
            this.btnShowTime.UseVisualStyleBackColor = true;
            this.btnShowTime.Click += new System.EventHandler(this.btnShowTime_Click);
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.White;
            this.txtCurrentTime.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentTime.Location = new System.Drawing.Point(237, 82);
            this.txtCurrentTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.Size = new System.Drawing.Size(136, 20);
            this.txtCurrentTime.TabIndex = 6;
            // 
            // Lab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.btnShowTime);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtSeconds);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab6";
            this.Text = "frmTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowTime;
        private System.Windows.Forms.TextBox txtCurrentTime;
    }
}

