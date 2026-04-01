namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");
            //Array.Clear(pallets, 0, 2);

            //Console.WriteLine($"clearning 2..... count: {pallets.Length}");
            //foreach (var pallet in pallets) {

            //    Console.WriteLine($"---{pallet}");
            //}

            //Array.Resize(ref pallets,6);

            //Console.WriteLine($"Resizing 6..... count: {pallets.Length}");
            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (var pallet in pallets)
            //{

            //    Console.WriteLine($"---{pallet}");
            //}
            //Console.WriteLine("");
            //Array.Resize(ref pallets, 3);
            //Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            //foreach (var pallet in pallets)
            //{

            //    Console.WriteLine($"---{pallet}");
            //}

            //string value = "abc123";
            //char[] chars = value.ToCharArray();
            //Array.Reverse(chars);
            ////string result = new(chars);

            //string result = String.Join(",", chars);
            //Console.WriteLine(result);


            //string[] items = result.Split(",");

            //foreach (string item in items) {


            //    Console.WriteLine(item);

            //}


            //string pangram = "The quick brown fox jumps over the lazy dog";
            //string[] words = pangram.Split(' ');
            //char[] charArray = [];
            //for (int i = 0; i < words.Length; i++)
            //{
            //    charArray = words[i].ToCharArray();
            //    Array.Reverse(charArray);
            //    words[i] = new string(charArray);
            //}
            //string result = string.Join(" ", words);
            //Console.WriteLine(words);
            //foreach (string word in words) {

            //    Console.Write(word+" ");
            //}

            //string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            //string[] orders =  orderStream.Split(',');
            //Array.Sort(orders);
            //for (int i= 0;i<orders.Length;i++) {
            //    if (orders[i].Length != 4)
            //    {

            //        Console.WriteLine($"{orders[i]}\t- Error");

            //    }
            //    else {

            //        Console.WriteLine(orders[i]);
            //    }
            //}


            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine("{1} {0}!", first, second);
            //Console.WriteLine("{0} {0} {0}!", first, second);


            //decimal price = 123.45m;
            //int discount = 50;
            //Console.WriteLine($"Price: {price:C} (Save {discount:C})");


            //decimal measurement = 123456.78912m;
            //Console.WriteLine($"Measurement: {measurement:N4} units");

            //decimal tax = .10785m;
            //Console.WriteLine($"Tax rate: {tax:P2}");


            //decimal price = 67.55m;
            //decimal salePrice = 59.99m;

            //string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            //Console.WriteLine(yourDiscount);


            //string input = "Pad this";
            //Console.WriteLine(input.PadLeft(12, '-'));
            //Console.WriteLine(input.PadRight(12, '-'));

            //string paymentId = "769C";
            //string payeeName = "Mr. Stephen Ortega";
            //string paymentAmount = "$5,000.00";

            //var formattedLine = paymentId.PadRight(6);
            //formattedLine += payeeName.PadRight(24);
            //formattedLine += paymentAmount.PadLeft(10);
            //Console.WriteLine("1234567890123456789012345678901234567890");
            //Console.WriteLine(formattedLine);

            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here

            Console.WriteLine(comparisonMessage);
        }
    }
}
