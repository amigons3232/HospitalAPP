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

       

        public Palata(string num, string size, string otdel)
        {
            this.num = num;
            this.size = size;
            this.otdel = otdel;
        }

        public string Id { get => id; set => id = value; }
        public string Num { get => num; set => num = value; }
           
        public string Size { get => size; set => size = value; }
        public string Otdel { get => otdel; set => otdel = value;}
    }
}
