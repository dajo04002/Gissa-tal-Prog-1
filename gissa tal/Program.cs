using System;

namespace gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int slumpTal = slump.Next(100);
            int antalGissningar = 0;
            int gissning = 101;

            while(gissning != slumpTal)
            {
                Console.WriteLine("Guess the randomly generated number!");
                gissning = int.Parse(Console.ReadLine());
                antalGissningar ++;

                if(gissning > slumpTal){
                    Console.WriteLine("Too high");
                }
                else if(gissning < slumpTal){
                    Console.WriteLine("Too low");
                }
                else{
                    Console.WriteLine("You guessed correctly! You answered in: "+antalGissningar+" attempts");
                }
            }
        }
    }
}