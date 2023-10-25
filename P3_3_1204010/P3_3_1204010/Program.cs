using System;

class Program
{
    static void Main()
    {
        string ulangi;

        do
        {
            int menu;
            bool menuValid = false;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Keliling Persegi Panjang");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        HitungLuas();
                        menuValid = true;
                        break;
                    case 2:
                        HitungKeliling();
                        menuValid = true;
                        break;
                    case 3:
                        Console.WriteLine("Terima kasih, program selesai.");
                        menuValid = true;
                        break;
                    default:
                        Console.WriteLine("Menu tidak valid. Silakan pilih lagi.");
                        break;
                }

            } while (!menuValid);

            Console.Write("Apakah Anda ingin mengulang program? (Y/T): ");
            ulangi = Console.ReadLine();

        } while (ulangi.ToLower() == "y");
    }

    static void HitungLuas()
    {
        Console.Write("Masukkan panjang: ");
        double panjang = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan lebar: ");
        double lebar = Convert.ToDouble(Console.ReadLine());

        double luas = panjang * lebar;
        Console.WriteLine($"Luas persegi panjang adalah: {luas}");
    }

    static void HitungKeliling()
    {
        Console.Write("Masukkan panjang: ");
        double panjang = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan lebar: ");
        double lebar = Convert.ToDouble(Console.ReadLine());

        double keliling = 2 * (panjang + lebar);
        Console.WriteLine($"Keliling persegi panjang adalah: {keliling}");
    }
}
