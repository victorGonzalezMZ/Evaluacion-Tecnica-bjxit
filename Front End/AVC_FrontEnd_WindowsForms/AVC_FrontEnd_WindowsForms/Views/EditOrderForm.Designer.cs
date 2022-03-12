namespace AVC_FrontEnd_WindowsForms.Views
{
    partial class EditOrderForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDOrder = new System.Windows.Forms.TextBox();
            this.txtbTotalPrice = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbDeliverer = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txtbSeller = new System.Windows.Forms.TextBox();
            this.dgvProductsOrder = new System.Windows.Forms.DataGridView();
            this.chkDelivered = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbInstructions = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(190, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(456, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(725, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deliverer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(696, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address Delivery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "List Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(331, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(457, 644);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total Cost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(696, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Has been Delivered";
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDOrder.Location = new System.Drawing.Point(59, 108);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.Size = new System.Drawing.Size(125, 30);
            this.txtIDOrder.TabIndex = 13;
            // 
            // txtbTotalPrice
            // 
            this.txtbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbTotalPrice.Location = new System.Drawing.Point(548, 641);
            this.txtbTotalPrice.Name = "txtbTotalPrice";
            this.txtbTotalPrice.Size = new System.Drawing.Size(125, 30);
            this.txtbTotalPrice.TabIndex = 14;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbAddress.Location = new System.Drawing.Point(696, 221);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(315, 30);
            this.txtbAddress.TabIndex = 15;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(413, 170);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 30);
            this.txtQuantity.TabIndex = 16;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(516, 111);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(203, 28);
            this.cmbClient.TabIndex = 17;
            // 
            // cmbDeliverer
            // 
            this.cmbDeliverer.FormattingEnabled = true;
            this.cmbDeliverer.Location = new System.Drawing.Point(808, 113);
            this.cmbDeliverer.Name = "cmbDeliverer";
            this.cmbDeliverer.Size = new System.Drawing.Size(203, 28);
            this.cmbDeliverer.TabIndex = 18;
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(102, 169);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(223, 28);
            this.cmbProducts.TabIndex = 19;
            // 
            // txtbSeller
            // 
            this.txtbSeller.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbSeller.Location = new System.Drawing.Point(247, 111);
            this.txtbSeller.Name = "txtbSeller";
            this.txtbSeller.Size = new System.Drawing.Size(203, 30);
            this.txtbSeller.TabIndex = 20;
            // 
            // dgvProductsOrder
            // 
            this.dgvProductsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsOrder.Location = new System.Drawing.Point(26, 238);
            this.dgvProductsOrder.Name = "dgvProductsOrder";
            this.dgvProductsOrder.RowHeadersWidth = 51;
            this.dgvProductsOrder.RowTemplate.Height = 29;
            this.dgvProductsOrder.Size = new System.Drawing.Size(647, 397);
            this.dgvProductsOrder.TabIndex = 21;
            // 
            // chkDelivered
            // 
            this.chkDelivered.AutoSize = true;
            this.chkDelivered.Location = new System.Drawing.Point(696, 592);
            this.chkDelivered.Name = "chkDelivered";
            this.chkDelivered.Size = new System.Drawing.Size(52, 24);
            this.chkDelivered.TabIndex = 22;
            this.chkDelivered.Text = "Yes";
            this.chkDelivered.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(560, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(871, 638);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(94, 29);
            this.btnSaveOrder.TabIndex = 24;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(737, 638);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(94, 29);
            this.btnCancelOrder.TabIndex = 25;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(696, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Additional Delivery Instructions";
            // 
            // txtbInstructions
            // 
            this.txtbInstructions.Location = new System.Drawing.Point(696, 318);
            this.txtbInstructions.Name = "txtbInstructions";
            this.txtbInstructions.Size = new System.Drawing.Size(315, 228);
            this.txtbInstructions.TabIndex = 27;
            this.txtbInstructions.Text = "";
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.txtbInstructions);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkDelivered);
            this.Controls.Add(this.dgvProductsOrder);
            this.Controls.Add(this.txtbSeller);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.cmbDeliverer);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbTotalPrice);
            this.Controls.Add(this.txtIDOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditOrderForm";
            this.Text = "NewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtIDOrder;
        private TextBox txtbTotalPrice;
        private TextBox txtbAddress;
        private TextBox txtQuantity;
        private ComboBox cmbClient;
        private ComboBox cmbDeliverer;
        private ComboBox cmbProducts;
        private TextBox txtbSeller;
        private DataGridView dgvProductsOrder;
        private CheckBox chkDelivered;
        private Button btnAdd;
        private Button btnSaveOrder;
        private Button btnCancelOrder;
        private Label label12;
        private RichTextBox txtbInstructions;
    }
}