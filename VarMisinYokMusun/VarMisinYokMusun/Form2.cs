using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VarMisinYokMusun
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int teklif;
        public int kutu;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teblikler " + teklif + "kazandýnýz.");
            MessageBox.Show("Kutunuzda " + kutu + " TL vardý.");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Telifimiz " + teklif + "TL. Var mýsýn ? Yok musun?";
        }

    }
}