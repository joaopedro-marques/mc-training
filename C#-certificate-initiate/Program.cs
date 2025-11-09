// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Write("Congratulations!");
// Console.Write(" ");
// Console.Write("You wrote your first line of code!");


// Console.WriteLine("Congratulations!");
// Console.Write("You Wrote your first lines of code.");

// Console.WriteLine("This is the first Line!");
// Console.WriteLine("This is the second line!");

// Console.WriteLine('b');

// Console.WriteLine('Hello World!');

// Console.WriteLine(123);
// Console.WriteLine(2.625);
// Console.WriteLine(12.39816m);
// Console.WriteLine(true);
// Console.WriteLine(false);
// Console.WriteLine("123");
// Console.WriteLine(123);

// Console.WriteLine("true");
// Console.WriteLine(true);

// string firstName;
// firstName = "Jhonny";
// Console.WriteLine(firstName);
// firstName = "Liem";
// Console.WriteLine(firstName);
// firstName = "Isabella";
// Console.WriteLine(firstName);
// firstName = "Yasmin";
// Console.WriteLine(firstName);

// string firstName;
// Console.WriteLine(firstName);

// string firstName = "Bob";
// int num = 3;
// double y = 34.4;

// Console.WriteLine($"Hello {firstName}! You have {num} messages and the temperature is {y} Celsius");

// Console.WriteLine("Hello\nWorld!");
// Console.WriteLine("Hello\tWorld!");
// Console.WriteLine("Hello\"World\"!");
// Console.WriteLine("c\\source\\repos");

using System.Runtime.InteropServices;

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Console.WriteLine(@"      c\souce\repos
//  (This is where your code goes)");

Console.Write(@"c:\invoices");
Console.WriteLine();
 Console.WriteLine("--------------------------------");
// Console.WriteLine("\u3053\u3093\u306b\u3061\u306f World");

Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("---------------------------------");
Console.WriteLine("STRING CONCATENATION");

string firstName = "John";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

Console.WriteLine("-------------------");
Console.WriteLine("STRING INTERPOLATION");

string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

message = $"Hello {firstName}!";
Console.WriteLine(message);

Console.WriteLine("-------------------");
int version = 11;
string updateText = "Update Windows";
Console.WriteLine($"{updateText} {version}!");

Console.WriteLine("-------------------");
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

Console.WriteLine("----------------");
projectName = "ACME";
Console.WriteLine($@" View English output:
  C:\Exercise\{projectName}\data.txt");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"{russianMessage}
  C:\Exercise\{projectName}\ru-RU\data.txt");

Console.WriteLine("----------------");
Console.WriteLine("Performing addiction with implicit type conversions");
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

Console.WriteLine("----------------");
Console.WriteLine("PERFORMING MATH OPERATIONS");
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal castingQuotient = (decimal)first / (decimal)second;

Console.WriteLine($"Quotient: {castingQuotient}");
Console.WriteLine($"Modulus of 200/5 : {200 % 5}");
Console.WriteLine($"Modulus of 7/5 : {first % second}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

Console.WriteLine("----------------");
Console.WriteLine("INCREMENT AND DECREMENT OPERATORS");
int value = 0;
value = value + 5;
value += 5;
value = 0;
value = value + 1;
value++;


value = 1;
value = value + 1;
Console.WriteLine("First increment" + value);

value += 1;
Console.WriteLine("Second increment" + value);

value++;
Console.WriteLine("Third increment" + value);

value = value - 1;
Console.WriteLine("First decrement" + value);

value -= 1;
Console.WriteLine("Second decrement" + value);

value--;
Console.WriteLine("Third decrement" + value);

value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Thirds: " + value);
Console.WriteLine("Fourth: " + (++value));

Console.WriteLine("----------------");
Console.WriteLine("Fahrenheit to Celsius challenge");

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5.0m / 9.0m);
Console.WriteLine($"The temperature is {celsius} Celsius.");

Console.WriteLine("----------------");
Console.WriteLine("CALCULATE AND PRINT STUDENT GRADES");
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


decimal sohpiaScore;
decimal nicolasScore;
decimal zahirahScore;
decimal jeongScore;

sohpiaScore = (decimal)sophiaSum / currentAssignments;
nicolasScore = (decimal)nicolasSum / currentAssignments;
zahirahScore = (decimal)zahirahSum / currentAssignments;
jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sohpiaScore+  "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

Console.WriteLine("----------------");
Console.WriteLine("CALCULATE FINAL GPA");

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int coousr1Grad = gradeA;
int coousr2Grad = gradeB;
int coousr3Grad = gradeB;
int coousr4Grad = gradeB;
int coousr5Grad = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += coousr1Grad * course1Credit;
totalGradePoints += coousr2Grad * course2Credit;
totalGradePoints += coousr3Grad * course3Credit;
totalGradePoints += coousr4Grad * course4Credit;
totalGradePoints += coousr5Grad * course5Credit;

decimal gradePointAvarage = totalGradePoints / (decimal)totalCreditHours;

int leadingDigit = (int)gradePointAvarage;
int firstDigit = (int)(gradePointAvarage * 10) % 10;
int secondDigit = (int)(gradePointAvarage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t{coousr1Grad}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{coousr2Grad}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{coousr3Grad}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{coousr4Grad}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{coousr5Grad}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t {leadingDigit}.{firstDigit}{secondDigit}");