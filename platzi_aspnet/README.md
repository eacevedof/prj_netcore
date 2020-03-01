### [Curso de ASP.NET Core by Juan Carlos Ruiz](https://platzi.com/clases/aspnet-core/)

### [1 - Bienvenida](https://platzi.com/clases/1395-aspnet-core/14479-bienvenida-al-curso8835/)

### [2 - Herramientas y prerrequisitos](https://platzi.com/clases/1395-aspnet-core/14480-herramientas-y-prerrequisitos/)
- Instalar:
  - VSCode
  - dotnet sdk

### [3 - La importancia del middleware en el entorno web](https://platzi.com/clases/1395-aspnet-core/14481-la-importancia-del-middleware-en-el-entorno-web/)
- Nginx, Tomcat, Apache
- Para netcore el middleware ideal es **Kestrel**, este es capaz de utilizar de .net por debajo
- Es solo para desarrollo, no esta pensado para producción

### [4 - Habilitar certificados, planillas preinstaladas](https://platzi.com/clases/1395-aspnet-core/14482-habilitar-certificados-planillas-preinstaladas/)
- Las webapps se pueden servir por http y/o https, en nuestro caso se hará con https y por lo tanto hay que instalar el certificado
```
dotnet tool install --global dotnet-dev-certs
```
- ![](https://trello-attachments.s3.amazonaws.com/5e5bec6f6b7bcd3f9715e204/806x278/05cd06e7e2ed7d0d948fbbd4deb0dd54/image.png)
```
El directorio de herramientas "<home-usuario>/.dotnet/tools" no está en la variable de entorno PATH.
Si usa zsh, puede agregarlo a su perfil mediante la ejecución del comando siguiente:

cat << \EOF >> ~/.zprofile
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
### [5 - ]()
-
### [6 - ]()
-
### [7 - ]()
-
### [8 - ]()
-
### [9 - ]()
-
### [10 - ]()
-
### [11 - ]()
-
### [12 - ]()
-
### [13 - ]()
-
### [14 - ]()
-
### [15 - ]()
-
### [16 - ]()
-
### [17 - ]()
-
### [18 - ]()
-
### [19 - ]()
-
### [20 - ]()
-
### [21 - ]()
-
### [22 - ]()
-
### [23 - ]()
-
### [24 - ]()
-
### [25 - ]()
-