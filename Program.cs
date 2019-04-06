using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VehicleForm());

            string sqlConnectionString = @"Data Source=DESKTOP-4SS4FRO;Initial Catalog=Vehicles;Integrated Security=True";
           
            SqlConnection mySql = new SqlConnection(sqlConnectionString);
            mySql.Open();
            Console.WriteLine("Connected!");


        }
    }
}
