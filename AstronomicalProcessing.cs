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
// Date: 15/09/2021
// Version:1
// AstronomicalProcessing
// This is a form-based application which displays the hours in a listbox, user can able to add, delete and search the data.
// Inputs, Processes, Outputs
//ACRONYMS: SP1:Sprint1, CR: Client Requirement , PR: functional requirement, NFR: Non-functional requirement
namespace AstronomicalProcessing
{
    //CR: Name of the application should be Astronomical processing
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

        //SP1: CR: Application has integer array having element of 24
        static int maxNumber = 24;
        //FR : array must be Integer
        int[] hours = new int[maxNumber];
        int nextIndex = 0;
        private void DisplayNumber()
        {

            ListBoxHours.Items.Clear();
            for (int i = 0; i < nextIndex; i++)
            {
                ListBoxHours.Items.Add(hours[i]);
            }
        }

        private void ListBoxHours_Click(object sender, EventArgs e)
        {
            int current = int.Parse(ListBoxHours.SelectedItem.ToString());
            int idx = ListBoxHours.Items.IndexOf(current);
            TextBoxHours.Text = hours[idx].ToString();
        }

        private void ButtonAutofill_Click(object sender, EventArgs e)
        {
            //FR:1 To display the random number from 10 to 99.
            nextIndex = 24;
            Random rand = new Random();
            for (int i = 0; i < nextIndex; i++)
            {
                hours[i] = rand.Next(10, 100);
            }

            DisplayNumber();
        }
        #endregion

        #region ADD, MODIFY AND DELETE

        //CR/FR:2 Input textbox so that user can add, edit and delete the data 
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxHours.Text))
            {
                try
                {
                    int number = int.Parse(TextBoxHours.Text);
                    hours[nextIndex] = number;
                    nextIndex++;
                    DisplayNumber();
                    TextBoxHours.Clear();
                    TextBoxHours.Focus();
                }
                catch(IndexOutOfRangeException)
                {
                    MessageBox.Show("Sorry,List exceed the limit of 24 numbers");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Sorry,Number too big to be accepted");
                }

            }
            // FR:2 The program must generate an error message if the text box is empty.
            else
            {
                MessageBox.Show("Blank space detected!Please input number in the Box.");
            }

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {

            if (ListBoxHours.SelectedIndex != -1)
            {
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current);
                DialogResult modifyTask = MessageBox.Show("Do you want to Continue?", "It will permanently modify the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (modifyTask == DialogResult.Yes)
                {
                    int.TryParse(TextBoxHours.Text, out hours[idx]);
                    DisplayNumber();
                    TextBoxHours.Clear();
                    TextBoxHours.Focus();
                }
                else
                {

                    toolStripStatusLabel1.Text = "User had cancelled to modify";

                }

            }
            else
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
                    hours[idx] = hours[nextIndex - 1];
                    toolStripStatusLabel1.Text = "Number has been Deleted";
                    nextIndex--;
                    DisplayNumber();
                    TextBoxHours.Clear();
                    TextBoxHours.Focus();
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
        #region Sort and Search
        //FR:3 sort method using the Bubble Sort algorithm.Sorting in Ascending order
        private void Sort()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                for (int j = i + 1; j < nextIndex; j++)
                {

                    if (hours[i].CompareTo(hours[j]) > 0)
                    {
                        int temp = hours[i];
                        hours[i] = hours[j];
                        hours[j] = temp;
                    }
                }
            }
            DisplayNumber();
        }
        //CR: Button to sort
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        //CR: Button to search Data
        //FR:5 search method using the Binary Search algorithm.
        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            Sort();
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
            //FR:5 Code must generate a message if the search is successful.
            if (found)
            {
                MessageBox.Show(target + " number is found");
            }
            //FR:5 Code must generate a message if the search is not successful.
            else
            {
                MessageBox.Show("Number not found");
            }

        }
        #endregion




        private void AstronomicalProcessing_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void TextBoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            toolStripStatusLabel1.Text = "Only digit accepted, not letter or alphabet";
        }
    }



}
