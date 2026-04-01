namespace ConsoleApp10
{
    internal class Program
    {
        static void aa(string[] args)
        {

            //string message = "Find what is (inside the parentheses)";

            //int openingPosition = message.IndexOf('(');
            //int closingPosition = message.IndexOf(')');

            //// Console.WriteLine(openingPosition);
            //// Console.WriteLine(closingPosition);
            //openingPosition += 1;
            //int length = closingPosition - openingPosition;//36-13=23
            //Console.WriteLine(message.Substring(openingPosition, length));


            //string message = "What is the value <span>between the tags</span>?";

            //int openingPosition = message.IndexOf("<span>");
            //int closingPosition = message.IndexOf("</span>");

            //openingPosition += 6;
            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length));


            //string data = "12345John Smith          5000  3  ";
            //string updatedData = data.Remove(5, 20);
            //Console.WriteLine(updatedData);

            //string message = "This--is--ex-amp-le--da-ta";
            //message = message.Replace("--", " ");
            //message = message.Replace("-", "");
            //Console.WriteLine(message);

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";//常量
            int openingPosition = input.IndexOf("<span>")+6;
            string quantity = input.Substring(openingPosition,4);

            int startIndex = input.IndexOf("<h2>");
            int endIndex = input.IndexOf("</span>")+7;
            int length = endIndex - startIndex;
            //Console.WriteLine(length);
            string output = input.Substring(startIndex, length).Replace("&trade", "&reg");


            // Your work here

            Console.WriteLine($"quantity:{quantity}");
            Console.WriteLine($"output:{output}");

        }
        
    }
}
