using System;
using System.Collections.Generic;
using System.IO;

public class Ventana
{
    public Ventana()
    {
        var files = Directory.GetFiles("/etc/");
        foreach (string i in files)
        {
            Console.WriteLine(String.Format("directorio {0}", i));
        }

    }

    public static void Main()
    {
        new Ventana();
    }
}