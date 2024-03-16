// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Modyfikacja 1
        //Modyfikacja 2
        //Modyfikacja 3
    }

    public static void WyliczSrednia(int[] liczby)
    {
        int suma = 0;
        foreach (int t in liczby)
        {
            suma += t;
        }

        int srednia;
        srednia = suma / liczby.Length;
    }

    public static int ZnajdzMax(int[] liczby)
    {
        int max = liczby[0];
        foreach (int x in liczby)
        {
            if (x > max)
                max = x;
        }

        return max;
    }
    
}
