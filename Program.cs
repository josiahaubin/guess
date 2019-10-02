using System;

namespace guess
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      int randomNum = rand.Next(1, 101);

      bool running = true;

      while (running)
      {
        try
        {
          Console.WriteLine("Pick a number between 1-100.");
          string userNum = Console.ReadLine();

          if (int.TryParse(userNum, out int userInt))
          {
            if (userInt == randomNum)
            {
              Console.WriteLine("Congrats, that is correct!");
              Console.Beep();
              running = false;
            }
            else if (userInt > randomNum)
            {
              Console.WriteLine("Too high, guess again");
            }
            else
            {
              Console.WriteLine("Too low, try again");
            }
          }

        }
        catch (Exception e)
        {
          Console.WriteLine(e);
        }
      }
    }
  }
}
