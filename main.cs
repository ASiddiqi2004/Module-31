using System;

class Program {
  static void Main(string[] args)
    {
        Console.WriteLine("Enter message:");
        string message = Console.ReadLine();

        int length = message.Length;

        if (length > 140)
        {
            Console.WriteLine("Too long, please shorten to below 140 words.");
        }
        else
        {
            Console.WriteLine("This message is elligble.");
          }
      }
  }
  