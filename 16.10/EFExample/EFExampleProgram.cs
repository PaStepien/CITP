// See https://aka.ms/new-console-template for more information
using DataLayer;

// var context = new NorthwindContext();
// var categories = context.Categories.Where(x => x.Id < 5).ToList();

var dataService = new DataService();

var categories = dataService.GetCategories();

foreach (var e in categories)
{
  Console.WriteLine(e.Name);
}