using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**

 *

 * Name: Dylan Angell

 * Teacher: Mr.Hardman

 * Assignment #2, Program #1

 * Date Last Modified: Oct,17,2016

 *
 
 */

namespace WindowsFormsApplication1
{
    public partial class frmAssignmentOne : Form
    {
        public frmAssignmentOne()
        {
            InitializeComponent();
        }

        private void btnWorld_Click(object sender, EventArgs e)
        {
            //Displays text to greet the user
            lblWorldbtn.Text = "Hello user";
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            //these are going to help display the users information
            string userName = txtUserName.Text;
            double userAge = Convert.ToDouble(txtUserAge.Text);
            string userFavColour = txtUserFavColour.Text;

            //These lines of code tell the program what to display
            lblUserInfo.Text = "Your name is: " + userName;
            lblUserInfo.Text += "\nYou are " + userAge + " Years old";
            lblUserInfo.Text += "\nYour favourite colour is " + userFavColour;

        }
    }
}
