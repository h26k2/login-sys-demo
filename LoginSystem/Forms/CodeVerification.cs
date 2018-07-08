using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.BackEnd;
using System.Collections;

namespace LoginSystem.Forms {
    public partial class CodeVerification : Form {
        public CodeVerification() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            
            //=========== Getting Raw Data From the User ==========


            string inputted_code = this.textBox1.Text;
            string temp_query = string.Format
                ("select email from pass_req_details where code = '{0}' ", inputted_code);


            /*======================================================================
             * Checking user inputted code either user inputted entered the right
             * code or wrong if the code is correct then the user will be 
             * redirected to password recovery page other-wise error message will
             * be show to the user.
             * ======================================================================*/


            Database db = new Database();
            db.AddQuery(temp_query);

            ArrayList status = db.GetDataWithStatus();

            if(status.Count > 1) {
                MessageBox.Show("Congratulation! Your code matched our records, now "+
                    "you can recover your password");
                this.Visible = false;
                Program.CloseStuff();
                new SetPassword(status[1].ToString()).Visible = true;
            }
            else {
                MessageBox.Show("Error Occured! We couldn't find your inputted  code in " +
                    "our database. Make sure that you're inputting right code");
            }


            // =========== For Clearing The Text Field ==============

            ClearText();


        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ClearText() {
            this.textBox1.Text = "";
        }

        private void CodeVerification_FormClosing(object sender, FormClosingEventArgs e) {

            Program.CloseStuff();

        }
    }
}
