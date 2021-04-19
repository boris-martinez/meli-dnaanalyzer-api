# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.

* **Title**: Selección del broker de mensajería.

* **Status**: accepted.

* **Context**: Se requiere utilizar un broker de mensajería que permita comunicar asincronicamente los diferentes sistemas en cuestión. Para el caso, el API de analisis DNA se integrará con el streaming processor a traves del broker, para la ingesta y almacenamiento de los eventos de telemetría (estadísticas verificaciones ADN).

* **Decision**: Se selecciona Azure Event Hub. Event Hub es una plataforma de mensajería administrada complementamente por Azure, hiper escalable, que soporta la ingesta de millones de eventos por segundo. Adicionalmente soporta los protocolos http, ampq y kafka. Para el caso, se utiliza amqp por restricciones económicas, pero en un escenario real, se utilizaría Kafka por ofrecer mejores prestaciones en cuanto al  rendimiento y la escalabilidad.

* **Consequences**: (1) Poder ingestar y leer eventos a una tasa de 100 o 1 millón de eventos por segundo ,(2) Poder escalar según necesidad, (3) Alta disponibilidad.

