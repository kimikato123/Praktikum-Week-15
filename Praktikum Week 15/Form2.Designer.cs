namespace Praktikum_Week_15
{
    partial class Form2
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
            this.labeltulisansubtotal = new System.Windows.Forms.Label();
            this.labeltulisantax = new System.Windows.Forms.Label();
            this.labeltulisandiscount = new System.Windows.Forms.Label();
            this.labeltulisantotal = new System.Windows.Forms.Label();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelnilaisubtotal = new System.Windows.Forms.Label();
            this.labelnilaitax = new System.Windows.Forms.Label();
            this.labelnilaidiscount = new System.Windows.Forms.Label();
            this.labelnilaitotal = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labeltulisansubtotal
            // 
            this.labeltulisansubtotal.AutoSize = true;
            this.labeltulisansubtotal.Location = new System.Drawing.Point(449, 104);
            this.labeltulisansubtotal.Name = "labeltulisansubtotal";
            this.labeltulisansubtotal.Size = new System.Drawing.Size(60, 17);
            this.labeltulisansubtotal.TabIndex = 0;
            this.labeltulisansubtotal.Text = "Subtotal";
            // 
            // labeltulisantax
            // 
            this.labeltulisantax.AutoSize = true;
            this.labeltulisantax.Location = new System.Drawing.Point(449, 137);
            this.labeltulisantax.Name = "labeltulisantax";
            this.labeltulisantax.Size = new System.Drawing.Size(31, 17);
            this.labeltulisantax.TabIndex = 1;
            this.labeltulisantax.Text = "Tax";
            // 
            // labeltulisandiscount
            // 
            this.labeltulisandiscount.AutoSize = true;
            this.labeltulisandiscount.Location = new System.Drawing.Point(449, 179);
            this.labeltulisandiscount.Name = "labeltulisandiscount";
            this.labeltulisandiscount.Size = new System.Drawing.Size(63, 17);
            this.labeltulisandiscount.TabIndex = 2;
            this.labeltulisandiscount.Text = "Discount";
            // 
            // labeltulisantotal
            // 
            this.labeltulisantotal.AutoSize = true;
            this.labeltulisantotal.Location = new System.Drawing.Point(449, 221);
            this.labeltulisantotal.Name = "labeltulisantotal";
            this.labeltulisantotal.Size = new System.Drawing.Size(40, 17);
            this.labeltulisantotal.TabIndex = 3;
            this.labeltulisantotal.Text = "Total";
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(35, 49);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(85, 21);
            this.checkBoxDiscount.TabIndex = 4;
            this.checkBoxDiscount.Text = "Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            this.checkBoxDiscount.CheckedChanged += new System.EventHandler(this.checkBoxDiscount_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(35, 201);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelnilaisubtotal
            // 
            this.labelnilaisubtotal.AutoSize = true;
            this.labelnilaisubtotal.Location = new System.Drawing.Point(539, 104);
            this.labelnilaisubtotal.Name = "labelnilaisubtotal";
            this.labelnilaisubtotal.Size = new System.Drawing.Size(16, 17);
            this.labelnilaisubtotal.TabIndex = 6;
            this.labelnilaisubtotal.Text = "0";
            // 
            // labelnilaitax
            // 
            this.labelnilaitax.AutoSize = true;
            this.labelnilaitax.Location = new System.Drawing.Point(542, 137);
            this.labelnilaitax.Name = "labelnilaitax";
            this.labelnilaitax.Size = new System.Drawing.Size(16, 17);
            this.labelnilaitax.TabIndex = 7;
            this.labelnilaitax.Text = "0";
            // 
            // labelnilaidiscount
            // 
            this.labelnilaidiscount.AutoSize = true;
            this.labelnilaidiscount.Location = new System.Drawing.Point(542, 179);
            this.labelnilaidiscount.Name = "labelnilaidiscount";
            this.labelnilaidiscount.Size = new System.Drawing.Size(16, 17);
            this.labelnilaidiscount.TabIndex = 8;
            this.labelnilaidiscount.Text = "0";
            // 
            // labelnilaitotal
            // 
            this.labelnilaitotal.AutoSize = true;
            this.labelnilaitotal.Location = new System.Drawing.Point(542, 221);
            this.labelnilaitotal.Name = "labelnilaitotal";
            this.labelnilaitotal.Size = new System.Drawing.Size(16, 17);
            this.labelnilaitotal.TabIndex = 9;
            this.labelnilaitotal.Text = "0";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(35, 76);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(119, 22);
            this.textBoxDiscount.TabIndex = 10;
            this.textBoxDiscount.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelnilaitotal);
            this.Controls.Add(this.labelnilaidiscount);
            this.Controls.Add(this.labelnilaitax);
            this.Controls.Add(this.labelnilaisubtotal);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.checkBoxDiscount);
            this.Controls.Add(this.labeltulisantotal);
            this.Controls.Add(this.labeltulisandiscount);
            this.Controls.Add(this.labeltulisantax);
            this.Controls.Add(this.labeltulisansubtotal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltulisansubtotal;
        private System.Windows.Forms.Label labeltulisantax;
        private System.Windows.Forms.Label labeltulisandiscount;
        private System.Windows.Forms.Label labeltulisantotal;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelnilaisubtotal;
        private System.Windows.Forms.Label labelnilaitax;
        private System.Windows.Forms.Label labelnilaidiscount;
        private System.Windows.Forms.Label labelnilaitotal;
        private System.Windows.Forms.TextBox textBoxDiscount;
    }
}