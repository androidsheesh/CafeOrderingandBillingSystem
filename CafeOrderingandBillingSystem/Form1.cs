using System.CodeDom;

namespace CafeOrderingandBillingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // namali rani double click, ignore
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            string orders = "";
            int totalbill = 0;


            // for food
            if (checkBoxBurger.Checked)
            {
                int qty = (int)numericUpDownBugrer.Value;
                if (qty > 0)
                {
                    int itemPrice = 85;
                    totalbill += itemPrice * qty;

                    orders += $"Burger x {qty} = {itemPrice * qty}\n";

                }
            }
            if (checkBoxChickenSandwich.Checked)
            {
                int qty = (int)numericUpDownChickenSandwich.Value;
                if (qty > 0)
                {
                    int itemPrice = 90;
                    totalbill += itemPrice * qty;

                    orders += $"Chicken Sandwich x {qty} = {itemPrice * qty}\n";
                }
            }
            if (checkBoxSpag.Checked)
            {
                int qty = (int)numericUpDownSpag.Value;
                if (qty > 0)
                {
                    int itemPrice = 100;
                    totalbill += itemPrice * qty;

                    orders += $"Spaghetti x {qty} = {itemPrice * qty}\n";
                }
            }
            if (checkBoxFrenchFries.Checked)
            {
                int qty = (int)numericUpDownFrenchFries.Value;
                if (qty > 0)
                {
                    int itemPrice = 50;
                    totalbill += itemPrice * qty;

                    orders += $"French Fries x {qty} = {itemPrice * qty}\n";
                }

            }

            // drinks
            if (checkBoxSoftdrink.Checked)
            {
                int qty = (int)numericUpDownSoftdrink.Value;
                if (qty > 0)
                {
                    int itemPrice = 30;
                    totalbill += itemPrice * qty;

                    orders += $"Softdrink x {qty} = {itemPrice * qty}\n";
                }
            }
            if (checkBoxIcedTea.Checked)
            {
                int qty = (int)numericUpDownIcedTea.Value;
                if (qty > 0)
                {
                    int itemPrice = 25;
                    totalbill += itemPrice * qty;

                    orders += $"Iced Tea x {qty} = {itemPrice * qty}\n";
                }
            }
            if (checkBoxCoffee.Checked)
            {
                int qty = (int)numericUpDownCoffee.Value;
                if (qty > 0)
                {
                    int itemPrice = 40;
                    totalbill += itemPrice * qty;

                    orders += $"Coffee x {qty} = {itemPrice * qty}\n";
                }
            }
            if (checkBoxBottledWater.Checked)
            {
                int qty = (int)numericUpDownBottledWater.Value;
                if (qty > 0)
                {
                    int itemPrice = 25;
                    totalbill += itemPrice * qty;

                    orders += $"Bottled Water x {qty} = {itemPrice * qty}\n";
                }
            }


            int input_money = int.Parse(txtBoxInputMoney.Text);
            if (input_money == 0)
            {
                if (input_money < totalbill)
                {
                    MessageBox.Show($"Insufficient funds. Please enter an amount greater than or equal to the total bill of {totalbill}.");
                    return;
                }
                else
                {

                    MessageBox.Show($"===============================\n SHAN'S CAFE \"\n===============================" +
                            $"\nYour Order:\n\n{orders}\n" +
                            $"===============================" +
                            $"\nSubtotal: {totalbill}" +
                            $"\nDiscount: 0" +
                            $"\n===============================" +
                            $"\nTOTAL: {totalbill}" +
                            $"\nPayment: {input_money}" +
                            $"\n===============================" +
                            $"\nChange: {input_money - totalbill}");
                }
            }
        }
    }
}

