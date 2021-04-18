# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.
* **Title**: Eficiencia computacional del algorimo de análisis de ADN.
* **Status**: accepted.
* **Context**: Se requiere optimizar al máximo el algoritmo de analisis de DNA con el fin de lograr el menor consumo de rucursos a nivel de cpu y memoria, y lograr un throughput de 100 a 1 millon de peticiones por segundo.
* **Decision**: Se definen las siguientes estrategias para la construcción del algoritmo:
  - [x] Rocorrer la matriz ordenadamente y por cada elemento, buscar secuencias formadas por 4 letras iguales en sentido vertical inferior, horizontal derecha, obliquo izquierda, obliquo derecha.
  - [x] Una vez se detecten dos secuencias validas, se aborta la busqueda sobre la matriz.
  - [x] La busqueda de una secuencia en determinada dirección se hará solamente si su busqueda no sobrepasa los limites de la matriz.
  - [x] Una vez se detecte una secuencia válida conformada por 4 letras iguales, se aborta la busqueda en esa dirección para ese elemento.
  - [x] Para elementos que hacen parte de una secuencia válida en una dirección particular, no se realizará busquedas en dicha dirección.
  - [x] No se  utilizará recursividad para recorrer la matriz NXN debido a que N es un valor abierto. Recursividad en mas de 5 o 10 niveles termina siendo ineficiente.
  - [x] Usar tipos de datos a la medida para optimizar consumo de memoria.
  - [x] No realizar busqueda sobre matrices inválidas o matrices inferiores a 4x4.
* **Consequences**: Lograr una eficiencia computacional que permita alcanzar el valor de Thoughput propuesto.