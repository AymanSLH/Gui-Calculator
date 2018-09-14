using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_V1
{
    public partial class Form1 : Form
    {
        double total1 = 0;
        bool plusButtonClicked = false; 
        bool minusButtonClicked = false;
        bool multiButtonClicked = false; 
        bool divdButtonClicked = false; 

        



        public Form1()
        {
            InitializeComponent();
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text; 

        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear(); 
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Holder.Text = txtDisplay.Text + "+";
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            multiButtonClicked = false;
            divdButtonClicked = false; 

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Holder.Text = txtDisplay.Text + "-";
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = true;
            divdButtonClicked = false;
            multiButtonClicked = false;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Holder.Text = txtDisplay.Text + "×";
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            bool plusButtonClicked = false;
            bool minusButtonClicked = false;
            bool multiButtonClicked = true;
            bool divdButtonClicked = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Holder.Text = txtDisplay.Text + "÷";
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            bool plusButtonClicked = false;
            bool minusButtonClicked = false;
            bool multiButtonClicked = false;
            bool divdButtonClicked = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked)
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked)
            {
                total1 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (divdButtonClicked)
            {
                total1 = total1 / double.Parse(txtDisplay.Text);
            }
            else if (multiButtonClicked)
            {
                total1 = total1 * double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total1.ToString();
            total1 = 0;
        }
    }
}
