# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.
* **Title**: Implementar la solución utilizando el concepto de aquitectura limpia.
* **Status**: accepted.
* **Context**: Se requiere implementar el componente analizador de DNA de una forma muy entendible, donde la logica de dominio del analizador esté completamente aislada y desacoplada de la logica de aplicación (API) e infraestructura; lo anteior para promover la mantenibilidad, extensibilidad y testeabilidad del componente.
* **Decision**: Se implementa la solución bajo una arquitectura hexagonal y se modela el dominio utilizando algunos principios de Onion Arquitecture y Domain Driven Design (DDD). Se definen 3 adaptadores primarios (capa rest, unit test, integration test) y 3 secundarios con sus respectivos puertos (Notificador de eventos de dominio, publicador de eventos de integración,  repositorio de estadísticas Elasticsearch). El dominio se estructura de la siguiente manera: 2 servicios de dominio con sus respectivos puertos (servicio de estadisticas y analizador DNA), las entidades necesarias para modelar el analisis de dna y sus estadisticas (todas con comportamiento y un apropiado nivel de encapsulamiento, evitando crear un  modelo anémico), 1 evento de dominio para notificar al adaptador primario (capa de aplicación) cuando un DNA es verificado. Cuando un DNA es verificado, la capa de aplicación se suscribe a ese evento y publica un evento de integración relacionado con la telemetría (a través de un adaptador secundario); de esta forma se desacopla la lógica de ingesta de  telemetría con la lógica de dominio de analisis de DNA/calculo estadísticas.
* **Consequences**: (1) Software con mayor grado de mantenibilidad, (2) software mas entendible, (3) software habilitado para ser probado a traves de test automáticos.

