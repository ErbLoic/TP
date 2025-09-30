-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 10 sep. 2025 à 11:45
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `leclerc`
--

-- --------------------------------------------------------

--
-- Structure de la table `achat`
--

CREATE TABLE `achat` (
  `numClient` int(11) NOT NULL DEFAULT 0,
  `numProduit` int(11) NOT NULL DEFAULT 0,
  `date` timestamp NOT NULL DEFAULT current_timestamp(),
  `nombre` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `achat`
--

INSERT INTO `achat` (`numClient`, `numProduit`, `date`, `nombre`) VALUES
(0, 1, '2025-05-05 13:52:27', 3),
(0, 2, '2025-05-05 13:43:50', 2),
(0, 3, '2025-05-05 13:52:28', 3),
(0, 4, '2025-04-28 15:09:36', 7),
(0, 5, '2025-05-05 13:43:50', 2),
(0, 6, '2025-05-05 13:54:45', 25),
(0, 7, '2025-05-05 13:54:46', 25),
(2, 1, '2017-03-17 12:54:15', 5),
(2, 5, '2018-10-06 15:36:23', 1),
(3, 2, '2017-04-03 06:40:27', 5),
(3, 6, '2018-11-25 13:42:05', 4),
(3, 7, '2017-06-03 18:55:29', 4),
(3, 10, '2017-02-22 09:34:55', 2),
(3, 10, '2018-05-19 08:54:07', 4),
(3, 11, '2018-09-18 15:15:27', 5),
(5, 3, '2018-01-19 15:34:29', 4),
(5, 4, '2018-11-19 11:37:09', 2),
(6, 5, '2017-05-02 06:52:16', 4),
(6, 5, '2017-05-11 06:47:07', 3),
(6, 6, '2018-01-25 08:59:57', 1),
(6, 6, '2018-08-06 15:34:53', 5),
(7, 2, '2017-06-23 06:19:42', 5),
(8, 1, '2018-11-22 15:51:24', 3),
(8, 2, '2018-04-23 15:37:52', 3),
(8, 6, '2018-10-21 11:16:25', 1),
(9, 4, '2018-07-12 15:38:14', 1),
(11, 1, '2017-02-28 10:58:55', 3),
(11, 2, '2017-05-13 08:50:58', 5),
(13, 4, '2018-11-28 18:43:54', 4),
(14, 3, '2018-04-07 06:15:03', 4),
(15, 1, '2017-07-21 06:57:10', 5),
(15, 1, '2018-02-08 08:00:07', 3),
(15, 2, '2018-12-17 12:05:32', 5),
(15, 4, '2018-01-06 10:56:34', 5),
(16, 11, '2018-10-12 18:23:59', 3);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `num` int(11) NOT NULL DEFAULT 0,
  `nom` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`num`, `nom`) VALUES
(1, 'nonrenseigne'),
(2, 'ouvrier'),
(3, 'cadre'),
(4, 'sansemploi'),
(5, 'autres');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `num` int(11) NOT NULL DEFAULT 0,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `CP` int(11) DEFAULT NULL,
  `tel` int(11) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `numcategorie` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`num`, `nom`, `prenom`, `adresse`, `ville`, `CP`, `tel`, `email`, `numcategorie`) VALUES
(0, 'Valjean', 'Michel', '59 rue de lacours', 'Lille', 62000, 6505050, 'dmichel@gmal.com', 1),
(1, 'Dupont', 'Charles', '8 rue de la Chappelle', 'Béthune', 62400, 625221414, 'cdupont@free.fr', 2),
(2, 'Chirac', 'Jacques', '8 rue de lElysées', 'Lille', 59000, 612311231, 'chirac@ely.z', 5),
(3, 'Jenton', 'Jean', '', 'Béthune', 62400, 680575818, 'Jenton.Jean@laposte.net', 5),
(4, 'Fontaine', 'Paul', '', 'Béthune', 62400, 673431662, 'Fontaine.Paul@laposte.net', 3),
(5, 'Liou', 'Pierre', '', 'Béthune', 62400, 640923063, 'Liou.Pierre@laposte.net', 1),
(6, 'Lili', 'Thierry', '', 'Arras', 62000, 658278000, 'Lili.Thierry@laposte.net', 5),
(7, 'Poli', 'Françoise', '', 'Arras', 62000, 613264437, 'Poli.Françoise@laposte.net', 5),
(8, 'Poutrio', 'Michel', '', 'Arras', 62000, 618239628, 'Poutrio.Michel@laposte.net', 3),
(9, 'Cako', 'Pierre', '', 'Arras', 62000, 639366538, 'Cako.Pierre@laposte.net', 1),
(10, 'Mopo', 'Marie', '', 'Béthune', 62400, 664806641, 'Mopo.Marie@laposte.net', 2),
(11, 'Toto', 'Marianne', '', 'Béthune', 62400, 642040139, 'Toto.Marianne@laposte.net', 2),
(12, 'Retrong', 'Jean-Yves', '', 'Arras', 62000, 604876904, 'Retrong.Jean-Yves@laposte.net', 5),
(13, 'Chicho', 'Ludovic', '', 'Béthune', 62400, 647585566, 'Chicho.Ludovic@laposte.net', 1),
(14, 'Riri', 'Nicolas', '', 'Béthune', 62400, 656541592, 'Riri.Nicolas@laposte.net', 4),
(15, 'Fifi', 'Stéphane', '', 'Arras', 62000, 695913179, 'Fifi.Stéphane@laposte.net', 5),
(16, 'Tata', 'Stéphanie', '', 'Béthune', 62400, 676527830, 'Tata.Stéphanie@laposte.net', 1);

--
-- Déclencheurs `client`
--
DELIMITER $$
CREATE TRIGGER `after_delete_client` AFTER DELETE ON `client` FOR EACH ROW BEGIN
    DELETE FROM achat where achat.numClient = OLD.num;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `num` int(11) NOT NULL DEFAULT 0,
  `nom` varchar(50) DEFAULT NULL,
  `prix` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`num`, `nom`, `prix`) VALUES
(1, 'PS4', 400),
(2, 'Xbox one', 350),
(3, 'Nexus 7', 150),
(4, 'iphone6', 600),
(5, 'Samsuns galaxy S6', 650),
(6, 'Nokia 3310', 50),
(7, 'PC portable Acer N412T', 350),
(8, 'TV 3D 4K LG 150cm', 1500),
(9, 'Home cinema LG 5.1', 200),
(10, 'écouteur Pouce', 5),
(11, 'enceinte bluetooth LG14', 1);

--
-- Déclencheurs `produit`
--
DELIMITER $$
CREATE TRIGGER `before_update_prix` BEFORE UPDATE ON `produit` FOR EACH ROW BEGIN
    IF NEW.prix IS NOT NULL   
    AND NEW.prix < 0      
      THEN
        SET NEW.prix = NULL;
    END IF;
END
$$
DELIMITER ;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `achat`
--
ALTER TABLE `achat`
  ADD PRIMARY KEY (`numClient`,`numProduit`,`date`),
  ADD KEY `FK_Achat_2` (`numProduit`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`num`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`num`),
  ADD KEY `numcategorie` (`numcategorie`);

--
-- Index pour la table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`num`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `achat`
--
ALTER TABLE `achat`
  ADD CONSTRAINT `FK_Achat_1` FOREIGN KEY (`numClient`) REFERENCES `client` (`num`),
  ADD CONSTRAINT `FK_Achat_2` FOREIGN KEY (`numProduit`) REFERENCES `produit` (`num`);

--
-- Contraintes pour la table `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `FK_CLIENT_1` FOREIGN KEY (`numcategorie`) REFERENCES `categorie` (`num`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
