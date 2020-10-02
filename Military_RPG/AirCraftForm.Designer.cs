namespace Military_RPG
{
    partial class AirCraftForm
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
            this.dgvFromDB = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.airCraftLbl = new System.Windows.Forms.Label();
            this.fuelLbl = new System.Windows.Forms.Label();
            this.altitudeLbl = new System.Windows.Forms.Label();
            this.speedLbl = new System.Windows.Forms.Label();
            this.maxWeightLbl = new System.Windows.Forms.Label();
            this.airCraftTypeLbl = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFromDB
            // 
            this.dgvFromDB.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFromDB.Location = new System.Drawing.Point(11, 114);
            this.dgvFromDB.Name = "dgvFromDB";
            this.dgvFromDB.Size = new System.Drawing.Size(781, 199);
            this.dgvFromDB.TabIndex = 0;
            this.dgvFromDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFromDB_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(328, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aircraft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(281, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on a datacell to select a craft ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aircraft ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Max Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(644, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Aircraft Type";
            // 
            // airCraftLbl
            // 
            this.airCraftLbl.AutoSize = true;
            this.airCraftLbl.Location = new System.Drawing.Point(16, 381);
            this.airCraftLbl.Name = "airCraftLbl";
            this.airCraftLbl.Size = new System.Drawing.Size(0, 13);
            this.airCraftLbl.TabIndex = 14;
            // 
            // fuelLbl
            // 
            this.fuelLbl.AutoSize = true;
            this.fuelLbl.Location = new System.Drawing.Point(105, 381);
            this.fuelLbl.Name = "fuelLbl";
            this.fuelLbl.Size = new System.Drawing.Size(0, 13);
            this.fuelLbl.TabIndex = 15;
            // 
            // altitudeLbl
            // 
            this.altitudeLbl.AutoSize = true;
            this.altitudeLbl.Location = new System.Drawing.Point(209, 381);
            this.altitudeLbl.Name = "altitudeLbl";
            this.altitudeLbl.Size = new System.Drawing.Size(0, 13);
            this.altitudeLbl.TabIndex = 17;
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(319, 381);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(0, 13);
            this.speedLbl.TabIndex = 18;
            // 
            // maxWeightLbl
            // 
            this.maxWeightLbl.AutoSize = true;
            this.maxWeightLbl.Location = new System.Drawing.Point(450, 381);
            this.maxWeightLbl.Name = "maxWeightLbl";
            this.maxWeightLbl.Size = new System.Drawing.Size(0, 13);
            this.maxWeightLbl.TabIndex = 19;
            // 
            // airCraftTypeLbl
            // 
            this.airCraftTypeLbl.AutoSize = true;
            this.airCraftTypeLbl.Location = new System.Drawing.Point(644, 381);
            this.airCraftTypeLbl.Name = "airCraftTypeLbl";
            this.airCraftTypeLbl.Size = new System.Drawing.Size(0, 13);
            this.airCraftTypeLbl.TabIndex = 20;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(647, 441);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(132, 40);
            this.SubmitBtn.TabIndex = 21;
            this.SubmitBtn.Text = "Confirm and Continue";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(505, 439);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(136, 44);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // AirCraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(804, 502);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.airCraftTypeLbl);
            this.Controls.Add(this.maxWeightLbl);
            this.Controls.Add(this.speedLbl);
            this.Controls.Add(this.altitudeLbl);
            this.Controls.Add(this.fuelLbl);
            this.Controls.Add(this.airCraftLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFromDB);
            this.Name = "AirCraftForm";
            this.Text = "AirCraft";
            this.Load += new System.EventHandler(this.AirCraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFromDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label airCraftLbl;
        private System.Windows.Forms.Label fuelLbl;
        private System.Windows.Forms.Label altitudeLbl;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.Label maxWeightLbl;
        private System.Windows.Forms.Label airCraftTypeLbl;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}