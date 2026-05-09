-- 1. Buat Database (jika belum ada)
CREATE DATABASE IF NOT EXISTS endfield CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE endfield;

-- 2. Tabel Kategori (8 jenis sesuai draft)
CREATE TABLE IF NOT EXISTS kategori (
    kode_kategori VARCHAR(50) NOT NULL PRIMARY KEY,
    nama_kategori VARCHAR(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 3. Tabel Alat (relasi ke kategori)
CREATE TABLE IF NOT EXISTS alat (
    kode_alat VARCHAR(50) NOT NULL PRIMARY KEY,
    nama_alat VARCHAR(100) NOT NULL,
    wilayah VARCHAR(50) DEFAULT NULL,
    deskripsi TEXT DEFAULT NULL,
    kode_kategori VARCHAR(50) DEFAULT NULL,
    foto_path VARCHAR(255) DEFAULT NULL,
    CONSTRAINT fk_alat_kategori FOREIGN KEY (kode_kategori) REFERENCES kategori(kode_kategori) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 4. Tabel Users (Opsional: untuk login berbasis DB di masa depan)
CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(20) DEFAULT 'admin'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 5. Data Sample Kategori (8 item)
INSERT INTO kategori (kode_kategori, nama_kategori) VALUES
('ELEK', 'Elektronik'),
('MEKA', 'Mekanik'),
('KIMIA', 'Kimia'),
('SIPIL', 'Sipil'),
('TANI', 'Pertanian'),
('IKAN', 'Perikanan'),
('ENGI', 'Energi'),
('IT', 'Teknologi Informasi');

-- 6. User Default (sesuai hardcoded di Form1.vb)
INSERT INTO users (username, password, role) VALUES ('admin', '12345', 'admin');