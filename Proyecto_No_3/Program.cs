using System;

namespace Tarea3DesgloseDeDinero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fragmento();
        }

        static void fragmento()
        {
            int C100, C50, C20, C10, C5, C1; //Declaracion para billetes
            int M50, M25, M10, M5, M1;
            decimal CAN;
            double DOLARES, Q;
            C100 = C50 = C20 = C10 = C5 = C1 = 0;
            M50 = M25 = M10 = M5 = M1 = 0;
            string linea, x;
            float numDecimal;


            int options;


            Console.WriteLine("Elija una Opcion: ");
            Console.WriteLine("Opcion 1:Desglose con Billetes Y Monedas. ");
            Console.WriteLine("Opcion 2:Cambios de Dolares a Quetzales");
            x = Console.ReadLine();
            options = int.Parse(x);

            switch (options)
            {
                case 1:
                    Console.WriteLine("Ingrese una cantidad: ");
                    linea = Console.ReadLine();
                    CAN = decimal.Parse(linea);
                    string CANString = CAN.ToString();
                    CAN = decimal.Parse(linea);

                    if ((CAN >= 100))
                    {
                        C100 = (int)(CAN / 100);
                        CAN = CAN - (C100 * 100);
                    }
                    if ((CAN >= 50))
                    {
                        C50 = ((int)(CAN / 50));
                        CAN = CAN - (C50 * 50);
                    }

                    if ((CAN >= 20))
                    {
                        C20 = ((int)(CAN / 20));
                        CAN = CAN - (C20 * 20);
                    }

                    if ((CAN >= 10))
                    {
                        C10 = ((int)(CAN / 10));
                        CAN = CAN - (C10 * 10);

                    }
                    if ((CAN >= 5))
                    {
                        C5 = ((int)(CAN / 5));
                        CAN = CAN - (C5 * 5);

                    }
                    if ((CAN >= 1))
                    {
                        C1 = ((int)(CAN / 1));
                        CAN = CAN - (C1 * 1);

                    }

                    numDecimal = float.Parse("0," + CANString.Split('.')[1]); //Obteniendo los numeros decimales

                    //logica para desglosar las monedas
                    if ((numDecimal >= 50))
                    {
                        M50 = ((int)(numDecimal / 50));
                        numDecimal = numDecimal - (M50 * 50);
                    }

                    if ((numDecimal >= 25))
                    {
                        M25 = ((int)(numDecimal / 25));
                        numDecimal = numDecimal - (M25 * 25);
                    }

                    if ((numDecimal >= 10))
                    {
                        M10 = ((int)(numDecimal / 10));
                        numDecimal = numDecimal - (M10 * 10);

                    }
                    if ((numDecimal >= 5))
                    {
                        M5 = ((int)(numDecimal / 5));
                        numDecimal = numDecimal - (M5 * 5);

                    }
                    if ((numDecimal >= 1))
                    {
                        M1 = ((int)(numDecimal / 1));
                        numDecimal = numDecimal - (M1 * 1);

                    }

                    //monedas


                    Console.WriteLine("******BILLETES******");
                    Console.WriteLine($"BILLETES DE Q.100: " + (C100));
                    Console.WriteLine($"BILLETES DE Q.50: " + (C50));
                    Console.WriteLine($"BILLETES DE Q.20: " + (C20));
                    Console.WriteLine($"BILLETES DE Q.10: " + (C10));
                    Console.WriteLine($"BILLETES DE Q.5: " + (C5));
                    Console.WriteLine($"BILLETES DE Q.1: " + (C1));
                    Console.WriteLine("******MONEDAS******");
                    Console.WriteLine($"MONEDAS DE .50 = " + (M50));
                    Console.WriteLine($"MONEDAS DE .25 = " + (M25));
                    Console.WriteLine($"MONEDAS DE .10 = " + (M10));
                    Console.WriteLine($"MONEDAS DE .5 = " + (M5));
                    Console.WriteLine($"MONEDAS DE .1 = " + (M1));
                    break;
                case 2:
                    Console.WriteLine("Ingrese una cantidad en Dolares: ");
                    linea = Console.ReadLine();
                    DOLARES = double.Parse(linea);
                    Q = DOLARES * 7.72;
                    double quetzales;
                    Console.WriteLine("DOLARES: $." + DOLARES);
                    Console.WriteLine("******CAMBIO DE MONEDA******");
                    Console.WriteLine("Quetzales: Q." + Q);

                    quetzales = double.Parse(Q.ToString());
                    CANString = Q.ToString();

                    if ((quetzales >= 100))
                    {
                        C100 = (int)(quetzales / 100);
                        quetzales = quetzales - (C100 * 100);
                    }
                    if ((quetzales >= 50))
                    {
                        C50 = ((int)(quetzales / 50));
                        quetzales = quetzales - (C50 * 50);
                    }

                    if ((quetzales >= 20))
                    {
                        C20 = ((int)(quetzales / 20));
                        quetzales = quetzales - (C20 * 20);
                    }

                    if ((quetzales >= 10))
                    {
                        C10 = ((int)(quetzales / 10));
                        quetzales = quetzales - (C10 * 10);

                    }
                    if ((quetzales >= 5))
                    {
                        C5 = ((int)(quetzales / 5));
                        quetzales = quetzales - (C5 * 5);

                    }
                    if ((quetzales >= 1))
                    {
                        C1 = ((int)(quetzales / 1));
                        quetzales = quetzales - (C1 * 1);

                    }
                    numDecimal = float.Parse("0," + CANString.Split('.')[1]); //Obteniendo los numeros decimales

                    //logica para desglosar las monedas
                    if ((numDecimal >= 50))
                    {
                        M50 = ((int)(numDecimal / 50));
                        numDecimal = numDecimal - (M50 * 50);
                    }

                    if ((numDecimal >= 25))
                    {
                        M25 = ((int)(numDecimal / 25));
                        numDecimal = numDecimal - (M25 * 25);
                    }

                    if ((numDecimal >= 10))
                    {
                        M10 = ((int)(numDecimal / 10));
                        numDecimal = numDecimal - (M10 * 10);

                    }
                    if ((numDecimal >= 5))
                    {
                        M5 = ((int)(numDecimal / 5));
                        numDecimal = numDecimal - (M5 * 5);

                    }
                    if ((numDecimal >= 1))
                    {
                        M1 = ((int)(numDecimal / 1));
                        numDecimal = numDecimal - (M1 * 1);

                    }
                    Console.WriteLine("******BILLETES******");
                    Console.WriteLine($"BILLETES DE Q.100: " + (C100));
                    Console.WriteLine($"BILLETES DE Q.50: " + (C50));
                    Console.WriteLine($"BILLETES DE Q.20: " + (C20));
                    Console.WriteLine($"BILLETES DE Q.10: " + (C10));
                    Console.WriteLine($"BILLETES DE Q.5: " + (C5));
                    Console.WriteLine($"BILLETES DE Q.1: " + (C1));
                    Console.WriteLine("******MONEDAS******");
                    Console.WriteLine($"MONEDAS DE .50 = " + (M50));
                    Console.WriteLine($"MONEDAS DE .25 = " + (M25));
                    Console.WriteLine($"MONEDAS DE .10 = " + (M10));
                    Console.WriteLine($"MONEDAS DE .5 = " + (M5));
                    Console.WriteLine($"MONEDAS DE .1 = " + (M1));

                    break;

                default:
                    Console.WriteLine("Error en la opcion");
                    break;
            }

        }

    }
}
