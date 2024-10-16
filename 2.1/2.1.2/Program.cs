using System;


class Program
{
  static void Main()
  {

    Console.WriteLine("Give your input");

    string yourInput = Console.ReadLine();

    string filteredInput = FilterInput(yourInput);
    double result = CountTheInput(filteredInput);

    Console.WriteLine("Your input" + filteredInput);
    Console.WriteLine("Your result" + result);

  }


  static string FilterInput(string input)
  {
    input = input.Trim();

    char[] elements = input.ToCharArray();

    List<char> permittedElements = new List<char>();

    List<char> permittedChars = new List<char> { '+', '*', '-', '/' };

    foreach (char character in elements)
    {
      if (char.IsDigit(character) || permittedChars.Contains(character))
      {
        permittedElements.Add(character);
      }
    }

    return string.Join("", permittedElements);
  }


  static double CountTheInput(string filteredInput)
  {
    if (filteredInput.Length == 0)
    {
      return 0;
    }

    Stack<double> elementsStack = new Stack<double>();

    char[] elements = filteredInput.ToCharArray();


    foreach (char value in elements)
    {
      if (char.IsDigit(value))
      {
        double valueToPush = Decimal.ToDouble(value) - '0';
        elementsStack.Push(valueToPush);
      }
      else
      {

        double elementTwo = elementsStack.Pop();
        double elementOne = elementsStack.Pop();


        double result = Calculator(elementOne, elementTwo, value);
        elementsStack.Push(result);
      }
    }

    return elementsStack.ElementAt(0);
  }

  static double Calculator(double num1, double num2, char op)
  {
    double result = 0;
    switch (op)
    {
      case '+':
        result = num1 + num2;
        return result;  // Return the result after this operation
      case '-':
        result = num1 - num2;
        return result;
      case '*':
        result = num1 * num2;
        return result;
      case '/':
        // Handle division by zero
        if (num2 == 0)
        {
          throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
      default:
        return result;
    }
  }



}