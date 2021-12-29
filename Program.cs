using System;

namespace Group4
{
    class Program
    {
        static void Main(string[] args){
        bool finished = false;
        do
        {
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("|-------------------------------Start----------------------------|");                           
            Console.WriteLine("| A = Ohms Lag                                                   |");
            Console.WriteLine("| B = Grader                                                     |");
            Console.WriteLine("| C = Hastighet                                                  |");
            Console.WriteLine("| D = Area eller volym                                           |");
            Console.WriteLine("|________________________________________________________________|");
            Console.Write("| Choose:  ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'A')
                {
                    Console.WriteLine("__________________________________________________________________");
                    Console.WriteLine("|--------------------------Ohms Lag Menu--------------------------|");
                    Console.WriteLine("| 1 = Spänning                                                    |");
                    Console.WriteLine("| 2 = Ström                                                       |");
                    Console.WriteLine("| 3 = Resistans                                                   |");
                    Console.WriteLine("|_________________________________________________________________|");
                    Console.Write("| Choose:  ");
                    int opinion = int.Parse(Console.ReadLine());
                    switch(opinion)
                    {
                        case 1:
                        double n1, n2, resultSpänn;
                        Console.WriteLine("| Spänning uträknare");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("| Ange: Strömmen: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("| Ange: Resistans: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultSpänn = n1 * n2;
                        Console.WriteLine("| {0} Är spänningen. ",resultSpänn);
                        Console.WriteLine("|__________________________________________________________________");
                        break;

                        case 2:
                        double n3, n4, resultStröm;
                        Console.WriteLine("| Ström uträknare");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("| Ange: spänningen: ");
                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ange: Resistans: ");
                        n4 = Convert.ToInt32(Console.ReadLine());
                        resultStröm = n3 / n4;
                        Console.WriteLine("| {0} Är Strömmen. ", resultStröm);
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
                // -----------------------------------------------------------------------------------------------
                if (x == 'B')
                {

                    Console.WriteLine(" ___________________________________________________________________");
                    Console.WriteLine("| Grader");
                    Console.WriteLine("| 1 Celsius");
                    Console.WriteLine("| 2 Fharen");
                    Console.WriteLine("| 3 Kelvin");
                    Console.WriteLine("|___________________________________________________________________");
                    Console.Write("| Choose:  ");
                    int opinionGrade = int.Parse(Console.ReadLine());
                    switch (opinionGrade)
                    {
                        case 1:
                        Console.WriteLine("| Celius");
                        Console.Write("| Ange: Antal Celsius: ");
                        int celsius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("| Kelvin = {0}", celsius + 273);
                        Console.WriteLine("| Fahrenheit = {0}", celsius * 18 / 10 + 32);
                        break;

                        case 2:
                        Console.WriteLine("| Fahrenheit");
                        Console.Write("| Ange: Antal Fahrenheit: ");
                        int fahren = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("| Kelvin = {0}", fahren - 32 * 5 / 9 + 273.15);
                        Console.WriteLine("| Celsius = {0}", fahren * 1.8 + 32);
                        break;
                        
                        case 3:
                        Console.WriteLine("| Kelvin");
                        Console.Write("| Ange: Antal Kelvin: ");
                        int kelvin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("| Celsius = {0}", kelvin - 273.15);
                        Console.WriteLine("| Fahrenheit = {0}", (kelvin - 273.15) * 1.8 + 32 );
                        break;

                    }
                }
                // -----------------------------------------------------------------------------------------------
                if (x == 'C')
                {
                    Console.WriteLine("___________________________________________________________________");
                    Console.WriteLine("|----------------------------Hastighet-----------------------------|");
                    Console.WriteLine("| 1 = Sträckan / Distans                                           |");
                    Console.WriteLine("| 2 = Hastighet                                                    |");
                    Console.WriteLine("| 3 = Tiden                                                        |");
                    Console.WriteLine("|__________________________________________________________________|");
                    Console.Write("| Choose:  ");
                    int opinionSVT = int.Parse(Console.ReadLine());
                    switch (opinionSVT)
                    {
                        case 1:
                        double n1, n2, result;
                        Console.WriteLine("| Räkna ut sträckan");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("| Ange: Hastighet: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("| Ange: Tiden: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine("| {0} Är sträckan. ", result);
                        Console.WriteLine("|__________________________________________________________________");
                        break;

                        case 2:
                        double n3, n4, result2;
                        Console.WriteLine("| Räkna ut Hastigheten");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("| Ange: Sträckan: ");
                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("| Ange: Tiden: ");
                        n4 = Convert.ToInt32(Console.ReadLine());
                        result2 = n3 / n4;
                        Console.WriteLine("| {0} Är Hastigheten. ", result2);
                        Console.WriteLine("|__________________________________________________________________");
                        break;
                        
                        case 3:
                        double n5, n6, result3;
                        Console.WriteLine("| Räkna ut Tiden");
                        Console.WriteLine("|__________________________________________________________________");
                        Console.Write("| Ange: Sträckan / Distansen: ");
                        n5 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("| Ange: Medel Hastigheten: ");
                        n6 = Convert.ToInt32(Console.ReadLine());
                        result3 = n5 / n6;
                        Console.WriteLine("| {0} Mintuer. ", result3);
                        Console.WriteLine("|__________________________________________________________________");
                        break;
                    }
                }
                // -----------------------------------------------------------------------------------------------
                if (x == 'D')
                {
                    Console.WriteLine("Area eller volym");
                    Console.WriteLine("Skriv 1 för area eller 2 för volym");
                    int opinionArea = int.Parse(Console.ReadLine());
                    switch (opinionArea){
                            case 1:
                                Console.WriteLine("Välj mellan Rektangel, triangel, cirkel, kub, pyramid eller sfär");
                                Console.WriteLine("Skriv r, t, c, k, p eller s för respektive form");
                                char a = char.Parse(Console.ReadLine());
                               
                            if (a == 'r')
                                     { 
                                    Console.WriteLine("Räkna ut arean på en rektangel = b*h");
                                    Console.ReadLine();
                                
                                    }

                            if (a == 't')
                                {
                                    Console.WriteLine("Räkna ut arean på en triangel = b*h/2");
                                    Console.ReadLine(); 
                                }
                          
                            if (a == 'c')
                                {
                                    Console.WriteLine("Räkna ut arean på en cirkel = ");
                                    Console.ReadLine();
                            }

                            if (a == 'k')
                            {
                                Console.WriteLine("Räkna ut arean på en kub = ");
                                Console.ReadLine();
                            }

                            if (a == 'p')
                            {
                                Console.WriteLine("Räkna ut arean på en pyramid = ");
                                Console.ReadLine();
                            }

                            if (a == 's')
                            {
                                Console.WriteLine("Räkna ut arean på en sfär = ");
                                Console.ReadLine();
                            }
                            else { Console.WriteLine("Du skrev ett ogiltigt värde"); 
                            }
                            break;

                           
                                   
            
                           
                    }
                    } 

                    if (x == 'V'){
                    int opinionVolym = int.Parse(Console.ReadLine());
                    switch (opinionVolym){

                        
                    }
                    }
                
                // -----------------------------------------------------------------------------------------------

            Console.Write("| Restart (Y/N) answer: ");
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
