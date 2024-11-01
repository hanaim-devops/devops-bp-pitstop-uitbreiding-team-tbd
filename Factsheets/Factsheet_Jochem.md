# Eigen bijdrage Jochem Kalsbeek

Ik had tijdens het stage leren werken met .NET en Entity Framework. Door deze stage had ik al enige ervaring met het werken met .NET en Entity Framework.
Hierdoor kreeg ik al snel de rol voor het opzetten van extra microservices waarbij ik ook hulp bood aan overige groepsgenoten.
Hierdoor ben ik ook voornamelijk verantwoordelijk geweest voor de het uitwerken van de functionaliteit.

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Ik heb bijgedragen aan de volgende pull requests en commits:

- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/18
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/37
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/34
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/12f8269b99b67f5404f95a5c3e5dcf3f1901fcd6
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/a3a1d3a05e969c870beac6cabb7595189b3e9129
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/632dbbe7a17435add91b7e5751a942371db77a54

Een voorbeeld van code waar ik het meest trots op ben is de volgende commit:
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/34/commits/51f4824c656d39913cdff2288de3abcef122487e

Hierbij heb ik een lelijke switch case omgezet naar een strategy pattern waarmee de verschillende events worden afgehandeld. Zodat
de RentalManagementEventHanlder open closed blijft.
Hoe deze strategy pattern werkt staat beschreven in het technisch ontwerp.

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/18/commits/7f3dca0f7671dc1a749be15645b0c1d69b478f58

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

In onderstaande commit heb ik in de code een extra try-catch block toegevoegd die een eventuele exception logt bij de logging service.

- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/2d05172f9d71f07ce9afaf12aa423d1e370ba855


## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Ik heb onderzoek gedaan naar Dapper tijdens de course-fase. We hebben er echter voor gekozen om dit niet te implementeren in ons project.
In plaats daarvan hebben we gekozen voor Entity Framework Core. Waarom deze keuze is gemaakt en wat het gevolg was van deze keuze is te lezen in de volgende commit:

- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/4af5a7896d3deb95e31133be950d8eb1c21a0306

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Ik heb bijgedragen aan het reviewen van de code van mijn groepsgenoten. Hierbij heb ik feedback gegeven op de volgende pull requests:

- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/42
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/29


## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Ik heb bijgedragen aan het C4-model het opstellen van een context diagram, container diagram en een aantal component diagrams. 
Hierbij heb ik de volgende commits gedaan:

- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/b96e325583c93b30c6783a4ae682d65ad2f46b59
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/4af5a7896d3deb95e31133be950d8eb1c21a0306
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/cd29473b5357f852a84a1937da883089ece52b7c
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/ee686e5e98b4957f3b52fd8bb2126e290cff5386
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/2947e12eed56dfcd79cf4caf8e9584a067976580
- https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/81aa6d428cbd3808fa1c20024a194bd2246e0ab7


## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Ik ben tijdens de eerste sprintreview voorzitter geweest. Hierbij heb ik de sprintreview geleid en de presentatie gegeven.
Tijdens de sprintreview heb ik de voortgang van de sprint besproken en de demo gegeven. Hierbij heb ik ook de feedback van de opdrachtgever
opgehaald en deze besproken met het team.

De daily standups heb ik over het algemeen geleid. Waarbij ik duidelijk probeerde te krijgen waar mensen op vast liepen. En of ik ze kon helpen.
Ook verdeelde we tijdens de daily standups de taken onderling.

Door dat ik tijdens mijn stage met .NET en Entity Framework Core had gewerkt. Was ik in staat om mijn groepsgenoten te helpen op punten
waar zij vast liepen. Dit maakte mij een toevoeging aan het groepsproces. 

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Tijdens het project heb ik een fout begaan om niet altijd te testen op productie. Ik was tijdens het project na het realiseren
van een feature vergeten om deze te testen op productie. Hierdoor kwam ik er pas later achter dat de feature niet werkte op productie. Lokaal
werkte deze feature wel. Dit was een goede les voor mij om altijd te testen op productie. Dit is iets wat ik zeker mee ga nemen in mijn verdere loopbaan.

Naast werkte ik chaotisch op het gebied van taken. Ik was snel afgeleid door een andere taak. Dit is iets wat ik in de toekomst beter wil gaan doen. Om van
te voren specifiek te bepalen welke taken ik ga uitvoeren en deze ook af te ronden voordat ik aan een andere taak begin.

Er waren ook dingen die wel goed gingen tijdens het project. Zo heb ik goed samengewerkt met mijn groepsgenoten. We hadden een goede communicatie en
we konden goed overleggen over de taken die we moesten uitvoeren. Dit is iets wat ik zeker mee ga nemen in mijn verdere loopbaan.

Als laatste was ik positief over de codekwaliteiten tijdens het project. Op de code die aangeleverd was die we verder moesten uitwerken heb ik een aantal code smells kunnen spotten.
En heb deze verbeterd in de uitbreiding.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Tijdens dit project heb ik een waardevolle bijdrage geleverd aan zowel de ontwikkeling van microservices als aan de configuratie, 
het versiebeheer en de documentatie. Mijn kennis van .NET en Entity Framework, opgedaan tijdens mijn stage,
was van grote waarde bij het opzetten van de microservices en het helpen van teamgenoten.

Daarnaast heb ik, door feedback te geven op pull requests en betrokken te zijn bij code reviews, bijgedragen aan de
kwaliteit van onze code.

Dit project was een leerzame ervaring, met enkele lessen die ik zal meenemen in mijn loopbaan. 
Zo heb ik geleerd altijd te testen in de productieomgeving, omdat er onverwachte verschillen kunnen zijn met de lokale omgeving. 
Ook heb ik meer inzicht gekregen in mijn werkstijl; ik realiseer me dat ik gestructureerder met taken wil omgaan door een betere planning en het afronden van taken voordat ik aan iets nieuws begin.
