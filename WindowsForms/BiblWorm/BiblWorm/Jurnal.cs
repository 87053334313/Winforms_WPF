using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblWorm
{
    public class Jurnal
    {
        public string Author;
        public string Name;
        public string Izd;
        public int str;
        public int god;
        public int srok;
        public Jurnal(string Author, string Name, string Izd, int str, int god, int srok)
        {
            this.Author = Author;
            this.Name = Name;
            this.Izd = Izd;
            this.str = str;
            this.god = god;
            this.srok = srok;
        }
        public string DateStr()
        {
            string str= "Author=" + Author +"\n";
            string name_1 = "Name=" + Name + "\n";
            string izd_str = "Izdatelstvo =" + Izd + "\n";
            string god_str = "god " + god + "\n";
            string srok_str = "srok = " + srok + "\n";
            string RetStr = str + name_1 + izd_str + god_str + srok_str;
            return RetStr;
            
        }
        public Jurnal()
        {
           
        }
    }
}
