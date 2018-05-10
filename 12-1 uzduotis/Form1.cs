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

namespace _12_1_uzduotis
{
    public partial class Form1 : Form
    {
        public string FiloVardas;
        public List<Automobilis> Automobiliai { get; set; } = new List<Automobilis>();

        public Form1()
        {
            InitializeComponent();
        }

        private void išeineamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                failas.InitialDirectory = "d:\\";
                failas.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
                failas.FilterIndex = 1;
                failas.RestoreDirectory = true;
                if (failas.ShowDialog() == DialogResult.OK)
                {
                    FiloVardas = failas.FileName;
                    try
                    {
                        var tekstas = File.ReadAllLines(failas.FileName);
                        foreach (var eilute in tekstas)
                        {
                            //MessageBox.Show(eilute);
                            Automobiliai.Add(new Automobilis(eilute));
                        }
                        dataGridView1.DataSource = Automobiliai;
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
