using System;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class MainForm : Form
    {
        private string BeerType_tmp { get; set; }
        private string BatchName_tmp { get; set; }
        private string BatchVolume_tmp { get; set; }
        private string BrewMethod_tmp { get; set; }

        private RangePair OG = new RangePair();

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Cbx_BatchNumber.Items.Add(Beer.PrevBatchNumber + 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ProdType_cbox.SelectedIndex == 0)
            {
                BatchIDPrefix_txt.Text = "Beer";
                MessageBox.Show((string)ProdType_cbox.SelectedItem);        //FIXME:  rmv diag
            }
            else if (ProdType_cbox.SelectedIndex == 1)
                BatchIDPrefix_txt.Text = "Cidr";
            else if (ProdType_cbox.SelectedIndex == 2)
                BatchIDPrefix_txt.Text = "Mead";
            else if (ProdType_cbox.SelectedIndex == 3)
                BatchIDPrefix_txt.Text = "Wine";
            else
                BatchIDPrefix_txt.Text = "Select a type";
        }

        private void BatchNumber_btn_Click(object sender, EventArgs e)
        {
            string batchIDsuffix;

            //if(Cbx_BatchNumber.SelectedText.Length != 0)
            //    batchIDsuffix = Cbx_BatchNumber.SelectedText.ToString();      /FIXME:  include an exception
            //else

                batchIDsuffix = Cbx_BatchNumber.SelectedItem.ToString();

                if (batchIDsuffix.Length < 2)
                    batchIDsuffix = "000" + batchIDsuffix;
                else if (batchIDsuffix.Length < 3)
                    batchIDsuffix = "00" + batchIDsuffix;
                else if (batchIDsuffix.Length < 4)
                    batchIDsuffix = "0" + batchIDsuffix;
                else
                    batchIDsuffix = "####";

            //Append batch number with batch prefix to produce BatchID
            BatchID_txt.Text = (string)ProdType_cbox.SelectedItem + batchIDsuffix;
        }

        private void MashLauter_btn_Click(object sender, EventArgs e)
        {
            MashLauterForm mashLauterForm = new MashLauterForm();
            mashLauterForm.Show();
        }

        private void AcceptBatchID_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void BeerType_btn_Click(object sender, EventArgs e)
        {
            BeerType_tmp = BeerType_cbox.Text;
            MessageBox.Show("Beer Type: \n" + BeerType_tmp);
        }

        private void BatchName_btn_Click(object sender, EventArgs e)
        {
            BatchName_tmp = BatchName_tbox.Text;
            MessageBox.Show("Batch Name: \n" + BatchName_tmp);
        }

        private void BatchVolume_btn_Click(object sender, EventArgs e)
        {
            BatchVolume_tmp = BatchVolume_cbox.Text;
            MessageBox.Show("Batch Volume: \n" + BatchVolume_tmp);
        }

        private void BrewMethod_btn_Click(object sender, EventArgs e)
        {
            BrewMethod_tmp = BrewMethod_cbox.SelectedItem.ToString();
            MessageBox.Show("Brewing Method: \n" + BrewMethod_tmp);
        }

        private void OGLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OG.lower = Convert.ToDouble(OGLower_cbox.SelectedItem.ToString());
            MessageBox.Show(OGLower_cbox.SelectedItem.ToString());
            if (OG.upper <= OG.lower)
                MessageBox.Show("OG Lower >= OG Upper");
        }

        private void OGUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OG.upper = Convert.ToDouble(OGUpper_cbox.SelectedItem.ToString());
            MessageBox.Show(OGUpper_cbox.SelectedItem.ToString());
            if (OG.upper <= OG.lower)
                MessageBox.Show("OG Lower >= OG Upper");
        }
    }
}

