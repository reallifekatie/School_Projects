-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2022 at 10:48 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `petshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `contacts`
--

CREATE TABLE `contacts` (
  `contact_id` int(11) NOT NULL,
  `contact_fname` text NOT NULL,
  `contact_lname` text NOT NULL,
  `contact_email` text NOT NULL,
  `contact_question` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `contacts`
--

INSERT INTO `contacts` (`contact_id`, `contact_fname`, `contact_lname`, `contact_email`, `contact_question`) VALUES
(1, 'Suzie', 'Cue', 'suzie@cue.com', 'Howdy?'),
(6, 'Bob', 'Hope', 'bob@hope.com', 'keep hope alive'),
(7, 'a', 'a', 'a', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `petguide`
--

CREATE TABLE `petguide` (
  `petguide_id` int(11) NOT NULL,
  `petguide_header` text NOT NULL,
  `petguide_blurb` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `petguide`
--

INSERT INTO `petguide` (`petguide_id`, `petguide_header`, `petguide_blurb`) VALUES
(3, 'Pet Training Guides', 'Donec a purus sit amet risus consectetur lacinia et ut libero. Vestibulum tempus fauscibus sagittis. Ut gravida lacus eget orci bibendum aliuet. A enean adipiscing congue mi a fringilla. Suspendisse placerat arcu ac est pharetra sit amet pretium ante.'),
(4, 'Make Them Behave', 'Ut gravida lacus eget orci bibendum aliuet. A enean adipiscing congue mi a fringilla. Suspendisse placerat arcu ac est pharetra sit amet pretium ante. porta. Duis risus augue, sollicitudin sit amet enim.'),
(5, 'Food They Need', 'Donec a purus sit amet risus consectetur lacinia et ut libero. Vestibulum tempus fauscibus sagittis. Ut gravida lacus eget orci bibendum aliuet. A enean adipiscing congue mi a fringilla. Suspendisse placerat arcu ac est pharetra sit amet pretium ante.'),
(6, 'Dos and Donts', 'Ut gravida lacus eget orci bibendum aliuet. A enean adipiscing congue mi a fringilla. Suspendisse placerat arcu ac est pharetra sit amet pretium ante. porta. Duis risus augue, sollicitudin sit amet enim.'),
(7, 'Pet Foods', 'Donec a purus sit amet risus consectetur lacinia et ut libero. Vestibulum tempus fauscibus sagittis. Ut gravida lacus eget orci bibendum aliuet. A enean adipiscing congue mi a fringilla. Suspendisse placerat arcu ac est pharetra sit amet pretium ante.'),
(8, 'Healthy Recipes for Pets', 'Ut gravida lacus eget orci bibendum aliuet. A enean adipiscing congue mi a fringilla. Suspendisse placerat arcu ac est pharetra sit amet pretium ante. porta. Duis risus augue, sollicitudin sit amet enim.');

-- --------------------------------------------------------

--
-- Table structure for table `petmart`
--

CREATE TABLE `petmart` (
  `petmart_id` int(11) NOT NULL,
  `petmart_image` text NOT NULL,
  `petmart_category` text NOT NULL,
  `petmart_listing` text NOT NULL,
  `petmart_listing_link` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `petmart`
--

INSERT INTO `petmart` (`petmart_id`, `petmart_image`, `petmart_category`, `petmart_listing`, `petmart_listing_link`) VALUES
(1, 'images/koi2.jpg', 'Food Area', 'Dog Food', 'petmart.php'),
(2, 'images/koi2.jpg', 'Food Area', 'Cat Food', 'petmart.php'),
(3, 'images/koi2.jpg', 'Food Area', 'Bird Food', 'petmart.php'),
(4, 'images/koi2.jpg', 'Food Area', 'Fish Food', 'petmart.php'),
(5, 'images/koi2.jpg', 'Food Area', 'Reptile Food', 'petmart.php'),
(6, 'images/koi2.jpg', 'Food Area', 'Small Pet Food', 'petmart.php'),
(7, 'images/koi2.jpg', 'Food Area', 'Large Pet Food', 'petmart.php'),
(8, 'images/cat3.jpg', 'Accessories', 'Odor Control', 'petmart.php'),
(9, 'images/cat3.jpg', 'Accessories', 'Liners', 'petmart.php'),
(10, 'images/cat3.jpg', 'Accessories', 'Scoops & Mats', 'petmart.php'),
(11, 'images/cat3.jpg', 'Accessories', 'Collars', 'petmart.php'),
(12, 'images/cat3.jpg', 'Accessories', 'Harnesses', 'petmart.php'),
(13, 'images/cat3.jpg', 'Accessories', 'ID Tags', 'petmart.php'),
(14, 'images/cat3.jpg', 'Accessories', 'Leashes', 'petmart.php'),
(15, 'images/dog2.jpg', 'Training & Behavior', 'Dog Food', 'petmart.php'),
(16, 'images/dog2.jpg', 'Training & Behavior', 'Cat Food', 'petmart.php'),
(17, 'images/dog2.jpg', 'Training & Behavior', 'Bird Food', 'petmart.php'),
(18, 'images/dog2.jpg', 'Training & Behavior', 'Fish Food', 'petmart.php'),
(19, 'images/dog2.jpg', 'Training & Behavior', 'Reptile Food', 'petmart.php'),
(20, 'images/dog2.jpg', 'Training & Behavior', 'Small Pet Food', 'petmart.php'),
(21, 'images/bird3.jpg', 'Health Center', 'Multivitamins', 'petmart.php'),
(22, 'images/bird3.jpg', 'Health Center', 'Dental Care', 'petmart.php'),
(23, 'images/bird3.jpg', 'Health Center', 'First Aid Kits', 'petmart.php'),
(24, 'images/bird3.jpg', 'Health Center', 'Medications', 'petmart.php'),
(25, 'images/bird3.jpg', 'Health Center', 'Supplements', 'petmart.php'),
(26, 'images/bird3.jpg', 'Health Center', 'Eye & Ear Care', 'petmart.php'),
(27, 'images/bird3.jpg', 'Health Center', 'Hip & Joint Health', 'petmart.php'),
(28, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Car Barriers', 'petmart.php'),
(29, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Car Seat Covers', 'petmart.php'),
(30, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Car Seats', 'petmart.php'),
(31, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Ramps', 'petmart.php'),
(32, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Seat Belts & Harnesses', 'petmart.php'),
(33, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Strollers', 'petmart.php'),
(34, 'images/bird-in-cage.jpg', 'Travel Essentials', 'Travel Crates & Carriers', 'petmart.php'),
(35, 'images/puppy3.jpg', 'Grooming', 'Brushes & Combs', 'petmart.php'),
(36, 'images/puppy3.jpg', 'Grooming', 'Deodorizers', 'petmart.php'),
(37, 'images/puppy3.jpg', 'Grooming', 'Cologne', 'petmart.php'),
(38, 'images/puppy3.jpg', 'Grooming', 'Ear & Eye Cleaners', 'petmart.php'),
(39, 'images/puppy3.jpg', 'Grooming', 'Nail Clippers', 'petmart.php'),
(40, 'images/puppy3.jpg', 'Grooming', 'Shampoo', 'petmart.php'),
(41, 'images/puppy3.jpg', 'Grooming', 'Conditioners', 'petmart.php'),
(42, 'images/puppy3.jpg', 'Grooming', 'Shed Controls', 'petmart.php');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_fname` text NOT NULL,
  `user_lname` text NOT NULL,
  `user_email` text NOT NULL,
  `user_password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_fname`, `user_lname`, `user_email`, `user_password`) VALUES
(1, 'Katie', 'Smith', 'me@me.com', '0ffe1abd1a08215353c233d6e009613e95eec4253832a761af28ff37ac5a150c');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contacts`
--
ALTER TABLE `contacts`
  ADD PRIMARY KEY (`contact_id`);

--
-- Indexes for table `petguide`
--
ALTER TABLE `petguide`
  ADD PRIMARY KEY (`petguide_id`);

--
-- Indexes for table `petmart`
--
ALTER TABLE `petmart`
  ADD PRIMARY KEY (`petmart_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contacts`
--
ALTER TABLE `contacts`
  MODIFY `contact_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `petguide`
--
ALTER TABLE `petguide`
  MODIFY `petguide_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `petmart`
--
ALTER TABLE `petmart`
  MODIFY `petmart_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
