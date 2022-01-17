using System;
using System.Collections.Generic;

namespace ListOOP
{
    class Program
    {
        static void Main(string[] args)
        {
             //Wisudawan wisudawan = new Wisudawan();
           
            static void Menu()
            {
                bool menu = true;
                while (menu == true)
                {

                    Console.WriteLine("Menu");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("1. Lihat Daftar Wisudawan");
                    Console.WriteLine("2. Daftar Wisuda");
                    Console.WriteLine("---------------------------");

                    Console.Write("Maukkan Pilihan");

                    int input = int.Parse(Console.ReadLine());
                    
                    switch (input)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("masukkan nim :");
                            string nim = Console.ReadLine();
                            Console.WriteLine("masukkan nama :");
                            string nama = Console.ReadLine();
                            Console.WriteLine("masukkan nilai :");
                            int nilai = Convert.ToInt32(Console.ReadLine());

                            var newWisudawan = new Wisudawan(nim,nama,nilai);
                            Wisudawan wisudawan = new Wisudawan();
                            wisudawan.AddWisudawan(newWisudawan);
                            break;
                        case 2:
                            DaftarWisuda();
                            break;

                    }
                }

            }

            Menu();

            

        }
        public static List<Wisudawan> wisudawan = new List<Wisudawan>();
        public static void DaftarWisuda()
        {

            Wisudawan wis = new Wisudawan();
            Console.Clear();
            Console.Write("Masukan Nama :");
            wis.Nama = Console.ReadLine();

            Console.Write("Masukan Nim :");
            wis.Nim = Console.ReadLine();

            Console.Write("Masukan Nilai :");
            wis.Nilai = Convert.ToInt32(Console.ReadLine());


            wisudawan.Add(wis);





                //Wisudawan ws = new Wisudawan();
            /*List<Wisudawan> wisudawans = new List<Wisudawan>();


            wisudawans.Add(new Wisudawan
            {
                Nama = nama,
                Nim = Nim,
                Nilai = nilai,
                Gelar = "",
                Predikat = "d"

            });*/


            /*foreach (var wisudawan in wisudawans)
            {

                Console.WriteLine($"{wisudawan.Nama}   denagan {wisudawan.Predikat}");

            }*/

            }



        public static void ViewTambah()
        {

        }
        

        public static void ListWisudawan()
        {
            Console.Clear();
            Console.WriteLine("List Mahasiswa");
            foreach (var wisu in wisudawan)
            {
                //string lulus = wisu.Lulus(Predikat);

                Console.WriteLine($"{wisu.Nama} nim {wisu.Nim} dinyatakan {wisu.GetPredikat(wisu.Nilai)}");

            }

        }


    }
}
