namespace EsenAppFramework.BarkodApp.UI
{
    partial class OrderListFrm
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
            this.dgwOrderList = new System.Windows.Forms.DataGridView();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.gbOrderDetailsInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Piece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderList)).BeginInit();
            this.gbOrderDetails.SuspendLayout();
            this.gbOrderDetailsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwOrderList
            // 
            this.dgwOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderList.Location = new System.Drawing.Point(17, 19);
            this.dgwOrderList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgwOrderList.MultiSelect = false;
            this.dgwOrderList.Name = "dgwOrderList";
            this.dgwOrderList.RowHeadersWidth = 51;
            this.dgwOrderList.Size = new System.Drawing.Size(659, 292);
            this.dgwOrderList.TabIndex = 0;
            this.dgwOrderList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwOrderList_CellMouseClick);
            this.dgwOrderList.SelectionChanged += new System.EventHandler(this.dgwOrderList_SelectionChanged);
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.Controls.Add(this.gbOrderDetailsInfo);
            this.gbOrderDetails.Location = new System.Drawing.Point(702, 19);
            this.gbOrderDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbOrderDetails.Size = new System.Drawing.Size(536, 295);
            this.gbOrderDetails.TabIndex = 1;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "Sipariş Bilgileri";
            // 
            // gbOrderDetailsInfo
            // 
            this.gbOrderDetailsInfo.Controls.Add(this.lblTotalPrice);
            this.gbOrderDetailsInfo.Controls.Add(this.label1);
            this.gbOrderDetailsInfo.Controls.Add(this.lvOrderDetails);
            this.gbOrderDetailsInfo.Location = new System.Drawing.Point(12, 35);
            this.gbOrderDetailsInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbOrderDetailsInfo.Name = "gbOrderDetailsInfo";
            this.gbOrderDetailsInfo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbOrderDetailsInfo.Size = new System.Drawing.Size(509, 240);
            this.gbOrderDetailsInfo.TabIndex = 1;
            this.gbOrderDetailsInfo.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(178, 189);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(119, 25);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "lblTotalPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Fiyat :";
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.Piece,
            this.Price,
            this.TotalPrice});
            this.lvOrderDetails.HideSelection = false;
            this.lvOrderDetails.Location = new System.Drawing.Point(18, 36);
            this.lvOrderDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.Size = new System.Drawing.Size(474, 137);
            this.lvOrderDetails.TabIndex = 0;
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 105;
            // 
            // Piece
            // 
            this.Piece.Text = "Adet";
            this.Piece.Width = 65;
            // 
            // Price
            // 
            this.Price.Text = "Fiyat";
            this.Price.Width = 71;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Toplam Fiyat";
            this.TotalPrice.Width = 143;
            // 
            // OrderListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 327);
            this.Controls.Add(this.gbOrderDetails);
            this.Controls.Add(this.dgwOrderList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "OrderListFrm";
            this.Text = "Siparis Listesi";
            this.Load += new System.EventHandler(this.OrderListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderList)).EndInit();
            this.gbOrderDetails.ResumeLayout(false);
            this.gbOrderDetailsInfo.ResumeLayout(false);
            this.gbOrderDetailsInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrderList;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.GroupBox gbOrderDetailsInfo;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Piece;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader TotalPrice;
    }
}