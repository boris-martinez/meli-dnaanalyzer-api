# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.

* **Title**: Selección herramienta de streaming para procesar los eventos de telemetría.

* **Status**: accepted.

* **Context**: Se requiere procesar de manera concurrente todos los eventos de telemetria enviados al broker de mensajería, transformarlos en una estructura mas eficiente para consulta y luego almacenarlos en Elasticsearch. Adicionalmente, este proceso tambien debe ser altamente escalable ya que procesará entre 100 y 1 millón de eventos por segundo.

* **Decision**: Se selecciona Logstash, la cual es una herramienta que permite construir de manera muy simple pipelines de procesamiento, utilizando un DSL basado en archivos de configuración. Ademas Logstash cuenta con multiples plugins para operaciones de entrada, salida y transformación de datos, soporta multithreading y escala facilmente al adicionar mas nodos de procesamiento.

* **Consequences**:  (1) Alta escalabilidad para soportar el procesamiento de eventos a una tasa de 100  o 1 millón de eventos por segundo. (2) Velocidad en desarrollo, pues construir un pipeline de procesamiento se hace en minutos.
