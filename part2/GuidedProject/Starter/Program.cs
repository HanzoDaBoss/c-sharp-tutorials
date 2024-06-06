using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[][] studentScores = [[90, 86, 87, 98, 100], [92, 89, 81, 96, 90], [90, 85, 87, 98, 68], [90, 95, 87, 88, 96], [92, 91, 90, 91, 92], [84, 86, 88, 90, 92], [80, 90, 100, 80, 90], [91, 91, 91, 91, 91]];

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentSums = { 0, 0, 0, 0, 0, 0, 0, 0 };

Dictionary<int, string> gradeConversions = new Dictionary<int, string>(){
    {97, "A+"},
    {93, "A"},
    {90, "A-"},
    {87, "B+"},
    {83, "B"},
    {80, "B-"},
};

int i = 0;

Console.WriteLine("Student\t\tGrade\n");

foreach (int[] scores in studentScores)
{
    decimal studentScore;
    string currentStudentLetterGrade = "";

    foreach (int score in scores)
    {
        studentSums[i] += score;
    }

    studentScore = (decimal)studentSums[i] / currentAssignments;

    foreach (KeyValuePair<int, string> gradeConversion in gradeConversions)
    {
        if (studentScore >= gradeConversion.Key)
        {
            currentStudentLetterGrade = gradeConversion.Value;
            break;
        }
    }

    Console.WriteLine($"{studentNames[i]}:\t\t" + studentScore + $"\t{currentStudentLetterGrade}");
    i++;
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
