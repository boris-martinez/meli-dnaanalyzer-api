# Architecture Decision Record (ADR)

This is the template in [Documenting architecture decisions - Michael Nygard](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions)

* **Author**: Boris Martinez.

* **Title**: Persistencia eventos reportes por tiempo.

* **Status**: accepted by Mario Aldana.

* **Context**: Se requiere seleccionar una tecnología que permita almacenar y consultar de manera costo-eficiente los reportes por tiempo de los vehiculos, al menos por 10 dias. Se estima que el tamaño de la data puede estar entre los 30 y 40 G para 15.000 vehículos.

* **Decision**: En primera instancia se utilizó un Azure Datalake gen2 para la ingesta de información, y Query Aceleration para la consulta de datos en el datalake. La ingesta de datos se implementó con resultados exitosos y a un bajo costo, sin embargo la consulta de los datos a través del Query Acceleration, evidenció algunos inconvenientes de latencia propios de Azure, en escenarios de alta concurrencia (32 hilos), sumado a los altos costos facturados por esta capacidad (1200 dolares mensuales). Como segunda alternativa, se implemento una Azure SQL, donde la información se guardó de forma particionada e indexada en 10 tablas usando un algoritmo hash MD5. Guardar la data particionada e indexada, ayudó a poder hacer consultas de manera eficiente, y que cumplieran con las necesidades del servicio. 

* **Consequences**: Se logró guardar los eventos de reportes por tiempo es una infraestructura costo-eficiente. Actualmente y para 15.000 véhiculos de Satrack se está utilizando una BD de 10 DTU, que cuesta 15 usd al mes.