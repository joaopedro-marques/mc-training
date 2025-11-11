// // Random dice = new Random();
// // int roll = dice.Next();
// // Console.WriteLine(roll);

// // int number = 7;
// // string text = "seven";

// // Console.WriteLine(number);
// // Console.WriteLine();
// // Console.WriteLine(text);
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);


// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largervalue;

largervalue = Math.Max(firstValue, secondValue);
Console.WriteLine(largervalue);

Console.WriteLine("------------");
Console.WriteLine("Desafio");
Random number = new();
int number1 = number.Next(1, 101);

Console.WriteLine($"Esse foi o número: {number1} e essa a raiz quadrada: {Math.Sqrt(number1):F2}");

Console.WriteLine("------------");
Console.WriteLine("Conditional If-else");

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

roll1 = 1;
roll2 = 2;
roll3 = 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  if ((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("You rolled triples! + 6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! + 2 bonus to total!");
    total += 2;
  }

}

if (total >= 16)
{
  Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
  Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
  Console.WriteLine("You win a trip for two!");
}
else
{
  Console.WriteLine("You win a kitten!");
}

Console.WriteLine("------------");
Console.WriteLine("Challenge business logic");
Random random = new();
int daysUntilExpiration = random.Next(21);
daysUntilExpiration = 0;
if (daysUntilExpiration <= 10)
{
  if (daysUntilExpiration == 0)
  {
    Console.WriteLine("Your subscription has expired.");
  }
  else if (daysUntilExpiration == 1)
  {
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%");
  }
  else if (daysUntilExpiration <= 5)
  {
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
    Console.WriteLine("Renew now to save 10%!");
  }
  else
  {
    Console.WriteLine("You subscriptions will expire soon. Renew Now!");
  }
}
