﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Windows.Forms;
using Winform_Nhom20_BTL.GUI;

namespace Winform_Nhom20_BTL
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
            Application.Run(new LoginForm());
        }

        //static string connectionString = @"Data Source=RAZER;Initial Catalog=QLRP;Integrated Security=True;Trust Server Certificate=True";
    }
}
