using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Doctor
    {
        string id;
        string fio;
        string spec;
        public Doctor(string fio,string spec)
        {
            this.fio = fio;
            this.spec = spec;
        }
        public Doctor(string id, string fio, string spec)
        {
            this.id = id;
            this.fio = fio;
            this.spec = spec;
        }
        public string Id { get => id; set => id = value; }
        public string Fio { get => fio; set => fio = value; }
        public string SPec { get => spec; set => spec = value; }
    }
}
