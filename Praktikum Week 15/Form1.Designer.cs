namespace Praktikum_Week_15
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
            this.listBoxnamaitem = new System.Windows.Forms.ListBox();
            this.listBoxharga = new System.Windows.Forms.ListBox();
            this.labeltulisanitems = new System.Windows.Forms.Label();
            this.labeltulisanmenu = new System.Windows.Forms.Label();
            this.labeltulisanharga = new System.Windows.Forms.Label();
            this.labelharga = new System.Windows.Forms.Label();
            this.radioButtonmakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonminuman = new System.Windows.Forms.RadioButton();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.buttoncheckout = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.labeltulisanbudewi = new System.Windows.Forms.Label();
            this.comboBoxlistmenu = new System.Windows.Forms.ComboBox();
            this.labeltulisansize = new System.Windows.Forms.Label();
            this.radioButtonsizenormal = new System.Windows.Forms.RadioButton();
            this.radioButtonsizejumbo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxnamaitem
            // 
            this.listBoxnamaitem.FormattingEnabled = true;
            this.listBoxnamaitem.ItemHeight = 16;
            this.listBoxnamaitem.Location = new System.Drawing.Point(64, 76);
            this.listBoxnamaitem.Name = "listBoxnamaitem";
            this.listBoxnamaitem.Size = new System.Drawing.Size(164, 292);
            this.listBoxnamaitem.TabIndex = 0;
            // 
            // listBoxharga
            // 
            this.listBoxharga.FormattingEnabled = true;
            this.listBoxharga.ItemHeight = 16;
            this.listBoxharga.Location = new System.Drawing.Point(234, 76);
            this.listBoxharga.Name = "listBoxharga";
            this.listBoxharga.Size = new System.Drawing.Size(120, 292);
            this.listBoxharga.TabIndex = 1;
            // 
            // labeltulisanitems
            // 
            this.labeltulisanitems.AutoSize = true;
            this.labeltulisanitems.Location = new System.Drawing.Point(197, 43);
            this.labeltulisanitems.Name = "labeltulisanitems";
            this.labeltulisanitems.Size = new System.Drawing.Size(49, 17);
            this.labeltulisanitems.TabIndex = 2;
            this.labeltulisanitems.Text = "ITEMS";
            // 
            // labeltulisanmenu
            // 
            this.labeltulisanmenu.AutoSize = true;
            this.labeltulisanmenu.Location = new System.Drawing.Point(399, 140);
            this.labeltulisanmenu.Name = "labeltulisanmenu";
            this.labeltulisanmenu.Size = new System.Drawing.Size(43, 17);
            this.labeltulisanmenu.TabIndex = 3;
            this.labeltulisanmenu.Text = "Menu";
            // 
            // labeltulisanharga
            // 
            this.labeltulisanharga.AutoSize = true;
            this.labeltulisanharga.Location = new System.Drawing.Point(620, 140);
            this.labeltulisanharga.Name = "labeltulisanharga";
            this.labeltulisanharga.Size = new System.Drawing.Size(47, 17);
            this.labeltulisanharga.TabIndex = 4;
            this.labeltulisanharga.Text = "Harga";
            // 
            // labelharga
            // 
            this.labelharga.AutoSize = true;
            this.labelharga.Location = new System.Drawing.Point(689, 140);
            this.labelharga.Name = "labelharga";
            this.labelharga.Size = new System.Drawing.Size(0, 17);
            this.labelharga.TabIndex = 5;
            this.labelharga.UseMnemonic = false;
            // 
            // radioButtonmakanan
            // 
            this.radioButtonmakanan.AutoSize = true;
            this.radioButtonmakanan.Location = new System.Drawing.Point(454, 92);
            this.radioButtonmakanan.Name = "radioButtonmakanan";
            this.radioButtonmakanan.Size = new System.Drawing.Size(87, 21);
            this.radioButtonmakanan.TabIndex = 6;
            this.radioButtonmakanan.TabStop = true;
            this.radioButtonmakanan.Text = "Makanan";
            this.radioButtonmakanan.UseVisualStyleBackColor = true;
            this.radioButtonmakanan.CheckedChanged += new System.EventHandler(this.radioButtonmakanan_CheckedChanged);
            // 
            // radioButtonminuman
            // 
            this.radioButtonminuman.AutoSize = true;
            this.radioButtonminuman.Location = new System.Drawing.Point(593, 92);
            this.radioButtonminuman.Name = "radioButtonminuman";
            this.radioButtonminuman.Size = new System.Drawing.Size(86, 21);
            this.radioButtonminuman.TabIndex = 7;
            this.radioButtonminuman.TabStop = true;
            this.radioButtonminuman.Text = "Minuman";
            this.radioButtonminuman.UseVisualStyleBackColor = true;
            this.radioButtonminuman.CheckedChanged += new System.EventHandler(this.radioButtonminuman_CheckedChanged);
            // 
            // buttonbuy
            // 
            this.buttonbuy.Location = new System.Drawing.Point(470, 292);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(144, 39);
            this.buttonbuy.TabIndex = 8;
            this.buttonbuy.Text = "Buy";
            this.buttonbuy.UseVisualStyleBackColor = true;
            this.buttonbuy.Click += new System.EventHandler(this.buttonbuy_Click);
            // 
            // buttoncheckout
            // 
            this.buttoncheckout.Location = new System.Drawing.Point(604, 369);
            this.buttoncheckout.Name = "buttoncheckout";
            this.buttoncheckout.Size = new System.Drawing.Size(144, 46);
            this.buttoncheckout.TabIndex = 9;
            this.buttoncheckout.Text = "Check Out";
            this.buttoncheckout.UseVisualStyleBackColor = true;
            this.buttoncheckout.Click += new System.EventHandler(this.buttoncheckout_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Enabled = false;
            this.buttondelete.Location = new System.Drawing.Point(234, 392);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // labeltulisanbudewi
            // 
            this.labeltulisanbudewi.AutoSize = true;
            this.labeltulisanbudewi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltulisanbudewi.Location = new System.Drawing.Point(323, 13);
            this.labeltulisanbudewi.Name = "labeltulisanbudewi";
            this.labeltulisanbudewi.Size = new System.Drawing.Size(114, 29);
            this.labeltulisanbudewi.TabIndex = 11;
            this.labeltulisanbudewi.Text = "Bu Dewi";
            // 
            // comboBoxlistmenu
            // 
            this.comboBoxlistmenu.FormattingEnabled = true;
            this.comboBoxlistmenu.Location = new System.Drawing.Point(454, 133);
            this.comboBoxlistmenu.Name = "comboBoxlistmenu";
            this.comboBoxlistmenu.Size = new System.Drawing.Size(160, 24);
            this.comboBoxlistmenu.TabIndex = 12;
            this.comboBoxlistmenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxlistmenu_SelectedIndexChanged);
            // 
            // labeltulisansize
            // 
            this.labeltulisansize.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labeltulisansize.AutoSize = true;
            this.labeltulisansize.Location = new System.Drawing.Point(451, 181);
            this.labeltulisansize.Name = "labeltulisansize";
            this.labeltulisansize.Size = new System.Drawing.Size(35, 17);
            this.labeltulisansize.TabIndex = 13;
            this.labeltulisansize.Text = "Size";
            this.labeltulisansize.Visible = false;
            // 
            // radioButtonsizenormal
            // 
            this.radioButtonsizenormal.AutoSize = true;
            this.radioButtonsizenormal.Checked = true;
            this.radioButtonsizenormal.Location = new System.Drawing.Point(6, 39);
            this.radioButtonsizenormal.Name = "radioButtonsizenormal";
            this.radioButtonsizenormal.Size = new System.Drawing.Size(74, 21);
            this.radioButtonsizenormal.TabIndex = 14;
            this.radioButtonsizenormal.TabStop = true;
            this.radioButtonsizenormal.Text = "Normal";
            this.radioButtonsizenormal.UseVisualStyleBackColor = true;
            this.radioButtonsizenormal.Visible = false;
            this.radioButtonsizenormal.CheckedChanged += new System.EventHandler(this.radioButtonsizenormal_CheckedChanged);
            // 
            // radioButtonsizejumbo
            // 
            this.radioButtonsizejumbo.AutoSize = true;
            this.radioButtonsizejumbo.Location = new System.Drawing.Point(106, 39);
            this.radioButtonsizejumbo.Name = "radioButtonsizejumbo";
            this.radioButtonsizejumbo.Size = new System.Drawing.Size(71, 21);
            this.radioButtonsizejumbo.TabIndex = 15;
            this.radioButtonsizejumbo.TabStop = true;
            this.radioButtonsizejumbo.Text = "Jumbo";
            this.radioButtonsizejumbo.UseVisualStyleBackColor = true;
            this.radioButtonsizejumbo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonsizenormal);
            this.groupBox1.Controls.Add(this.radioButtonsizejumbo);
            this.groupBox1.Location = new System.Drawing.Point(512, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeltulisansize);
            this.Controls.Add(this.comboBoxlistmenu);
            this.Controls.Add(this.labeltulisanbudewi);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoncheckout);
            this.Controls.Add(this.buttonbuy);
            this.Controls.Add(this.radioButtonminuman);
            this.Controls.Add(this.radioButtonmakanan);
            this.Controls.Add(this.labelharga);
            this.Controls.Add(this.labeltulisanharga);
            this.Controls.Add(this.labeltulisanmenu);
            this.Controls.Add(this.labeltulisanitems);
            this.Controls.Add(this.listBoxharga);
            this.Controls.Add(this.listBoxnamaitem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxnamaitem;
        private System.Windows.Forms.ListBox listBoxharga;
        private System.Windows.Forms.Label labeltulisanitems;
        private System.Windows.Forms.Label labeltulisanmenu;
        private System.Windows.Forms.Label labeltulisanharga;
        private System.Windows.Forms.Label labelharga;
        private System.Windows.Forms.RadioButton radioButtonmakanan;
        private System.Windows.Forms.RadioButton radioButtonminuman;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.Button buttoncheckout;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Label labeltulisanbudewi;
        private System.Windows.Forms.ComboBox comboBoxlistmenu;
        private System.Windows.Forms.Label labeltulisansize;
        private System.Windows.Forms.RadioButton radioButtonsizenormal;
        private System.Windows.Forms.RadioButton radioButtonsizejumbo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

