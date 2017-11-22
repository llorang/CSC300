namespace AlcoholMaker
{
    partial class MashLauterForm
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
            this.SingleRest_btn = new System.Windows.Forms.Button();
            this.DecoctionMash_btn = new System.Windows.Forms.Button();
            this.MultiRest_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrainBill_lbl = new System.Windows.Forms.Label();
            this.GrainBill_tbox = new System.Windows.Forms.TextBox();
            this.FirstRunnings_tbox = new System.Windows.Forms.TextBox();
            this.FirstRunnings_lbl = new System.Windows.Forms.Label();
            this.StrikeWaterVol_tbox = new System.Windows.Forms.TextBox();
            this.StrikeWaterVol_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MashTempUpper_cbox = new System.Windows.Forms.ComboBox();
            this.MashTempLower_cbox = new System.Windows.Forms.ComboBox();
            this.MashTempRange_lbl = new System.Windows.Forms.Label();
            this.StrikeTempTarget_lbl = new System.Windows.Forms.Label();
            this.StrikeTempTarget_cbox = new System.Windows.Forms.ComboBox();
            this.MashTime_lbl = new System.Windows.Forms.Label();
            this.MashTime_cbox = new System.Windows.Forms.ComboBox();
            this.MashTempActual_lbl = new System.Windows.Forms.Label();
            this.MashTempActual_cbox = new System.Windows.Forms.ComboBox();
            this.StrikeTempActual_lbl = new System.Windows.Forms.Label();
            this.StrikeTempActual_cbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PotDiameter_tbox = new System.Windows.Forms.TextBox();
            this.LiquidHeight_tbox = new System.Windows.Forms.TextBox();
            this.FirstLauter_tbox = new System.Windows.Forms.TextBox();
            this.CalcLauter1_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SpargeVolume_tbox = new System.Windows.Forms.TextBox();
            this.WortVolumeCalc_btn = new System.Windows.Forms.Button();
            this.WortVolume_tbox = new System.Windows.Forms.TextBox();
            this.Lauter2Height_tbox = new System.Windows.Forms.TextBox();
            this.WortVolume_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingleRest_btn
            // 
            this.SingleRest_btn.Location = new System.Drawing.Point(68, 35);
            this.SingleRest_btn.Name = "SingleRest_btn";
            this.SingleRest_btn.Size = new System.Drawing.Size(182, 54);
            this.SingleRest_btn.TabIndex = 0;
            this.SingleRest_btn.Text = "Single-Rest Infusion";
            this.SingleRest_btn.UseVisualStyleBackColor = true;
            this.SingleRest_btn.Click += new System.EventHandler(this.SingleRest_btn_Click);
            // 
            // DecoctionMash_btn
            // 
            this.DecoctionMash_btn.Location = new System.Drawing.Point(510, 35);
            this.DecoctionMash_btn.Name = "DecoctionMash_btn";
            this.DecoctionMash_btn.Size = new System.Drawing.Size(182, 54);
            this.DecoctionMash_btn.TabIndex = 1;
            this.DecoctionMash_btn.Text = "Decoction Mash";
            this.DecoctionMash_btn.UseVisualStyleBackColor = true;
            this.DecoctionMash_btn.Click += new System.EventHandler(this.DecoctionMash_btn_Click);
            // 
            // MultiRest_btn
            // 
            this.MultiRest_btn.Location = new System.Drawing.Point(290, 35);
            this.MultiRest_btn.Name = "MultiRest_btn";
            this.MultiRest_btn.Size = new System.Drawing.Size(182, 54);
            this.MultiRest_btn.TabIndex = 2;
            this.MultiRest_btn.Text = "Multi-Rest Infusion";
            this.MultiRest_btn.UseVisualStyleBackColor = true;
            this.MultiRest_btn.Click += new System.EventHandler(this.MultiRest_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT A MASHING METHOD";
            // 
            // GrainBill_lbl
            // 
            this.GrainBill_lbl.AutoSize = true;
            this.GrainBill_lbl.Location = new System.Drawing.Point(200, 123);
            this.GrainBill_lbl.Name = "GrainBill_lbl";
            this.GrainBill_lbl.Size = new System.Drawing.Size(98, 16);
            this.GrainBill_lbl.TabIndex = 4;
            this.GrainBill_lbl.Text = "Grain Bill (lb)";
            // 
            // GrainBill_tbox
            // 
            this.GrainBill_tbox.Location = new System.Drawing.Point(176, 153);
            this.GrainBill_tbox.Name = "GrainBill_tbox";
            this.GrainBill_tbox.Size = new System.Drawing.Size(122, 22);
            this.GrainBill_tbox.TabIndex = 5;
            // 
            // FirstRunnings_tbox
            // 
            this.FirstRunnings_tbox.Location = new System.Drawing.Point(574, 153);
            this.FirstRunnings_tbox.Name = "FirstRunnings_tbox";
            this.FirstRunnings_tbox.Size = new System.Drawing.Size(138, 22);
            this.FirstRunnings_tbox.TabIndex = 7;
            // 
            // FirstRunnings_lbl
            // 
            this.FirstRunnings_lbl.AutoSize = true;
            this.FirstRunnings_lbl.Location = new System.Drawing.Point(547, 123);
            this.FirstRunnings_lbl.Name = "FirstRunnings_lbl";
            this.FirstRunnings_lbl.Size = new System.Drawing.Size(201, 16);
            this.FirstRunnings_lbl.TabIndex = 6;
            this.FirstRunnings_lbl.Text = "1st Runnings Calculated (qt)";
            // 
            // StrikeWaterVol_tbox
            // 
            this.StrikeWaterVol_tbox.Location = new System.Drawing.Point(370, 153);
            this.StrikeWaterVol_tbox.Name = "StrikeWaterVol_tbox";
            this.StrikeWaterVol_tbox.Size = new System.Drawing.Size(127, 22);
            this.StrikeWaterVol_tbox.TabIndex = 9;
            // 
            // StrikeWaterVol_lbl
            // 
            this.StrikeWaterVol_lbl.AutoSize = true;
            this.StrikeWaterVol_lbl.Location = new System.Drawing.Point(347, 123);
            this.StrikeWaterVol_lbl.Name = "StrikeWaterVol_lbl";
            this.StrikeWaterVol_lbl.Size = new System.Drawing.Size(176, 16);
            this.StrikeWaterVol_lbl.TabIndex = 8;
            this.StrikeWaterVol_lbl.Text = "Strike Water Volume (qt)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "The Mash:";
            // 
            // MashTempUpper_cbox
            // 
            this.MashTempUpper_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MashTempUpper_cbox.FormattingEnabled = true;
            this.MashTempUpper_cbox.Items.AddRange(new object[] {
            "144",
            "146",
            "148",
            "150",
            "152",
            "154",
            "156",
            "158",
            "160",
            "162",
            "164"});
            this.MashTempUpper_cbox.Location = new System.Drawing.Point(193, 265);
            this.MashTempUpper_cbox.Name = "MashTempUpper_cbox";
            this.MashTempUpper_cbox.Size = new System.Drawing.Size(115, 24);
            this.MashTempUpper_cbox.TabIndex = 44;
            this.MashTempUpper_cbox.Text = "Upper Range";
            this.MashTempUpper_cbox.SelectedIndexChanged += new System.EventHandler(this.MashTempUpper_cbox_SelectedIndexChanged);
            // 
            // MashTempLower_cbox
            // 
            this.MashTempLower_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MashTempLower_cbox.FormattingEnabled = true;
            this.MashTempLower_cbox.Items.AddRange(new object[] {
            "140",
            "142",
            "144",
            "146",
            "148",
            "150",
            "152",
            "154",
            "156",
            "158",
            "160"});
            this.MashTempLower_cbox.Location = new System.Drawing.Point(60, 264);
            this.MashTempLower_cbox.Name = "MashTempLower_cbox";
            this.MashTempLower_cbox.Size = new System.Drawing.Size(115, 24);
            this.MashTempLower_cbox.TabIndex = 43;
            this.MashTempLower_cbox.Text = "Lower Range";
            this.MashTempLower_cbox.SelectedIndexChanged += new System.EventHandler(this.MashTempLower_cbox_SelectedIndexChanged);
            // 
            // MashTempRange_lbl
            // 
            this.MashTempRange_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MashTempRange_lbl.Location = new System.Drawing.Point(76, 208);
            this.MashTempRange_lbl.Name = "MashTempRange_lbl";
            this.MashTempRange_lbl.Size = new System.Drawing.Size(210, 32);
            this.MashTempRange_lbl.TabIndex = 42;
            this.MashTempRange_lbl.Text = "Mash Temperature \r\nRange (deg F)";
            this.MashTempRange_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StrikeTempTarget_lbl
            // 
            this.StrikeTempTarget_lbl.AutoSize = true;
            this.StrikeTempTarget_lbl.Location = new System.Drawing.Point(347, 231);
            this.StrikeTempTarget_lbl.Name = "StrikeTempTarget_lbl";
            this.StrikeTempTarget_lbl.Size = new System.Drawing.Size(197, 16);
            this.StrikeTempTarget_lbl.TabIndex = 45;
            this.StrikeTempTarget_lbl.Text = "Strike Water Temp (Target)";
            // 
            // StrikeTempTarget_cbox
            // 
            this.StrikeTempTarget_cbox.FormattingEnabled = true;
            this.StrikeTempTarget_cbox.Items.AddRange(new object[] {
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170"});
            this.StrikeTempTarget_cbox.Location = new System.Drawing.Point(363, 265);
            this.StrikeTempTarget_cbox.Name = "StrikeTempTarget_cbox";
            this.StrikeTempTarget_cbox.Size = new System.Drawing.Size(147, 24);
            this.StrikeTempTarget_cbox.TabIndex = 46;
            // 
            // MashTime_lbl
            // 
            this.MashTime_lbl.AutoSize = true;
            this.MashTime_lbl.Location = new System.Drawing.Point(590, 231);
            this.MashTime_lbl.Name = "MashTime_lbl";
            this.MashTime_lbl.Size = new System.Drawing.Size(122, 16);
            this.MashTime_lbl.TabIndex = 47;
            this.MashTime_lbl.Text = "Mash Time (min)";
            // 
            // MashTime_cbox
            // 
            this.MashTime_cbox.FormattingEnabled = true;
            this.MashTime_cbox.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90"});
            this.MashTime_cbox.Location = new System.Drawing.Point(598, 265);
            this.MashTime_cbox.Name = "MashTime_cbox";
            this.MashTime_cbox.Size = new System.Drawing.Size(105, 24);
            this.MashTime_cbox.TabIndex = 48;
            this.MashTime_cbox.SelectedIndexChanged += new System.EventHandler(this.MashTime_cbox_SelectedIndexChanged);
            // 
            // MashTempActual_lbl
            // 
            this.MashTempActual_lbl.AutoSize = true;
            this.MashTempActual_lbl.Location = new System.Drawing.Point(76, 331);
            this.MashTempActual_lbl.Name = "MashTempActual_lbl";
            this.MashTempActual_lbl.Size = new System.Drawing.Size(146, 16);
            this.MashTempActual_lbl.TabIndex = 49;
            this.MashTempActual_lbl.Text = "Mash Temp (Actual)";
            // 
            // MashTempActual_cbox
            // 
            this.MashTempActual_cbox.FormattingEnabled = true;
            this.MashTempActual_cbox.Items.AddRange(new object[] {
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160"});
            this.MashTempActual_cbox.Location = new System.Drawing.Point(228, 328);
            this.MashTempActual_cbox.Name = "MashTempActual_cbox";
            this.MashTempActual_cbox.Size = new System.Drawing.Size(116, 24);
            this.MashTempActual_cbox.TabIndex = 50;
            this.MashTempActual_cbox.SelectedIndexChanged += new System.EventHandler(this.MashTempActual_cbox_SelectedIndexChanged);
            // 
            // StrikeTempActual_lbl
            // 
            this.StrikeTempActual_lbl.AutoSize = true;
            this.StrikeTempActual_lbl.Location = new System.Drawing.Point(386, 331);
            this.StrikeTempActual_lbl.Name = "StrikeTempActual_lbl";
            this.StrikeTempActual_lbl.Size = new System.Drawing.Size(194, 16);
            this.StrikeTempActual_lbl.TabIndex = 51;
            this.StrikeTempActual_lbl.Text = "Strike Water Temp (Actual)";
            // 
            // StrikeTempActual_cbox
            // 
            this.StrikeTempActual_cbox.FormattingEnabled = true;
            this.StrikeTempActual_cbox.Items.AddRange(new object[] {
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170"});
            this.StrikeTempActual_cbox.Location = new System.Drawing.Point(586, 328);
            this.StrikeTempActual_cbox.Name = "StrikeTempActual_cbox";
            this.StrikeTempActual_cbox.Size = new System.Drawing.Size(119, 24);
            this.StrikeTempActual_cbox.TabIndex = 52;
            this.StrikeTempActual_cbox.SelectedIndexChanged += new System.EventHandler(this.StrikeTempActual_cbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Lauter (1):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Pot diameter (in)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Liquid height in pot (in)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "1st Runnings Actual (qt)";
            // 
            // PotDiameter_tbox
            // 
            this.PotDiameter_tbox.Location = new System.Drawing.Point(146, 427);
            this.PotDiameter_tbox.Name = "PotDiameter_tbox";
            this.PotDiameter_tbox.Size = new System.Drawing.Size(75, 22);
            this.PotDiameter_tbox.TabIndex = 58;
            this.PotDiameter_tbox.TextChanged += new System.EventHandler(this.PotDiameter_tbox_TextChanged);
            // 
            // LiquidHeight_tbox
            // 
            this.LiquidHeight_tbox.Location = new System.Drawing.Point(309, 427);
            this.LiquidHeight_tbox.Name = "LiquidHeight_tbox";
            this.LiquidHeight_tbox.Size = new System.Drawing.Size(75, 22);
            this.LiquidHeight_tbox.TabIndex = 59;
            this.LiquidHeight_tbox.TextChanged += new System.EventHandler(this.LiquidHeight_tbox_TextChanged);
            // 
            // FirstLauter_tbox
            // 
            this.FirstLauter_tbox.Location = new System.Drawing.Point(628, 427);
            this.FirstLauter_tbox.Name = "FirstLauter_tbox";
            this.FirstLauter_tbox.Size = new System.Drawing.Size(84, 22);
            this.FirstLauter_tbox.TabIndex = 60;
            // 
            // CalcLauter1_btn
            // 
            this.CalcLauter1_btn.Location = new System.Drawing.Point(460, 421);
            this.CalcLauter1_btn.Name = "CalcLauter1_btn";
            this.CalcLauter1_btn.Size = new System.Drawing.Size(97, 34);
            this.CalcLauter1_btn.TabIndex = 61;
            this.CalcLauter1_btn.Text = "Calculate";
            this.CalcLauter1_btn.UseVisualStyleBackColor = true;
            this.CalcLauter1_btn.Click += new System.EventHandler(this.CalcLauter1_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "Sparge:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Sparge Water Temp = 173 deg F";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Sparge Water Volume (qt)";
            // 
            // SpargeVolume_tbox
            // 
            this.SpargeVolume_tbox.Location = new System.Drawing.Point(617, 503);
            this.SpargeVolume_tbox.Name = "SpargeVolume_tbox";
            this.SpargeVolume_tbox.Size = new System.Drawing.Size(113, 22);
            this.SpargeVolume_tbox.TabIndex = 65;
            // 
            // WortVolumeCalc_btn
            // 
            this.WortVolumeCalc_btn.Location = new System.Drawing.Point(460, 599);
            this.WortVolumeCalc_btn.Name = "WortVolumeCalc_btn";
            this.WortVolumeCalc_btn.Size = new System.Drawing.Size(97, 34);
            this.WortVolumeCalc_btn.TabIndex = 73;
            this.WortVolumeCalc_btn.Text = "Calculate";
            this.WortVolumeCalc_btn.UseVisualStyleBackColor = true;
            this.WortVolumeCalc_btn.Click += new System.EventHandler(this.WortVolumeCalc_btn_Click);
            // 
            // WortVolume_tbox
            // 
            this.WortVolume_tbox.Location = new System.Drawing.Point(628, 605);
            this.WortVolume_tbox.Name = "WortVolume_tbox";
            this.WortVolume_tbox.Size = new System.Drawing.Size(84, 22);
            this.WortVolume_tbox.TabIndex = 72;
            // 
            // Lauter2Height_tbox
            // 
            this.Lauter2Height_tbox.Location = new System.Drawing.Point(309, 605);
            this.Lauter2Height_tbox.Name = "Lauter2Height_tbox";
            this.Lauter2Height_tbox.Size = new System.Drawing.Size(75, 22);
            this.Lauter2Height_tbox.TabIndex = 71;
            this.Lauter2Height_tbox.TextChanged += new System.EventHandler(this.Lauter2Height_tbox_TextChanged);
            // 
            // WortVolume_lbl
            // 
            this.WortVolume_lbl.AutoSize = true;
            this.WortVolume_lbl.Location = new System.Drawing.Point(614, 576);
            this.WortVolume_lbl.Name = "WortVolume_lbl";
            this.WortVolume_lbl.Size = new System.Drawing.Size(123, 16);
            this.WortVolume_lbl.TabIndex = 69;
            this.WortVolume_lbl.Text = "Wort Volume (qt)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Liquid height in pot (in)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 24);
            this.label13.TabIndex = 66;
            this.label13.Text = "Lauter (2):";
            // 
            // MashLauterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 689);
            this.Controls.Add(this.WortVolumeCalc_btn);
            this.Controls.Add(this.WortVolume_tbox);
            this.Controls.Add(this.Lauter2Height_tbox);
            this.Controls.Add(this.WortVolume_lbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SpargeVolume_tbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalcLauter1_btn);
            this.Controls.Add(this.FirstLauter_tbox);
            this.Controls.Add(this.LiquidHeight_tbox);
            this.Controls.Add(this.PotDiameter_tbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StrikeTempActual_cbox);
            this.Controls.Add(this.StrikeTempActual_lbl);
            this.Controls.Add(this.MashTempActual_cbox);
            this.Controls.Add(this.MashTempActual_lbl);
            this.Controls.Add(this.MashTime_cbox);
            this.Controls.Add(this.MashTime_lbl);
            this.Controls.Add(this.StrikeTempTarget_cbox);
            this.Controls.Add(this.StrikeTempTarget_lbl);
            this.Controls.Add(this.MashTempUpper_cbox);
            this.Controls.Add(this.MashTempLower_cbox);
            this.Controls.Add(this.MashTempRange_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StrikeWaterVol_tbox);
            this.Controls.Add(this.StrikeWaterVol_lbl);
            this.Controls.Add(this.FirstRunnings_tbox);
            this.Controls.Add(this.FirstRunnings_lbl);
            this.Controls.Add(this.GrainBill_tbox);
            this.Controls.Add(this.GrainBill_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MultiRest_btn);
            this.Controls.Add(this.DecoctionMash_btn);
            this.Controls.Add(this.SingleRest_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MashLauterForm";
            this.Text = "MashLauterForm";
            this.Load += new System.EventHandler(this.MashLauterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingleRest_btn;
        private System.Windows.Forms.Button DecoctionMash_btn;
        private System.Windows.Forms.Button MultiRest_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GrainBill_lbl;
        private System.Windows.Forms.TextBox GrainBill_tbox;
        private System.Windows.Forms.TextBox FirstRunnings_tbox;
        private System.Windows.Forms.Label FirstRunnings_lbl;
        private System.Windows.Forms.TextBox StrikeWaterVol_tbox;
        private System.Windows.Forms.Label StrikeWaterVol_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MashTempUpper_cbox;
        private System.Windows.Forms.ComboBox MashTempLower_cbox;
        private System.Windows.Forms.Label MashTempRange_lbl;
        private System.Windows.Forms.Label StrikeTempTarget_lbl;
        private System.Windows.Forms.ComboBox StrikeTempTarget_cbox;
        private System.Windows.Forms.Label MashTime_lbl;
        private System.Windows.Forms.ComboBox MashTime_cbox;
        private System.Windows.Forms.Label MashTempActual_lbl;
        private System.Windows.Forms.ComboBox MashTempActual_cbox;
        private System.Windows.Forms.Label StrikeTempActual_lbl;
        private System.Windows.Forms.ComboBox StrikeTempActual_cbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PotDiameter_tbox;
        private System.Windows.Forms.TextBox LiquidHeight_tbox;
        private System.Windows.Forms.TextBox FirstLauter_tbox;
        private System.Windows.Forms.Button CalcLauter1_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SpargeVolume_tbox;
        private System.Windows.Forms.Button WortVolumeCalc_btn;
        private System.Windows.Forms.TextBox WortVolume_tbox;
        private System.Windows.Forms.TextBox Lauter2Height_tbox;
        private System.Windows.Forms.Label WortVolume_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}