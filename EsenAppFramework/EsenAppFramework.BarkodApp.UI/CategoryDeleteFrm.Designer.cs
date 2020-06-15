namespace EsenAppFramework.BarkodApp.UI
{
    partial class CategoryDeleteFrm
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
            this.gbxProductDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.gbxProductDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProductDelete
            // 
            this.gbxProductDelete.Controls.Add(this.btnDelete);
            this.gbxProductDelete.Controls.Add(this.lbCategory);
            this.gbxProductDelete.Location = new System.Drawing.Point(13, 14);
            this.gbxProductDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxProductDelete.Name = "gbxProductDelete";
            this.gbxProductDelete.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxProductDelete.Size = new System.Drawing.Size(505, 310);
            this.gbxProductDelete.TabIndex = 1;
            this.gbxProductDelete.TabStop = false;
            this.gbxProductDelete.Text = "Katagori Sil";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(338, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 25;
            this.lbCategory.Location = new System.Drawing.Point(19, 31);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(301, 254);
            this.lbCategory.TabIndex = 0;
            // 
            // CategoryDeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 342);
            this.Controls.Add(this.gbxProductDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryDeleteFrm";
            this.Text = "Kategori Sil";
            this.Load += new System.EventHandler(this.CategoryDeleteFrm_Load);
            this.gbxProductDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProductDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbCategory;
    }
}