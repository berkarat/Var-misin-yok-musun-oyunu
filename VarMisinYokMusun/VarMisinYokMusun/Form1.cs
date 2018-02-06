using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace VarMisinYokMusun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[] arr = new int[24];
        constructionClass degerler = new constructionClass(0, 0, 0);
        public bool KutuSec = true;
        //public int SecilenKutu = 0;
        //public int StateCounter = 0;
        //public int StateCounterLimit = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            arr = asd.KutuAta();  //Kutulara random olarak kazanýlacak deðerler atanýyor.
            MessageBox.Show("Kutunuzu Seçiniz");
        }

        private void ButtonClick(object sender, EventArgs e)
        {

            Button b = new Button();
            b = (Button)sender;
            string secilenad = b.Name.Replace("btn", "");
            int secilensayi = Convert.ToInt32(secilenad);
            if (KutuSec == true)
            {
                degerler.SecilenKutu = secilensayi;
                KutuSec = false;
                b.Enabled = false;

                //Label lb = (Label)(this.Controls.Find("lbl" + arr[secilensayi - 1], false)[0]);
                //lb.ForeColor = Color.Red;
                State(8);
                return;
            }
            b.Enabled = false;
            MessageBox.Show("Seçilen kutuda " + arr[secilensayi - 1] + " TL var");

            degerler.StateCounter++;
            Label lb_ = (Label)(this.Controls.Find("lbl" + arr[secilensayi - 1], false)[0]);
            lb_.BackColor = Color.Red;
            arr[secilensayi - 1] = 0;
            if (degerler.StateCounterLimit == degerler.StateCounter)
            {
                Form2 f = new Form2();
                f.kutu = arr[degerler.SecilenKutu - 1];
                f.teklif = asd.TeklifVer(arr);
                f.ShowDialog();
                degerler.StateCounter = 0;
                if (degerler.StateCounterLimit == 1)
                    FinalState();
                if (degerler.StateCounterLimit == 6)
                    State(1);
                if (degerler.StateCounterLimit == 7)
                    State(6);
                if (degerler.StateCounterLimit == 8)
                    State(7);
            }
            this.Text = "Var Mýsýn Yok Musun ?" + "       teklife kalan kutu sayýsý = " + (degerler.StateCounterLimit - degerler.StateCounter);
        }
        public void State(int a)
        {
            //MessageBox.Show("Ýlk teklif için "+a+" kutu seçiniz");
            degerler.StateCounterLimit = a;
        }

        public void FinalState()
        {
            MessageBox.Show(arr[degerler.SecilenKutu - 1] + "TL kazandýnýz");
            this.Close();
        }
    }
}