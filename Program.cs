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
            Console.WriteLine("|                          Main menu                             |");
            Console.WriteLine("|                  Välj mellan Alternativen                      |");
            Console.WriteLine("|________________________________________________________________|");                         
            Console.WriteLine("| A = Ohms Lag                                                   |");
            Console.WriteLine("| B = Grader                                                     |");
            Console.WriteLine("| C = Hastighet                                                  |");
            Console.WriteLine("| D = Area eller volym                                           |");
            Console.WriteLine("| M = inches / cm / feet / yards / m                             |");
            Console.WriteLine("|________________________________________________________________|");
            Console.Write("| Choose:  ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'A' || x == 'a')
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
                        Console.Write("| Ange: Resistans: ");
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

                if (x == 'B' || x == 'b')
                {

                    Console.WriteLine(" ___________________________________________________________________");
                    Console.WriteLine("|                              Grader                               |");
                    Console.WriteLine("|         Välj det värdet du har så räknas resterande värden ut     |");
                    Console.WriteLine("|___________________________________________________________________|");
                    Console.WriteLine("| 1) Celsius                                                        |");
                    Console.WriteLine("| 2) Fharen                                                         |");
                    Console.WriteLine("| 3) Kelvin                                                         |");
                    Console.WriteLine("|___________________________________________________________________|");
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

                if (x == 'C' || x == 'c')
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

                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
             
                if (x == 'd' || x == 'D')
                {
                    Console.WriteLine("__________________________________________________________________");
                    Console.WriteLine("|                      Area eller volym                           |");
                    Console.WriteLine("| 1) Area                                                         |");
                    Console.WriteLine("| 2) Volym                                                        |");
                    Console.WriteLine("|_________________________________________________________________|");
                    Console.Write("| Choose:  ");
                    int opinionAreaVolym = int.Parse(Console.ReadLine());
                    switch(opinionAreaVolym)
                    {

                    case 1:
                    Console.WriteLine("__________________________________________________________________");
                    Console.WriteLine("|                          Räkna ut area                          |");
                    Console.WriteLine("| Rektangel = R & r                                               |");
                    Console.WriteLine("| Triangel..= T & t                                               |");
                    Console.WriteLine("| Pyramid...= P & p                                               |");
                    Console.WriteLine("| Cirkel....= C & c                                               |");
                    Console.WriteLine("| Sfär......= S & s                                               |");
                    Console.WriteLine("| Kub.......= K & k                                               |");
                    Console.WriteLine("|_________________________________________________________________|");
                    Console.Write("| Choose:  ");
                    char a = char.Parse(Console.ReadLine());
                    if (a == 'r' || a == 'R')
                    {
                        Console.WriteLine("| Räkna ut arean på en rektangel.");
                        Console.Write("| Ange basen på rektangeln: ");
                        double rekB = double.Parse(Console.ReadLine());
                        Console.Write("| Ange höjden på rektangeln: ");
                        double rekH = double.Parse(Console.ReadLine());
                        double rekA = rekB * rekH;
                        Console.WriteLine("| Arean på Rektangel: "+ rekA);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (a == 't' || a == 'T')
                    {
                        Console.WriteLine("Räkna ut arean på en triangel.");
                        Console.Write("| Ange basen på trianglen: ");
                        double triB= double.Parse(Console.ReadLine());
                        Console.Write("| Ange höjden på trianglen: ");
                        double triH = double.Parse(Console.ReadLine());
                        double triA = (triB * triH) / 2;
                        Console.WriteLine("| Arean på triangeln är: "+ triA);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (a == 'p'|| a == 'P')
                    {
                        // b upphöjt till 2 + 4 (en halv gånger b gånger h)
                        Console.WriteLine("| Räkna ut surface-arean på en pyramid. ");
                        Console.Write("| Ange Base Lenght: ");
                        double BaseL = double.Parse(Console.ReadLine());
                        Console.Write("| Ange Base Width: ");
                        double BaseW = double.Parse(Console.ReadLine());
                        Console.Write("| Ange Pyramid Height: ");
                        double Height = double.Parse(Console.ReadLine());
                        double resultPyramidArea = (BaseL * BaseW) 
                        + (BaseL * Math.Sqrt(Math.Pow(BaseW / 2, 2) + Math.Pow(Height, 2))) 
                        + (BaseW * Math.Sqrt(Math.Pow(BaseL / 2, 2) + Math.Pow(Height, 2)));
                        Console.WriteLine("| Arean på surface-arean är: "+ resultPyramidArea);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                     else if (a == 's' || a == 'S')
                    {
                        double pi = 3.14;
                        Console.WriteLine("| Räkna ut arean på en sfär.");
                        Console.Write("| Skriv radien på sfären: ");
                        double sfärR = double.Parse (Console.ReadLine());
                        Console.WriteLine("| Arean på sfären är: "+ 4 * pi * sfärR * sfärR);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (a == 'k' || a == 'K')
                    {
                        Console.WriteLine("kuben");
                        
                    }
                    else
                    {
                        Console.WriteLine("Du skrev ett ogiltigt värde");
                    }
                    break;
                    case 2:
                    Console.WriteLine("__________________________________________________________________");
                    Console.WriteLine("|                              Volym                              |");
                    Console.WriteLine("| Rektangel = R & r                                               |");
                    Console.WriteLine("| Triangel..= T & t                                               |");
                    Console.WriteLine("| Pyramid...= P & p                                               |");
                    Console.WriteLine("| Cirkel....= C & c                                               |");
                    Console.WriteLine("| Sfär......= S & s                                               |");
                    Console.WriteLine("| Kub.......= K & k                                               |");
                    Console.WriteLine("|_________________________________________________________________|");
                    Console.Write("| Choose:  ");
                    char m = char.Parse(Console.ReadLine());
                    if (m == 'r' || m == 'R')
                    {
                        Console.WriteLine("| Räkna ut Volymen på en rektangel/rätblock.");
                        Console.Write("| Ange basytan: ");
                        double rekBase = double.Parse(Console.ReadLine());
                        Console.Write("| Ange höjden: ");
                        double rekHeight = double.Parse(Console.ReadLine());
                        Console.WriteLine("| Volymen är: "+ rekBase * rekHeight);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (m == 'p' || m == 'P')
                    {
                         Console.WriteLine("| Räkna ut Volymen på en prisma.");
                        Console.Write("| Ange basytan: ");
                        double prismaB = double.Parse(Console.ReadLine());
                        Console.Write("| Ange höjden: ");
                        double prismaH = double.Parse(Console.ReadLine());
                        Console.WriteLine("| Volymen på prisma är: "+ prismaB * prismaH);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (m == 'c' || m == 'C')
                    {
                        Console.WriteLine("| Räkna ut Volymen på en cylinder.");
                        Console.WriteLine("| Ange basytan");
                        double cylinderB = double.Parse(Console.ReadLine());
                        Console.WriteLine("| Ange höjden");
                        double cylinderH = double.Parse(Console.ReadLine());
                        Console.WriteLine("| Volymen på cylindern är: " + cylinderB * cylinderH);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (m == 'k' || m == 'K')
                    {
                        Console.WriteLine("| Räkna ut Volymen på en kub. ");
                        Console.Write("| Ange Base/Lengh: ");
                        double CubeV = double.Parse(Console.ReadLine());
                        double CubeResult = CubeV * 3;
                        Console.WriteLine("| Volymen på kuben är: " + CubeResult);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else if (m == 'p' || m == 'P')
                    {
                        Console.WriteLine("Räkna ut Volymen på en pyramid.");
                        Console.Write("| Ange Base Lenght: ");
                        double BaseL = double.Parse(Console.ReadLine());
                        Console.Write("| Ange Base Width: ");
                        double BaseW = double.Parse(Console.ReadLine());
                        Console.Write("| Ange Pyramid Height: ");
                        double HeightH = double.Parse(Console.ReadLine());
                        double resultPyramidVolym = ((BaseL * BaseW * HeightH) / 3);
                        Console.WriteLine("| Volymen på pyramid är: " + resultPyramidVolym);
                        Console.WriteLine("|_________________________________________________________________");
                    }
                    else
                    {
                        Console.WriteLine("Du skrev ett ogiltigt värde");
                    }
                    break;
                    }
                }

                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


                if (x == 'M' || x == 'm')
                {
                    Console.WriteLine("_____________________________________________________________________");
                    Console.WriteLine("| Välj mellan | inches | cm | feet | yards | m |                    |");
                    Console.WriteLine("|___________________________________________________________________|"); 
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
                        double meter;
                        meter = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("| Inches = {0}", meter * 2.54);
                        Console.WriteLine("| CM = {0}", meter / 12);
                        Console.WriteLine("| Feet = {0}", meter / 36);
                        Console.WriteLine("| Yards = {0}", meter / 39.37);
                        Console.WriteLine("|___________________________________________________________________");
                        break;
                    }
                }

            Console.Write("| Restart (Y/N) answer: ");
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine("|_________________________________________________________________");
            if (b =='y' || b == 'Y')
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