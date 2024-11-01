# Eigen bijdrage Kevin Noppers

Als deliverable voor de individuele bijdrage in het beroepsproduct maak een eigen markdown bestand `<mijn-voornaam>.md` in je repo aan met tekst inclusief linkjes naar code en documentaties bestanden, pull requests, commit diffs. Maak hierin de volgende kopjes met een invulling.

Je schrapt verder deze tekst en vervangt alle andere template zaken, zodat alleen de kopjes over blijven. **NB: Aanwezigheid van template teksten na inleveren ziet de beoordelaar als een teken dat je documentatie nog niet af is, en hij/zij deze dus niet kan of hoeft te beoordelen**.

Je begin hier onder het hoofdkopje met een samenvatting van je bijdrage zoals je die hieronder uitwerkt. Best aan het einde schrijven. Zorg voor een soft landing van de beoordelaar, maar dat deze ook direct een beeld krijgt. Je hoeft geen heel verslag te schrijven. De kopjes kunnen dan wat korter met wat bullet lijst met links voor 2 tot 4 zaken en 1 of 2 inleidende zinnen erboven. Een iets uitgebreidere eind conclusie schrijf je onder het laatste kopje.


## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Voor de codebijdragen heb ik de volgende stukken gemaakt, Ik ben bezig geweest met het instellen van de rancher omgeving zoals het instellen van een Ingress controller. Het volgende waar ik mee bezig ben geweest is het opstellen van een argocd omgeving waar het mogelijk is om de applicatie te deployen.
Verder heb ik ookgewerkt aan de review microservice. In de volgende commits is te zien welke stukken code hiervoor zijn geschreven.

- ArgoCD configuratie - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/970b0b13bd81f5185dcc225f091d5cd88726ac51)
- Review microservice - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/e0f9f44b6490fe6daac8aa76fbdf214d68242c76#diff-8fcd706519c891c411dd7f587150ccaf8c5f532ff099879b41936f2d1fb6e498)
- Review micorservice - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/c2cb5dd228db214b67e3018b4dc23f2d50325f97)
- Review micorservice - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/a55518d3b15147fccf2b9db299fd4f560d0c4905)

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

Voor de bijdragen voor kuberetes heb ik op het begin een aantal docker files omgezet naar een kubernetes deployment. Verder heb ik ook een aantal services toegevoegd aan de rancher omgeving. Waarbij ik ook de nodige configuratie heb gedaan om de services te laten werken. Zoals de Argocd en de Ingress controller.

- Kompoze files - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/a474ce33f9653c7c32934390de7bddfebb382e6c)
- Rancher deployments - [rancher](https://rancher.k8s.devops.aimsites.nl:8443/dashboard/c/c-bq9ww/apps/catalog.cattle.io.app)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Voor het versiebeheer hebben wij als groep afgesproken om alle commits en branches te maken vanuit de taken. We hebben hier helaas geen documntatie van gemaakt omdat wij dit destijds in een discord call hebben afgesproken.

- Voorbeeld commit - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/a474ce33f9653c7c32934390de7bddfebb382e6c)
- Alternative commit - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/970b0b13bd81f5185dcc225f091d5cd88726ac51)

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model.

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Voor het onderzoek was mijn doel om te kijken naar terraform. Helaas is dit niet gelukt omdat wij een k8s server van de HAN hadden gekregen. Hierdoor was het niet nodig om terraform te gebruiken. Ik heb wel gekeken naar de mogelijkheden van terraform en hoe dit in combinatie met kubernetes gebruikt kan worden.
Omdat ik alsnog een opdracht nodig had voor mijn onderzoek te implementeren in dit project heb ik argocd geimplement en geconfigureerd. In de commits is te zien hoe ik dit heb gedaan.

- ArgoCD configuratie - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/970b0b13bd81f5185dcc225f091d5cd88726ac51)

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Ook voor het review proces heb ik gekeken naar de code van andere personen. Ik heb gekeken naar de code van de review microservice en heb hier feedback op gegeven. Ik heb gekeken naar de code en gekeken of de code voldoet aan de standaarden die wij als groep hebben afgesproken. Ik heb hier feedback op gegeven en de code is aangepast.


- Code review - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/33#pullrequestreview-2401876489)
- Code review - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/33#pullrequestreview-2401876342)

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Voor de documentatie ben ik bezig geweest met het C4 model, de argocd handleiding. Voor het C4 model heb ik gekeken naar het container diagram en de diagram van de services, verder voor de argocd handleding heb ik het een en ander in de documentatie hezet.

- C4 model - [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/tree/main/Docs/Models)
- ArgoCD handleiding - [handleiding](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/tree/main/Docs/argocd)

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Tijdens de scrum ceremonies heb ik een keer de notulen bijgehouden, hierin heb ik beschreven welke afsrpaken wij hebben gemaakt en wat voor planning wij verder moesten bijhouden. Verder heb ik inbreng gehad in het aanvullen als het gaat over de services zoals grafana, terraform of ansible. Als er onduiderlijkheid was had ik een stuk verteld waardoor de context duiderlijker werd.
Als laats heb ik ook een keer de eind sprint review gedaan en verteld over het technisch ontwerp waar vragen over waren. Hier ging het over waarom wij in de context diagram een customer en een mederweker hadden staan.

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Voor mijn leerervaring vond ik het mooi dat de docent met onderdelen kwam waar wij zelf nog niet aan hadden gedacht. Een goed voorbeeld is dat de docent wist te vertellen welke keuzes wij beter in het ASR hadden kunnen zetten. Hierdoor ben ik tot de conclustie gekomen dat het soms een goed idee is om af en toe eens de mening te vragen van iemand met ervaring, zoals een docent.
Verder wil ik mijzelf de top geven dat ik goed heb mee lopen denken binnen het team, Verder denk ik dat het ook goed was voor de gezelligheid binnen het team. De twee tips die ik voor mijzelf heb is dat niet veel kennis van DOTNET had en hier meer aan had moeten werken. Ook vind ik dat ik eerder hulp had moeten vragen met mijn onderzoek omdat ik blijkbaar niet optijd terraform kon opzetten.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Mijn conclusie in dit project is dat we een mooi project hebben neergezet. We hebben in de tijd vrijwel alles kunnen afronden en hebben een mooie samenwerking gehad binnen het team. Toch een mooie tip voor de volgende keer een soort dag afsluiting erin hebben om te zorgen dat iedereen weet wat er door wie is gemaakt die dag.
