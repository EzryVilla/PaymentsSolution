namespace PaymentsSolution
{
    partial class FrmMain
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
            this.grdPayments = new System.Windows.Forms.DataGridView();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.cmbSellers = new System.Windows.Forms.ComboBox();
            this.cmbOrders = new System.Windows.Forms.ComboBox();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPayments
            // 
            this.grdPayments.AllowUserToResizeColumns = false;
            this.grdPayments.AllowUserToResizeRows = false;
            this.grdPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayments.Location = new System.Drawing.Point(20, 160);
            this.grdPayments.Name = "grdPayments";
            this.grdPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPayments.Size = new System.Drawing.Size(534, 174);
            this.grdPayments.TabIndex = 0;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(436, 107);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(85, 21);
            this.btnAddPayment.TabIndex = 1;
            this.btnAddPayment.Text = "Pay now";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // cmbSellers
            // 
            this.cmbSellers.FormattingEnabled = true;
            this.cmbSellers.Location = new System.Drawing.Point(136, 29);
            this.cmbSellers.Name = "cmbSellers";
            this.cmbSellers.Size = new System.Drawing.Size(279, 21);
            this.cmbSellers.TabIndex = 2;
            // 
            // cmbOrders
            // 
            this.cmbOrders.FormattingEnabled = true;
            this.cmbOrders.Location = new System.Drawing.Point(136, 67);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Size = new System.Drawing.Size(279, 21);
            this.cmbOrders.TabIndex = 3;
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Location = new System.Drawing.Point(94, 74);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(36, 13);
            this.lblOrderName.TabIndex = 4;
            this.lblOrderName.Text = "Order:";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(94, 37);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(36, 13);
            this.lblSeller.TabIndex = 5;
            this.lblSeller.Text = "Seller:";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(41, 115);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(89, 13);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Payment method:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(136, 107);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(279, 21);
            this.cmbPaymentMethod.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 357);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblOrderName);
            this.Controls.Add(this.cmbOrders);
            this.Controls.Add(this.cmbSellers);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.grdPayments);
            this.Name = "FrmMain";
            this.Text = "Payments Solution";
            ((System.ComponentModel.ISupportInitialize)(this.grdPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPayments;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.ComboBox cmbSellers;
        private System.Windows.Forms.ComboBox cmbOrders;
        private System.Windows.Forms.Label lblOrderName;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
    }
}

