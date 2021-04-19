# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.
* **Title**: Segregación de responsabilidades. Se separa el proceso de telemetría del proceso core de analisis de DNA.
* **Status**: Accepted.
* **Context**: Se requiere maximizar la eficiencia computacional de la API, promover la alta disponibilidad con un buen esquema de tolerancia a fallos y promover la escalabilidad con el fin de poder soportar entre 100 y 1 millón de peticiones por segundo.
* **Decision**: Se decide desacoplar el proceso de telemetría del proceso core de analisis de DNA con el fin  que ambos procesos puedan escalar de manera independiente y evitar que fallos en el almacenamiento de la telemetría afecte el proceso de analisis. De acuerdo a lo anterior, entonces una vez se haga la verificación de DNA, se ingestará el resultado a un broker de mensajería amqp, para que posteriomente a través de otro proceso independiente, se lea dicha información y se almacene en un repositorio NOSQL.
* **Consequences**: (1) Procesos aislados  e independientes (un fallo en uno de los procesos, no afecta al otro). (2) Ambos procesos pueden escalar de manera independiente. (3) Optimización en los tiempos de respuesta de la API al tener que realizar un menor trabajo. (4) Consistencia eventual en las estadisticas.