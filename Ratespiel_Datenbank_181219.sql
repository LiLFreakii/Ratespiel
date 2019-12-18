-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server Version:               10.4.10-MariaDB - mariadb.org binary distribution
-- Server Betriebssystem:        Win64
-- HeidiSQL Version:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Exportiere Daten aus Tabelle ratespiel.fragenantworten: ~3 rows (ungefähr)
/*!40000 ALTER TABLE `fragenantworten` DISABLE KEYS */;
INSERT INTO `fragenantworten` (`ID`, `Frage`, `Antwort1`, `Antwort2`, `Antwort3`, `Antwort4`, `RichtigeAntwort`, `Schwierigkeit`, `KategorieId`) VALUES
	(1, 'Wie hoch ist der höchste Berg der Welt', '5m', '8848m', '5624m', 'hoch', 2, 2, 3),
	(2, 'Was ergibt 55 + 74', '12', '55', '129', '132', 3, 1, 1),
	(3, 'Wer prägte die Begriffe "kollektives Unbewusstes" und "Archetyp(us)"?', 'Sigmund Freud', 'C.G. Jungs', 'Donald Trump', 'Herr Bube', 2, 3, 3);
/*!40000 ALTER TABLE `fragenantworten` ENABLE KEYS */;

-- Exportiere Daten aus Tabelle ratespiel.kategorie: ~2 rows (ungefähr)
/*!40000 ALTER TABLE `kategorie` DISABLE KEYS */;
INSERT INTO `kategorie` (`Id`, `Kategorie`) VALUES
	(1, 'Mathematik'),
	(2, 'Physik'),
	(3, 'Allgemeinwissen');
/*!40000 ALTER TABLE `kategorie` ENABLE KEYS */;

-- Exportiere Daten aus Tabelle ratespiel.spiel: ~14 rows (ungefähr)
/*!40000 ALTER TABLE `spiel` DISABLE KEYS */;
INSERT INTO `spiel` (`ID`, `SpielNr`, `Score`, `UserID`, `Datum`) VALUES
	(16, 1, 10, 1, '2019-12-17'),
	(20, 2, 7, 8, '2019-12-17'),
	(39, 3, 0, 1, '2019-12-18'),
	(40, 4, 3, 1, '2019-12-18'),
	(41, 4, 0, 1, '2019-12-18'),
	(42, 4, 0, 1, '2019-12-18'),
	(43, 5, 3, 11, '2019-12-18'),
	(44, 5, 0, 11, '2019-12-18'),
	(45, 5, 0, 11, '2019-12-18'),
	(46, 5, 0, 11, '2019-12-18'),
	(47, 5, 3, 11, '2019-12-18'),
	(48, 9, 3, 11, '2019-12-18'),
	(49, 10, 3, 11, '2019-12-18'),
	(50, 11, 3, 11, '2019-12-18');
/*!40000 ALTER TABLE `spiel` ENABLE KEYS */;

-- Exportiere Daten aus Tabelle ratespiel.spielantwort: ~61 rows (ungefähr)
/*!40000 ALTER TABLE `spielantwort` DISABLE KEYS */;
INSERT INTO `spielantwort` (`Id`, `SpielNr`, `fuaid`, `gepruefteantwort`) VALUES
	(1, 0, 2, 1),
	(2, 0, 1, 1),
	(3, 0, 2, 1),
	(4, 0, 3, 1),
	(5, 0, 1, 1),
	(6, 0, 1, 1),
	(7, 0, 2, 1),
	(8, 0, 1, 1),
	(9, 0, 2, 1),
	(10, 0, 1, 1),
	(11, 0, 2, 1),
	(12, 2, 1, 1),
	(13, 2, 2, 1),
	(14, 2, 3, 1),
	(15, 2, 1, 1),
	(16, 2, 2, 1),
	(17, 2, 3, 1),
	(18, 3, 1, 1),
	(19, 3, 2, 1),
	(20, 3, 3, 1),
	(21, 3, 1, 1),
	(22, 3, 2, 1),
	(23, 3, 3, 1),
	(24, 3, 1, 1),
	(25, 3, 2, 1),
	(26, 3, 3, 1),
	(27, 3, 1, 1),
	(28, 3, 2, 1),
	(29, 3, 3, 1),
	(30, 4, 1, 1),
	(31, 4, 2, 1),
	(32, 4, 3, 1),
	(33, 5, 1, 1),
	(34, 5, 1, 1),
	(35, 5, 1, 1),
	(36, 5, 1, 1),
	(37, 5, 2, 1),
	(38, 5, 3, 1),
	(39, 5, 1, 1),
	(40, 5, 2, 1),
	(41, 5, 3, 1),
	(42, 6, 1, 1),
	(43, 6, 2, 1),
	(44, 6, 3, 1),
	(45, 6, 1, 1),
	(46, 6, 2, 1),
	(47, 6, 3, 1),
	(48, 6, 1, 1),
	(49, 7, 1, 1),
	(50, 8, 1, 1),
	(51, 8, 2, 1),
	(52, 8, 3, 1),
	(53, 9, 1, 1),
	(54, 9, 2, 1),
	(55, 9, 3, 1),
	(56, 10, 1, 1),
	(57, 10, 2, 1),
	(58, 10, 3, 1),
	(59, 11, 1, 1),
	(60, 11, 2, 1),
	(61, 11, 3, 1);
/*!40000 ALTER TABLE `spielantwort` ENABLE KEYS */;

-- Exportiere Daten aus Tabelle ratespiel.user: ~3 rows (ungefähr)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`ID`, `Username`, `Passwort`, `Mail`, `Vorname`, `Nachname`, `Rolle`) VALUES
	(1, 'HToek', 'pa$$w0rd', 'Hamza.Toek@ht.de', 'Hamza', 'Tök', 'A'),
	(8, 'Chris', 'Ibach', 'asdMail', 'Chris', 'Ibach', 'U'),
	(11, 'Username', 'Passwort', 'User.Passwort@bfw.de', 'User', 'Pass', 'A');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
