using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the window whem the user clicks the button "Exit"
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare Variables
            string userPhone = txtPhone.Text;
            string finalPhoneNumber;
            const int ARRAY_SIZE = 12;
            char[] phoneNumber = new char[ARRAY_SIZE];
            
            //If statements to make sure entered string is valid
            if (userPhone.Length != ARRAY_SIZE) 
            {
                lblResult.Text = "Length of phone number is incorrect.";
            }
            else if (!userPhone.Contains('-'))
            {
                lblResult.Text = "Hyphen aren't in the phone number.";
            }
            else if (userPhone.Any(char.IsLower))
            {
                lblResult.Text = "Lowercase letters not allowed.";
            }
            else 
            {
                //Goes through the entered phone number and turns any alphabetic characters into a number
                for (int i = 0; i < ARRAY_SIZE; i++)
                {
                    if (char.IsDigit(userPhone[i]))
                    {
                        phoneNumber[i] = userPhone[i];
                    }
                    else if (userPhone[i] == 'A' || userPhone[i] == 'B' || userPhone[i] == 'C')
                    {
                        phoneNumber[i] = '2';
                    }
                    else if (userPhone[i] == 'D' || userPhone[i] == 'E' || userPhone[i] == 'F')
                    {
                        phoneNumber[i] = '3';
                    }
                    else if (userPhone[i] == 'G' || userPhone[i] == 'H' || userPhone[i] == 'I')
                    {
                        phoneNumber[i] = '4';
                    }
                    else if (userPhone[i] == 'J' || userPhone[i] == 'K' || userPhone[i] == 'L')
                    {
                        phoneNumber[i] = '5';
                    }
                    else if (userPhone[i] == 'M' || userPhone[i] == 'N' || userPhone[i] == 'O')
                    {
                        phoneNumber[i] = '6';
                    }
                    else if (userPhone[i] == 'P' || userPhone[i] == 'Q' || userPhone[i] == 'R' || userPhone[i] == 'S')
                    {
                        phoneNumber[i] = '7';
                    }
                    else if (userPhone[i] == 'T' || userPhone[i] == 'U' || userPhone[i] == 'V')
                    {
                        phoneNumber[i] = '8';
                    }
                    else if (userPhone[i] == 'W' || userPhone[i] == 'X' || userPhone[i] == 'Y' || userPhone[i] == 'Z')
                    {
                        phoneNumber[i] = '9';
                    }
                    //Else for the hyphens
                    else
                    {
                        phoneNumber[i] = userPhone[i];
                    }
                }
                //Turns the array of numbers into a string
                finalPhoneNumber = new string(phoneNumber);
                //Outputs said string
                lblResult.Text = finalPhoneNumber;
            }
        }
    }
}
