using System;
using System.Collections.Generic;


public class LowHigh
{
  public static void HighLow(int min, int max)
    {
      var rand = new Random();
      int numb = rand.Next(min, max);
      Console.WriteLine($"{numb}... is this your number?");
      string response = Console.ReadLine();
      if (response == "lower") 
      {
      HighLow(min,numb);
      } 
      else if (response == "higher")
      {
       HighLow(numb,max);
      }
      else
      {
        Console.WriteLine("Got it Dumb Human!");
      }
    }

  public static void Main()
  {
    Console.WriteLine("Pick a number, and Ill guess it.");
    Console.WriteLine("Lets Play!");

    int max= 100;
    int min= 0;
    HighLow(min,max);

    }

    // for (int i = 1; i > 0; i++)
    // {
    //   int numb = rand.Next(min, max);
    //   Console.WriteLine($"{numb}... is this your number?");
    //   Console.WriteLine("type correct, lower, or higher");
    //   string response = Console.ReadLine();
    //   if (response == "lower") 
    //   {
    //     max = numb;
    //   } 
    //   else if (response == "higher")
    //   {
    //     min = numb + 1;
    //   }
    //   else
    //   {
    //     Console.WriteLine("Ha! I Win!");
    //     break;
    //   }
    // }
  

}