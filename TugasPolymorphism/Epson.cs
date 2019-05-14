using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Name = "Epson";

            Console.WriteLine("{0} display dimension : 10*11", Name);
        }
    }
}
