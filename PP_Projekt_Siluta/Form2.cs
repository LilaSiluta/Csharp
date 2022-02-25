using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Projekt_Siluta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Przypisanie wykresowi danych z pliku txt

                if (Form1.checkBox1.Checked == true)
                {
                    chart1.Series[0].Points.AddXY("0-1", Form1.ilość[0]);
                }
                if (Form1.checkBox2.Checked == true)
                {
                    chart1.Series[0].Points.AddXY("1-2", Form1.ilość[1]);
                }
                if (Form1.checkBox3.Checked == true)
                {
                    chart1.Series[0].Points.AddXY("2-3", Form1.ilość[2]);
                }
                if (Form1.checkBox4.Checked == true)
                {
                    chart1.Series[0].Points.AddXY("3-4", Form1.ilość[3]);
                }
                if (Form1.checkBox5.Checked == true)
                {
                    chart1.Series[0].Points.AddXY("4-5", Form1.ilość[4]);
                }

            // Zmiana koloru słupków
            if (Form1.radioButton3.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(225, 128, 255);
            }
            if (Form1.radioButton4.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(65, 140, 240);
            }
            if (Form1.radioButton5.Checked == true)
            {
                chart1.Series[0].Color = Color.FromArgb(118, 32, 123);
            }

            //Zmiana koloru tła
            if (Form1.radioButton8.Checked == true)
            {
                BackColor = Color.FromArgb(192, 192, 255);
            }
            if (Form1.radioButton7.Checked == true)
            {
                BackColor = Color.FromArgb(213, 245, 236);
            }
            if (Form1.radioButton6.Checked == true)
            {
                BackColor = Color.FromArgb(Form1.kolorTła);
            }

            //Czy ma być wyświetlana legenda?
            if (Form1.radioButton9.Checked == true)
            {
                chart1.Legends[0].Enabled = true;
                chart1.ChartAreas[0].AxisX.Title = "Przedział ocen";
                chart1.ChartAreas[0].AxisY.Title = "Ilość ocen";
            }
            if (Form1.radioButton10.Checked == true)
            {
                chart1.Legends[0].Enabled = false;
                chart1.ChartAreas[0].AxisX.Title = "";
                chart1.ChartAreas[0].AxisY.Title = "";

            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno chcesz zamknąć okno?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
