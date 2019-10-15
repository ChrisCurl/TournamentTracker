using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeLabel_Click(object sender, EventArgs e)
        {

        }

        private bool validateForm()
        {
            bool output = true;

            int placeNumber = 0;

            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameValue.TextLength == 0)
            {
                output = false;
            }

            double prizeAmount = 0;
            int prizePercentage = 0;
            bool prizeAmountValid = double.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizeAmountValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0 )
            {
                output = false;
            }


            return output;
        }
    }
}
