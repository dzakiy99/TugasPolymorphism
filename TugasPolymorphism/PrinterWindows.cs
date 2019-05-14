using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class PrinterWindows
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("{0} display dimension : N/A", Name);
        }

        public void Print()
        {
            Console.WriteLine("{0} printer printing....", Name);
        }
    }
}
