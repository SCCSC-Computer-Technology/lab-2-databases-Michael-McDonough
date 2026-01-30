using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Michael McDonough Lab 2
 * City population
 * CPT 206 A80H
 * 1-29-2026
 */

namespace MMcDonough_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

            //formats the pop collumn to be more human readable 
            dgvCity.Columns["populationDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //i wish this button could send me to sleep lol
            // the program was not exiting with this.Close(), app exit works 
            Application.Exit();
        }

        //Buttons are bound to to sql queries, see CityDBDataSet.xsd too see the queries in detail
        private void btnPopASC_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopulationASC(this.cityDBDataSet.City);
        }

        private void btnPopDESC_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopulationDESC(this.cityDBDataSet.City);
        }

        private void btnNameZA_Click(object sender, EventArgs e)
        {
            
            cityTableAdapter.FillByCityNameDESC(this.cityDBDataSet.City);
        }

        private void btnNameAZ_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByCityNameASC(this.cityDBDataSet.City);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            cityBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cityDBDataSet);
        }

        private void btnClacStat_Click(object sender, EventArgs e)
        {
            tBTotal.Text = cityTableAdapter.SUMPop().ToString();

            tBAvg.Text = cityTableAdapter.AveragePop().ToString();

            tBHigh.Text = cityTableAdapter.HighestPop().ToString();

            tBLow.Text = cityTableAdapter.LowestPop().ToString();
        }



        private void btnCitySave_Click(object sender, EventArgs e)
        {
            //checck for null
            if (cityBindingSource.Current == null)
            {
                MessageBox.Show("Warning: Missing information, failed add city");
                btnCitySave.Visible = false;
                btnCityNew.Visible = true;
                return;
            }

            //trim the textbox data to keep the database clean
            cityTextBox.Text = cityTextBox.Text.Trim();
            stateTextBox.Text = stateTextBox.Text.Trim();
            populationTextBox.Text = populationTextBox.Text.Trim();

            //validate the input for correct datatype and nulls
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show("Enter a valid city name");
                return;
            }

            if (string.IsNullOrEmpty(stateTextBox.Text))
            {
                MessageBox.Show("Enter a valid State name");
                return;
            }

            int population;

            //checks if the population is actually a number at all
            bool isint = int.TryParse(populationTextBox.Text, out population);

            if (isint == false)
            {
                MessageBox.Show("Population must be a whole number");
                return;
            }

            if (population < 0)
            {
                MessageBox.Show("Population cannot be negative");
                return;
            }

            //reload the population with the clean number to make extra sure its right
            populationTextBox.Text = population.ToString();

            try
            {
                Validate();
                cityBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(cityDBDataSet);
                btnCitySave.Visible = false;
                btnCityNew.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cityTableAdapter.Fill(cityDBDataSet.City);
                btnCitySave.Visible = false;
                btnCityNew.Visible = true;
            }

           

        }

        private void btnCityNew_Click(object sender, EventArgs e)
        {
           
            cityBindingSource.AddNew();
            btnCitySave.Visible = true;
            btnCityNew.Visible = false;
            btnCancel.Visible = true;
            btnDelete.Visible = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cityBindingSource.CancelEdit();
            //cityBindingSource.EndEdit();
            cityTableAdapter.Fill(cityDBDataSet.City);
            btnCancel.Visible = false;
            btnDelete.Visible = true;
            btnCitySave.Visible = false;
            btnCityNew.Visible = true;


        }

        //deletes selected city row
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //the null checking is exausting and by design of the UI it should never be a problem, someone would find a way to break it if i didnt check
            if (cityBindingSource.Current == null)
            {
                MessageBox.Show("Please select a city to delete");
                return;
            }

            var cityRow = cityBindingSource.Current as DataRowView;

            string cityName = cityRow["City"].ToString();

            var delete = MessageBox.Show("Warning: This will delete " + cityName + "\n Do you wish to continue?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (delete == DialogResult.Yes)
            {
                try
                {
                    cityBindingSource.RemoveCurrent();
                    Validate();
                    cityBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(cityDBDataSet);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cityTableAdapter.Fill(cityDBDataSet.City);
                }
            }
            else
            {
                
                return;
            }
        }

        //edits the selected city row
        //this was 7 lines before making it not crash now its like 50
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //checck for null
            if (cityBindingSource.Current == null)
            {
                MessageBox.Show("Warning: A city must be selected! \n please make a selection by clicking on the row of or by navigating with the arrows at the top of the table to the city to be edited");
                return;
            }
            
            //trim the textbox data to keep the database clean
            cityTextBox.Text = cityTextBox.Text.Trim();
            stateTextBox.Text = stateTextBox.Text.Trim();
            populationTextBox.Text = populationTextBox.Text.Trim();

            //validate the input for correct datatype and nulls
            if(string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show("Enter a valid city name");
                return;
            }

            if (string.IsNullOrEmpty(stateTextBox.Text))
            {
                MessageBox.Show("Enter a valid State name");
                return;
            }

            int population;

            //checks if the population is actually a number at all
            bool isint = int.TryParse(populationTextBox.Text, out population);

            if (isint == false)
            {
                MessageBox.Show("Population must be a whole number");
                return;
            }

            if (population < 0)
            {
                MessageBox.Show("Population cannot be negative");
                return;
            }

            //reload the population with the clean number to make extra sure its right
            populationTextBox.Text = population.ToString();

            try
            {
                Validate();
                cityBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(cityDBDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cityTableAdapter.Fill(cityDBDataSet.City);
            }

        }


    }
    
}
