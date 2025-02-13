using System;

class Program
{
    static string ConvertirAHMS(int segundos)
    {
        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        int segundosRestantes = segundos % 60;

        return $"{horas:D2}:{minutos:D2}:{segundosRestantes:D2}";
    }

    static void Main()
    {
        Console.WriteLine(ConvertirAHMS(3661)); // Salida: 01:01:01
    }
}
