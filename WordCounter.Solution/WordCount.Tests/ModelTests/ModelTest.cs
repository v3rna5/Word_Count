using Microsoft.VisualStudio.TestTools.UnitTesting;
 Using System.Collections.Generic;
using System;



namespace WordCounter.Tests
{
  [TestClass]
  public class ReapeatCounterTest
  {
    [TestMethod]
    public void Word_ContainsString_True()
    {
      // /Arrange
      String input = "dog";
      String input2 = "cat"; //change to a different word and test will fail
      //Act
      bool wordContains = (input.Contains(input2));
      //Assert
      Assert.AreEqual(true, wordContains);
      Console.WriteLine("Word Count: 1");
    }

    // User input a word first label form and a sentence on the second label form. The app will return how many inputted word matches regardless if it's upper or lowecase_
    [TestMethod]
    public void Word_IgnoreUpperLowerCase_True()
    {
      //Arrange
      String input1 = "AA";
      String input2 = "aa";
      //Act
      bool ignoreCase = (input1.ToUpper() == input2.ToUpper());
      //Assert
      Assert.AreEqual(true, ignoreCase);
      Console.WriteLine("Ignore Case");
    }

    [TestMethod]
    public void formValidation()
    {
      //Arrange
      int wordCount = 0;
      //Assert
      Assert.AreEqual(0, wordCount); // should pass
      Console.WriteLine("Count");

    }
  }
}
