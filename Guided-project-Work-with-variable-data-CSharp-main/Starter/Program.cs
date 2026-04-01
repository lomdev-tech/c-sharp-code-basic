// #1 ourAnimals 数组将存储以下内容：
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// #2 支持数据输入的变量
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;
// #3 用于存储运行时数据的数组，没有持久化数据
string[,] ourAnimals = new string[maxPets, 7];

// #4 创建示例数据 ourAnimals 数组条目
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";

            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";

            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";

}


// #5 显示顶级菜单选项
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    // 注意：Console.Clear 方法在调试会话中会引发异常
    Console.Clear();

    Console.WriteLine("欢迎使用 Contoso PetFriends 应用。您的主菜单选项如下：");
    Console.WriteLine(" 1. 列出所有当前宠物信息");
    Console.WriteLine(" 2. 显示具有指定特征的所有狗");
    Console.WriteLine();
    Console.WriteLine("请输入您的选项编号（或输入 Exit 退出程序）");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    // 使用 switch-case 处理所选菜单选项
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            // 列出所有宠物信息
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\r按 Enter 键继续");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Display all dogs with a specified characteristic
            // 显示具有指定特征的所有狗
            //Console.WriteLine("\n功能开发中 - 请下个月查看进度。");
            string dogCharacteristic = "";

            while (dogCharacteristic == "")
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\n输入一个你想搜索的狗狗特征");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                }
            }
            bool noMatchesDog = true;
            string dogDescription = "";
            // #6 loop through the ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // #7 Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];//将狗的身体描述和性格描述字符串连接起来赋给一个整体的狗描述变量

                    if (dogDescription.Contains(dogCharacteristic))
                    {

                        Console.WriteLine($"\n我们的狗 {ourAnimals[i, 3]} 跟你搜索的关键字匹配!");
                        Console.WriteLine(dogDescription);
                        noMatchesDog = false;
                    }

                }
            }

            if (noMatchesDog)
            {
                Console.WriteLine("没有找到符合以下条件的狗狗： " + dogCharacteristic);
            }
            Console.WriteLine("按 Enter 键继续。");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");