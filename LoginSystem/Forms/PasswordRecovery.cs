using LoginSystem.BackEnd;
using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem.Forms
{
    public partial class PasswordRecovery : Form
    {
        public PasswordRecovery()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form1().Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ========== Getting Raw Data From User ===============

            string inputted_text = this.textBox1.Text;
            string temp_query = String.Format
            ("select email from login_details where email = '{0}' or username = '{0}'",
            inputted_text);

            /*========================================================================
             * Connecting to Database and checing whether the user inputted
             * email or username is valid or not. If valid then it is going to save
             * a random code to database and also sending this code to user email
             * so that he / she can enter that code and recover his / her password
             ======================================================================== */

            Database db = new Database();
            db.AddQuery(temp_query);
            ArrayList status = db.GetDataWithStatus();

            // =========== When the user inputted data is valid ============

            if (status.Count > 1)
            {
                //========== Getting user email from the database ===========

                string email = status[1].ToString();
                Program.user_email = email;

                // ========= Generating Random Code  =====================

                Random rnd = new Random();
                int randomCode = rnd.Next(1000, 100000);

                string temp_query1 = String.Format
                 ("insert into pass_req_details values ( '{0}' , '{1}' )",
                 email, randomCode.ToString());

                db.AddQuery(temp_query1);

                int querystatus = db.ExecuteQuery();

                //When the code successfully added to the database

                if (querystatus == 1)
                {
                    //Sending email on successful insertion of code to DB

                    Email mail = new Email();
                    Boolean mailStatus = mail.SendCode(email, randomCode.ToString());

                    if (mailStatus)
                    {
                        this.Visible = false;
                        new CodeVerification().Visible = true;
                        MessageBox.Show("We've successfully sent you recovery code " +
                            "at " + email + " please enter that code to recover your password");

                        /* ======================================================
                         * Using a function that is going to expire that code
                         * after some time Means after some time the code which
                         * was sent to user will be expired
                         ============================================================*/

                        Task.Factory.StartNew(() =>
                        {
                            System.Threading.Thread.Sleep(50000);
                            Program.CloseStuff();
                        });
                    }
                    else
                    {
                        MessageBox.Show("Error occured While sending recovery code");
                    }
                }
                else
                {
                    MessageBox.
                   Show("Error occured while generating and saving recovery code");
                }
            }
            else
            {
                MessageBox.Show("We're sorry we couldn't find your email address or " +
                    "username in our databse");
            }

            // ======== For Clearing The Text Field ============

            clearText();
        }

        private void clearText()
        {
            this.textBox1.Text = "";
        }
    }
}