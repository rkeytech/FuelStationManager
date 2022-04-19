namespace FuelStation.Win
{
    partial class ItemF
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
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.ctrlItemDescription = new System.Windows.Forms.TextBox();
            this.ctrlItemCode = new System.Windows.Forms.TextBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.ctrlItemType = new System.Windows.Forms.ComboBox();
            this.ctrlItemCost = new System.Windows.Forms.NumericUpDown();
            this.ctrlItemPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Location = new System.Drawing.Point(197, 299);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(124, 23);
            this.btnCancelItem.TabIndex = 15;
            this.btnCancelItem.Text = "Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.Location = new System.Drawing.Point(67, 299);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(124, 23);
            this.btnSaveItem.TabIndex = 14;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // ctrlItemDescription
            // 
            this.ctrlItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlItemDescription.Location = new System.Drawing.Point(148, 82);
            this.ctrlItemDescription.Name = "ctrlItemDescription";
            this.ctrlItemDescription.Size = new System.Drawing.Size(214, 23);
            this.ctrlItemDescription.TabIndex = 12;
            // 
            // ctrlItemCode
            // 
            this.ctrlItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlItemCode.Location = new System.Drawing.Point(148, 41);
            this.ctrlItemCode.Name = "ctrlItemCode";
            this.ctrlItemCode.Size = new System.Drawing.Size(214, 23);
            this.ctrlItemCode.TabIndex = 11;
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItemType.Location = new System.Drawing.Point(53, 124);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(58, 15);
            this.lblItemType.TabIndex = 10;
            this.lblItemType.Text = "Item Type";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItemDescription.Location = new System.Drawing.Point(21, 85);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(94, 15);
            this.lblItemDescription.TabIndex = 9;
            this.lblItemDescription.Text = "Item Description";
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItemCode.Location = new System.Drawing.Point(53, 41);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(62, 15);
            this.lblItemCode.TabIndex = 8;
            this.lblItemCode.Text = "Item Code";
            // 
            // lblItemCost
            // 
            this.lblItemCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItemCost.Location = new System.Drawing.Point(53, 166);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(58, 15);
            this.lblItemCost.TabIndex = 16;
            this.lblItemCost.Text = "Item Cost";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblItemPrice.Location = new System.Drawing.Point(51, 206);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(60, 15);
            this.lblItemPrice.TabIndex = 18;
            this.lblItemPrice.Text = "Item Price";
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlItemType.FormattingEnabled = true;
            this.ctrlItemType.Location = new System.Drawing.Point(148, 121);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Size = new System.Drawing.Size(214, 23);
            this.ctrlItemType.TabIndex = 20;
            // 
            // ctrlItemCost
            // 
            this.ctrlItemCost.DecimalPlaces = 2;
            this.ctrlItemCost.Location = new System.Drawing.Point(148, 164);
            this.ctrlItemCost.Name = "ctrlItemCost";
            this.ctrlItemCost.Size = new System.Drawing.Size(214, 23);
            this.ctrlItemCost.TabIndex = 21;
            // 
            // ctrlItemPrice
            // 
            this.ctrlItemPrice.DecimalPlaces = 2;
            this.ctrlItemPrice.Location = new System.Drawing.Point(148, 204);
            this.ctrlItemPrice.Name = "ctrlItemPrice";
            this.ctrlItemPrice.Size = new System.Drawing.Size(214, 23);
            this.ctrlItemPrice.TabIndex = 22;
            // 
            // ItemF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ctrlItemPrice);
            this.Controls.Add(this.ctrlItemCost);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemCost);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.ctrlItemDescription);
            this.Controls.Add(this.ctrlItemCode);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.lblItemCode);
            this.Name = "ItemF";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.ItemF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bsItem;
        private Button btnCancelCustomer;
        private Button btnSaveCustomer;
        private TextBox ctrlItemDescription;
        private TextBox ctrlItemCode;
        private Label lblItemType;
        private Label lblItemDescription;
        private Label lblItemCode;
        private Label lblItemCost;
        private Label lblItemPrice;
        private ComboBox ctrlItemType;
        private NumericUpDown ctrlItemCost;
        private NumericUpDown ctrlItemPrice;
        private Button btnCancelItem;
        private Button btnSaveItem;
    }
}