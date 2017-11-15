using System;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class MainForm : Form
    {
        private string BeerType_tmp { get; set; }
        private string BatchName_tmp { get; set; }
        private double BatchVolume_tmp { get; set; }
        private FermentedProducts.BrewMethod BrewMethod_tmp { get; set; }
        private double IBUvalue_tmp { get; set; }
        private string Yeast_tmp { get; set; }

        private RangePair OG = new RangePair();
        private RangePair FG = new RangePair();
        private RangePair FermTemp = new RangePair();

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
            BatchVolume_tmp = Convert.ToDouble(BatchVolume_cbox.Text);
            MessageBox.Show("Batch Volume: \n" + BatchVolume_tmp);
        }

        private void BrewMethod_btn_Click(object sender, EventArgs e)
        {
            if (BrewMethod_cbox.SelectedIndex == 0)
            {
                BrewMethod_tmp = FermentedProducts.BrewMethod.Extract;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
            else if (BrewMethod_cbox.SelectedIndex == 1)
            {
                BrewMethod_tmp = FermentedProducts.BrewMethod.PartialMash;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
            else if (BrewMethod_cbox.SelectedIndex == 2)
            {
                BrewMethod_tmp = FermentedProducts.BrewMethod.AllGrain;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
            else if (BrewMethod_cbox.SelectedIndex == 3)
            {
                BrewMethod_tmp = FermentedProducts.BrewMethod.Other;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
        }

        private void OGLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OG.lower = Convert.ToDouble(OGLower_cbox.SelectedItem.ToString());
            MessageBox.Show(OGLower_cbox.SelectedItem.ToString());
            if (OG.upper <= OG.lower && OG.upper != 0)
                MessageBox.Show("OG Lower >= OG Upper");
        }

        private void OGUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OG.upper = Convert.ToDouble(OGUpper_cbox.SelectedItem.ToString());
            MessageBox.Show(OGUpper_cbox.SelectedItem.ToString());
            if (OG.upper <= OG.lower)
                MessageBox.Show("OG Lower >= OG Upper");
        }

        private void FGLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FG.lower = Convert.ToDouble(FGLower_cbox.SelectedItem.ToString());
            MessageBox.Show(FGLower_cbox.SelectedItem.ToString());
            if (FG.upper <= FG.lower && FG.upper != 0)
                MessageBox.Show("FG Lower >= FG Upper");
        }

        private void FGUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FG.upper = Convert.ToDouble(FGUpper_cbox.SelectedItem.ToString());
            MessageBox.Show(FGUpper_cbox.SelectedItem.ToString());
            if (FG.upper <= FG.lower)
                MessageBox.Show("FG Lower >= FG Upper");
        }

        private void FermTempLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FermTemp.lower = Convert.ToDouble(FermTempLower_cbox.SelectedItem.ToString());
            MessageBox.Show(FermTempLower_cbox.SelectedItem.ToString());
            if (FermTemp.upper <= FermTemp.lower && FermTemp.upper != 0)
                MessageBox.Show("FermTemp Lower >= FermTemp Upper");
        }

        private void FermTempUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FermTemp.upper = Convert.ToDouble(FermTempUpper_cbox.SelectedItem.ToString());
            MessageBox.Show(FermTempUpper_cbox.SelectedItem.ToString());
            if (FermTemp.upper <= FermTemp.lower)
                MessageBox.Show("FermTemp Lower >= FermTemp Upper");
        }

        private void IBU_btn_Click(object sender, EventArgs e)
        {
            IBUvalue_tmp = Convert.ToDouble(IBU_tbox.Text);
            MessageBox.Show("IBUs: " + IBU_tbox.Text);
        }

        private void AcceptBatchID_btn_Click(object sender, EventArgs e)
        {
            if (BeerType_tmp == "Ale")
            {
                MessageBox.Show("called Ale constructor");
                var Beer0001_test = new Ale(BatchName_tmp, BatchVolume_tmp, BrewMethod_tmp, IBUvalue_tmp);
                MessageBox.Show("Beer type: " + Beer0001_test.BeerType);
            }
            else if(BeerType_tmp == "Lager")
                MessageBox.Show("call Lager constructor");                    //FIXME:  add constructors
            else if (BeerType_tmp == "BarleyWine")
                MessageBox.Show("call BarleyWine constructor");
            else
                MessageBox.Show("Select a beer type");
        }

        private void Ingredients_btn_Click(object sender, EventArgs e)
        {
            if (BrewMethod_tmp == FermentedProducts.BrewMethod.AllGrain)
            {
                IngredientsAllGrain ingredientsAllGrain = new IngredientsAllGrain();
                ingredientsAllGrain.Show();
            }
            else
            {
                IngredientsExtract ingredientsExtract = new IngredientsExtract();
                ingredientsExtract.Show();
            }
        }

        private void BrewEquipment_btn_Click(object sender, EventArgs e)
        {
            if(BrewMethod_tmp == FermentedProducts.BrewMethod.AllGrain)
            {
                EquipmentAllGrain equipmentAllGrain = new EquipmentAllGrain();
                equipmentAllGrain.Show();
            }
            else
            {
                EquipmentExtract equipmentExtract = new EquipmentExtract();
                equipmentExtract.Show();
            }
        }

        private void Yeast_tbox_TextChanged(object sender, EventArgs e)
        {
            Yeast_tmp = Yeast_tbox.Text;
        }

        private void YeastStarter_btn_Click(object sender, EventArgs e)
        {
            YeastStarter yeastStarter = new YeastStarter();
            yeastStarter.Show();
        }

        private void MashLauter_btn_Click(object sender, EventArgs e)
        {
            MashLauterForm mashLauterForm = new MashLauterForm();
            mashLauterForm.Show();
        }
    }
}

