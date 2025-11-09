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