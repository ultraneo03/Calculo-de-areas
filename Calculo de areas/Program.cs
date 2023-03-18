using System;

namespace Calculo_de_areas
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try {
                bool salida = false;

                while (!salida)
                {

                    Console.WriteLine("Seleccione la figura de la cual desea calcular el área:");
                    Console.WriteLine("1. Círculo");
                    Console.WriteLine("2. Rectángulo");
                    Console.WriteLine("3. Salir del programa");

                    string opcionString = Console.ReadLine();
                    int opcion = 0;
                    bool esNumeroValido=false;

                    try
                    {
                        opcion = Int32.Parse(opcionString);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("La opción ingresada no es válida. Por favor, ingrese una opción numérica.");
                        continue;
                    }


                    if (opcion == 1)
                    {
                        double radio = 0;

                        do
                        {
                            Console.WriteLine("Ingrese el radio del círculo: ");
                            string radioString = Console.ReadLine();

                            esNumeroValido = Double.TryParse(radioString, out radio);
                            if (!esNumeroValido)
                            {
                                Console.WriteLine("Error: Debe ingresar un número válido.");
                            }
                            else if (radio <= 0)
                            {
                                Console.WriteLine("Error: El radio debe ser mayor que cero.");
                                esNumeroValido = false;
                            }
                        } while (!esNumeroValido);

                        FiguraGeometrica figura = new Circulo(radio);
                        figura.MostrarInformacion();
                        figura.CalcularArea();
                        figura.MostrarResultado();

                    }
                    else if (opcion == 2)
                    {
                        double baseRectangulo = 0;
                        double altura = 0;
                        esNumeroValido = false;
                        do
                        {
                            Console.WriteLine("Ingrese la base del rectángulo: ");
                            string baseString = Console.ReadLine();

                            esNumeroValido = Double.TryParse(baseString, out baseRectangulo);
                            if (!esNumeroValido)
                            {
                                Console.WriteLine("Error: Debe ingresar un número válido.");
                            }
                            else if (baseRectangulo <= 0)
                            {
                                Console.WriteLine("Error: La base debe ser mayor que cero.");
                                esNumeroValido = false;
                            }
                        } while (!esNumeroValido);

                        esNumeroValido = false;
                        do
                        {
                            Console.WriteLine("Ingrese la altura del rectángulo: ");
                            string alturaString = Console.ReadLine();

                            esNumeroValido = Double.TryParse(alturaString, out altura);
                            if (!esNumeroValido)
                            {
                                Console.WriteLine("Error: Debe ingresar un número válido.");
                            }
                            else if (baseRectangulo <= 0)
                            {
                                Console.WriteLine("Error: La base debe ser mayor que cero.");
                                esNumeroValido = false;
                            }

                        } while (!esNumeroValido);

                        FiguraGeometrica figura = new Rectangulo(baseRectangulo, altura);
                        figura.MostrarInformacion();
                        figura.CalcularArea();
                        figura.MostrarResultado();
                    }
                    else if (opcion == 3)
                    {
                        salida = true;
                        Console.WriteLine("Muchas Gracias por usar el programa.");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("El valor ingresado no es valido.");
            }
        } 
    }
}
