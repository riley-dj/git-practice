using System;

class Program
{
  public static void Main (string[] args)
  {
    Console.WriteLine("pick a number between one and two");
    int input = Convert.ToInt32(Console.ReadLine());
    if(input == 1)
    {
      Console.WriteLine("you have chosen: " + input + " ;)");
    }
  }
}