namespace ConsoleApp3
{
    class Person
    {
        public string name="jack2";
        //无参构造器默认写  如果两个及以上的构造器就要把默认的写出来

    }
    class Program
    {
         static void Main(string[] args)
        {
            Person person = new();
            string name = "   jack1";
            name = name.TrimStart();
            Console.WriteLine("Hello, World!");
            Console.WriteLine(name);
            string a = person.name;
            Console.WriteLine(a);
        }
    }
}
