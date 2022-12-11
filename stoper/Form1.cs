using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoper
{
    public partial class Form1 : Form
    {
        private int licznik = 0;
        private bool status = false;
        private int x = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Form1 okno = new Form1();
            licznik++;
            lbWyswietlacz.Text = Convert.ToString(licznik);
            pilka.Left += x;
            if (pilka.Left >=okno.Width - 40) x = -x;
            
            if (pilka.Left <= 5) x = -x;
        }

        private void lbWyswietlacz_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btStop.Text = "STOP";
            status = false;
            btStart.Enabled = false;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (status)
            {
                licznik = 0;
                lbWyswietlacz.Text = "0";
                status = false;
                x = 10;
                pilka.Left = 0;
            }
            else
            {
                btStop.Text = "RESET";
                status = true;
                btStart.Enabled= true;
            }
        }
    }
}
