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
    public partial class Yeast : Form
    {
        private string Yeast_tmp { get; set; }
        private string YeastNutrient_tmp { get; set; }

        public Yeast()
        {
            InitializeComponent();
        }

        private void Yeast_Load(object sender, EventArgs e)
        {
 
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Description_tbox.Text))
            {
                MessageBox.Show("Enter a yeast description.");
                return;
            }

            var sb = new StringBuilder();
            sb.Append(YeastType_cbox.SelectedItem.ToString());
            sb.Append(" ");
            sb.Append(Description_tbox.Text);
            Yeast_tbox.Text = Convert.ToString(sb);

            Description_tbox.Clear();

            Yeast_tmp = Yeast_tbox.Text;
        }

        private void YeastStarter_btn_Click(object sender, EventArgs e)
        {
            YeastStarter yeastStarter = new YeastStarter();
            yeastStarter.Show();
        }

        private void NutrientSubmit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NutrientAmount_tbox.Text))
            {
                MessageBox.Show("Enter a value for nutrient amount.");
                return;
            }
            if (string.IsNullOrEmpty(NutrientDescrip_tbox.Text))
            {
                MessageBox.Show("Enter a yeast nutrient description.");
                return;
            }

            var sb = new StringBuilder();
            sb.Append(NutrientAmount_tbox.Text);
            sb.Append(" oz ");
            sb.Append(NutrientDescrip_tbox.Text);
            YeastNutrient_tbox.Text = Convert.ToString(sb);

            NutrientAmount_tbox.Clear();
            NutrientDescrip_tbox.Clear();

            YeastNutrient_tmp = YeastNutrient_tbox.Text;
        }
    }
}
