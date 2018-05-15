using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_5_uzduotis
{
    static class Rasymas_i_faila
    {
        public static void ExportGridData(DataGridView dataGridView, ref string[] Rezultatas)
        {
            for (int j = 0; j < dataGridView.RowCount; j++)
            {
                string Eilute = "";
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    Eilute += dataGridView.Rows[j].Cells[i].Value + ";";
                }
                Rezultatas[j] = Eilute;
            }
        }

        public static void IrasytiIFaila(string FailoVardas, string[] Tekstas)
        {
            try
            {
                File.WriteAllLines(FailoVardas, Tekstas);
            }
            catch (Exception)
            {
                MessageBox.Show("Kazkas negerai");
            }
        }

        public static void SkaitytiIsFaila(string FailoVardas, ref string[] Tekstas)
        {
            try
            {
                Tekstas = File.ReadAllLines(FailoVardas);
            }
            catch (Exception)
            {
                MessageBox.Show("Kazkas negerai");
            }
        }

    }
}
