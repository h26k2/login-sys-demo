using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace LoginSystem.BackEnd {
    class Database {


        SqlConnection con;
        SqlCommand command;
        SqlDataReader reader;

        public Database() {
            EstablishConnection();
        }


        public void EstablishConnection() {
            try {
                con = new SqlConnection
                    ("Server = ENTER_YOUR_SERVER_NAME_HERE ; Database = LoginSystem ; Trusted_Connection = true");
                con.Open();
            }
            catch(Exception e) {
                MessageBox.Show
                    ("Error occured while establishing Connection to DB " + e.Message);
            }
        }


        public void AddQuery(string query) {
            try {

                command = new SqlCommand(query, con);

            }
            catch(Exception e) {
                MessageBox.Show
                    ("Error occured while adding query " + e.Message);
            }
        }

        public int ExecuteQuery() {

            int status = 0;

            try {

                status = command.ExecuteNonQuery();

            }
            catch(Exception e) {
                MessageBox.Show
                    ("Error occured while executing query " + e.Message);
            }

            return status;

        }

        public void CloseConnection() {
            con.Close();
        }


        public ArrayList GetDataWithStatus() {

            ArrayList returnStatus = new ArrayList();

            try {
                reader = command.ExecuteReader();

                if (reader.Read()) {
                    returnStatus.Add(true);
                    returnStatus.Add(reader.GetString(0));
                }
                else {
                    returnStatus.Add(false);
                }

            }
            catch(Exception e) {
                MessageBox.Show
                    ("Error occured while getting data from database " + e.Message);
            }

            reader.Close();
            return returnStatus;
            

        }

    }
}
