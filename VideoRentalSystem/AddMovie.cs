﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)//This is add movie method
        {
            int a, b;

            if (txtRating.Text == "" || txtTitle.Text == "" || txtYear.Text == "" || txtCopies.Text == "" || txtPlot.Text == "" || txtGenre.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else if (!int.TryParse(txtYear.Text, out a) || !(int.TryParse(txtCopies.Text, out b)))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }

                DatabaseFunctions database = new DatabaseFunctions();
                database.addnewmovie(txtRating.Text, txtTitle.Text, txtYear.Text, rental.ToString(), txtCopies.Text, txtPlot.Text, txtGenre.Text);

                MessageBox.Show("Movie Added");
            }

        }
    }
}
