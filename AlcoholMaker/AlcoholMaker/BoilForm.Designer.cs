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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
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
            // BoilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 659);
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
    }
}