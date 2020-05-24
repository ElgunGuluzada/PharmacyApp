using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21052020HTWeekend
{
   partial class Pharmacy
    {
        public string PharmacyName;
        private static int _id = 0;
        public readonly int Id;
        public Drug[] drugArr = new Drug[0];
        

        public Pharmacy()
        {
            Id = _id;
            _id++;
        }
        public Pharmacy(string pharmacyName) : this()
        {
            PharmacyName = pharmacyName;
        }
      
    }
}