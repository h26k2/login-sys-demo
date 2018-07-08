using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.BackEnd;

namespace LoginSystem {
    static class Program {

        public static string user_email;
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void CloseStuff() {

            Database db = new Database();
            string query = String.Format
                ("delete from pass_req_details where email = '{0}'", user_email);
            db.AddQuery(query);
            db.ExecuteQuery();
            db.CloseConnection();

        }

    }
}
