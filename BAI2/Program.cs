using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace BAI
{
    public partial class BAI_Afteken2
    {
        public static bool Vooruit(uint b)
        {
            // *** IMPLEMENTATION HERE *** //
            
            // Verplaatste de 7de bit naar de eerste en check vervolgens of hij aan staat
            return (b >> 7) == 1;
        }
        public static uint Vermogen(uint b)
        {
            //Bit 5-6
            
            // 00 Vermogen is 0%
            // 01 Vermogen is 33%
            // 10 Vermogen is 67%
            // 11 Vermogen is 100%
            
            if ((b & 96) == 0 )
            {
                return 0;
            }
            
            if ( (b & 64) == 0)
            {
                return 33;
            }
            
            if ((b & 32) == 0)
            {
                return 67;
            }
      
            return 100;
        }
        public static bool Wagon(uint b)
        {
            // Bit 4 (8)
            
            
            // *** IMPLEMENTATION HERE *** //
            return (b & 16) == 16;
        }
        public static bool Licht(uint b)
        {
            // Bit 3 (4)
            
            // *** IMPLEMENTATION HERE *** //
            return (b & 8) == 8;
        }
        public static uint ID(uint b)
        {
            // *** IMPLEMENTATION HERE *** //
            return (b & 7);
        }

        public static HashSet<uint> Alle(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            foreach (var element in inputStroom)
            {
                set.Add(element);
            }
            
            // *** IMPLEMENTATION HERE *** //
            return set;
        }
        public static HashSet<uint> ZonderLicht(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            
            foreach (var element in inputStroom)
            {
                if (Licht(element))
                {
                    continue;
                }
                
                set.Add(element);
            }
            // *** IMPLEMENTATION HERE *** //
            return set;
        }
        public static HashSet<uint> MetWagon(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            
            foreach (var element in inputStroom)
            {
                if (!Wagon(element))
                {
                    continue;
                }

                set.Add(element);
            }
            // *** IMPLEMENTATION HERE *** //
            return set;
        }
        public static HashSet<uint> SelecteerID(List<uint> inputStroom, uint lower, uint upper)
        {
            HashSet<uint> set = new HashSet<uint>();

            foreach (var element in inputStroom)
            {
                uint id = ID(element);

                if (id >= lower && id <= upper)
                {
                    set.Add(element);
                }
            }
            
            // *** IMPLEMENTATION HERE *** //
            return set;
        }

        public static HashSet<uint> Opdr3a(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            set = SelecteerID(inputStroom, 0, 2);
      
            HashSet<uint> zonderLicht = new HashSet<uint>();
            zonderLicht = ZonderLicht(inputStroom);
            
            set.IntersectWith(zonderLicht);
            
            return set;
        }

        public static HashSet<uint> Opdr3b(List<uint> inputStroom)
        {
            // Een verzameling treinen met een ID hoger dan 2 OF met licht. Gebruik hiervoor de set uit opdracht
            // 3a en Alle uit opdracht 2
            
            
            
            HashSet<uint> set = new HashSet<uint>();
            set = Opdr3a(inputStroom: inputStroom);

            // Clean set
            HashSet<uint> set2 = new HashSet<uint>(inputStroom);
            // Sanitize values, remove the 
            set2.ExceptWith(set);
            
            
            // *** IMPLEMENTATION HERE *** //
            return set2;
        }

        public static void ToonInfo(uint b)
        {
            Console.WriteLine($"ID {ID(b)}, Licht {Licht(b)}, Wagon {Wagon(b)}, Vermogen {Vermogen(b)}, Vooruit {Vooruit(b)}");
        }

        public static List<uint> GetInputStroom()
        {
            List<uint> inputStream = new List<uint>();
            for (uint i = 0; i < 256; i++)
            {
                inputStream.Add(i);
            }
            return inputStream;
        }

        public static void PrintSet(HashSet<uint> x)
        {
            Console.Write("{");
            foreach (uint i in x)
                Console.Write($" {i}");
            Console.WriteLine($" }} ({x.Count} elementen)");
        }


        static void Main(string[] args)
        {
            // Console.WriteLine("=== Opgave 1 ===");
            // ToonInfo(210);
            // Console.WriteLine();
            //
            // List<uint> inputStroom = GetInputStroom();
            //
            // Console.WriteLine("=== Opgave 2 ===");
            // HashSet<uint> alle = Alle(inputStroom);
            // PrintSet(alle);
            // HashSet<uint> zonderLicht = ZonderLicht(inputStroom);
            // PrintSet(zonderLicht);
            // HashSet<uint> metWagon = MetWagon(inputStroom);
            // PrintSet(metWagon);
            // HashSet<uint> groter6 = SelecteerID(inputStroom, 6, 7);
            // PrintSet(groter6);
            // Console.WriteLine();
            //
            // Console.WriteLine("=== Opgave 3a ===");
            // HashSet<uint> opg3a = Opdr3a(inputStroom);
            // PrintSet(opg3a);
            // foreach (uint b in opg3a)
            // {
            //     ToonInfo(b);
            // }
            // Console.WriteLine();
            //
            // Console.WriteLine("=== Opgave 3b ===");
            // HashSet<uint> opg3b = Opdr3b(inputStroom);
            // PrintSet(opg3b);
            // foreach (uint b in opg3b)
            // {
            //     ToonInfo(b);
            // }
            // Console.WriteLine();
        }
    }
}
