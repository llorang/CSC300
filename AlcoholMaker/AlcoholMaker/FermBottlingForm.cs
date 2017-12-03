﻿using System;
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
    using Measurement;
    using Measurement.Hydrometer;

    public partial class FermBottlingForm : Form
    {
        private double _hydroReadingRaw;
        private int _hydroTempRaw;

        public FermBottlingForm()
        {
            InitializeComponent();
        }

        private void FermBottlingForm_Load(object sender, EventArgs e)
        {
            AerationDuration_tbox.Enabled = false;
        }

        private void AerationYes_btn_Click(object sender, EventArgs e)
        {
            AerationDuration_tbox.Enabled = true;
            AerationDuration_tbox.Focus();
        }

        private void AerationNo_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The yeast cells will suffocate!");
        }

        private void FinalGravReading_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hydroReadingRaw = Convert.ToDouble(FinalGravReading_cbox.SelectedItem);
        }

        private void FinalGravTemp_tbox_TextChanged(object sender, EventArgs e)
        {
            _hydroTempRaw = Convert.ToInt16(FinalGravTemp_tbox.Text);
        }

        private void FinalGravTempCorrect_btn_Click(object sender, EventArgs e)
        {
            Beer.FinalGravUncorrected = new Hydrometer(_hydroReadingRaw, _hydroTempRaw);
            Beer.FinalGravCorrected = Beer.FinalGravUncorrected.TempCorrect(60);
            FinalGravity_tbox.Text = Convert.ToString(Math.Round(Beer.FinalGravCorrected.Reading, 4));
        }

        private void CalcABV_btn_Click(object sender, EventArgs e)
        {
            Alcohol.ABV = ABV.CalculateABV(Beer.PostBoilGravCorrected.Reading, Beer.FinalGravCorrected.Reading);
            Beer.ApparentAttenuation = ApparentAttenuation.CalcAA(Beer.PostBoilGravCorrected.Reading, Beer.FinalGravCorrected.Reading);
        }

        private void ABV_tbox_TextChanged(object sender, EventArgs e)
        {
            ABV_tbox.Text = Convert.ToString(Math.Round(Alcohol.ABV,3));
            AA_tbox.Text = Convert.ToString(Math.Round(Beer.ApparentAttenuation, 3));
        }
    }
}
