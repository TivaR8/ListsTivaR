using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 14-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program Will randomly generate a letter...
 * ...and will place it in a random position on the form.
*/

namespace ListsTivaR
{
    public partial class frmLists : Form
    {
        // Declare global variables
        List<Label> listOfLabels = new List<Label>();
        Random randomLocation = new Random();
        Random randomLetter = new Random();
        const int MAX_WIDTH = 350;
        const int MAX_HEIGHT = 350;
        const int MIN_LETTER = 65;
        const int MAX_LETTER = 90;

        public frmLists()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Declare local variable
            Label aNewLabel = new Label();
            Point locationOfLabel;
            int xLocation;
            int yLocation;
            int randomLetterNumber;

            // Get random x and y value for the location of label on the form
            xLocation = randomLocation.Next(50, MAX_WIDTH + 1);
            yLocation = randomLocation.Next(50, MAX_HEIGHT + 1);

            //  Get a random unicode value value for a letter between A=65 and Z=90
            randomLetterNumber = randomLetter.Next(MIN_LETTER, MAX_LETTER + 1);

            // Get a new (x,y) object with the random x- and y-values above
            locationOfLabel = new Point(xLocation, yLocation);

            // Insert the random letter into the label
            aNewLabel.Text = Char.ConvertFromUtf32(randomLetterNumber);

            // Adjust the size of the label
            aNewLabel.AutoSize = false;

            // Place the label at the random location 
            aNewLabel.Location = locationOfLabel;

            // Add the label to the controls object
            this.Controls.Add(aNewLabel);

            // Add the label to the list
            listOfLabels.Add(aNewLabel);

            // Update the count of the list on the label
            this.lblListCount.Text = "Current number of items in the list: " + listOfLabels.Count;

            // Refresh the form to display each new label 
            this.Refresh();
        }
    }
}
