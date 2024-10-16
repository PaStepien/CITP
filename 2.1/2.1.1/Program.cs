using System;


class Program
{
  static void Main()
  {
    string filePath = "exercises-data.csv";

    Dictionary<int, string>? exercises = ConvertCsvToDictionary(filePath);

    if (exercises != null)
    {
      string longestTitle = getDictionaryLongestTitle(exercises);
      Console.WriteLine("The longest title is: " + longestTitle);

      PrintNumberOfWordsInTitle(exercises);
      SaveToANewCsvFile(exercises);
    }


  }


  static Dictionary<int, string> ConvertCsvToDictionary(string filePath)
  {

    if (!File.Exists(filePath))
    {
      Console.WriteLine("File does not exist.");
      return new Dictionary<int, string>();
    }

    using (StreamReader reader = new StreamReader(filePath))
    {
      try
      {
        string line;
        string[] splittedLine;
        int idCounter = 0;

        Dictionary<int, string> exercises = new Dictionary<int, string>();
        while ((line = reader.ReadLine()) != null)
        {
          splittedLine = line.Split(',');
          int id = int.Parse(splittedLine[0]);
          string title = splittedLine[1];
          exercises.Add(id, title);
          idCounter++;
        }

        if (idCounter == exercises.Count)
        {
          return exercises;
        }
        else
        {
          Console.WriteLine("There are duplicate IDs");
          return new Dictionary<int, string>();
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("Error: " + e.Message);
        return new Dictionary<int, string>();
      }

    }
  }

  static string getLongestTitle(Dictionary<int, string> exercises)
  {
    string longestTitle = "";
    foreach (string title in exercises.Values)
    {
      if (title.Length > longestTitle.Length)
      {
        longestTitle = title;
      }
    }

    return longestTitle;

  }

  static string getDictionaryLongestTitle(Dictionary<int, string> dictionary)
  {
    // return dictionary.Values.OrderByDescending(value => value.Length).First();
    return dictionary.Values.OrderBy(value => value.Length).Last();
  }

  static void PrintNumberOfWordsInTitle(Dictionary<int, string> dictionary)
  {
    foreach (var kvp in dictionary)
    {
      int id = kvp.Key;
      string title = kvp.Value;

      string[] words = title.Split(' ');

      Console.WriteLine("ID " + id + " word length: " + words.Length);
    }
  }

  static void SaveToANewCsvFile(Dictionary<int, string> dictionary)
  {
    string newFilePath = "exercises-new-data.csv";
    using (StreamWriter writer = new StreamWriter(newFilePath))
    {
      foreach (var kvp in dictionary)
      {
        int id = kvp.Key;
        string title = kvp.Value.Replace("\"", string.Empty);
        string[] wordsInTitle = title.Split(" ");
        foreach (string word in wordsInTitle)
        {
          writer.WriteLine($"{id}, {word}");
        }
      }
    }
  }


}