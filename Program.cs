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
            Console.Write("| Choose: ");
            var opinion = (Console.ReadLine());
                if (opinion == "1")
                {
                  
                        Console.WriteLine("Ohms Lag");
                        var opinionOhm = (Console.ReadLine());
                    {


                        Console.WriteLine("R * I = U");


                        Console.WriteLine("U / R = I");


                        Console.WriteLine("U / I = R");
                    }
                      
                        
                
               
                Console.WriteLine("Grader");
                var opinionGrad = (Console.ReadLine());
              
                    Console.WriteLine("Celius");
                 
                    Console.WriteLine("Kelvin");
                  
                    Console.WriteLine("Fahrenheit");
                  
                }
                
                Console.WriteLine("Times");
                var opinionTime = (Console.ReadLine());
               
                
               
                Console.WriteLine("Volym eller area?");
                var opinionVolArea = (Console.ReadLine());
              
                    Console.WriteLine("Volym");
                    var opinionVolym = (Console.ReadLine()); 
                  
                        Console.WriteLine("Rectangle Volym");
                       
                        Console.WriteLine("Triangle Volym");
                      
                        Console.WriteLine("Cricle Volym");
                      
                        Console.WriteLine("Cube Volym");
                     
                        Console.WriteLine("error");
                    
                 
                    Console.WriteLine("Area");
                    var opinionArea = (Console.ReadLine());
                { 
                      
                        Console.WriteLine("Rectangle Volym");
                       
                        Console.WriteLine("Triangle Area");
                       
                        Console.WriteLine("Cricle Area");
                       
                        Console.WriteLine("Cube Area");
                       
                        Console.WriteLine("error");
                    }
                
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
