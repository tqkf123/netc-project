using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Rug : Form
    {
        public Rug()
        {
            InitializeComponent();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blankit blankit = new Blankit();
            blankit.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funiture search = new Funiture();
            search.ShowDialog();
            this.Close();
        }
    }
}
