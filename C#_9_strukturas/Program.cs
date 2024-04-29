using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__9_strukturas
{
    internal class Program
    {
        public struct Darbinieks
        {
            public int id;
            public string vards;
            public string uzvards;
            public int bernu_sk;
            public string amats;
            public bool slodze;

            public void Registret()
            {
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Vards: ");
                vards = Console.ReadLine();
                Console.Write("Uzvards: ");
                uzvards = Console.ReadLine();
                Console.Write("Bernu skaits: ");
                bernu_sk = int.Parse(Console.ReadLine());
                Console.Write("Amats: ");
                amats = Console.ReadLine();
                Console.Write("Slodze (pilna/nepilna): ");
                string input = Console.ReadLine();
                slodze = (input.ToLower() == "pilna");
            }

            public void Izvadit()
            {
                Console.WriteLine("");
                Console.WriteLine($"{id}\t{vards}\t{uzvards}\t{bernu_sk}\t{amats}\t{(slodze ? "pilna" : "nepilna")}");
            }
        }
            public static void IevaditPecId(int id_meklet, Darbinieks[] darbinieki)
            {
                for (int i = 0; i < darbinieki.Length; i++)
                {
                    if (darbinieki[i].id == id_meklet)
                    {
                        Console.WriteLine("Id\tVards\tUzvards\tBernu_sk\tAmats\tSlodze");
                        darbinieki[i].Izvadit();
                    }
                }
            }
        public static void Main(string[] args)
        {
            Console.Write("Ievadi darbinineku skaitu: ");
            int skaits = int.Parse(Console.ReadLine());
            Darbinieks[] darbinieki = new Darbinieks[skaits];

            while (true)
            {
                Console.WriteLine("Lūdzu izvēlēties metodi:");
                Console.WriteLine("1 - Ievadīt darbinieku");
                Console.WriteLine("2 - Izvadīt uz ekrāna");
                Console.WriteLine("3 - Izvadīt konkrētu darbinieku");
                Console.Write("Jūsu izvēle: ");
                string izvele = Console.ReadLine();
                Console.Clear();

                switch (izvele)
                {
                    case "1":
                        for (int i = 0; i < darbinieki.Length; i++)
                        {
                            Console.WriteLine($"Ludzu ievadiet {i+1} darbinieka datus:");
                            darbinieki[i].Registret();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Id\tVards\tUzvards\tBernu_sk\tAmats\tSlodze");
                        for (int i = 0; i < skaits; i++)
                        {
                            darbinieki[i].Izvadit();
                        }
                        break;
                    case "3":
                        Console.Write("Ievadi darbinieka id: ");
                        int id_meklet = int.Parse(Console.ReadLine());
                        IevaditPecId(id_meklet, darbinieki);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}