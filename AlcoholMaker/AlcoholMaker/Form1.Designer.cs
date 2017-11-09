namespace AlcoholMaker
{
    partial class MainForm
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
            this.Lbl_BatchNumber = new System.Windows.Forms.Label();
            this.Cbx_BatchNumber = new System.Windows.Forms.ComboBox();
            this.ProdType_lbl = new System.Windows.Forms.Label();
            this.ProdType_cbox = new System.Windows.Forms.ComboBox();
            this.SubmitProdType_btn = new System.Windows.Forms.Button();
            this.BatchIDPrefix_lbl = new System.Windows.Forms.Label();
            this.BatchIDPrefix_txt = new System.Windows.Forms.Label();
            this.BatchNumber_btn = new System.Windows.Forms.Button();
            this.BatchID_lbl = new System.Windows.Forms.Label();
            this.BatchID_txt = new System.Windows.Forms.Label();
            this.MashLauter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_BatchNumber
            // 
            this.Lbl_BatchNumber.AutoSize = true;
            this.Lbl_BatchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BatchNumber.Location = new System.Drawing.Point(338, 12);
            this.Lbl_BatchNumber.Name = "Lbl_BatchNumber";
            this.Lbl_BatchNumber.Size = new System.Drawing.Size(107, 16);
            this.Lbl_BatchNumber.TabIndex = 3;
            this.Lbl_BatchNumber.Text = "Select Batch #";
            // 
            // Cbx_BatchNumber
            // 
            this.Cbx_BatchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_BatchNumber.FormattingEnabled = true;
            this.Cbx_BatchNumber.Location = new System.Drawing.Point(341, 36);
            this.Cbx_BatchNumber.Name = "Cbx_BatchNumber";
            this.Cbx_BatchNumber.Size = new System.Drawing.Size(113, 28);
            this.Cbx_BatchNumber.TabIndex = 4;
            // 
            // ProdType_lbl
            // 
            this.ProdType_lbl.AutoSize = true;
            this.ProdType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdType_lbl.Location = new System.Drawing.Point(12, 12);
            this.ProdType_lbl.Name = "ProdType_lbl";
            this.ProdType_lbl.Size = new System.Drawing.Size(149, 16);
            this.ProdType_lbl.TabIndex = 5;
            this.ProdType_lbl.Text = "Select Product Type";
            // 
            // ProdType_cbox
            // 
            this.ProdType_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdType_cbox.FormattingEnabled = true;
            this.ProdType_cbox.Items.AddRange(new object[] {
            "Beer",
            "Cider",
            "Mead",
            "Wine"});
            this.ProdType_cbox.Location = new System.Drawing.Point(15, 40);
            this.ProdType_cbox.Name = "ProdType_cbox";
            this.ProdType_cbox.Size = new System.Drawing.Size(152, 24);
            this.ProdType_cbox.TabIndex = 6;
            // 
            // SubmitProdType_btn
            // 
            this.SubmitProdType_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitProdType_btn.Location = new System.Drawing.Point(56, 70);
            this.SubmitProdType_btn.Name = "SubmitProdType_btn";
            this.SubmitProdType_btn.Size = new System.Drawing.Size(63, 23);
            this.SubmitProdType_btn.TabIndex = 7;
            this.SubmitProdType_btn.Text = "Submit Type";
            this.SubmitProdType_btn.UseVisualStyleBackColor = true;
            this.SubmitProdType_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BatchIDPrefix_lbl
            // 
            this.BatchIDPrefix_lbl.AutoSize = true;
            this.BatchIDPrefix_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchIDPrefix_lbl.Location = new System.Drawing.Point(200, 12);
            this.BatchIDPrefix_lbl.Name = "BatchIDPrefix_lbl";
            this.BatchIDPrefix_lbl.Size = new System.Drawing.Size(105, 16);
            this.BatchIDPrefix_lbl.TabIndex = 8;
            this.BatchIDPrefix_lbl.Text = "BatchID Prefix";
            // 
            // BatchIDPrefix_txt
            // 
            this.BatchIDPrefix_txt.AutoSize = true;
            this.BatchIDPrefix_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchIDPrefix_txt.Location = new System.Drawing.Point(198, 49);
            this.BatchIDPrefix_txt.Name = "BatchIDPrefix_txt";
            this.BatchIDPrefix_txt.Size = new System.Drawing.Size(0, 16);
            this.BatchIDPrefix_txt.TabIndex = 9;
            // 
            // BatchNumber_btn
            // 
            this.BatchNumber_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchNumber_btn.Location = new System.Drawing.Point(359, 72);
            this.BatchNumber_btn.Name = "BatchNumber_btn";
            this.BatchNumber_btn.Size = new System.Drawing.Size(69, 21);
            this.BatchNumber_btn.TabIndex = 10;
            this.BatchNumber_btn.Text = "Submit";
            this.BatchNumber_btn.UseVisualStyleBackColor = true;
            this.BatchNumber_btn.Click += new System.EventHandler(this.BatchNumber_btn_Click);
            // 
            // BatchID_lbl
            // 
            this.BatchID_lbl.AutoSize = true;
            this.BatchID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchID_lbl.Location = new System.Drawing.Point(517, 15);
            this.BatchID_lbl.Name = "BatchID_lbl";
            this.BatchID_lbl.Size = new System.Drawing.Size(62, 16);
            this.BatchID_lbl.TabIndex = 11;
            this.BatchID_lbl.Text = "BatchID";
            // 
            // BatchID_txt
            // 
            this.BatchID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchID_txt.Location = new System.Drawing.Point(522, 49);
            this.BatchID_txt.Name = "BatchID_txt";
            this.BatchID_txt.Size = new System.Drawing.Size(82, 44);
            this.BatchID_txt.TabIndex = 12;
            // 
            // MashLauter_btn
            // 
            this.MashLauter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MashLauter_btn.Location = new System.Drawing.Point(268, 489);
            this.MashLauter_btn.Name = "MashLauter_btn";
            this.MashLauter_btn.Size = new System.Drawing.Size(213, 29);
            this.MashLauter_btn.TabIndex = 13;
            this.MashLauter_btn.Text = "Mash/Lauter Page";
            this.MashLauter_btn.UseVisualStyleBackColor = true;
            this.MashLauter_btn.Click += new System.EventHandler(this.MashLauter_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 540);
            this.Controls.Add(this.MashLauter_btn);
            this.Controls.Add(this.BatchID_txt);
            this.Controls.Add(this.BatchID_lbl);
            this.Controls.Add(this.BatchNumber_btn);
            this.Controls.Add(this.BatchIDPrefix_txt);
            this.Controls.Add(this.BatchIDPrefix_lbl);
            this.Controls.Add(this.SubmitProdType_btn);
            this.Controls.Add(this.ProdType_cbox);
            this.Controls.Add(this.ProdType_lbl);
            this.Controls.Add(this.Cbx_BatchNumber);
            this.Controls.Add(this.Lbl_BatchNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Beer Maker v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_BatchNumber;
        private System.Windows.Forms.ComboBox Cbx_BatchNumber;
        private System.Windows.Forms.Label ProdType_lbl;
        private System.Windows.Forms.ComboBox ProdType_cbox;
        private System.Windows.Forms.Button SubmitProdType_btn;
        private System.Windows.Forms.Label BatchIDPrefix_lbl;
        private System.Windows.Forms.Label BatchIDPrefix_txt;
        private System.Windows.Forms.Button BatchNumber_btn;
        private System.Windows.Forms.Label BatchID_lbl;
        private System.Windows.Forms.Label BatchID_txt;
        private System.Windows.Forms.Button MashLauter_btn;
    }
}

