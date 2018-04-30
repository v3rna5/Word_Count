using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputString;
    private string _inputWord;

    public RepeatCounter (string inputString, string inputWord)
    {
      _inputString = inputString;
      _inputWord = inputWord;
    }

    public string GetInputString()
    {
      return _inputString;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }
    public int CountRepeats()
    {
      int wordCounter = 0;
      string newString = _inputString.ToUpper();
      string inputWord = _inputWord.ToUpper();
      string [] stringArray = newString.Split(' ');

      if (stringArray.Length <= 0 || inputWord.Length <= 0)
      {
        wordCounter = 0;
        } else
        {
          for (int i = 0; i < stringArray.Length; i++)
          {
            if (stringArray[i].IndexOf(inputWord) != -1)
            {
               Console.WriteLine(inputWord.Length);
               Console.WriteLine(stringArray[i].Length);
              if (stringArray[i].Contains(inputWord) && inputWord.Length == stringArray[i].Length)

              {
                wordCounter += 1;
              }

            }
          }
        }
        return wordCounter;
      }
    }
  }
