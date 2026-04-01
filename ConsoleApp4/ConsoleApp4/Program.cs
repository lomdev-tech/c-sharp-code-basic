using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentAssignments = 5;//科目数量
            string[] studentNames = { "Jack", "Andrew", "Emma", "Logan" };
            int[] studentScores = new int[10];
            string currentStudentLetterGrade = "";
            int[] jackScores = { 90, 86, 87, 98, 100 };
            int[] andrewScores = { 92, 89, 81, 96, 90 };
            int[] emmaScores = { 90, 85, 87, 98, 68 };
            int[] loganScores = { 90, 95, 87, 88, 96 };
            Console.WriteLine("Student\t\tGrade\n");
            foreach (string name in studentNames)//循环名字
            {
                string currentStudent = name;
                if (currentStudent == "Jack")//
                {
                    studentScores = jackScores;

                }
                else if (currentStudent == "Andrew")
                {
                    studentScores = andrewScores;

                }
                else if (currentStudent == "Emma")
                {
                    studentScores = emmaScores;
                }
                else if (currentStudent == "Logan")
                {
                    studentScores = loganScores;

                }
                int sumAssignmentScores = 0;
                foreach (int singleScore in studentScores)
                {
                    sumAssignmentScores += singleScore;
                }
                decimal currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

            }
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}
