using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4_Volodymyr_Alt
{
    class Party
    {

        //introducing some useful private vars and arrays
        private double costPerPers;
        private string[] guestList;

        public Party (int maxNumberOfGuests)
        {
            guestList = new string[maxNumberOfGuests];
        }

        public double CostPerPerson //defines a property for this class
        {
            get { return costPerPers; } //sends the value from costPerPers
            set
            {
                if (value >= 0)
                    costPerPers = value; //sets the  costPerPers equal to value
            }
        }

        private int GuestNumber() //calculating the guest numbers
        {
            int guestNum = 0; //declaring a variable

            for (int index = 0; index < guestList.Length; index++)
            {
                if(!string.IsNullOrEmpty(guestList[index])) //loops trhough the entire array and finds all non-empty values. Essentially, it counts the number of guests
                {
                    guestNum++;
                }
            }
            return guestNum;
        }

        private int FindVacantSlot() //looks for an avaliable slot inside the array
        {
            int emptySlotId = -1; //in case there is no avaliable slot, the program will do nothing

            for (int index = 0; index < guestList.Length; index++)
            {
                if(string.IsNullOrEmpty (guestList[index]))
                {
                    emptySlotId = index;
                    break;
                }

            }

            return emptySlotId;
        }

        public bool AddNewGuest(string firstName, string lastName) //method for adding some new guests
        {
            bool success = true;
            int emptySlotId = FindVacantSlot(); //takes the position of the empty slot from FindVacantSlot() 

            if (emptySlotId != -1) //if an empty slot is found, the program writes the names in
            {
                guestList[emptySlotId] = FullName(firstName, lastName);
            }

            return success;
        }

        private string FullName(string firstName, string lastName) // formats the name, so it is displayed distinctively (eg. uppercase last name)
        {
            return lastName.ToUpper() + ", " + firstName;
        }

        public bool ChangeEntry(int index, string firstName, string lastName) //method for editing the existing input
        {
            bool success = false; //assumes the program will not perform

            if (CheckIndex(index)) //see line 107
            {
                guestList[index] = FullName(firstName, lastName); //writes the names into the array
                success = true;
            }

            return success;
        }

        public bool DeleteEntry(int index) //method for editing the deleting input
        {
            bool success = false;

            if(CheckIndex(index)) //see line 107
            {
                guestList[index] = string.Empty; //empties an entry in an array
                ShiftArray(index); //shifts the elements of the array so that there are no gaps
                success = true;
            }

            return success;
        }

        public bool CheckIndex(int index) //checks that the array is not out of bounds
        {
            return (index >= 0) && (index < guestList.Length);
        }

        private void ShiftArray(int index) //shifts the elements of the array so that there are no gaps
        {
            for (int arrayIndex = index+1; arrayIndex < guestList.Length; arrayIndex++)
            {
                guestList[arrayIndex - 1] = guestList[arrayIndex];
                guestList[arrayIndex] = string.Empty;
            }
        }

        public double TotalCost() //calculates the total cost
        {
            int guestNum = GuestNumber();

            double totalCost = guestNum * costPerPers;

            return totalCost;
        }

        public string[] GetGuests() //array that is used to get the guests
        {
            int size = GuestNumber(); //sets the size of the array
            string[] guests = new string[size]; //creates a local array

            if (size <= 0)
            {
                return null; //returns empty value if the size is invalid
            }

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i]; //adjust the size according the specified length
                }
            }

            return guests;
        }

        public int GuestCount
        {
            get { return GuestNumber(); } //a getter for guest count
        }

    }
}
