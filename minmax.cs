using System;


namespace lab11rabika
{
    internal class minmax
    {
        static void Main()
        {
            
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

        
            int[] marks = new int[numberOfStudents];

          
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter the marks for student {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

           
            int minMarks = marks[0];
            int maxMarks = marks[0];
            int totalMarks = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                if (marks[i] < minMarks)
                {
                    minMarks = marks[i];
                }
                if (marks[i] > maxMarks)
                {
                    maxMarks = marks[i];
                }
                totalMarks += marks[i];
            }

            double averageMarks = (double)totalMarks / numberOfStudents;

         
            Console.WriteLine($"Minimum Marks: {minMarks}");
            Console.WriteLine($"Maximum Marks: {maxMarks}");
            Console.WriteLine($"Average Marks: {averageMarks:F2}");
        }
    }
}

