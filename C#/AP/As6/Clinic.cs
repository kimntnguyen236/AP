using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As6
{
    public delegate void DValid(string msg);
    public class Clinic
    {
        SortedList<string, Patient> pList = new SortedList<string, Patient>();
        public void AddNewPatient()
        {
            Patient p = new Patient();
            p.Accept();
            pList.Add(p.pID,p);
        }
    }
}
