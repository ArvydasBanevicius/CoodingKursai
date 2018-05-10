using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzduotis
{
    class Kompiuteris
    {
        public string Vaizduske { get; private set; }
        public string Motinine { get; private set; }
        public int DiskoTalpa { get; private set; }

        public Kompiuteris(string vaizduske, string motinine, int diskotalpa)
        {
            Vaizduske = vaizduske;
            Motinine = motinine;
            DiskoTalpa = diskotalpa;
        }

        public Kompiuteris()
        {
                
        }

        public string GetVaistuske()
        {
            return Vaizduske;
        }

        private void SetVaiduske(string vaizd )
        {
            Vaizduske = vaizd;
        }

        public void Isvedimas( string Tekstas )
        {
            SetVaiduske(Tekstas);
        }
    }
}
