# Exigences fonctionnelles

## ChargéDeLaboratoire
### CU01. Veux comparer les temps de trajet: 
  1. le CL sélectionne une intersection de départ et une intersection d'arrivée, ainsi que le taux de rafraichissement de la prise de mesure.
  1. Le CL sélectionne les sources de données qu'il veut utiliser. [Service externe](service-externe.md), données de simulation ou données temps réel de la STM.
  2. Le système affiche un graphique du temps de déplacement et met celui-ci à jour selon le taux de rafraichissement.
  3. Le CL peut récupérer le fichier de données et générer ses propres graphiques à l'aide d’Excel</span>.
> #### Cas alternatifs
>  - 2.a [Service externe](service-externe.md): Utiliser tout les [service externe](service-externe.md) disponible pour faire le comparatif.
>  - 2.b1 Simulation: Vous comparer au moins 2 implémentations différentes du microservice qui calcul de temps de trajet. 


### CU02. Veut pouvoir mettre le chaos dans les services en
  - **Option 1**: Manuel
    1.1. Le CL consulte la liste des microservices avec leur latence moyenne.
    1.2. Le CL change la latence d'un ou plusieurs microservices</span>.
  
  - **Option 2**: Automatique
    2.1. Le CL sélectionne le mode automatique tout en spécifiant la fréquence de la perturbation en seconde.
    2.2. Le système détruit<sup>1</sup> un microservice de façon aléatoire a toute les x secondes</span>.
  
  - Le système conserve un log des différents changements apportés que nous pourrons utiliser pour vérifier les données accumulées.

> #### Cas alternatifs
>  - 1.2.a Le CL détruit un ou plusieurs microservices</span>.
>  - 1.2.b Le CL détruit tous les microservices d'une équipe.
</span>

#### CU03. Usager multiple
Comparer simultanément 25 trajets différents sur une période de 24h et utilisant les données temps réel de la STM et un [service externe](service-externe.md) qui tient compte du trafique dans son calcul.

Désactiver l'affichage graphique en temps réel et utiliser l'archivage des données pour permettre la réalisation de différents graphiques sur Excel. 