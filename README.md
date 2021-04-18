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

1. **Rendimiento**: Se requiere que tanto el proceso de análisis de DNA, como el de telemetría, sean lo mas eficiente posible en términos de cpu y memoria y genere las respuestas en el menor tiempo posible (300  ms en promedio).
2. **Escalabilidad**: El sistema debe soportar entre 100 y 1 millón de peticiones por segundo.
3. **Mantenibilidad**: Aunque este atributo no se menciona de forma explicita, todo software que se construye debe tener un buen índice de mantenibilidad con el fin de que otras personas puedan entenderlo fácilmente y puedan evolucionarlo de manera eficaz.
4. **Testeability**: El sistema debe poderse probar mediante casos de prueba automatizados y tener una cobertura mayor al 80%.
5. **Disponibilidad:** Aunque este atributo  no se menciona de forma explicita, actualmente todo sistema debe manejar un alto porcentaje de disponibilidad , ser resiliente y manejar una buena tolerancia a fallos.

De igual forma se plantean las siguientes *restricciones* y *suposiciones*:

1. El ambiente de despliegue es limitado y de bajo costo, por lo tanto los componentes tendrán restricciones de escalabilidad en escenarios de pruebas de carga.
2. El ambiente de despliegue es limitado y de bajo presupuesto, por lo tanto el API estará disponible en la siguiente ventana horaria: Lunes - Viernes entre 8am - 5pm.
3. Se  acepta consistencia eventual para el proceso de telemetría de las estadísticas de las verificaciones de ADN.
4. Por definición, no es posible calcular un ratio cuando alguno de los factores es cero. Por lo tanto cuando esto ocurra, el API omitirá este elemento del json de respuesta.
5. Al principio del enunciado se restringe la implementación del desarrollo a los siguientes lenguajes: Java / Golang / C-C++ / Javascript (node) / Python / Ruby). Sin embargo mas adelante se indica que puede ser desarrollado en cualquier otro lenguaje. Por lo tanto se opta por hacer la implementación en c#.
6. Se asume que dos o mas secuencias de 4 letras iguales de ADN se pueden solapar, siempre y cuando sean de direcciones diferentes. Este tipo de secuencias contarán para determinar si un humano es mutante o no.
7. Se asume que las pruebas unitarias relacionadas con el dominio fueron aprobadas por el dueño del producto. [Ver](docs/CasosPruebas.xlsx) documento de pruebas unitarias.
8. Se asume que la solicitud de almacenamiento del DNA es para fines estadísticos, telemetría o BAM (Business Activity Monitoring).



### Architecture Decision Records (ADR)

* [01 Desacoplar proceso de análisis y de telemetría](docs/adr/2021-04-16_1_Separación-analisisdna-telemetria.md)
* [02 Selección repositorio de información de telemetría](docs/adr/2021-04-16_2_Persistencia-estadisticas.md)
* [03 Selección streaming processor de eventos de telemetría](docs/adr/2021-04-16_3_Streaming-processor-telemetria.md)
* [04 Broker de mensajería](docs/adr/2021-04-16_3_Broker-mensajeria.md)
* [05 Clean Arquitecture](docs/adr/2021-04-16_4_Clean-arquitecture.md)
* [06 Implementación de principios SOLID, SLAP, DRY](docs/adr/2021-04-16_5_Principios-solid.md)
* [07 Estrategia eficiencia computacional algoritmo de analisis ADN](docs/adr/2021-04-16_6_Eficiencia-computacional.md)
* [08 Observabilidad](docs/adr/2021-04-16_7_Observabilidad.md)

### Vista de Despliegue

diagrama



# Devops
### Build



### Tests



### Release



# Access Endpoint

TODO: Describe and show how to build your code and run the tests. 

[Health Check Enpoint]: www.google.com	"Healtch Check Enpodint"
[Open Api Endpoint]: www.google.com	"Swagger"

