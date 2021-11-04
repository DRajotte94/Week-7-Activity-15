using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_Activity_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // populates first and last initial inputs programmatically
            Object[] itemObject = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            firstInitial.Items.AddRange(itemObject);
            lastInititial.Items.AddRange(itemObject);
        }

        private void mediaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select from category
            int choice = mediaBox.SelectedIndex;

            // genre options based on category selection
            if (choice == 0) // movies
            {
                genreBox.Items.Clear(); // ensures box is emtpy before populating
                Object[] genreObject = { "Action", "Suspense", "Horror", "Romanance", "Comedy", "Holiday" };
                genreBox.Items.AddRange(genreObject);
            }
            else if (choice == 1) // books
            {
                genreBox.Items.Clear(); // ensures box is emtpy before populating
                Object[] genreObject = { "Mystery", "Romance", "Historical", "Fantasy", "Religious" };
                genreBox.Items.AddRange(genreObject);
            }
            else if (choice == 2) // games
            {
                genreBox.Items.Clear(); // ensures box is emtpy before populating
                Object[] genreObject = { "Adventure", "Action", "RPG", "FPS", "Sports", "Strategy", "Simulation", "Survival" };
                genreBox.Items.AddRange(genreObject);
            }
            else if (choice == 3) // music
            {
                genreBox.Items.Clear(); // ensures box is emtpy before populating
                Object[] genreObject = { "Classical", "Rock", "Hip-Hop", "Jazz", "Indie", "Country", "Blues" };
                genreBox.Items.AddRange(genreObject);
            }
        }

        private void LuckyButton_Click(object sender, EventArgs e)
        {
            // variables used in formulas based on user input
            int first = firstInitial.SelectedIndex + 1;
            int last = lastInititial.SelectedIndex + 1;
            int media = mediaBox.SelectedIndex + 1;
            int genre = genreBox.SelectedIndex + 1;

            // formula for calculating lucky number
            int lucky = (first + last) + (media * genre) / 3;

            // sends number to form2 and displays it
            Form2 secondForm = new Form2(lucky); // object for form 2
            secondForm.Show(); // display second form
        }
    }
}
