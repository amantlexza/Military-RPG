namespace Military_RPG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plane = new System.Windows.Forms.PictureBox();
            this.militaryBase = new System.Windows.Forms.PictureBox();
            this.enemySquad = new System.Windows.Forms.PictureBox();
            this.enemyCamp = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySquad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // plane
            // 
            this.plane.Image = ((System.Drawing.Image)(resources.GetObject("plane.Image")));
            this.plane.Location = new System.Drawing.Point(146, 367);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(93, 72);
            this.plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plane.TabIndex = 0;
            this.plane.TabStop = false;
            // 
            // militaryBase
            // 
            this.militaryBase.Image = ((System.Drawing.Image)(resources.GetObject("militaryBase.Image")));
            this.militaryBase.Location = new System.Drawing.Point(332, 58);
            this.militaryBase.Name = "militaryBase";
            this.militaryBase.Size = new System.Drawing.Size(93, 72);
            this.militaryBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.militaryBase.TabIndex = 1;
            this.militaryBase.TabStop = false;
            // 
            // enemySquad
            // 
            this.enemySquad.Image = ((System.Drawing.Image)(resources.GetObject("enemySquad.Image")));
            this.enemySquad.Location = new System.Drawing.Point(161, 171);
            this.enemySquad.Name = "enemySquad";
            this.enemySquad.Size = new System.Drawing.Size(93, 72);
            this.enemySquad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemySquad.TabIndex = 2;
            this.enemySquad.TabStop = false;
            // 
            // enemyCamp
            // 
            this.enemyCamp.Image = ((System.Drawing.Image)(resources.GetObject("enemyCamp.Image")));
            this.enemyCamp.Location = new System.Drawing.Point(332, 225);
            this.enemyCamp.Name = "enemyCamp";
            this.enemyCamp.Size = new System.Drawing.Size(93, 72);
            this.enemyCamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyCamp.TabIndex = 3;
            this.enemyCamp.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 506);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.enemyCamp);
            this.Controls.Add(this.enemySquad);
            this.Controls.Add(this.militaryBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySquad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.PictureBox militaryBase;
        private System.Windows.Forms.PictureBox enemySquad;
        private System.Windows.Forms.PictureBox enemyCamp;
        private System.Windows.Forms.Timer timer1;
    }
}

