// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a  = 2100000000;
// int b = 2100000000;
// long c = a + (long)b;
// Console.WriteLine(c);

// decimal a1 = 2.3m;
// decimal b1 = 4.6m;
// decimal c1 = a1 + b1;
// Console.WriteLine(c1);


// int a = 10;
// int b = 20;
// int bb = 1;
// if (a + b > 25){
//     Console.WriteLine("结果大于25");
//     bb++;
//     Console.WriteLine(bb);
// }
// else{
//     Console.WriteLine("结果不大于25");
// }

// int counter = 10;
// do
// {
//     Console.WriteLine(counter);
//     Console.WriteLine(counter++);

//     ++counter;
// } while (counter < 5);
// Console.WriteLine(counter);
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(i);
// }
// 创建一个新数组
// int[] numbers = [1,2,3,4,5,6,7,8,9,10];
// numbers = [..numbers,11,12,13,14,15];
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }
// var numbers = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var names = new List<string> { "Alice", "Bob", "Charlie" };
// var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// string[] names = ["Alice", "Bob", "Charlie"];
// names = [..names, "David", "Eve"];
// foreach (string name in names)
// {
//     Console.WriteLine($"Hello, {name.ToUpper()}!");
// }
// var scores = new List<int> [ 85, 92, 78, 90, 88 ];
List<int> scores = [85, 92, 78, 90, 88];
scores.Add(95);
// LINKQ语法
IEnumerable<int> scoreQuery =
 from score in scores where score >= 90
 orderby score ascending
 select score;
 Console.WriteLine(scoreQuery.Count());

foreach (int score in scoreQuery)
{
    Console.WriteLine(score);
}
int firstDigit = (int) (2.994573 * 10) % 10;
Console.WriteLine(29 % 10);
Console.WriteLine(firstDigit);
// 使用传统语法

// foreach (int score in scores)
// {
//     if (score >= 90)
//     {
//         Console.WriteLine($"优秀成绩: {score}");
//     }
// }
// for (int i = 0; i < scores.Count; i++)
// {
//     if (scores[i] >= 90)
//     {
//         Console.WriteLine($"优秀成绩: {scores[i]}");
//     }
// }
// scores.ForEach(scores =>
// {
//     Console.WriteLine($"Score: {scores}");
// });

// scores.ForEach(scores => Console.WriteLine($"Score: {scores}"));