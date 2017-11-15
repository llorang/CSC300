namespace AlcoholMaker
{
    partial class IngredientsAllGrain
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MassOfGrain_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.MassOfGrain_tbox = new System.Windows.Forms.TextBox();
            this.Description_tbox = new System.Windows.Forms.TextBox();
            this.GrainTotal_lbl = new System.Windows.Forms.Label();
            this.GrainTotal_tbox = new System.Windows.Forms.TextBox();
            this.AddToList_btn = new System.Windows.Forms.Button();
            this.SaveList_lbl = new System.Windows.Forms.Label();
            this.SaveList_btn = new System.Windows.Forms.Button();
            this.IngredientList_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(403, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 355);
            this.listBox1.TabIndex = 0;
            // 
            // MassOfGrain_lbl
            // 
            this.MassOfGrain_lbl.AutoSize = true;
            this.MassOfGrain_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassOfGrain_lbl.Location = new System.Drawing.Point(30, 31);
            this.MassOfGrain_lbl.Name = "MassOfGrain_lbl";
            this.MassOfGrain_lbl.Size = new System.Drawing.Size(66, 16);
            this.MassOfGrain_lbl.TabIndex = 1;
            this.MassOfGrain_lbl.Text = "lb of grain";
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.Location = new System.Drawing.Point(134, 31);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(76, 16);
            this.Description_lbl.TabIndex = 2;
            this.Description_lbl.Text = "Description";
            // 
            // MassOfGrain_tbox
            // 
            this.MassOfGrain_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassOfGrain_tbox.Location = new System.Drawing.Point(33, 64);
            this.MassOfGrain_tbox.Name = "MassOfGrain_tbox";
            this.MassOfGrain_tbox.Size = new System.Drawing.Size(63, 22);
            this.MassOfGrain_tbox.TabIndex = 3;
            // 
            // Description_tbox
            // 
            this.Description_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_tbox.Location = new System.Drawing.Point(137, 64);
            this.Description_tbox.Name = "Description_tbox";
            this.Description_tbox.Size = new System.Drawing.Size(196, 22);
            this.Description_tbox.TabIndex = 4;
            // 
            // GrainTotal_lbl
            // 
            this.GrainTotal_lbl.AutoSize = true;
            this.GrainTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrainTotal_lbl.Location = new System.Drawing.Point(34, 213);
            this.GrainTotal_lbl.Name = "GrainTotal_lbl";
            this.GrainTotal_lbl.Size = new System.Drawing.Size(96, 16);
            this.GrainTotal_lbl.TabIndex = 5;
            this.GrainTotal_lbl.Text = "Grain Total (lb)";
            // 
            // GrainTotal_tbox
            // 
            this.GrainTotal_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrainTotal_tbox.Location = new System.Drawing.Point(33, 243);
            this.GrainTotal_tbox.Name = "GrainTotal_tbox";
            this.GrainTotal_tbox.Size = new System.Drawing.Size(89, 22);
            this.GrainTotal_tbox.TabIndex = 6;
            // 
            // AddToList_btn
            // 
            this.AddToList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToList_btn.Location = new System.Drawing.Point(109, 135);
            this.AddToList_btn.Name = "AddToList_btn";
            this.AddToList_btn.Size = new System.Drawing.Size(135, 35);
            this.AddToList_btn.TabIndex = 7;
            this.AddToList_btn.Text = "Add to list";
            this.AddToList_btn.UseVisualStyleBackColor = true;
            this.AddToList_btn.Click += new System.EventHandler(this.AddToList_btn_Click);
            // 
            // SaveList_lbl
            // 
            this.SaveList_lbl.AutoSize = true;
            this.SaveList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveList_lbl.Location = new System.Drawing.Point(101, 309);
            this.SaveList_lbl.Name = "SaveList_lbl";
            this.SaveList_lbl.Size = new System.Drawing.Size(176, 16);
            this.SaveList_lbl.TabIndex = 20;
            this.SaveList_lbl.Text = "Select items from list to save";
            // 
            // SaveList_btn
            // 
            this.SaveList_btn.Location = new System.Drawing.Point(137, 328);
            this.SaveList_btn.Name = "SaveList_btn";
            this.SaveList_btn.Size = new System.Drawing.Size(94, 49);
            this.SaveList_btn.TabIndex = 19;
            this.SaveList_btn.Text = "Save List";
            this.SaveList_btn.UseVisualStyleBackColor = true;
            this.SaveList_btn.Click += new System.EventHandler(this.SaveList_btn_Click);
            // 
            // IngredientList_lbl
            // 
            this.IngredientList_lbl.AutoSize = true;
            this.IngredientList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientList_lbl.Location = new System.Drawing.Point(458, 31);
            this.IngredientList_lbl.Name = "IngredientList_lbl";
            this.IngredientList_lbl.Size = new System.Drawing.Size(105, 16);
            this.IngredientList_lbl.TabIndex = 21;
            this.IngredientList_lbl.Text = "Ingredient List";
            // 
            // IngredientsAllGrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 487);
            this.Controls.Add(this.IngredientList_lbl);
            this.Controls.Add(this.SaveList_lbl);
            this.Controls.Add(this.SaveList_btn);
            this.Controls.Add(this.AddToList_btn);
            this.Controls.Add(this.GrainTotal_tbox);
            this.Controls.Add(this.GrainTotal_lbl);
            this.Controls.Add(this.Description_tbox);
            this.Controls.Add(this.MassOfGrain_tbox);
            this.Controls.Add(this.Description_lbl);
            this.Controls.Add(this.MassOfGrain_lbl);
            this.Controls.Add(this.listBox1);
            this.Name = "IngredientsAllGrain";
            this.Text = "IngredientsAllGrain";
            this.Load += new System.EventHandler(this.IngredientsAllGrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label MassOfGrain_lbl;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.TextBox MassOfGrain_tbox;
        private System.Windows.Forms.TextBox Description_tbox;
        private System.Windows.Forms.Label GrainTotal_lbl;
        private System.Windows.Forms.TextBox GrainTotal_tbox;
        private System.Windows.Forms.Button AddToList_btn;
        private System.Windows.Forms.Label SaveList_lbl;
        private System.Windows.Forms.Button SaveList_btn;
        private System.Windows.Forms.Label IngredientList_lbl;
    }
}