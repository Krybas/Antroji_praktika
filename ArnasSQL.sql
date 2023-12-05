-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: praktinis_darbas_a
-- ------------------------------------------------------
-- Server version	8.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administracija`
--

DROP TABLE IF EXISTS `administracija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administracija` (
  `idAdministracija` int NOT NULL,
  `Administratoriaus_vardas` char(45) NOT NULL,
  `Administratoriaus_pavarde` char(45) NOT NULL,
  PRIMARY KEY (`idAdministracija`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administracija`
--

LOCK TABLES `administracija` WRITE;
/*!40000 ALTER TABLE `administracija` DISABLE KEYS */;
INSERT INTO `administracija` VALUES (1,'Admin','Admin');
/*!40000 ALTER TABLE `administracija` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dalykas`
--

DROP TABLE IF EXISTS `dalykas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dalykas` (
  `idDalykas` int NOT NULL,
  `Dalyko_pavadinimas` varchar(45) NOT NULL,
  PRIMARY KEY (`idDalykas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dalykas`
--

LOCK TABLES `dalykas` WRITE;
/*!40000 ALTER TABLE `dalykas` DISABLE KEYS */;
INSERT INTO `dalykas` VALUES (1,'Profesinė anglų kalba'),(2,'Specialybės kalba'),(3,'Matematika'),(4,'Operacinės sistemos'),(5,'Struktūrinis programavimas'),(6,'Informatikos įvadas'),(7,'Informacijos valdymo pagrindai'),(8,'Vadyba');
/*!40000 ALTER TABLE `dalykas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `destytojas`
--

DROP TABLE IF EXISTS `destytojas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `destytojas` (
  `idDestytojas` int NOT NULL,
  `Destytojo_vardas` char(45) NOT NULL,
  `Destytojo_pavarde` char(45) NOT NULL,
  PRIMARY KEY (`idDestytojas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `destytojas`
--

LOCK TABLES `destytojas` WRITE;
/*!40000 ALTER TABLE `destytojas` DISABLE KEYS */;
INSERT INTO `destytojas` VALUES (1,'Milda','Kiškytė'),(2,'Violeta','Baltrūnienė'),(3,'Jolita','Vasaitienė'),(4,'Romanas','Tumasonis'),(5,'Natalija','Pozniak'),(6,'Valdona','Judickaitė'),(7,'Anželika','Slimavičienė'),(8,'Irina','Lušičina'),(9,'Juratė','Helsvik'),(10,'Irina','Liušicyna');
/*!40000 ALTER TABLE `destytojas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupe`
--

DROP TABLE IF EXISTS `grupe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupe` (
  `idGrupe` int NOT NULL,
  `Grupes_pavadinimas` varchar(45) NOT NULL,
  PRIMARY KEY (`idGrupe`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupe`
--

LOCK TABLES `grupe` WRITE;
/*!40000 ALTER TABLE `grupe` DISABLE KEYS */;
INSERT INTO `grupe` VALUES (1,'PI23A'),(2,'IS23A');
/*!40000 ALTER TABLE `grupe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `priskirtas_dalykas`
--

DROP TABLE IF EXISTS `priskirtas_dalykas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `priskirtas_dalykas` (
  `idPriskirtas_dalykas` int NOT NULL,
  `idDestytojas` int NOT NULL,
  `idGrupe` int NOT NULL,
  `idDalykas` int NOT NULL,
  PRIMARY KEY (`idPriskirtas_dalykas`,`idDestytojas`,`idGrupe`,`idDalykas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `priskirtas_dalykas`
--

LOCK TABLES `priskirtas_dalykas` WRITE;
/*!40000 ALTER TABLE `priskirtas_dalykas` DISABLE KEYS */;
INSERT INTO `priskirtas_dalykas` VALUES (1,1,1,1),(2,2,1,2),(3,3,1,3),(4,4,1,4),(5,5,1,5),(6,6,2,6),(7,7,2,7),(8,8,2,8),(9,9,2,1),(10,10,2,4);
/*!40000 ALTER TABLE `priskirtas_dalykas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentas`
--

DROP TABLE IF EXISTS `studentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentas` (
  `idStudentas` int NOT NULL,
  `Studento_vardas` char(45) COLLATE utf8mb4_lt_0900_as_cs NOT NULL,
  `Studento_pavarde` char(45) COLLATE utf8mb4_lt_0900_as_cs NOT NULL,
  `idGrupe` int NOT NULL,
  PRIMARY KEY (`idStudentas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_lt_0900_as_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentas`
--

LOCK TABLES `studentas` WRITE;
/*!40000 ALTER TABLE `studentas` DISABLE KEYS */;
INSERT INTO `studentas` VALUES (1,'Jurga','Jonaitė',1),(2,'Paulius','Kazlas',2),(3,'Giedrė','Mačiulė',1),(4,'Rokas','Vaitkus',2),(5,'Jurga','Valytė',2),(6,'Mantas','Grigas',2);
/*!40000 ALTER TABLE `studentas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studento_dalykas`
--

DROP TABLE IF EXISTS `studento_dalykas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studento_dalykas` (
  `idStudento_dalykas` int NOT NULL,
  `idDalykas` int NOT NULL,
  `idStudentas` int NOT NULL,
  `pazymys` float DEFAULT NULL,
  PRIMARY KEY (`idStudento_dalykas`,`idDalykas`,`idStudentas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studento_dalykas`
--

LOCK TABLES `studento_dalykas` WRITE;
/*!40000 ALTER TABLE `studento_dalykas` DISABLE KEYS */;
INSERT INTO `studento_dalykas` VALUES (1,1,1,10),(2,1,2,8),(3,1,3,8),(4,1,4,10),(5,1,5,9),(6,1,6,10),(7,2,1,7),(8,2,2,7),(9,2,3,6),(10,3,1,8),(11,3,2,6),(12,3,3,7),(13,4,1,8),(14,4,2,7),(15,4,3,9),(16,4,6,8),(17,5,1,9),(18,5,2,9),(19,5,3,10),(20,5,4,7),(21,5,5,7),(22,6,4,8),(23,6,5,8),(24,6,6,9),(25,7,4,6),(26,7,5,6),(27,7,6,7),(28,8,4,10),(29,8,5,9),(30,8,6,10);
/*!40000 ALTER TABLE `studento_dalykas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-05 20:56:29
