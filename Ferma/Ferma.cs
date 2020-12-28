using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferma
{
    public partial class Ferma : Form
    {
        public Ferma()
        {
            InitializeComponent();
        }

        private void Ferma_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoPlayer videoForm = new VideoPlayer();
            videoForm.Tag = this;
            videoForm.Show(this);
            Hide();
        }
    }
}
