using System;

class Program
{
  public static void Main (string[] args)
  {
    void questions(int question)
    {
      if (question == 1)
      {
        Console.WriteLine("What is 7 * 4?");
        
        string answer1 = Console.ReadLine(); // It will asked to put an answer

        if (answer1 == "28")
        {
          Console.WriteLine("Correct!"); // Putting an answer will make sure it's correct
        }
        else
        {
          Console.WriteLine("Incorrect."); // Putting any answer will make it wrong
        }
      }
    }
    
    questions(1);
    
  }
}
