using System.Xml;

string opcion;
int suma = 0;
int media = 0;
string[] nombre = new string[5];
string[] apellido = new string[5];
int[] edad = new int[5];
int[] nota = new int[5];

Console.WriteLine("LABORATORIO 15");
Console.WriteLine("1250521");
Console.WriteLine();
Console.WriteLine("Por favor, ingrese la opción que desea correr");
Console.WriteLine("OPCIÖN  1: mayores de edad");
Console.WriteLine("OPCIÖN  2: nombres y apellidos");
Console.WriteLine("OPCIÓN  3: salir");
opcion = Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

switch (opcion)
{
    case "1":

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Por favor, ingrese un nombre");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese su edad");
            edad[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            if (edad[i] > 18)
            {
                Console.WriteLine(nombre[i] + " es mayor de edad, y tiene: " + edad[i] + " años");
            }
        }
        for (int i = 0; i < 5; i++)
        {
            suma = suma + edad[i];
            media = suma / 5;
        }
        Console.WriteLine();
        Console.WriteLine(", mientras que la media de las 5 edades es de: " + media);
        Console.WriteLine();
        Console.WriteLine();
        break;










    case "2":

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Por favor, ingrese un nombre");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese su apellido respectivo");
            apellido[i] = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese la nota de " + nombre[i] + "_" +  apellido[i]);
            nota[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();    
        }

        for (int j = 0; j < 5; j++)
        {
            suma = suma + nota[j];
            media = suma / 5;


        }
        Console.WriteLine();
        Console.WriteLine("la media de las 5 notas es de: " + media);
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            if (nota[i] >= 71)
            {
                Console.WriteLine(nombre[i] + "_" + apellido[i] + "    ha aprobado la clase con: " + nota[i] + " puntos");
            }
            else
            {
                Console.WriteLine(nombre[i] + "_" + apellido[i] + "    ha reprobado la clase con:  " + nota[i] + " puntos ");
            }
        }
        Console.WriteLine();

        double Mayor = 0;
        int Verdadero2 = 0;
        string Mejor = "";
        for (int i = 0; i < 5; i++)
        {
            if (Mayor < nota[i])
            {
                Mayor = nota[i];
                Verdadero2 = i + 1;
                Mejor = nombre[i] + apellido[i];

            }
        }
        Console.WriteLine("La nota más alta pertenece a: " + Mejor);

        double Mayor2 = 0;
        int Verdadero3 = 0;
        string Mejor2 = "";
        for (int i = 0; i < 5; i++)
        {
            if (Mayor2 > nota[i])
            {
                Mayor2 = nota[i];
                Verdadero3 = i + 1;
                Mejor2 = nombre[i];

            }
        }
        Console.WriteLine("La más baja pertenece a: " + Mejor2);

        double promedio2 = 0;
        double sum2 = 0;
        for (int i = 0; i < 5; i++)
        {
            if (promedio2 < nota[i])
            {
                Mayor2 = nota[i];
                Verdadero3 = i + 1;
                Mejor2 = nombre[i];

            }
            sum2 = sum2 + nota[i];
        }

        promedio2 = sum2 / 5;
        Console.WriteLine("El promedio de las notas es " + promedio2);

        break;










    case "3":

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Muchas gracias por participar");
        Console.WriteLine("Por favor, presione una tecla para finalizar el programa");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        break;
}
