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
            this.AcceptBatchID_lbl = new System.Windows.Forms.Label();
            this.AcceptBatchID_btn = new System.Windows.Forms.Button();
            this.BatchName_lbl = new System.Windows.Forms.Label();
            this.BatchName_tbox = new System.Windows.Forms.TextBox();
            this.BatchName_btn = new System.Windows.Forms.Button();
            this.BrewMethod_lbl = new System.Windows.Forms.Label();
            this.BrewMethod_btn = new System.Windows.Forms.Button();
            this.BrewMethod_cbox = new System.Windows.Forms.ComboBox();
            this.BatchVolume_cbox = new System.Windows.Forms.ComboBox();
            this.BatchVolume_btn = new System.Windows.Forms.Button();
            this.BatchVolume_lbl = new System.Windows.Forms.Label();
            this.BeerType_btn = new System.Windows.Forms.Button();
            this.BeerType_cbox = new System.Windows.Forms.ComboBox();
            this.BeerType_lbl = new System.Windows.Forms.Label();
            this.OGRange_lbl = new System.Windows.Forms.Label();
            this.OGLower_cbox = new System.Windows.Forms.ComboBox();
            this.OGUpper_cbox = new System.Windows.Forms.ComboBox();
            this.FGUpper_cbox = new System.Windows.Forms.ComboBox();
            this.FGLower_cbox = new System.Windows.Forms.ComboBox();
            this.FGRange_lbl = new System.Windows.Forms.Label();
            this.FermTempUpper_cbox = new System.Windows.Forms.ComboBox();
            this.FermTempLower_cbox = new System.Windows.Forms.ComboBox();
            this.FermTemp_lbl = new System.Windows.Forms.Label();
            this.IBU_btn = new System.Windows.Forms.Button();
            this.IBU_tbox = new System.Windows.Forms.TextBox();
            this.IBU_lbl = new System.Windows.Forms.Label();
            this.BrewEquipment_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.SubmitProdType_btn.Text = "Submit";
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
            this.BatchID_lbl.Location = new System.Drawing.Point(496, 12);
            this.BatchID_lbl.Name = "BatchID_lbl";
            this.BatchID_lbl.Size = new System.Drawing.Size(62, 16);
            this.BatchID_lbl.TabIndex = 11;
            this.BatchID_lbl.Text = "BatchID";
            // 
            // BatchID_txt
            // 
            this.BatchID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchID_txt.Location = new System.Drawing.Point(496, 36);
            this.BatchID_txt.Name = "BatchID_txt";
            this.BatchID_txt.Size = new System.Drawing.Size(82, 44);
            this.BatchID_txt.TabIndex = 12;
            // 
            // MashLauter_btn
            // 
            this.MashLauter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MashLauter_btn.Location = new System.Drawing.Point(283, 553);
            this.MashLauter_btn.Name = "MashLauter_btn";
            this.MashLauter_btn.Size = new System.Drawing.Size(213, 29);
            this.MashLauter_btn.TabIndex = 13;
            this.MashLauter_btn.Text = "Mash/Lauter Page";
            this.MashLauter_btn.UseVisualStyleBackColor = true;
            this.MashLauter_btn.Click += new System.EventHandler(this.MashLauter_btn_Click);
            // 
            // AcceptBatchID_lbl
            // 
            this.AcceptBatchID_lbl.AutoSize = true;
            this.AcceptBatchID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBatchID_lbl.Location = new System.Drawing.Point(257, 346);
            this.AcceptBatchID_lbl.Name = "AcceptBatchID_lbl";
            this.AcceptBatchID_lbl.Size = new System.Drawing.Size(122, 16);
            this.AcceptBatchID_lbl.TabIndex = 16;
            this.AcceptBatchID_lbl.Text = "Accept BatchID?";
            // 
            // AcceptBatchID_btn
            // 
            this.AcceptBatchID_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBatchID_btn.Location = new System.Drawing.Point(443, 334);
            this.AcceptBatchID_btn.Name = "AcceptBatchID_btn";
            this.AcceptBatchID_btn.Size = new System.Drawing.Size(65, 39);
            this.AcceptBatchID_btn.TabIndex = 17;
            this.AcceptBatchID_btn.Text = "Yes";
            this.AcceptBatchID_btn.UseVisualStyleBackColor = true;
            this.AcceptBatchID_btn.Click += new System.EventHandler(this.AcceptBatchID_btn_Click);
            // 
            // BatchName_lbl
            // 
            this.BatchName_lbl.AutoSize = true;
            this.BatchName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchName_lbl.Location = new System.Drawing.Point(12, 136);
            this.BatchName_lbl.Name = "BatchName_lbl";
            this.BatchName_lbl.Size = new System.Drawing.Size(92, 16);
            this.BatchName_lbl.TabIndex = 18;
            this.BatchName_lbl.Text = "Batch Name";
            // 
            // BatchName_tbox
            // 
            this.BatchName_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchName_tbox.Location = new System.Drawing.Point(15, 155);
            this.BatchName_tbox.Name = "BatchName_tbox";
            this.BatchName_tbox.Size = new System.Drawing.Size(152, 22);
            this.BatchName_tbox.TabIndex = 19;
            // 
            // BatchName_btn
            // 
            this.BatchName_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchName_btn.Location = new System.Drawing.Point(56, 183);
            this.BatchName_btn.Name = "BatchName_btn";
            this.BatchName_btn.Size = new System.Drawing.Size(63, 23);
            this.BatchName_btn.TabIndex = 20;
            this.BatchName_btn.Text = "Submit";
            this.BatchName_btn.UseVisualStyleBackColor = true;
            this.BatchName_btn.Click += new System.EventHandler(this.BatchName_btn_Click);
            // 
            // BrewMethod_lbl
            // 
            this.BrewMethod_lbl.AutoSize = true;
            this.BrewMethod_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrewMethod_lbl.Location = new System.Drawing.Point(338, 136);
            this.BrewMethod_lbl.Name = "BrewMethod_lbl";
            this.BrewMethod_lbl.Size = new System.Drawing.Size(118, 16);
            this.BrewMethod_lbl.TabIndex = 21;
            this.BrewMethod_lbl.Text = "Brewing Method";
            // 
            // BrewMethod_btn
            // 
            this.BrewMethod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrewMethod_btn.Location = new System.Drawing.Point(365, 183);
            this.BrewMethod_btn.Name = "BrewMethod_btn";
            this.BrewMethod_btn.Size = new System.Drawing.Size(63, 23);
            this.BrewMethod_btn.TabIndex = 23;
            this.BrewMethod_btn.Text = "Submit";
            this.BrewMethod_btn.UseVisualStyleBackColor = true;
            this.BrewMethod_btn.Click += new System.EventHandler(this.BrewMethod_btn_Click);
            // 
            // BrewMethod_cbox
            // 
            this.BrewMethod_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrewMethod_cbox.FormattingEnabled = true;
            this.BrewMethod_cbox.Items.AddRange(new object[] {
            "Extract",
            "Partial Mash",
            "AllGrain",
            "Other"});
            this.BrewMethod_cbox.Location = new System.Drawing.Point(341, 155);
            this.BrewMethod_cbox.Name = "BrewMethod_cbox";
            this.BrewMethod_cbox.Size = new System.Drawing.Size(115, 24);
            this.BrewMethod_cbox.TabIndex = 24;
            // 
            // BatchVolume_cbox
            // 
            this.BatchVolume_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchVolume_cbox.FormattingEnabled = true;
            this.BatchVolume_cbox.Items.AddRange(new object[] {
            "1.0",
            "2.5",
            "5.0",
            "10.0"});
            this.BatchVolume_cbox.Location = new System.Drawing.Point(201, 155);
            this.BatchVolume_cbox.Name = "BatchVolume_cbox";
            this.BatchVolume_cbox.Size = new System.Drawing.Size(115, 24);
            this.BatchVolume_cbox.TabIndex = 27;
            // 
            // BatchVolume_btn
            // 
            this.BatchVolume_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchVolume_btn.Location = new System.Drawing.Point(225, 183);
            this.BatchVolume_btn.Name = "BatchVolume_btn";
            this.BatchVolume_btn.Size = new System.Drawing.Size(63, 23);
            this.BatchVolume_btn.TabIndex = 26;
            this.BatchVolume_btn.Text = "Submit";
            this.BatchVolume_btn.UseVisualStyleBackColor = true;
            this.BatchVolume_btn.Click += new System.EventHandler(this.BatchVolume_btn_Click);
            // 
            // BatchVolume_lbl
            // 
            this.BatchVolume_lbl.AutoSize = true;
            this.BatchVolume_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchVolume_lbl.Location = new System.Drawing.Point(198, 136);
            this.BatchVolume_lbl.Name = "BatchVolume_lbl";
            this.BatchVolume_lbl.Size = new System.Drawing.Size(110, 16);
            this.BatchVolume_lbl.TabIndex = 25;
            this.BatchVolume_lbl.Text = "Batch Vol (gal)";
            // 
            // BeerType_btn
            // 
            this.BeerType_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerType_btn.Location = new System.Drawing.Point(648, 71);
            this.BeerType_btn.Name = "BeerType_btn";
            this.BeerType_btn.Size = new System.Drawing.Size(63, 23);
            this.BeerType_btn.TabIndex = 30;
            this.BeerType_btn.Text = "Submit";
            this.BeerType_btn.UseVisualStyleBackColor = true;
            this.BeerType_btn.Click += new System.EventHandler(this.BeerType_btn_Click);
            // 
            // BeerType_cbox
            // 
            this.BeerType_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerType_cbox.FormattingEnabled = true;
            this.BeerType_cbox.Items.AddRange(new object[] {
            "Ale",
            "Lager",
            "BarleyWine"});
            this.BeerType_cbox.Location = new System.Drawing.Point(607, 41);
            this.BeerType_cbox.Name = "BeerType_cbox";
            this.BeerType_cbox.Size = new System.Drawing.Size(152, 24);
            this.BeerType_cbox.TabIndex = 29;
            // 
            // BeerType_lbl
            // 
            this.BeerType_lbl.AutoSize = true;
            this.BeerType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerType_lbl.Location = new System.Drawing.Point(620, 12);
            this.BeerType_lbl.Name = "BeerType_lbl";
            this.BeerType_lbl.Size = new System.Drawing.Size(129, 16);
            this.BeerType_lbl.TabIndex = 28;
            this.BeerType_lbl.Text = "Select Beer Type";
            // 
            // OGRange_lbl
            // 
            this.OGRange_lbl.AutoSize = true;
            this.OGRange_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OGRange_lbl.Location = new System.Drawing.Point(34, 247);
            this.OGRange_lbl.Name = "OGRange_lbl";
            this.OGRange_lbl.Size = new System.Drawing.Size(199, 16);
            this.OGRange_lbl.TabIndex = 31;
            this.OGRange_lbl.Text = "OG Range (Recommended)";
            // 
            // OGLower_cbox
            // 
            this.OGLower_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OGLower_cbox.FormattingEnabled = true;
            this.OGLower_cbox.Items.AddRange(new object[] {
            "1.030",
            "1.032",
            "1.034",
            "1.036",
            "1.038",
            "1.040",
            "1.042",
            "1.044",
            "1.046",
            "1.048",
            "1.050"});
            this.OGLower_cbox.Location = new System.Drawing.Point(18, 278);
            this.OGLower_cbox.Name = "OGLower_cbox";
            this.OGLower_cbox.Size = new System.Drawing.Size(115, 24);
            this.OGLower_cbox.TabIndex = 33;
            this.OGLower_cbox.Text = "Lower Range";
            this.OGLower_cbox.SelectedIndexChanged += new System.EventHandler(this.OGLower_cbox_SelectedIndexChanged);
            // 
            // OGUpper_cbox
            // 
            this.OGUpper_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OGUpper_cbox.FormattingEnabled = true;
            this.OGUpper_cbox.Items.AddRange(new object[] {
            "1.030",
            "1.032",
            "1.034",
            "1.036",
            "1.038",
            "1.040",
            "1.042",
            "1.044",
            "1.046",
            "1.048",
            "1.050",
            "1.052"});
            this.OGUpper_cbox.Location = new System.Drawing.Point(148, 278);
            this.OGUpper_cbox.Name = "OGUpper_cbox";
            this.OGUpper_cbox.Size = new System.Drawing.Size(115, 24);
            this.OGUpper_cbox.TabIndex = 35;
            this.OGUpper_cbox.Text = "Upper Range";
            this.OGUpper_cbox.SelectedIndexChanged += new System.EventHandler(this.OGUpper_cbox_SelectedIndexChanged);
            // 
            // FGUpper_cbox
            // 
            this.FGUpper_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FGUpper_cbox.FormattingEnabled = true;
            this.FGUpper_cbox.Items.AddRange(new object[] {
            "1.000",
            "1.002",
            "1.004",
            "1.006",
            "1.008",
            "1.010",
            "1.012",
            "1.014",
            "1.016",
            "1.018",
            "1.020"});
            this.FGUpper_cbox.Location = new System.Drawing.Point(443, 278);
            this.FGUpper_cbox.Name = "FGUpper_cbox";
            this.FGUpper_cbox.Size = new System.Drawing.Size(115, 24);
            this.FGUpper_cbox.TabIndex = 38;
            this.FGUpper_cbox.Text = "Upper Range";
            this.FGUpper_cbox.SelectedIndexChanged += new System.EventHandler(this.FGUpper_cbox_SelectedIndexChanged);
            // 
            // FGLower_cbox
            // 
            this.FGLower_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FGLower_cbox.FormattingEnabled = true;
            this.FGLower_cbox.Items.AddRange(new object[] {
            "1.000",
            "1.002",
            "1.004",
            "1.006",
            "1.008",
            "1.010",
            "1.012",
            "1.014",
            "1.016",
            "1.018",
            "1.020"});
            this.FGLower_cbox.Location = new System.Drawing.Point(313, 278);
            this.FGLower_cbox.Name = "FGLower_cbox";
            this.FGLower_cbox.Size = new System.Drawing.Size(115, 24);
            this.FGLower_cbox.TabIndex = 37;
            this.FGLower_cbox.Text = "Lower Range";
            this.FGLower_cbox.SelectedIndexChanged += new System.EventHandler(this.FGLower_cbox_SelectedIndexChanged);
            // 
            // FGRange_lbl
            // 
            this.FGRange_lbl.AutoSize = true;
            this.FGRange_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FGRange_lbl.Location = new System.Drawing.Point(329, 247);
            this.FGRange_lbl.Name = "FGRange_lbl";
            this.FGRange_lbl.Size = new System.Drawing.Size(197, 16);
            this.FGRange_lbl.TabIndex = 36;
            this.FGRange_lbl.Text = "FG Range (Recommended)";
            // 
            // FermTempUpper_cbox
            // 
            this.FermTempUpper_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermTempUpper_cbox.FormattingEnabled = true;
            this.FermTempUpper_cbox.Items.AddRange(new object[] {
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62",
            "64",
            "66",
            "68",
            "70",
            "72",
            "74",
            "76",
            "78"});
            this.FermTempUpper_cbox.Location = new System.Drawing.Point(644, 183);
            this.FermTempUpper_cbox.Name = "FermTempUpper_cbox";
            this.FermTempUpper_cbox.Size = new System.Drawing.Size(115, 24);
            this.FermTempUpper_cbox.TabIndex = 41;
            this.FermTempUpper_cbox.Text = "Upper Range";
            this.FermTempUpper_cbox.SelectedIndexChanged += new System.EventHandler(this.FermTempUpper_cbox_SelectedIndexChanged);
            // 
            // FermTempLower_cbox
            // 
            this.FermTempLower_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermTempLower_cbox.FormattingEnabled = true;
            this.FermTempLower_cbox.Items.AddRange(new object[] {
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62",
            "64",
            "66",
            "68",
            "70",
            "72",
            "74",
            "76"});
            this.FermTempLower_cbox.Location = new System.Drawing.Point(511, 182);
            this.FermTempLower_cbox.Name = "FermTempLower_cbox";
            this.FermTempLower_cbox.Size = new System.Drawing.Size(115, 24);
            this.FermTempLower_cbox.TabIndex = 40;
            this.FermTempLower_cbox.Text = "Lower Range";
            this.FermTempLower_cbox.SelectedIndexChanged += new System.EventHandler(this.FermTempLower_cbox_SelectedIndexChanged);
            // 
            // FermTemp_lbl
            // 
            this.FermTemp_lbl.AutoSize = true;
            this.FermTemp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermTemp_lbl.Location = new System.Drawing.Point(524, 126);
            this.FermTemp_lbl.Name = "FermTemp_lbl";
            this.FermTemp_lbl.Size = new System.Drawing.Size(191, 32);
            this.FermTemp_lbl.TabIndex = 39;
            this.FermTemp_lbl.Text = "Fermentation Temperature\r\nRange (deg F)";
            // 
            // IBU_btn
            // 
            this.IBU_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBU_btn.Location = new System.Drawing.Point(648, 299);
            this.IBU_btn.Name = "IBU_btn";
            this.IBU_btn.Size = new System.Drawing.Size(63, 23);
            this.IBU_btn.TabIndex = 44;
            this.IBU_btn.Text = "Submit";
            this.IBU_btn.UseVisualStyleBackColor = true;
            this.IBU_btn.Click += new System.EventHandler(this.IBU_btn_Click);
            // 
            // IBU_tbox
            // 
            this.IBU_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBU_tbox.Location = new System.Drawing.Point(607, 271);
            this.IBU_tbox.Name = "IBU_tbox";
            this.IBU_tbox.Size = new System.Drawing.Size(152, 22);
            this.IBU_tbox.TabIndex = 43;
            // 
            // IBU_lbl
            // 
            this.IBU_lbl.AutoSize = true;
            this.IBU_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBU_lbl.Location = new System.Drawing.Point(656, 252);
            this.IBU_lbl.Name = "IBU_lbl";
            this.IBU_lbl.Size = new System.Drawing.Size(41, 16);
            this.IBU_lbl.TabIndex = 42;
            this.IBU_lbl.Text = "IBUs";
            // 
            // BrewEquipment_btn
            // 
            this.BrewEquipment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrewEquipment_btn.Location = new System.Drawing.Point(319, 438);
            this.BrewEquipment_btn.Name = "BrewEquipment_btn";
            this.BrewEquipment_btn.Size = new System.Drawing.Size(134, 37);
            this.BrewEquipment_btn.TabIndex = 45;
            this.BrewEquipment_btn.Text = "Brew Equipment";
            this.BrewEquipment_btn.UseVisualStyleBackColor = true;
            this.BrewEquipment_btn.Click += new System.EventHandler(this.BrewEquipment_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 46;
            this.button1.Text = "Ingredients";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(578, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 37);
            this.button2.TabIndex = 47;
            this.button2.Text = "Yeast";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BrewEquipment_btn);
            this.Controls.Add(this.IBU_btn);
            this.Controls.Add(this.IBU_tbox);
            this.Controls.Add(this.IBU_lbl);
            this.Controls.Add(this.FermTempUpper_cbox);
            this.Controls.Add(this.FermTempLower_cbox);
            this.Controls.Add(this.FermTemp_lbl);
            this.Controls.Add(this.FGUpper_cbox);
            this.Controls.Add(this.FGLower_cbox);
            this.Controls.Add(this.FGRange_lbl);
            this.Controls.Add(this.OGUpper_cbox);
            this.Controls.Add(this.OGLower_cbox);
            this.Controls.Add(this.OGRange_lbl);
            this.Controls.Add(this.BeerType_btn);
            this.Controls.Add(this.BeerType_cbox);
            this.Controls.Add(this.BeerType_lbl);
            this.Controls.Add(this.BatchVolume_cbox);
            this.Controls.Add(this.BatchVolume_btn);
            this.Controls.Add(this.BatchVolume_lbl);
            this.Controls.Add(this.BrewMethod_cbox);
            this.Controls.Add(this.BrewMethod_btn);
            this.Controls.Add(this.BrewMethod_lbl);
            this.Controls.Add(this.BatchName_btn);
            this.Controls.Add(this.BatchName_tbox);
            this.Controls.Add(this.BatchName_lbl);
            this.Controls.Add(this.AcceptBatchID_btn);
            this.Controls.Add(this.AcceptBatchID_lbl);
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
        private System.Windows.Forms.Label AcceptBatchID_lbl;
        private System.Windows.Forms.Button AcceptBatchID_btn;
        private System.Windows.Forms.Label BatchName_lbl;
        private System.Windows.Forms.TextBox BatchName_tbox;
        private System.Windows.Forms.Button BatchName_btn;
        private System.Windows.Forms.Label BrewMethod_lbl;
        private System.Windows.Forms.Button BrewMethod_btn;
        private System.Windows.Forms.ComboBox BrewMethod_cbox;
        private System.Windows.Forms.ComboBox BatchVolume_cbox;
        private System.Windows.Forms.Button BatchVolume_btn;
        private System.Windows.Forms.Label BatchVolume_lbl;
        private System.Windows.Forms.Button BeerType_btn;
        private System.Windows.Forms.ComboBox BeerType_cbox;
        private System.Windows.Forms.Label BeerType_lbl;
        private System.Windows.Forms.Label OGRange_lbl;
        private System.Windows.Forms.ComboBox OGLower_cbox;
        private System.Windows.Forms.ComboBox OGUpper_cbox;
        private System.Windows.Forms.ComboBox FGUpper_cbox;
        private System.Windows.Forms.ComboBox FGLower_cbox;
        private System.Windows.Forms.Label FGRange_lbl;
        private System.Windows.Forms.ComboBox FermTempUpper_cbox;
        private System.Windows.Forms.ComboBox FermTempLower_cbox;
        private System.Windows.Forms.Label FermTemp_lbl;
        private System.Windows.Forms.Button IBU_btn;
        private System.Windows.Forms.TextBox IBU_tbox;
        private System.Windows.Forms.Label IBU_lbl;
        private System.Windows.Forms.Button BrewEquipment_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

