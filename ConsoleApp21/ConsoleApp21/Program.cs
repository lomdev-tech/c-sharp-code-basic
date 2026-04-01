namespace ConsoleApp21
{
    internal class Program :Car, Interface1, Interface2
    {
        public string Name { get ; set ; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car car = new();
            car.Name = "Test";
        }

       
    }
}
