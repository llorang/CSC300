namespace AlcoholMaker
{
    partial class EquipmentAllGrain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveList_lbl = new System.Windows.Forms.Label();
            this.SaveList_btn = new System.Windows.Forms.Button();
            this.RemoveItem_lbl = new System.Windows.Forms.Label();
            this.AddItem_lbl = new System.Windows.Forms.Label();
            this.EquipList_lbl = new System.Windows.Forms.Label();
            this.AddItem_tbox = new System.Windows.Forms.TextBox();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SaveList_lbl
            // 
            this.SaveList_lbl.AutoSize = true;
            this.SaveList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveList_lbl.Location = new System.Drawing.Point(49, 316);
            this.SaveList_lbl.Name = "SaveList_lbl";
            this.SaveList_lbl.Size = new System.Drawing.Size(176, 16);
            this.SaveList_lbl.TabIndex = 18;
            this.SaveList_lbl.Text = "Select items from list to save";
            // 
            // SaveList_btn
            // 
            this.SaveList_btn.Location = new System.Drawing.Point(85, 335);
            this.SaveList_btn.Name = "SaveList_btn";
            this.SaveList_btn.Size = new System.Drawing.Size(94, 49);
            this.SaveList_btn.TabIndex = 17;
            this.SaveList_btn.Text = "Save List";
            this.SaveList_btn.UseVisualStyleBackColor = true;
            this.SaveList_btn.Click += new System.EventHandler(this.SaveList_btn_Click);
            // 
            // RemoveItem_lbl
            // 
            this.RemoveItem_lbl.AutoSize = true;
            this.RemoveItem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem_lbl.Location = new System.Drawing.Point(40, 207);
            this.RemoveItem_lbl.Name = "RemoveItem_lbl";
            this.RemoveItem_lbl.Size = new System.Drawing.Size(185, 16);
            this.RemoveItem_lbl.TabIndex = 16;
            this.RemoveItem_lbl.Text = "Select item to remove from list";
            // 
            // AddItem_lbl
            // 
            this.AddItem_lbl.AutoSize = true;
            this.AddItem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_lbl.Location = new System.Drawing.Point(65, 56);
            this.AddItem_lbl.Name = "AddItem_lbl";
            this.AddItem_lbl.Size = new System.Drawing.Size(141, 16);
            this.AddItem_lbl.TabIndex = 15;
            this.AddItem_lbl.Text = "Enter item to add to list";
            // 
            // EquipList_lbl
            // 
            this.EquipList_lbl.AutoSize = true;
            this.EquipList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipList_lbl.Location = new System.Drawing.Point(304, 31);
            this.EquipList_lbl.Name = "EquipList_lbl";
            this.EquipList_lbl.Size = new System.Drawing.Size(109, 16);
            this.EquipList_lbl.TabIndex = 14;
            this.EquipList_lbl.Text = "Equipment List";
            // 
            // AddItem_tbox
            // 
            this.AddItem_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_tbox.Location = new System.Drawing.Point(52, 75);
            this.AddItem_tbox.Name = "AddItem_tbox";
            this.AddItem_tbox.Size = new System.Drawing.Size(164, 22);
            this.AddItem_tbox.TabIndex = 13;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(85, 226);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(94, 49);
            this.Remove_btn.TabIndex = 12;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(85, 103);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(94, 47);
            this.Add_btn.TabIndex = 11;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Plastic bottling bucket, 5 gal",
            "SS stir spoon",
            "SS boil pot, 3 gal",
            "Mash tun, 3 gal",
            "Large nylon bag",
            "Plastic pitcher, 1/2 gal",
            "Volumetric pitcher",
            "Dial thermometer",
            "Lab thermometer",
            "Hydrometer",
            "Refractometer",
            "Immersion chiller",
            "Siphon & hose",
            "Funnel"});
            this.listBox1.Location = new System.Drawing.Point(260, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 324);
            this.listBox1.TabIndex = 10;
            // 
            // EquipmentAllGrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.SaveList_lbl);
            this.Controls.Add(this.SaveList_btn);
            this.Controls.Add(this.RemoveItem_lbl);
            this.Controls.Add(this.AddItem_lbl);
            this.Controls.Add(this.EquipList_lbl);
            this.Controls.Add(this.AddItem_tbox);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "EquipmentAllGrain";
            this.Text = "EquipmentAllGrain";
            this.Load += new System.EventHandler(this.EquipmentAllGrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SaveList_lbl;
        private System.Windows.Forms.Button SaveList_btn;
        private System.Windows.Forms.Label RemoveItem_lbl;
        private System.Windows.Forms.Label AddItem_lbl;
        private System.Windows.Forms.Label EquipList_lbl;
        private System.Windows.Forms.TextBox AddItem_tbox;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.ListBox listBox1;
    }
}