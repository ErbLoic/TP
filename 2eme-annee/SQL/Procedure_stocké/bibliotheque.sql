-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : lun. 29 sep. 2025 à 16:27
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bibliotheque`
--
CREATE DATABASE IF NOT EXISTS `bibliotheque` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bibliotheque`;

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `pListeLivres` ()   BEGIN
SELECT * FROM livre;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pLivresParAuteur` (IN `id_auteur` INT)   BEGIN
SELECT * 
FROM livre
WHERE livre.idAuteur=id_auteur;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pNbEmpruntsAdherent` (IN `id_adh` INT, OUT `nbr_total` INT)   BEGIN
SELECT COUNT(*) INTO nbr_total
FROM emprunt
WHERE emprunt.idAdherent=id_adh ;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pRetardEmprunts` ()   BEGIN
    DECLARE v_id INT DEFAULT 1;
    DECLARE v_maxId INT;
    DECLARE v_dateEmprunt DATE;
    DECLARE v_nbJoursRetard INT;

    SELECT MAX(idEmprunt) INTO v_maxId FROM Emprunt;

    WHILE v_id <= v_maxId DO
        SELECT dateEmprunt
        INTO v_dateEmprunt
        FROM Emprunt
        WHERE idEmprunt = v_id
          AND dateRetour IS NULL
        LIMIT 1;

        SET v_nbJoursRetard = DATEDIFF(CURDATE(), DATE_ADD(v_dateEmprunt, INTERVAL 1 MONTH));

        SELECT v_id AS idEmprunt, v_nbJoursRetard AS nbJoursRetard
        WHERE v_dateEmprunt IS NOT NULL
          AND v_nbJoursRetard > 0;

        SET v_id = v_id + 1;
        SET v_dateEmprunt = NULL;
    END WHILE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pSanctionsAdherents` ()   BEGIN
    DECLARE v_id INT DEFAULT 1;
    DECLARE v_maxId INT;
    DECLARE v_nom VARCHAR(100);
    DECLARE v_nbRetards INT;

    SELECT MAX(idAdherent) INTO v_maxId FROM Adherent;

    WHILE v_id <= v_maxId DO
        SELECT nom
        INTO v_nom
        FROM adherent
        WHERE idAdherent = v_id
        LIMIT 1;

        SELECT COUNT(*)
        INTO v_nbRetards
        FROM Emprunt
        WHERE idAdherent = v_id
          AND dateRetour IS NULL
          AND CURDATE() > DATE_ADD(dateEmprunt, INTERVAL 1 MONTH);

        IF v_nbRetards > 3 THEN
            SELECT CONCAT('Avertissement : ', v_nom) AS Message;
        END IF;

        SET v_id = v_id + 1;
    END WHILE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pStatutLivre` (IN `id_livre` INT, OUT `texte` VARCHAR(50))   BEGIN
    DECLARE nb INT;

    SELECT COUNT(*) 
    INTO nb 
    FROM emprunt 
    WHERE emprunt.idLivre = id_livre AND emprunt.dateRetour IS null;

    IF nb = 0 THEN
        SET texte = 'Disponible';
    ELSE
        SET texte = 'Indisponible';
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

CREATE TABLE `adherent` (
  `idAdherent` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `dateInscription` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `adherent`
--

INSERT INTO `adherent` (`idAdherent`, `nom`, `prenom`, `dateInscription`) VALUES
(1, 'Durand', 'Pierre', '2023-01-15'),
(2, 'Martin', 'Sophie', '2023-03-10'),
(3, 'Dubois', 'Luc', '2024-06-20'),
(4, 'Lefevre', 'Claire', '2024-07-01'),
(5, 'Bernard', 'Julien', '2022-09-15'),
(6, 'Petit', 'Marie', '2023-11-22'),
(7, 'Roux', 'Nicolas', '2024-01-05'),
(8, 'Fontaine', 'Camille', '2024-02-14'),
(9, 'Moreau', 'Antoine', '2024-03-30'),
(10, 'Lambert', 'Elise', '2024-04-12');

-- --------------------------------------------------------

--
-- Structure de la table `auteur`
--

CREATE TABLE `auteur` (
  `idAuteur` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `nationalite` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `auteur`
--

INSERT INTO `auteur` (`idAuteur`, `nom`, `prenom`, `nationalite`) VALUES
(1, 'Hugo', 'Victor', 'Française'),
(2, 'Rowling', 'J.K.', 'Britannique'),
(3, 'Tolkien', 'J.R.R.', 'Britannique'),
(4, 'Camus', 'Albert', 'Française'),
(5, 'Verne', 'Jules', 'Française'),
(6, 'Christie', 'Agatha', 'Britannique'),
(7, 'Shakespeare', 'William', 'Britannique'),
(8, 'Orwell', 'George', 'Britannique'),
(9, 'Dumas', 'Alexandre', 'Française'),
(10, 'Austen', 'Jane', 'Britannique');

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE `emprunt` (
  `idEmprunt` int(11) NOT NULL,
  `idLivre` int(11) DEFAULT NULL,
  `idAdherent` int(11) DEFAULT NULL,
  `dateEmprunt` date DEFAULT NULL,
  `dateRetour` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `emprunt`
--

INSERT INTO `emprunt` (`idEmprunt`, `idLivre`, `idAdherent`, `dateEmprunt`, `dateRetour`) VALUES
(1, 1, 1, '2025-09-28', NULL),
(2, 2, 1, '2024-02-15', NULL),
(3, 3, 2, '2024-03-12', NULL),
(4, 4, 2, '2024-04-15', NULL),
(5, 5, 3, '2024-05-01', '2024-05-20'),
(6, 6, 3, '2024-06-18', NULL),
(7, 7, 4, '2024-07-10', NULL),
(8, 8, 5, '2024-01-20', '2024-02-15'),
(9, 9, 5, '2024-02-25', NULL),
(10, 10, 6, '2024-03-05', '2024-03-25'),
(11, 11, 7, '2024-04-12', NULL),
(12, 12, 7, '2024-05-15', NULL),
(13, 13, 8, '2024-06-01', '2024-06-20'),
(14, 14, 8, '2024-06-25', NULL),
(15, 15, 9, '2024-07-02', NULL),
(16, 16, 9, '2024-07-05', NULL),
(17, 17, 10, '2024-07-10', NULL),
(18, 18, 10, '2024-07-12', NULL),
(19, 19, 10, '2024-07-15', NULL),
(20, 23, 2, '2025-01-07', NULL),
(21, 22, 2, '2017-09-13', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `livre`
--

CREATE TABLE `livre` (
  `idLivre` int(11) NOT NULL,
  `titre` varchar(100) NOT NULL,
  `annee` int(11) DEFAULT NULL,
  `idAuteur` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `livre`
--

INSERT INTO `livre` (`idLivre`, `titre`, `annee`, `idAuteur`) VALUES
(1, 'Les Misérables', 1862, 1),
(2, 'Notre-Dame de Paris', 1831, 1),
(3, 'Harry Potter à l\'école des sorciers', 1997, 2),
(4, 'Harry Potter et la Chambre des secrets', 1998, 2),
(5, 'Harry Potter et le Prisonnier d\'Azkaban', 1999, 2),
(6, 'Harry Potter et la Coupe de feu', 2000, 2),
(7, 'Le Seigneur des anneaux', 1954, 3),
(8, 'Le Hobbit', 1937, 3),
(9, 'Silmarillion', 1977, 3),
(10, 'L\'Étranger', 1942, 4),
(11, 'La Peste', 1947, 4),
(12, 'Vingt mille lieues sous les mers', 1870, 5),
(13, 'Le Tour du monde en 80 jours', 1872, 5),
(14, 'Mort sur le Nil', 1937, 6),
(15, 'Dix petits nègres', 1939, 6),
(16, 'Hamlet', 1603, 7),
(17, 'Roméo et Juliette', 1597, 7),
(18, '1984', 1949, 8),
(19, 'La Ferme des animaux', 1945, 8),
(20, 'Les Trois Mousquetaires', 1844, 9),
(21, 'Le Comte de Monte-Cristo', 1846, 9),
(22, 'Orgueil et Préjugés', 1813, 10),
(23, 'Raison et Sentiments', 1811, 10);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD PRIMARY KEY (`idAdherent`);

--
-- Index pour la table `auteur`
--
ALTER TABLE `auteur`
  ADD PRIMARY KEY (`idAuteur`);

--
-- Index pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD PRIMARY KEY (`idEmprunt`),
  ADD KEY `idLivre` (`idLivre`),
  ADD KEY `idAdherent` (`idAdherent`);

--
-- Index pour la table `livre`
--
ALTER TABLE `livre`
  ADD PRIMARY KEY (`idLivre`),
  ADD KEY `idAuteur` (`idAuteur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `adherent`
--
ALTER TABLE `adherent`
  MODIFY `idAdherent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `auteur`
--
ALTER TABLE `auteur`
  MODIFY `idAuteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `emprunt`
--
ALTER TABLE `emprunt`
  MODIFY `idEmprunt` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pour la table `livre`
--
ALTER TABLE `livre`
  MODIFY `idLivre` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD CONSTRAINT `emprunt_ibfk_1` FOREIGN KEY (`idLivre`) REFERENCES `livre` (`idLivre`),
  ADD CONSTRAINT `emprunt_ibfk_2` FOREIGN KEY (`idAdherent`) REFERENCES `adherent` (`idAdherent`);

--
-- Contraintes pour la table `livre`
--
ALTER TABLE `livre`
  ADD CONSTRAINT `livre_ibfk_1` FOREIGN KEY (`idAuteur`) REFERENCES `auteur` (`idAuteur`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
