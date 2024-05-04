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
    public partial class shareboxes : Form
    {
        public shareboxes()
        {
            InitializeComponent();
        }

        private void back_dash_Click(object sender, EventArgs e)
        {
            placeorder p1 = new placeorder();
            p1.Show();
            Hide();
        }

        private void comboitems2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboitems2.SelectedItem.ToString() == "16")
            {
                textprice2.Text = "375";
            }
            else if (comboitems2.SelectedItem.ToString() == "20")
            {
                textprice2.Text = "450";
            }
            else if (comboitems2.SelectedItem.ToString() == "32")
            {
                textprice2.Text = "650";
            }
            else
            {
                textprice2.Text = "0";
            }


            textTotal2.Text = "";
            textQty2.Text = "";

        }

        private void textQty2_TextChanged(object sender, EventArgs e)
        {
            if (textQty2.Text.Length > 0)
            {
                textTotal2.Text = (Convert.ToInt16(textprice2.Text) * Convert.ToInt16(textQty2.Text)).ToString();
            }
        }

        private void orderamountlabel2_Click(object sender, EventArgs e)
        {
            orderamount oa = new orderamount();
            oa.Show();
            Hide();
        }
    }
}
