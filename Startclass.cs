using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Startclass
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Tere tulemast");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            //если имя Юку
            /*if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla! Lähme kinno!");
            //кино
                Console.WriteLine("Kui vana sa oled?");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus<0 || vanus>=120)
                {
                    Console.WriteLine("Viga andmetega");
                }
                else if (vanus<6)
                {
                    Console.WriteLine("Tasuta pilet!");
                }
                else if (vanus>=6 && vanus<=14)
                {
                    Console.WriteLine("Lastepilet!");
                }
                else if (vanus>15 && vanus <65)
                {
                    Console.WriteLine("Täispilet!");
                }
                else if (vanus>=65)
                {
                    Console.WriteLine("Sooduspilet!");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }*/

            /*1 вариант. умножение двух цифр, введенных пользователем*/
            /*Console.Write("arv1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("arv2: ");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("Kogus = {0}", c);*/
            /*2 вариант. умножение двух цифр, введенных пользователем*/
            /*int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);*/

            /*соседи по парте*/
            /*Console.WriteLine("Siseta esimene nimi: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Siseta teine nimi: ");
            string nimi2 = Console.ReadLine();
            Console.WriteLine("{0} ja {1} olevad pinginaabrid", nimi1, nimi2);*/

            /*площадь*/
            /*
            Console.Write("kõrgus: ");
            decimal kõrgus = Math.Abs(decimal.Parse(Console.ReadLine()));
            Console.Write("pikkus: ");
            decimal pikkus = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal pindala = kõrgus * pikkus;
            Console.WriteLine("Kogus = {0} m2", pindala);
            Console.WriteLine("Kas tahad remondi teha?");
            string otvet = Console.ReadLine();
            if (otvet=="jah")
            {
                Console.WriteLine("Kui suur ruud meetri hind?");
                decimal hind = decimal.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(hind * pindala,2) + " - summa");
            }
            else
            {
                Console.WriteLine("Head aega!");
            }
            */
            //скидка 30%
            /*Console.Write("Siseta hind: ");
            int hind = int.Parse(Console.ReadLine());           
            int soodustus = (hind/100)*30;
            Console.WriteLine("Soodustus (30%) on {0}", soodustus);*/

            //temperatuur
            /*Console.WriteLine("Mis temperatuur on täna?");
            int temp = int.Parse(Console.ReadLine());
            if (temp<18 || temp>18)
            {
                Console.WriteLine("{0} on ebameeldiv temperatuur!", temp);
            }
            else if (temp==18)
            {
                Console.WriteLine("{0} on hea temperatuur!", temp);
            }*/

            Console.WriteLine("Sinu pikkus? (cm) ");
            decimal pikk = Math.Abs(decimal.Parse(Console.ReadLine()));
            if (pikk < 130 || pikk>230)
            {
                Console.WriteLine("Vale pikkus");
                
            }
            else
            {
                Console.WriteLine("Sa oled naine või mees? ");
                string sugu = Console.ReadLine();
                if (sugu == "naine")
                {
                    if (pikk < 165)
                    {
                        Console.WriteLine("Sul on lühike pikkus");
                    }
                    else if (pikk == 165)
                    {
                        Console.WriteLine("Sul on keskmine pikkus");
                    }
                    else if (pikk > 165)
                    {
                        Console.WriteLine("Sul on suur pikkus");
                    }
                }
                else if (sugu == "mees")
                {
                    if (pikk < 176)
                    {
                        Console.WriteLine("Sul on väike pikkus");
                    }
                    else if (pikk == 176)
                    {
                        Console.WriteLine("Sul on keskmine pikkus");
                    }
                    else if (pikk > 176)
                    {
                        Console.WriteLine("Sul on suur pikkus");
                    }
                }
            }
            

                Console.ReadLine();
        }
    }
}
