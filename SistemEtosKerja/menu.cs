using System;

namespace SistemEtosKerja
{
    internal class Menu
    {
        public static void MainMenu()
        {
            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU UTAMA ===");
                Console.WriteLine("1. Melihat Jobdesk");
                Console.WriteLine("2. Melakukan Presensi");
                Console.WriteLine("3. Mengelola Jobdesk Karyawan");
                Console.WriteLine("4. Mengelola Data Karyawan");
                Console.WriteLine("5. Mengelola Presensi");
                Console.WriteLine("6. Mengelola Penggajian");
                Console.WriteLine("0. Keluar");
                Console.Write("Masukkan pilihan Anda: ");

                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Input tidak valid. Tekan Enter untuk melanjutkan.");
                    Console.ReadLine();
                    continue;
                }

                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        LihatJobdesk();
                        break;
                    case 2:
                        Presensi();
                        break;
                    case 3:
                        KelolaJobdesk();
                        break;
                    case 4:
                        KelolaDataKaryawan();
                        break;
                    case 5:
                        KelolaPresensi();
                        break;
                    case 6:
                        KelolaPenggajian();
                        break;
                    case 0:
                        Console.WriteLine("Terima kasih. Program selesai.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia.");
                        break;
                }

                if (pilihan != 0)
                {
                    Console.WriteLine("\nTekan Enter untuk kembali ke menu.");
                    Console.ReadLine();
                }

            } while (pilihan != 0);
        }

        static void LihatJobdesk() => Console.WriteLine("Contoh: Anda bertugas membuat laporan mingguan.");
        static void Presensi()
        {
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine($"Presensi berhasil dicatat untuk {nama} pada {DateTime.Now}");
        }
        static void KelolaJobdesk() => Console.WriteLine("Contoh: Tambah/Edit/Hapus jobdesk.");
        static void KelolaDataKaryawan() => Console.WriteLine("Contoh: Tambah/Edit/Hapus data karyawan.");
        static void KelolaPresensi() => Console.WriteLine("Contoh: Lihat/mengubah data presensi karyawan.");
        static void KelolaPenggajian() => Console.WriteLine("Contoh: Proses gaji, tunjangan, dan potongan.");
    }
}
