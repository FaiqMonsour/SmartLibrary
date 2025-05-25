-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 26, 2025 at 01:47 AM
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
-- Database: `library_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) DEFAULT NULL,
  `publisher` varchar(50) NOT NULL,
  `category` varchar(100) DEFAULT NULL,
  `year` int(25) NOT NULL,
  `isbn` int(11) NOT NULL,
  `available_copies` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `title`, `author`, `publisher`, `category`, `year`, `isbn`, `available_copies`) VALUES
(1, 'php', 'waleed', '', 'language ', 0, 0, 1),
(2, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(3, 'c#', 'hasan', '', NULL, 0, 0, 1),
(4, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(5, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(6, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(7, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(8, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(9, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(10, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(12, 'c#', 'ghassan', '', NULL, 0, 0, 1),
(13, 'web', 'waleed', '', NULL, 0, 0, 1),
(15, 'web', 'waleed', '', NULL, 0, 0, 1),
(16, 'web', 'waleed', '', NULL, 0, 0, 1),
(18, 'web', 'waleed', '', NULL, 0, 0, 1),
(19, 'web', 'waleed', '', NULL, 0, 0, 1),
(20, 'java', 'ghassan', '', NULL, 0, 0, 1),
(21, 'software', 'mohammed', '', NULL, 0, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `borrows`
--

CREATE TABLE `borrows` (
  `issue_id` int(11) NOT NULL,
  `book_title` int(11) DEFAULT NULL,
  `user_name` int(11) DEFAULT NULL,
  `issue_date` date DEFAULT NULL,
  `return_date` date DEFAULT NULL,
  `status` enum('borrowed','returned') DEFAULT 'borrowed'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `fines`
--

CREATE TABLE `fines` (
  `id` int(11) NOT NULL,
  `member_id` int(11) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `issued_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `member_id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `date` varchar(50) NOT NULL,
  `gender` enum('male','female') NOT NULL,
  `address` varchar(50) NOT NULL,
  `phone` int(20) NOT NULL,
  `role` enum('admin','member','userprovider') DEFAULT 'member'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `email`, `date`, `gender`, `address`, `phone`, `role`) VALUES
(2, 'wadea', '$2y$10$rX/xYGg7HkuY7ie1dZUD.uuyGRZjN2m6CCQe5VgWSnvZXSwKGOw9i', 'wadeaalrajhy10@gmail.com', '2025-05-26', 'male', 'taiz', 63848434, 'userprovider'),
(3, 'waleed razaz', '$2y$10$oDl0Su38UIm1JowrSX1Rpe4g7XNt6oA6VNocuszvpuUjMlcPMsPIi', 'wlydalrajhy180@gmail.com', '2003-09-29', 'male', 'taiz', 714406399, 'admin'),
(4, 'ghassan', '$2y$10$CeuHI2W.Ngscvp1lilgZeegBpBKBf1XLN6SIEhuPLb.4UONug3xvC', 'ghassan@gmail.com', '', 'male', '', 0, 'member'),
(5, 'aymen', '$2y$10$.paSfEPVoiSB7tW.LsZLMOPFv/MspUT8v1vgrPMtBlUFbH9Z5yTCG', 'aymen@gmail.com', '2025-05-28', 'male', 'taiz', 38387632, 'member');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_id`);

--
-- Indexes for table `borrows`
--
ALTER TABLE `borrows`
  ADD PRIMARY KEY (`issue_id`),
  ADD KEY `book_id` (`book_title`),
  ADD KEY `member_id` (`user_name`);

--
-- Indexes for table `fines`
--
ALTER TABLE `fines`
  ADD PRIMARY KEY (`id`),
  ADD KEY `member_id` (`member_id`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`member_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `borrows`
--
ALTER TABLE `borrows`
  MODIFY `issue_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `fines`
--
ALTER TABLE `fines`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `member_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `borrows`
--
ALTER TABLE `borrows`
  ADD CONSTRAINT `borrows_ibfk_1` FOREIGN KEY (`book_title`) REFERENCES `books` (`book_id`),
  ADD CONSTRAINT `borrows_ibfk_2` FOREIGN KEY (`user_name`) REFERENCES `members` (`member_id`);

--
-- Constraints for table `fines`
--
ALTER TABLE `fines`
  ADD CONSTRAINT `fines_ibfk_1` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
