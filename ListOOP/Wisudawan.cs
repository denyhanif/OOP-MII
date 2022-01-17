using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ListOOP
{
    class Wisudawan : Mahasiswa
    {
        public int Nilai { get; set; }
        public string Predikat { get; set; }
        public string Gelar { get; set; }

        List<Wisudawan> _wisudawan { get; set; } = new List<Wisudawan>();

        
        public Wisudawan() { }
        public Wisudawan(string namaWisudawan, string nimWisudawan , int nilaiWisudawan)
        {
            Nama = namaWisudawan;
            Nim = nimWisudawan;
            Nilai = nilaiWisudawan;

        }
        public override bool Lulus(string Predikat)
        {
            bool isLulus = false;
            if (Predikat.Equals("A"))
            {
                isLulus = true;
            }
            else if (Predikat.Equals("B"))
            {
                isLulus = true;
            }

            return isLulus;
        }


        public override string GetPredikat(int Nilai)
        {
            if (Nilai> 60)
            {
                Predikat = "Lulus dengan nilai A";
            }
            else if (Nilai<50){

                 Predikat = "Lulus dengan nilai B";
            }
            else
            {
                Predikat = "Belum Lulus Karena nilai C";
            }

            return Predikat;
            
        }

        public void AddWisudawan( Wisudawan wisudawan)
        {
            _wisudawan.Add(wisudawan);

        }


        public void GetWisudawan(List<Wisudawan> wisudawans)
        {
            int no = 0;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Daftar Wisudawan");
            Console.WriteLine("");
            foreach (var wisudawan in wisudawans)
            {
                Console.WriteLine($"{no+1}  Nama : {wisudawan.Nama} Nim :{wisudawan.Nim} degan predikat : {wisudawan.Predikat}");
            }
            Console.WriteLine("");
        }
        public void ShowWisudawan()
        {
            int itemLength = _wisudawan.Count;
            if (itemLength != 0)
            {
                GetWisudawan(_wisudawan);
            }
            else
            {
                Console.WriteLine("Data Wisudawan Kosong");
                //GetMessage(ConsoleColor.Yellow, "Record is empty");
            }
        }

        public void UpdateWisudawan(string nim)
        {
            var item = _wisudawan.FirstOrDefault(x=>x.Nim == nim);

            if ( item == null)
            {
                Console.WriteLine("Data tidak ditemukan");
            }
            else
            {
                Console.WriteLine(" Update Nama :");
                string inputNama = Console.ReadLine();
                Console.WriteLine(" Update Nilai :");
                string inputNilai = Console.ReadLine();

                item.Nim = inputNama;
                item.Nama = inputNama;

                Console.WriteLine("Data berhasil di update");
            }
        }

        public void DleteWisudawan(string nim)
        {
            var item = _wisudawan.FirstOrDefault(x => x.Nim == nim);

            if (item ==  null)
            {
                Console.WriteLine("data tidak di temukan");
            }
            else
            {
                Console.WriteLine("Apakah Anda yakin");
                string choose = Console.ReadLine().ToUpper().Trim();
                switch (choose)
                {
                    case "Y":
                        _wisudawan.Remove(item);
                        Console.WriteLine("Record deleted successfully");
                        break;
                    case "N":
                        Console.WriteLine( "Record failed to delete");
                        break;
                    default:
                        Console.WriteLine("Invalid input tidak valid");
                        break;
                }
            }
        }








    }
}
