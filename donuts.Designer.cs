namespace donuts_shop
{
    partial class donuts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donuts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_dash2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboitems = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.orderamountlabel1 = new System.Windows.Forms.Label();
            this.addorder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.back_dash2);
            this.panel1.Location = new System.Drawing.Point(18, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 530);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // back_dash2
            // 
            this.back_dash2.AutoSize = true;
            this.back_dash2.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_dash2.Location = new System.Drawing.Point(32, 490);
            this.back_dash2.Name = "back_dash2";
            this.back_dash2.Size = new System.Drawing.Size(39, 17);
            this.back_dash2.TabIndex = 0;
            this.back_dash2.Text = "Back";
            this.back_dash2.Click += new System.EventHandler(this.back_dash2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textTotal);
            this.panel2.Controls.Add(this.textQty);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textprice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboitems);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.orderamountlabel1);
            this.panel2.Controls.Add(this.addorder);
            this.panel2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(145, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 530);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qty";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(399, 196);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 33);
            this.textTotal.TabIndex = 10;
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(219, 196);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(100, 33);
            this.textQty.TabIndex = 9;
            this.textQty.TextChanged += new System.EventHandler(this.textQty_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(30, 196);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 33);
            this.textprice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "select item";
            // 
            // comboitems
            // 
            this.comboitems.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboitems.FormattingEnabled = true;
            this.comboitems.Items.AddRange(new object[] {
            "CUSTARD STUFFED DONUT",
            "CINAMOM SUGAR DONUT",
            "CLASSIC GLAZED DONUT",
            "CLASSIC GLAZED TWISTED DONUT",
            "CINAMON SUGAR TWISTED DONUT",
            "STRAWBERRY SHORTCAKE DONUT",
            "NUTELLA STUFFED DONUT",
            "FERRERO ROCHER DONUT",
            "KINDER BUENO DONUT",
            "PISTACHEO STUFFED DONUT"});
            this.comboitems.Location = new System.Drawing.Point(30, 83);
            this.comboitems.Name = "comboitems";
            this.comboitems.Size = new System.Drawing.Size(475, 36);
            this.comboitems.TabIndex = 5;
            this.comboitems.SelectedIndexChanged += new System.EventHandler(this.comboitems_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(546, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 524);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // orderamountlabel1
            // 
            this.orderamountlabel1.AutoSize = true;
            this.orderamountlabel1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderamountlabel1.Location = new System.Drawing.Point(189, 393);
            this.orderamountlabel1.Name = "orderamountlabel1";
            this.orderamountlabel1.Size = new System.Drawing.Size(157, 34);
            this.orderamountlabel1.TabIndex = 3;
            this.orderamountlabel1.Text = "order amount";
            this.orderamountlabel1.Click += new System.EventHandler(this.orderamountlabel1_Click);
            // 
            // addorder
            // 
            this.addorder.Location = new System.Drawing.Point(172, 265);
            this.addorder.Name = "addorder";
            this.addorder.Size = new System.Drawing.Size(186, 52);
            this.addorder.TabIndex = 1;
            this.addorder.Text = "Add to order";
            this.addorder.UseVisualStyleBackColor = true;
            // 
            // donuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "donuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "donuts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back_dash2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboitems;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label orderamountlabel1;
        private System.Windows.Forms.Button addorder;
    }
}