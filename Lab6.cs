using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, System.EventArgs e)
        {
            // Преобразуем текст в число
            int sec = int.Parse(txtSeconds.Text);
            int min = int.Parse(txtMinutes.Text);

            // Увеличиваем секунды
            sec++;

            // Если секунд стало 60, увеличиваем минуты
            if (sec == 60)
            {
                sec = 0;
                min++;
            }

            // Обновляем текстовые поля
            txtSeconds.Text = sec.ToString();
            txtMinutes.Text = min.ToString();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            // Переключаем состояние таймера
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;

            // Меняем текст кнопки
            if (tmrSecundomer.Enabled)
            {
                btnStart.Text = "Пауза";
            }
            else
            {
                btnStart.Text = "Старт";
            }

        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            // Останавливаем таймер и сбрасываем время
            tmrSecundomer.Enabled = false;
            btnStart.Text = "Старт";
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }

        private void btnShowTime_Click(object sender, System.EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
