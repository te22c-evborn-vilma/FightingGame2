using System;

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Hi and welcome to my fighting game!");
Fight();

static void Fight()                                     //metod
{
  Console.WriteLine("Please write your character's name ^-^");

  Random generator = new Random();

  int hp1 = 100;
  string char1 = Console.ReadLine();
  int char1DMG = 0;

  int hp2 = 100;
  string char2 = "Coco";
  int char2DMG = 0;

  string art = "(/・<・)/     (ò_ó*)";
  Console.Clear();
  Console.WriteLine($"\n{char1} is fighting {char2}\n{art}");
  Console.WriteLine("\nPress ENTER to start the fight ^-^");
  Console.ReadLine();

  while (hp1 > 0 && hp2 > 0)
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n------ <<< NEW GAME >>> ------");
    Console.WriteLine($"{char1}: {hp1}hp {art} {char2}: {hp2}hp");
    

    Console.WriteLine("Press p to punch or k to kick the other fighter");
    string answer1 = Console.ReadLine();

    if (answer1 == "k")
    {
      char1DMG = generator.Next(5, 15);
      hp2 -= char1DMG;
      answer1 = "kicked";
    }
    else if (answer1 == "p")
    {
      char1DMG = generator.Next(15, 25);
      hp2 -= char1DMG;
      answer1 = "punched";
    }
    else
    {
      Console.WriteLine("Sorry, that won't work. Press ENTER to start from the beginning");
      Console.ReadLine();
      Console.Clear();
      Fight();
    }
      
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    hp2 = Math.Max(0, hp2);
    Console.WriteLine($"{char1} {answer1} {char2} and did {char1DMG} DMG");

    Console.ForegroundColor = ConsoleColor.DarkRed;
    string char2Action = "did nothing";
    int char2RDMG = generator.Next(2);
    if (char2RDMG == 0)
    {
      char2DMG = generator.Next(5, 15);
      hp1 -= char2DMG;
      char2Action = "kicked";
    }
    else if (char2RDMG == 1)
    {
      char2DMG = generator.Next(15, 25);
      hp1 -= char2DMG;
      char2Action = "punched";
    }
    hp1 = Math.Max(0, hp1);
    Console.WriteLine($"{char2} {char2Action} {char1} and did {char2DMG} DMG");

    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\nPress any button to continue the fight");
    Console.ReadKey();
  }

  Console.ForegroundColor = ConsoleColor.Black;
  Console.Clear();
  Console.WriteLine("\n- The fight is over -\n");

  if (hp1 == 0 && hp2 == 0)
  {
    Console.WriteLine("--- It's a tie! ---");
  }
  else if (hp1 == 0)
  {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"--- The winner is {char2}! ---");
    Console.WriteLine("        ＜（＾－＾）＞");
  }
  else
  {
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"--- The winner is {char1}! ---");
    Console.WriteLine("        （~＾ O ＾）~");
  }
  
  PlayAgain();

  static void PlayAgain()
  {
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\nWould you like to play again?");

    string playAgain = Console.ReadLine();
    playAgain = playAgain.ToLower();
    
    if (playAgain == "yes")
    {
      Console.Clear();
      Fight();
    }
    else if (playAgain == "no")
    {
      Console.Clear();
      Console.WriteLine($"\nThank you for playing! (/^-^)/");
    }
    else
    {
      Console.Clear();
      Console.WriteLine("Sorry, I don't understand what you mean\nPlease try again");
      PlayAgain();
    }
  }
}

Console.WriteLine("\nPress any button to end");
Console.ReadKey();