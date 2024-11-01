# Eigen bijdrage Daan Memelink

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Voor de Rental Management heb ik de frontend gemaakt.  
De Review Management werkte niet door een spelfout in de naam van de solution. Dit heb ik (samen met nog een aantal andere kleine bugs) opgelost waardoor de Review Management gebuild kon worden.

- [Frontend voor RentalCarManagement](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/bdcc9e844de26dbd34c34b0e38247ac114d6c5dd)
- [Bug fixes RentalManagement & RentalCarManagement](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/a3a218d26ac021e7776b073ba09bf03601094d9b)
- [Bug fixes ReviewManagement](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/fa0bb0e90ead9dd51e36936d2e72da50d3bb040b)

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

Bij het aanmaken van de nieuwe services RentalManagementAPI, RentalCarManagementAPI en RentalManagementEventHandler heb ik dockerfiles gemaakt. Ook heb ik de docker-compose file geupdate zodat de nieuwe services met docker compose gebuild en gestart kunnen worden.
 
- [Nieuwe services toegevoegd](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/198d53450a6ac9057344f9ce46016933178b5b55)
- [Docker compose file aangepast](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/fa0bb0e90ead9dd51e36936d2e72da50d3bb040b#diff-cd2ae9f5a501d16253a461b919af1523e71916a984989885e6783203f4ee252a)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Aan het begin van dit project hebben we onderling mondelinge afspraken gemaakt over de naamgeving van branches en pull requests. In de branches staat het issue nummer van de issues op het scrumbord. Pull requests hebben dezelfde naam als branches. 
In de ReviewManagementAPI zat een spelfout (deze heette eerst ReviewManagmentAPI). Dit zorgde voor problemen. Samen met Danny heb ik dit opgelost. Ik heb de commit gemaakt, maar heb (voor traceerbaarheid) Danny als co-author toegevoegd aan de commit.

- [Branch naam gemaakt conform afspraken](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/tree/feature/%238-reservering-wijzigen)
- [Pull request gemaakt conform afspraken](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/35)
- [Commit met co-author](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/fa0bb0e90ead9dd51e36936d2e72da50d3bb040b)

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Tijdens de course-fase heb ik onderzoek gedaan naar Litmus Chaos. Zie [mijn blog post hier](https://github.com/hanaim-devops/devops-blog-DaanMemelink/tree/main/src/robuustheid-voor-microservices).
Ik heb geprobeerd om LitmusChaos te implementeren in de Pitstop applicatie. De installatie van het ChaosCenter mislukte echter doordat MongoDB een persistent volume vereiste, wat niet kon in Rancher.
Ik heb dit gedebugged door te kijken naar de status van de verschillende pods. Daarin was te zien dat de LitmusChaos services aan het wachten waren op MongoDB. In de logs van MongoDB was te zien dat deze een persistent volume nodig had.  
In [ChaosExperiment.yaml](..%2FDocs%2Flitmuschaos%2FChaosExperiment.yaml) heb ik de ChaosExperiment aangemaakt. Als LitmusChaos het zou doen op Rancher zou ik dit experiment kunnen uitvoeren waarmee de RentalCarManagementAPI gekilled wordt.

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Op de pullrequests van Danny en Kevin over de ReviewManagement service heb ik twee reviews gedaan. Ik heb kritisch gekeken naar de code en gezegd wat er verbeterd kon worden voordat de code naar de development branch gemerged mocht worden.

- [Review op pull request ReviewManagement sterren geven](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/30#pullrequestreview-2401757022)
- [Review op pull request ReviewManagement bericht toevoegen aan review](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/31#pullrequestreview-2401839322)

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Ik heb verschillende documentatietaken opgepakt. Zo heb ik een ADR gemaakt, een component diagram gemaakt en de component diagrammen toegevoegd aan het technisch ontwerp.

- [ADR toegevoegd](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/134cbd6d76974900cafef36916a0ca656b383f56)
- [CustomerManagement component diagram gemaakt](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/99edae1bd8512c4402e8b1d7b12fb3580d790731)
- [Technisch Ontwerp component diagrammen toegevoegd](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/98d8790067c190ebd1d94aa60824feba92e8c77f)

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Tijdens de sprint planning van de tweede week van het project en tijdens de laatste sprint review ben ik voorzitter geweest. Hierin probeerde ik de tijd te bewaken en aan het einde van elk onderwerp te inventariseren of er mensen nog vragen of opmerkingen hadden.  
Tijdens de sprint review heb ik aangegeven dat we als team door moeten gaan met het helpen bij elkaars taken, hier was de rest van de groep het helemaal mee eens. Ook heb ik gezegd dat we het planningsbord beter moeten bijhouden en de tijd voor de persoonlijke factsheet beter moeten inplannen. 

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

**Tips**
- Als ik van een onderwerp geen verstand had vroeg ik al snel anderen met meer verstand van het onderwerp naar een oplossing. Ik kreeg de feedback dat ik zelf wat langer moet zoeken naar een oplossing en als ik er dan nog steeds niet uit kom naar anderen kan vragen.
- Een tip voor mij en de rest van de groep is plannen. We hadden nu meer prioriteit gegeven aan de functionaliteiten in plaats van de documentatie. Daardoor kwamen we op het einde een beetje in tijdsnood.

**Tops**
- Gestructureerde meetings. De twee keren dat ik voorzitter was bij de scrum meetings kreeg ik de feedback dat ik een duidelijke structuur aan de meetings bracht.
- Van mijn groepsgenoten kreeg ik te horen dat mijn communicatie helder was en dat het maken van afspraken daarom makkelijk gaat.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Dit project gaf me waardevolle praktijkervaring met DevOps, vooral in containerisatie en event handling. De focus op goede communicatie en samenwerking verbeterde onze workflow en codekwaliteit.
Voor het afstuderen en mijn verdere loopbaan neem ik de kennis over microservices, containerisatie en event handling mee.
