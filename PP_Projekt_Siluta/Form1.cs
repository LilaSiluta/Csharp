using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PP_Projekt_Siluta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int kolorTła;
        public static int[] ilość = new int[5];
        string rozdzieloneDane;

        private void pictureBox_Bar_Click(object sender, EventArgs e)
        {

        }

        private void label_ocenaKinderCountry_Click(object sender, EventArgs e)
        {

        }

        private void label_produktFirmyKinder_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno chcesz zamknąć okno?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void button_otwórzPlikTxt_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            textBox_opinie.Visible = true;
            OpenFileDialog oceny = new OpenFileDialog();
            oceny.Filter = "Notatnik|*.txt";
            if (oceny.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_opinie.Text = File.ReadAllText(oceny.FileName);
            }
            label11.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            string[] ocenyString = new string[80];
            double[] ocenyDouble = new double[80];
            int i;
            try
            {
                ocenyString = File.ReadAllLines(oceny.FileName);
                for (i = 0; i < 80; i++)
                {
                    ocenyDouble[i] = Double.Parse(ocenyString[i]);
                }
                for( i = 0; i < 80; i++)
                {
                    if (ocenyDouble[i] >= 0 && ocenyDouble[i] <= 1)
                    {
                        ilość[0] += 1;
                    }
                    if (ocenyDouble[i] > 1 && ocenyDouble[i] <= 2)
                    {
                        ilość[1] += 1;
                    }
                    if (ocenyDouble[i] > 2 && ocenyDouble[i] <= 3)
                    {
                        ilość[2] += 1;
                    }
                    if (ocenyDouble[i] > 3 && ocenyDouble[i] <= 4)
                    {
                        ilość[3] += 1;
                    }
                    if (ocenyDouble[i] > 4 && ocenyDouble[i] <= 5)
                    {
                        ilość[4] += 1;
                    }
                }
            }
            catch
            {
                for (i = 0; i <5; i++)
                {
                    ilość[i] = 0;
                }
                MessageBox.Show("Błąd! Spróbuj jeszcze raz.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label10.Text = "" + ilość[0];
            label9.Text = "" + ilość[1];
            label8.Text = "" + ilość[2];
            label7.Text = "" + ilość[3];
            label6.Text = "" + ilość[4];
            rozdzieloneDane = "Oceny produtu z podziałem na poszczególne przedziały: \n --> (0-1):" + ilość[0] + "\n --> (1-2):" + ilość[1] +
                "\n --> (2-3):" + ilość[2] + "\n --> (3-4):" + ilość[3] + "\n --> (4-5):" + ilość[4];
        }
        private void groupBox_opinieKonsumentów_Enter(object sender, EventArgs e)
        {
            ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button_otwórzPlikTxt.Enabled = true;
            if(radioButton1.Checked==true)
            {
                MessageBox.Show("Za pomocą przycisku 'Otwórz' możesz zobaczyć opinie klientów.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button_otwórzPlikTxt.Enabled = false;
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Wybierając 'NIE' rezygnujesz z podglądu w opinie o produkcie. \nW reultacie nie stworzysz wykresu. Czy jesteś pewien tej operacji?", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
            }
            else
            {
                if (radioButton11.Checked == true)
                {
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    checkBox5.Visible = false;
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox4.Checked = true;
                    checkBox5.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked
               == true) && (radioButton6.Checked == true || radioButton7.Checked == true || radioButton8.Checked == true)
               && (radioButton9.Checked == true || radioButton10.Checked == true)
               && (radioButton12.Checked == true || radioButton11.Checked == true) && (checkBox1.Checked == true || checkBox2.Checked == true
               || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true))
            {
                Form2 generowanyWykres = new Form2();
                generowanyWykres.ShowDialog();
            }
            else
            {
                MessageBox.Show("UPS! Czegoś nie zaznaczyłeś. \n Spróbuj jeszcze raz!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                if ( colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    kolorTła = colorDialog1.Color.ToArgb();
                }
            }
        }

        // Zapisanie pliku z danymi jako txt
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog zapisDanych = new SaveFileDialog();
            zapisDanych.Filter = "Plik tekstowy|*.txt";
            if (zapisDanych.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BinaryWriter zapisywacz = new BinaryWriter(File.Create(zapisDanych.FileName));
                zapisywacz.Write(rozdzieloneDane);
                zapisywacz.Dispose();
                MessageBox.Show("Plik został zapisany! ", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
