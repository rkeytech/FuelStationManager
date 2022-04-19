namespace FuelStation.Win
{
    partial class TransactionLineF
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
            this.ctrlItemPrice = new System.Windows.Forms.NumericUpDown();
            this.ctrlQuantity = new System.Windows.Forms.NumericUpDown();
            this.ctrlItem = new System.Windows.Forms.ComboBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnCancelTransactionLine = new System.Windows.Forms.Button();
            this.btnSaveTransactionLine = new System.Windows.Forms.Button();
            this.ctrlTotalValue = new System.Windows.Forms.NumericUpDown();
            this.bsTransactionLine = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlItemPrice
            // 
            this.ctrlItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlItemPrice.DecimalPlaces = 2;
            this.ctrlItemPrice.Location = new System.Drawing.Point(137, 148);
            this.ctrlItemPrice.Name = "ctrlItemPrice";
            this.ctrlItemPrice.ReadOnly = true;
            this.ctrlItemPrice.Size = new System.Drawing.Size(214, 23);
            this.ctrlItemPrice.TabIndex = 32;
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlQuantity.DecimalPlaces = 3;
            this.ctrlQuantity.Location = new System.Drawing.Point(137, 107);
            this.ctrlQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(214, 23);
            this.ctrlQuantity.TabIndex = 31;
            this.ctrlQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlQuantity.ValueChanged += new System.EventHandler(this.ctrlQuantity_ValueChanged);
            // 
            // ctrlItem
            // 
            this.ctrlItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlItem.FormattingEnabled = true;
            this.ctrlItem.Location = new System.Drawing.Point(137, 64);
            this.ctrlItem.Name = "ctrlItem";
            this.ctrlItem.Size = new System.Drawing.Size(214, 23);
            this.ctrlItem.TabIndex = 30;
            this.ctrlItem.DropDownClosed += new System.EventHandler(this.ctrlItem_DropDownClosed);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItemPrice.Location = new System.Drawing.Point(40, 150);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(60, 15);
            this.lblItemPrice.TabIndex = 29;
            this.lblItemPrice.Text = "Item Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblQuantity.Location = new System.Drawing.Point(47, 109);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblTotalValue.Location = new System.Drawing.Point(37, 188);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(63, 15);
            this.lblTotalValue.TabIndex = 24;
            this.lblTotalValue.Text = "Total Value";
            // 
            // lblItem
            // 
            this.lblItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItem.AutoSize = true;
            this.lblItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItem.Location = new System.Drawing.Point(69, 67);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(31, 15);
            this.lblItem.TabIndex = 23;
            this.lblItem.Text = "Item";
            // 
            // btnCancelTransactionLine
            // 
            this.btnCancelTransactionLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelTransactionLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnCancelTransactionLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTransactionLine.Location = new System.Drawing.Point(193, 305);
            this.btnCancelTransactionLine.Name = "btnCancelTransactionLine";
            this.btnCancelTransactionLine.Size = new System.Drawing.Size(124, 23);
            this.btnCancelTransactionLine.TabIndex = 34;
            this.btnCancelTransactionLine.Text = "Cancel";
            this.btnCancelTransactionLine.UseVisualStyleBackColor = false;
            this.btnCancelTransactionLine.Click += new System.EventHandler(this.btnCancelTransactionLine_Click);
            // 
            // btnSaveTransactionLine
            // 
            this.btnSaveTransactionLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTransactionLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnSaveTransactionLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTransactionLine.Location = new System.Drawing.Point(63, 305);
            this.btnSaveTransactionLine.Name = "btnSaveTransactionLine";
            this.btnSaveTransactionLine.Size = new System.Drawing.Size(124, 23);
            this.btnSaveTransactionLine.TabIndex = 33;
            this.btnSaveTransactionLine.Text = "Save";
            this.btnSaveTransactionLine.UseVisualStyleBackColor = false;
            this.btnSaveTransactionLine.Click += new System.EventHandler(this.btnSaveTransactionLine_Click);
            // 
            // ctrlTotalValue
            // 
            this.ctrlTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalValue.DecimalPlaces = 2;
            this.ctrlTotalValue.Location = new System.Drawing.Point(137, 186);
            this.ctrlTotalValue.Name = "ctrlTotalValue";
            this.ctrlTotalValue.ReadOnly = true;
            this.ctrlTotalValue.Size = new System.Drawing.Size(214, 23);
            this.ctrlTotalValue.TabIndex = 35;
            // 
            // TransactionLineF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ctrlTotalValue);
            this.Controls.Add(this.btnCancelTransactionLine);
            this.Controls.Add(this.btnSaveTransactionLine);
            this.Controls.Add(this.ctrlItemPrice);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.ctrlItem);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblItem);
            this.Name = "TransactionLineF";
            this.Text = "Transaction Line";
            this.Load += new System.EventHandler(this.TransactionLineF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown ctrlItemPrice;
        private NumericUpDown ctrlQuantity;
        private ComboBox ctrlItem;
        private Label lblItemPrice;
        private Label lblQuantity;
        private Label lblTotalValue;
        private Label lblItem;
        private Button btnCancelTransactionLine;
        private Button btnSaveTransactionLine;
        private NumericUpDown ctrlTotalValue;
        private BindingSource bsTransactionLine;
    }
}