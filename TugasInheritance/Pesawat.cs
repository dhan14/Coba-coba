using System;

namespace TugasInheritance
{
    public class Pesawat : Transportasi //Pesawat adalah transportasi nu bisa ngapung
    {
        public Pesawat()
        {

        }
        public void jenisTransport()
        {
            Console.WriteLine("Di Udara");
        }
        public string bahanBakar()
        {
            return "avgas";
        }
    }
}