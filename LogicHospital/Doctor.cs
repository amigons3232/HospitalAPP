using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicHospital
{
    public class Doctor : InterfacePeople
    {
        string id;
        string fio;
        string spec;
        public Doctor(string fio, string spec)
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
        public string Id()
        {
            return id;
        }

        public string Fio()
        {
            return fio;
        }

        public void setFio(string fio)
        {
            this.fio = fio;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string SPec { get => spec; set => spec = value; }
    }
}
