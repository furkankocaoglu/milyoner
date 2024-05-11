using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gelismissinav
{
    internal class soru
    {
        public string SoruMetni { get; set; }
        
        public string[] Secenekler { get; set; }
        public char DogruSecenek { get; set; }

        public soru(string soruMetni, string[] secenekler, char dogruSecenek)
        {
            SoruMetni = soruMetni;
            Secenekler = secenekler;
            DogruSecenek = dogruSecenek;
        }

        public bool CevapKontrol(char secilenSecenek)
        {
            return char.ToUpper(secilenSecenek) == DogruSecenek;
        }
    }
}

