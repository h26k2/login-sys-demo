using LoginSystem.BackEnd;
using LoginSystem.Forms;
using System;
using System.Collections;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new PasswordRecovery().Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //========= Collecting Raw Data From User===============
            string inputted_email = "";
            if (!txt_username.Text.Contains("@"))
            {
                inputted_email = txt_username.Text;
            }
            else
            {
                MessageBox.Show("Whoa! Username or password didn't matched our records");
                return;
            }
            string inputted_pass = txt_password.Text;
            string temp_query = String.Format
            ("select name from login_details where username = '{0}' or email = '{1}' " +
            "and pass = '{2}'", inputted_email, inputted_email, inputted_pass);

            /*========================================================================
             * Sending Query to Database and checking whether the user inputted data
             * is right or wrong.. if right then the user will be redirected to
             * dashboard page else a error message will be showed to the user
             =========================================================================*/

            Database db = new Database();
            db.AddQuery(temp_query);
            ArrayList status = db.GetDataWithStatus();

            if (status.Count > 1)
            {
                string user = status[1].ToString();
                this.Visible = false;
                new Dashboard(user).Visible = true;
            }
            else
            {
                MessageBox.Show("Whoa! Username or password didn't matched our records");
            }

            //=============== Clearing Text Boxes ============

            ClearTextBoxes();
        }

        public void ClearTextBoxes()
        {
            this.txt_username.Text = "";
            this.txt_password.Text = "";
        }
    }
}