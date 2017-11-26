using System;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class BoilForm : Form
    {
        private double _hydroReadingRaw;
        private int _hydroTempRaw;

        public BoilForm()
        {
            InitializeComponent();
        }

        private void HydroReading_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hydroReadingRaw = Convert.ToDouble(HydroReading_cbox.SelectedItem);
            MessageBox.Show(_hydroReadingRaw.ToString());
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
    }
}
