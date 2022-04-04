using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
  public class HaskyDog : Dog, IBark, IEat
  {
    public void Bark()
    {
      Console.WriteLine($"Dog age: {Age}");
      Console.WriteLine($"{Name} is barking!!! woof!!!");
    }

    public void Eat()
    {
      Console.WriteLine($"{Name} dog is EATING!!! NIAM NIAM!!!");
    }
  }
}
