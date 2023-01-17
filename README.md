# TpCsharpCrudOperations
 

Collections

Liste des exercices

Exercice N°1 :   Héritage de base 
Exercice N°2 : 	Manipulation de collections
Exercice N°3: Manipulation de bases de données 


Formateur : Hafed Benteftifa

 

Préparé par : Hafed Benteftifa

© Hafed Benteftifa 2014-2022

Ce document ne peut être utilisé dans le cadre d’une formation, publication papier, site internet ou tout support sans mon accord express.

Aucune reproduction, même partielle, ne peut être faite de ce document et de l'ensemble de son contenu : textes, images, etc. sans mon autorisation express. Pour toutes informations, communiquer avec moi à info@degenio.com.

 
Exercice N°1 : Héritage de base  

OBJECTIF
Étudier le concept d’héritage


DÉMARCHE

1.	Créer la classe de base Contact. Celle-ci définit un contact que l’on peut avoir. On nous impose qu’un contact dispose d’un nom et d’une adresse email.
2.	Sur la base de cette information, créer un contact ayant comme nom "Alain flouflou" et adresse courriel a.flouflou@monsite.com. Afficher son détail avec la fonction print().


3.	On considère maintenant que l'on peut avoir un contact mais qui est aussi un fournisseur. Dans ce cas précis, un fournisseur dispose d'un attribut supplémentaire appelé code_scn ainsi que d'une méthode PasserCommande(). Développer la classe Fournisseur. Créer un objet fournisseur avec les valeurs "Annie ClairClair", a.clairclair@monsite.com" et "1234"
 
Exercice N°2: Manipulation de collections   

OBJECTIF
Manipuler une collection


DÉMARCHE

1.	On désire maintenant sauvegarder les contacts dans un registre mémoire. Pour cela, on va utiliser une liste comme collection. Développer la classe RegistreContacts qui utilise une collection. On ajoutera les contacts précédents dans le registre.

2.	On fera en sorte maintenant d'ajouter le parcours de contacts une fois qu'ils ont été ajoutés.

3.	Le registre des contacts devra maintenant nous fournir un moyen de rechercher un contact par son nom. Développer la méthode RechercherContact qui prend le nom d'un contact pour rechercher s'il est déjà dans le registre.



 
Exercice N°3: Manipulation de bases de données 

OBJECTIF
Manipuler une base de données


DÉMARCHE

1.	On désire maintenant sauvegarder les contacts dans une table. Développer le code nécessaire pour sauvegarder les contacts dans une table. On utilisera une approche connectée ou déconnectée.

2.	Ajouter le support pour l’affichage de tous les contacts.

3.	Améliorer votre UI en ajoutant les formulaires appropriés.
