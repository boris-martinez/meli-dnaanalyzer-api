# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.

* **Title**: Selección del repositorio de información de la telemetría

* **Status**: accepted.

* **Context**: Se necesita seleccionar el repositorio de información que almacenará la telemetría enviada por la API de analisis de DNA. Debido a que la información a guardar tiene caracteristicas de big data, se requiere una estructura que pueda almacena grandes volumenes de información, que pueda escalar para soportar entre 100 y 1 millón de peticiones por segundo  y que la información pueda ser consulta de manera muy rapida.

* **Decision**: El repositorio seleccionado es Elasticsearch. Elasticsearch es una base de datos nosql, distribuida y  orientada a documentos , optimizada para realizar busquedas eficientes sobre grandes volumnes de información y un gran potencial para escalar según necesidad. Generalmente elasticsearch es usado para almacenar información de logs y telemetría de las aplicaciones, para luego ser consultada de forma agregada a traves de dashboards. 

* **Consequences**:  (1) Sistema altamente escalable que permitirá soportar entre 100 y 1 millon de operaciones por segundo. (2) Gran performance en operaciones de lectura y escritura. (3) Soporte a agregaciones en las consultas, lo cual es necesario para cuantificar la cantidad de mutantes y no mutantes.

