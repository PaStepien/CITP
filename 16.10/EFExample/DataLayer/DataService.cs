
namespace DataLayer;

public class DataService : IDataService
{
  public List<Category> GetCategories()
  {
    var db = new NorthwindContext();
    return db.Categories.Where(x => x.Id < 5).ToList();
  }
}