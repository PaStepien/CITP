public class Person
{
  public int Age { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public int CourseId { get; set; }

  public override string ToString()
  {
    return $"Name={Name},Age={Age},Email={Email},CourseId={CourseId}";
  }
}
