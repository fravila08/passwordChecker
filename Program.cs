// See https://aka.ms/new-console-template for more information
using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength= 8;
      int score = 0;
      string uppercase="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase="abcdefghijklmnopqrstuvwxyz";
      string digits="1234567890";
      string specialChars="!@#$%^&*";
      Console.WriteLine("Enter your desired password");
      string password= Console.ReadLine();
      if (password.Length >= minLength){
        score++;
      }
    //   target.IndexOfAny(list.ToCharArray()) != -1;
      if(uppercase.IndexOfAny(password.ToCharArray())!= -1){
        score++;
      }
      if (lowercase.IndexOfAny(password.ToCharArray())!= -1){
        score++;
      }
      if (digits.IndexOfAny(password.ToCharArray())!= -1){
        score++;
      }
      if(specialChars.IndexOfAny(password.ToCharArray())!= -1){
        score++;
      }
      switch(score){
        case 5:
          Console.WriteLine("Extremely Strong");
        break;
        case 4:
          Console.WriteLine("Extremely Strong");
        break;
        case 3:
          Console.WriteLine("Strong");
        break;
        case 2:
          Console.WriteLine("Medium");
        break;
        case 1:
          Console.WriteLine("Weak");
        break;
        default:
          Console.WriteLine("Password does not meat standards");
        break;
      }
    }
  }
}
