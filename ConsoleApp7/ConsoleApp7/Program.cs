namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int first = 2;
            //string second = "4";
            //string result = first + second;//拼接
            //Console.WriteLine(result);

            //int myInt = 3;
            //Console.WriteLine($"int:{myInt}");

            //decimal myDecimal = myInt;
            //Console.WriteLine($"{myDecimal}");


            //decimal myDecimal = 3.14m;
            //Console.WriteLine($"{myDecimal}");
            //int myInt = (int)myDecimal;
            //Console.WriteLine($"{myInt}");

            //decimal myDecimal = 1.23456789m;
            //float myFloat = (float)myDecimal;

            //Console.WriteLine($"Decimal: {myDecimal}");
            //Console.WriteLine($"Float  : {myFloat}");
            //int first = 5;
            //int second = 7;
            //string message = first.ToString() + second.ToString();
            //Console.WriteLine(message);
            //string first = "5ee";
            //string second = "7";
            //int outresult;
            //int sum = int.Parse(first) + int.Parse(second);//强行转换 如果字符串不全是数字会抛异常
            //bool flag = int.TryParse(first,out outresult);//可以运行，转换成功会返回true outresult赋值转换成功的值
            //失败会返回false outresult会被赋值为0
            //Console.WriteLine(flag);
            //Console.WriteLine(outresult);
            //Console.WriteLine(sum);

            //int result = Convert.ToInt32(first)+Convert.ToInt32(second);//Convert.ToInt32方法会尝试将字符串转换为整数，
            //                                                            //如果转换失败会抛出异常
            //Console.WriteLine(result);
            //Console.WriteLine("按回车键位继续");
            //Console.ReadLine();


            //int value = (int)1.5m;
            //Console.WriteLine(value);
            //int value2 = Convert.ToInt32(1.5m);
            //Console.WriteLine(value2);
            // decimal value = 2.5m;
            //int a = Convert.ToInt32(value);
            // Console.WriteLine(a);

            //string name = "Bob";
            //Console.WriteLine(int.Parse(name));
            //string value = "102";
            //int result = 0;
            //bool flag = int.TryParse(value, out result);
            //if (flag) {

            //    Console.WriteLine($"{result}");

            //}
            //else {
            //    value = "0";
            //    Console.WriteLine($"{value}");
            //    Console.WriteLine($"{result}");
            //}

            //string value = "bad";
            //int result = 0;
            //if (int.TryParse(value, out result))
            //{
            //    Console.WriteLine($"Measurement: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Unable to report the measurement.");
            //}

            //if (result > 0)
            //    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

            //string[] values =  { "12.3","A","B","C","D","E","45","60"};
            //decimal total=0m;
            //string message = "";
            //foreach (string value in values) {
            //    decimal number;
            //    if (decimal.TryParse(value, out number))
            //    {

            //        total += number;

            //    }
            //    else {

            //        message += value;

            //    }

            //}
            //Console.WriteLine($"{total}");
            //Console.WriteLine($"{message}");

            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;
            int result1 = Convert.ToInt32(value1/value2);
            decimal result2 = value2 / (decimal)value3;
            float result3 = value3 / value1;
            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            Console.WriteLine($"将 value1 除以 value2，并以int形式显示结果。{result1}");

            // Your code here to set result2
            Console.WriteLine($"将 value2 除以 value3，并以decimal形式显示结果。 {result2}");

            // Your code here to set result3
            Console.WriteLine($"将 value3 除以 value1，并以float形式显示结果。 {result3}");
        }
    }
}       
