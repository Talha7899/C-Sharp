/*
 Grade Calculator:

Create a C# console application that calculates the final grade of a student based on the marks obtained in three subjects: Mathematics, Science, and English. The grading system is as follows:
Marks range from 0 to 100 for each subject.
The final grade is determined based on the average marks obtained.
Use the following grading scale:
A: 90 - 100
B: 80 - 89
C: 70 - 79
D: 60 - 69
F: Below 60
Your program should:Prompt the user to input marks for Mathematics, Science, and English.Calculate the average marks.Determine the final grade based on the average marks using a switch case statement.Display the final grade to the user.
Ensure the program handles invalid input gracefully.

Sample Output:

Grade Calculator

Enter marks for Mathematics: 85
Enter marks for Science: 78
Enter marks for English: 92

Average marks: 85

Final Grade: B
 */


Console.WriteLine("Enter marks for Mathematics");

var mathmathics = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter marks for Science");

var science = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter marks for English");

var english = Convert.ToInt32(Console.ReadLine());

int avg_marks = ((mathmathics + science + english)/3);

if (avg_marks >= 90 && avg_marks <= 100)
{
    Console.WriteLine($"Average Marks: {avg_marks}");
    Console.WriteLine("Final Grade: A");
}else if (avg_marks >=80  && avg_marks <= 89)
{
    Console.WriteLine($"Average Marks: {avg_marks}");
    Console.WriteLine("Final Grade: B");
}
else if (avg_marks >= 70 && avg_marks <= 79)
{
    Console.WriteLine($"Average Marks: {avg_marks}");
    Console.WriteLine("Final Grade: C");
}
else if (avg_marks >= 60 && avg_marks <= 69)
{
    Console.WriteLine($"Average Marks: {avg_marks}");
    Console.WriteLine("Final Grade: D");
}
else if (avg_marks < 60)
{
    Console.WriteLine($"Average Marks: {avg_marks}");
    Console.WriteLine("Final Grade: F");
}
else
{
    Console.WriteLine("Please enter a valid marks of Subjects");
}