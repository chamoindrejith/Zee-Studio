using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Zee_Studio
{
    public partial class Display : Form
    {
        private readonly Movie movie = null;
        public Display()
        {
            InitializeComponent();
        }
        public Display(Movie mv)
        {
            movie = mv;
            InitializeComponent();
            lblMovieName.Text = movie.GetMovieName();
            lblMovieID.Text = movie.GetMovieID();
            lblReview.Text = movie.GetReview();
            lblDirector.Text = movie.GetDirector();
            lblEmail.Text = movie.GetEmail();
            lblProductionCompany.Text = movie.GetProductionCompany();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(movie == null || movie.IsDisposed)
            {
                movie = new Movie(this);
            }
            movie.Show();
            this.Hide();
        }

    }
}
