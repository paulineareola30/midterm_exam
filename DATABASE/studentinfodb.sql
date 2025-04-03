-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2025 at 04:19 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentinfodb`
--

-- --------------------------------------------------------

--
-- Table structure for table `coursetb`
--

CREATE TABLE `coursetb` (
  `courseId` int(11) NOT NULL,
  `courseName` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `coursetb`
--

INSERT INTO `coursetb` (`courseId`, `courseName`) VALUES
(1, 'IT'),
(2, 'BSBA'),
(3, 'ABEL'),
(4, 'BPA');

-- --------------------------------------------------------

--
-- Table structure for table `studentrecordtb`
--

CREATE TABLE `studentrecordtb` (
  `studentId` int(11) NOT NULL,
  `firstName` varchar(250) DEFAULT NULL,
  `lastName` varchar(250) DEFAULT NULL,
  `middleName` varchar(250) DEFAULT NULL,
  `houseNo` int(11) DEFAULT NULL,
  `brgyName` varchar(250) DEFAULT NULL,
  `municipality` varchar(250) DEFAULT NULL,
  `province` varchar(250) DEFAULT NULL,
  `region` varchar(250) DEFAULT NULL,
  `country` varchar(250) DEFAULT NULL,
  `birthdate` varchar(250) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `studContactNo` varchar(250) DEFAULT NULL,
  `emailAddress` varchar(250) DEFAULT NULL,
  `guardianFirstName` varchar(250) DEFAULT NULL,
  `guardianLastName` varchar(250) DEFAULT NULL,
  `hobbies` varchar(250) DEFAULT NULL,
  `nickname` varchar(250) DEFAULT NULL,
  `courseId` int(11) DEFAULT NULL,
  `yearId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentrecordtb`
--

INSERT INTO `studentrecordtb` (`studentId`, `firstName`, `lastName`, `middleName`, `houseNo`, `brgyName`, `municipality`, `province`, `region`, `country`, `birthdate`, `age`, `studContactNo`, `emailAddress`, `guardianFirstName`, `guardianLastName`, `hobbies`, `nickname`, `courseId`, `yearId`) VALUES
(1, 'Pauline', 'Areola', 'Nepacina', 178, 'Cabalaoangan Sur', 'Rosales', 'Pangasinan', 'Region 1', 'Philippines', '2004-11-30', 20, '09123456789', 'paulineareola@gmail.com', 'Lorena', 'Areola', 'Reading, Coding', 'Paula', 1, 3),
(2, 'Roger', 'Macaraeg', 'Travina', 123, 'Magsaysay', 'Bayambang', 'Pangasinan', 'Region 1', 'Philippines', '2002-07-29', 23, '09234567891', 'rogermac@gmail.com', 'Rosario', 'Macaraeg', 'Painting, Music', 'Roga', 2, 4),
(3, 'Ryen', 'Nava', 'Torres', 134, 'San Marcelino', 'Balungao', 'Pangasinan', 'Region 2', 'Philippines', '2003-11-08', 21, '09345678912', 'ryennava@gmail.com', 'Roam', 'Nava', 'Gaming, Swimming', 'Rye', 3, 3),
(4, 'Emily', 'Davis', 'Johnson', 101, 'EastSide', 'Houston', 'Texas', 'Region 4', 'USA', '2006-01-25', 19, '09456789213', 'emilydavis@gmail.com', 'Michael', 'Davis', 'Dancing, Cooking ', 'Emi', 4, 1),
(5, 'David', 'Wilson', 'Lee', 202, 'South', 'Miami', 'Florida', 'Region 5', 'USA', '2003-04-04', 21, '09567891234', 'davidwilson@gmail.com', 'John', 'Wilson', 'Photography, Hiking', 'Dave', 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `yeartb`
--

CREATE TABLE `yeartb` (
  `yearId` int(11) NOT NULL,
  `yearLvl` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `yeartb`
--

INSERT INTO `yeartb` (`yearId`, `yearLvl`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coursetb`
--
ALTER TABLE `coursetb`
  ADD PRIMARY KEY (`courseId`);

--
-- Indexes for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  ADD PRIMARY KEY (`studentId`),
  ADD KEY `courseId` (`courseId`),
  ADD KEY `yearId` (`yearId`);

--
-- Indexes for table `yeartb`
--
ALTER TABLE `yeartb`
  ADD PRIMARY KEY (`yearId`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  ADD CONSTRAINT `studentrecordtb_ibfk_1` FOREIGN KEY (`courseId`) REFERENCES `coursetb` (`courseId`),
  ADD CONSTRAINT `studentrecordtb_ibfk_2` FOREIGN KEY (`yearId`) REFERENCES `yeartb` (`yearId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
