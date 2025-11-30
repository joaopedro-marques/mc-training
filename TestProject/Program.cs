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

Console.WriteLine("--------");

string[] fraudulentOrdersIDs = new string[3];

fraudulentOrdersIDs[0] = "A123";
fraudulentOrdersIDs[1] = "B456";
fraudulentOrdersIDs[2] = "C789";

// fraudulentOrdersIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrdersIDs[0]}");
Console.WriteLine($"First: {fraudulentOrdersIDs[1]}");
Console.WriteLine($"First: {fraudulentOrdersIDs[2]}");

fraudulentOrdersIDs[0] = "F000";

Console.WriteLine($"Resigned first: {fraudulentOrdersIDs[0]}");

string[] fraudulentOrdersIDs1 = ["A123", "B456", "F789"];

Console.WriteLine($"First: {fraudulentOrdersIDs1[0]}");
Console.WriteLine($"First: {fraudulentOrdersIDs1[1]}");
Console.WriteLine($"First: {fraudulentOrdersIDs1[2]}");

Console.WriteLine($"There are {fraudulentOrdersIDs.Length} fraudulent orders to process.");

int[] inventory = { 200, 300, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
  bin++;
  Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
  sum += item;
}

Console.WriteLine($"We have {sum} items in the inventory.");

Console.WriteLine("------------");
Console.WriteLine("Challenge array interaction");

string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string order in orders)
{
  if (order.StartsWith('B'))
    Console.WriteLine(order);
}

Console.WriteLine("-------------------");
Console.WriteLine("Training comments");

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets");
*/

/*
The following code creates five randoms OrderIds
to test the faurd detection process. OrderIDs consist
of a latter from A to E, and a three 
digit number. Ex:A123.
*/
Random random1 = new Random();
string[] orderIds2 = new string[5];
for (int i = 0; i < orderIds2.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIds2[i] = prefix + suffix;
}
foreach (var orderID in orderIds2)
{
  Console.WriteLine(orderID);
}

Console.WriteLine("------------");
Console
.
WriteLine(
  "Hello Example 1!"
)
  ;

string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

Console.WriteLine("--------");

Random dice2 = new Random();

int roll4 = dice.Next(1, 7);
int roll5 = dice.Next(1, 7);
int roll6 = dice.Next(1, 7);
int roll7 = dice.Next(1, 7);

int total2 = roll4 + roll5 + roll6;
Console.WriteLine($"Dice roll: {roll4} + {roll5} + {roll6} = {total}");

if ((roll4 == roll5) || (roll5 == roll3) || (roll4 == roll3))
{
  if ((roll4 == roll2) && (roll5 == roll3))
  {
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total2 += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
    total2 += 2;
  }
}
Console.WriteLine("-----------------");
Console.WriteLine("Challenge redeability");
/*
This code try to revese and find in a phrase how many time the character
'o' appears. 
*/
string initialPhrase = "The quick brown fox jumps over the lazy dog.";

char[] lettersPhrase = initialPhrase.ToCharArray();
Array.Reverse(lettersPhrase);

int letterCount = 0;

foreach (char letter in lettersPhrase)
{
  if (letter == 'o') 
  {
    letterCount++; 
  }
}

string finalPhrase = new String(lettersPhrase);

Console.WriteLine(finalPhrase);
Console.WriteLine($"'o' appears {letterCount} times.");

//Evaluate booean expressions to make decisions in C#..
Console.WriteLine(" -----------");
Console.WriteLine("a" == "A");
Console.WriteLine("a" == "a");
Console.WriteLine( 1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine(" -----------");
Console.WriteLine("a" != "A");
Console.WriteLine("a" != "a");
Console.WriteLine( 1 != 2);

myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine("-----------");
string paragram = "The quinck brom fox jumps over the laze dog.";
Console.WriteLine(!paragram.Contains("fox"));
Console.WriteLine(!paragram.Contains("cow"));

Console.WriteLine("-----------");
//Evaluate purchase discount
int saleAmount = 1001;
// int discount = saleAmout > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//Coin flip
Console.WriteLine("-----------");
int coin = random.Next(0, 2);
string result = coin == 0 ? "heads" : "tails";
Console.WriteLine($"You flipped {result}");

//Permission
string permission = "";
int level = 10;
if (level > 55)
  Console.WriteLine("Welcome, Super Admin user.");
else if (permission.Contains("Manager") && level >= 20)
  Console.WriteLine("Contact an admin for access");
else if (permission.Contains("Admin") || permission.Contains("Manager"))
  Console.WriteLine("Welcom, Admin user.");
else
  Console.WriteLine("You do not have sufficient privileges.");