namespace AlcoholMaker
{
    partial class FermBottlingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AerationYes_btn = new System.Windows.Forms.Button();
            this.AerationNo_btn = new System.Windows.Forms.Button();
            this.Duration_lbl = new System.Windows.Forms.Label();
            this.AerationDuration_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.FinalGravity_tbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.FinalGravTempCorrect_btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.FinalGravTemp_tbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.FinalGravReading_cbox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ABV_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AA_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CalcABV_btn = new System.Windows.Forms.Button();
            this.LoadBottleData_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BottleType_tbox = new System.Windows.Forms.TextBox();
            this.BottleVolume_tbox = new System.Windows.Forms.TextBox();
            this.BatchVolume_tbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BottlesNeeded_tbox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BottlesFilled_tbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.AddFermTemp_btn = new System.Windows.Forms.Button();
            this.NewFermList_btn = new System.Windows.Forms.Button();
            this.FermDay_cbox = new System.Windows.Forms.ComboBox();
            this.FermTemp_cbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fermentation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bottling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aeration?";
            // 
            // AerationYes_btn
            // 
            this.AerationYes_btn.Location = new System.Drawing.Point(143, 62);
            this.AerationYes_btn.Name = "AerationYes_btn";
            this.AerationYes_btn.Size = new System.Drawing.Size(52, 40);
            this.AerationYes_btn.TabIndex = 3;
            this.AerationYes_btn.Text = "Yes";
            this.AerationYes_btn.UseVisualStyleBackColor = true;
            this.AerationYes_btn.Click += new System.EventHandler(this.AerationYes_btn_Click);
            // 
            // AerationNo_btn
            // 
            this.AerationNo_btn.Location = new System.Drawing.Point(213, 62);
            this.AerationNo_btn.Name = "AerationNo_btn";
            this.AerationNo_btn.Size = new System.Drawing.Size(52, 40);
            this.AerationNo_btn.TabIndex = 4;
            this.AerationNo_btn.Text = "No";
            this.AerationNo_btn.UseVisualStyleBackColor = true;
            this.AerationNo_btn.Click += new System.EventHandler(this.AerationNo_btn_Click);
            // 
            // Duration_lbl
            // 
            this.Duration_lbl.AutoSize = true;
            this.Duration_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_lbl.Location = new System.Drawing.Point(335, 71);
            this.Duration_lbl.Name = "Duration_lbl";
            this.Duration_lbl.Size = new System.Drawing.Size(78, 20);
            this.Duration_lbl.TabIndex = 5;
            this.Duration_lbl.Text = "Duration";
            // 
            // AerationDuration_tbox
            // 
            this.AerationDuration_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AerationDuration_tbox.Location = new System.Drawing.Point(419, 71);
            this.AerationDuration_tbox.Name = "AerationDuration_tbox";
            this.AerationDuration_tbox.Size = new System.Drawing.Size(74, 22);
            this.AerationDuration_tbox.TabIndex = 6;
            this.AerationDuration_tbox.TextChanged += new System.EventHandler(this.AerationDuration_tbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "minutes";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(543, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 16);
            this.label22.TabIndex = 51;
            this.label22.Text = "Wort Gravity (OG)";
            // 
            // FinalGravity_tbox
            // 
            this.FinalGravity_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalGravity_tbox.Location = new System.Drawing.Point(568, 312);
            this.FinalGravity_tbox.Name = "FinalGravity_tbox";
            this.FinalGravity_tbox.Size = new System.Drawing.Size(84, 22);
            this.FinalGravity_tbox.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(659, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "at 60 deg F";
            // 
            // FinalGravTempCorrect_btn
            // 
            this.FinalGravTempCorrect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinalGravTempCorrect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalGravTempCorrect_btn.Location = new System.Drawing.Point(447, 283);
            this.FinalGravTempCorrect_btn.Name = "FinalGravTempCorrect_btn";
            this.FinalGravTempCorrect_btn.Size = new System.Drawing.Size(79, 59);
            this.FinalGravTempCorrect_btn.TabIndex = 48;
            this.FinalGravTempCorrect_btn.Text = "Temp Correct";
            this.FinalGravTempCorrect_btn.UseVisualStyleBackColor = true;
            this.FinalGravTempCorrect_btn.Click += new System.EventHandler(this.FinalGravTempCorrect_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(321, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "Temp (deg F)";
            // 
            // FinalGravTemp_tbox
            // 
            this.FinalGravTemp_tbox.Location = new System.Drawing.Point(324, 312);
            this.FinalGravTemp_tbox.Name = "FinalGravTemp_tbox";
            this.FinalGravTemp_tbox.Size = new System.Drawing.Size(82, 20);
            this.FinalGravTemp_tbox.TabIndex = 46;
            this.FinalGravTemp_tbox.TextChanged += new System.EventHandler(this.FinalGravTemp_tbox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(279, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "at";
            // 
            // FinalGravReading_cbox
            // 
            this.FinalGravReading_cbox.FormattingEnabled = true;
            this.FinalGravReading_cbox.Items.AddRange(new object[] {
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
            this.FinalGravReading_cbox.Location = new System.Drawing.Point(159, 311);
            this.FinalGravReading_cbox.Name = "FinalGravReading_cbox";
            this.FinalGravReading_cbox.Size = new System.Drawing.Size(95, 21);
            this.FinalGravReading_cbox.TabIndex = 44;
            this.FinalGravReading_cbox.SelectedIndexChanged += new System.EventHandler(this.FinalGravReading_cbox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(138, 283);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "Hydrometer Reading";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 312);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "Final Gravity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "%";
            // 
            // ABV_tbox
            // 
            this.ABV_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABV_tbox.Location = new System.Drawing.Point(250, 391);
            this.ABV_tbox.Name = "ABV_tbox";
            this.ABV_tbox.Size = new System.Drawing.Size(74, 22);
            this.ABV_tbox.TabIndex = 53;
            this.ABV_tbox.TextChanged += new System.EventHandler(this.ABV_tbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "ABV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(659, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "%";
            // 
            // AA_tbox
            // 
            this.AA_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AA_tbox.Location = new System.Drawing.Point(578, 393);
            this.AA_tbox.Name = "AA_tbox";
            this.AA_tbox.Size = new System.Drawing.Size(74, 22);
            this.AA_tbox.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Apparent Attenuation";
            // 
            // CalcABV_btn
            // 
            this.CalcABV_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcABV_btn.Location = new System.Drawing.Point(41, 378);
            this.CalcABV_btn.Name = "CalcABV_btn";
            this.CalcABV_btn.Size = new System.Drawing.Size(92, 48);
            this.CalcABV_btn.TabIndex = 58;
            this.CalcABV_btn.Text = "Calc ABV/ AA";
            this.CalcABV_btn.UseVisualStyleBackColor = true;
            this.CalcABV_btn.Click += new System.EventHandler(this.CalcABV_btn_Click);
            // 
            // LoadBottleData_btn
            // 
            this.LoadBottleData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBottleData_btn.Location = new System.Drawing.Point(41, 462);
            this.LoadBottleData_btn.Name = "LoadBottleData_btn";
            this.LoadBottleData_btn.Size = new System.Drawing.Size(92, 54);
            this.LoadBottleData_btn.TabIndex = 59;
            this.LoadBottleData_btn.Text = "Load Bottle Data";
            this.LoadBottleData_btn.UseVisualStyleBackColor = true;
            this.LoadBottleData_btn.Click += new System.EventHandler(this.LoadBottleData_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = "Volume";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(488, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 18);
            this.label11.TabIndex = 62;
            this.label11.Text = "oz";
            // 
            // BottleType_tbox
            // 
            this.BottleType_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottleType_tbox.Location = new System.Drawing.Point(199, 481);
            this.BottleType_tbox.Name = "BottleType_tbox";
            this.BottleType_tbox.Size = new System.Drawing.Size(147, 22);
            this.BottleType_tbox.TabIndex = 63;
            // 
            // BottleVolume_tbox
            // 
            this.BottleVolume_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottleVolume_tbox.Location = new System.Drawing.Point(436, 481);
            this.BottleVolume_tbox.Name = "BottleVolume_tbox";
            this.BottleVolume_tbox.Size = new System.Drawing.Size(48, 22);
            this.BottleVolume_tbox.TabIndex = 64;
            // 
            // BatchVolume_tbox
            // 
            this.BatchVolume_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchVolume_tbox.Location = new System.Drawing.Point(655, 481);
            this.BatchVolume_tbox.Name = "BatchVolume_tbox";
            this.BatchVolume_tbox.Size = new System.Drawing.Size(70, 22);
            this.BatchVolume_tbox.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(726, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 18);
            this.label12.TabIndex = 66;
            this.label12.Text = "oz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(540, 479);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 18);
            this.label13.TabIndex = 65;
            this.label13.Text = "Batch Volume";
            // 
            // BottlesNeeded_tbox
            // 
            this.BottlesNeeded_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottlesNeeded_tbox.Location = new System.Drawing.Point(282, 578);
            this.BottlesNeeded_tbox.Name = "BottlesNeeded_tbox";
            this.BottlesNeeded_tbox.Size = new System.Drawing.Size(48, 22);
            this.BottlesNeeded_tbox.TabIndex = 70;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(145, 579);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 18);
            this.label20.TabIndex = 68;
            this.label20.Text = "Bottles Needed";
            // 
            // BottlesFilled_tbox
            // 
            this.BottlesFilled_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottlesFilled_tbox.Location = new System.Drawing.Point(552, 578);
            this.BottlesFilled_tbox.Name = "BottlesFilled_tbox";
            this.BottlesFilled_tbox.Size = new System.Drawing.Size(48, 22);
            this.BottlesFilled_tbox.TabIndex = 72;
            this.BottlesFilled_tbox.TextChanged += new System.EventHandler(this.BottlesFilled_tbox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(433, 579);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 18);
            this.label14.TabIndex = 71;
            this.label14.Text = "Bottles Filled";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(166, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 18);
            this.label21.TabIndex = 73;
            this.label21.Text = "Day";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(324, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 18);
            this.label23.TabIndex = 75;
            this.label23.Text = "Temp";
            // 
            // AddFermTemp_btn
            // 
            this.AddFermTemp_btn.Location = new System.Drawing.Point(472, 164);
            this.AddFermTemp_btn.Name = "AddFermTemp_btn";
            this.AddFermTemp_btn.Size = new System.Drawing.Size(70, 39);
            this.AddFermTemp_btn.TabIndex = 77;
            this.AddFermTemp_btn.Text = "ADD";
            this.AddFermTemp_btn.UseVisualStyleBackColor = true;
            this.AddFermTemp_btn.Click += new System.EventHandler(this.AddFermTemp_btn_Click);
            // 
            // NewFermList_btn
            // 
            this.NewFermList_btn.Location = new System.Drawing.Point(57, 142);
            this.NewFermList_btn.Name = "NewFermList_btn";
            this.NewFermList_btn.Size = new System.Drawing.Size(135, 22);
            this.NewFermList_btn.TabIndex = 78;
            this.NewFermList_btn.Text = "New Fermentation List";
            this.NewFermList_btn.UseVisualStyleBackColor = true;
            this.NewFermList_btn.Click += new System.EventHandler(this.NewFermList_btn_Click);
            // 
            // FermDay_cbox
            // 
            this.FermDay_cbox.FormattingEnabled = true;
            this.FermDay_cbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.FermDay_cbox.Location = new System.Drawing.Point(213, 174);
            this.FermDay_cbox.Name = "FermDay_cbox";
            this.FermDay_cbox.Size = new System.Drawing.Size(57, 21);
            this.FermDay_cbox.TabIndex = 79;
            this.FermDay_cbox.SelectedIndexChanged += new System.EventHandler(this.FermDay_cbox_SelectedIndexChanged);
            // 
            // FermTemp_cbox
            // 
            this.FermTemp_cbox.FormattingEnabled = true;
            this.FermTemp_cbox.Items.AddRange(new object[] {
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.FermTemp_cbox.Location = new System.Drawing.Point(380, 174);
            this.FermTemp_cbox.Name = "FermTemp_cbox";
            this.FermTemp_cbox.Size = new System.Drawing.Size(68, 21);
            this.FermTemp_cbox.TabIndex = 80;
            this.FermTemp_cbox.SelectedIndexChanged += new System.EventHandler(this.FermTemp_cbox_SelectedIndexChanged);
            // 
            // FermBottlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 656);
            this.Controls.Add(this.FermTemp_cbox);
            this.Controls.Add(this.FermDay_cbox);
            this.Controls.Add(this.NewFermList_btn);
            this.Controls.Add(this.AddFermTemp_btn);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.BottlesFilled_tbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BottlesNeeded_tbox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.BatchVolume_tbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BottleVolume_tbox);
            this.Controls.Add(this.BottleType_tbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LoadBottleData_btn);
            this.Controls.Add(this.CalcABV_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AA_tbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ABV_tbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.FinalGravity_tbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.FinalGravTempCorrect_btn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.FinalGravTemp_tbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.FinalGravReading_cbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AerationDuration_tbox);
            this.Controls.Add(this.Duration_lbl);
            this.Controls.Add(this.AerationNo_btn);
            this.Controls.Add(this.AerationYes_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FermBottlingForm";
            this.Text = "FermBottlingForm";
            this.Load += new System.EventHandler(this.FermBottlingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AerationYes_btn;
        private System.Windows.Forms.Button AerationNo_btn;
        private System.Windows.Forms.Label Duration_lbl;
        private System.Windows.Forms.TextBox AerationDuration_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox FinalGravity_tbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button FinalGravTempCorrect_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FinalGravTemp_tbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox FinalGravReading_cbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ABV_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AA_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CalcABV_btn;
        private System.Windows.Forms.Button LoadBottleData_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BottleType_tbox;
        private System.Windows.Forms.TextBox BottleVolume_tbox;
        private System.Windows.Forms.TextBox BatchVolume_tbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BottlesNeeded_tbox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox BottlesFilled_tbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button AddFermTemp_btn;
        private System.Windows.Forms.Button NewFermList_btn;
        private System.Windows.Forms.ComboBox FermDay_cbox;
        private System.Windows.Forms.ComboBox FermTemp_cbox;
    }
}