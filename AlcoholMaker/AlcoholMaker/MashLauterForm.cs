using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class MashLauterForm : Form
    {
        public MashLauterForm()
        {
            InitializeComponent();
        }

        private void MashLauterForm_Load(object sender, EventArgs e)
        {
            GrainBill_tbox.Text = IngredientsAllGrain.GrainTotal.ToString();
        }

        private void SingleRest_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill out this form.");
        }

        private void MultiRest_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress.");
        }

        private void DecoctionMash_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relax, don't worry - have a homebrew!\nAnd play Aerosmith Rocks album!");
        }


    }
}
