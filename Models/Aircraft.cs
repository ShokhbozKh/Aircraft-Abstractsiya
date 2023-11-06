using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    abstract class Aircraft
    {
        public string Color { get; set; }
        public Object engine { get; set; }
        public abstract void Start();
        public abstract void Stop();
        public abstract void TakeOff();
        public abstract void Land();


    }
}
