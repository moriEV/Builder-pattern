using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class Computer
    {
        public CPU cpu { get; set; }
        public Motherboard board { get; set; }
        public RAM memory { get; set; }
        public Storage storage { get; set; }
        public VideoCard videoCard { get; set; }
        public override string ToString()
        {
            return $"Computer Configuration:\n" +
                   $"CPU: {cpu?.Model}\n" +
                   $"Motherboard: {board?.Model}\n" +
                   $"RAM: {memory?.MemoryGB}GB\n" +
                   $"HDD: {storage?.Size}GB\n" +
                   $"GPU: {videoCard?.Model}";
        }
    }
    public class ComputerBuilder
    {
        private Computer computer;

        public ComputerBuilder()
        {
            computer = new Computer();
        }

        public ComputerBuilder SetCPU(string model)
        {
            computer.cpu = new CPU { Model = model };
            return this;
        }

        public ComputerBuilder SetMotherboard(string model)
        {
            computer.board = new Motherboard { Model = model };
            return this;
        }

        public ComputerBuilder SetRAM(int memoryGB)
        {
            computer.memory = new RAM { MemoryGB = memoryGB };
            return this;
        }

        public ComputerBuilder SetHDD(int size)
        {
            computer.storage = new Storage { Size = size };
            return this;
        }

        public ComputerBuilder SetGPU(string model)
        {
            computer.videoCard = new VideoCard { Model = model };
            return this;
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
