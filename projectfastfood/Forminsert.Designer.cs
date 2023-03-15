namespace projectfastfood
{
    partial class Forminsert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TboxSearch = new System.Windows.Forms.TextBox();
            this.bnlFood = new System.Windows.Forms.Label();
            this.TboxOrder_name = new System.Windows.Forms.TextBox();
            this.TboxBalance = new System.Windows.Forms.TextBox();
            this.BalanceFood = new System.Windows.Forms.Label();
            this.TboxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roundPicture = new projectfastfood.RoundPictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(186, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "ADDORDERS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::projectfastfood.Properties.Resources.close1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(502, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TboxSearch
            // 
            this.TboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxSearch.Location = new System.Drawing.Point(161, 82);
            this.TboxSearch.Name = "TboxSearch";
            this.TboxSearch.Size = new System.Drawing.Size(214, 34);
            this.TboxSearch.TabIndex = 2;
            // 
            // bnlFood
            // 
            this.bnlFood.AutoSize = true;
            this.bnlFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnlFood.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bnlFood.Location = new System.Drawing.Point(234, 224);
            this.bnlFood.Name = "bnlFood";
            this.bnlFood.Size = new System.Drawing.Size(89, 32);
            this.bnlFood.TabIndex = 4;
            this.bnlFood.Text = "Name";
            // 
            // TboxOrder_name
            // 
            this.TboxOrder_name.BackColor = System.Drawing.Color.White;
            this.TboxOrder_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxOrder_name.Location = new System.Drawing.Point(240, 260);
            this.TboxOrder_name.Name = "TboxOrder_name";
            this.TboxOrder_name.Size = new System.Drawing.Size(185, 34);
            this.TboxOrder_name.TabIndex = 5;
            // 
            // TboxBalance
            // 
            this.TboxBalance.BackColor = System.Drawing.Color.White;
            this.TboxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxBalance.Location = new System.Drawing.Point(240, 337);
            this.TboxBalance.Name = "TboxBalance";
            this.TboxBalance.Size = new System.Drawing.Size(185, 34);
            this.TboxBalance.TabIndex = 7;
            // 
            // BalanceFood
            // 
            this.BalanceFood.AutoSize = true;
            this.BalanceFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceFood.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BalanceFood.Location = new System.Drawing.Point(234, 301);
            this.BalanceFood.Name = "BalanceFood";
            this.BalanceFood.Size = new System.Drawing.Size(118, 32);
            this.BalanceFood.TabIndex = 6;
            this.BalanceFood.Text = "Balance";
            // 
            // TboxNum
            // 
            this.TboxNum.BackColor = System.Drawing.Color.White;
            this.TboxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxNum.Location = new System.Drawing.Point(240, 180);
            this.TboxNum.Name = "TboxNum";
            this.TboxNum.Size = new System.Drawing.Size(185, 34);
            this.TboxNum.TabIndex = 5;
            this.TboxNum.Text = "202300";
            this.TboxNum.TextChanged += new System.EventHandler(this.TboxNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(234, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "NumberID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projectfastfood.Properties.Resources.loupe;
            this.pictureBox2.Location = new System.Drawing.Point(381, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // roundPicture
            // 
            this.roundPicture.BackColor = System.Drawing.SystemColors.Control;
            this.roundPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundPicture.Location = new System.Drawing.Point(37, 180);
            this.roundPicture.Name = "roundPicture";
            this.roundPicture.Size = new System.Drawing.Size(180, 180);
            this.roundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicture.TabIndex = 11;
            this.roundPicture.TabStop = false;
            this.roundPicture.Click += new System.EventHandler(this.roundPicture_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.BackgroundImage = global::projectfastfood.Properties.Resources.delete__2_;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(344, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 53);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.BackgroundImage = global::projectfastfood.Properties.Resources.edit__1_;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(249, 399);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 53);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::projectfastfood.Properties.Resources.save__1_;
            this.btnSave.Location = new System.Drawing.Point(162, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 53);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Forminsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(560, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.roundPicture);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TboxBalance);
            this.Controls.Add(this.BalanceFood);
            this.Controls.Add(this.TboxNum);
            this.Controls.Add(this.TboxOrder_name);
            this.Controls.Add(this.bnlFood);
            this.Controls.Add(this.TboxSearch);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forminsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundPictureBox roundimg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TboxSearch;
        private System.Windows.Forms.Label bnlFood;
        private System.Windows.Forms.TextBox TboxOrder_name;
        private System.Windows.Forms.TextBox TboxBalance;
        private System.Windows.Forms.Label BalanceFood;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox TboxNum;
        private RoundPictureBox roundPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}