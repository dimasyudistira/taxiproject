using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver: {0}", DriverName);
            Console.WriteLine("Sedang Tugas: {0}", OnDuty);
            Console.WriteLine("Penumpang ke: {0}", NumPassenger);
            Console.WriteLine("================================================");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
            Console.WriteLine("{0} akan selesai mengantar penumpang dalam 30 menit", DriverName);
            Console.WriteLine("================================================");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} melakukan perjalanan selama 30 menit", DriverName);
            Console.WriteLine("{0} telah selesai ngantar penumpang", DriverName);
            Console.WriteLine("================================================");
        }
    }
}