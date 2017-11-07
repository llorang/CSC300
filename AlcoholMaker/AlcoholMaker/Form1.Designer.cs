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
            this.lbl_SelectType = new System.Windows.Forms.Label();
            this.cb_TypeList = new System.Windows.Forms.ComboBox();
            this.btn_ChooseType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SelectType
            // 
            this.lbl_SelectType.AutoSize = true;
            this.lbl_SelectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectType.Location = new System.Drawing.Point(35, 23);
            this.lbl_SelectType.Name = "lbl_SelectType";
            this.lbl_SelectType.Size = new System.Drawing.Size(170, 20);
            this.lbl_SelectType.TabIndex = 0;
            this.lbl_SelectType.Text = "Select Product Type";
            // 
            // cb_TypeList
            // 
            this.cb_TypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TypeList.FormattingEnabled = true;
            this.cb_TypeList.Items.AddRange(new object[] {
            "Beer",
            "Cider",
            "Mead",
            "Wine"});
            this.cb_TypeList.Location = new System.Drawing.Point(40, 46);
            this.cb_TypeList.Name = "cb_TypeList";
            this.cb_TypeList.Size = new System.Drawing.Size(165, 28);
            this.cb_TypeList.TabIndex = 1;
            // 
            // btn_ChooseType
            // 
            this.btn_ChooseType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseType.Location = new System.Drawing.Point(61, 80);
            this.btn_ChooseType.Name = "btn_ChooseType";
            this.btn_ChooseType.Size = new System.Drawing.Size(115, 30);
            this.btn_ChooseType.TabIndex = 2;
            this.btn_ChooseType.Text = "Choose Type";
            this.btn_ChooseType.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 542);
            this.Controls.Add(this.btn_ChooseType);
            this.Controls.Add(this.cb_TypeList);
            this.Controls.Add(this.lbl_SelectType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Beer Maker v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectType;
        private System.Windows.Forms.ComboBox cb_TypeList;
        private System.Windows.Forms.Button btn_ChooseType;
    }
}

