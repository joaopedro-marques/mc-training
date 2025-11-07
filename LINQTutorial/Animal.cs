class Animal
{
  public string Name { get; set; }
  public double Height { get; set; }
  public double Weight { get; set; }
  public int AnimalID { get; set; }

  public Animal(string name = "NoName",
  double weight = 0, double height = 0)
  {
    Name = name;
    Weight = weight;
    Height = height;
  }

  public override string ToString() => $"Name: {Name}, Weight: {Weight}, Height: {Height}";
}