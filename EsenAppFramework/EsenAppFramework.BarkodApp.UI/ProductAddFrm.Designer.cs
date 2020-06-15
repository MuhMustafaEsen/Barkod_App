namespace EsenAppFramework.BarkodApp.UI
{
    partial class ProductAddUpdateFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxBarkodNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductAddUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.tbxUnitPrice);
            this.groupBox1.Controls.Add(this.tbxQuantity);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.tbxBarkodNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProductAddUpdate);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(668, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urun Ekle Guncelle";
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 25;
            this.lbCategory.Location = new System.Drawing.Point(152, 140);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCategory.Size = new System.Drawing.Size(180, 179);
            this.lbCategory.TabIndex = 29;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(476, 94);
            this.tbxUnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(180, 30);
            this.tbxUnitPrice.TabIndex = 28;
            this.tbxUnitPrice.Text = "0";
            this.tbxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUnitPrice_KeyPress);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(476, 49);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(180, 30);
            this.tbxQuantity.TabIndex = 27;
            this.tbxQuantity.Text = "0";
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(152, 97);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(180, 30);
            this.tbxProductName.TabIndex = 26;
            // 
            // tbxBarkodNo
            // 
            this.tbxBarkodNo.Location = new System.Drawing.Point(152, 46);
            this.tbxBarkodNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxBarkodNo.Name = "tbxBarkodNo";
            this.tbxBarkodNo.Size = new System.Drawing.Size(180, 30);
            this.tbxBarkodNo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fiyatı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adet / Kilo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Urun Ismi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Barkod No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kategori :";
            // 
            // btnProductAddUpdate
            // 
            this.btnProductAddUpdate.Location = new System.Drawing.Point(363, 140);
            this.btnProductAddUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductAddUpdate.Name = "btnProductAddUpdate";
            this.btnProductAddUpdate.Size = new System.Drawing.Size(293, 37);
            this.btnProductAddUpdate.TabIndex = 25;
            this.btnProductAddUpdate.Text = "Urun Ekle / Guncelle";
            this.btnProductAddUpdate.UseVisualStyleBackColor = true;
            this.btnProductAddUpdate.Click += new System.EventHandler(this.btnProductAddUpdate_Click);
            // 
            // ProductAddUpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 370);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductAddUpdateFrm";
            this.Text = "ProductAddUpdate";
            this.Load += new System.EventHandler(this.ProductAddUpdateFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxBarkodNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductAddUpdate;
        private System.Windows.Forms.ListBox lbCategory;
    }
}