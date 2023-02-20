using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("driving Motorcycle with abstract method");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("plus a little more");
        }
    }
}
