
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Base de données : `sio1_tp5`
--
CREATE DATABASE IF NOT EXISTS `sio1_tp_affichage` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `sio1_tp_affichage`;

-- --------------------------------------------------------

--
-- Structure de la table `oeuvre`
--

CREATE TABLE `oeuvre` (
  `idoeuvre` INT(3) UNSIGNED ZEROFILL NOT NULL ,
  `titre` varchar(45) DEFAULT NULL,
  `auteur` varchar(45) DEFAULT NULL,
  `nb_exemplaires` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `oeuvre`
--

INSERT INTO `oeuvre` (`idoeuvre`, `titre`, `auteur`, `nb_exemplaires`) VALUES
('001', 'Les Misérables', 'Victor Hugo', 5),
('002', 'Harry Potter à l école des sorciers, tome 1', 'JK Rowling', 3),
('003', 'Harry Potter et la Chambre des Secrets, tome ', 'JK Rowling', 2),
('004', 'Harry Potter et le Prisonnier d Azkaban, tome', 'JK Rowling', 2),
('005', 'Le Petit Prince', 'Antoine de Saint-Exupéry', 2),
('006', 'Alice au pays des merveilles', 'Lewis Caroll', 2),
('007', 'Da Vinci Code', 'Dan Brown', 1),
('008', 'L alchimiste', 'Paulo Coelho', 1),
('009', 'Vingt mille lieues sous les mers', 'Jules Verne', 1),
('010', 'Twilight: Fascination, tome 1', 'Stephenie Meyer ', 3),
('011', 'Twilight: Tentation, tome 2', 'Stephenie Meyer ', 2),
('012', 'L île mystérieuse', 'Jules Verne', 1);

--
-- Index pour les tables déchargées
--
