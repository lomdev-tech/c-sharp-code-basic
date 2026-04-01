// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

// int leadingDigit = (int) gradePointAverage;
// int firstDigit = (int) (gradePointAverage * 10 ) % 10;
// int secondDigit = (int) (gradePointAverage * 100 ) % 10;

// Console.WriteLine($"Student: {studentName}\n");
// Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

// Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");

// Random dice = new();
// for (int i = 0; i < 7; i++)
// {
//     int roll = dice.Next(1, 7);//1-6
//     Console.WriteLine(roll);
// }
// int result = dice.Next();
// Console.WriteLine(result);




// Random dice = new();
// int roll1 = dice.Next();//[0-21亿)的随机整数
// int roll2 = dice.Next(101);//101以内的随机整数[0,101)
// int roll3 = dice.Next(50, 101);//[50-101)的随机整数
// Console.WriteLine($"First roll: {roll1}");
// for (int i = 0; i < 11; i++)
// {
//     int roll2 = dice.Next(11);
// Console.WriteLine($"Second roll: {roll2}");

// }
// Console.WriteLine($"Third roll: {roll3}");

// Random dice = new();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

Random dice = new();
int winCount = 0;
for (int i = 0; i < 10; i++)
{
    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);
    int total = roll1 + roll2 + roll3;

    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        total += 2;
    }

    Console.WriteLine($"{i + 1} round");
    Console.WriteLine($"Dice roll:{roll1}+{roll2}+{roll3}={total}");
    if (total >= 15)
    {
        winCount++;
        Console.WriteLine("You win!");
        Console.WriteLine();
    }
    if (total < 15)
    {
        Console.WriteLine("Sorry, You lose.");
        Console.WriteLine();
    }
}
Console.Write($"total winCount:{winCount}\n");
double epsilon = 1e-9;
Console.WriteLine(epsilon);