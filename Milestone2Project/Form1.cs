using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLClasses;

namespace Milestone2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            // Closes the application
            this.Close();
        }

        private void bttnResults_Click(object sender, EventArgs e)
        {
            if (rdoBttnDeepFryer.Checked)
            {
                // Gets all the info from the class
                DeepFryer newDeepFryer = new DeepFryer(cbxColor.SelectedItem.ToString(), txtBoxMaterial.Text, cbxBrand.SelectedItem.ToString(),
                    int.Parse(txtBoxMaxTemp.Text), cbxFuleType.SelectedItem.ToString(), int.Parse(txtBoxInventory.Text), int.Parse(txtBoxFirstInput.Text), 
                    int.Parse(txtBoxSecondInput.Text));

                // Changes the text of the label
                lblResults.Text = string.Format("Brand and Material: {0}, {1}\nMax Cooking Temp: {2} degrees\nColor: {3}\nTotal Inventory: {4}", newDeepFryer.brand, 
                    newDeepFryer.material, newDeepFryer.maxTemp, newDeepFryer.color, newDeepFryer.CalInvenotry());

                // Makes one button and two labels visible again
                bttnClose.Visible = true;
                lblEndResults.Visible = true;
                lblResults.Visible = true;
                // Makes one button invisible 
                bttnResults.Visible = false;
            } 
            else if (rdoBttnGasGrill.Checked)
            {
                // Gets all the info from the class
                GasGrill newGasGrill = new GasGrill(cbxColor.SelectedItem.ToString(), txtBoxMaterial.Text, cbxBrand.SelectedItem.ToString(),
                    int.Parse(txtBoxMaxTemp.Text), cbxFuleType.SelectedItem.ToString(), int.Parse(txtBoxInventory.Text), int.Parse(txtBoxFirstInput.Text),
                    txtBoxSecondInput.Text);

                // Changes the text of the label
                lblResults.Text = string.Format("Brand and Material: {0}, {1}\nMax Cooking Temp: {2} degrees\nColor: {3}\nTotal Inventory: {4}", newGasGrill.brand,
                    newGasGrill.material, newGasGrill.maxTemp, newGasGrill.color, newGasGrill.CalInvenotry());

                // Makes one button and two labels visible again
                bttnClose.Visible = true;
                lblEndResults.Visible = true;
                lblResults.Visible = true;
                // Makes one button invisible 
                bttnResults.Visible = false;
            }
            else if (rdoBttnPatioStove.Checked)
            {
                // Gets all the info from the class
                PatioStove newPatioStove = new PatioStove(cbxColor.SelectedItem.ToString(), txtBoxMaterial.Text, cbxBrand.SelectedItem.ToString(),
                    int.Parse(txtBoxMaxTemp.Text), cbxFuleType.SelectedItem.ToString(), int.Parse(txtBoxInventory.Text), int.Parse(txtBoxFirstInput.Text),
                    txtBoxSecondInput.Text);

                // Changes the text of the label
                lblResults.Text = string.Format("Brand and Material: {0}, {1}\nMax Cooking Temp: {2} degrees\nColor: {3}\nTotal Inventory: {4}", newPatioStove.brand,
                    newPatioStove.material, newPatioStove.maxTemp, newPatioStove.color, newPatioStove.CalInvenotry());

                // Makes one button and two labels visible again
                bttnClose.Visible = true;
                lblEndResults.Visible = true;
                lblResults.Visible = true;
                // Makes one button invisible 
                bttnResults.Visible = false;
            }
            else
            {
                // Gets all the info from the class
                Smoker newSmoker = new Smoker(cbxColor.SelectedItem.ToString(), txtBoxMaterial.Text, cbxBrand.SelectedItem.ToString(),
                    int.Parse(txtBoxMaxTemp.Text), cbxFuleType.SelectedItem.ToString(), int.Parse(txtBoxInventory.Text), txtBoxSecondInput.Text);

                // Changes the text of the label
                lblResults.Text = string.Format("Brand and Material: {0}, {1}\nMax Cooking Temp: {2} degrees\nColor: {3}\nTotal Inventory: {4}", newSmoker.brand,
                    newSmoker.material, newSmoker.maxTemp, newSmoker.color, newSmoker.CalInvenotry());

                // Makes one button and two labels visible again
                bttnClose.Visible = true;
                lblEndResults.Visible = true;
                lblResults.Visible = true;
                // Makes one button invisible 
                bttnResults.Visible = false;
                // Makes a label and a txtBox invisible
                lblSecondInput.Visible = false;
                txtBoxSecondInput.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Makes the return button invisible 
            bttnResults.Visible = false;
            // Makes the close button invisible
            bttnClose.Visible = false;
            // Makes the two labels/txtBoxes invisibe
            lblFirstInput.Visible = false;
            lblSecondInput.Visible = false;
            txtBoxFirstInput.Visible = false;
            txtBoxSecondInput.Visible = false;
            // Makes two more lables invisible
            lblResults.Visible = false;
            lblEndResults.Visible = false;
        }

        private void bttnContinue_Click(object sender, EventArgs e)
        {
            if (rdoBttnDeepFryer.Checked)
            {
                // Changes the text of two of the labels 
                lblFirstInput.Text = "Number of Fryer Tanks";
                lblSecondInput.Text = "Max Holdable Gallons";

                // Makes all other radio buttons invisible
                rdoBttnGasGrill.Visible = false;
                rdoBttnPatioStove.Visible = false;
                rdoBttnSmoker.Visible = false;

                // Makes the labels/txtBoxes visible again 
                lblFirstInput.Visible = true;
                lblSecondInput.Visible = true;
                txtBoxFirstInput.Visible = true;
                txtBoxSecondInput.Visible = true;
                // Makes one button visible again and one other button invisible
                bttnResults.Visible = true;
                bttnContinue.Visible = false;
            }
            else if (rdoBttnGasGrill.Checked)
            {
                // Changes the text of the two labels 
                lblFirstInput.Text = "Start up time in minutes";
                lblSecondInput.Text = "Temp Control Knobs (Y/N)";

                // Makes all other radio buttons invisible
                rdoBttnDeepFryer.Visible = false;
                rdoBttnPatioStove.Visible = false;
                rdoBttnSmoker.Visible = false;

                // Makes the labels/txtBoxes visible again 
                lblFirstInput.Visible = true;
                lblSecondInput.Visible = true;
                txtBoxFirstInput.Visible = true;
                txtBoxSecondInput.Visible = true;
                // Makes one button visible again and one other button invisible
                bttnResults.Visible = true;
                bttnContinue.Visible = false;
            }
            else if (rdoBttnPatioStove.Checked)
            {
                // Changes the text of the two labels
                lblFirstInput.Text = "Total amount of burners";
                lblSecondInput.Text = "Hose Guard Present (Y/N)";

                // Makes all other radio buttons invisible
                rdoBttnGasGrill.Visible = false;
                rdoBttnDeepFryer.Visible = false;
                rdoBttnSmoker.Visible = false;

                // Makes the labels/txtBoxes visible again 
                lblFirstInput.Visible = true;
                lblSecondInput.Visible = true;
                txtBoxFirstInput.Visible = true;
                txtBoxSecondInput.Visible = true;
                // Makes one button visible again and one other button invisible
                bttnResults.Visible = true;
                bttnContinue.Visible = false;
            }
            else
            {
                // Changes the text of the label and makes the other one invisible 
                lblFirstInput.Text = "Hangers Present (Y/N)";
                lblSecondInput.Visible = false;
                txtBoxSecondInput.Visible = false;

                // Makes all other radio buttons invisible
                rdoBttnGasGrill.Visible = false;
                rdoBttnPatioStove.Visible = false;
                rdoBttnDeepFryer.Visible = false;

                // Makes the labels/txtBoxes visible again 
                lblFirstInput.Visible = true;
                txtBoxFirstInput.Visible = true;
                // Makes one button visible again and one other button invisible
                bttnResults.Visible = true;
                bttnContinue.Visible = false;
            }
        }
    }
}
