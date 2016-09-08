using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of times to print \"Yay!\": ");
//print Yay to the screen the number of input value
            var times = Console.ReadLine();
           try{
            var name = int.Parse(times);
            var mynumber = 0;
            if(name <= 0){
                Console.WriteLine("You must enter a positive number");
               
            }
               while(mynumber < name){
               mynumber += 1;
                Console.WriteLine("Yay!");
                
            }
           }catch(FormatException) {
            Console.WriteLine("You must enter a whole number.");    
           }
            //keep track of how may times the loop has run
        }
    }
}