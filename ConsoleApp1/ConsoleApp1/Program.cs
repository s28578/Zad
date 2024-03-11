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
        foreach (int x in liczby)
        {
            suma += x;
        }

        int srednia;
        srednia = suma / liczby.Length;
    }
    
}
