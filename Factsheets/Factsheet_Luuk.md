# Eigen bijdrage Luuk Stins

In dit document laat bespreek ik mijn eigen bijdrage aan het pitstop project. Ik heb me verdiept in tools zoals Tekton, Kaniko maar ook .net asp Tegelijkertijd heb ik gewerkt aan mijn soft skills en ben ik mijn vaardigheden in Git verder gaan verdiepen door alles via de CLI te beheren. Dit project bood een waardevolle leerervaring in het werken met microservices en moderne DevOps-praktijken.

## 1. Code/platform bijdrage

Beschrijf hier kort je bijdrage vanuit je rol, developer (Dev) of infrastructure specialist (Ops). Als Developer beschrijf en geef je links van minimaal 2 en maximaal 4 grootste bijdrages qua code functionaliteiten of non-functionele requirements. Idealiter werk je TDD (dus ook commit van tests en bijbehorende code tegelijk), maar je kunt ook linken naar geschreven automatische tests (unit tests, acceptance tests (BDD), integratie tests, end to end tests, performance/load tests, etc.). Als Opser geef je je minimaal 2 maximaal 4 belangrijkste bijdragen aan het opzetten van het Kubernetes platform, achterliggende netwerk infrastructuur of configuration management (MT) buiten Kubernetes (en punt 2).

## 2. Bijdrage app configuratie/containers/kubernetes

[Change k8s image pull policy](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/4a557a02e46642eee8f8efaf40a3bbdb1e702b1f)

Het veranderen van de image pull policy zodat ookal is de versie niet veranderd kubernetes de image opnieuw pulled.

[Update env for all](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/0f058dd94485d92aca7d62eb02f1b5030b7f3b4e)

Zet specifieke environment variables aan de container die de gegenereerde foutmeldingen op kubernetes oplost.

[Document volume settings in kubernetes for pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/2d8dcbfa18170490aedad87079f70c2111a28c26)

Configureer een automatische storage claim configuratie die ervoor zorgt dat elke task in de pipeline een pvc krijgt.

[service dockerfiles](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/360c4189b94884b7b8a740d1b6c3d242dc2b3471)

Pas de folder structuur aan dat de pipeline template ook de sdk docker images kan genereren.

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

[kaniko script to build & deploy images](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/50c42152ced359a0318853ee00d35121cd44e958)

Docker loopt niet op kubernetes dus als je docker images wilt maken in een pipeline is er iets anders nodig. Hiervoor heb ik een kaniko script gemaakt die het mogelijk maakt om alsnog docker images te builden op de kubernetes pipeline.

[git clone run](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/a6e321c0fce7f56d4f07c78e39ab68f55b2dc62f)

Als je een pipeline wilt bouwen heb je ook een source nodig waar de bestanden op staan. Deze task template zorgt ervoor dat elke pipeline snel en op een handige manier via deze task template een git repo can pullen.

Door gebruik te maken van deze task templates heb je automatisch te manier hoe een repo wordt gepulled of een docker image wordt gebuild in de pipeline gestandaardiseerd.

## 4. Onderzoek

[Tekton: 'Objectgeoriënteerde' Jenkins met een Kubernetes-sausje](https://github.com/hanaim-devops/devops-blog-luukjp/blob/main/src/tekton-jenkins-met-een-kubernetes-sausje/README.md)

Tijdens het Course BP heb ik de technologie tekton onderzocht. Het implementeren hiervan was over het algemeen vrij simpel. Hoewel ik had verwacht dat de yaml syntax lastig zou zijn door het onderzoek was het vanaf het begin vrij vanzelf sprekend met de hulp van de tekton docs. Het is gelukt om volledig gebruik te maken van de modulaire aanpak van tekton en zo 'object georienteerde' pipelines te maken doormiddel van task en pipeline templates. Bij een pipeline verwacht je dat hij automatisch builds kan genereren. Aan de hand van de gegeven omgeving door school is het niet gelukt door via webhooks de pipeline runs automatisch te starten. Helaas heb ik hier veel tijd in gestoken maar is er niks nuttigs naar buiten gekomen. Ik wou heel graag dat het had gewerkt maar helaas moet de pipeline voor een productie build nog handmatig getriggerd worden. De automatische pipeline runs had ons veel tijd bespaard door de code in de main branch automatisch op productie te krijgen.
 
## 5. Bijdrage code review/kwaliteit anderen en security

[32 als klant wil ik een review bericht kunnen verwijderen zodat ik mijn review terug kan trekken als het niet meer van toepassing is #38](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/38)

[Bump async from 2.6.1 to 2.6.4 in /src/WebApp/wwwroot/lib/bootstrap #26](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/26)

[Bump set-value and union-value in /src/WebApp/wwwroot/lib/bootstrap #21](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/21)

[Bump json-schema and jsprim in /src/WebApp/wwwroot/lib/bootstrap #24](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/pull/24)

Bijgedragen aan het reviewen van de pr's van Danny en dependabot. Bij de eerste pr heb ik een puntje aangebracht waardoor het reviewen van de branch mij onnodig veel tijd kostte. De andere pr's heb ik gereviewed en hierbij getest of de dependency updates de code brak. Het reviewen van deze branch is belangrijk voor de security van de applicatie.

## 6. Bijdrage documentatie

[Required Secrets for Tekton Pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/blob/main/tekton/tekton.md)

Het installeren van secret keys kan een hele operatie zijn. De documentatie hier boven legt uit hoe je de docker registry secrets kan instellen.

[Setting Up Volumes with Local Path Provisioner](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/blob/main/tekton/volume-info.md)

Het opzetten van de storage claims was een heel gedoe. Daarom heb ik een korte documentatie gemaakt hoe je een local path provisioner kan installeren op rancher en waarvoor dit belangrijk is.

[Create Component diagram VehicleManagementAPI.drawio](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/commit/9cf6194749fe227025e534583072b5e692ca6ce4)

![Component diagram VehicleManagementAPI](https://raw.githubusercontent.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-tbd/refs/heads/main/Docs/images/Component%20diagram%20VehicleManagementAPI.drawio.png)

Ik heb een C4 component diagram gemaakt van de VehicleManagementAPI in dit model kan je op een globale en makkelijke manier zien hoe de container in elkaar steekt.

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

In de eerste week en in de eerste meeting ben ik de notulist geweest. Hierbij heb ik de belangrijkste zaken van de meeting genoteerd, zodat we als team hierop kunnen terug vallen na de vergadering zodat we niks missen.

Tijdens de retrospective was er naar voren gekomen dat niet iedereen even op tijd was. Als team hebben we gezamelijk ervoor gekozen om een daily standup om 9:15 in te plannen om er voor te zorgen dat er een duidelijk tijd is waar je aanwezig moet zijn op school.
  
## 8. Leerervaringen

Tops:

- Om de essentie van van git beter te begrijpen heb ik alleen maar gebruik gemaakt van git cli dit project, zodat ik mijn geleerde kennis in de courses herhaal en dit niet meer zal vergeten.
- Het configureren van kubernetes en de pipeline heeft heel veel tijd moeite en stress veroorzaakt. Er waren heel veel variabelen waarbij ik rekening heb moeten houden omdat telkens een nieuw probleem veroorzaakt werd. Ondanks alle problemen ben ik er in geslaagd om door te gaan zodat het uiteindelijk heeft gewerkt.

Tips:

- Doordat ik alles zoveel mogelijk lokaal doe, doordat ik weet dat het voor git handig is om vroeg tijdig te committen, push ik laat mijn commits waardoor ze opstapelen. Hierdoor open ik pas laat de pr's waardoor het team vaak pas laat de code kan reviewen. Volgende keer moet ik sneller mijn werk op development zetten.
- Beter communiceren naar mijn team genoten toe, doordat er slechte communicatie was vanuit mijn kant liep er wat frustratie op bij mijn teamgenoten. In de toekomst moet ik vanuit mezelf aangeven als ik bijvoorbeeld later ben of al aan een nieuwe taak ben begonnen.

## 9. Conclusie & feedback

Ik vind dat het project sucesvol is verlopen. We hebben veel taken afgekregen en vrijwel iedereen heeft hun technologie kunnen implementeren. Er waren wat communicatie problemen vanuit mijn kant, maar dit heeft niet voor mindere kwaliteit gezorgd. Mijn eigen technologie heeft mij blij verrast omdat het handiger werkt dan ik had verwerkt. Tijdens het project heb ik veel mogen leren over microservices en de nieuwe kijk op deze development aanpak is zeker die ik kan meenemen naar andere aanpakken.

Ik heb geen feedback aan de docenten/beoordelaars, maar wel een tip voor de toekomst. Rancher was erg lastig om voor elkaar te krijgen en het was handig geweest om hier eerder uitleg over te krijgen.
