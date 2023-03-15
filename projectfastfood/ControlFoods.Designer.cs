namespace projectfastfood
{
    partial class ControlFoods
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.roundImage = new projectfastfood.RoundPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblnumber);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblbalance);
            this.panel1.Controls.Add(this.roundImage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 144);
            this.panel1.TabIndex = 0;
            // 
            // lblnumber
            // 
            this.lblnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumber.AutoSize = true;
            this.lblnumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(305, 13);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(79, 20);
            this.lblnumber.TabIndex = 1;
            this.lblnumber.Text = "2023001";
            this.lblnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(315, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 20);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "ชุดรวม";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblbalance
            // 
            this.lblbalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbalance.AutoSize = true;
            this.lblbalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(303, 107);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(73, 20);
            this.lblbalance.TabIndex = 3;
            this.lblbalance.Text = "50.00 ฿";
            this.lblbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roundImage
            // 
            this.roundImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundImage.Image = global::projectfastfood.Properties.Resources._11701496_4771105;
            this.roundImage.Location = new System.Drawing.Point(3, 3);
            this.roundImage.Name = "roundImage";
            this.roundImage.Size = new System.Drawing.Size(148, 136);
            this.roundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundImage.TabIndex = 0;
            this.roundImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControlFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ControlFoods";
            this.Size = new System.Drawing.Size(399, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundPictureBox roundImage;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Button button1;
    }
}
