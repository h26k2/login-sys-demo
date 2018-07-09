using System;
using System.Windows.Forms;

namespace LoginSystem.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username)
        {
            InitializeComponent();
            username_label.Text = username;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Form1().Visible = true;
        }
    }
}