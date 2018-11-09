# .NET C# | MONO 2


Mostrar un formulario web (aspx) que escriba en pantalla "ASPX.Net"  usando el RAZOR clásico , y escribir mediante la clase "Response" el siguiente mensaje 
"Bienvenido a ASP.Net ... mono-xsp" al cargar la página.


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

```aspx
<% @Page Language="C#" CodeFile="Default.aspx.cs" Inherits="Default"%>
<html>

<body>
    <h1>
        <%="ASPX.Net" %>
    </h1>
</body>

</html>
```

```cs
using System;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Output.Write("Bienvenido a ASP.Net ... mono-xsp");
    }
}
```


## EJECUTAR EJEMPLO

```sh
# comandos cmd ---
# instalar mono-xsp
$ sudo apt-get install mono-xsp
# ejecutar con mono
$ xsp
```

## REQUISITOS 

* Tener instalado el compilador c sharp
* Tener instalado mono-xsp
* visual studio code