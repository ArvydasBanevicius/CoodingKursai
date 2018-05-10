using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izanga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x0d)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var atidarykKitaLanga = new Form2();
            atidarykKitaLanga.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var IvestiForma = new Form3())
            {
                IvestiForma.ShowDialog();
                if (IvestiForma.DialogResult == DialogResult.OK)
                {
                    textBox2.Text = IvestiForma.Tekstas;
                }
            }
        }
    }
}
