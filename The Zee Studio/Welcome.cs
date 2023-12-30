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
    public partial class Welcome : Form
    {
        private Movie movie = null;
        public Welcome()
        {
            InitializeComponent();
        }

        public Welcome(Movie mv)
        {
            InitializeComponent();
            movie = mv;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(movie == null || movie.IsDisposed)
            {
                movie = new Movie();
                movie.Show();
                this.Hide();
            }
        }
    }
}
