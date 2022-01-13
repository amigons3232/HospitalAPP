using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicHospital
{
 
    public class Palata
    {
        string id;
        string num;
        string size;
        string otdel;

        public Palata(string id, string num, string size, string otdel)
        {
            this.id = id;
            this.num = num;
            this.size = size;
            this.otdel = otdel;
        }

        public Palata(string num, string size, string otdel)
        {
            this.num = num;
            this.size = size;
            this.otdel = otdel;
        }

        
    }
}
