using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int resultadoSorteo = random.Next(1000, 10000); // Genera un número aleatorio de 4 dígitos

        Console.Write("Ingrese un número de 4 dígitos para apostar: ");
        int apuesta;

        // Validar la entrada del usuario
        while (!int.TryParse(Console.ReadLine(), out apuesta) || apuesta < 1000 || apuesta > 9999)
        {
            Console.Write("Número inválido. Ingrese un número de 4 dígitos: ");
        }

        Console.Write("Ingrese la cantidad apostada: ");
        int montoApostado;
        while (!int.TryParse(Console.ReadLine(), out montoApostado) || montoApostado <= 0)
        {
            Console.Write("Cantidad inválida. Ingrese un valor positivo: ");
        }

        Console.WriteLine($"Número ganador del sorteo: {resultadoSorteo}");

        int premio = CalcularPremio(apuesta, resultadoSorteo, montoApostado);

        if (premio > 0)
        {
            Console.WriteLine($"¡Felicidades! Has ganado {premio}.");
        }
        else
        {
            Console.WriteLine("Lo siento, no ganaste esta vez.");
        }
    }

    static int CalcularPremio(int apuesta, int resultado, int monto)
    {
        string apuestaStr = apuesta.ToString();
        string resultadoStr = resultado.ToString();

        if (apuesta == resultado)
        {
            return monto * 4500;
        }
        else if (new string(apuestaStr.OrderBy(c => c).ToArray()) == new string(resultadoStr.OrderBy(c => c).ToArray()))
        {
            return monto * 200;
        }
        else if (apuestaStr.Substring(1) == resultadoStr.Substring(1))
        {
            return monto * 400;
        }
        else if (apuestaStr.Substring(2) == resultadoStr.Substring(2))
        {
            return monto * 50;
        }
        else if (apuestaStr.Substring(3) == resultadoStr.Substring(3))
        {
            return monto * 5;
        }
        return 0;
    }
}
