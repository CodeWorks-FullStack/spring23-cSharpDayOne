namespace cSharpDayOne.Repositories;

public class FakeDB
{
  public List<Cat> Cats;

  public FakeDB()
  {
    Cats = new List<Cat>();
    Cats.Add(new Cat("Georgie", "Grey & White", 5, 8, 0, 1));
    Cats.Add(new Cat("Gopher", "Black", 2, 6, 4, 2));
    Cats.Add(new Cat("Bella", "Brown", 8, 2, 30, 3));
    Cats.Add(new Cat("Tiger", "Orange & White", 13, 2, 100, 4));
  }
}
