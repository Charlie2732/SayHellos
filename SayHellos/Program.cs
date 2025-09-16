namespace SayHellos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))  // loop för att säkerställa att användaren skriver in ett namn

            {
                Console.WriteLine("Du måste skriva in ett namn!");
                Console.WriteLine("Vad heter du?");
                name = Console.ReadLine();
            }

            SayHello(name);
        }
        static void SayHello(string name) //    metod med parameter
        {
            Console.WriteLine($"Hello, {name}");
        }
    
    }
}
