# CDMM

## 🧑 Cultuur & Organisatie: 6

CO-204: Ops en Dev samen: Ging goed bij ons doordat wij duidelijke taken hadden en goed communiceerden.
Door de goede communicatie en duidelijke taken was het makkelijk om samen te werken en elkaar te helpen waar nodig. Ook was
het daardoor makkelijk om een taakverdeling op te stellen.

CO-205 Vast proces voor wijzigingen: Wij hadden een vast proces voor wijzigingen, namelijk dat wij altijd een pull request
moesten maken en dat er altijd iemand anders moest reviewen. Dit zorgde ervoor dat er altijd iemand anders naar de code keek.
Daarnaast hadden we een naamgeving voor bijvoorbeeld bracnhing waar we ons aan hielden.

CO-305: Deploy losgekoppeld van release: Wij hadden een losgekoppelde deploy van release. Dit zorgde ervoor dat wij altijd
konden deployen en dat wij niet afhankelijk waren van een release.

## ⛪ Ontwerp & Architectuur: 8

OA-203: Configuratie als Code (CaC): Wij hebben gewerkt met docker om lokaal de applicatie te kunnen deployen.

OA-401: Infrastructure as Code (IaC): Wij hebben gewerkt met Ansible om de applicatie te deployen naar de productie omgeving.

## 🏗️ Build & Deploy: 8

BD-203: Build once deploy anywhere: Wij maken gebruik van een scheiding van de deploy en release stap. Door deze aanpak
kunnen we altijd builden en op alle omgevingen de applicatie deployen.

BD-303 Volledig automatische DB deploys: Bij het opstarten van elke microservice worden de migrations automatisch uitgevoerd
op de databases van de microservices.



## 🧪 Test & Verification: 4

TV-202 en TV-304


## 📈 Information & Reporting: 6

IR-201: Gedeeld informatiemodel: Waarna er een foutmelding komt wordt deze in de logservice gelogd.
IR-202: Wij hebben tekton geïmplementeerd waarin tijdens het uitvoeren van de pipeline ook foutmeldingen of infomeldingen gelogd.
IR-301 en IR-401: Wij hebben grafana geïmplementeerd in de applicatie 
