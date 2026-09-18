namespace SOLID
{
    partial class Form1
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
            txtCustomerEmail = new TextBox();
            dgvItems = new DataGridView();
            cmbDiscountType = new ComboBox();
            btnCalculate = new Button();
            btnSaveOrder = new Button();
            btnEmailInvoice = new Button();
            btnPrint = new Button();
            lblEmail = new Label();
            lblDiscount = new Label();
            lblItems = new Label();
            lblTotal = new Label();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(115, 106);
            txtCustomerEmail.Multiline = true;
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(306, 38);
            txtCustomerEmail.TabIndex = 0;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Qty });
            dgvItems.Location = new Point(514, 106);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(491, 296);
            dgvItems.TabIndex = 1;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // cmbDiscountType
            // 
            cmbDiscountType.FormattingEnabled = true;
            cmbDiscountType.Location = new Point(115, 211);
            cmbDiscountType.Name = "cmbDiscountType";
            cmbDiscountType.Size = new Size(306, 33);
            cmbDiscountType.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(115, 281);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 49);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSaveOrder.Location = new Point(255, 281);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(166, 49);
            btnSaveOrder.TabIndex = 3;
            btnSaveOrder.Text = "SAVE ORDER";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnEmailInvoice
            // 
            btnEmailInvoice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEmailInvoice.Location = new Point(115, 353);
            btnEmailInvoice.Name = "btnEmailInvoice";
            btnEmailInvoice.Size = new Size(306, 49);
            btnEmailInvoice.TabIndex = 3;
            btnEmailInvoice.Text = "EMAIL INVOICE";
            btnEmailInvoice.UseVisualStyleBackColor = true;
            btnEmailInvoice.Click += btnEmailInvoice_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(115, 422);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(306, 49);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "PRINT INVOICE";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 78);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(115, 183);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(82, 25);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Discount";
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("SimSun-ExtB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.Location = new Point(688, 40);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(145, 48);
            lblItems.TabIndex = 4;
            lblItems.Text = "ITEMS";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(734, 434);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "TOTAL";
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 8;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 150;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 555);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscount);
            Controls.Add(lblItems);
            Controls.Add(lblEmail);
            Controls.Add(btnPrint);
            Controls.Add(btnEmailInvoice);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCalculate);
            Controls.Add(cmbDiscountType);
            Controls.Add(dgvItems);
            Controls.Add(txtCustomerEmail);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerEmail;
        private DataGridView dgvItems;
        private ComboBox cmbDiscountType;
        private Button btnCalculate;
        private Button btnSaveOrder;
        private Button btnEmailInvoice;
        private Button btnPrint;
        private Label lblEmail;
        private Label lblDiscount;
        private Label lblItems;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
    }
}
