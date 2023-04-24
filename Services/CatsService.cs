namespace cSharpDayOne.Services;

public class CatsService
{

  private readonly CatsRepository _repo;

  public CatsService(CatsRepository repo)
  {
    _repo = repo;
  }

  internal Cat Create(Cat catData)
  {
    return _repo.Create(catData);
  }

  internal List<Cat> Get()
  {
    List<Cat> cats = _repo.Get();
    return cats;
  }

  internal Cat GetOne(int catId)
  {
    Cat cat = _repo.GetOne(catId);
    if (cat == null) throw new Exception($"no cat at id {catId}");
    return cat;
  }

  internal string Remove(int catId)
  {
    Cat cat = this.GetOne(catId);
    // IF we were worried about access control we could check for a creator too
    _repo.Remove(catId);
    return $"{cat.Name} was adopted";
  }
}


