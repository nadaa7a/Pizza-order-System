using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            pnSize.BackColor = Color.Transparent;
            pnCrustType.BackColor = Color.Transparent;
            pnToppings.BackColor = Color.Transparent;
            pnWhereToEat.BackColor = Color.Transparent;

            lbSize.BackColor = Color.Transparent;
            lbCrustType.BackColor = Color.Transparent;
            lbToppings.BackColor = Color.Transparent;
            lbWhereToEat.BackColor = Color.Transparent;
            lbOrderSummary.BackColor = Color.Transparent;
            slbSize.BackColor = Color.Transparent;
            slbToppings.BackColor = Color.Transparent;
            slbCrustType.BackColor = Color.Transparent;
            slbWhereToEat.BackColor = Color.Transparent;
            lbTotalPrice.BackColor = Color.Transparent;
            lbPrice.BackColor = Color.Transparent;
        }

        private void UpdateOrderSummary()
        {
            // Size :
            if (rbSmall.Checked)
                slbSize.Text = "Size : Small";
            else if (rbMedium.Checked)
                slbSize.Text = "Size : Medium";
            else if (rbLarg.Checked)
                slbSize.Text = "Size : Larg";

            // Crust Type : 
            if (rbThinCrust.Checked)
                slbCrustType.Text = "Crust Type : Thin";
            else if (rbThinkCrust.Checked)
                slbCrustType.Text = "Crust Type : Think";

            // Where To Eat :
            if (rbEatIn.Checked)
                slbWhereToEat.Text = "Where To Eat : Eat In";
            else if (rbTakeOut.Checked)
                slbWhereToEat.Text = "Where To Eat : Take Out";
        }

        private void UpdateToppings()
        {
            string Toppings = "";

            if (chbExtraChees.Checked)
                Toppings += "Extra Chees. \n";

            if (chbMushrooms.Checked)
                Toppings += "Mushrooms. \n";

            if (chbTomatoes.Checked)
                Toppings += "Tomatoes. \n";

            if (chbOnion.Checked)
                Toppings += "Onion. \n";

            if (chbOlives.Checked)
                Toppings += "Olives. \n";

            if (chbGreenPapers.Checked)
                Toppings += "Green Papers. \n";

            if (Toppings == "") 
            {
                slbToppings.Text = "Toppings : No Toppings.";
            }
            else
            {
                slbToppings.Text = "Toppings : \n" + Toppings;
            }
        }

        private void CalculateTotalPrice()
        {
            int Price = 0;

            // Size : 
            if (rbSmall.Checked)
                Price += Convert.ToInt32(rbSmall.Tag);
            else if (rbMedium.Checked)
                Price += Convert.ToInt32(rbMedium.Tag);
            else if (rbLarg.Checked)
                Price += Convert.ToInt32(rbLarg.Tag);

            // Crust Type : 
            if (rbThinCrust.Checked)
                Price += Convert.ToInt32(rbThinCrust.Tag);
            else if (rbThinkCrust.Checked)
                Price += Convert.ToInt32(rbThinkCrust.Tag);

            // Toppings : 
            if (chbExtraChees.Checked)
                Price += Convert.ToInt32(chbExtraChees.Tag);

            if (chbMushrooms.Checked)
                Price += Convert.ToInt32(chbMushrooms.Tag);

            if (chbTomatoes.Checked)
                Price += Convert.ToInt32(chbTomatoes.Tag);

            if (chbOnion.Checked)
                Price += Convert.ToInt32(chbOnion.Tag);

            if (chbOlives.Checked)
                Price += Convert.ToInt32(chbOlives.Tag);

            if (chbGreenPapers.Checked)
                Price += Convert.ToInt32(chbGreenPapers.Tag);

            lbPrice.Text = "$" + Price.ToString();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            CalculateTotalPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            CalculateTotalPrice();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            CalculateTotalPrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            CalculateTotalPrice();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            CalculateTotalPrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void chbGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Confirm Order !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                btnResetForm.Enabled = true;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = true;
            }

            rbSmall.Enabled = true;

            chbOlives.Checked = false;
            chbGreenPapers.Checked = false;
            chbOnion.Checked = false;
            chbMushrooms.Checked = false;

            CalculateTotalPrice();
        }
    }
}
