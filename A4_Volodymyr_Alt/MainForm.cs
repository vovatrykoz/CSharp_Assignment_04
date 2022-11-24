using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_Volodymyr_Alt
{
    public partial class MainForm : Form
    {
        Party party; //creates an instance of a party class

        public MainForm() //initalizes the form and the interface
        {
            InitializeComponent();
            InitGUI();
        }

        private void InitGUI() //cleareing all the space used for the output
        {
            txtFrstName.Text = string.Empty;
            txtLstName.Text = string.Empty;

            lblGuestNum.Text = string.Empty;
            lblTotalCost.Text = string.Empty;
            lstGuestList.Items.Clear();

            grpInviteGuests.Enabled = false;
        }

        private bool CreateList() //class responsible for creating a guest list and recording of the operation has been performed successfully
        {

            //local variables
            int maxNumber;
            bool success;

            //checks that the input for the guest number is valid
            if (int.TryParse (txtGuestNum.Text, out maxNumber) && (maxNumber > 0))
            {
                party = new Party(maxNumber); //if the conditions hold up the party will be assigned a value
                MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success"); //informs the user that the operation has been performed successfully
                success = true;
            }
            else //if the values are not correct, a message box will appear, and the variable will return false
            {
                MessageBox.Show("Invalid guest number. Please, try again!", "Error");
                success = false;
            }

            return success;
        }

        private bool ReadCostPerPerson()
        {

            double value;
            bool success;

            //checks the cost values for validity
            success = double.TryParse(txtCostPerPers.Text, out value) && (value >= 0);

            if (success)
            {
                party.CostPerPerson = value; //if the values are correct it sends the values into the CostPerPerson property
                success = true;
            }
            else
            {
                MessageBox.Show("Invalid amount. Please, try again!"); //displays an error message and returns false if the values were incorrect
                success = false;
            }

            return success;
        }

        //updates the user interface

        private void UpdateGUI()
        {
            lstGuestList.Items.Clear(); //clears out the listbox
            string[] guestList = party.GetGuests(); //creates a local string array for the guest list and takes the values for it from the GetGuests array in Party.cs

            double netCost = party.TotalCost(); //local variable for storing the result of the Total Cost calculation in Party.cs

            if (guestList != null) //checks that the values are not empty
            {
                for (int index = 0; index < guestList.Length; index++) //loops through the entire guestList array
                {
                    string value = $"{ index + 1,4} {guestList[index],-20}"; //defines the string format by describing how different values will have different formats and adjust how much space they take up
                    lstGuestList.Items.Add(value); //adds the adjusted values into the listBox
                }
            }
            else
            {
                return; //stops the execution if the values are empty
            }


            lblTotalCost.Text = netCost.ToString("0.00"); //displays a rounded up value of the total cost
            lblGuestNum.Text = party.GuestCount.ToString(); //displays the number of guests
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            bool guestCountSuccess = CreateList(); //checks if the guest list has been created successfully
            if(guestCountSuccess)
            {
                bool costSuccess = ReadCostPerPerson(); //checks if the costs have been recorded successfully

                if (!guestCountSuccess || !costSuccess) //stops the execution if the costs have not been recorded successfully
                {
                    return;
                }

                if (guestCountSuccess && costSuccess) //if both of the previous variables return true (meaning the values are recorded successfully) user interface is updated with new values
                {
                    UpdateGUI();
                    grpInviteGuests.Enabled = true;
                }
            }
        }

        private bool ValidateText(string text1, string text2) //checks the text input for validity
        {
            text1 = text1.Trim(); //trims the text recieved when this variable is applied
            text2 = text2.Trim(); //trims the text recieved when this variable is applied


            if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2)) //checks if the text is empty
            {
                return true;
            }
            else //returns false if the text is empty
            {
                MessageBox.Show("Please, provide both first and second names!", "Error");
                return false;
            }
        }

        private bool TrimNames() //trims the text values received
        {
            if (ValidateText(txtFrstName.Text, txtLstName.Text)) //checks the text for validity
            {
                txtFrstName.Text = txtFrstName.Text.Trim(); //trims the string text
                txtLstName.Text = txtLstName.Text.Trim();
                return true; //certifies that the operation was successfull
            }
            else
            {
                return false; //says that the operation failed
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TrimNames()) //starts after the names have been trimmed
            {
                bool success = party.AddNewGuest(txtFrstName.Text, txtLstName.Text); //checks if the values for the new guest are valid

                if (success)
                {
                    UpdateGUI(); //updates the user interface if they are
                }
                else
                {
                    MessageBox.Show("Impossible to add new guests!", "Erorr"); //displays an error if they aren't
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemId = lstGuestList.SelectedIndex; //recieves the index of the selected listbox item

            if (lstGuestList.SelectedIndex < 0) //if no item is selected an error message will be displayed
            {
                MessageBox.Show("Select an item first!");
            }
            else //if an item has been selected, the value is saved in the index part
            {
                party.DeleteEntry(itemId); //deletes the enry for the selected item
                UpdateGUI(); //updates the user interface
            }


        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int itemId = lstGuestList.SelectedIndex; //recieves the index of the selected listbox item

            if (lstGuestList.SelectedIndex < 0) //if no item is selected an error message will be displayed
            {
                MessageBox.Show("Select an item first!");
            }
            else if(TrimNames()) //if an item has been selected, the value is saved in the index part
            {
                party.ChangeEntry(itemId, txtFrstName.Text, txtLstName.Text); //replaces the selected value
                UpdateGUI();
            }
        }
    }
}
