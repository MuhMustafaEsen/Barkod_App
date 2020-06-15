namespace EsenAppFramework.BarkodApp.UI
{
    partial class OrderFrm
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
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.lwOrder = new System.Windows.Forms.ListView();
            this.Barcod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Piece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbProductInfo = new System.Windows.Forms.GroupBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbPiece = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.tbxBarkodNo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.tbOrderName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxOrder.SuspendLayout();
            this.gbProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.lwOrder);
            this.gbxOrder.Controls.Add(this.label6);
            this.gbxOrder.Controls.Add(this.btnDelete);
            this.gbxOrder.Controls.Add(this.gbProductInfo);
            this.gbxOrder.Controls.Add(this.btnSearch);
            this.gbxOrder.Controls.Add(this.lbTotalPrice);
            this.gbxOrder.Controls.Add(this.tbxBarkodNo);
            this.gbxOrder.Location = new System.Drawing.Point(14, 54);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(1147, 314);
            this.gbxOrder.TabIndex = 0;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Siparis";
            // 
            // lwOrder
            // 
            this.lwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Barcod,
            this.ProductName,
            this.Piece,
            this.TotalPrice});
            this.lwOrder.HideSelection = false;
            this.lwOrder.Location = new System.Drawing.Point(514, 25);
            this.lwOrder.Name = "lwOrder";
            this.lwOrder.Size = new System.Drawing.Size(558, 201);
            this.lwOrder.TabIndex = 8;
            this.lwOrder.UseCompatibleStateImageBehavior = false;
            this.lwOrder.View = System.Windows.Forms.View.Details;
            // 
            // Barcod
            // 
            this.Barcod.Text = "Barkod";
            this.Barcod.Width = 107;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 150;
            // 
            // Piece
            // 
            this.Piece.Text = "Adet / KG";
            this.Piece.Width = 119;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Toplam Fiyat";
            this.TotalPrice.Width = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Toplam Fiyat : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbProductInfo
            // 
            this.gbProductInfo.Controls.Add(this.lbCategory);
            this.gbProductInfo.Controls.Add(this.btnAdd);
            this.gbProductInfo.Controls.Add(this.txbPiece);
            this.gbProductInfo.Controls.Add(this.lblBarcode);
            this.gbProductInfo.Controls.Add(this.lblPrice);
            this.gbProductInfo.Controls.Add(this.label7);
            this.gbProductInfo.Controls.Add(this.label3);
            this.gbProductInfo.Controls.Add(this.lblProductName);
            this.gbProductInfo.Controls.Add(this.label2);
            this.gbProductInfo.Controls.Add(this.label4);
            this.gbProductInfo.Controls.Add(this.label1);
            this.gbProductInfo.Location = new System.Drawing.Point(6, 77);
            this.gbProductInfo.Name = "gbProductInfo";
            this.gbProductInfo.Size = new System.Drawing.Size(500, 231);
            this.gbProductInfo.TabIndex = 3;
            this.gbProductInfo.TabStop = false;
            this.gbProductInfo.Text = "Ürün Bilgisi";
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 20;
            this.lbCategory.Location = new System.Drawing.Point(319, 45);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(169, 104);
            this.lbCategory.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(459, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbPiece
            // 
            this.txbPiece.Location = new System.Drawing.Point(106, 138);
            this.txbPiece.Name = "txbPiece";
            this.txbPiece.Size = new System.Drawing.Size(92, 26);
            this.txbPiece.TabIndex = 5;
            this.txbPiece.Text = "1";
            this.txbPiece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPiece_KeyPress);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(102, 109);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(84, 20);
            this.lblBarcode.TabIndex = 4;
            this.lblBarcode.Text = "lblBarcode";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(102, 76);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "lblPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adet  / KG :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barkod :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(102, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(121, 20);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "lblProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategoriler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ürün Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(641, 282);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(91, 20);
            this.lbTotalPrice.TabIndex = 4;
            this.lbTotalPrice.Text = "lbTotalPrice";
            // 
            // tbxBarkodNo
            // 
            this.tbxBarkodNo.Location = new System.Drawing.Point(16, 34);
            this.tbxBarkodNo.Name = "tbxBarkodNo";
            this.tbxBarkodNo.Size = new System.Drawing.Size(303, 26);
            this.tbxBarkodNo.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(972, 12);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(189, 36);
            this.btnFinishOrder.TabIndex = 2;
            this.btnFinishOrder.Text = "Siparişi Bitir";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // tbOrderName
            // 
            this.tbOrderName.Location = new System.Drawing.Point(636, 17);
            this.tbOrderName.Name = "tbOrderName";
            this.tbOrderName.Size = new System.Drawing.Size(312, 26);
            this.tbOrderName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sipariş Adı :";
            // 
            // OrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOrderName);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderFrm";
            this.Text = "OrderFrm";
            this.Load += new System.EventHandler(this.OrderFrm_Load);
            this.gbxOrder.ResumeLayout(false);
            this.gbxOrder.PerformLayout();
            this.gbProductInfo.ResumeLayout(false);
            this.gbProductInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbProductInfo;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbPiece;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox tbxBarkodNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lwOrder;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Piece;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.ColumnHeader Barcod;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.TextBox tbOrderName;
        private System.Windows.Forms.Label label5;
    }
}