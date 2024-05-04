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
    public partial class placeorder : Form
    {
        public placeorder()
        {
            InitializeComponent();
        }

        private void logout_dash_Click(object sender, EventArgs e)
        {
            login f1 = new login();
            f1.Show();
            Hide();
        }

        private void Shareboxbutton_Click(object sender, EventArgs e)
        {
            shareboxes s1 = new shareboxes();
            s1.Show();
            Hide();
        }

        private void Donutsbutton_Click(object sender, EventArgs e)
        {
            donuts d1 = new donuts();
            d1.Show();
            Hide();
        }
    }
}
