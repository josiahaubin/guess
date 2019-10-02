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
              Console.WriteLine("Do you want to play again?");
              string answer = Console.ReadLine().ToLower();

              switch (answer)
              {
                case "yes":
                  running = true;
                  randomNum = rand.Next(1, 101);
                  break;

                case "no":
                  running = false;
                  break;
              }
            }
            else if (userInt > randomNum)
            {
              Console.WriteLine("Too high, guess again");
              Console.Beep();
            }
            else
            {
              Console.WriteLine("Too low, try again");
              Console.Beep();
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
