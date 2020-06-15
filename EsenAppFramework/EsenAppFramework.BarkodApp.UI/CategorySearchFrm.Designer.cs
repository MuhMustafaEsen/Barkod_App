namespace EsenAppFramework.BarkodApp.UI
{
    partial class CategorySearchFrm
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
            this.gbCategorySearch = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCategorySearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategorySearch
            // 
            this.gbCategorySearch.Controls.Add(this.cbxCategory);
            this.gbCategorySearch.Controls.Add(this.btnSearch);
            this.gbCategorySearch.Controls.Add(this.label1);
            this.gbCategorySearch.Location = new System.Drawing.Point(13, 14);
            this.gbCategorySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCategorySearch.Name = "gbCategorySearch";
            this.gbCategorySearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCategorySearch.Size = new System.Drawing.Size(580, 92);
            this.gbCategorySearch.TabIndex = 1;
            this.gbCategorySearch.TabStop = false;
            this.gbCategorySearch.Text = "Kategori Ara";
            this.gbCategorySearch.Enter += new System.EventHandler(this.gbCategorySearch_Enter);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(149, 31);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(265, 33);
            this.cbxCategory.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(434, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Guncelle";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori : ";
            // 
            // CategorySearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 124);
            this.Controls.Add(this.gbCategorySearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategorySearchFrm";
            this.Text = "CategorySearchFrm";
            this.Load += new System.EventHandler(this.CategorySearchFrm_Load);
            this.gbCategorySearch.ResumeLayout(false);
            this.gbCategorySearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategorySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategory;
    }
}