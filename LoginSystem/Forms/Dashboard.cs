using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem.Forms {
    public partial class Dashboard : Form {
        public Dashboard(string username) {
            InitializeComponent();
            this.username_label.Text = username;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Visible = false;
            new Form1().Visible = true;
        }
    }
}
