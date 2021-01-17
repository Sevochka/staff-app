using Newtonsoft.Json;
using StaffApp.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffApp
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

            DB database = new DB();
            ServerData server = DB.server;

            File.WriteAllText("serviceData.json", JsonConvert.SerializeObject(server));

            database.setConnectionData();

            Application.Run(new FormPanelMenu(database));
        }
    }
}
