using System;
using System.Collections.Generic;
using System.Linq;
using Sphinx.Riddles;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Riddle river = new Riddle("I have a mouth but do not speek, I have a bed but do not sleep, I run everywhere but go nowhere, what am I?", "river");
      Riddle nose = new Riddle("I can run but not walk. Wherever I go, thought follows behind. What am I?", "nose");
      Riddle sponge = new Riddle("I have holes in my top and bottom, my left and right, and my middle. But I still hold water. What am I?", "sponge");
      Riddle david = new Riddle("David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?", "david");
      Riddle fire = new Riddle("Give me food, and I will live; give me water, and I will die. What am I?", "fire");
      Riddle corn = new Riddle("It stalks the countryside with ears that can’t hear. What is it?", "corn");
      Riddle seven = new Riddle("I am an odd number. Take away a letter and I become even. What number am I?", "seven");
      Riddle envelope = new Riddle("What begins with an “e” and only contains one letter?", "envelope");
      Riddle queue = new Riddle("What word is pronounced the same if you take away four of its five letters?", "queue");
      Riddle coffin = new Riddle("The man who invented it doesn't want it. The man who bough it doesn't need it. The man who needs it dosen't know it. What is it?", "coffin");

      while (Riddle.riddles.Count > 0)
      {
        Console.WriteLine(Riddle.AskRiddle());
        string userAnswer = (Console.ReadLine()).ToLower();
        string expectedAnswer = Riddle.CheckAnswer();
        if (expectedAnswer == userAnswer)
        {
          Riddle.RemoveRiddle();
          Console.WriteLine("You answered correct!");
        }
        else
        { 
          Console.WriteLine("Sorry the answer was: " + expectedAnswer);
          Console.WriteLine("NOM NOM NOM");
          break;
        }
      }
      Console.WriteLine("You've solved all my puzzles! You get to live!");
    }
  }
}