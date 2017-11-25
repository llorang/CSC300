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
            MessageBox.Show(Convert.ToString(_hydroReadingRaw));
        }

        private void HydroTemp_tbox_TextChanged(object sender, EventArgs e)
        {
            _hydroTempRaw = Convert.ToInt16(HydroTemp_tbox.Text);
        }

        private void TempCorrect_btn_Click(object sender, EventArgs e)
        {
            Beer.PreBoilGravUncorrected = new Hydrometer(_hydroReadingRaw, _hydroTempRaw);
            Beer.PreBoilGravCorrected = Beer.PreBoilGravUncorrected.TempCorrect(60);
            PreBoilGravity_tbox.Text = Convert.ToString(Math.Round(Beer.PreBoilGravCorrected.Reading,4));
        }
    }
}
