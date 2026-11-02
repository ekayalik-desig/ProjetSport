DROP DATABASE IF EXISTS bdSport;

CREATE DATABASE bdSport
CHARACTER SET utf8mb4;

USE bdSport;


-- 1. TABLE DES SPORTIFS

CREATE TABLE Sportif (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(25),
    prenom VARCHAR(25),
    dateNaiss DATE,
    rue VARCHAR(100),
    cp VARCHAR(5),
    ville VARCHAR(25),
    niveauXp VARCHAR(25),
    nomSport VARCHAR(50)
);


-- 2. TABLE DES UTILISATEURS

CREATE TABLE Utilisateur (
    id INT AUTO_INCREMENT PRIMARY KEY,
    login VARCHAR(50) NOT NULL UNIQUE,
    motDePasseHash VARCHAR(255) NOT NULL,
    sel VARCHAR(255) NOT NULL
);


-- 3. TABLE DES SPORTS

CREATE TABLE Sport (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50)
);


-- 4. TABLE DES NIVEAUX

CREATE TABLE Niveau (
    id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(25)
);


-- 5. TABLE DES SPORTS PRATIQUES

CREATE TABLE Pratiquer (
    idSportif INT,
    idSport INT,
    idNiveau INT,

    PRIMARY KEY (idSportif, idSport),

    FOREIGN KEY (idSportif) REFERENCES Sportif(id),
    FOREIGN KEY (idSport) REFERENCES Sport(id),
    FOREIGN KEY (idNiveau) REFERENCES Niveau(id)
);


-- 6. AJOUTER LES SPORTS

INSERT INTO Sport (id, nom)
VALUES
(1, 'Football'),
(2, 'Tennis'),
(3, 'Judo'),
(4, 'Natation'),
(5, 'Basketball'),
(6, 'Rugby'),
(7, 'Course');


-- 7. AJOUTER LES NIVEAUX

INSERT INTO Niveau (id, libelle)
VALUES
(1, 'Débutant'),
(2, 'Confirmé'),
(3, 'Avancé'),
(4, 'Professionnel');


-- 8. AJOUTER LES SPORTIFS

INSERT INTO Sportif
(id, nom, prenom, dateNaiss, rue, cp, ville, niveauXp, nomSport)
VALUES
(1, 'Martin', 'Alex', '2002-05-14',
 '12 rue Victor Hugo', '75015', 'Paris',
 'Débutant', 'Football'),

(2, 'Durand', 'Sophie', '1998-09-21',
 '8 avenue de la République', '69003', 'Lyon',
 'Confirmé', 'Tennis'),

(3, 'Bernard', 'Thomas', '1995-02-10',
 '25 rue Pasteur', '31000', 'Toulouse',
 'Avancé', 'Judo'),

(4, 'Petit', 'Emma', '1992-11-03',
 '17 rue Nationale', '59000', 'Lille',
 'Professionnel', 'Natation'),

(5, 'Robert', 'Lucas', '2004-07-18',
 '4 rue Gambetta', '33000', 'Bordeaux',
 'Débutant', 'Basketball'),

(6, 'Moreau', 'Chloé', '2000-01-25',
 '31 rue Jean Jaurès', '44000', 'Nantes',
 'Confirmé', 'Rugby'),

(7, 'Simon', 'Hugo', '1997-06-12',
 '9 rue des Écoles', '67000', 'Strasbourg',
 'Avancé', 'Course'),

(8, 'Laurent', 'Léa', '1990-03-30',
 '22 boulevard Haussmann', '75009', 'Paris',
 'Professionnel', 'Football'),

(9, 'Michel', 'Nathan', '2005-12-08',
 '15 rue de la Paix', '06000', 'Nice',
 'Débutant', 'Tennis'),

(10, 'Garcia', 'Camille', '1999-08-17',
 '7 rue du Commerce', '35000', 'Rennes',
 'Confirmé', 'Natation');


-- 9. RELIER CHAQUE SPORTIF A SON SPORT ET SON NIVEAU

INSERT INTO Pratiquer (idSportif, idSport, idNiveau)
VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 1),
(6, 6, 2),
(7, 7, 3),
(8, 1, 4),
(9, 2, 1),
(10, 4, 2);


-- 10. AFFICHER LE RESULTAT

SELECT Sportif.nom, Sportif.prenom,
       Sport.nom AS sport,
       Niveau.libelle AS niveau
FROM Pratiquer
INNER JOIN Sportif ON Pratiquer.idSportif = Sportif.id
INNER JOIN Sport ON Pratiquer.idSport = Sport.id
INNER JOIN Niveau ON Pratiquer.idNiveau = Niveau.id
ORDER BY Sportif.id;