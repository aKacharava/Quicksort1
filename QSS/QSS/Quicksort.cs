using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSS
{
    public partial class Quicksort : Form
    {
        //Global variables
        int min = 0, max = 10, amount = 10;

        public Quicksort()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            lstNumbers.Items.Clear();
            //Fill the listbox with numbers while the listbox items count is lower than the amount
            while (lstNumbers.Items.Count < amount)
            {
                int Getal = random.Next(min, max + 1);
                lstNumbers.Items.Add(Getal);
            }
        }

        private void btnQuicksort_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[lstNumbers.Items.Count];
            
            //Add all the numbers from the listbox to the array
            for (int i = 0; i < lstNumbers.Items.Count; i++)
            {
                numbers[i] = int.Parse(lstNumbers.Items[i].ToString());
            }

            //int[] numbers = { 6, 5, 8, 9, 3, 1, 2, 8, 3, 0 }; 
            int[] sorted_array = qSort.quicksort(numbers);
            lstNumbers.Items.Clear();

            for (int i = 0; i < sorted_array.Length; i++)
            {
                lstNumbers.Items.Add(sorted_array[i]);
            }
        }

        private void txbMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                min = int.Parse(txbMin.Text);
                errorProvider1.SetError(txbMin, "");
            }
            catch (Exception error)
            {
                errorProvider1.SetError(txbMin, error.Message);
            }
        }

        private void txbMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                max = int.Parse(txbMax.Text);
                errorProvider1.SetError(txbMax, "");
            }
            catch (Exception error)
            {
                errorProvider1.SetError(txbMax, error.Message);
            }
        }

        private void txbAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(txbAmount.Text);
                errorProvider1.SetError(txbAmount, "");
            }
            catch (Exception error)
            {
                errorProvider1.SetError(txbAmount, error.Message);
            }
        }
    }
}
