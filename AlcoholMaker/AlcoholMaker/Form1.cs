using System;
using System.Windows.Forms;

namespace AlcoholMaker
{
    public partial class MainForm : Form
    {
        private string _beerType_tmp { get; set; }
        private string _batchName_tmp { get; set; }
        private double _batchVolume_tmp { get; set; }
        private FermentedProducts.BrewMethod _brewMethod_tmp { get; set; }
        private double _ibuValue_tmp { get; set; }
        private string _bottleType_tmp { get; set; }
        private int _bottleVolume_tmp { get; set; }

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

        private void BeerType_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _beerType_tmp = BeerType_cbox.SelectedItem.ToString();
        }

        private void BatchName_btn_Click(object sender, EventArgs e)
        {
            _batchName_tmp = BatchName_tbox.Text;
            MessageBox.Show("Batch Name: \n" + _batchName_tmp);
        }

        private void BatchVolume_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _batchVolume_tmp = Convert.ToDouble(BatchVolume_cbox.SelectedItem.ToString());
            FermentedProducts.BatchVolume = _batchVolume_tmp;
        }

        private void BrewMethod_btn_Click(object sender, EventArgs e)
        {
            if (BrewMethod_cbox.SelectedIndex == 0)
            {
                _brewMethod_tmp = FermentedProducts.BrewMethod.Extract;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
            else if (BrewMethod_cbox.SelectedIndex == 1)
            {
                _brewMethod_tmp = FermentedProducts.BrewMethod.PartialMash;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
            else if (BrewMethod_cbox.SelectedIndex == 2)
            {
                _brewMethod_tmp = FermentedProducts.BrewMethod.AllGrain;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
            else if (BrewMethod_cbox.SelectedIndex == 3)
            {
                _brewMethod_tmp = FermentedProducts.BrewMethod.Other;
                MessageBox.Show("Brewing Method: \n" + BrewMethod_cbox.SelectedItem.ToString());
            }
        }

        private void FermTempLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FermTemp.lower = Convert.ToDouble(FermTempLower_cbox.SelectedItem.ToString());
            if (FermTemp.upper <= FermTemp.lower && FermTemp.upper != 0)
                MessageBox.Show("FermTemp Lower >= FermTemp Upper");
        }

        private void FermTempUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FermTemp.upper = Convert.ToDouble(FermTempUpper_cbox.SelectedItem.ToString());
            if (FermTemp.upper <= FermTemp.lower)
                MessageBox.Show("FermTemp Lower >= FermTemp Upper");
        }

        private void OGLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OG.lower = Convert.ToDouble(OGLower_cbox.SelectedItem.ToString());
            if (OG.upper <= OG.lower && OG.upper != 0)
                MessageBox.Show("OG Lower >= OG Upper");
        }

        private void OGUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OG.upper = Convert.ToDouble(OGUpper_cbox.SelectedItem.ToString());
            if (OG.upper <= OG.lower)
                MessageBox.Show("OG Lower >= OG Upper");
        }

        private void FGLower_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FG.lower = Convert.ToDouble(FGLower_cbox.SelectedItem.ToString());
            if (FG.upper <= FG.lower && FG.upper != 0)
                MessageBox.Show("FG Lower >= FG Upper");
        }

        private void FGUpper_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FG.upper = Convert.ToDouble(FGUpper_cbox.SelectedItem.ToString());
            if (FG.upper <= FG.lower)
                MessageBox.Show("FG Lower >= FG Upper");
        }

        private void IBU_btn_Click(object sender, EventArgs e)
        {
            _ibuValue_tmp = Convert.ToDouble(IBU_tbox.Text);
            MessageBox.Show("IBUs: " + IBU_tbox.Text);
        }

        private void BottleType_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bottleType_tmp = BottleType_cbox.SelectedItem.ToString();
        }

        private void BottleVolume_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bottleVolume_tmp = Convert.ToInt16(BottleVolume_cbox.SelectedItem);
        }

        private void AcceptBatchID_btn_Click(object sender, EventArgs e)
        {
            if (_beerType_tmp == "Ale")
            {
                Ale ale1 = new Ale(_batchName_tmp, _batchVolume_tmp, _brewMethod_tmp, _ibuValue_tmp, _bottleType_tmp, _bottleVolume_tmp);
                MessageBox.Show("Beer type: " + ale1.BeerType);
            }
            else if(_beerType_tmp == "Lager")                    //FIXME:  add constructors
                MessageBox.Show("add Lager constructor");
            else if (_beerType_tmp == "BarleyWine")
                MessageBox.Show("add BarleyWine constructor");
            else
                MessageBox.Show("Select a beer type");
        }

        private void Ingredients_btn_Click(object sender, EventArgs e)
        {
            if (_brewMethod_tmp == FermentedProducts.BrewMethod.AllGrain)
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
            if(_brewMethod_tmp == FermentedProducts.BrewMethod.AllGrain)
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

        private void Yeast_btn_Click(object sender, EventArgs e)
        {
            Yeast yeast = new Yeast();
            yeast.Show();
        }

        private void MashLauter_btn_Click(object sender, EventArgs e)
        {
            MashLauterForm mashLauterForm = new MashLauterForm();
            mashLauterForm.Show();
        }

    }
}

