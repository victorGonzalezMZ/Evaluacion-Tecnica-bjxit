namespace AVC_FrontEnd_WindowsForms.Views
{
    partial class ListUsersForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoEditUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchbarUser = new System.Windows.Forms.TextBox();
            this.btnLogoutUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(46, 157);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.Size = new System.Drawing.Size(1089, 518);
            this.dgvUsers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(517, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            // 
            // btnGoEditUser
            // 
            this.btnGoEditUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoEditUser.Location = new System.Drawing.Point(985, 96);
            this.btnGoEditUser.Name = "btnGoEditUser";
            this.btnGoEditUser.Size = new System.Drawing.Size(150, 37);
            this.btnGoEditUser.TabIndex = 2;
            this.btnGoEditUser.Text = "Create new user";
            this.btnGoEditUser.UseVisualStyleBackColor = true;
            this.btnGoEditUser.Click += new System.EventHandler(this.btnGoEditUser_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUser.Location = new System.Drawing.Point(864, 96);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(104, 37);
            this.btnSearchUser.TabIndex = 3;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // txtSearchbarUser
            // 
            this.txtSearchbarUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchbarUser.Location = new System.Drawing.Point(159, 100);
            this.txtSearchbarUser.Name = "txtSearchbarUser";
            this.txtSearchbarUser.Size = new System.Drawing.Size(687, 30);
            this.txtSearchbarUser.TabIndex = 5;
            // 
            // btnLogoutUsers
            // 
            this.btnLogoutUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutUsers.Location = new System.Drawing.Point(46, 31);
            this.btnLogoutUsers.Name = "btnLogoutUsers";
            this.btnLogoutUsers.Size = new System.Drawing.Size(94, 31);
            this.btnLogoutUsers.TabIndex = 6;
            this.btnLogoutUsers.Text = "Logout";
            this.btnLogoutUsers.UseVisualStyleBackColor = true;
            this.btnLogoutUsers.Click += new System.EventHandler(this.btnLogoutUsers_Click);
            // 
            // ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 730);
            this.Controls.Add(this.btnLogoutUsers);
            this.Controls.Add(this.txtSearchbarUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnGoEditUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ListUsersForm";
            this.Text = "ListUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUsers;
        private Label label1;
        private Button btnGoEditUser;
        private Button btnSearchUser;
        private Label label2;
        private TextBox txtSearchbarUser;
        private Button btnLogoutUsers;
    }
}