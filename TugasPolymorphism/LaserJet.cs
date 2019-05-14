using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Name = "LaserJet";

            Console.WriteLine("{0} display dimension : 12*12", Name);
        }
    }
}
