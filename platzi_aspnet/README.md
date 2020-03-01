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
```s
dotnet tool install --global dotnet-dev-certs
```
![](https://trello-attachments.s3.amazonaws.com/5e5bec6f6b7bcd3f9715e204/806x278/05cd06e7e2ed7d0d948fbbd4deb0dd54/image.png)
```s
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