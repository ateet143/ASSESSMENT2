using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
// Atit Singh/Satbir Singh,Team:CSharpPerth, Sprint 1
// Date: 21/09/2021
// Version:2
// AstronomicalProcessing
// This is a form-based application which displays the hours in a listbox, user can able to add, delete and search the data.
// program let the user to input the number and the numbers can be sorted,search, added , edit and deleted.

namespace AstronomicalProcessing
{
    //CR5: Name of the application should be Astronomical processing
    public partial class AstronomicalProcessing : Form
    {
        #region BUILTIN
        public AstronomicalProcessing()
        {
            InitializeComponent();
        }
        private void AstronomicalProcessing_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region DECLARING ARRAY, DISPLAY METHOD, FILL RANDOM NUMBERS

        //PR2:The array has 24 elements to reflect the number of hours per day.
        static int maxNumber = 24;
        //CR1/PR1: All data is stored as integers in an array.
        int[] hours = new int[maxNumber];
        int nextIndex = 0;

        private void DisplayNumber()  //Method to Displays all the numbers in the listbox
        {
            ListBoxHours.Items.Clear();
            for (int i = 0; i < nextIndex; i++)
            {
                ListBoxHours.Items.Add(hours[i]);
            }
        }
        private void ListBoxHours_Click(object sender, EventArgs e) //method to show the content from listbox to texbox
        {
            if (ListBoxHours.SelectedItem != null)
            {   //pasrsing the text value from texbox to integer
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current); //getting the position of number in list
                TextBoxHours.Text = hours[idx].ToString();  //displaying the number in textbox
            }
            else    //showing information to user to select the number from list
            {
                toolStripStatusLabel1.Text = "Select a number from the List";
            }

        }

        private void ButtonAutofill_Click(object sender, EventArgs e)
        {
            //FR:1 To display the random number from 10 to 99.
            nextIndex = 24;
            Random rand = new Random();
            for (int i = 0; i < nextIndex; i++)
            {
                int random = rand.Next(10, 100);
                //if the number already exist in array, it will substract -1 from i
                if (hours.Contains(random))
                {
                    i--;   // it is needed otherwise 0 is assigned in an array index

                }
                //if the number does not exist in array, it will assign the number in array
                else
                {
                    hours[i] = random;
                }
            }
            DisplayNumber();
        }
        #endregion

        #region ADD, MODIFY AND DELETE

        //CR4/PR: Input textbox so that user can add, edit and delete the data 
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //to show the error message if texbbox is empty or has null value
            if (!string.IsNullOrEmpty(TextBoxHours.Text))
            {
                try
                {
                    int number = int.Parse(TextBoxHours.Text);
                    if (!hours.Contains(number))
                    {
                        hours[nextIndex] = number;
                        nextIndex++;
                        DisplayNumber();
                        TextBoxClearFocus();
                    }
                    else
                    {
                        MessageBox.Show("Duplicate number, Enter different number!",
                         "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxClearFocus();
                    }

                }
                //it will show the error message if the input number is more than the array limit
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Input exceed the limit of 24 numbers",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxClearFocus();
                }
                // it will execute if the user input the invalid text, such as copy text and paste in textbox
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input,Enter numbers only",
                       "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxClearFocus();
                }

            }
            // PR6: The program must generate an error message if the text box is empty.
            else
            {
                MessageBox.Show("Blank space detected!Please input number in the Box.",
                    "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {

            if (ListBoxHours.SelectedIndex != -1)
            {
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current);
                if (!hours.Contains(int.Parse(TextBoxHours.Text)))
                {
                    DialogResult modifyTask = MessageBox.Show("Do you want to Continue?", "It will permanently modify the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (modifyTask == DialogResult.Yes)
                    {

                        int.TryParse(TextBoxHours.Text, out hours[idx]);
                        DisplayNumber();
                        TextBoxClearFocus();
                    }
                    else  //notifying user of cancelling to modify, happens if user choose to NO in dailogbox
                    {

                        toolStripStatusLabel1.Text = "User had cancelled to modify";

                    }
                }
                //if user does not select number from the  list 
                else  //trigger if duplicate number detected in the list
                {
                    toolStripStatusLabel1.Text = "Duplicate number, Enter different number!";
                    TextBoxHours.Focus();
                }


            }
            else   // if user does not select any numbers from the list
            {
                toolStripStatusLabel1.Text = "User need to select data from the list";
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxHours.SelectedIndex != -1)
            {
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current);
                DialogResult delTask = MessageBox.Show("Do you want to Continue?", "It will permanently Delete the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delTask == DialogResult.Yes)
                {
                    hours[idx] = hours[nextIndex - 1]; //deletes the number form the list
                    toolStripStatusLabel1.Text = "Number has been Deleted";
                    nextIndex--;
                    DisplayNumber();
                    TextBoxClearFocus();
                }
                else
                {
                    toolStripStatusLabel1.Text = "User had cancelled to Delete";
                }

            }
            else
            {
                toolStripStatusLabel1.Text = "User need to select data from the list";
            }
        }
        #endregion

        #region SORT and SEARCH
        //PR3: sort method using the Bubble Sort algorithm.Sorting in Ascending order
        private void Sort()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                for (int j = i + 1; j < nextIndex; j++)
                {

                    if (hours[i].CompareTo(hours[j]) > 0) //if i is greater than j
                    {
                        int temp = hours[i];
                        hours[i] = hours[j];
                        hours[j] = temp;
                    }
                }
            }
            DisplayNumber();
        }
        //CR3: Button to sort the data
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        //CR3: Button to search the data
        //PR4: search method using the Binary Search algorithm.
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Sort();
            if (!string.IsNullOrEmpty(TextBoxHours.Text))
            {
                int target = int.Parse(TextBoxHours.Text);
                int min = 0;
                int max = nextIndex - 1;
                int mid = 0;
                bool found = false;

                while (min <= max)
                {

                    mid = (min + max) / 2;
                    if (target == hours[mid])
                    {
                        found = true;
                        break;
                    }
                    else if (target.CompareTo(hours[mid]) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                //PR:8 Code must generate a message if the search is successful.
                if (found)
                {
                    MessageBox.Show(target + " is located in line " + (mid + 1),
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //PR:7 Code must generate a message if the search is not successful.
                else
                {
                    MessageBox.Show("Number not found",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                toolStripStatusLabel1.Text = "Search Failed: Please enter numbers into text box";

            }
        }
        #endregion

        #region UTILITIES
        //Status message disapper if the user move the mouse
        private void AstronomicalProcessing_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        //CR2/PR5: The client can use a text box input to search the array.
        private void TextBoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxHours.MaxLength = 2;   //textbox will not accept more than 2 digit
            //It will not let the user type letter and decimal 
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolStripStatusLabel1.Text = "Only whole number accepted, not letter or alphabet";
            }

        }
        private void TextBoxClearFocus()  //method to clear and focus in textbox.
        {
            TextBoxHours.Clear();
            TextBoxHours.Focus();
        }
        #endregion
    }
}
