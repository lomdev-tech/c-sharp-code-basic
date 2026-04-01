using System;

// ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data
string[,] ourAnimals = new string[maxPets, 7];

// sample data ourAnimals array entries
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
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "lion";
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

// top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("欢迎使用 Contoso PetFriends 应用程序。您的主菜单选项有：");
    Console.WriteLine(" 1. 列出所有当前宠物信息");
    Console.WriteLine(" 2. 显示具有指定特征的所有狗狗");
    Console.WriteLine(" 3. 添加宠物");
    Console.WriteLine();
    Console.WriteLine("请输入您的选项编号（或输入 Exit 退出程序）");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }

            Console.WriteLine("\r\n按 Enter 键继续");
            readResult = Console.ReadLine();

            break;

        case "2":
            // #1 Display all dogs with a multiple search characteristics

            string dogCharacteristic = "";

            while (dogCharacteristic == "")
            {
                // #2 have user enter multiple comma separated characteristics to search for
                Console.WriteLine($"\r\n请输入要搜索的狗狗特征，多个特征请用逗号分隔。");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                    Console.WriteLine();
                }
            }
            string[] dogSearchs = dogCharacteristic.Split(",");
            for (int i = 0; i < dogSearchs.Length; i++) dogSearchs[i] = dogSearchs[i].Trim();
            Array.Sort(dogSearchs);
            //foreach (var s in dogSearchs) Console.WriteLine(s+"-");
            //bool noMatchesDog = true;
            string dogDescription = "";

            // #4 update to "rotating" animation with countdown
            string[] searchingIcons = { " |", " /", "--", " \\", " *" };

            bool matchesAnyDog = false;

            // loop ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {

                if (ourAnimals[i, 1].Contains("dog"))
                {

                    // Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];
                    bool matchesCurrentDog = false;

                    foreach (var dogs in dogSearchs)
                    {
                        if (dogs != null && dogs.Trim() != "")
                        {

                            for (int j = 2; j > -1; j--)
                            {
                                // #5 update "searching" message to show countdown 
                                foreach (string icon in searchingIcons)
                                {
                                    Console.Write($"\r正在搜索我们的狗狗 {ourAnimals[i, 3]} 中是否有特征 {dogCharacteristic} {icon}");
                                    Thread.Sleep(100);
                                }

                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }
                            if (dogDescription.Contains(" " + dogs.Trim() + " "))
                            {
                                // #3b update message to reflect term 
                                // #3c set a flag "this dog" is a match
                                Console.WriteLine($"\r我们的狗 {ourAnimals[i, 3]} 符合您对 {dogs.Trim()} 的搜索");
                                matchesCurrentDog = true;
                                matchesAnyDog = true;
                                //noMatchesDog = false;
                            }

                        }
                    }

                    if (matchesCurrentDog)
                    {
                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                    }
                    // #3a iterate submitted characteristic terms and search description for each term



                    // #3d if "this dog" is match write match message + dog description
                }
            }

            if (!matchesAnyDog)
            {

                Console.WriteLine("没有找到与以下特征匹配的狗: " + dogCharacteristic);


            }

            Console.WriteLine("\n\r按 Enter 键继续");
            readResult = Console.ReadLine();

            break;
        case "3":
            Console.WriteLine("正在开发中，等下个月再来..");
            Console.WriteLine("\n\r按 Enter 键继续");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }
} while (menuSelection != "exit");