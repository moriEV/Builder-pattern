using Builder_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ComputerBuilder builder = new ComputerBuilder();
        Computer computer = builder
            .SetCPU("Intel Core i7")
            .SetMotherboard("ASUS ROG Strix Z490-E")
            .SetRAM(16)
            .SetHDD(2000)
            .SetGPU("NVIDIA GeForce RTX 3080")
            .Build();

        Console.WriteLine(computer.ToString());
    }
}