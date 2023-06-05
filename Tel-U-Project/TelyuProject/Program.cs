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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            try
            {
                using (FileStream fs = new FileStream("filename.txt", FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);


                    sr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
