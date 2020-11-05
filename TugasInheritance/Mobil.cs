using System;

namespace TugasInheritance
{
    public class Mobil : Transportasi//mobil ban nya ngagulutuk
    {
        public Mobil()
        {

        }
        public void jenisTransport()
        {
            Console.WriteLine("Di Darat");
        }
        public string bahanBakar()
        {
            return "bensin";
        }
    }
}