// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        String nama = "Gabrielle";
        HaloGeneric.SapaUser(nama);
    }
}

public class HaloGeneric
{
    public static void SapaUser<T> (T param1)
    {
        Console.WriteLine ("Halo user "+ param1);
    }
}