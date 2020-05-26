using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21052020HTWeekend
{
    class Drug
    {
        public  string Name;
        private static int _id = 0;
        public readonly int Id;
        public Double Price;
        public int Count;

        public Drug()
        {
            Id = _id;
            _id++;
        }
        //public Drug(string name) : this()
        //{
        //    Name = name;
        //}
        public Drug(string name, Double price, int count) : this()
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public override string ToString()
        {
            return $"{Id} Adi: {Name} - Qiymeti: {Price} manat - Sayi: {Count} eded";
        }    
    }
}
