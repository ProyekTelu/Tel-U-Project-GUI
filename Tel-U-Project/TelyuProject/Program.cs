using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TelyuProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Project project1 = new Project
            {
                Title = "Sistem Informasi Penjualan",
                Lecturer = "Dr. Ahmad",
                Description = "Membuat sistem informasi penjualan untuk toko baju online",
                Prodi = new List<string>() { "S1 Informatika", "S1 Sistem Informasi", "S1 Teknik Komputer" },
                StartDate = new DateTime(2022, 1, 1),
                EndDate = new DateTime(2022, 6, 30),
                linkGroup = "https://web.whatsapp.com/",
                quota = 6,
                IsDone = false,
                IsOpen = true

            };



            Project project2 = new Project
            {
                Title = "Aplikasi E-commerce",
                Lecturer = "Prof. Budi",
                Description = "Membuat aplikasi e-commerce untuk toko baju",
                Prodi = new List<string>() { "S1 Informatika", "S1 Sistem Informasi", "S1 Teknik Komputer" },
                StartDate = new DateTime(2022, 3, 1),
                EndDate = new DateTime(2022, 8, 31),
                quota = 6,
                linkGroup = "https://web.whatsapp.com/",
                IsDone = false,
                IsOpen = true
            };

            Project project3 = new Project
            {
                Title = "Aplikasi Mobile Restoran",
                Lecturer = "Dr. Hadi",
                Description = "Membuat aplikasi mobile untuk memesan makanan di restoran",
                Prodi = new List<string>() { "S1 Informatika", "S1 Sistem Informasi", "S1 Teknik Komputer" },
                StartDate = new DateTime(2022, 5, 1),
                EndDate = new DateTime(2022, 10, 31),
                linkGroup = "https://web.whatsapp.com/",
                quota = 3,
                IsDone = false,
                IsOpen = true
            };

            Project project4 = new Project
            {
                Title = "Sistem Informasi Perpustakaan",
                Lecturer = "Dr. Sarah",
                Description = "Membuat sistem informasi perpustakaan untuk universitas",
                Prodi = new List<string>() { "S1 Informatika", "S1 Sistem Informasi", "S1 Teknik Komputer" },
                StartDate = new DateTime(2022, 7, 1),
                EndDate = new DateTime(2022, 12, 31),
                linkGroup = "https://web.whatsapp.com/",
                quota = 8,
                IsDone = false,
                IsOpen = true
            };

            Project project5 = new Project
            {
                Title = "Sistem Informasi Akademik",
                Lecturer = "Dr. Andi",
                Description = "Membuat sistem informasi akademik untuk universitas",
                Prodi = new List<string>() { "S1 Informatika", "S1 Sistem Informasi", "S1 Teknik Komputer" },
                StartDate = new DateTime(2022, 9, 1),
                EndDate = new DateTime(2022, 2, 28),
                linkGroup = "https://web.whatsapp.com/",
                quota = 4,
                IsDone = false,
                IsOpen = true
            };

            Data.projectList.Add(project1);
            Data.projectList.Add(project2);
            Data.projectList.Add(project3);
            Data.projectList.Add(project4);
            Data.projectList.Add(project5);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            try{
                using (FileStream fs = new FileStream("filename.txt", FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);


                    sr.Close();
                    fs.Close();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
