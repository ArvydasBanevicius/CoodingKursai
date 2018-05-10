using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Preke> Prekes = new List<Preke>();
        public Form1()
        {
            InitializeComponent();
        }

        private void baigtiDarbąSuProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiPrekiųSąrašąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Failas = new OpenFileDialog())
            { 
                Failas.DefaultExt = "*.csv";
                Failas.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
                Failas.FilterIndex = 1;
                if (Failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var PrekiuSarasas = File.ReadAllLines(Failas.FileName);
                        foreach (var eilute in PrekiuSarasas)
                        {
                            Prekes.Add(new Preke(eilute));
                        }
                        dataGridView1.DataSource = Prekes;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kazkas negerai");
                    }
                }
            }
        }
    }
}
