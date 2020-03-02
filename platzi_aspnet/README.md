## [Curso de ASP.NET Core by Juan Carlos Ruiz](https://platzi.com/clases/aspnet-core/)

### [1 - Bienvenida](https://platzi.com/clases/1395-aspnet-core/14479-bienvenida-al-curso8835/)
- Introducción

### [2 - Herramientas y prerrequisitos](https://platzi.com/clases/1395-aspnet-core/14480-herramientas-y-prerrequisitos/)
- Instalar:
  - VSCode
  - dotnet sdk
### [3 - La importancia del middleware en el entorno web](https://platzi.com/clases/1395-aspnet-core/14481-la-importancia-del-middleware-en-el-entorno-web/)
- Nginx, Tomcat, Apache
- Para netcore el middleware ideal es **Kestrel**, este es capaz de utilizar de .net por debajo
- Es solo para desarrollo, no esta pensado para producción
### [4 - Habilitar certificados, planillas preinstaladas](https://platzi.com/clases/1395-aspnet-core/14482-habilitar-certificados-planillas-preinstaladas/)
- Las webapps se pueden servir por http y/o https, en nuestro caso se hará con https y por lo tanto hay que instalar el certificado
```
dotnet tool install --global dotnet-dev-certs
```
- ![](https://trello-attachments.s3.amazonaws.com/5e5bec6f6b7bcd3f9715e204/806x278/05cd06e7e2ed7d0d948fbbd4deb0dd54/image.png)
```s
El directorio de herramientas "<home-usuario>/.dotnet/tools" no está en la variable de entorno PATH.
Si usa zsh, puede agregarlo a su perfil mediante la ejecución del comando siguiente:

# Agregue las herramientas del SDK de .NET Core
exporte PATH="$PATH:<home-usuario>/.dotnet/tools"
EOF

Y ejecute "zsh -l" para que esté disponible para la sesión actual.
Solo puede agregarlo a la sesión actual ejecutando el comando siguiente:

export PATH="$PATH:<home-usuario>/.dotnet/tools"

Puede invocar la herramienta con el comando siguiente: dotnet-dev-certs
La herramienta "dotnet-dev-certs" (versión '2.2.0') se instaló correctamente.
```
- `dotnet dev-certs https --trust`
```
A valid HTTPS certificate with a key accessible across security partitions was not found. The following command will run to fix it:
'sudo security set-key-partition-list -D localhost -S unsigned:,teamid:UBF8T346G9'
This command will make the certificate key accessible across security partitions and might prompt you for your password. For more information see: https://aka.ms/aspnetcore/2.1/troubleshootcertissues
A valid HTTPS certificate with a key accessible across security partitions was not found. The following command will run to fix it:
'sudo security set-key-partition-list -D localhost -S unsigned:,teamid:UBF8T346G9'
This command will make the certificate key accessible across security partitions and might prompt you for your password. For more information see: https://aka.ms/aspnetcore/3.1/troubleshootcertissues
Trusting the HTTPS development certificate was requested. If the certificate is not already trusted we will run the following command:
'sudo security add-trusted-cert -d -r trustRoot -k /Library/Keychains/System.keychain <<certificate>>'
This command might prompt you for your password to install the certificate on the system keychain.
```
- Razor page: Es la web más básica que se puede hacer
- MVC *: App expansible
- ASP.NET Core Web API: para hacer APIS (no se verá en el curso)
- **comando**
  ```
  dotnet new web -o <carpeta-destino-donde-se-creara-la-app>
  dotnet new mvc -o <carpeta-destino-donde-se-creara-la-app>
  ``` 
- ![](https://trello-attachments.s3.amazonaws.com/5e5bec6f6b7bcd3f9715e204/987x145/65ca9998fd994d9d39d0d3b7c7e6722e/image.png)
```
├── Controllers
│   └── HomeController.cs
├── Models
│   └── ErrorViewModel.cs
├── Program.cs
├── Properties
│   └── launchSettings.json
├── Startup.cs
├── Views
│   ├── Home
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Shared
│   │   ├── Error.cshtml
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── appsettings.Development.json
├── appsettings.json
├── obj
│   ├── project.assets.json
│   ├── project.csproj.nuget.cache
│   ├── project.csproj.nuget.dgspec.json
│   ├── project.csproj.nuget.g.props
│   └── project.csproj.nuget.g.targets
├── project.csproj
└── wwwroot
    ├── css
    │   └── site.css
    ├── favicon.ico
    ├── js
    │   └── site.js
    └── lib
        ├── bootstrap
        │   ├── LICENSE
        │   └── dist
        │       ├── css
        │       │   ├── bootstrap-grid.css
                    ...
        │       │   └── bootstrap.min.css.map
        │       └── js
        │           ├── bootstrap.bundle.js
                    ...
        │           └── bootstrap.min.js.map
        ├── jquery
        │   ├── LICENSE.txt
        │   └── dist
        │       ├── jquery.js
        │       ├── jquery.min.js
        │       └── jquery.min.map
        ├── jquery-validation
        │   ├── LICENSE.md
        │   └── dist
        │       ├── additional-methods.js
        │       ├── additional-methods.min.js
        │       ├── jquery.validate.js
        │       └── jquery.validate.min.js
        └── jquery-validation-unobtrusive
            ├── LICENSE.txt
            ├── jquery.validate.unobtrusive.js
            └── jquery.validate.unobtrusive.min.js

20 directories, 56 files
```
### [5 - Revisión detalladas de la estructura de directorios](https://platzi.com/clases/1395-aspnet-core/14483-revision-detalladas-de-la-estructura-de-directorio/)
- bin: todo el compilado
- obj: carpeta temporal al compilar
- wwwroot:
  - css
  - images
  - js
  - lib
- Las vistas son acciones
- Convención: `<algo>Controller`
- Program.cs tiene la función main
- Startup.cs tiene las rutas
- **error**
  - No arranca.
  - He instalado la extensión de c#
  - > The .NET Core SDK cannot be located. .NET Core debugging will not be enabled. Make sure the .NET Core SDK is installed and is on the path.
  - En `code > preferences > settings` he buscado .Net y desactivado los avisos
  - Tenía el puerto mal configurado. 6000 no lo detecta como seguro con 3300 va!
- `<dentro-de-la-carpeta-del-proyecto>dotnet run`
- ![](https://trello-attachments.s3.amazonaws.com/5b014dcaf4507eacfc1b4540/5e5bec6f6b7bcd3f9715e204/ccd070a2b5c1ea64214db5696323f67a/image.png)
### [6 - ¿Qúé es el patrón MVC?](https://platzi.com/clases/1395-aspnet-core/14484-que-es-el-patron-mvc/)
- teoria de mvc
- Modelo: Entidades: POCO es una clase plana sin funcionalidad adicional
- POCO: Plain old CLR objects
- POJO plain old java objects
### [7 - Nuestro proyecto](https://platzi.com/clases/1395-aspnet-core/14485-nuestro-proyecto0649/)
- Resumen
- Haremos la app de gestión de una escuela
### [8 - Vista y controlador](https://platzi.com/clases/1395-aspnet-core/14486-vista-y-controlador/)
- Las convenciones 
```c#
//<project>/Controllers/EscuelaController.cs
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class EscuelaController:Controller
    {
        public IActionResult Index()
        {
            //si no se especifica la vista se lanza la de por defecto
            //Views/Escuela/Index.cshtml
            return View();
        }

    }//class

}//namespace

@{
    //<project>/Views/Escuela/Index.cshtml
    ViewData["Title"] = "Información escuela";
}
<h1>Escuela</h1>
<h2>nombre:</h2>
<p><b>Año fundacion:</b></p>
```
- ![](https://trello-attachments.s3.amazonaws.com/5e5bec6f6b7bcd3f9715e204/798x570/f3561d27228a12bff0fb5963f22d9d4e/image.png)
### [9 - Modelo a nivel básico](https://platzi.com/clases/1395-aspnet-core/14487-modelo-a-nivel-basico/)
- 
```c#
<!-- <project>/Views/_ViewImports.cshtml -->
@using project
@using project.Models
//el taghelper son funcionalidades extra que traen para crear código más rápido
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

<!-- <project>/Views/_ViewStart.cshtml -->
@{
    //el layout que se cargará por defecto
    //Views/Shared/_Layout.cshtml
    Layout = "_Layout";
}

//Views/Shared/_Layout.cshtml
<div class="container">
  <main role="main" class="pb-3">
      @RenderBody() //espacio de la vista
  </main>
</div>

<footer class="border-top footer text-muted">
  <div class="container">
      &copy; 2020 - project - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
  </div>
</footer>
<script src="~/lib/jquery/dist/jquery.min.js"></script>
<script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
<script src="~/js/site.js" asp-append-version="true"></script>
@RenderSection("Scripts", required: false)

//Models/Escuela.cs
using System;

namespace project.Models
{
    public class EscuelaModel
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public int anyo { get; set; }

    }
}

//<project>/Controllers/EscuelaController.cs
using System;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class EscuelaController:Controller
    {
        public IActionResult Index()
        {
            var objescuela = new EscuelaModel();
            objescuela.anyo=2005;
            objescuela.id = Guid.NewGuid().ToString();
            objescuela.nombre = "Some school";
            //si no se especifica la vista se lanza la de por defecto
            return View(objescuela);
        }

    }//class

}//namespace
```
### [10 - Razor Syntax](https://platzi.com/clases/1395-aspnet-core/14488-razor-syntax/)
- Razor (cuchilla) la forma espaguetti de c#
- la marca @ es como el ? de php
```c#
@{
    //Views/Escuela/Index.cshtml
}
@model EscuelaModel //tipando el modelo
@{
    ViewData["Title"] = "Información escuela";
}
<h1>Escuela: @Model.nombre</h1>
<h2>nombre:</h2>
<p><b>Año fundacion:</b></p>

//Actualizo ruta por defecto a escuela
//Startup.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Escuela}/{action=Index}/{id?}");
            });
        }//configure

    }//class startup
}//ns project

```
### [11 - Vistas, plantillas, Archivos de inicio](https://platzi.com/clases/1395-aspnet-core/14489-vistas-plantillas-archivos-de-inicio/)
```c#
//Views/Escuela/Index.cshtml
@model EscuelaModel //tipando el modelo
@{
    ViewData["Title"] = "Información escuela";
    //Layout = "Simple"; //shared/simple.cshtml
}
<h1>Escuela: @ViewData["Title"]</h1>
<h2>Nombre: @Model.nombre</h2>
<p><b>Año fundacion:</b> <span>@Model.anyo</span></p>

<p>1:<i>@ViewBag.cosadinamica</i></p>
<p>2:<i>@ViewData["cosadinamica"]</i></p>

//<project>/Views/_ViewStart.cshtml
@{
    //aqui defino el template general para todas las vistas
    Layout = "_Layout";
    //Layout = "Simple";
}

//Simple.cshtml
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - project</title>
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="~/css/site.css" />
</head>
<body>
    @RenderBody()
</body>
</html>

//EscuelaController.cs
public class EscuelaController:Controller
{
    public IActionResult Index()
    {
        var objescuela = new EscuelaModel();
        objescuela.anyo=2005;
        objescuela.id = Guid.NewGuid().ToString();
        objescuela.nombre = "Some school";

        ViewBag.cosadinamica = "La monja";
        //si no se especifica la vista se lanza la de por defecto
        return View(objescuela);
    }
}
```
### [12 - ]()
- 
```c#
```
### [13 - ]()
- 
```c#
```
### [14 - ]()
- 
```c#
```
### [15 - ]()
- 
```c#
```
### [16 - ]()
- 
```c#
```
### [17 - ]()
- 
```c#
```
### [18 - ]()
- 
### [19- ]()
- 
### [20- ]()
- 
### [21 - ]()
- 
### [22 - ]()
- 
### [23 - ]()
- 
### [24 - ]()
- 
### [25 - ]()
- 
### [26 - ]()
- 
### [27 - ]()
- 
### [28 - ]()
- 
### [29 - ]()
- 
### [30 - ]()
- 
### [31- ]()
- 
### [32 - ]()
- 
### [33 - ]()
- 
### [34 - ]()
- 
### [35 - ]()
- 