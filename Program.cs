using System;

namespace Group4
{
    class Program
    {
        static void Main(string[] args)
        // enbart en test för att illustrera en potentiell design.
        // vet ej ifall detta fungerar error message "Try the new cross-platform PowerShell"

        {
        bool finished = false;
        do
        {
            Console.WriteLine("Start");
            Console.WriteLine("1 = Ohms Lag");
            Console.WriteLine("2 = Grader");
            Console.WriteLine("3 = Time");
            Console.WriteLine("4 = Area eller volym");
            Console.Write("| Choose: ");
            int opinion = int.Parse(Console.ReadLine());
            switch(opinion)
            {
                case 1:
                Console.WriteLine("Ohms Lag");
                int opinionOhm = int.Parse(Console.ReadLine());
                switch(opinionOhm){
                    case 1:
                    Console.WriteLine("R * I = U");
                    break;
                    case 2:
                    Console.WriteLine("U / R = I");
                    break;
                    case 3:
                    Console.WriteLine("U / I = R");
                    break;
                    default:
                    Console.WriteLine("error");
                }
                case 2:
                Console.WriteLine("Grader");
                int opinionGrad = int.Parse(Console.ReadLine());
                switch(opinionGrad){
                    case 1:
                    Console.WriteLine("Celius");
                    break;
                    case 2:
                    Console.WriteLine("Kelvin");
                    break;
                    case 3:
                    Console.WriteLine("Fahrenheit");
                    break;
                    default:
                    Console.WriteLine("error");
                }
                case 3:
                Console.WriteLine("Times");
                int opinionTime = int.Parse(Console.ReadLine());
                switch(opinionGrad){
                    case 1:
                    case 2:
                    case 3:
                    default:
                    Console.WriteLine("error");
                }
                case 4:
                Console.WriteLine("Volym eller area?");
                int opinionVolArea = int.Parse(Console.ReadLine());
                switch(opinionVolArea){
                    case 1:
                    Console.WriteLine("Volym");
                    int opinionVolym = int.Parse(Console.ReadLine());
                    switch(opinionVolym){
                        case 1:
                        Console.WriteLine("Rectangle Volym");
                        break;
                        case 2:
                        Console.WriteLine("Triangle Volym");
                        break;
                        case 3:
                        Console.WriteLine("Cricle Volym");
                        break;
                        case 4:
                        Console.WriteLine("Cube Volym");
                        break;
                        default:
                        Console.WriteLine("error");
                    }
                    case 2:
                    Console.WriteLine("Area");
                    int opinionArea = int.Parse(Console.ReadLine());
                        switch(opinionArea){
                        case 1:
                        Console.WriteLine("Rectangle Volym");
                        break;
                        case 2:
                        Console.WriteLine("Triangle Area");
                        break;
                        case 3:
                        Console.WriteLine("Cricle Area");
                        break;
                        case 4:
                        Console.WriteLine("Cube Area");
                        break;
                        default:
                        Console.WriteLine("error");
                    }
                    default:
                }


            }
            Console.Write("- Restart (Y/N) answer: ");
            char x = char.Parse(Console.ReadLine());
            if (x =='y' && x=='Y')
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
