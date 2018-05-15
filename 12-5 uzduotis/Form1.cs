using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_5_uzduotis
{
    public partial class Form1 : Form
    {
        private const int StulpeliuSkaicius = 20;
        private const int EiluciuSkaicius = 200;

        Random rnd = new Random();
        int[,] PirmasSkaiciuMasyvas;
        int[,] AntrasSkaiciuMasyvas;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = StulpeliuSkaicius;
            dataGridView1.RowCount = EiluciuSkaicius;

            dataGridView2.ColumnCount = StulpeliuSkaicius;
            dataGridView2.RowCount = EiluciuSkaicius;

            PirmasSkaiciuMasyvas = new int[dataGridView1.ColumnCount, dataGridView1.RowCount];
            AntrasSkaiciuMasyvas = new int[dataGridView2.ColumnCount, dataGridView2.RowCount];

            for (int i=0; i< dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Name = "Stulpelis " + (i+1);
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView2.Columns[i].Name = "Stulpelis " + (i + 1);
            }

            SkaiciuotiAtsitiktiniusSkaicius(ref PirmasSkaiciuMasyvas);
            SkaiciuotiAtsitiktiniusSkaicius(ref AntrasSkaiciuMasyvas);

            PildytiGrida(ref PirmasSkaiciuMasyvas, dataGridView1);
            PildytiGrida(ref AntrasSkaiciuMasyvas, dataGridView2);
        }

        private void SkaiciuotiAtsitiktiniusSkaicius(ref int[,] Masyvas)
        {
            for (int i = 0; i < StulpeliuSkaicius; i++)
            {
                for (int j = 0; j < EiluciuSkaicius; j++)
                {
                    Masyvas[i, j] = rnd.Next(10000);
                }
            }
        }

        private void PildytiGrida(ref int[,] Masyvas, DataGridView dataGridView)
        {
            for (int i = 0; i < StulpeliuSkaicius; i++)
            {
                for (int j = 0; j < EiluciuSkaicius; j++)
                {
                    try
                    {
                        dataGridView.Rows[j].Cells[i].Value = Masyvas[i, j];
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var failas = new SaveFileDialog())
            {
                failas.Title = "Irasyti failą vardu";
                failas.InitialDirectory = "d:\\";
                failas.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
                failas.FilterIndex = 1;
                failas.FileName = tabControl1.SelectedTab.Text;
                failas.RestoreDirectory = true;
                if (failas.ShowDialog() == DialogResult.OK)
                {
                    DataGridView DG;
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            DG = dataGridView1;
                            break;
                        case 1:
                            DG = dataGridView2;
                            break;
                        default: return;
                    }
                    string[] Tekstas = new string[EiluciuSkaicius];
                    Rasymas_i_faila.ExportGridData(DG, ref Tekstas);
                    Rasymas_i_faila.IrasytiIFaila(failas.FileName, Tekstas);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                failas.Title = "Nuskaityti failą vardu";
                failas.InitialDirectory = "d:\\";
                failas.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
                failas.FilterIndex = 1;
                failas.RestoreDirectory = true;
                if (failas.ShowDialog() == DialogResult.OK)
                {
                    DataGridView DG;
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            DG = dataGridView1;
                            break;
                        case 1:
                            DG = dataGridView2;
                            break;
                        default: return;
                    }
                    string[] Tekstas = new string[EiluciuSkaicius];
                    Rasymas_i_faila.SkaitytiIsFaila(failas.FileName, ref Tekstas);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView DG;
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        DG = dataGridView1;
                        break;
                    case 1:
                        DG = dataGridView2;
                        break;
                    default: return;
                }
                while (DG.RowCount > 0)
                {
                    DG.Rows.RemoveAt(0);
                }
            }
            catch (Exception)
            {
            }
        }
    }

}
