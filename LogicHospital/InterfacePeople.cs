using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicHospital
{
    public interface InterfacePeople
    {
        string Fio();
        string Id();
        void setFio(string fio);
        void setId(string id);
    }
}
