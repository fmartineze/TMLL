TMLL - Tyny Multi-Language Library C#
=====================================

Normalmente para realizar en programa con soporte de Multi-Lenguage, utilizaremos los recursos de localizacion y globalización que ya soporta c#

https://msdn.microsoft.com/es-es/library/dn602532.aspx
http://www.codeproject.com/Tips/580043/How-to-make-a-multi-language-application-in-Csharp

Pero en algunas ocasiones, es necesario externalizar las traducciones para que el usuario final pueda modificarlas facilmente o incluso añadir nuevos idiomas.
Con este ultimo fin se ha desarrollado esta libreria.


Contribuciones
--------------

Se aceptan cualquier tipo de contribución, solución a bugs o cualquier otro aporte. Si desea reportarnos algun bug, lo pueden hacer abriendo un "issue" en GitHub.


Ejemplos
========

Los siguientes ejemplos ilustran como funciona la libreria. 

Ejemplo: Cargar los archivos de idiomas y mostrar un WordTag. 

```c#
tmll idiomas_es = new tmll(".\\MyLanguagePath", "es"); // Crea el Objeto "idiomas" el cual cataloga todos los ficheros .LANG en la ruta ".\\MyLanguagePath" y marca como activo el que tenga el ID "es".
tmll idiomas_en = new tmll(".\\MyLanguagePath", "en"); // Hace lo mismo pero marca como activo el que tenga el ID "en".
Console.WriteLine( idiomas_es.ReadWord("hola_mundo") ); // Imprime el WordTag "hola_mundo" en Español
Console.WriteLine( idiomas_en.ReadWord("hola_mundo") ); // Imprime el WordTag "hola_mundo" en Ingles
}
```

Fichero: .\MyLanguagePath\spanish.lang
```c#
[info]
id=es
language=Español
[words]
hola_mundo=HOLA MUNDO EN ESPAÑOL

```

Fichero: .\MyLanguagePath\english.lang
```c#
[info]
id=en
language=English
[words]
hola_mundo=HELLO WORLD IN ENGLISH

```


RESULTADO:
```c#
HOLA MUNDO EN ESPAÑOL
HELLO WORLD IN ENGLISH
```

Licence
=======

Esta libreria está licenciada bajo Apache 2.0, para mas información consulta LICENSE.md
