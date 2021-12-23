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
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("|Start                                                           |");                           
            Console.WriteLine("|A = Ohms Lag                                                    |");
            Console.WriteLine("|B = Grader                                                      |");
            Console.WriteLine("|C = Time                                                        |");
            Console.WriteLine("|D = Area eller volym                                            |");
            Console.WriteLine("|________________________________________________________________|");
            Console.Write("| Choose:  ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'A')
                {
                    Console.WriteLine("Ohms Lag");
                    Console.WriteLine("1 = Spänning");
                    Console.WriteLine("2 = Ström");
                    Console.WriteLine("3 = Resistans");
                    int opinion = int.Parse(Console.ReadLine());
                    switch(opinion)
                    {
                        case 1:
                        int n1, n2, result;
                        Console.WriteLine("Spänning");
                        Console.WriteLine("Ange: Strömmen");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ange: Resistans");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine(result);
                        break;

                        case 2:
                        Console.WriteLine("Ström");
                        Console.Write("Ange: spänningen");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ange: Resistans");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 / n2;
                        Console.WriteLine(result);
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
