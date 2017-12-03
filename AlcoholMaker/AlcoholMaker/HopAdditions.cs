using System;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class HopAdditions : Form
    {
        private double _wortVolumeGals;
        private double _wortGravity;
        private string _hopVariety;
        private string _hopVariety2;
        private string _hopVariety3;
        private string _hopVariety4;
        private double _hopWeight;
        private double _hopWeight2;
        private double _hopWeight3;
        private double _hopWeight4;
        private double _hopAA;
        private double _hopAA2;
        private double _hopAA3;
        private double _hopAA4;
        private int _boilTime;
        private int _boilTime2;
        private int _boilTime3;
        private int _boilTime4;
        private double _ibuTotal = 0.0;
         
        public HopAdditions()
        {
            InitializeComponent();
        }

        private void HopAdditions_Load(object sender, EventArgs e)
        {
            _wortVolumeGals = Beer.WortVolume / 4.0;
            BatchVolume_tbox.Text = Convert.ToString(Math.Round(Beer.WortVolume / 4.0, 2));
            _wortGravity = Beer.PreBoilGravCorrected.Reading;
            WortGravity_tbox.Text = Convert.ToString(Math.Round(Beer.PreBoilGravCorrected.Reading, 3));
        }
        #region Hop Addition 1 Actions
        private void HopVariety1_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopVariety = HopVariety1_cbox.SelectedItem.ToString();
        }

        private void HopWeight1_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopWeight = Convert.ToDouble(HopWeight1_cbox.SelectedItem);
        }

        private void AlphaAcidPercent1_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopAA = Convert.ToDouble(AlphaAcidPercent1_cbox.SelectedItem);
        }

        private void BoilTime1_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _boilTime = Convert.ToInt16(BoilTime1_cbox.SelectedItem);
        }

        private void Addtn1Submit_btn_Click(object sender, EventArgs e)
        {
            var hopsAddtn1 = new GeneralBeer.Hops.Hops(_hopVariety, _hopWeight, _hopAA, _boilTime);
            _ibuTotal += hopsAddtn1.CalculateIBU(_wortGravity, _wortVolumeGals);
            IBU_tbox.Text = Convert.ToString(Math.Round(_ibuTotal));
        }
        #endregion
        #region Hop Addition 2 Actions
        private void HopVariety2_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopVariety2 = HopVariety2_cbox.SelectedItem.ToString();
        }

        private void HopWeight2_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopWeight2 = Convert.ToDouble(HopWeight2_cbox.SelectedItem);
        }

        private void AlphaAcidPercent2_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopAA2 = Convert.ToDouble(AlphaAcidPercent2_cbox.SelectedItem);
        }

        private void BoilTime2_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _boilTime2 = Convert.ToInt16(BoilTime2_cbox.SelectedItem);
        }

        private void Addtn2Submit_btn_Click(object sender, EventArgs e)
        {
            var hopsAddtn2 = new GeneralBeer.Hops.Hops(_hopVariety2, _hopWeight2, _hopAA2, _boilTime2);
            _ibuTotal += hopsAddtn2.CalculateIBU(_wortGravity, _wortVolumeGals);
            IBU_tbox.Text = Convert.ToString(Math.Round(_ibuTotal));
        }
        #endregion
        #region Hop Addition 3 Actions
        private void HopVariety3_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopVariety3 = HopVariety3_cbox.SelectedItem.ToString();
        }
        private void HopWeight3_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopWeight3 = Convert.ToDouble(HopWeight3_cbox.SelectedItem);
        }

        private void AlphaAcidPercent3_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopAA3 = Convert.ToDouble(AlphaAcidPercent3_cbox.SelectedItem);
        }

        private void BoilTime3_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _boilTime3 = Convert.ToInt16(BoilTime3_cbox.SelectedItem);
        }

        private void Addtn3Submit_btn_Click(object sender, EventArgs e)
        {
            var hopsAddtn3 = new GeneralBeer.Hops.Hops(_hopVariety3, _hopWeight3, _hopAA3, _boilTime3);
            _ibuTotal += hopsAddtn3.CalculateIBU(_wortGravity, _wortVolumeGals);
            IBU_tbox.Text = Convert.ToString(Math.Round(_ibuTotal));
        }
        #endregion
        #region Hop Addition 4 Actions
        private void HopVariety4_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopVariety4 = HopVariety4_cbox.SelectedItem.ToString();
        }

        private void HopWeight4_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopWeight4 = Convert.ToDouble(HopWeight4_cbox.SelectedItem);
        }

        private void AlphaAcidPercent4_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hopAA4 = Convert.ToDouble(AlphaAcidPercent4_cbox.SelectedItem);
        }

        private void BoilTime4_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _boilTime4 = Convert.ToInt16(BoilTime4_cbox.SelectedItem);
        }

        private void Addtn4Submit_btn_Click(object sender, EventArgs e)
        {
            var hopsAddtn4 = new GeneralBeer.Hops.Hops(_hopVariety4, _hopWeight4, _hopAA4, _boilTime4);
            _ibuTotal += hopsAddtn4.CalculateIBU(_wortGravity, _wortVolumeGals);
            IBU_tbox.Text = Convert.ToString(Math.Round(_ibuTotal));
        }
        #endregion


    }
}
