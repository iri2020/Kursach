using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoi
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static string podkl = @"Data Source=DESKTOP-HQ2MQUP\MSSQLSERVER2;Initial Catalog=Igra;Integrated Security=True";
        public static int id_user = -1;
        public static bool type_user = true;
        public static string urov;
        public static int row;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
