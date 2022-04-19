namespace FuelStation.Win
{
    partial class CustomerF
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
            this.components = new System.ComponentModel.Container();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerCardNumber = new System.Windows.Forms.Label();
            this.ctrlCustomerSurname = new System.Windows.Forms.TextBox();
            this.ctrlCustomerName = new System.Windows.Forms.TextBox();
            this.ctrlCustomerCardNumber = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblCustomerSurname.Location = new System.Drawing.Point(34, 67);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(109, 15);
            this.lblCustomerSurname.TabIndex = 0;
            this.lblCustomerSurname.Text = "Customer Surname";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblCustomerName.Location = new System.Drawing.Point(49, 112);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(94, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCardNumber
            // 
            this.lblCustomerCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerCardNumber.AutoSize = true;
            this.lblCustomerCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblCustomerCardNumber.Location = new System.Drawing.Point(9, 157);
            this.lblCustomerCardNumber.Name = "lblCustomerCardNumber";
            this.lblCustomerCardNumber.Size = new System.Drawing.Size(134, 15);
            this.lblCustomerCardNumber.TabIndex = 2;
            this.lblCustomerCardNumber.Text = "Customer Card Number";
            // 
            // ctrlCustomerSurname
            // 
            this.ctrlCustomerSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCustomerSurname.Location = new System.Drawing.Point(149, 64);
            this.ctrlCustomerSurname.Name = "ctrlCustomerSurname";
            this.ctrlCustomerSurname.Size = new System.Drawing.Size(214, 23);
            this.ctrlCustomerSurname.TabIndex = 3;
            // 
            // ctrlCustomerName
            // 
            this.ctrlCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCustomerName.Location = new System.Drawing.Point(149, 109);
            this.ctrlCustomerName.Name = "ctrlCustomerName";
            this.ctrlCustomerName.Size = new System.Drawing.Size(214, 23);
            this.ctrlCustomerName.TabIndex = 4;
            // 
            // ctrlCustomerCardNumber
            // 
            this.ctrlCustomerCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCustomerCardNumber.Location = new System.Drawing.Point(149, 154);
            this.ctrlCustomerCardNumber.Name = "ctrlCustomerCardNumber";
            this.ctrlCustomerCardNumber.Size = new System.Drawing.Size(214, 23);
            this.ctrlCustomerCardNumber.TabIndex = 5;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnSaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCustomer.Location = new System.Drawing.Point(58, 291);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(124, 23);
            this.btnSaveCustomer.TabIndex = 6;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnCancelCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCustomer.Location = new System.Drawing.Point(188, 291);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(124, 23);
            this.btnCancelCustomer.TabIndex = 7;
            this.btnCancelCustomer.Text = "Cancel";
            this.btnCancelCustomer.UseVisualStyleBackColor = false;
            this.btnCancelCustomer.Click += new System.EventHandler(this.btnCancelCustomer_Click);
            // 
            // CustomerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnCancelCustomer);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.ctrlCustomerCardNumber);
            this.Controls.Add(this.ctrlCustomerName);
            this.Controls.Add(this.ctrlCustomerSurname);
            this.Controls.Add(this.lblCustomerCardNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerSurname);
            this.Name = "CustomerF";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCustomerSurname;
        private Label lblCustomerName;
        private Label lblCustomerCardNumber;
        private TextBox ctrlCustomerSurname;
        private TextBox ctrlCustomerName;
        private TextBox ctrlCustomerCardNumber;
        private Button btnSaveCustomer;
        private Button btnCancelCustomer;
        private BindingSource bsCustomer;
    }
}