// Marcos Cervantes Matamoros
// Perfeccionamiento Ejercicio 1

/*
1.- Crea un programa que pida al usuario un número, luego una operación (+, -, 
*, /) y luego otro número, y muestre el resultado de esa operación.

Se debe repetir hasta que el usuario teclee "fin" en vez del primer número.

También debe permitir las siguientes operaciones adicionales:

- "Elevado a", que se podrá indicar con ^ y con **

- "Raíz cuadrada", que se indicará con una R, y que no pedirá un segundo 
número, sino que mostrará la raíz cuadrada del primero que se ha introducido.

- Raíz de orden N, que se indicará con "raizn" seguido del índice de la raiz: 
"8 raizn 3" querría decir "calcular la raíz cúbica de 8".

Si el usuario teclea una operación incorrecta, debe mostrar un mensaje de 
aviso, recordándole las operaciones correctas. No debe fallar (sino mostrar un 
mensaje de aviso) si el usuario intenta dividir entre cero, calcular la raíz de 
un número negativo u operar con textos, en vez de con números.
*/

using System;
public class PerfeccioamientoEjerccio1
{
    public static void OpcionesPermitidas()
    {
        Console.WriteLine();
        Console.WriteLine("Para sumar: +");
        Console.WriteLine("Para restar: -");
        Console.WriteLine("Para multiplicar: *");
        Console.WriteLine("Para dividir: /");
        Console.WriteLine("Para elevar por otro numero: ^ o **");
        Console.WriteLine("Para la raiz cuadrada: R");
        Console.WriteLine("Para hacer la raiz de orden N: raizn");
    }

    public static void Main()
    {
        try {
            string num1, operation;
            double num2;
            Console.Write("Introduce el primer numero: ");
            num1 = Console.ReadLine();

            while (num1.ToLower() != "fin")
            {
                Console.Write("Introduce el operador: ");
                operation = Console.ReadLine().ToLower();

                if (operation == "r")
                {
                    if (Convert.ToDouble(num1) < 0)
                        Console.WriteLine("Error, estas intentando hacer" +
                            " la raiz de un numero negativo");
                    else
                        Console.WriteLine("{0}{2} = {1}", num1,
                                Math.Sqrt(Convert.ToDouble(num1)),
                                operation);
                }
                else
                {
                    switch (operation)
                    {
                        case "+":
                            Console.Write("Introduce el segundo numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0} {3} {1} = {2}", num1, num2,
                                (Convert.ToDouble(num1) + num2), operation);
                            break;
                        case "-":
                            Console.Write("Introduce el segundo numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0} {3} {1} = {2}", num1, num2,
                                (Convert.ToDouble(num1) - num2), operation);
                            break;
                        case "*":
                            Console.Write("Introduce el segundo numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0} {3} {1} = {2}", num1, num2,
                                (Convert.ToDouble(num1) * num2), operation);
                            break;
                        case "/":
                            Console.Write("Introduce el segundo numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 == 0)
                                Console.WriteLine("Error, estas intentando " +
                                    "dividir por 0");
                            else
                                Console.WriteLine("{0} {3} {1} = {2}", num1, num2,
                                   (Convert.ToDouble(num1) / num2));
                            break;
                        case "^":
                        case "**":
                            Console.Write("Introduce el segundo numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0} {3} {1} = {2}", num1, num2,
                                Math.Pow(Convert.ToDouble(num1), num2), operation);
                            break;
                        case "raizn":
                            if (Convert.ToDouble(num1) < 0)
                                Console.WriteLine("Error, estas intentando hacer" +
                                    " la raiz de un numero negativo");
                            else
                            {
                                Console.Write("Introduce el segundo numero: ");
                                num2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} {3} {1} = {2}", num1, num2,
                                    Math.Pow(Convert.ToDouble(num1),
                                    (1 / Convert.ToDouble(num2))), operation);
                            }
                            break;

                        default:
                            Console.WriteLine("Las opciones permitidas son: ");
                            OpcionesPermitidas();
                            break;
                    }
                }
                Console.Write("Introduce el primer numero: ");
                num1 = Console.ReadLine();
            }
        }
        catch
        {
            Console.WriteLine("Error, intentando operar con textos");
        }
    }
}
