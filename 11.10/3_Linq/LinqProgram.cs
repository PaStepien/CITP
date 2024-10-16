using System.Linq;



var query = Data.GetPersonData();

var q2 = query.Join(Data.GetCourses(), p => p.CourseId, c => c.Id, (p, c) => new { p.Name, CourseName = c.Name, p.Age });

foreach (var e in query.MyWhere(x => x.CourseId == 1).MySelect(x => x.Name))
{
  Console.WriteLine(e);
};

foreach (var e in q2)
{
  //Console.WriteLine(e);
}

foreach (var e in query.Select(x => x.Name).OrderBy(x => x))
{
  // Console.WriteLine(e);
}

foreach (var e in query.GroupBy(x => x.CourseId).OrderBy(x => x.Key))
{
  // Console.WriteLine(e.Key);
  //Console.WriteLine(e.Count());
  //Console.WriteLine();
};

foreach (var e in q2.Select(x => new { x.Name, x.Age }))
{

  // Console.WriteLine(e);
};

static class LinqExt
{
  public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> fn)
  {
    foreach (var e in source)
    {
      if (fn(e))
      {
        yield return e;
      }
    }
  }

  public static IEnumerable<U> MySelect<T, U>(this IEnumerable<T> source, Func<T, U> fn)
  {
    foreach (var e in source)
    {
      yield return fn(e);
    }
  }
}