using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21052020HTWeekend
{
    class TypeDrug
    {
        public string TypeName ;
        private static int _id = 0;
        public readonly int Id;


        public TypeDrug()
        {
            Id = _id;
            _id++;
        }
        public TypeDrug(string typeName):this()
        {
            TypeName = typeName;
        }

        public override string ToString()
        {
            return $"{Id} {TypeName}";
        }
    }
}
