TMLL - Tiny Multi-Language Library C#
=====================================

Normalmente para realizar en programa con soporte de Multi-Lenguage, utilizaremos los recursos de localizaci�n y globalizaci�n que ya soporta c#.

https://msdn.microsoft.com/es-es/library/dn602532.aspx
http://www.codeproject.com/Tips/580043/How-to-make-a-multi-language-application-in-Csharp

Pero en algunas ocasiones, es necesario externalizar las traducciones para que el usuario final pueda modificarlas f�cilmente o incluso a�adir nuevos idiomas. Con este �ltimo fin se ha desarrollado esta librer�a.


Contribuciones
--------------

Se aceptan cualquier tipo de contribuci�n, soluci�n a bugs o cualquier otro aporte. Si desea reportarnos alg�n bug, lo pueden hacer abriendo un "issue" en GitHub.


Ejemplos
========

Los siguientes ejemplos ilustran c�mo funciona la librer�a.

Ejemplo: Cargar los archivos de idiomas y mostrar un WordTag. 

```c#
tmll idiomas_es = new tmll(".\\MyLanguagePath", "es"); // Crea el Objeto "idiomas" el cual cataloga todos los ficheros .LANG en la ruta ".\\MyLanguagePath" y marca como activo el que tenga el ID "es".
tmll idiomas_en = new tmll(".\\MyLanguagePath", "en"); // Hace lo mismo pero marca como activo el que tenga el ID "en".
Console.WriteLine( idiomas_es.ReadWord("hola_mundo") ); // Imprime el WordTag "hola_mundo" en Espa�ol
Console.WriteLine( idiomas_en.ReadWord("hola_mundo") ); // Imprime el WordTag "hola_mundo" en Ingles
```

Fichero: .\MyLanguagePath\spanish.lang
```c#
[info]
id=es
language=Espa�ol
[words]
hola_mundo=HOLA MUNDO EN ESPA�OL

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
HOLA MUNDO EN ESPA�OL
HELLO WORLD IN ENGLISH
```

FUNDAMENTOS
===========

Ha continuaci�n se describe las funciones, motodos y objetos de la libreria.

**Funciones**

```c#
  // Tipo: constructor
  // Paramentros:
  //     - folder_name(String):  Path donde est�n ubicados los archivos .lang
  //     - LanguageToSelect(String): ID del idioma a selecionar como activo de forma predeterminada.
  //
  // Objetivo: Constructor de la clase, cataloga los archivos .lang incluidos en el "folder_name" y los inserta en a lista "LanguagesList", en caso de coincidir el ID con algun idioma, lo inserta en "SelectLanguage"
  
  public tmll(string folder_name, string LanguageToSelect = "")
```

```c#
  // Tipo: Funci�n
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

Esta librer�a est� licenciada bajo Apache 2.0, para m�s informaci�n consulta LICENSE.md
