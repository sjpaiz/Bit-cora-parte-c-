

class Program
{
    static void Main(string[]args)
    {
      string opcion;
      Personaje personaje = new Personaje(0,0);

    do
    {
      Console.WriteLine("Menú de opciones");
      Console.WriteLine("a. Sube");
      Console.WriteLine("b. Baja");
      Console.WriteLine("c. Izquierda");
      Console.WriteLine("d. Derecha");
      Console.WriteLine("e. Salir");
     
     opcion= Console.ReadLine()+"";

      switch (opcion)
      {
        case "a":
            personaje.moverhaciaarriba(LeerCantidad("arriba"));
        break;
        case "b":
            personaje.moverhaciaabajo(LeerCantidad("abajo"));
        break;
        case "c":
            personaje.moverhacialaizquierda(LeerCantidad("izquierda"));
        break;
        case "d":
            personaje.moverhacialaderecha(LeerCantidad("derecha"));
        break;
        case "e":
            Console.WriteLine("$Coordenadas finales del personaje:(personaje.GetX()),(personaje.GetY())");
        break;
      }
    } 
    while (opcion != "e");
    } 
    static int LeerCantidad(string direccion) 
    {
        Console.WriteLine("Ingrese la cantidad a moverse hacia (direccion):");
        int cantidad = int.Parse(Console.ReadLine());
        return cantidad;
    }
}


