using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navbat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Navbat yaratamiz:
            Navat navat= new Navat();
            while (true)
            {
                Console.WriteLine(" __________________________Menyu______________________________ \n" +
                                  "|n=0 Bo'sh navbatni yaratish (Navbatni tozalash)              |");
                Console.WriteLine("|n=1 Navbat oxriga yangi element qo'shish                     | ");
                Console.WriteLine("|n=2 Navbatdagi birinchi elementni qaytarish va o'chirish     |");
                Console.WriteLine("|n=3 Navbatni hamma elementni chiqarish va navatni bo'shatish |");
                Console.WriteLine("|n=4 Navbatni bo'shligni tekshirish                           | " +
                                 "\n|_____________________________________________________________|");
                Console.Write("n=");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        {
                            if (navat.BushNavbat()) break;
                            else
                            {
                                Console.WriteLine("Mavjuda navbat elementlari");
                                navat.Tozalash();
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Yangi elementni nomni yozing");
                            string yangiNavbat = Console.ReadLine();
                            navat.Navbatga(yangiNavbat);
                            break;
                        }
                    case 2:
                        {
                            string v = navat.Navbatdan();
                            Console.WriteLine("Navbatning birinchi elementi: {0}", v==null?"Navbat bosh":v);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Barcha navbat elementlari ");
                            navat.Tozalash();
                            break;
                        }
                    case 4:
                        {
                            if (navat.BushNavbat()) Console.WriteLine("Navbat bo'sh");
                            else Console.WriteLine("Navat bo'sh emas!");
                            break;
                        }
                    default:
                        break;
                }

            }

        }
    }
}
