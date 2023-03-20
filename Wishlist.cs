using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void wishList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wishList2.Items.Add("iPhone 14 Pro Max Full Paid");
            wishList2.Items.Add("House n Lot");
            wishList2.Items.Add("Burger");
            wishList2.Items.Add("RC");
            wishList2.Items.Add("Crackers");
        }

        private void closeButtonBox_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void countButton1_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishList2.Items.Count);
        }

        private void countText_Click(object sender, EventArgs e)
        {

        }

        private void sortButtonBox_Click(object sender, EventArgs e)
        {
            wishList2.Sorted = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wishList2.Items.Clear();
        }

        private void selectionOutputBox_TextChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishList2.Text;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
