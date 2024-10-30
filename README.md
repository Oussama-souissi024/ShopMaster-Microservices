# ShopMaster

## Statut du Projet
🚧 **En cours de développement** 🚧

## Introduction
**ShopMaster** est une application de commerce électronique basée sur une architecture de microservices. Chaque microservice est indépendant et responsable d'une fonctionnalité spécifique de l'application, assurant une modularité et une évolutivité accrues.

## Architecture du Projet
L'application ShopMaster est divisée en plusieurs microservices qui communiquent entre eux via des appels HTTP. Cette architecture permet une séparation des préoccupations, une meilleure gestion des dépendances, et la possibilité de scaler chaque service indépendamment.

## Menu des Services
- **ShopMaster.Web**
- **ShopMaster.Services.CouponAPI**
- **ShopMaster.Services.ProductAPI**
- **ShopMaster.Services.AuthAPI**
- **ShopMaster.MessageBus**
- **ShopMaster.Services.EmailAPI**
- **ShopMaster.Services.OrderAPI**
- **ShopMaster.Gateway**
- **ShopMaster.Services.RewardAPI**

### Services dans le Projet

1. **ShopMaster.Web**  
 C'est le frontend de l'application ShopMaster, développé avec ASP.NET MVC. Ce composant permet aux utilisateurs finaux d'interagir avec les différents services de l'application, notamment pour l'authentification, la gestion des produits, et le panier d'achat. Il consomme les APIs des microservices pour afficher les informations aux utilisateurs.

 2. **ShopMaster.Services.CouponAPI**  
   Ce service gère les coupons de l'application ShopMaster. Développé avec ASP.NET Core, il permet aux utilisateurs de créer, lire, mettre à jour et supprimer des coupons. Il utilise Entity Framework pour interagir avec la base de données des coupons et AutoMapper pour gérer les mappages entre les modèles de données et les DTOs. Ce service est sécurisé par des autorisations basées sur les rôles, permettant uniquement aux administrateurs de créer et de modifier des coupons. Les informations sur les coupons sont exposées via une API REST, et le service se connecte à une base de données SQL Server pour le stockage des données.

3. **ShopMaster.Services.ProductAPI**
Ce service gère les produits de l'application ShopMaster. Développé avec ASP.NET Core, il permet aux utilisateurs de créer, lire, mettre à jour et supprimer des produits. Il utilise Entity Framework pour interagir avec la base de données des produits et AutoMapper pour gérer les mappages entre les modèles de données et les DTOs. Ce service est sécurisé par des autorisations basées sur les rôles, permettant uniquement aux administrateurs de créer et de modifier des produits. Les informations sur les produits sont exposées via une API REST, et le service se connecte à une base de données SQL Server pour le stockage des données.

4. **ShopMaster.Services.AuthAPI**
Ce service gère l'authentification des utilisateurs dans l'application ShopMaster. Développé avec ASP.NET Core, il permet aux utilisateurs de s'inscrire, de se connecter et d'assigner des rôles. Le service utilise Identity Framework pour gérer les utilisateurs et les rôles, et Entity Framework pour interagir avec la base de données d'authentification. Les tokens JWT sont générés pour assurer une authentification sécurisée et sont configurés à partir des options spécifiées dans le fichier de configuration. Les points de terminaison de l'API sont exposés via une API REST, permettant une intégration fluide avec d'autres services de l'application. Ce service se connecte à une base de données SQL Server pour le stockage des données et utilise Swagger pour la documentation de l'API.

5. **ShopMaster.MessageBus**
Ce service gère la communication asynchrone entre les différents microservices de l'application ShopMaster. Développé avec .NET 8, il utilise Azure Service Bus pour publier des messages dans des topics et des queues. L'interface IMessageBus définit la méthode PublishMessage, qui permet aux services d'envoyer des objets sérialisés en JSON, garantissant ainsi une transmission des données sécurisée et efficace. Le service génère également un identifiant de corrélation unique pour chaque message, facilitant le suivi et le débogage. Grâce à sa conception modulaire, le MessageBus s'intègre facilement dans l'architecture de microservices, assurant une communication fluide et scalable entre les composants de l'application.

6. **ShopMaster.Services.EmailAPI**
Ce service gère l'envoi d'emails au sein de l'application ShopMaster. Développé avec .NET 8, il utilise Azure Service Bus pour recevoir des messages et déclencher des actions d'envoi d'emails. Le service inclut un EmailService qui s'occupe de la création et de l'envoi des messages électroniques, ainsi que de la journalisation des emails envoyés. Les messages reçus sont traités à l'aide de consommateurs de Service Bus qui gèrent différentes actions, comme l'envoi d'un récapitulatif de panier, la confirmation d'enregistrement d'utilisateur et la notification de commandes passées. Les données de connexion à la base de données SQL Server et les informations de Service Bus sont configurées via des fichiers appsettings. Ce microservice expose des fonctionnalités via une API REST, offrant ainsi une communication asynchrone et scalable pour l'application.

7. **ShopMaster.Services.OrderAPI**
Ce service gère la gestion des commandes dans l'application ShopMaster. Développé avec ASP.NET Core, il permet aux utilisateurs de créer, lire, mettre à jour et supprimer des commandes. Le service utilise Entity Framework pour interagir avec la base de données des commandes et AutoMapper pour gérer les mappages entre les modèles de données et les DTOs. Il prend en charge le traitement des commandes, y compris la validation, le calcul des totaux et la gestion des statuts de commande. Les informations sur les commandes sont exposées via une API REST, permettant aux autres services, comme le service de paiement et le service d'authentification, de consommer les données des commandes. Ce service est sécurisé par des autorisations basées sur les rôles, garantissant que seules les opérations appropriées peuvent être effectuées par les utilisateurs. Les données sont stockées dans une base de données SQL Server, et le service utilise Swagger pour la documentation de l'API, facilitant ainsi l'intégration et l'utilisation par d'autres composants de l'application.

8. **ShopMaster.Gateway**
Le service ShopMaster.Gateway sert de point d'entrée principal pour tous les microservices de l'application ShopMaster. Développé avec ASP.NET Core, ce composant joue un rôle essentiel dans la gestion des requêtes des utilisateurs en les redirigeant vers les services appropriés. Il agit comme un reverse proxy, permettant une communication fluide entre le frontend et les divers microservices, tout en offrant une couche de sécurité supplémentaire grâce à l'authentification et à l'autorisation centralisées.
Le gateway gère également la collecte et l'agrégation des réponses des microservices, facilitant ainsi une expérience utilisateur harmonieuse. En plus de la gestion des requêtes, il intègre des mécanismes de routage basés sur des règles, ce qui permet de diriger les appels API vers les services les plus appropriés en fonction de l'URL et des paramètres fournis.
Ce service est également conçu pour être évolutif et maintenable, permettant d'ajouter facilement de nouveaux microservices sans nécessiter de modifications significatives dans l'architecture existante. Grâce à l'utilisation de Swagger, la documentation des API est automatiquement générée, offrant aux développeurs une interface interactive pour explorer les différentes routes disponibles.

9. **ShopMaster.Services.RewardAPI**
Le service ShopMaster.Services.RewardAPI est un élément clé du système de fidélité de l'application ShopMaster, conçu pour enrichir l'expérience d'achat des utilisateurs en leur permettant de gagner et d'échanger des points de fidélité. Développé avec ASP.NET Core, ce service vise à encourager l'engagement des utilisateurs et à renforcer leur fidélité à la marque à travers des récompenses attrayantes.

Avec RewardAPI, les utilisateurs peuvent facilement accumuler des points en fonction de leurs interactions sur la plateforme, que ce soit par le biais d'achats réguliers ou en participant à des promotions spéciales. Ce service fournit également une interface intuitive pour consulter le solde de points et un historique détaillé des transactions, tout en offrant des options d'échange flexibles, telles que des remises ou des produits exclusifs.

Pour garantir une gestion efficace des récompenses, ce service comprend des fonctionnalités administratives permettant de configurer les règles de gain et d'échange de points, ainsi que de surveiller les activités des utilisateurs à travers un tableau de bord dédié. RewardAPI est sécurisé par des autorisations basées sur les rôles, assurant que seuls les utilisateurs autorisés peuvent effectuer des transactions relatives aux points de fidélité.

En intégrant Swagger pour la documentation de l'API, ShopMaster.Services.RewardAPI facilite l'intégration avec d'autres microservices, offrant une transparence et une accessibilité maximales pour les développeurs et les administrateurs.

![ShopMaster-Project-Design](https://raw.githubusercontent.com/Oussama-souissi024/ShopMaster-/refs/heads/main/Microservices-project-architecture.png)