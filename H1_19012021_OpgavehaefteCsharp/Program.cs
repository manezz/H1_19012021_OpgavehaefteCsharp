using System;

namespace H1_19012021_OpgavehaefteCsharp
{
    class Values
    {
        readonly protected static double[][] menu =
        {
            new double[] { 1.1, 1.2, 1.3, 1.4, 1.5 },
            new double[] { 2.1, 2.2, 2.3 }
        };
    }

    class Methods : Values
    {
        protected void Fejl(string beskrivelse, string convert)
        {
            try
            {
                if (convert == "ToDouble")
                {
                    Convert.ToDouble(convert);
                }
                else if (convert == "ToInt32")
                {
                    Convert.ToInt32(convert);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fejl");
            }
        }
    }

    class Program : Methods
    {
        Program fejl = new Program();
        
        static void Main(string[] args)
        {
            double menuValg = 0;

            while (true)
            {
                Console.Clear();
                
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.Write($"Opgave {i + 1}:");

                    for (int j = 0; j < menu[i].Length; j++)
                    {
                        Console.Write($"  {menu[i][j]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                try
                {
                    Console.WriteLine("Vaelg en Opgave");
                    menuValg = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    menuValg = 0;
                    Console.WriteLine();
                    Console.WriteLine("Fejl");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();

                Console.WriteLine($"Opgave {menuValg}");
                Console.WriteLine();

                switch (menuValg)
                {
                    case 1.1:
                        {
                            double fahrenheit = 0;
                            double celsius = 0;

                            while (true)
                            {
                                
                                try
                                {
                                    Console.WriteLine("Intast decimaltal i Fahrenheit");
                                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Fejl");
                                    Console.ReadLine();
                                }
                            }

                            celsius = (fahrenheit - 32) * 5 / 9;

                            Console.WriteLine("Det er {0:f2} Celsius", celsius);

                            break;
                        }
                    case 1.2:
                        {
                            Console.WriteLine(1.1);
                            Console.WriteLine();

                            double celsius = 0;
                            double fahrenheit = 0;
                            double kelvin = 0;
                            double reaumur = 0;

                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Intast decimaltal i Celsius");
                                    celsius = Convert.ToDouble(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Fejl");
                                    Console.ReadLine();
                                }
                            }

                            fahrenheit = (celsius * 9 / 5) + 32;
                            kelvin = celsius + 273.15;
                            reaumur = celsius * 0.8;

                            Console.WriteLine("Det er {0:f2} Fahrenheit", fahrenheit);
                            Console.WriteLine("Det er {0:f2} Kelvin", kelvin);
                            Console.WriteLine("Det er {0:f2} Reaumur", reaumur);

                            break;
                        }
                    case 1.3:
                        {


                            break;
                        }

                    case 1.4:
                        {
                            double omsaetning = 0;
                            double variableOmkostninger = 0;
                            double fasteOmkostninger = 0;
                            double daekningsbidrag = 0;
                            double overskud = 0;
                            

                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Intast Omsaetning i kr.");
                                    omsaetning = Convert.ToDouble(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Fejl");
                                    Console.ReadLine();
                                }
                            }

                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Intast Variable Omkostninger i kr.");
                                    variableOmkostninger = Convert.ToDouble(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Fejl");
                                    Console.ReadLine();
                                }
                            }

                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Intast Faste Omkostninger i kr.");
                                    fasteOmkostninger = Convert.ToDouble(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Fejl");
                                    Console.ReadLine();
                                }
                            }

                            daekningsbidrag = omsaetning - variableOmkostninger;
                            overskud = daekningsbidrag - fasteOmkostninger;

                            Console.Write("         ");
                            Console.WriteLine("Omsaetning: {0:c2}", omsaetning);
                            Console.Write("(minus)  ");
                            Console.WriteLine("Variable Omkostninger: {0:c2}", variableOmkostninger);
                            Console.Write("         ");
                            Console.WriteLine("-----------------------------");
                            Console.Write("=        ");
                            Console.WriteLine("Daekningsbidrag: {0:c2}", daekningsbidrag);
                            Console.Write("(minus)  ");
                            Console.WriteLine("Faste omkostninger: {0:c2}", fasteOmkostninger);
                            Console.WriteLine("-----------------------------");
                            Console.Write("=        ");
                            Console.WriteLine("Overskud: {0:c2}", overskud);
                            Console.WriteLine();
                            Console.ReadLine();

                            break;
                        }
                }
            }

            Console.WriteLine("Tryk Enter for at afslutte");
            Console.ReadLine();
        }
    }
}
