using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIDA_FİRMASI_OTOMASYONU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double D_arpa = 0, D_buğday = 0, D_mısır = 0, D_bulgur = 0, D_yulaf = 0;
        double E_arpa = 0, E_buğday = 0, E_mısır = 0, E_bulgur = 0, E_yulaf = 0;
        double F_arpa = 0, F_buğday = 0, F_mısır = 0, F_bulgur = 0, F_yulaf = 0;
        double S_arpa = 0, S_buğday = 0, S_mısır = 0, S_bulgur = 0, S_yulaf = 0;
        string[] depo_bilgileri;
        string[] fiyat_bilgileri;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                F_arpa = F_arpa + (F_arpa * Convert.ToDouble(textBox6.Text) / 100);
                fiyat_bilgileri[0] = Convert.ToString(F_arpa);
            }
            catch (Exception)
            {

                textBox6.Text = "HATA!";
            }
            try
            {
                F_buğday = F_buğday + (F_buğday * Convert.ToDouble(textBox7.Text) / 100);
                fiyat_bilgileri[1] = Convert.ToString(F_buğday);
            }
            catch (Exception)
            {

                textBox7.Text = "HATA!";
            }
            try
            {
                F_mısır = F_mısır + (F_mısır * Convert.ToDouble(textBox8.Text) / 100);
                fiyat_bilgileri[2] = Convert.ToString(F_mısır);
            }
            catch (Exception)
            {

                textBox8.Text = "HATA!";
            }
            try
            {
                F_bulgur = F_bulgur + (F_bulgur * Convert.ToDouble(textBox9.Text) / 100);
                fiyat_bilgileri[3] = Convert.ToString(F_bulgur);
            }
            catch (Exception)
            {

                textBox9.Text = "HATA!";
            }
            try
            {
                F_yulaf = F_yulaf + (F_yulaf * Convert.ToDouble(textBox10.Text) / 100);
                fiyat_bilgileri[4] = Convert.ToString(F_yulaf);
            }
            catch (Exception)
            {

                textBox10.Text = "HATA!";
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", fiyat_bilgileri);
            txt_fiyat_oku();
            txt_fiyat_yaz();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ARPA")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "BUĞDAY")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "MISIR")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "BULGUR")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "YULAF")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }

            label29.Text = "________";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_arpa = double.Parse(numericUpDown1.Value.ToString());
            S_buğday = double.Parse(numericUpDown1.Value.ToString());
            S_mısır = double.Parse(numericUpDown1.Value.ToString());
            S_bulgur = double.Parse(numericUpDown1.Value.ToString());
            S_yulaf = double.Parse(numericUpDown1.Value.ToString());

            if (numericUpDown1.Enabled == true)
            {
                D_arpa = D_arpa - S_arpa;
                label29.Text = Convert.ToString(S_arpa * F_arpa);
            }
            else if (numericUpDown2.Enabled == true)
            {
                D_buğday = D_buğday - S_buğday;
                label29.Text = Convert.ToString(S_buğday * F_buğday);
            }
            else if (numericUpDown3.Enabled == true)
            {
                D_mısır = D_mısır - S_mısır;
                label29.Text = Convert.ToString(S_mısır * F_mısır);
            }
            else if (numericUpDown4.Enabled == true)
            {
                D_bulgur = D_bulgur - S_bulgur;
                label29.Text = Convert.ToString(S_bulgur * F_bulgur);
            }
            else if (numericUpDown5.Enabled == true)
            {
                D_yulaf = D_yulaf - S_yulaf;
                label29.Text = Convert.ToString(S_yulaf * F_yulaf);
            }

            depo_bilgileri[0] = Convert.ToString(D_arpa);
            depo_bilgileri[1] = Convert.ToString(D_buğday);
            depo_bilgileri[2] = Convert.ToString(D_mısır);
            depo_bilgileri[3] = Convert.ToString(D_bulgur);
            depo_bilgileri[4] = Convert.ToString(D_yulaf);
            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgileri);
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
            numericupdown_value();


            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            numericUpDown3.Text = "0";
            numericUpDown4.Text = "0";
            numericUpDown5.Text = "0";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                E_arpa = Convert.ToDouble(textBox1.Text);
                if (3000 < D_arpa + E_arpa || E_arpa <= 0)
                    textBox1.Text = "HATA!";
                else
                    depo_bilgileri[0] = Convert.ToString(D_arpa + E_arpa);
            }
            catch (Exception)
            {

                textBox1.Text = "HATA!";
            }
            try
            {
                E_buğday = Convert.ToDouble(textBox2.Text);
                if (3000 < D_buğday + E_buğday || E_buğday <= 0)
                    textBox2.Text = "HATA!";
                else
                    depo_bilgileri[1] = Convert.ToString(D_buğday + E_buğday);
            }
            catch (Exception)
            {

                textBox2.Text = "HATA!";
            }
            try
            {
                E_mısır = Convert.ToDouble(textBox3.Text);
                if (3000 < D_mısır + E_mısır || E_mısır <= 0)
                    textBox3.Text = "HATA!";
                else
                    depo_bilgileri[2] = Convert.ToString(D_mısır + E_mısır);
            }
            catch (Exception)
            {

                textBox3.Text = "HATA!";
            }
            try
            {
                E_bulgur = Convert.ToDouble(textBox4.Text);
                if (3000 < D_bulgur + E_bulgur || E_bulgur <= 0)
                    textBox4.Text = "HATA!";
                else
                    depo_bilgileri[3] = Convert.ToString(D_mısır + E_mısır);
            }
            catch (Exception)
            {

                textBox4.Text = "HATA!";
            }
            try
            {
                E_yulaf = Convert.ToDouble(textBox5.Text);
                if (3000 < D_yulaf + E_yulaf || E_yulaf <= 0)
                    textBox5.Text = "HATA!";
                else
                    depo_bilgileri[4] = Convert.ToString(D_yulaf + E_yulaf);
            }
            catch (Exception)
            {

                textBox5.Text = "HATA!";
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgileri);
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();

        }


        private void txt_depo_oku()
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\depo.txt");
            D_arpa = Convert.ToDouble(depo_bilgileri[0]);
            D_buğday = Convert.ToDouble(depo_bilgileri[1]);
            D_mısır = Convert.ToDouble(depo_bilgileri[2]);
            D_bulgur = Convert.ToDouble(depo_bilgileri[3]);
            D_yulaf = Convert.ToDouble(depo_bilgileri[4]);
        }
        private void txt_depo_yaz()
        {
            label6.Text = D_arpa.ToString("N");
            label7.Text = D_buğday.ToString("N");
            label8.Text = D_mısır.ToString("N");
            label9.Text = D_bulgur.ToString("N");
            label10.Text = D_yulaf.ToString("N");
        }
        private void txt_fiyat_oku()
        {
            fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\fiyat.txt");
            F_arpa = Convert.ToDouble(fiyat_bilgileri[0]);
            F_buğday = Convert.ToDouble(fiyat_bilgileri[1]);
            F_mısır = Convert.ToDouble(fiyat_bilgileri[2]);
            F_bulgur = Convert.ToDouble(fiyat_bilgileri[3]);
            F_yulaf = Convert.ToDouble(fiyat_bilgileri[4]);
        }
        private void txt_fiyat_yaz()
        {
            label16.Text = F_arpa.ToString("N");
            label17.Text = F_buğday.ToString("N");
            label18.Text = F_mısır.ToString("N");
            label19.Text = F_bulgur.ToString("N");
            label20.Text = F_yulaf.ToString("N");
        }

        private void progressBar_guncelle()
        {
            progressBar1.Value = Convert.ToInt32(D_arpa);
            progressBar2.Value = Convert.ToInt32(D_buğday);
            progressBar3.Value = Convert.ToInt32(D_mısır);
            progressBar4.Value = Convert.ToInt32(D_bulgur);
            progressBar5.Value = Convert.ToInt32(D_yulaf);
        }
        private void numericupdown_value()
        {
            numericUpDown1.Maximum = decimal.Parse(D_arpa.ToString());
            numericUpDown2.Maximum = decimal.Parse(D_buğday.ToString());
            numericUpDown3.Maximum = decimal.Parse(D_mısır.ToString());
            numericUpDown4.Maximum = decimal.Parse(D_bulgur.ToString());
            numericUpDown5.Maximum = decimal.Parse(D_yulaf.ToString());
        }

        
        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label29.Text = "________";
            progressBar1.Maximum = 3000;
            progressBar2.Maximum = 3000;
            progressBar3.Maximum = 3000;
            progressBar4.Maximum = 3000;
            progressBar5.Maximum = 3000;
            txt_depo_oku();
            txt_depo_yaz();
            txt_fiyat_oku();
            txt_fiyat_yaz();
            progressBar_guncelle();
            numericupdown_value();
          
            string[] tahil_turleri = { "ARPA", "BUĞDAY", "MISIR", "BULGUR", "YULAF" };
            comboBox1.Items.AddRange(tahil_turleri);
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;


        }
    }
}
