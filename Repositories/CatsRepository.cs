namespace cSharpDayOne.Repositories;

public class CatsRepository
{
  // NOTE this will work similar when we have a real db but will change a little
  private readonly FakeDB _db;

  public CatsRepository(FakeDB db)
  {
    _db = db;
  }

  internal Cat Create(Cat catData)
  {
    int catId = _db.Cats[_db.Cats.Count - 1].Id + 1; //NOTE just some weirdness for unique id's today
    Cat newCat = new Cat(catData.Name, catData.Color, catData.Age, catData.LivesLeft, catData.BirdsEaten, catId);
    _db.Cats.Add(newCat);
    return newCat;
  }

  internal List<Cat> Get()
  {
    return _db.Cats;
  }

  internal Cat GetOne(int catId)
  {
    Cat cat = _db.Cats.Find(c => c.Id == catId);
    return cat;
  }

  internal void Remove(int catId)
  {
    // _db.Cats = _db.Cats.FindAll(c => c.Id != catId);
    Cat cat = this.GetOne(catId);
    _db.Cats.Remove(cat);
  }
}
