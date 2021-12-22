using System;

namespace Group4
{
    class Program
    {
        static void Main(string[] args)
        // enbart en test för att illustrera en potentiell design.
        // vet ej ifall detta fungerar error message "Try the new cross-platform PowerShell"
        // case in case ser ej ut att fungera, If else får användas istället?

{
        bool finished = false;
        do
        {
            Console.WriteLine("Start");
            Console.WriteLine("1 = Ohms Lag");
            Console.WriteLine("2 = Grader");
            Console.WriteLine("3 = Time");
            Console.WriteLine("4 = Area eller volym");
            Console.Write(" Choose: ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'A')
                {
                    Console.WriteLine("Ohms Lag");
                    int opinion = int.Parse(Console.ReadLine());
                    switch(opinion)
                    {
                        case 1:
                        Console.WriteLine("Spänning");
                        break;

                        case 2:
                        Console.WriteLine("Ström");
                        break;

                        case 3:
                        Console.WriteLine("Resistans");
                        break;
                    }
                }



                if (x == 'B')
                {
                    Console.WriteLine("Grader");
                }
                if (x == 'C')
                {
                    Console.WriteLine("Time");
                }
                if (x == 'D')
                {
                    Console.WriteLine("Area eller volym");
                }


            Console.Write("- Restart (Y/N) answer: ");
            char b = char.Parse(Console.ReadLine());
            if (b =='y')
            {
                finished = false;
            }
            else 
            {
                finished = true;
            }
            } while (!finished);
        }
    }
}
