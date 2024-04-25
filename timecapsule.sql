-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 25 Nis 2024, 19:56:54
-- Sunucu sürümü: 10.4.25-MariaDB
-- PHP Sürümü: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `timecapsule`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `note`
--

CREATE TABLE `note` (
  `id` int(10) UNSIGNED NOT NULL,
  `note` text COLLATE utf8_turkish_ci NOT NULL,
  `display_date` date NOT NULL,
  `created_at` date NOT NULL,
  `unread` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `note`
--

INSERT INTO `note` (`id`, `note`, `display_date`, `created_at`, `unread`) VALUES
(2, 'Hadi Bakalım', '2024-04-08', '2024-04-09', 0),
(3, 'Deneme', '2024-04-09', '2024-04-09', 0),
(4, 'Hadi Bakalım', '2024-04-12', '2024-04-09', 0),
(5, 'Selim Ahmet', '2024-04-25', '2024-04-09', 1),
(6, 'Selim Ahmetdsda', '2024-04-02', '2024-04-09', 0),
(7, 'Selim Ahmetdsda', '2024-04-09', '2024-03-30', 0),
(8, 'Selim Ahmetdsda', '2024-04-09', '2024-04-09', 0),
(9, 'Selim Ahmetdsda', '2024-04-09', '2024-04-08', 0),
(10, 'Selim Ahmetdsda', '2024-04-09', '2024-04-07', 0),
(11, 'Selim Ahmetdsda', '2024-04-09', '2024-04-06', 0),
(12, 'Selim Ahmetdsda', '2024-04-09', '2024-04-05', 0),
(13, 'Selim Ahmetdsda', '2024-04-08', '2024-04-03', 0),
(14, 'Selim Ahmetdsda', '2024-04-08', '2024-04-02', 0),
(15, 'Selim Ahmetdsda', '2024-04-08', '2024-04-04', 0),
(16, 'Selim Ahmetdsda', '2024-04-08', '2024-04-01', 0),
(17, 'Deneme', '2024-04-10', '2024-04-10', 0),
(18, 'Hadi Bakalım', '2024-04-13', '2024-04-10', 1),
(19, 'Önümüzdeki ay selamlar seni sabırsızlıkla bekliyorum.', '2024-05-01', '2024-04-25', 1),
(20, 'Selamlar gelecek sene seni çoook bekledim', '2025-04-25', '2024-04-25', 1),
(21, 'Bu mesajı okyan kisi çok sanslı', '2024-05-05', '2024-04-25', 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `note`
--
ALTER TABLE `note`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `note`
--
ALTER TABLE `note`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
