using System; // Usamos esto para poder usar funciones básicas como Console.WriteLine y Console.ReadLine

class Program
{
    static void Main()
    {
        // Crear una caja (variable) para guardar el primer número
        int numero1;
        // Crear una caja (variable) para guardar el segundo número
        int numero2;
        // Crear una caja (variable) para guardar el resultado de la suma
        int resultado;

        // Pedimos al usuario que ingrese el primer número
        Console.Write("Ingresa el primer número: ");
        // Guardamos el número ingresado en la variable numero1. Usamos int.Parse para convertir el texto a número
        numero1 = int.Parse(Console.ReadLine());

        // Pedimos al usuario que ingrese el segundo número
        Console.Write("Ingresa el segundo número: ");
        // Guardamos el número ingresado en la variable numero2. Usamos int.Parse para convertir el texto a número
        numero2 = int.Parse(Console.ReadLine());

        // Sumamos los dos números y guardamos el resultado en la variable resultado
        resultado = numero1 + numero2;

        // Mostramos el resultado en la pantalla
        Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es " + resultado);

        // Esperamos a que el usuario presione una tecla antes de cerrar el programa
        Console.ReadKey();
    }
}