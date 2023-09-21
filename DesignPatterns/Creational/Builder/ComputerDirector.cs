using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Director: The Director class responsible for constructing the computer
    public class ComputerDirector
    {
        private IComputerBuilder builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructComputer()
        {
            builder.BuildProcessor();
            builder.BuildRAM();
            builder.BuildStorage();
            builder.BuildGraphicsCard();
        }
    }
}
