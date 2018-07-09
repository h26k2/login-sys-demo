using LoginSystem.BackEnd;
using System;
using System.Windows.Forms;

namespace LoginSystem
{
    internal static class Program
    {
        public static string user_email;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void CloseStuff()
        {
            Database db = new Database();
            string query = String.Format
                ("delete from pass_req_details where email = '{0}'", user_email);
            db.AddQuery(query);
            db.ExecuteQuery();
            db.CloseConnection();
        }
    }
}