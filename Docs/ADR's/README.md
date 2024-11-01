# Architectural Decision Records

## ADR-001: Klant kan geen eigen reservering maken

### Context
Het systeem bevat een functie waarmee gebruikers reserveringen kunnen maken. Er was een overweging om klanten zelf een reservering te laten plaatsen in plaats van deze door een medewerker te laten uitvoeren.

### Beslissing
Er is besloten om de mogelijkheid voor klanten om zelf een reservering te maken niet te implementeren.

### Redenatie
- **Tijdsbesparing:** Om klanten zelfstandig reserveringen te laten maken, zou een inlogpagina moeten worden ontwikkeld. Dit zou extra ontwikkeltijd kosten.
- **Weinig toegevoegde waarde:** De functionaliteit die een medewerker biedt bij het maken van een reservering is vrijwel identiek aan wat een klant zelf zou doen. Hierdoor voegt het weinig functionele waarde toe om klanten zelfstandig te laten reserveren.
- **Alternatief overwogen:** Er was een optie om het formulier te ontwerpen vanuit de aanname dat een gebruiker al ingelogd was, maar ook dit zou extra tijd vergen met weinig extra voordelen.

### Gevolg
Door klanten geen eigen reserveringen te laten maken, kunnen we ontwikkeltijd inzetten voor andere functionaliteiten die meer waarde toevoegen.

## ADR-002: Met Draw.IO of Structurizr het C4 Model ontwerpen

### Context
Er moet een keuze gemaakt worden over welk programma gebruikt gaat worden om het C4 Model te ontwerpen.

### Beslissing
Er is besloten om Draw.IO te gebruiken om het C4 Model te ontwerpen.

### Redenatie
- **Tijdsbesparing:** Draw.IO is al bekend bij de teamleden en is makkelijk te gebruiken. Er is kort onderzocht naar Structurizr, maar dit programma is niet bekend bij de teamleden en zou meer tijd kosten om te leren en opzetten.
- **Gebruiksvriendelijkheid:** Draw.IO is een online tool die makkelijk te gebruiken is en waarbij je makkelijk diagrammen kan maken.

## ADR-003: Reservering wijzigen

### Context
Het systeem bevat een functie waarmee gebruikers gemaakte reserveringen kunnen wijzigen. Er was discussie over welke gegevens van een reservering gewijzigd kunnen worden.

### Beslissing
Er is besloten om enkel de einddatum en de huurauto van de reservering te wijzigen. De startdatum en de klantgegevens kunnen niet gewijzigd worden.

### Redenatie
- **Geen inlogmogelijkheden:** In het MVP dat wij ontwikkelen is geen login functionaliteit aanwezig, waardoor bij iedere reservering de klant gekozen kan worden. Logischerwijs wordt er later een loginsysteem ontwikkeld waardoor de niet gekozen hoeft te worden bij een reservering, maar hij automatisch wordt toegevoegd. Als een klant zijn/haar reservering wijzigt zal de klant altijs hetzelfde blijven. Daarom is ervoor gekozen ook nu geen klantgegevens te wijzigen.

### Gevolg
Door enkel de einddatum en de huurauto van de reservering te wijzigen, kunnen we ontwikkeltijd inzetten voor andere functionaliteiten die meer waarde toevoegen.

## ADR-004: Entity Framework Core vs Dapper

### Context
Bij de ontwikkeling van de applicatie moet een keuze gemaakt worden tussen Entity Framework Core en Dapper als ORM. Beiden
zijn populair en hebben hun eigen voor- en nadelen. Wij moeten een keuze maken welke van de twee wij gaan gebruiken.

### Beslissing
We kiezen voor Entity Framework Core als ORM voor onze applicatie.

### Redenatie
- **Tijdsbesparing:** Entity Framework Core is een ORM die veel zaken voor ons afhandelt. Hierdoor hoeven wij minder code te schrijven en kunnen wij sneller ontwikkelen.
- **Migraties:** Entity Framework Core heeft een ingebouwde migratie tool die het makkelijk maakt om de database te updaten. Dapper heeft deze tool niet.

### Gevolg
Door Entity Framework te kiezen kunnen we tijd besparen op de ontwikkeling van de applicatie. Dit betekent dat we sneller nieuwe functionaliteiten kunnen toevoegen en bugs kunnen oplossen.
Doordat we beperkte tijd hebben om deze applicatie verder te ontwikkelen is het belangrijk dat we zo snel mogelijk nieuwe functionaliteiten kunnen toevoegen.