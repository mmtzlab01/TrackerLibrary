using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class Create_Prize : Form
    {
        public Create_Prize()
        {
            InitializeComponent();
        }

        private void PlaceNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumberValue.Text,
                    PrizeamountValue.Text,
                    PrizePercentageValue.Text);

                Globalconfig.Connection.CreatePrize(model);
                ClearForm();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please try again.");
            }
        }

        private void ClearForm()
        {
            PlaceNameValue.Text = "";
            PlaceNumberValue.Text = "";
            PrizeamountValue.Text = "0";
            PrizePercentageValue.Text = "0";
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(PlaceNumberValue.Text, out placeNumber);
            if (!placeNumberValid)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeamountValid = decimal.TryParse(PrizeamountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeamountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }


            return output;
        }
    }
}
