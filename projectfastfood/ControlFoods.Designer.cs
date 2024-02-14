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
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.roundImage = new projectfastfood.RoundPictureBox();
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 117);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblnumber
            // 
            this.lblnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumber.AutoSize = true;
            this.lblnumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(213, 10);
            this.lblnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(71, 17);
            this.lblnumber.TabIndex = 1;
            this.lblnumber.Text = "2023001";
            this.lblnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(155, 23);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblname.Size = new System.Drawing.Size(129, 31);
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
            this.lblbalance.Location = new System.Drawing.Point(220, 55);
            this.lblbalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(64, 17);
            this.lblbalance.TabIndex = 3;
            this.lblbalance.Text = "50.00 ฿";
            this.lblbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roundImage
            // 
            this.roundImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundImage.Image = global::projectfastfood.Properties.Resources._11701496_4771105;
            this.roundImage.Location = new System.Drawing.Point(2, 2);
            this.roundImage.Margin = new System.Windows.Forms.Padding(2);
            this.roundImage.Name = "roundImage";
            this.roundImage.Size = new System.Drawing.Size(112, 111);
            this.roundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundImage.TabIndex = 0;
            this.roundImage.TabStop = false;
            // 
            // ControlFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ControlFoods";
            this.Size = new System.Drawing.Size(299, 122);
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
