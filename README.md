# DNA Analyzer
Magneto quiere reclutar la mayor cantidad de mutantes para poder luchar contra los X-Men. Te ha contratado a ti para que desarrolles un proyecto que detecte si un humano es mutante basándose en su secuencia de ADN. Para eso te ha pedido crear un programa con un método o función con la siguiente firma (En alguno de los siguiente lenguajes: Java / Golang / C-C++ / Javascript (node) / Python / Ruby):

 **boolean isMutant(String[] dna); // Ejemplo Java** 

En donde recibirás como parámetro un array de Strings que representan cada fila de una tabla de (NxN) con la secuencia del ADN. Las letras de los Strings solo pueden ser: (A,T,C,G), las cuales representa cada base nitrogenada del ADN. 



![context-view](docs/img/img1.png)

Sabrás si un humano es mutante, si encuentras **más de una secuencia de cuatro letras iguales**, de forma oblicua, horizontal o vertical. 

**Ejemplo (Caso mutante):**

 String[] dna = {"ATGCGA","CAGTGC","TTATGT","AGAAGG","CCCCTA","TCACTG"}; 

En este caso el llamado a la función isMutant(dna) devuelve "true".

**Desafíos:**

**Nivel 1:**
Programa (en cualquier lenguaje de programación) que cumpla con el método pedido por
Magneto.

**Nivel 2:**
Crear una API REST, hostear esa API en un cloud computing libre (Google App Engine,
Amazon AWS, etc), crear el servicio “/mutant/” en donde se pueda detectar si un humano es
mutante enviando la secuencia de ADN mediante un HTTP POST con un Json el cual tenga el
siguiente formato:

POST → /mutant/
{
"dna":["ATGCGA","CAGTGC","TTATGT","AGAAGG","CCCCTA","TCACTG"]
}

En caso de verificar un mutante, debería devolver un HTTP 200-OK, en caso contrario un
403-Forbidden

**Nivel 3:**
Anexar una base de datos, la cual guarde los ADN’s verificados con la API.
Solo 1 registro por ADN.
Exponer un servicio extra "/stats" que devuelva un Json con las estadísticas de las
verificaciones de ADN: {"count_mutant_dna":40, “count_human_dna:"100 "ratio:0.4}

Tener en cuenta que la API puede recibir fluctuaciones agresivas de tráfico (Entre 100 y 1
millón de peticiones por segundo).

Test-Automáticos, Code coverage > 80%.

## Build Status (GitHub Actions)



|      Image       |                            Status                            |
| :--------------: | :----------------------------------------------------------: |
| DNA Analyzer API | ![example workflow](https://github.com/boris-martinez/meli-dnaanalyzer-api/actions/workflows/meli-dnaanalyzer-api.yml/badge.svg) |



# Architecture
### Architecture Drivers

A continuación se listan (el orden establece la prioridad) los atributos de calidad que debe soportar el sistema:

1. **Rendimiento**: Se requiere que el algoritmo que analiza si un humano es mutante o no, sea lo mas eficiente posible en terminos de cpu y memoria.
2. **Escalabilidad**: El sistema debe soportar entre uno y un millon de llamados por segundo.
3. **Mantenibilidad**: se requiere bla bla 
4. **Testeability**: se requiere bla bla 

De igual forma se plantean las siguientes restricciones y suposiciones:

1. jksdjksjdksd
2. jklsdlskdlskdls
3. kjdkjdkajdksa



### Architecture Decision Records (ADR)

* [01 Persistencia eventos reportes por tiempo](docs/adr/2021-02-19_1_Persistencia-reportes-tiempo.md)
* [02 Tiempo almacenamiento eventos reportes por tiempo](adr/2021-02-19_2_Tiempo-almacenamiento-reportes-tiempo.md)
* [03 Estrategia de filtrado de vehículos en el proceso de ingesta](adr/2021-02-19_3_Estrategia-filtrado-vehiculos-ingesta.md)
* [04 Cache de vehíclos en el proceso de filtrado](adr/2021-02-19_4_Cache-filtrado-vehiculos.md)
* [05 Estrategia testing mode](adr/2021-02-19_5_Estrategia-testing-mode-ingesta_.md)
* [06 Segregación de bases de datos](adr/2021-02-19_6_Segregacion_bd.md)
* [07 Limitaciones escalabilidad del analizador](adr/2021-02-19_7_Limitaciones-escalabilidad-analyzer.md)
* [08 Trazabilidad y soporte rutas](adr/2021-02-19_8_Trazabilidad-soporte-rutas.md)

### Vista de Despliegue

diagrama



# Devops
### Build



### Tests



### Release



# Access Endpoint

TODO: Describe and show how to build your code and run the tests. 