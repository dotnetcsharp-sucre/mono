# .NET C# | MONO 1


Mostrar una aplicación de escritorio con un control BUTTON que al pulsar sobre el mismo , cree un formulario con el mensaje de texto "open form" 



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
using System.Windows.Forms;

public class Ventana : Form
{
    static public void Main()
    {
        Application.Run(new Ventana());
    }

    public Ventana()
    {
        Button b = new Button() { Text = "Click aquí!" };
        b.Click += new EventHandler(Button_Click);
        Controls.Add(b);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        var f = new Form();
        f.Controls.Add(new Label() { Text = "open form" });
        f.ShowDialog();
    }
}
```


## EJECUTAR EJEMPLO

```sh
# comandos cmd ---
# compilar el archivo main.cs utilizando como recurso la dll Forms
$ csc main.cs -r:System.Windows.Forms.dll
# ejecutar con mono
$ mono main.exe
```

## REQUISITOS 

* Tener instalado el compilador c sharp
* Tener instalado mono
* visual studio code