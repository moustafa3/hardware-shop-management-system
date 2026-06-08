# Hardware Shop Management System

Application desktop développée en **C# Windows Forms** pour la gestion d’une boutique de matériel.

## Description

Hardware Shop Management System est une application de gestion commerciale permettant de gérer les opérations quotidiennes d’une boutique de matériel : catalogue d’articles, catégories, clients, facturation, suivi du stock et rapport journalier.

## Fonctionnalités

* Authentification administrateur
* Gestion des articles
* Gestion des catégories
* Gestion des clients
* Gestion de la facturation
* Suivi automatique du stock
* Rapport journalier des ventes
* Interface desktop simple et intuitive

## Technologies utilisées

* C#
* .NET Framework
* Windows Forms
* SQL Server LocalDB
* ADO.NET
* Git / GitHub

## Structure du projet

```text
HardwareShop/
├── database/
│   └── HardwareDb.sql
├── docs/
│   └── screenshots/
├── App.config
├── Program.cs
├── Login.cs
├── Items.cs
├── Categories.cs
├── Customers.cs
├── Billing.cs
├── Report.cs
├── functions.cs
├── README.md
└── .gitignore
```

## Base de données

L’application utilise une base de données SQL Server LocalDB nommée :

```text
HardwareDb
```

Le script SQL de création de la base de données se trouve dans :

```text
database/HardwareDb.sql
```

## Configuration de la connexion

La connexion à la base de données est définie dans `functions.cs` :

```csharp
Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HardwareDb;Integrated Security=True;Connect Timeout=30
```

## Installation et exécution

### Prérequis

* Windows
* Visual Studio
* SQL Server LocalDB
* .NET Framework
* Git

### Étapes

1. Cloner le repository :

```bash
git clone https://github.com/moustafa3/HardwareShop.git
```

2. Ouvrir la solution dans Visual Studio.

3. Restaurer les packages NuGet si nécessaire.

4. Ouvrir **SQL Server Object Explorer** dans Visual Studio.

5. Se connecter à :

```text
(localdb)\MSSQLLocalDB
```

6. Exécuter le script SQL :

```text
database/HardwareDb.sql
```

7. Générer la solution :

```text
Build > Build Solution
```

8. Lancer l’application depuis Visual Studio.

## Identifiants de test

```text
Username: Admin
Password: Admin
```

## Captures d’écran

Les captures d’écran du projet peuvent être ajoutées dans :

```text
docs/screenshots/
```

Exemples recommandés :

```text
docs/screenshots/login.png
docs/screenshots/items.png
docs/screenshots/categories.png
docs/screenshots/customers.png
docs/screenshots/billing.png
docs/screenshots/report.png
```

## Améliorations possibles

* Remplacer les requêtes SQL dynamiques par des requêtes paramétrées
* Déplacer la chaîne de connexion vers un fichier de configuration
* Améliorer la validation des champs utilisateur
* Ajouter une gestion des utilisateurs dans la base de données
* Ajouter un système de rôles
* Améliorer la navigation entre les formulaires
* Ajouter une meilleure gestion des erreurs
* Ajouter des tests unitaires pour la logique métier

## Compétences mises en pratique

* Développement d’interfaces desktop avec Windows Forms
* Gestion de base de données avec SQL Server
* Opérations CRUD
* Utilisation de DataGridView et ComboBox
* Gestion de stock
* Requêtes SQL avec ADO.NET
* Organisation d’un projet C# pour GitHub
