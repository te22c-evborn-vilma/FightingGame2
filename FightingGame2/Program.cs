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

  int hp2 = 100;
  string char2 = "Coco";

// int char2Name = generator.Next(2);

// if (char2Name == 0)
// {
//    char2 = "Coco";
// }
// else if (char2Name == 1)
// {
//    char2 = "Charlie";
// }
// else
// {
//    char2 = "Tom";
// }

  string art = "(/・<・)/     (ò_ó*)";
  Console.Clear();
  Console.WriteLine($"\n{char1} is fighting {char2}\n{art}");
  Console.WriteLine("\nPress any button to start the fight ^-^");
  Console.ReadLine();


  while (hp1 > 0 && hp2 > 0)
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n------ <<< NEW GAME >>> ------");
    Console.WriteLine($"{char1}: {hp1}hp {art} {char2}: {hp2}hp");
  
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    int char1DMG = generator.Next(25);
    hp2 -= char1DMG;
    hp2 = Math.Max(0, hp2);
    Console.WriteLine($"{char1} does {char1DMG} DMG on {char2}");

    Console.ForegroundColor = ConsoleColor.DarkRed;
    int char2DMG = generator.Next(25);
    hp1 -= char2DMG;
    hp1 = Math.Max(0, hp1);
    Console.WriteLine($"{char2} does {char2DMG} DMG on {char1}");

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

  Console.ForegroundColor = ConsoleColor.Black;
  Console.WriteLine("Would you like to play again?");

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
    Console.WriteLine("Sorry, I don't understand what you mean\nYou must start from the beginning");
    Fight();
  }
}

Console.WriteLine("\nPress any button to end");
Console.ReadKey();