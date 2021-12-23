using System;

namespace Group4
{
    class Program
    {
        static void Main(string[] args){
        bool finished = false;
        do
        {
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("|Start                                                           |");                           
            Console.WriteLine("|A = Ohms Lag                                                    |");
            Console.WriteLine("|B = Grader                                                      |");
            Console.WriteLine("|C = Hastighet                                                   |");
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
                        double n1, n2, result;
                        Console.WriteLine("Spänning uträknare");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.WriteLine("Ange: Strömmen: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ange: Resistans: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine("{0} Är spänningen. ",result);
                        Console.WriteLine("|__________________________________________________________________");
                        break;

                        case 2:
                        double resultStröm, n3, n4;
                        Console.WriteLine("Ström uträknare");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("Ange: spänningen: ");
                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ange: Resistans: ");
                        n4 = Convert.ToInt32(Console.ReadLine());
                        resultStröm = n3 / n4;
                        Console.WriteLine("{0} Är Strömmen. ", resultStröm);
                        Console.WriteLine("|__________________________________________________________________");
                        break;

                        case 3:
                        double n5, n6, resultRes; 
                        Console.WriteLine("| Resistans uträknare.");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("| Ange: Spänningen: ");
                        n5 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("| Ange: Strömmen: ");
                        n6 = Convert.ToInt32(Console.ReadLine());
                        resultRes = n5 / n6;
                        Console.WriteLine("| {0} Är Resistans. ",resultRes);
                        Console.WriteLine("|__________________________________________________________________");
                        break;
                    }
                }
                if (x == 'B')
                {
                    Console.WriteLine("Grader");
                }

                if (x == 'C')
                {
                    Console.WriteLine("___________________________________________________________________");
                    Console.WriteLine("|----------------------------Hastighet-----------------------------|");
                    Console.WriteLine("| 1 = Sträckan / Distans                                           |");
                    Console.WriteLine("| 2 = Hastighet                                                    |");
                    Console.WriteLine("| 3 = Tiden                                                        |");
                    Console.WriteLine("|__________________________________________________________________|");
                    int opinionSVT = int.Parse(Console.ReadLine());
                    switch (opinionSVT)
                    {
                        case 1:
                        double n1, n2, result;
                        Console.WriteLine("Räkna ut sträckan");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.WriteLine("Ange: Hastighet: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ange: Tiden: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine("{0} Är sträckan. ", result);
                        Console.WriteLine("|__________________________________________________________________");
                        break;

                        case 2:
                        break;
                        
                        case 3:
                        break;
                    }
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
