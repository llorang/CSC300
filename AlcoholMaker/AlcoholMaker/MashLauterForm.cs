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
    public partial class MashLauterForm : Form
    {
        private RangePair _mashTempRange = new RangePair();
        private double _potDiameter;
        private double _liquidHeight;
        private double _firstRunnings;

        public MashLauterForm()
        {
            InitializeComponent();
        }

        private void MashLauterForm_Load(object sender, EventArgs e)
        {
            
        }
        #region Mash-Method Buttons
        private void SingleRest_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill out this form.");
            GrainBill_tbox.Text = IngredientsAllGrain.GrainTotal.ToString();
            StrikeWaterVol_tbox.Text = Convert.ToString(IngredientsAllGrain.GrainTotal * Beer.H2OtoGrainRatio);
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
            MessageBox.Show(MashTempLower_cbox.SelectedItem.ToString());
            if (_mashTempRange.upper <= _mashTempRange.lower && _mashTempRange.upper != 0)
                MessageBox.Show("MashTempRange Lower >= MashTempRange Upper");
        }

        private void MashTempUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mashTempRange.upper = Convert.ToDouble(MashTempUpper_cbox.SelectedItem.ToString());
            MessageBox.Show(MashTempUpper_cbox.SelectedItem.ToString());
            if (_mashTempRange.upper <= _mashTempRange.lower && _mashTempRange.upper != 0)
                MessageBox.Show("MashTempRange Lower >= MashTempRange Upper");
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
        }
    }
}
