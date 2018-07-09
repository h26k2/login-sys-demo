﻿using LoginSystem.BackEnd;
using System;
using System.Windows.Forms;

namespace LoginSystem.Forms
{
    public partial class SetPassword : Form
    {
        private string email;

        public SetPassword(string mail)
        {
            InitializeComponent();
            email = mail;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // ============ Getting Raw Data =========

            string text1 = this.textBox1.Text;
            string text2 = this.textBox2.Text;

            /* =================================================================
             * If Inputted Password of both text boxes matches then the user
             * password would be updated
             * =================================================================*/

            if (text1.Equals(text2) && !text1.Contains(""))
            {
                string temp_query = String.Format
                    ("update login_details set pass = '{0}' where email = '{1}' ",
                    text1, email);

                Database db = new Database();
                db.AddQuery(temp_query);
                int status = db.ExecuteQuery();

                if (status == 1)
                {
                    MessageBox.Show("Your Password has been set successfully");
                    this.Visible = false;
                    new Form1().Visible = true;
                }
                else
                {
                    MessageBox.Show("Error occured while setting password");
                }
            }
            else
            {
                MessageBox.Show
                    ("Error Occured! Password didn't matched or maybe you've used " +
                    "SPACES in password character. Make sure that you've inputted same " +
                    "passwords in both Text Boxes");
            }

            ClearFields();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearFields()
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void SetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseStuff();
        }
    }
}