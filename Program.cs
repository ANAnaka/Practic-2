
internal class Program
{
    static void MakeSound(int[] korobka)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Escape)
        {
            Console.Clear();


            if (key.Key == ConsoleKey.D)
            { Console.Beep(korobka[0], 300); }

            else if (key.Key == ConsoleKey.R)
            { Console.Beep(korobka[1], 300); }

            else if (key.Key == ConsoleKey.F)
            { Console.Beep(korobka[2], 300); }

            else if (key.Key == ConsoleKey.T)
            { Console.Beep(korobka[3], 300); }

            else if (key.Key == ConsoleKey.G)
            { Console.Beep(korobka[4], 300); }

            else if (key.Key == ConsoleKey.H)
            { Console.Beep(korobka[5], 300); }

            else if (key.Key == ConsoleKey.Y)
            { Console.Beep(korobka[6], 300); }

            else if (key.Key == ConsoleKey.J)
            { Console.Beep(korobka[7], 300); }

            else if (key.Key == ConsoleKey.U)
            { Console.Beep(korobka[8], 300); }

            else if (key.Key == ConsoleKey.K)
            { Console.Beep(korobka[9], 300); }

            else if (key.Key == ConsoleKey.I)
            { Console.Beep(korobka[10], 300); }

            else if (key.Key == ConsoleKey.L)
            { Console.Beep(korobka[11], 300); }

            key = Console.ReadKey();

        }
    }
    static void ChangeOctave()
    {
        ConsoleKeyInfo octava = Console.ReadKey();

        if (octava.Key == ConsoleKey.F1)
        {
            MakeSound(Pervaya());
        }
        else if (octava.Key == ConsoleKey.F6)
        {
            MakeSound(Shestaya());
        }
    }
    static int[] Pervaya()
    {
        int[] vtorayaoctava = new[] { 110, 116, 123, 69, 65, 73, 78, 82, 92, 87, 104, 98 };
        return vtorayaoctava;
    }
    static int[] Shestaya()
    {
        int[] vtorayaoctava = new[] { 1760, 1865, 1976, 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661 };
        return vtorayaoctava;
    }
    private static void Main(string[] args)
    {

        Console.WriteLine("Выберите октаву");

        Console.WriteLine("F1 - Вторая октава");
        Console.WriteLine("F2 - Третья октава");

        do
        {

            ChangeOctave();

   
        } while (true);
    }
}