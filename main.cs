using System;

class Program {
  public static void Main (string[] args) {
    /*
    for (int i = 1; i <= 100; i++){
      if (i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
      } else if ( i % 3 == 0) {
        Console.WriteLine("Fizz");
      } else if ( i % 5 == 0) {
        Console.WriteLine("Buzz");
      } else {
        Console.WriteLine(i);
      }
      
    }
    */

    Console.Write("Please select a number between 1-6: ");
    int numb1 = Convert.ToInt32(Console.ReadLine());
    

    switch(numb1){
      case 1: 
      Console.WriteLine("Archimedes");
      break;
      case 2:
      Console.WriteLine("Thor");
      break;
      case 3:
      Console.WriteLine("Ripley");
      break;
      case 4:
      Console.WriteLine("Tristan");
      break;
      case 5:
      Console.WriteLine("Jalapeno");
      break;
      case 6:
      Console.WriteLine("Athena");
      break;
      default:
      Console.WriteLine("I miss you Pippin, Callie and Maverick!");
      break;
    }
  }
}