TMLL - Tiny Multi-Language Library C#
=====================================

Normalmente para realizar en programa con soporte de Multi-Lenguage, utilizaremos los recursos de localización y globalización que ya soporta c#.

https://msdn.microsoft.com/es-es/library/dn602532.aspx
http://www.codeproject.com/Tips/580043/How-to-make-a-multi-language-application-in-Csharp

Pero en algunas ocasiones, es necesario externalizar las traducciones para que el usuario final pueda modificarlas fácilmente o incluso añadir nuevos idiomas. Con este último fin se ha desarrollado esta librería.


Contribuciones
--------------

Se aceptan cualquier tipo de contribución, solución a bugs o cualquier otro aporte. Si desea reportarnos algún bug, lo pueden hacer abriendo un "issue" en GitHub.


Ejemplos
========

Los siguientes ejemplos ilustran cómo funciona la librería.

Ejemplo: Cargar los archivos de idiomas y mostrar un WordTag. 

```c#
tmll idiomas_es = new tmll(".\\MyLanguagePath", "es"); // Crea el Objeto "idiomas" el cual cataloga todos los ficheros .LANG en la ruta ".\\MyLanguagePath" y marca como activo el que tenga el ID "es".
tmll idiomas_en = new tmll(".\\MyLanguagePath", "en"); // Hace lo mismo pero marca como activo el que tenga el ID "en".
Console.WriteLine( idiomas_es.ReadWord("hola_mundo") ); // Imprime el WordTag "hola_mundo" en Español
Console.WriteLine( idiomas_en.ReadWord("hola_mundo") ); // Imprime el WordTag "hola_mundo" en Ingles
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

FUNDAMENTOS
===========

Ha continuación se describe las funciones, motodos y objetos de la libreria.

**Funciones**

```c#
  // Tipo: constructor
  // Paramentros:
  //     - folder_name(String):  Path donde están ubicados los archivos .lang
  //     - LanguageToSelect(String): ID del idioma a selecionar como activo de forma predeterminada.
  //
  // Objetivo: Constructor de la clase, cataloga los archivos .lang incluidos en el "folder_name" y los inserta en a lista "LanguagesList", en caso de coincidir el ID con algun idioma, lo inserta en "SelectLanguage"
  
  public tmll(string folder_name, string LanguageToSelect = "")
```

```c#
  // Tipo: Función
  // Paramentros:
  //     - WordTab(String): WordTag a buscar.
  // Retorna: 
  //     - (String) Cadena relacionada con el WordTag y el idioma activo.
    
  public string ReadWord(string WordTag)
```

**Propiedades**

```c#
  public List<Languages> LanguagesList  // Lista de idiomas encontrados en el Path indicado en el constructor.
  public Languages SelectLanguage;      // Idioma activo
  
```



Licencia
========

Esta librería está licenciada bajo Apache 2.0, para más información consulta LICENSE.md
