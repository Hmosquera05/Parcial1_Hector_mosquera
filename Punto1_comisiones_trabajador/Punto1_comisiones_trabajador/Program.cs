public class Program
{
    static void Main(string[] args)
    {
        // Definimos el sueldo base del vendedor
        decimal sueldoBase = 3000000;

        // Valores de las ventas del vendedor
        Console.WriteLine("Ingrese el valor de la primera venta:");
        decimal venta1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la segunda venta:");
        decimal venta2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la tercera venta:");
        decimal venta3 = Convert.ToDecimal(Console.ReadLine());

        // Calculamos las comisiones de las ventas del vendedor (10% sobre el valor total de cada venta)
        decimal comision1 = venta1 * 0.10m;
        decimal comision2 = venta2 * 0.10m;
        decimal comision3 = venta3 * 0.10m;

        // Calculamos el total de las comisiones por ventas del vendedor 
        decimal totalComisiones = comision1 + comision2 + comision3;

        // Calculamos el total que recibirá el vendedor en el mes tomando en cuenta su sueldo base y comisiones 
        decimal totalRecibido = sueldoBase + totalComisiones;

        // Determinamos cuál fue la venta con mayor comisión
        decimal comisionMayor = Math.Max(comision1, Math.Max(comision2, comision3));

        // Calculamos el promedio de las comisiones del vendedor
        decimal promedioComisiones = totalComisiones / 3;

        // Verificamos si el vendedor supera el objetivo de ventas para el beneficio extra
        decimal objetivoVentas = 1000000;
        decimal totalVentas = venta1 + venta2 + venta3;
        decimal beneficioExtra = (totalVentas >= objetivoVentas) ? 100000 : 0;

        // Mostramos los resultados por pantalla
        Console.WriteLine($"Total dinero obtenido por el vendedor de las comisiones: ${totalComisiones}");
        Console.WriteLine($"Total dinero recibido por el vendedor en el mes (sueldo base + comisiones + Beneficio extra): ${totalRecibido}");
        Console.WriteLine($"La mayor comisión por ventas obtenida es: ${comisionMayor}");
        Console.WriteLine($"El promedio de las comisiones por ventas es: ${promedioComisiones}");
        Console.WriteLine($"Beneficio extra: ${beneficioExtra}");

        if (beneficioExtra > 0)
        {
            Console.WriteLine("Has superado el objetivo de ventas del mes. La empresa te obsequiará un beneficio extra de 100000.");
        }
        else
        {
            Console.WriteLine("No has superado el objetivo de ventas del mes. No recibirás el bono adicional, pero no te desanimes, sigue esforzandote.");
        }
    }
}