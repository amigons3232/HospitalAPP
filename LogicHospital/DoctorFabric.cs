using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicHospital
{
    public class DoctorFabric:AbstractEntity
    {
        public override Doctor createDoctor(string fio, string spec)
        {
            return new Doctor(fio, spec);
        }

        public override Doctor createDoctor(string id, string fio, string spec)
        {
            return new Doctor(id, fio, spec);
        }

        public override Palata createPalata(string id, string num, string size, string otdel)
        {
            throw new NotImplementedException();
        }

        public override Palata createPalata(string num, string size, string otdel)
        {
            throw new NotImplementedException();
        }

        public override Patient createPatient(string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut)
        {
            throw new NotImplementedException();
        }

        public override Patient createPatient(string id, string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut)
        {
            throw new NotImplementedException();
        }
    }
}
