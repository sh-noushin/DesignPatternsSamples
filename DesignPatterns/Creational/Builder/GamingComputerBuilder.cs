using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Concrete Builder: A specific implementation of the builder interface
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildProcessor()
        {
            computer.Processor = "Intel Core i10";
        }

        public void BuildRAM()
        {
            computer.RAM = 64;
        }

        public void BuildStorage()
        {
            computer.Storage = 2000;
        }

        public void BuildGraphicsCard()
        {
            computer.GraphicsCard = "NVIDIA";
        }

        public Computer Build()
        {
            return computer;
        }
    }

}
