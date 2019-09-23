using System;
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
    public partial class MainForm : Form
    {
        //this is the main form where we can handle the all functionalities
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void AddMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }

        private void ViewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomer viewCustomer = new ViewCustomer();
            viewCustomer.ShowDialog();
        }

        private void ViewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMovie viewMovie = new ViewMovie();
            viewMovie.ShowDialog();
        }

        private void IssueMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueMovie issueMovie = new IssueMovie();
            issueMovie.ShowDialog();
        }

        private void ReturnMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnMoviecs returnMoviecs = new ReturnMoviecs();
            returnMoviecs.ShowDialog();
        }
    }
}
