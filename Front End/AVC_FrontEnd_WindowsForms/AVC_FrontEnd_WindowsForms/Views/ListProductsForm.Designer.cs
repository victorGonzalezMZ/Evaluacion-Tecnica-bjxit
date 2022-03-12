namespace AVC_FrontEnd_WindowsForms.Views
{
    partial class ListProductsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnGoEditProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Product";
            // 
            // txtbSearchProduct
            // 
            this.txtbSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbSearchProduct.Location = new System.Drawing.Point(188, 132);
            this.txtbSearchProduct.Name = "txtbSearchProduct";
            this.txtbSearchProduct.Size = new System.Drawing.Size(621, 30);
            this.txtbSearchProduct.TabIndex = 2;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProduct.Location = new System.Drawing.Point(815, 126);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(94, 40);
            this.btnSearchProduct.TabIndex = 3;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnGoEditProduct
            // 
            this.btnGoEditProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoEditProduct.Location = new System.Drawing.Point(915, 126);
            this.btnGoEditProduct.Name = "btnGoEditProduct";
            this.btnGoEditProduct.Size = new System.Drawing.Size(226, 40);
            this.btnGoEditProduct.TabIndex = 4;
            this.btnGoEditProduct.Text = "Register New Product";
            this.btnGoEditProduct.UseVisualStyleBackColor = true;
            this.btnGoEditProduct.Click += new System.EventHandler(this.btnGoEditProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(56, 202);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(1085, 500);
            this.dgvProducts.TabIndex = 5;
            // 
            // ListProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 753);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnGoEditProduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtbSearchProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListProductsForm";
            this.Text = "ListProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbSearchProduct;
        private Button btnSearchProduct;
        private Button btnGoEditProduct;
        private DataGridView dgvProducts;
    }
}