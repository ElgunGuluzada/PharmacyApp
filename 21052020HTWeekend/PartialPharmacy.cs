using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21052020HTWeekend
{
    partial class Pharmacy
    {
        public override string ToString()
        {
            return $"{Id} {PharmacyName} {drugArr}";
        }
        public void AddDrug(Drug newDrug)
        {
            Array.Resize(ref drugArr, drugArr.Length + 1);
            drugArr[drugArr.Length - 1] = newDrug;
            Console.WriteLine($"{newDrug} elave olundu");
        }
        public void DrugList()
        {
            foreach (Drug drug in drugArr)
            {
                Console.WriteLine($"{drug}");
            }
        }
        public void SaleDrug(string name, Double price, int count)
        {
            for (int i = 0; i < drugArr.Length; i++)
            {
                if (drugArr[i].Name == name && drugArr[i].Price <= price && drugArr[i].Count >= count)
                {
                    Console.WriteLine("ALLAH Shefa Versin. Bizi Sechdiyiniz Uchun Teshekkurler.");
                }
                else if (drugArr[i].Name != name)
                {
                    Console.WriteLine($" Uzr Isteyirik Hal Hazirda Magazamizda {name} dermani yoxdur, Sifarish ede bilersiniz ");
                }
                else if (drugArr[i].Name == name && drugArr[i].Price > price && drugArr[i].Count >= count)
                {
                    Double Lackofmoney = 0;
                    Lackofmoney = drugArr[i].Price - price;
                    Console.WriteLine($" {drugArr[i].Name} dermanin qiymeti {drugArr[i].Price} manatdir, zehmet olmazsa elave {Lackofmoney} manat odenish edin ");
                }
                else if (drugArr[i].Name == name && drugArr[i].Price <= price && drugArr[i].Count < count)
                {
                    int Lackofcount = 0;
                    Lackofcount = count - drugArr[i].Count;
                    Console.WriteLine($"Uzr Isteyirik {drugArr[i].Name} dermani {drugArr[i].Count} eded qalib, {Lackofcount} eded chatmir, sifarish ede bilersiniz");
                }
            }
        }
    }
}
