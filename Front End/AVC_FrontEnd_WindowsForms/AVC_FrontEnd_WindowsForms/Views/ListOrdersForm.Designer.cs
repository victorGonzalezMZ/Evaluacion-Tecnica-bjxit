namespace AVC_FrontEnd_WindowsForms.Views
{
    partial class ListOrdersForm
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
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnToEditOrder = new System.Windows.Forms.Button();
            this.txtbSearchOrder = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(494, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Order";
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchOrder.Location = new System.Drawing.Point(785, 95);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(109, 49);
            this.btnSearchOrder.TabIndex = 2;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnToEditOrder
            // 
            this.btnToEditOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToEditOrder.Location = new System.Drawing.Point(900, 95);
            this.btnToEditOrder.Name = "btnToEditOrder";
            this.btnToEditOrder.Size = new System.Drawing.Size(184, 49);
            this.btnToEditOrder.TabIndex = 3;
            this.btnToEditOrder.Text = "Register New Order";
            this.btnToEditOrder.UseVisualStyleBackColor = true;
            this.btnToEditOrder.Click += new System.EventHandler(this.btnToEditOrder_Click);
            // 
            // txtbSearchOrder
            // 
            this.txtbSearchOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbSearchOrder.Location = new System.Drawing.Point(183, 104);
            this.txtbSearchOrder.Name = "txtbSearchOrder";
            this.txtbSearchOrder.Size = new System.Drawing.Size(596, 30);
            this.txtbSearchOrder.TabIndex = 4;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(67, 172);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.Size = new System.Drawing.Size(1017, 488);
            this.dgvOrders.TabIndex = 5;
            // 
            // ListOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 713);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.txtbSearchOrder);
            this.Controls.Add(this.btnToEditOrder);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListOrdersForm";
            this.Text = "ListOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSearchOrder;
        private Button btnToEditOrder;
        private TextBox txtbSearchOrder;
        private DataGridView dgvOrders;
    }
}