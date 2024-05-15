using System;

class Automovil
{
    private int modelo;
    private double precio;
    private string marca;
    private bool disponible;
    private double tipoCambioDolar;
    private double descuentoAplicado;

    public Automovil()
    {
        modelo = 2019;
        precio = 10000.00;
        marca = "";
        disponible = false;
        tipoCambioDolar = 7.50;
        descuentoAplicado = 0.00;
    }

    public void IngresarDatos()
    {
        Console.WriteLine("Ingresar modelo del automóvil:");
        modelo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresar precio del automóvil en quetzales:");
        precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresar marca del automóvil:");
        marca = Console.ReadLine();

        Console.WriteLine("Ingresar tipo de cambio de dólar a quetzales:");
        tipoCambioDolar = Convert.ToDouble(Console.ReadLine());
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Datos del automóvil:");
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Precio (quetzales): " + precio);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Disponible: " + disponible);
        Console.WriteLine("Tipo de cambio dólar a quetzales: " + tipoCambioDolar);
        Console.WriteLine("Descuento aplicado: " + descuentoAplicado);
    }

    public void CambiarDisponibilidad()
{
    Console.WriteLine("Desea cambiar disponibilidad (Disponibilidad actual: " + disponible + ")? (true/false)");
    string respuesta = Console.ReadLine().ToLower(); 

    if (respuesta == "true")
    {
        disponible = true;
        Console.WriteLine("Disponibilidad cambiada correctamente.");
    }
    else if (respuesta == "false")
    {
        disponible = false;
        Console.WriteLine("\nDisponibilidad cambiada correctamente.");
    }
    else
    {
        Console.WriteLine("\nRespuesta no válida. No se ha realizado ningún cambio en la disponibilidad.");
    }
}

    public void AplicarDescuento()
    {
        Console.WriteLine("Ingrese el monto del descuento a aplicar:");
        double descuento = Convert.ToDouble(Console.ReadLine());
        if (descuento >= 0 && descuento <= precio)
        {
            precio -= descuento;
            descuentoAplicado = descuento;
            Console.WriteLine("Descuento aplicado correctamente.");
        }
        else
        {
            Console.WriteLine("Monto de descuento inválido. No se ha aplicado ningún descuento.");
        }
    }

class Program
{
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil();
        objAutomovil.IngresarDatos();
        objAutomovil.MostrarDatos();
        objAutomovil.CambiarDisponibilidad();
        objAutomovil.MostrarDatos();
        objAutomovil.AplicarDescuento();
        objAutomovil.MostrarDatos();
    }
}
}