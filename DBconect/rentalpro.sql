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
-- Database: `rentalpro`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_customer`
--

CREATE TABLE IF NOT EXISTS `db_customer` (
  `id_customer` int(5) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) NOT NULL,
  `no_ktp` varchar(15) NOT NULL,
  `no_hp` varchar(12) NOT NULL,
  `alamat_customer` varchar(50) NOT NULL,
  PRIMARY KEY (`id_customer`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data untuk tabel `db_customer`
--

INSERT INTO `db_customer` (`id_customer`, `nama`, `no_ktp`, `no_hp`, `alamat_customer`) VALUES
(1, 'Jery Richardo', '0007878766676', '085657777777', 'Jl. Ranoyapo No.3 Manado'),
(2, 'Meivi Nangoy', '0009898988898', '085347789989', 'Jl. Ranotana Weru No.1'),
(3, 'Nina Katrina', '0003493939534', '08432222332', 'Jl.Satu Nomor Dua'),
(4, 'Ririn Lala', '0000767677676', '085342344444', 'Jl. Yusuf Hasiru'),
(5, 'George Nangoy', '0000834434333', '08565434555', 'Jl. Unklab Manado'),
(7, 'Neril Roy', '0000078786712', '08768888989', 'Jl.Samrat No.3'),
(8, 'Ardi Lengkong', '0000008643434', '085240025844', 'Jl. Kayu Bulan No12'),
(9, 'Melisa Bernardo', '00000878656787', '087699999999', 'Jl. Parkvile Estate'),
(10, 'Lasarus Dony', '00000000737434', '0878777676', 'Jl. Klabat no.2'),
(11, 'Andre ', '00000909879809', '0878999881', 'Jl. Satu Dua Tiga');

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_data_transaksi`
--

CREATE TABLE IF NOT EXISTS `db_data_transaksi` (
  `id_transaksi` int(9) NOT NULL AUTO_INCREMENT,
  `id_mobil` int(3) NOT NULL,
  `id_customer` int(6) NOT NULL,
  `Status` int(1) NOT NULL DEFAULT '1',
  `mulai_sewa` date NOT NULL,
  `selesai_sewa` date NOT NULL,
  `denda_sewa` int(20) NOT NULL,
  `total_sewa` int(20) NOT NULL,
  `user` int(2) NOT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data untuk tabel `db_data_transaksi`
--

INSERT INTO `db_data_transaksi` (`id_transaksi`, `id_mobil`, `id_customer`, `Status`, `mulai_sewa`, `selesai_sewa`, `denda_sewa`, `total_sewa`, `user`) VALUES
(1, 1, 1, 1, '2016-11-08', '2016-11-10', 0, 700000, 1),
(2, 1, 1, 1, '0000-00-00', '0000-00-00', 0, 700000, 1),
(3, 1, 1, 1, '2016-11-08', '2016-11-10', 0, 700000, 1),
(4, 1, 1, 1, '2016-11-08', '2016-11-17', 0, 3150000, 1),
(5, 1, 1, 1, '2016-11-08', '2016-11-09', 0, 350000, 1),
(6, 1, 1, 1, '2016-11-08', '2016-11-12', 0, 1400000, 1),
(7, 0, 0, 1, '2016-11-08', '2016-11-10', 0, 700000, 1);

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
