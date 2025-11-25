using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExamScore\tOverall Grade\t\tExtra Credit\n");

foreach (string name in studentNames)
{

  string currentStudent = name;

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;
  else if (currentStudent == "Andrew")
    studentScores = andrewScores;
  else if (currentStudent == "Emma")
    studentScores = emmaScores;
  else if (currentStudent == "Logan")
    studentScores = loganScores;
  else if (currentStudent == "Becky")
    studentScores = beckyScores;
  else if (currentStudent == "Chris")
    studentScores = chrisScores;
  else if (currentStudent == "Eric")
    studentScores = ericScores;
  else if (currentStudent == "Gregor")
    studentScores = gregorScores;
  else
    continue;

  decimal sum = 0;
  decimal studentScore;

  int gradeAssigmentes = 0;
  decimal extraCredit = 0;
  decimal examScore = 0;
  foreach (int score in studentScores)
  {
    gradeAssigmentes++;
    if (gradeAssigmentes <= examAssignments)
    {
      sum += score;
      examScore += score;      
    }      
    else
    {
      sum += (decimal)score / 10;
    }
  }
  examScore /= examAssignments;
  studentScore = (decimal)sum / examAssignments;
  extraCredit = studentScore - examScore;
  

  if (studentScore >= 97)
    currentStudentLetterGrade = "A+";
  else if (studentScore >= 93)

    currentStudentLetterGrade = "A";
  else if (studentScore >= 90)
    currentStudentLetterGrade = "A-";

  else if (studentScore >= 87)

    currentStudentLetterGrade = "B+";
  else if (studentScore >= 83)
    currentStudentLetterGrade = "B";

  else if (studentScore >= 80)
    currentStudentLetterGrade = "B-";

  else if (studentScore >= 77)
    currentStudentLetterGrade = "C+";

  else if (studentScore >= 73)
    currentStudentLetterGrade = "C";

  else if (studentScore >= 70)
    currentStudentLetterGrade = "C-";

  else if (studentScore >= 67)
    currentStudentLetterGrade = "D+";

  else if (studentScore >= 63)
    currentStudentLetterGrade = "D";

  else if (studentScore >= 60)
    currentStudentLetterGrade = "D-";
  else
    currentStudentLetterGrade = "F";

  Console.WriteLine(currentStudent + "\t\t" + examScore + "\t\t" + studentScore + "\t" + currentStudentLetterGrade + "\t\t" + (int)examScore+ " "+ "(" + extraCredit + ")");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
