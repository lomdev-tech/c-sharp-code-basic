// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, jack!");
// Console.Write("Congratulations!");
// Console.Write(" ");
// Console.Write("You wrote your first lines of code.");
// Console.Write("这是第一行");
// Console.WriteLine("这是第二行");
// string name = "jack";
// string age = "18";
// Console.WriteLine($"姓名：{name}，年龄：{age}岁");
// string name1;
// name1 = "tom";
// Console.WriteLine(name1);

// string myfriendName = "Bob";
// int num = 3;
// decimal price = 34.4m;
// var message = $"My friend {myfriendName} bought {num} books, each costs {price} dollars.";
// Console.WriteLine(message);
// Console.WriteLine(34.40m);

// Console.WriteLine("Hello\nWorld!");
// Console.WriteLine("Hello\tWorld!");
// Console.WriteLine("Hello \"World\"!");
// Console.WriteLine("c:\\source\\repos");
// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t");
// Console.WriteLine(@"c:\invoices");

// // Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// // To generate Japanese invoices:
// // Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");
// Console.WriteLine("========================");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t");
// Console.Write(@"c:\invoices");

// // To generate Japanese invoices:
// // Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");
// string firstName = "Jack";
// string greeting = "Hello, World!";
// Console.WriteLine($"{greeting}    aa {firstName}");

// string projectName = "First-Project";
// Console.WriteLine($"C:\\Output\\{projectName}\\Data");
// string projectNamea = "ACME";
// string englishLocation = $@"c:\Exercise\{projectNamea}\data.txt";
// Console.WriteLine($"View English output:\n\t{englishLocation}\n");

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0432";
// string russianLocation = $@"c:\Exercise\{projectNamea}\ru-RU\data.txt";
// Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");


// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// int sophiaSum =  sophia1 + sophia2 + sophia3 + sophia4 + sophia5;;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// decimal sophiaScore = (decimal)sophiaSum / currentAssignments;;
// decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
// decimal jeongScore = (decimal)jeongSum / currentAssignments;
// Console.WriteLine("Student \tGrade\n");
// Console.WriteLine("Sophia: \t" + sophiaScore + "\tA");
// Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
// Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
// Console.WriteLine("Jeong:  \t" + jeongScore + "\tA");
using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password);