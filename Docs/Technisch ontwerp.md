﻿# Technisch ontwerp
## Inleiding
Dit technisch ontwerp is geschreven aan de hand van het C4-model. Dit model is tussen
2006 en 2011 bedacht door Simon Brown. Dit model documenteert de architectuur van
softwaresystemen door meerdere overzichtsniveaus te tonen die de decompositie van een
systeem in containers en componenten, de relatie tussen deze elementen en, waar van
toepassing, de relatie met zijn gebruikers verklaren. Hieronder staan de overzichtsniveaus
met een korte uitleg:

● Level 1: Context: <br>
Dit niveau toont het geheel van het systeem en de relatie met
gebruikers en andere systemen.

● Level 2: Container: <br>
Ontbindt het systeem in onderling gerelateerde containers. Een
container stelt een applicatie of database voor.

● Level 3: Component: <br>
Dit niveau ontbindt de verschillende containers in meerdere
componenten en laat de relatie tussen de componenten zien.

● Level 4: Code: <br>
Dit niveau geeft de bouwstenen weer waarmee de componenten zijn
opgebouwd. Hij bevat bijvoorbeeld class diagrams, sequence diagrams en activity
diagrams.

Om de lezer het eenvoudig te maken is er een legenda opgesteld waarin beschreven wordt
welke onderdelen terug gaan komen in dit document en welke kleur daaraan gekoppeld
staat:

![legenda.jpg](images%2Flegenda.jpg)

## Level 1: Context

![Context.png](images%2FContext.png)

Hierboven staat de context diagram van de Pitstop applicatie. Goed te zien is dat het systeem twee verschillende gebruikers kent.
De klant en de monteur. De klant kan een afspraak maken en de monteur kan deze afspraak accepteren of weigeren. 
De klant kan ook een review achterlaten over de monteur. Waarna de monteur aangeeft klaar te zijn met de reparatie. Zal
er automatisch een factuur worden verstuurd via de mail richting de gebruiker. Tijdens de reperatie kan een medewerker of een klant
een leenauto reserveren. 


## Level 2: Container
![Container diagram.png](images%2FContainer%20diagram.png)

Hierboven staat het container diagram van de Pitstop applicatie. Goed te zien is dat pitstop geen monolith is. Hij is
opgedeeld in meerdere microservices elke microservice heeft zijn eigen verantwoordelijkheid. Mocht een microservice afhankelijk
zijn van een andere microservice dan wordt er gebruik gemaakt van RabbitMQ. Een goed voorbeeld hoe dit werkt is wanneer er een Customer wordt
toegevoegd. De CustomerManagementAPI voegt de customer toe en na toevoegen zal hij een event sturen naar RabbiMQ. Dit event
wordt vervolgens doorgestuurd naar de WorkshopManagementAPI en de RentalManagementAPI. Deze twee microservices zal hierop reageren
door de net aangemaakte customer toe te voegen aan hun eigen database. Dit volgt het principe van Autonomy over Authority.
Hierbij houdt elke microservice zijn eigen context bij en slaan meerdere microservices misschien wel dezelfde data op. Zoals te zien
op het volgende plaatje over een bounded context.

![Bounded context.jpg](images%2FBounded%20context.jpg)

Deze aanpak voorkomt dat microservices veel met elkaar moeten communiceren. Daarnaast zorgt dit voor een stabielere applicatie.
Mocht er een microservice uitvallen dan zal de rest van de applicatie nog steeds werken. En omdat ze een eigen versie bijhouden
van hun bounded context hoeven ze die in dat geval niet op te halen bij een andere microservice. En kunnen zij daarom gewoon
doorgaan met hun werkzaamheden.

## Level 3: Components

### Customer Management

![Component diagram CustomerManagementAPI.drawio.png](images%2FComponent%20diagram%20CustomerManagementAPI.drawio.png)

In dit component diagram is te zien dat de CustomerManagementAPI wordt aangeroepen door de WebApp. Eerst wordt de controller aangeroepen. Die stuurt vervolgens de request door naar de service. De service zal vervolgens de gebruik maken van de CustomerManagement database om data te lezen, te wijzigen of te verwijderen. Ook kan de service een event sturen naar RabbitMQ. Op deze manier kunnen andere services (die luisteren naar events van de CustomerManagementAPI, via RabbitMQ) het event ontvangen. Dit wordt bijvoorbeeld gedaan door de RentalManagementEventHandler en de WorkshopManagementEventHandler om de nieuwe customer toe te voegen aan de de RentalManagement en de WorkshopManagement database.

### Workshop Management

![Component diagram Workshop.drawio.png](images%2FComponent%20diagram%20Workshop.drawio.png)

In dit component diagram is te zien dat de WorkshopManagementAPI wordt aangeroepen door de WebApp. In de controller wordt alle logica uitgevoerd en wordt de repository aangeroepen die vervolgens gebruik maakt van de WorkshopManagement database om data te lezen, te wijzigen of te verwijderen.

### Rental Management

![Component diagram RentalManagementAPI.drawio.png](images%2FComponent%20diagram%20RentalManagementAPI.drawio.png)

In dit component diagram is te zien dat de RentalManagementAPI wordt aangeroepen door de WebApp. Eerst wordt de controller aangeroepen. Die stuurt vervolgens de request door naar de service. De service zal vervolgens de gebruik maken van de RentalManagement database om data te lezen, te wijzigen of te verwijderen.

### Review Management
![Component ReviewManagementAPI.drawio.png](images%2FComponent%20ReviewManagementAPI.drawio.png)

In dit component diagram is te zien dat de ReviewManagementAPI wordt aangeroepen door de WebApp. Als eerste wordt de controller aangeroepen. Die stuurt vervolgens de request door naar de service. De service zal vervolgens de gebruik maken van de ReviewManagement database om data te lezen, te veranderenof te verwijderen.

### Rental Car Management

![Component diagram RentalCarManagementAPI.drawio.png](images%2FComponent%20diagram%20RentalCarManagementAPI.drawio.png)

In dit component diagram is te zien dat de RentalCarManagementAPI wordt aangeroepen door de WebApp. Eerst wordt de controller aangeroepen. Die stuurt vervolgens de request door naar de service. De service zal vervolgens de gebruik maken van de RentalCarManagement database om data te lezen, te wijzigen of te verwijderen. Ook kan de service een event sturen naar RabbitMQ. Op deze manier kunnen andere services (die luisteren naar events van de RentalCarManagementAPI, via RabbitMQ) het event ontvangen. Dit wordt bijvoorbeeld gedaan door de RentalManagementEventHandler om de nieuwe rental car toe te voegen aan de RentalManagement database.

### Vehicle Management

![Component diagram VehicleManagementAPI.drawio.png](images%2FComponent%20diagram%20VehicleManagementAPI.drawio.png)

In dit component diagram is te zien dat de VehicleManagementAPI wordt aangeroepen door de WebApp. Eerst wordt de controller aangeroepen. Die stuurt vervolgens de request door naar de service. De service zal vervolgens de gebruik maken van de VehicleManagement database om data te lezen, te wijzigen of te verwijderen. Ook kan de service een event sturen naar RabbitMQ. Op deze manier kunnen andere services (die luisteren naar events van de VehicleManagementAPI, via RabbitMQ) het event ontvangen. Dit wordt bijvoorbeeld gedaan door de WorkshopManagementEventHandler om de nieuwe vehicle toe te voegen aan de WorkshopManagement database.

### Rental Management Event Handler

![Component diagram RentalManagementEventHandler.drawio.png](images%2FComponent%20diagram%20RentalManagementEventHandler.drawio.png)

In dit component diagram is te zien dat de RentalManagementEventHandler event notificaties ontvangt van RabbitMQ. De RentalManagementEventHandler zal vervolgens de notificatie verwerken en de data toevoegen aan de RentalManagement database.

### Workshop Management Event Handler

![Component diagram WorkshopManagementEventHandler.drawio.png](images%2FComponent%20diagram%20WorkshopManagementEventHandler.drawio.png)

In dit component diagram is te zien dat de WorkshopManagementEventHandler event notificaties ontvangt van RabbitMQ. De WorkshopManagementEventHandler zal vervolgens de notificatie verwerken en de data toevoegen aan de WorkshopManagement database.

## Level 4: Code
![eventhandler.jpg](images%2Feventhandler.jpg)

Hierboven staat een class diagram die gehaald is uit de RentalManagementAPI component. Deze classes zijn verantwoordelijk
voor het afhandelen van events uit RabbitMQ. Dit is een variant van de strategy pattern om zo de
EventHandlerWorker open closed te houden. Wanneer er een event binnenkomt met een bepaalde messagetype dan wordt er in de
lijst met handlers gekeken naar een overeenkomende handler die vervolgens verantwoordelijk wordt gesteld om dat specifieke
event af te handelen.