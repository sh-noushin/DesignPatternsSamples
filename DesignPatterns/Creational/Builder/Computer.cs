using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Product: The Computer class representing the final Computer system is a
    // complex object that we want to construct it step by step.
    public class Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string GraphicsCard { get; set; }

        public void Display()
        {
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"Storage: {Storage} GB SSD");
            Console.WriteLine($"Graphics Card: {GraphicsCard}");
        }
    }
}
