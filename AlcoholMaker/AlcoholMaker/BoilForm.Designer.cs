namespace AlcoholMaker
{
    partial class BoilForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.HydroReading_lbl = new System.Windows.Forms.Label();
            this.HydroReading_cbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HydroTemp_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TempCorrect_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PreBoilGravity_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadFields_btn = new System.Windows.Forms.Button();
            this.PtsPerGal_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WortVolume_tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrainBill_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CalcEfficiency_btn = new System.Windows.Forms.Button();
            this.PtsPerPound_tbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BoilTime_cbox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.IrishMoss_cbox = new System.Windows.Forms.ComboBox();
            this.YeastNutrient_cbox = new System.Windows.Forms.ComboBox();
            this.HopAdditions_btn = new System.Windows.Forms.Button();
            this.PostBoilGravity_tbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PostBoilTempCorrect_btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.PostBoilGravTemp_tbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PostBoilGravReading_cbox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ChillMethod_cbox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pre-Boil Gravity:";
            // 
            // HydroReading_lbl
            // 
            this.HydroReading_lbl.AutoSize = true;
            this.HydroReading_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HydroReading_lbl.Location = new System.Drawing.Point(151, 19);
            this.HydroReading_lbl.Name = "HydroReading_lbl";
            this.HydroReading_lbl.Size = new System.Drawing.Size(152, 16);
            this.HydroReading_lbl.TabIndex = 1;
            this.HydroReading_lbl.Text = "Hydrometer Reading";
            // 
            // HydroReading_cbox
            // 
            this.HydroReading_cbox.FormattingEnabled = true;
            this.HydroReading_cbox.Items.AddRange(new object[] {
            "1.020",
            "1.021",
            "1.022",
            "1.023",
            "1.024",
            "1.025",
            "1.026",
            "1.027",
            "1.028",
            "1.029",
            "1.030",
            "1.031",
            "1.032",
            "1.033",
            "1.034",
            "1.035",
            "1.036",
            "1.037",
            "1.038",
            "1.039",
            "1.040"});
            this.HydroReading_cbox.Location = new System.Drawing.Point(172, 47);
            this.HydroReading_cbox.Name = "HydroReading_cbox";
            this.HydroReading_cbox.Size = new System.Drawing.Size(95, 21);
            this.HydroReading_cbox.TabIndex = 2;
            this.HydroReading_cbox.SelectedIndexChanged += new System.EventHandler(this.HydroReading_cbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "at";
            // 
            // HydroTemp_tbox
            // 
            this.HydroTemp_tbox.Location = new System.Drawing.Point(337, 48);
            this.HydroTemp_tbox.Name = "HydroTemp_tbox";
            this.HydroTemp_tbox.Size = new System.Drawing.Size(82, 20);
            this.HydroTemp_tbox.TabIndex = 4;
            this.HydroTemp_tbox.TextChanged += new System.EventHandler(this.HydroTemp_tbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temp (deg F)";
            // 
            // TempCorrect_btn
            // 
            this.TempCorrect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TempCorrect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempCorrect_btn.Location = new System.Drawing.Point(460, 19);
            this.TempCorrect_btn.Name = "TempCorrect_btn";
            this.TempCorrect_btn.Size = new System.Drawing.Size(79, 59);
            this.TempCorrect_btn.TabIndex = 6;
            this.TempCorrect_btn.Text = "Temp Correct";
            this.TempCorrect_btn.UseVisualStyleBackColor = true;
            this.TempCorrect_btn.Click += new System.EventHandler(this.TempCorrect_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "at 60 deg F";
            // 
            // PreBoilGravity_tbox
            // 
            this.PreBoilGravity_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreBoilGravity_tbox.Location = new System.Drawing.Point(569, 47);
            this.PreBoilGravity_tbox.Name = "PreBoilGravity_tbox";
            this.PreBoilGravity_tbox.Size = new System.Drawing.Size(84, 22);
            this.PreBoilGravity_tbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Conversion Efficiency:";
            // 
            // LoadFields_btn
            // 
            this.LoadFields_btn.Location = new System.Drawing.Point(40, 164);
            this.LoadFields_btn.Name = "LoadFields_btn";
            this.LoadFields_btn.Size = new System.Drawing.Size(79, 35);
            this.LoadFields_btn.TabIndex = 10;
            this.LoadFields_btn.Text = "Load Fields";
            this.LoadFields_btn.UseVisualStyleBackColor = true;
            this.LoadFields_btn.Click += new System.EventHandler(this.LoadFields_btn_Click);
            // 
            // PtsPerGal_tbox
            // 
            this.PtsPerGal_tbox.Location = new System.Drawing.Point(172, 179);
            this.PtsPerGal_tbox.Name = "PtsPerGal_tbox";
            this.PtsPerGal_tbox.Size = new System.Drawing.Size(59, 20);
            this.PtsPerGal_tbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pts/Gal";
            // 
            // WortVolume_tbox
            // 
            this.WortVolume_tbox.Location = new System.Drawing.Point(279, 179);
            this.WortVolume_tbox.Name = "WortVolume_tbox";
            this.WortVolume_tbox.Size = new System.Drawing.Size(60, 20);
            this.WortVolume_tbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wort Volume (gal)";
            // 
            // GrainBill_tbox
            // 
            this.GrainBill_tbox.Location = new System.Drawing.Point(398, 179);
            this.GrainBill_tbox.Name = "GrainBill_tbox";
            this.GrainBill_tbox.Size = new System.Drawing.Size(62, 20);
            this.GrainBill_tbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grain Bill (lb)";
            // 
            // CalcEfficiency_btn
            // 
            this.CalcEfficiency_btn.Location = new System.Drawing.Point(524, 162);
            this.CalcEfficiency_btn.Name = "CalcEfficiency_btn";
            this.CalcEfficiency_btn.Size = new System.Drawing.Size(67, 37);
            this.CalcEfficiency_btn.TabIndex = 17;
            this.CalcEfficiency_btn.Text = "Calculate";
            this.CalcEfficiency_btn.UseVisualStyleBackColor = true;
            this.CalcEfficiency_btn.Click += new System.EventHandler(this.CalcEfficiency_btn_Click);
            // 
            // PtsPerPound_tbox
            // 
            this.PtsPerPound_tbox.Location = new System.Drawing.Point(644, 179);
            this.PtsPerPound_tbox.Name = "PtsPerPound_tbox";
            this.PtsPerPound_tbox.Size = new System.Drawing.Size(88, 20);
            this.PtsPerPound_tbox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Pts/lb";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "The Boil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Boil Time";
            // 
            // BoilTime_cbox
            // 
            this.BoilTime_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoilTime_cbox.FormattingEnabled = true;
            this.BoilTime_cbox.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90"});
            this.BoilTime_cbox.Location = new System.Drawing.Point(96, 284);
            this.BoilTime_cbox.Name = "BoilTime_cbox";
            this.BoilTime_cbox.Size = new System.Drawing.Size(102, 23);
            this.BoilTime_cbox.TabIndex = 22;
            this.BoilTime_cbox.Text = "T = xx minutes";
            this.BoilTime_cbox.SelectedIndexChanged += new System.EventHandler(this.BoilTime_cbox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(245, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Additions:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(328, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Irish Moss";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(533, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Yeast Nutrient";
            // 
            // IrishMoss_cbox
            // 
            this.IrishMoss_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrishMoss_cbox.FormattingEnabled = true;
            this.IrishMoss_cbox.Items.AddRange(new object[] {
            "25",
            "35",
            "50",
            "65",
            "80"});
            this.IrishMoss_cbox.Location = new System.Drawing.Point(412, 284);
            this.IrishMoss_cbox.Name = "IrishMoss_cbox";
            this.IrishMoss_cbox.Size = new System.Drawing.Size(102, 23);
            this.IrishMoss_cbox.TabIndex = 26;
            this.IrishMoss_cbox.Text = "T = xx minutes";
            this.IrishMoss_cbox.SelectedIndexChanged += new System.EventHandler(this.IrishMoss_cbox_SelectedIndexChanged);
            // 
            // YeastNutrient_cbox
            // 
            this.YeastNutrient_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeastNutrient_cbox.FormattingEnabled = true;
            this.YeastNutrient_cbox.Items.AddRange(new object[] {
            "25",
            "40",
            "55",
            "70",
            "85"});
            this.YeastNutrient_cbox.Location = new System.Drawing.Point(644, 284);
            this.YeastNutrient_cbox.Name = "YeastNutrient_cbox";
            this.YeastNutrient_cbox.Size = new System.Drawing.Size(102, 23);
            this.YeastNutrient_cbox.TabIndex = 27;
            this.YeastNutrient_cbox.Text = "T = xx minutes";
            this.YeastNutrient_cbox.SelectedIndexChanged += new System.EventHandler(this.YeastNutrient_cbox_SelectedIndexChanged);
            // 
            // HopAdditions_btn
            // 
            this.HopAdditions_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HopAdditions_btn.Location = new System.Drawing.Point(266, 341);
            this.HopAdditions_btn.Name = "HopAdditions_btn";
            this.HopAdditions_btn.Size = new System.Drawing.Size(179, 45);
            this.HopAdditions_btn.TabIndex = 28;
            this.HopAdditions_btn.Text = "Hop Additions";
            this.HopAdditions_btn.UseVisualStyleBackColor = true;
            this.HopAdditions_btn.Click += new System.EventHandler(this.HopAddittions_btn_Click);
            // 
            // PostBoilGravity_tbox
            // 
            this.PostBoilGravity_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostBoilGravity_tbox.Location = new System.Drawing.Point(581, 594);
            this.PostBoilGravity_tbox.Name = "PostBoilGravity_tbox";
            this.PostBoilGravity_tbox.Size = new System.Drawing.Size(84, 22);
            this.PostBoilGravity_tbox.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(672, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "at 60 deg F";
            // 
            // PostBoilTempCorrect_btn
            // 
            this.PostBoilTempCorrect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PostBoilTempCorrect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostBoilTempCorrect_btn.Location = new System.Drawing.Point(460, 565);
            this.PostBoilTempCorrect_btn.Name = "PostBoilTempCorrect_btn";
            this.PostBoilTempCorrect_btn.Size = new System.Drawing.Size(79, 59);
            this.PostBoilTempCorrect_btn.TabIndex = 35;
            this.PostBoilTempCorrect_btn.Text = "Temp Correct";
            this.PostBoilTempCorrect_btn.UseVisualStyleBackColor = true;
            this.PostBoilTempCorrect_btn.Click += new System.EventHandler(this.PostBoilTempCorrect_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(334, 565);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Temp (deg F)";
            // 
            // PostBoilGravTemp_tbox
            // 
            this.PostBoilGravTemp_tbox.Location = new System.Drawing.Point(337, 594);
            this.PostBoilGravTemp_tbox.Name = "PostBoilGravTemp_tbox";
            this.PostBoilGravTemp_tbox.Size = new System.Drawing.Size(82, 20);
            this.PostBoilGravTemp_tbox.TabIndex = 33;
            this.PostBoilGravTemp_tbox.TextChanged += new System.EventHandler(this.PostBoilGravTemp_tbox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(292, 595);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "at";
            // 
            // PostBoilGravReading_cbox
            // 
            this.PostBoilGravReading_cbox.FormattingEnabled = true;
            this.PostBoilGravReading_cbox.Items.AddRange(new object[] {
            "1.020",
            "1.021",
            "1.022",
            "1.023",
            "1.024",
            "1.025",
            "1.026",
            "1.027",
            "1.028",
            "1.029",
            "1.030",
            "1.031",
            "1.032",
            "1.033",
            "1.034",
            "1.035",
            "1.036",
            "1.037",
            "1.038",
            "1.039",
            "1.040"});
            this.PostBoilGravReading_cbox.Location = new System.Drawing.Point(172, 593);
            this.PostBoilGravReading_cbox.Name = "PostBoilGravReading_cbox";
            this.PostBoilGravReading_cbox.Size = new System.Drawing.Size(95, 21);
            this.PostBoilGravReading_cbox.TabIndex = 31;
            this.PostBoilGravReading_cbox.SelectedIndexChanged += new System.EventHandler(this.PostBoilGravReading_cbox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(151, 565);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 16);
            this.label18.TabIndex = 30;
            this.label18.Text = "Hydrometer Reading";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 594);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Post-Boil Gravity:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(37, 463);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "Chill Method:";
            // 
            // ChillMethod_cbox
            // 
            this.ChillMethod_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChillMethod_cbox.FormattingEnabled = true;
            this.ChillMethod_cbox.Items.AddRange(new object[] {
            "Immersion Chiller"});
            this.ChillMethod_cbox.Location = new System.Drawing.Point(230, 463);
            this.ChillMethod_cbox.Name = "ChillMethod_cbox";
            this.ChillMethod_cbox.Size = new System.Drawing.Size(249, 23);
            this.ChillMethod_cbox.TabIndex = 39;
            this.ChillMethod_cbox.Text = "Select Method";
            this.ChillMethod_cbox.SelectedIndexChanged += new System.EventHandler(this.ChillMethod_cbox_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(572, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "Wort Gravity";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(556, 565);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "Wort Gravity (OG)";
            // 
            // BoilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 659);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ChillMethod_cbox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.PostBoilGravity_tbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PostBoilTempCorrect_btn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PostBoilGravTemp_tbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PostBoilGravReading_cbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.HopAdditions_btn);
            this.Controls.Add(this.YeastNutrient_cbox);
            this.Controls.Add(this.IrishMoss_cbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BoilTime_cbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PtsPerPound_tbox);
            this.Controls.Add(this.CalcEfficiency_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GrainBill_tbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WortVolume_tbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PtsPerGal_tbox);
            this.Controls.Add(this.LoadFields_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PreBoilGravity_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TempCorrect_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HydroTemp_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HydroReading_cbox);
            this.Controls.Add(this.HydroReading_lbl);
            this.Controls.Add(this.label1);
            this.Name = "BoilForm";
            this.Text = "BoilForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HydroReading_lbl;
        private System.Windows.Forms.ComboBox HydroReading_cbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HydroTemp_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TempCorrect_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PreBoilGravity_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoadFields_btn;
        private System.Windows.Forms.TextBox PtsPerGal_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WortVolume_tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GrainBill_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CalcEfficiency_btn;
        private System.Windows.Forms.TextBox PtsPerPound_tbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox BoilTime_cbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox IrishMoss_cbox;
        private System.Windows.Forms.ComboBox YeastNutrient_cbox;
        private System.Windows.Forms.Button HopAdditions_btn;
        private System.Windows.Forms.TextBox PostBoilGravity_tbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button PostBoilTempCorrect_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PostBoilGravTemp_tbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox PostBoilGravReading_cbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox ChillMethod_cbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}