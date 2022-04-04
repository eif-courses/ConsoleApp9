// See https://aka.ms/new-console-template for more information

using ConsoleApp9.Models;

var pets = new List<Dog>();

pets.Add(new HaskyDog{
  Age = 5,
  Name = "Hasky"
});

pets.Add(new ToyDog
{
  Age = 2,
  Name = "Paw Dog"
});



Console.WriteLine("Pick your pet enter option number");
for (int i = 0; i < pets.Count; i++)
{
  Console.WriteLine($"{i+1}. {pets[i].Name}");
}

string? input = Console.ReadLine();
int option;
int.TryParse(input, out option);


var result = pets[option-1];

if (result is ToyDog)
{
  Console.WriteLine("===================================");
  Console.WriteLine("Toy dog ab le to Bark only.");
  Console.WriteLine("===================================");
  var temp = result as ToyDog;
  temp?.Bark();
}
else
{
  
    Console.WriteLine("===================================");
    Console.WriteLine("Real dog able to Bark and eat.");
    Console.WriteLine("===================================");
  var temp = result as HaskyDog;
  temp?.Bark();
  temp?.Eat();
}



Func<int, int, string> SetCoordinates = (x, y) => { return $"X: {x}, Y: {y}"; };

Console.WriteLine(SetCoordinates(2, 3));

SetCoordinates = (x, y) => Execute(x, y);

Console.WriteLine(SetCoordinates(5, 5));


SetCoordinates = (x, y) => Divide(x, y);

Console.WriteLine(SetCoordinates(5, 5));


static string Execute(int x, int y)
{
  return "Only x: "+x.ToString();
}

static string Divide(int x, int y)
{
  return y > 0 ? "Division: "+(x / y).ToString() : 0.ToString(); 
}







