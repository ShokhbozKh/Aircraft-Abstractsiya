using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class PassengerPlane : Aircraft
    {
        public int passengers { get; set; } = 123;
        public override void Land()
        {
            Console.WriteLine("PassengerPlane Landing............");
        }

        public override void Start()
        {
            Console.WriteLine("PassengerPlane Starting...........");
        }

        public override void Stop()
        {
            Console.WriteLine("PassengerPlane Stoping.........");
        }

        public override void TakeOff()
        {
            Console.WriteLine("PassengerPlane trkeoff............");
        }
    }
}
