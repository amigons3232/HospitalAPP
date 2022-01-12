using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicHospital
{
   public class PatientFabric : AbstractEntity
    {
        public override Doctor createDoctor(string fio, string spec)
        {
            throw new NotImplementedException();
        }

        public override Doctor createDoctor(string id, string fio, string spec)
        {
            throw new NotImplementedException();
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
            return new Patient(fio, idPalata, idDoctor, DateIn, diagnoz, DateOut);
        }

        public override Patient createPatient(string id, string fio, string idPalata, string idDoctor, string DateIn, string diagnoz, string DateOut)
        {
            return new Patient(id, fio, idPalata, idDoctor, DateIn, diagnoz, DateOut);
        }
    }
}
