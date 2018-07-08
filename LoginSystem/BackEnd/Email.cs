using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace LoginSystem.BackEnd {
    class Email {

        private string admin_email = "PLEASE_ENTER_YOUR_EMAIL_ADDRESS_HERE";
        private string admin_pass = "PLEASE_ENTER_YOUR_PASSWORD_HERE";

        /*
         * I've used SMTP please make sure to allow less secure apps 
         * to use your account.
         * RELATED LINK  https://support.google.com/accounts/answer/6010255
         */ 

        private SmtpClient emailClient;

        public Email() {
            GetEmailClient();
        }

        public void GetEmailClient() {

            try {

                emailClient = new SmtpClient("smtp.gmail.com", 587);
                emailClient.Credentials = new NetworkCredential(admin_email, admin_pass);
                emailClient.EnableSsl = true;
            }
            catch(Exception e) {
                MessageBox.Show("Error occured while getting Email Client " + e.Message);
            }

        }

        public Boolean SendCode(string email , string code) {

            Boolean status;

            try {

                emailClient.Send(admin_email, email, "Password Recovery Code", code);
                status = true;

            }
            catch(Exception e) {
                MessageBox.Show("Error occured while sending code " + e.Message);
                status = false;
            }

            return status;
        }


    }
}
