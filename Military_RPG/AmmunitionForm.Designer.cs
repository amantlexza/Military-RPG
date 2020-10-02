namespace Military_RPG
{
    partial class AmmunitionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.typeLbl = new System.Windows.Forms.Label();
            this.AmmunitionText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFromDB
            // 
            this.dgvFromDB.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFromDB.Location = new System.Drawing.Point(12, 111);
            this.dgvFromDB.Name = "dgvFromDB";
            this.dgvFromDB.Size = new System.Drawing.Size(420, 316);
            this.dgvFromDB.TabIndex = 0;
            this.dgvFromDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFromDB_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(153, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the list below to select as much ammo as you\'d like";
            // 
            // ContBtn
            // 
            this.ContBtn.Location = new System.Drawing.Point(536, 323);
            this.ContBtn.Name = "ContBtn";
            this.ContBtn.Size = new System.Drawing.Size(136, 44);
            this.ContBtn.TabIndex = 3;
            this.ContBtn.Text = "Save And Continue";
            this.ContBtn.UseVisualStyleBackColor = true;
            this.ContBtn.Click += new System.EventHandler(this.ContBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(291, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ammunition";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(536, 260);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(136, 44);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add to Craft";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(467, 156);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(0, 13);
            this.typeLbl.TabIndex = 6;
            // 
            // AmmunitionText
            // 
            this.AmmunitionText.AutoSize = true;
            this.AmmunitionText.Location = new System.Drawing.Point(597, 156);
            this.AmmunitionText.Name = "AmmunitionText";
            this.AmmunitionText.Size = new System.Drawing.Size(0, 13);
            this.AmmunitionText.TabIndex = 7;
            // 
            // AmmunitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(804, 502);
            this.Controls.Add(this.AmmunitionText);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFromDB);
            this.Name = "AmmunitionForm";
            this.Text = "Ammunition";
            this.Load += new System.EventHandler(this.AmmunitionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFromDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label AmmunitionText;
    }
}