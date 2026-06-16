using System.IO.Pipelines;

public class Practica_cafe
{
    public static void Main(String[]args)
    {
        int opcion, result = 0, SiOno;
        double precio_final;
        string nombre_producto;
        Console.WriteLine("1. Café");
        Console.WriteLine("2. Té");
        Console.WriteLine("3. Chocolate");
        Console.WriteLine("Ingrese una opción: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion) {
            case 1:
                nombre_producto = " Café";
                result = 5;
                break;
            case 2:
                nombre_producto = " Té";
                result = 4;
                break;
            case 3:
                nombre_producto = " Chocolate";
                result = 6;  
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;

        }
        Console.WriteLine ("¿Es estudiante? ");
        Console.WriteLine ("1. Si");
        Console.WriteLine("2. No");
        SiOno = int.Parse(Console.ReadLine());
        if (SiOno == 1)
        {
            
            precio_final = result - (result *0.10);
            
        }
        else
        {
            
            precio_final = result;
        }
        Console.WriteLine("Producto: " + nombre_producto);
        Console.WriteLine("Precio: S/.  " + result);
        Console.WriteLine("Total a pagar: S/. " + precio_final);

    }
}