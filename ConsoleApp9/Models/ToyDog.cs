using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
  public class ToyDog : Dog, IBark
  {
    public void Bark()
    {
      Console.WriteLine($"Toy Dog age: {Age}");
      Console.WriteLine($"{Name} is barking!!! woof!!!");
    }
  }
}
