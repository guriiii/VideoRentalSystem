namespace VideoRentalSystem
{
    partial class UpdateAndDeleteCust
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
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnDaleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(191, 85);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(295, 20);
            this.txtCustID.TabIndex = 58;
            this.txtCustID.Visible = false;
            // 
            // btnDaleteCustomer
            // 
            this.btnDaleteCustomer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDaleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDaleteCustomer.Location = new System.Drawing.Point(360, 302);
            this.btnDaleteCustomer.Name = "btnDaleteCustomer";
            this.btnDaleteCustomer.Size = new System.Drawing.Size(126, 64);
            this.btnDaleteCustomer.TabIndex = 57;
            this.btnDaleteCustomer.Text = "Delete Customer";
            this.btnDaleteCustomer.UseVisualStyleBackColor = false;
            this.btnDaleteCustomer.Click += new System.EventHandler(this.BtnDaleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(124, 302);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(135, 64);
            this.btnUpdateCustomer.TabIndex = 56;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(191, 250);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(295, 20);
            this.txtPhoneNo.TabIndex = 55;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(191, 188);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(295, 26);
            this.txtAddress.TabIndex = 54;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(191, 131);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 20);
            this.txtFirstName.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(112, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(112, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Name";
            // 
            // UpdateAndDeleteCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnDaleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "UpdateAndDeleteCust";
            this.Text = "UpdateAndDeleteCust";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnDaleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        public System.Windows.Forms.TextBox txtPhoneNo;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
    }
}