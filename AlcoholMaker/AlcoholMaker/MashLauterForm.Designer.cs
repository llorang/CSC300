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
            this.GrainBill_lbl.Location = new System.Drawing.Point(92, 141);
            this.GrainBill_lbl.Name = "GrainBill_lbl";
            this.GrainBill_lbl.Size = new System.Drawing.Size(98, 16);
            this.GrainBill_lbl.TabIndex = 4;
            this.GrainBill_lbl.Text = "Grain Bill (lb)";
            // 
            // GrainBill_tbox
            // 
            this.GrainBill_tbox.Location = new System.Drawing.Point(68, 171);
            this.GrainBill_tbox.Name = "GrainBill_tbox";
            this.GrainBill_tbox.Size = new System.Drawing.Size(138, 22);
            this.GrainBill_tbox.TabIndex = 5;
            // 
            // MashLauterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 752);
            this.Controls.Add(this.GrainBill_tbox);
            this.Controls.Add(this.GrainBill_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MultiRest_btn);
            this.Controls.Add(this.DecoctionMash_btn);
            this.Controls.Add(this.SingleRest_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}