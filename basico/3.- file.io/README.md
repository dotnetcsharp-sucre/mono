# .NET C# | MONO 3


Elaborar un script que permita listar los archivos de un directorio "/etc".


## PASOS

```sh
# comandos cmd ---
# crear carpeta llamada dotnet-sucre
$ mkdir dotnet-sucre 
# ingresar en el interior de la carpeta creada
$ cd dotnet-sucre
# establecer directorio actual como un repositorio git
$ git init
# abrir la carpeta actual en visual studio code
$ code .
```

## CÓDIGO

```cs
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
```


## EJECUTAR EJEMPLO

```sh
# comandos cmd ---
# compilar archivo "main.cs"
$ csc main.cs
# ejecutar con mono
$ mono main.exe
```

## REQUISITOS 

* Tener instalado el compilador c sharp
* Tener instalado mono
* visual studio code