using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_3_uzduotis
{
    public partial class Form1 : Form
    {

        int[,] ZaidziantysSkaiciai = new int[5, 5];
        public int M, J, R, G, Z;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add("", "", "", "", "");
            }
        }


        private void NaujasZaidimas()
        {
            for (int i = 0; i < 5; i++)
            {
                M = rnd.Next(1, 15);
                J = rnd.Next(16, 30);
                R = rnd.Next(31, 45);
                G = rnd.Next(46, 60);
                Z = rnd.Next(61, 75);
//                dataGridView1.CellRows.Add(M, J, R, G, Z);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        //    e.ColumnIndex
        }
    }
}
