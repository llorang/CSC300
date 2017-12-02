using System;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class BoilForm : Form
    {
        private double _hydroReadingRaw;
        private int _hydroTempRaw;
        private int _boilTime;
        private int _irishMossTime;
        private int _yeastNutrientTime;
        

        public BoilForm()
        {
            InitializeComponent();
        }

        private void HydroReading_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hydroReadingRaw = Convert.ToDouble(HydroReading_cbox.SelectedItem);
        }

        private void HydroTemp_tbox_TextChanged(object sender, EventArgs e)
        {
            _hydroTempRaw = Convert.ToInt16(HydroTemp_tbox.Text);
        }

        private void TempCorrect_btn_Click(object sender, EventArgs e)
        {
            Beer.PreBoilGravUncorrected = new Measurement.Hydrometer.Hydrometer(_hydroReadingRaw, _hydroTempRaw);
            Beer.PreBoilGravCorrected = Beer.PreBoilGravUncorrected.TempCorrect(60);
            PreBoilGravity_tbox.Text = Convert.ToString(Math.Round(Beer.PreBoilGravCorrected.Reading, 4));
        }

        private void LoadFields_btn_Click(object sender, EventArgs e)
        {
            PtsPerGal_tbox.Text = Beer.PointsPerGallon.ToString();
            WortVolume_tbox.Text = Convert.ToString(Math.Round (Beer.WortVolume / 4.0, 2));
            GrainBill_tbox.Text = IngredientsAllGrain.GrainTotal.ToString();
        }

        private void CalcEfficiency_btn_Click(object sender, EventArgs e)
        {
            Beer.ConversionEfficiency = Beer.ConversionEfficiencyCalc (Beer.WortVolume,IngredientsAllGrain.GrainTotal);
            PtsPerPound_tbox.Text = Convert.ToString(Math.Round(Beer.ConversionEfficiency, 2));
        }

        private void BoilTime_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _boilTime = Convert.ToInt16(BoilTime_cbox.SelectedItem);
        }

        private void IrishMoss_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _irishMossTime = Convert.ToInt16(IrishMoss_cbox.SelectedItem);
        }

        private void YeastNutrient_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _yeastNutrientTime = Convert.ToInt16(YeastNutrient_cbox.SelectedItem);
        }

        private void HopAddittions_btn_Click(object sender, EventArgs e)
        {
            if (Beer.PreBoilGravCorrected == null)
            {
                MessageBox.Show("Missing a value for wort gravity.");
            }
            else
            {
                HopAdditions hopAdditions = new HopAdditions();
                hopAdditions.Show();
            }

        }

        private void ChillMethod_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add more options when they become available
        }

        private void PostBoilGravReading_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hydroReadingRaw = Convert.ToDouble(PostBoilGravReading_cbox.SelectedItem);
        }

        private void PostBoilGravTemp_tbox_TextChanged(object sender, EventArgs e)
        {
            _hydroTempRaw = Convert.ToInt16(PostBoilGravTemp_tbox.Text);
        }

        private void PostBoilTempCorrect_btn_Click(object sender, EventArgs e)
        {
            Beer.PostBoilGravUncorrected = new Measurement.Hydrometer.Hydrometer(_hydroReadingRaw, _hydroTempRaw);
            Beer.PostBoilGravCorrected = Beer.PostBoilGravUncorrected.TempCorrect(60);
            PostBoilGravity_tbox.Text = Convert.ToString(Math.Round(Beer.PostBoilGravCorrected.Reading, 4));
        }
    }
}
