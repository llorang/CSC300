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
    public partial class IngredientsAllGrain : Form
    {
        public static double GrainTotal = 0.0;

        public IngredientsAllGrain()
        {
            InitializeComponent();
        }

        private void IngredientsAllGrain_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void AddToList_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MassOfGrain_tbox.Text))
            {
                MessageBox.Show("Enter a value for grain mass.");
                return;
            }
            if (string.IsNullOrEmpty(Description_tbox.Text))
            {
                MessageBox.Show("Enter a grain description.");
                return;
            }

            var sb = new StringBuilder();
            sb.Append(MassOfGrain_tbox.Text);
            sb.Append(" ");
            sb.Append(Description_tbox.Text);
            listBox1.Items.Add(sb);

            GrainTotal += Convert.ToDouble(MassOfGrain_tbox.Text);
            GrainTotal_tbox.Text = Convert.ToString(GrainTotal);

            MassOfGrain_tbox.Clear();
            Description_tbox.Clear();
            MassOfGrain_tbox.Focus();
        }

        private void SaveList_btn_Click(object sender, EventArgs e)
        {
            //Beer.BeerIngredAllGrainList = listBox1.SelectedItems.Cast<string>().ToList();
        }
    }
}
