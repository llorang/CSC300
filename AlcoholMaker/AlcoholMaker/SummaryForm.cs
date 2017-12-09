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
    public partial class SummaryForm : Form
    {
        private static string _recommendations;

        public static string Recommendations { get { return _recommendations; } }

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SumReportLoad_btn_Click(object sender, EventArgs e)
        {
            Date_tbox.Text = FermentedProducts.BatchDate.ToShortDateString();

            BeerType_txt.Text = MainForm.Beertype;
            BrewMethod_txt.Text = MainForm.BrewMethod.ToString();
            BatchName_txt.Text = MainForm.Batchname;
            BatchID_txt.Text = FermentedProducts.BatchID;
            Volume_txt.Text = MainForm.Batchvolume.ToString();

            OG_txt.Text = Convert.ToString(Math.Round(Beer.PostBoilGravCorrected.Reading, 3));
            FG_txt.Text = Convert.ToString(Math.Round(Beer.FinalGravCorrected.Reading, 3));
            ABV_txt.Text = Convert.ToString(Math.Round(Alcohol.ABV, 2));
            AA_txt.Text = Convert.ToString(Math.Round(Beer.ApparentAttenuation, 1));
            IBUs_txt.Text = Convert.ToString(Math.Round(HopAdditions.IBUtotal, 1));
        }

        private void Recommendations_rtbox_TextChanged(object sender, EventArgs e)
        {
            _recommendations = Recommendations_rtbox.Text;
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Job well done - have a homebrew!");
        }
    }
}
