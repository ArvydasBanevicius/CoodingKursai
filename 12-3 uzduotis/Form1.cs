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
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            dataGridView1.Columns[0].Name = "M";
            dataGridView1.Columns[1].Name = "J";
            dataGridView1.Columns[2].Name = "R";
            dataGridView1.Columns[3].Name = "G";
            dataGridView1.Columns[4].Name = "Z";
            NaujasZaidimas();
        }

        private void SkaiciuojaSpalva(ref int[,] Masyvas, int Idx)
        {
            int i = 0;
            while (i < 5)
            {
                Pakartoti:
                Masyvas[i, Idx] = rnd.Next((Idx * 15) + 1, (Idx * 15) + 15);
                int j = 0;
                while (j < i)
                {
                    if (Masyvas[j, Idx] == Masyvas[i, Idx]) goto Pakartoti;
                    j++;
                }
                i++;
            }
        }

        private void NaujasZaidimas()
        {
            int[,] ZaidimoSkaiciai = new int[5, 5];
            SkaiciuojaSpalva(ref ZaidimoSkaiciai, 0);
            SkaiciuojaSpalva(ref ZaidimoSkaiciai, 1);
            SkaiciuojaSpalva(ref ZaidimoSkaiciai, 2);
            SkaiciuojaSpalva(ref ZaidimoSkaiciai, 3);
            SkaiciuojaSpalva(ref ZaidimoSkaiciai, 4);
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = ZaidimoSkaiciai[i, 0];
                dataGridView1.Rows[i].Cells[1].Value = ZaidimoSkaiciai[i, 1];
                dataGridView1.Rows[i].Cells[2].Value = ZaidimoSkaiciai[i, 2];
                dataGridView1.Rows[i].Cells[3].Value = ZaidimoSkaiciai[i, 3];
                dataGridView1.Rows[i].Cells[4].Value = ZaidimoSkaiciai[i, 4];
            }
            dataGridView1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NaujasZaidimas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkaiciuojaSpalva(ref ZaidziantysSkaiciai, 0);
            SkaiciuojaSpalva(ref ZaidziantysSkaiciai, 1);
            SkaiciuojaSpalva(ref ZaidziantysSkaiciai, 2);
            SkaiciuojaSpalva(ref ZaidziantysSkaiciai, 3);
            SkaiciuojaSpalva(ref ZaidziantysSkaiciai, 4);
            dataGridView1.Invalidate();
        }


        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex >= 0)&&(e.RowIndex >= 0)&&(Convert.ToInt32(e.Value) == ZaidziantysSkaiciai[e.ColumnIndex, e.RowIndex]))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kazkas negerai");
            }
        }

    }
}
