namespace SayHellos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            SayHello(name);

        }
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
    }
}
