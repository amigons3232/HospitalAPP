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

        
