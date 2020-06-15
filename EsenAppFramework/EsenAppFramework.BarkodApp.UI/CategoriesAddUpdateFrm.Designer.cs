namespace EsenAppFramework.BarkodApp.UI
{
    partial class CategoriesAddUpdateFrm
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
            this.gbxCategoryAddUpdate = new System.Windows.Forms.GroupBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategoriesAddUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCategoryAddUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategoryAddUpdate
            // 
            this.gbxCategoryAddUpdate.Controls.Add(this.tbxDescription);
            this.gbxCategoryAddUpdate.Controls.Add(this.tbxCategoryName);
            this.gbxCategoryAddUpdate.Controls.Add(this.btnCategoriesAddUpdate);
            this.gbxCategoryAddUpdate.Controls.Add(this.label2);
            this.gbxCategoryAddUpdate.Controls.Add(this.label1);
            this.gbxCategoryAddUpdate.Location = new System.Drawing.Point(18, 19);
            this.gbxCategoryAddUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxCategoryAddUpdate.Name = "gbxCategoryAddUpdate";
            this.gbxCategoryAddUpdate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxCategoryAddUpdate.Size = new System.Drawing.Size(684, 150);
            this.gbxCategoryAddUpdate.TabIndex = 0;
            this.gbxCategoryAddUpdate.TabStop = false;
            this.gbxCategoryAddUpdate.Text = "Kategori Ekle Guncelle";
            this.gbxCategoryAddUpdate.Enter += new System.EventHandler(this.gbxCategoryAddUpdate_Enter);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(198, 76);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(180, 26);
            this.tbxDescription.TabIndex = 27;
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Location = new System.Drawing.Point(198, 33);
            this.tbxCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(180, 26);
            this.tbxCategoryName.TabIndex = 26;
            // 
            // btnCategoriesAddUpdate
            // 
            this.btnCategoriesAddUpdate.Location = new System.Drawing.Point(405, 33);
            this.btnCategoriesAddUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategoriesAddUpdate.Name = "btnCategoriesAddUpdate";
            this.btnCategoriesAddUpdate.Size = new System.Drawing.Size(256, 39);
            this.btnCategoriesAddUpdate.TabIndex = 19;
            this.btnCategoriesAddUpdate.Text = "Katagori Ekle / Guncelle";
            this.btnCategoriesAddUpdate.UseVisualStyleBackColor = true;
            this.btnCategoriesAddUpdate.Click += new System.EventHandler(this.btnCategoriesAddUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ismi : ";
            // 
            // CategoriesAddUpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 191);
            this.Controls.Add(this.gbxCategoryAddUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoriesAddUpdateFrm";
            this.Text = "CategoriesAddUpdate";
            this.Load += new System.EventHandler(this.CategoriesAddUpdateFrm_Load);
            this.gbxCategoryAddUpdate.ResumeLayout(false);
            this.gbxCategoryAddUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategoryAddUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoriesAddUpdate;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxCategoryName;
    }
}