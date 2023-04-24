
using System.ComponentModel.DataAnnotations;

namespace cSharpDayOne.Models;



public class Cat
{
  // NOTE only want a constructor for today as we will create a fake DB
  public Cat(string name, string color, int age, int livesLeft, int birdsEaten, int id)
  {
    Name = name;
    Color = color;
    Age = age;
    LivesLeft = livesLeft;
    BirdsEaten = birdsEaten;
    Id = id;
  }

  public int Id { get; set; }
  public string Name { get; set; }
  public string Color { get; set; }
  public int Age { get; set; }

  [Range(0, 9)] // example of data annotation, applies to next line
  public int LivesLeft { get; set; } = 9;
  public int BirdsEaten { get; private set; }

  void eat(string food)
  {
    if (food == "bird")
    {
      BirdsEaten++;
    }
  }



}