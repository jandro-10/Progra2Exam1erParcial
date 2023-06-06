
using Examen1erParcial.Modelos;
using System.Drawing;

int opcion;
List<MedioDeTransporte> Vehiculos = new List<MedioDeTransporte>();

Terrestre T1 = new Terrestre();
Aereo A1 = new Aereo();



do
{

    Console.WriteLine("\n*** Menu ***");
    Console.WriteLine("Elija una opcion");

    Console.WriteLine("1 - Medio de Transporte Terrestre");
    Console.WriteLine("2 - Medio de Transporte Aereo");
    Console.WriteLine("3 - Hacer Viaje Terrestre");
    Console.WriteLine("4 - Hacer Viaje Aereo");
    Console.WriteLine("5 - Mostrar Vehiculos");
    Console.WriteLine("6 - Salir");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Ingrese el nombre del medio de transporte: ");
        string NombreT = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo del transporte: ");
        string ModeloT = Console.ReadLine();
        Console.WriteLine("Ingrese el año de lanzamineto: ");
        short AñoLT = short.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Color: ");
        string ColorT = Console.ReadLine();
        Console.WriteLine("Cantidad de ruedas: ");
        short CantRT = short.Parse(Console.ReadLine());
        Console.WriteLine("Placa: ");
        string PlacaT = Console.ReadLine();

        T1.NombreA = NombreT;
        T1.ModeloA = ModeloT;
        T1.AñoL = AñoLT;
        T1.ColorA = ColorT;
        T1.CantRuedas = CantRT;
        T1.placa = PlacaT;
        Vehiculos.Add(T1);

    }
    if (opcion == 2)
    {
        Console.WriteLine("Ingrese el nombre del medio de transporte: ");
        string NombreA = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo del transporte: ");
        string ModeloA = Console.ReadLine();
        Console.WriteLine("Ingrese el año de lanzamineto: ");
        short AñoLA = short.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Color: ");
        string ColorA = Console.ReadLine();
        Console.WriteLine("Cantidad de Helices: ");
        short CantRA = short.Parse(Console.ReadLine());
        Console.WriteLine("Cantidad de Alas: ");
        short CantAA = short.Parse(Console.ReadLine());

        A1.NombreA = NombreA;
        A1.ModeloA = ModeloA;
        A1.AñoL = AñoLA;
        A1.ColorA = ColorA;
        A1.CantHelices = CantRA;
        A1.CantAlas = CantAA;
        Vehiculos.Add(A1);
        

    }
    if (opcion == 3)
    {
        Console.WriteLine("Ingrese los Kilometros a recorrer: ");
        double KMR = double.Parse(Console.ReadLine());
        T1.KmsRecorrer = KMR;
        T1.CosumoCombustible();
    }
    if (opcion == 4)
    {
        Console.WriteLine("Ingrese los Kilometros a recorrer: ");
        double KMR = double.Parse(Console.ReadLine());
        A1.KmsRecorrer = KMR;
        A1.CosumoCombustible();

    }
    if (opcion == 5)
    {
        foreach (MedioDeTransporte mdt in Vehiculos)
        {

            Console.WriteLine(mdt.ToString());

        }

    }
    else if (opcion == 6)
    {
        Console.WriteLine("A finalizado el programa");
    }


} while (opcion != 6);
