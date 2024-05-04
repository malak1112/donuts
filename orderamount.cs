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
    public partial class orderamount : Form
    {
        public orderamount()
        {
            InitializeComponent();
        }

        private void back_dash2_Click(object sender, EventArgs e)
        {
            placeorder p1 = new placeorder();
            p1.Show();
            Hide();

        }
    }
}
