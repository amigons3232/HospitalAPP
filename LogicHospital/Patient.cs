using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicHospital
{
    public class Patient : InterfacePeople
    {
        string id;
        string fio;
        string idPalata;
        string idDoctor;
        string DateIn;
        string diagnoz;
        string DateOut;

        public Patient(string id, string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut)
        {
            this.id = id;
            this.fio = fio;
            iDpalata = idPalata;
            IDdoctor = idDoctor;
            dateIn = DateIn;
            Diagnoz = diagnoz;
            dateOut = DateOut;

        }

        public Patient(string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut)
        {
            this.fio = fio;
            iDpalata = idPalata;
            IDdoctor = idDoctor;
            dateIn = DateIn;
            Diagnoz = diagnoz;
            dateOut = DateOut;
        }

        public string iDpalata { get => idPalata; set => idPalata = value; }
        public string IDdoctor { get => idDoctor; set => idDoctor = value; }
        public string dateIn { get => DateIn; set => DateIn = value; }
        public string Diagnoz { get => diagnoz; set => diagnoz = value; }
        public string dateOut { get => DateOut; set => DateOut = value; }
        public string Fio()
        {
            return fio;
        }

        public string Id()
        {
            return id;
        }

        public void setFio(string fio)
        {
            this.fio = fio;
        }

        public void setId(string id)
        {
            this.id = id;
        }
    }
}
