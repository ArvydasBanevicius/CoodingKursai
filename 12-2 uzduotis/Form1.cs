using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace _12_2_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // https://www.amazon.co.uk/gp/search/ref=sr_il_ti_computers?fst=as%3Aon&rh=k%3Alaptop%2Cn%3A340831031%2Cn%3A429886031&keywords=laptop&ie=UTF8&qid=1526316124&lo=computers

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            textBox1.Text = "";
            GautiHTML(url);
        }

        private static async void GautiHTML(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocoment = new HtmlAgilityPack.HtmlDocument();
            htmlDocoment.LoadHtml(html);
            var produktuSarasas = htmlDocoment.DocumentNode.Descendants("ul")
                .Where(x => x.GetAttributeValue("id", "")
                .Equals("s-results-list-atf")).ToList();

            var produktuElementai = produktuSarasas[0].Descendants("li")
                .Where(x => x.GetAttributeValue("id", "")
                .Contains("result")).ToList();


            for (int i=0; i<produktuElementai.Count; i++)
            {
            }

            foreach (var htmlNode in produktuElementai)
            {
                MessageBox.Show(htmlNode.InnerText);
            }
        }
    }
}
