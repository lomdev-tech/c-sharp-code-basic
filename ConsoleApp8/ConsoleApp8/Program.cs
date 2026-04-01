namespace ConsoleApp8
{
    internal class Program
    {
        static void aa(string[] args)
        {

            Console.WriteLine("有符号整形类型(区分+-)");
            Console.WriteLine($"byte最小数值{sbyte.MinValue} 最大数值{sbyte.MaxValue}");
            Console.WriteLine($"short最小数值{short.MinValue} 最大数值{short.MaxValue}");
            Console.WriteLine($"int最小数值{int.MinValue} 最大数值{int.MaxValue}");
            Console.WriteLine($"long最小数值{long.MinValue} 最大数值{long.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("无符号整形类型（从0开始）");
            Console.WriteLine($"byte最小数值{byte.MinValue} 最大数值{byte.MaxValue}");
            Console.WriteLine($"short最小数值{ushort.MinValue} 最大数值{ushort.MaxValue}");
            Console.WriteLine($"int最小数值{uint.MinValue} 最大数值{uint.MaxValue}");
            Console.WriteLine($"long最小数值{ulong.MinValue} 最大数值{ulong.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("浮点类型(始终有符号)");
            Console.WriteLine($"float最小数值{float.MinValue} 最大数值{float.MaxValue}");
            Console.WriteLine($"double最小数值{double.MinValue} 最大数值{double.MaxValue}");
            Console.WriteLine($"decimal最小数值{decimal.MinValue} 最大数值{decimal.MaxValue}");


        }
    }
}
