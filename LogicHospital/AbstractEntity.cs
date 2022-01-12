using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicHospital
{
    public abstract class AbstractEntity
    {
        public abstract Doctor createDoctor(string fio, string spec);
        public abstract Doctor createDoctor(string id, string fio, string spec);

        public abstract Palata createPalata(string id, string num, string size, string otdel);

        public abstract Palata createPalata(string num, string size, string otdel);

        public abstract Patient createPatient(string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut);
        public abstract Patient createPatient(string id, string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut);


    }
}
