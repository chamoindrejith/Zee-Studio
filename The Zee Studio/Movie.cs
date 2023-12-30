using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Zee_Studio
{
    public partial class Movie : Form
    {
        private Display display = null;
        public Movie()
        {
            InitializeComponent();
        }
        public Movie(Display dis)
        {
            display = dis;
            InitializeComponent();
        }

        private Boolean validate()
        {
            string movieName = txtMovieName.Text;
            string movieId = txtMovieID.Text;
            string review = txtReview.Text;
            string director = txtDirector.Text;
            string email = txtEmailID.Text;
            string productionCompany = txtProductionCompany.Text;

            if (!string.IsNullOrEmpty(movieName))
            {
                if(!Regex.Match(movieName, @"^[A-Za-z\s]+$").Success)
                {
                    errorProvider1.SetError(txtMovieName, "Invalid Movie Name!");
                    txtMovieName.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(txtMovieName, "Field is empty");
                txtMovieName.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(movieId))
            {
                if (!Regex.Match(movieId, @"^\d{4}/[A-Za-z]{4}-\d{1,3}$").Success)
                {
                    errorProvider1.SetError(txtMovieID, "Invalid Movie ID!");
                    txtMovieID.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(txtMovieID, "Field is empty!");
                txtMovieID.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(review))
            {
                if (!Regex.Match(review, @"^\d{1}$").Success)
                {
                    errorProvider1.SetError(txtReview, "Invalid Review");
                    txtReview.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(txtReview, "Field is empty!");
                txtReview.Focus();
                return false;
            }


            if (!string.IsNullOrEmpty(director))
            {
                if (!Regex.Match(director, @"^[A-Za-z\s]+$").Success)
                {
                    errorProvider1.SetError(txtDirector, "Invalid Director");
                    txtDirector.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(txtDirector, "Field is empty!");
                txtDirector.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(email))
            {
                if (!Regex.Match(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$").Success)
                {
                    errorProvider1.SetError(txtEmailID, "Invalid Email ID!");
                    txtEmailID.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(txtEmailID, "Field is empty!");
                txtEmailID.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(productionCompany))
            {
                if (!Regex.Match(productionCompany, @"^[A-Za-z\s]+$").Success)
                {
                    errorProvider1.SetError(txtProductionCompany, "Invalid Production company!");
                    txtProductionCompany.Focus();
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(txtProductionCompany, "Field is empty!");
                txtProductionCompany.Focus();
                return false;
            }

            return true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                MessageBox.Show("Details Submitted Successfully!", "Details Status",MessageBoxButtons.OK, MessageBoxIcon.Information); if (display == null || display.IsDisposed)
                if(display != null || display.IsDisposed)
                {
                    display = new Display(this);
                }
                this.Hide();
                display.Show();
            }
            else
            {
                MessageBox.Show("Error in field, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        } 
        
        public string GetMovieName()
        {
            return txtMovieName.Text;
        }
        public string GetMovieID()
        {
            return txtMovieID.Text;
        }
        public string GetReview()
        {
            return txtReview.Text;
        }
        public string GetDirector() 
        { 
            return txtDirector.Text;
        }
        public string GetEmail()
        { 
            return txtEmailID.Text;
        }
        public string GetProductionCompany()
        {
            return txtProductionCompany.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
