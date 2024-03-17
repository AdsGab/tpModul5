// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        String nama = "Gabrielle";
        HaloGeneric.SapaUser(nama);
        dataGeneric<String> dataNama = new dataGeneric<String>("Halo");
        dataNama.printData();
    }
}

public class HaloGeneric
{
    public static void SapaUser<T> (T param1)
    {
        Console.WriteLine ("Halo user "+ param1);
    }
}

public class dataGeneric<T> 
{
    private T data;

    public dataGeneric(T data)
    {
        this.data = data;
    }
    public void printData() {
        Console.WriteLine("Data yang tersimpan adalah " + data);
    }
}