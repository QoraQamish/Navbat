using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navbat
{
    public class Navat
    {
        private static List<string> _navbat { get; set;}

        public Navat()
        {
            _navbat = new List<string>();
        }
        //1- Bo'sh navbatni yaratish (Navbatni tozalash)
        public void Tozalash()
        {
            while (_navbat.Count > 0)
            {
                  var navbat = _navbat.First();
                    _navbat.RemoveAt(0);
                    Console.WriteLine(navbat);

            }
        }
        // 2-Navbatni bo'shligni tekshirish
        public bool BushNavbat()
        {
            if (_navbat.Count == 0) return true;
            else return false;
        }
        //3- Navbat oxriga yangi element qo'shish
        public void Navbatga(string yangiNavbat)
        {
            _navbat.Add(yangiNavbat);
        }
        ///4- Navbatdagi birinchi elementni qaytarish va o'chirish
        public string Navbatdan()
        {
            if (_navbat.Count>0)
            {
                var navbat = _navbat.First(); 
                _navbat.RemoveAt(0);
                return navbat;

            }
            return null;
        }

      
    }
}
