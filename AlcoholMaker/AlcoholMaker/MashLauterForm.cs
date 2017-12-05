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
        private RangePair _mashTempRange = new RangePair();
        private double _potDiameter;
        private double _liquidHeight;
        private double _firstRunningsCalculated;
        private double _firstRunnings;
        private double _lauter2Height;
 

        public MashLauterForm()
        {
            InitializeComponent();
        }

        private void MashLauterForm_Load(object sender, EventArgs e)
        {
            SingleRest_btn.Enabled = true;
            MultiRest_btn.Enabled = false;
            DecoctionMash_btn.Enabled = false;
        }
        #region Mash-Method Buttons
        private void SingleRest_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill out this form.");
            GrainBill_tbox.Text = IngredientsAllGrain.GrainTotal.ToString();
            Beer.StrikeWaterVolume = IngredientsAllGrain.GrainTotal * Beer.H2OtoGrainRatio;
            StrikeWaterVol_tbox.Text = Convert.ToString(IngredientsAllGrain.GrainTotal * Beer.H2OtoGrainRatio);
            _firstRunningsCalculated = IngredientsAllGrain.GrainTotal * (Beer.H2OtoGrainRatio - Beer.H2ORetentionRatio);
            FirstRunnings_tbox.Text = Convert.ToString(IngredientsAllGrain.GrainTotal * (Beer.H2OtoGrainRatio - Beer.H2ORetentionRatio));
        }

        private void MultiRest_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress.");
        }

        private void DecoctionMash_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relax, don't worry - have a homebrew!\nAnd play Aerosmith Rocks album!");
        }
        #endregion
        #region Mash Operations
        private void MashTempLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mashTempRange.lower = Convert.ToDouble(MashTempLower_cbox.SelectedItem.ToString());
            if (_mashTempRange.upper <= _mashTempRange.lower && _mashTempRange.upper != 0)
                MessageBox.Show("MashTempRange Lower >= MashTempRange Upper");
        }

        private void MashTempUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mashTempRange.upper = Convert.ToDouble(MashTempUpper_cbox.SelectedItem.ToString());
            if (_mashTempRange.upper <= _mashTempRange.lower && _mashTempRange.upper != 0)
                MessageBox.Show("MashTempRange Lower >= MashTempRange Upper");
        }

        private void StrikeTempTarget_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beer.StrikeWaterTempTarget = Convert.ToInt16(StrikeTempTarget_cbox.SelectedItem.ToString());
        }

        private void MashTime_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beer.MashTime = Convert.ToInt16(MashTime_cbox.SelectedItem.ToString());
        }

        private void MashTempActual_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beer.MashTemp = Convert.ToInt16(MashTempActual_cbox.SelectedItem.ToString());
        }

        private void StrikeTempActual_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beer.StrikeTempActual = Convert.ToInt16(StrikeTempActual_cbox.SelectedItem.ToString());
        }
        #endregion
        private void PotDiameter_tbox_TextChanged(object sender, EventArgs e)
        {
            _potDiameter = Convert.ToDouble(PotDiameter_tbox.Text);
        }

        private void LiquidHeight_tbox_TextChanged(object sender, EventArgs e)
        {
            _liquidHeight = Convert.ToDouble(LiquidHeight_tbox.Text);
        }

        private void CalcLauter1_btn_Click(object sender, EventArgs e)
        {
            _firstRunnings = Math.PI * Math.Pow((_potDiameter / 2), 2) * _liquidHeight * 0.0173;   //0.0173 converts cubic inches to quarts
            FirstLauter_tbox.Text = Convert.ToString(Math.Round(_firstRunnings,2));
            SpargeVolume_tbox.Text = Convert.ToString(_firstRunningsCalculated);        //Sparge volume = 1st runnings (calculated)
        }

        private void Lauter2Height_tbox_TextChanged(object sender, EventArgs e)
        {
            _lauter2Height = Convert.ToDouble(Lauter2Height_tbox.Text);
        }

        private void WortVolumeCalc_btn_Click(object sender, EventArgs e)
        {
            Beer.WortVolume = Math.PI * Math.Pow((_potDiameter / 2), 2) * _lauter2Height * 0.0173;   //0.0173 converts cubic inches to quarts
            WortVolQts_tbox.Text = Convert.ToString(Math.Round(Beer.WortVolume,2));
            WortVolGals_tbox.Text = Convert.ToString(Math.Round(Beer.WortVolume / 4.0, 2));
        }

        private void BoilPage_btn_Click(object sender, EventArgs e)
        {
            BoilForm boilForm = new BoilForm();
            boilForm.Show();
        }


    }
}
