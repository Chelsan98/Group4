using System;

namespace Group4
{

    class Program
    {
      
        static void Main(string[] args){
        bool finished = false;

        do
        // använda variabler:
        // A, B, C, D = Menu
        // R, T, C, K, P, S = Area & Volym
        // y = return
        // M = inches / cm / feet / yards / m [TEMPORÄR]
        // 1, 2, 3, = Switch: Ohms Lag.
        // 1, 2, 3, = Switch: Grader.
        // 1, 2, 3, = Switch: Hastighet.
        // ------------------------------
        // Kan man göra A & AA = New varible eller A & a
        {
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("|-------------------------------Start----------------------------|");                           
            Console.WriteLine("| A = Ohms Lag                                                   |");
            Console.WriteLine("| B = Grader                                                     |");
            Console.WriteLine("| C = Hastighet                                                  |");
            Console.WriteLine("| D = Area eller volym                                           |");
            Console.WriteLine("| M = inches / cm / feet / yards / m                             |");
            Console.WriteLine("|________________________________________________________________|");
            Console.Write("| Choose:  ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'A')
                {
                    Console.WriteLine("___________________________________________________________________");
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
                        Console.WriteLine("|___________________________________________________________________");
                        break;

                        case 2:
                        Console.WriteLine("| Fahrenheit");
                        Console.Write("| Ange: Antal Fahrenheit: ");
                        int fahren = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("| Kelvin = {0}", fahren - 32 * 5 / 9 + 273.15);
                        Console.WriteLine("| Celsius = {0}", fahren * 1.8 + 32);
                        Console.WriteLine("|___________________________________________________________________");
                        break;
                        
                        case 3:
                        Console.WriteLine("| Kelvin");
                        Console.Write("| Ange: Antal Kelvin: ");
                        int kelvin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("| Celsius = {0}", kelvin - 273.15);
                        Console.WriteLine("| Fahrenheit = {0}", (kelvin - 273.15) * 1.8 + 32 );
                        Console.WriteLine("|___________________________________________________________________");
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
             
                if (x == 'D')
                {
                    Console.WriteLine("Area eller volym");
                    Console.WriteLine("Skriv 1 för area eller 2 för volym");
                    int opinionAreaVolym = int.Parse(Console.ReadLine());

                    if (opinionAreaVolym == 1)
                    Console.WriteLine("Räkna ut area");
                    Console.WriteLine("________________________________________________________________________");
                    Console.WriteLine("Välj mellan Rektangel, triangel, cirkel, kub, pyramid eller sfär");
                    Console.WriteLine("Skriv r, t, c, k, p eller s för respektive form");
                    char a = char.Parse(Console.ReadLine());

                    if (a == 'r')
                    {

                        Console.WriteLine("Räkna ut arean på en rektangel = b*h");
                        Console.WriteLine("Skriv basen på rektangeln");
                        double rekB = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv höjden på rektangeln");
                        double rekH = double.Parse(Console.ReadLine());
                        double rekA = rekB * rekH;
                        Console.WriteLine("Area= " + rekA);

                    }

                  else if (a == 't')
                    {
                        // /2 funkar inte av någon anledning //
                        Console.WriteLine("Räkna ut arean på en triangel = b*h/2");
                        Console.WriteLine("Skriv basen på trianglen");
                        double triB= double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv höjden på trianglen");
                        double triH = double.Parse(Console.ReadLine());
                        double triA = triB * triH / 2;
                        Console.WriteLine("Arean på triangeln är: "+triA);
                    }

                   else if (a == 'c')
                    {
                        double pi = 3.14;
                        Console.WriteLine("Räkna ut arean på en cirkel = pi* r*r ");
                        Console.WriteLine("Skriv radien på cirklen");
                        double cirR =double.Parse(Console.ReadLine());
                        Console.WriteLine("Arean på cirklen är: "+pi *cirR *cirR);
                    }

                  else if (a == 'k')
                    {
                        Console.WriteLine("Räkna ut arean på en kub = 6 s*s för totala arean");
                        Console.ReadLine();
                    }

                   else if (a == 'p')
                    {
                        Console.WriteLine("Räkna ut arean på en pyramid = jäkligt krångligt kollar på det sen ");
                        Console.ReadLine();
                    }

                   else if (a == 's')
                    {
                        double pi = 3.14;
                        Console.WriteLine("Räkna ut arean på en sfär = 4pir*r ");
                        Console.WriteLine("__________________________________________");
                        Console.WriteLine("Skriv radien på sfären");
                        double sfärR=double.Parse (Console.ReadLine());
                        Console.WriteLine("Arean på sfären är: "+ 4*pi *sfärR * sfärR);

                    }
                    else
                    {
                        Console.WriteLine("Du skrev ett ogiltigt värde");
                    }


                    if (opinionAreaVolym == 2)
                    {
                        Console.WriteLine("Räkna ut volym");
                        Console.WriteLine("Välj mellan Rektangel/Rätblock, prisma, cylinder, kub, pyramid eller sfär");
                        Console.WriteLine("Skriv r, p, c, k, p eller s för respektive form");
                        char v = char.Parse(Console.ReadLine());
                        if (v == 'r')
                        {

                            Console.WriteLine("Räkna ut Volymen på en rektangel/rätblock = basytan (längden*bredden) * höjden");
                            Console.WriteLine("Skriv basytan");
                            double rekbasyta=double.Parse(Console.ReadLine());
                            Console.WriteLine("Skriv höjden");
                            double rekhöjd =double.Parse(Console.ReadLine());
                            Console.WriteLine("Volymen är: "+ rekbasyta *rekhöjd);
                           
                        }
                        else if (a == 'p')
                        {
                            Console.WriteLine("Räkna ut Volymen på en prisma = basyta * höjd");
                            Console.WriteLine("Skriv basytan");
                            double prismaB = double.Parse(Console.ReadLine());
                            Console.WriteLine("Skriv höjden");
                            double prismaH = double.Parse(Console.ReadLine());
                            Console.WriteLine("Svaret är: "+ prismaB *prismaH);
                        }

                        else if (a == 'c')
                        {
                            Console.WriteLine("Räkna ut Volymen på en cylinder = basytan(pi*r*r) * höjden");
                            Console.WriteLine("Skriv basytan");
                            double cylinderB = double.Parse(Console.ReadLine());
                            Console.WriteLine("Skriv höjden");
                            double cylinderH = double.Parse(Console.ReadLine());
                            Console.WriteLine("Svaret är: " + cylinderB * cylinderH);
                        }

                        else if (a == 'k')
                        {
                            Console.WriteLine("Räkna ut Volymen på en kub = ");
                            Console.ReadLine();
                        }

                        else if (a == 'p')
                        {
                            Console.WriteLine("Räkna ut Volymen på en pyramid = ");
                            Console.ReadLine();
                        }

                        else if (a == 's')
                        {
                            Console.WriteLine("Räkna ut Volymen på en sfär = ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Du skrev ett ogiltigt värde");
                        }


                    }

                }
                // -----------------------------------------------------------------------------------------------
                // skriv in 1 få ut 4 känns budget
                // ideal: användaren väljer x till y värde  istället för 1:4
                if (x == 'M')
                    Console.WriteLine("_____________________________________________________________________");
                    Console.WriteLine("| Välj mellan | inches | cm | feet | yards | m |                    |"); 
                    Console.WriteLine("| 1) Inches                                                         |");
                    Console.WriteLine("| 2) Cm                                                             |");
                    Console.WriteLine("| 3) Feet                                                           |");
                    Console.WriteLine("| 4) Yards                                                          |");
                    Console.WriteLine("| 5) Meter                                                          |");
                    Console.WriteLine("|___________________________________________________________________|");
                    Console.Write("| Choose:  ");
                    int opinionMesure = int.Parse(Console.ReadLine());
                    switch (opinionMesure){
                        case 1:
                        double inches;
                        Console.Write("| Skriv in: Antal Inches: ");
                        inches = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("| CM = {0}", inches * 2.54);
                        Console.WriteLine("| Feet = {0}", inches / 12);
                        Console.WriteLine("| Yards = {0}", inches / 36);
                        Console.WriteLine("| Meters = {0}", inches / 39.37);
                        Console.WriteLine("|___________________________________________________________________");
                        break;

                        case 2:
                        double cm;
                        Console.Write("| Skriv in: Antal Inches: ");
                        cm = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("| Inches = {0}", cm * 2.54);
                        Console.WriteLine("| Feet = {0}", cm / 12);
                        Console.WriteLine("| Yards = {0}", cm / 36);
                        Console.WriteLine("| Meters = {0}", cm / 39.37);
                        Console.WriteLine("|___________________________________________________________________");
                        break;

                        case 3:
                        double feet;
                        feet = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("| Inches = {0}", feet * 2.54);
                        Console.WriteLine("| CM = {0}", feet / 12);
                        Console.WriteLine("| Yards = {0}", feet / 36);
                        Console.WriteLine("| Meters = {0}", feet / 39.37);
                        Console.WriteLine("|___________________________________________________________________");
                        break;

                        case 4:
                        double yards;
                        yards = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("| Inches = {0}", yards * 2.54);
                        Console.WriteLine("| CM = {0}", yards / 12);
                        Console.WriteLine("| Yards = {0}", yards / 36);
                        Console.WriteLine("| Meters = {0}", yards / 39.37);
                        Console.WriteLine("|___________________________________________________________________");
                        break;

                        case 5:
                        double m;
                        m = Convert.ToDouble(Console.ReadLine());
                        break;
                    }

                // -----------------------------------------------------------------------------------------------
              
                 

                 
                
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
