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
    public partial class donuts : Form
    {
        public donuts()
        {
            InitializeComponent();
        }

        private void back_dash2_Click(object sender, EventArgs e)
        {
            placeorder p1 = new placeorder();
            p1.Show();
            Hide();
        }

        private void comboitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboitems.SelectedItem.ToString() == "CUSTARD STUFFED DONUT")
            {
                textprice.Text = "50";
            }
            else if (comboitems.SelectedItem.ToString() == "CINAMOM SUGAR DONUT")
            {
                textprice.Text = "50";
            }
            else if (comboitems.SelectedItem.ToString() == "CLASSIC GLAZED DONUT")
            {
                textprice.Text = "50";
            }
            else if (comboitems.SelectedItem.ToString() == "CLASSIC GLAZED TWISTED DONUT")
            {
                textprice.Text = "55";
            }
            else if (comboitems.SelectedItem.ToString() == "CINAMON SUGAR TWISTED DONUT")
            {
                textprice.Text = "55";
            }
            else if (comboitems.SelectedItem.ToString() == "STRAWBERRY SHORTCAKE DONUT")
            {
                textprice.Text = "55";
            }
            else if (comboitems.SelectedItem.ToString() == "NUTELLA STUFFED DONUT")
            {
                textprice.Text = "70";
            }
            else if (comboitems.SelectedItem.ToString() == "FERRERO ROCHER DONUT")
            {
                textprice.Text = "75";
            }
            else if (comboitems.SelectedItem.ToString() == "KINDER BUENO DONUT")
            {
                textprice.Text = "75";
            }
            else if (comboitems.SelectedItem.ToString() == "PISTACHEO STUFFED DONUT")
            {
                textprice.Text = "75";
            }
            else
            {
                textprice.Text = "0";
            }



            textTotal.Text = "";
            textQty.Text = "";
        }

        private void textQty_TextChanged(object sender, EventArgs e)
        {
            if (textQty.Text.Length > 0)
            {
                textTotal.Text = (Convert.ToInt16(textprice.Text) * Convert.ToInt16(textQty.Text)).ToString();
            }

        }

        private void orderamountlabel1_Click(object sender, EventArgs e)
        {
            orderamount oa = new orderamount();
            oa.Show();
            Hide();
        }
    }
}
