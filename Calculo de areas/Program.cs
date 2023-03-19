using System;

namespace Calculo_de_areas
{
    class Program
    {
        /// <summary>
        /// main program for calculate area to diferent geometric figures
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try {
                bool exit = false;

                while (!exit)
                {

                    Console.WriteLine("Seleccione la figura de la cual desea calcular el área:");
                    Console.WriteLine("1. Círculo");
                    Console.WriteLine("2. Rectángulo");
                    Console.WriteLine("3. Salir del programa");

                    string optionString = Console.ReadLine();
                    int option = 0;
                    bool isValidNumber=false;

                    try
                    {
                        option = Int32.Parse(optionString);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("La opción ingresada no es válida. Por favor, ingrese una opción numérica.");
                        continue;
                    }


                    if (option == 1)
                    {
                        double radio = 0;

                        do
                        {
                            Console.WriteLine("Ingrese el radio del círculo: ");
                            string radioString = Console.ReadLine();

                            isValidNumber = Double.TryParse(radioString, out radio);
                            if (!isValidNumber)
                            {
                                Console.WriteLine("Error: Debe ingresar un número válido.");
                            }
                            else if (radio <= 0)
                            {
                                Console.WriteLine("Error: El radio debe ser mayor que cero.");
                                isValidNumber = false;
                            }
                        } while (!isValidNumber);

                        GeometricFigure figure = new Circle(radio);
                        figure.ShowInformation();
                        figure.CalculateArea();
                        figure.ShowResult();

                    }
                    else if (option == 2)
                    {
                        double baseRectangulo = 0;
                        double altura = 0;
                        isValidNumber = false;
                        do
                        {
                            Console.WriteLine("Ingrese la base del rectángulo: ");
                            string baseString = Console.ReadLine();

                            isValidNumber = Double.TryParse(baseString, out baseRectangulo);
                            if (!isValidNumber)
                            {
                                Console.WriteLine("Error: Debe ingresar un número válido.");
                            }
                            else if (baseRectangulo <= 0)
                            {
                                Console.WriteLine("Error: La base debe ser mayor que cero.");
                                isValidNumber = false;
                            }
                        } while (!isValidNumber);

                        isValidNumber = false;
                        do
                        {
                            Console.WriteLine("Ingrese la altura del rectángulo: ");
                            string alturaString = Console.ReadLine();

                            isValidNumber = Double.TryParse(alturaString, out altura);
                            if (!isValidNumber)
                            {
                                Console.WriteLine("Error: Debe ingresar un número válido.");
                            }
                            else if (baseRectangulo <= 0)
                            {
                                Console.WriteLine("Error: La base debe ser mayor que cero.");
                                isValidNumber = false;
                            }

                        } while (!isValidNumber);

                        GeometricFigure figure = new Rectangle(baseRectangulo, altura);
                        figure.ShowInformation();
                        figure.CalculateArea();
                        figure.ShowResult();
                    }
                    else if (option == 3)
                    {
                        exit = true;
                        Console.WriteLine("Muchas Gracias por usar el programa.");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Se presento un problema en el programa.");
            }
        } 
    }
}
