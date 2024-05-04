using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donuts_shop
{
    public partial class login : Form
    {
        string name = "donuts factory";
        string pass = "12345";
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if ((user_name.Text == name) && (user_pass.Text == pass))
            {
                placeorder p1 = new placeorder();
                p1.Show();
                Hide();
            }
            else
            {
                string message = "invalid password or username";
                MessageBox.Show(message);
            }
        }
    }
}
