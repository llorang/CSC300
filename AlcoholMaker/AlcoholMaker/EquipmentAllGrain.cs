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
    public partial class EquipmentAllGrain : Form
    {
        public EquipmentAllGrain()
        {
            InitializeComponent();
        }

        private void EquipmentAllGrain_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddItem_tbox.Text))
                return;
            listBox1.Items.Add(AddItem_tbox.Text);
            AddItem_tbox.Clear();
            AddItem_tbox.Focus();
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void SaveList_btn_Click(object sender, EventArgs e)
        {
            Beer.BeerEquipAllGrainList = listBox1.SelectedItems.Cast<string>().ToList();
        }
    }
}
