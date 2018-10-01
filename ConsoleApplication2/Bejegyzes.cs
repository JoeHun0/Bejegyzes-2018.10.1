using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok = 0;
        private DateTime letrejott =  DateTime.Now;
        private DateTime szerkesztve = DateTime.Now;

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
        }

        public string Tartalom
        {
            get
            {
                return tartalom;
            }

            set
            {
                tartalom = value;
                szerkesztve = DateTime.Now;
            }
        }

        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }
        }

        public DateTime Szerkesztve
        {
            get
            {
                return szerkesztve;
            }

            
        }
        public void like()
        {
            likeok++;
        }

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.Tartalom = tartalom;
        }
        public string kiir(){
            return szerzo + " - " + likeok + " - " + letrejott + "\r\n Szerkesztve: " + szerkesztve + "\r\n" + Tartalom ;
        }
    }
}
