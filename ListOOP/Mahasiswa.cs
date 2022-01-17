using System;
using System.Collections.Generic;
using System.Text;

namespace ListOOP
{
    class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
       
        public virtual bool Lulus( string nilai)
        {
            bool isLulus = false;
            return isLulus;
        }

        public virtual string GetPredikat(int nilai)
        {
            String selamat = " ";
            return selamat;
        }


        public void addWisudawan()
        {

        }

        public void ShowWisudawan() { }
 
        public void UpdateWisudawan()
        {

        }

        public void DeleteWisudawan()
        {

        }

    }
}
