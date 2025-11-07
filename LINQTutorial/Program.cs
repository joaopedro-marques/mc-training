using System.Collections;
using LINQTutorial;

Console.WriteLine("Hello, World!");
QueryStringArray();
QueryIntArray();
QueryArrayList();
QueryCollection();
QueryAnimalData();

static void QueryStringArray()
{
  string[] dogs = { "Kitty", "Spot", "Rover", "Rover",
  "Bryan Griffin", "Scooby Doo", "OldYeller", "Rin Tin Tin",
  "Charlie B. Barkin", "LAssie", "Snoopy" };

  var dogSpaces = from dog in dogs
                  where dog.Contains(" ")
                  orderby dog descending
                  select dog;

  foreach (var i in dogSpaces)
  {
    Console.WriteLine(i);
  }
  Console.WriteLine();
}

static void QueryIntArray()
{
  int[] nums = { 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };
  var gt20 = from num in nums where num > 20 orderby num select num;

  foreach (var i in gt20)
  {
    Console.WriteLine(i);
  }
  Console.WriteLine();
  Console.WriteLine($"Get type: {gt20.GetType()}");
  var listGT20 = gt20.ToList<int>();
  var arrayGT20 = gt20.ToArray();

  nums[0] = 40;

  foreach (var i in gt20)
  {
    Console.WriteLine(i);
  }
  Console.WriteLine();

}


static void QueryArrayList()
{
  ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name = "Heidi",
                Height = .8,
                Weight = 18},

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };

  // You have to convert the ArrayList into 
  // an IEnumerable
  var famAnimalEnum = famAnimals.OfType<Animal>();

  var smAnimals = from animal in famAnimalEnum
                  where animal.Weight <= 90
                  orderby animal.Name
                  select animal;

  var haviestAnimal = from animal in famAnimalEnum
                      orderby animal.Weight descending
                      select animal;

  foreach (var animal in smAnimals)
  {
    Console.WriteLine("{0} weighs {1}lbs",
        animal.Name, animal.Weight);
  }

  foreach (var animal in haviestAnimal)
  {
    Console.WriteLine("{0} weighs {1}lbs",
        animal.Name, animal.Weight);
  }

  Console.WriteLine();

}

static void QueryCollection()
{
  var animalList = new List<Animal>()
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200 }
            };

  var bigDogs = from dog in animalList
                where (dog.Weight > 70) && (dog.Height > 25)
                select dog;

  foreach (var dog in bigDogs)
  {
    Console.WriteLine("A {0} weights {1} lbs", dog.Name, dog.Weight);
  }
}

static void QueryAnimalData()
{
  Animal[] animals = new[]
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                AnimalID = 2},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

  Owner[] owners = new[]
  {
                new Owner{Name = "Doug Parks",
                OwnerID = 1},
                new Owner{Name = "Sally Smith",
                OwnerID = 2},
                new Owner{Name = "Paul Brooks",
                OwnerID = 3}
            };

  var nameHeight = from a in animals
                   select new
                   {
                     a.Name,
                     a.Height
                   };
  Array arrNameHeight = nameHeight.ToArray();
  foreach (var i in arrNameHeight)
  {
    Console.WriteLine(i.ToString());
  }
  Console.WriteLine();

  var innerJoin = from animal in animals join owner in owners on animal.AnimalID equals owner.OwnerID select new { OwnerName = owner.Name, AnimalName = animal.Name };
  
  foreach (var i in innerJoin)
  {
    Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);
  }
  Console.WriteLine();

  var groupJoin = from owner in owners
                  orderby owner.OwnerID
                  join animal in animals on owner.OwnerID equals animal.AnimalID into ownerGroup
                  select new
                  {
                    Owner = owner.Name,
                    Animals = from owner2 in ownerGroup orderby owner2.Name select owner2
                  };

  

  foreach (var i in groupJoin)
  {

    Console.WriteLine(i.Owner);
    foreach(var animal in i.Animals)
    {
      Console.WriteLine("\t{0}", animal.Name);
    }
  }
}


