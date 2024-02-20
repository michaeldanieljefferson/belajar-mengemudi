-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Waktu pembuatan: 25. Oktober 2017 jam 17:08
-- Versi Server: 5.1.41
-- Versi PHP: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `phonebook`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `customer_ID` int(5) NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(40) NOT NULL,
  `customer_phone` varchar(15) NOT NULL,
  PRIMARY KEY (`customer_ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`customer_ID`, `customer_name`, `customer_phone`) VALUES
(1, 'Jhonny Deep', '0854554433'),
(2, 'Roy Franco', '0853421221'),
(3, 'Ivan Gunawan', '0867555551'),
(4, 'Erick Van De Borg', '0856599998'),
(7, 'Wanda ', ' 087877765699'),
(6, 'Joel ', ' 087877765654'),
(8, 'Qiky Enal', ' 087877765691'),
(9, 'Reylan Foxy', '0878777676'),
(10, 'Olvin Richardson', ' 089865543433'),
(12, 'Rean ', ' 0865666643'),
(13, 'Rey ', ' 085288888888'),
(14, 'Kailin ', ' 085487767677');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
