-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Waktu pembuatan: 08. Nopember 2016 jam 16:13
-- Versi Server: 5.1.41
-- Versi PHP: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `jagomengemudi`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_teacher`
--

CREATE TABLE IF NOT EXISTS `db_teacher` (
  `teacher_id` int(5) NOT NULL AUTO_INCREMENT,
  `teacher_username` varchar(20) NOT NULL,
  `teacher_password` varchar(15) NOT NULL,
  `teacher_name` varchar(30) NOT NULL,
  `teacher_age` int(2) NOT NULL,
  `teacher_number` varchar(13) NOT NULL,
  `teacher_address` varchar(40) NOT NULL,
  `teacher_mengajar` varchar(7) NOT NULL,
  `teacher_honor` int(7) NOT NULL,
  PRIMARY KEY (`teacher_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data untuk tabel `db_teacher`
--

INSERT INTO `db_teacher` (`teacher_id`, `teacher_username`, `teacher_password`, `teacher_name`, `teacher_age`, `teacher_number`, `teacher_address`, `teacher_mengajar`, `teacher_honor`) VALUES
(1, 'ririn'  , '12345', 'ririn anindia'  , 30, '082145332345', 'Jl.pramuka'   , 'mobil', 100000),
(2, 'rizal'  , '11234', 'rizal bakri'    , 29, '089939854458', 'Jl.pegangsaan', 'motor', 80000),
(3, 'karina' , '22345', 'karina yubiwat' , 35, '081339485723', 'Jl.merdeka   ', 'mobil', 120000),
(4, 'jakob'  , '34567', 'jakobus lestra' , 28, '089834583457', 'Jl.garuda    ', 'motor', 90000),
(5, 'yolanda', '33345', 'yolanda lestari', 35, '089927543875', 'Jl.retera    ', 'mobil', 110000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_student`
--

CREATE TABLE IF NOT EXISTS `db_student` (
  `student_id` int(9) NOT NULL AUTO_INCREMENT,
  `student_username` varchat(20) NOT NULL,
  `student_password` varchar(15) NOT NULL,
  `student_name` varchar(30) NOT NULL,
  `student_age` varchar(2) NOT NULL,
  `student_number` varchar(13) NOT NULL,
  `student_address` varchar(40) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data untuk tabel `db_student`
--

INSERT INTO `db_student` (`student_id`, `id_mobil`, `id_customer`, `Status`, `mulai_sewa`, `selesai_sewa`, `denda_sewa`, `total_sewa`, `user`) VALUES
(1, 1, 1, 1, '2016-11-08', '2016-11-10', 0, 700000, 1),
(2, 1, 1, 1, '0000-00-00', '0000-00-00', 0, 700000, 1),
(3, 1, 1, 1, '2016-11-08', '2016-11-10', 0, 700000, 1),
(4, 1, 1, 1, '2016-11-08', '2016-11-17', 0, 3150000, 1),
(5, 1, 1, 1, '2016-11-08', '2016-11-09', 0, 350000, );

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_mobil`
--

CREATE TABLE IF NOT EXISTS `db_mobil` (
  `id_mobil` int(11) NOT NULL AUTO_INCREMENT,
  `no_polisi` varchar(11) NOT NULL,
  `nama_pemilik` varchar(50) NOT NULL,
  `alamat_pemilik` varchar(50) NOT NULL,
  `merek` varchar(10) NOT NULL,
  `tahun_pembuatan` varchar(4) NOT NULL,
  `warna` varchar(20) NOT NULL,
  `no_rangka` varchar(30) NOT NULL,
  `no_mesin` varchar(30) NOT NULL,
  `no_bpkb` varchar(30) NOT NULL,
  `biaya_harian` int(30) NOT NULL,
  `jenis_model` varchar(30) NOT NULL,
  `tahun_perakitan` varchar(4) NOT NULL,
  `isi_silinder` varchar(5) NOT NULL,
  `warna_tnkb` varchar(20) NOT NULL,
  `bahan_bakar` varchar(10) NOT NULL,
  `Status` int(1) NOT NULL,
  PRIMARY KEY (`id_mobil`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data untuk tabel `db_mobil`
--

INSERT INTO `db_mobil` (`id_mobil`, `no_polisi`, `nama_pemilik`, `alamat_pemilik`, `merek`, `tahun_pembuatan`, `warna`, `no_rangka`, `no_mesin`, `no_bpkb`, `biaya_harian`, `jenis_model`, `tahun_perakitan`, `isi_silinder`, `warna_tnkb`, `bahan_bakar`, `Status`) VALUES
(1, 'DB1234AV', 'El Irawan', 'Jl. Soekarno no.5 Aermadidi', 'Honda', '2015', 'Silver', '087657898767890', '987890987890987', '00898', 350000, 'Honda Mobilio', '2015', '1500', 'Silver', 'Bensi', 1),
(2, 'DB5432AV', 'El Irawan', 'Jl. Soekarno no.5 Aermadidi', 'Honda', '2015', 'Hitam', '087657898767333', '987890987890333', '4532', 350000, 'Honda CRV', '2015', '1500', 'Hitam', 'Bensi', 0),
(3, 'DB 12 AV', 'El Savador', 'Jl. Soekarno No.3', 'Honda', '2015', 'Hitam', '08787456787654567', '00000888878777879', '0000088123333', 350000, 'Jazz', '2015', '1500', 'Hitam', 'Bensi', 0),
(4, 'DB 88 AV', 'El Savador', 'Jl. Soekarno No.3', 'Honda', '2015', 'Putih', '00000333', '00000002', '05555554', 300000, 'Mobillio', '2015', '1500', 'Putih', 'Bensin', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `id_user` int(3) NOT NULL,
  `level_user` varchar(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id_user`),
  KEY `id_user` (`id_user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id_user`, `level_user`, `username`, `password`) VALUES
(1, 'kasir', 'Jony', '12345'),
(2, 'kasir', 'Nancy', '12345');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
