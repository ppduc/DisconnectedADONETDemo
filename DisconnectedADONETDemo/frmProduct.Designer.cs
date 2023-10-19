namespace DisconnectedADONETDemo
{
    partial class frmProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnViewProducts = new Button();
            btnViewCategories = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(136, 36);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(174, 34);
            btnViewProducts.TabIndex = 0;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnViewCategories
            // 
            btnViewCategories.Location = new Point(511, 36);
            btnViewCategories.Name = "btnViewCategories";
            btnViewCategories.Size = new Size(174, 34);
            btnViewCategories.TabIndex = 1;
            btnViewCategories.Text = "View Categories";
            btnViewCategories.UseVisualStyleBackColor = true;
            btnViewCategories.Click += btnViewCategories_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(46, 93);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 33;
            dgvData.Size = new Size(717, 287);
            dgvData.TabIndex = 2;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnViewCategories);
            Controls.Add(btnViewProducts);
            Name = "frmProduct";
            Text = "Form1";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProducts;
        private Button btnViewCategories;
        private DataGridView dgvData;
    }
}