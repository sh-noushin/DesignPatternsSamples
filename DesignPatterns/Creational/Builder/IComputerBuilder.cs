using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Builder: An abstract builder interface
    public interface IComputerBuilder
    {
        void BuildProcessor();
        void BuildRAM();
        void BuildStorage();
        void BuildGraphicsCard();
        Computer Build();
    }
}
