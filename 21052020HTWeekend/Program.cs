using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _21052020HTWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy A = new Pharmacy("Zeferan Aptek");
            Console.WriteLine($"{A.Id}\t\t\t{A.PharmacyName}-e Xosh Gelmisiniz");

            Drug d = new Drug("Analgin", 0.2, 500);
            Drug d1 = new Drug("Nemesil", 0.7, 1300);
            Drug d2 = new Drug("Snup", 5.9, 350);
            Drug d3 = new Drug("Bioxen", 40, 50);

            Console.WriteLine("");
            Console.WriteLine("\t\t Daxil olan dermanin Novu, Adi,  Qiymeti ve Miqdari");
            Console.WriteLine("");

            TypeDrug Tab = new TypeDrug("Tablet terkibli");
            TypeDrug Toz = new TypeDrug("Toz terkibli");
            TypeDrug M = new TypeDrug("Maye terkibli");
            TypeDrug B = new TypeDrug("Bitki terkibli");

            Console.WriteLine(Tab.ToString());
            A.AddDrug(d);
            Console.WriteLine(Toz.ToString());
            A.AddDrug(d1);
            Console.WriteLine(M.ToString());
            A.AddDrug(d2);
            Console.WriteLine(B.ToString());
            A.AddDrug(d3);

            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t Derman Siyahisi");
            Console.WriteLine("");

            A.DrugList();

            Console.WriteLine("");
            Console.WriteLine("Zehmet Olmasa Almaq istediyiniz Dermanin Adini Daxil Edin");
            string name = Console.ReadLine();
            Console.WriteLine("Zehmet Olmazsa Azn-le Pulunuzun Miqdarini Daxil Edin");
            Double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet Olmazsa Istediyiniz Miqdari Daxil Edin");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t Eczacinin Cavabi");
            A.SaleDrug(name, price, count);
        }
    }
}

