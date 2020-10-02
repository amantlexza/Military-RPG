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
            this.dgvToDB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFromDB
            // 
            this.dgvFromDB.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFromDB.Location = new System.Drawing.Point(276, 115);
            this.dgvFromDB.Name = "dgvFromDB";
            this.dgvFromDB.Size = new System.Drawing.Size(246, 246);
            this.dgvFromDB.TabIndex = 0;
            this.dgvFromDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvToDB
            // 
            this.dgvToDB.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvToDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToDB.Location = new System.Drawing.Point(12, 115);
            this.dgvToDB.Name = "dgvToDB";
            this.dgvToDB.Size = new System.Drawing.Size(247, 246);
            this.dgvToDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the list below to select as much ammo as you\'d like";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save And Continue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(178, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ammunition";
            // 
            // AmmunitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvToDB);
            this.Controls.Add(this.dgvFromDB);
            this.Name = "AmmunitionForm";
            this.Text = "Ammunition";
            this.Load += new System.EventHandler(this.AmmunitionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFromDB;
        private System.Windows.Forms.DataGridView dgvToDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}