
using System.Collections;





IEnumerable OddNumbers(int start, int end)
{
  int number = start;
  while (true)
  {

    if (number % 2 != 0)
    {
      if (number >= end)
        break;
      yield return number;

    }
    number++;
  }
}

IEnumerable Methods()
{
  yield return "PUT";
  yield return "POST";
  yield return "GET";
  yield return "DELETE";
}


foreach (var x in OddNumbers(10, 50))
{
  Console.WriteLine(x);
}