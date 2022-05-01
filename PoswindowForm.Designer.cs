namespace Restaurant_Management_System
{
    partial class PoswindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoswindowForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ItemtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CashiertextBox = new System.Windows.Forms.TextBox();
            this.Timelabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Idlabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.ReceiptgroupBox = new System.Windows.Forms.GroupBox();
            this.Orderbutton = new System.Windows.Forms.Button();
            this.Receiptbutton = new System.Windows.Forms.Button();
            this.TotalPricetextBox = new System.Windows.Forms.TextBox();
            this.ItemQuantitytextBox = new System.Windows.Forms.TextBox();
            this.ItemPricetextBox = new System.Windows.Forms.TextBox();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.TotalPricelabel = new System.Windows.Forms.Label();
            this.ItemQuantitylabel = new System.Windows.Forms.Label();
            this.ItemPricelabel = new System.Windows.Forms.Label();
            this.ItemNamelabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReturnedAmounttextBox = new System.Windows.Forms.TextBox();
            this.PaidAmounttextBox = new System.Windows.Forms.TextBox();
            this.ReturnedAmountlabel = new System.Windows.Forms.Label();
            this.PaidAmountlabel = new System.Windows.Forms.Label();
            this.PaymentTypecomboBox = new System.Windows.Forms.ComboBox();
            this.PaymentTypelabel = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Confirmtbutton = new System.Windows.Forms.Button();
            this.TotalPaymenttextBox = new System.Windows.Forms.TextBox();
            this.TotalPaymentlabel = new System.Windows.Forms.Label();
            this.WithvatTotaltextBox = new System.Windows.Forms.TextBox();
            this.VattextBox = new System.Windows.Forms.TextBox();
            this.TotalPaytextBox = new System.Windows.Forms.TextBox();
            this.WithvatTotallabel = new System.Windows.Forms.Label();
            this.Vatlabel = new System.Windows.Forms.Label();
            this.TotalPaylabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ReceiptgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Item";
            // 
            // ItemtextBox
            // 
            this.ItemtextBox.Location = new System.Drawing.Point(124, 25);
            this.ItemtextBox.Multiline = true;
            this.ItemtextBox.Name = "ItemtextBox";
            this.ItemtextBox.Size = new System.Drawing.Size(202, 20);
            this.ItemtextBox.TabIndex = 1;
            this.ItemtextBox.TextChanged += new System.EventHandler(this.ItemtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(652, 306);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cashier Name";
            // 
            // CashiertextBox
            // 
            this.CashiertextBox.Location = new System.Drawing.Point(478, 27);
            this.CashiertextBox.Multiline = true;
            this.CashiertextBox.Name = "CashiertextBox";
            this.CashiertextBox.Size = new System.Drawing.Size(106, 20);
            this.CashiertextBox.TabIndex = 4;
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.BackColor = System.Drawing.Color.Transparent;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(887, 23);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(43, 20);
            this.Timelabel.TabIndex = 5;
            this.Timelabel.Text = "Time";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.BackColor = System.Drawing.Color.Transparent;
            this.Idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel.Location = new System.Drawing.Point(615, 27);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(96, 20);
            this.Idlabel.TabIndex = 10;
            this.Idlabel.Text = "Customer Id";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(717, 29);
            this.IdtextBox.Multiline = true;
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(106, 20);
            this.IdtextBox.TabIndex = 11;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // ReceiptgroupBox
            // 
            this.ReceiptgroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ReceiptgroupBox.Controls.Add(this.Orderbutton);
            this.ReceiptgroupBox.Controls.Add(this.Receiptbutton);
            this.ReceiptgroupBox.Controls.Add(this.TotalPricetextBox);
            this.ReceiptgroupBox.Controls.Add(this.ItemQuantitytextBox);
            this.ReceiptgroupBox.Controls.Add(this.ItemPricetextBox);
            this.ReceiptgroupBox.Controls.Add(this.ItemNametextBox);
            this.ReceiptgroupBox.Controls.Add(this.TotalPricelabel);
            this.ReceiptgroupBox.Controls.Add(this.ItemQuantitylabel);
            this.ReceiptgroupBox.Controls.Add(this.ItemPricelabel);
            this.ReceiptgroupBox.Controls.Add(this.ItemNamelabel);
            this.ReceiptgroupBox.Location = new System.Drawing.Point(26, 68);
            this.ReceiptgroupBox.Name = "ReceiptgroupBox";
            this.ReceiptgroupBox.Size = new System.Drawing.Size(270, 213);
            this.ReceiptgroupBox.TabIndex = 13;
            this.ReceiptgroupBox.TabStop = false;
            this.ReceiptgroupBox.Text = "Add to Receipt";
            // 
            // Orderbutton
            // 
            this.Orderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbutton.Location = new System.Drawing.Point(152, 170);
            this.Orderbutton.Name = "Orderbutton";
            this.Orderbutton.Size = new System.Drawing.Size(95, 25);
            this.Orderbutton.TabIndex = 10;
            this.Orderbutton.Text = "Order List";
            this.Orderbutton.UseVisualStyleBackColor = true;
            this.Orderbutton.Click += new System.EventHandler(this.Orderbutton_Click);
            // 
            // Receiptbutton
            // 
            this.Receiptbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiptbutton.Location = new System.Drawing.Point(32, 170);
            this.Receiptbutton.Name = "Receiptbutton";
            this.Receiptbutton.Size = new System.Drawing.Size(95, 25);
            this.Receiptbutton.TabIndex = 9;
            this.Receiptbutton.Text = "Add to Receipt";
            this.Receiptbutton.UseVisualStyleBackColor = true;
            this.Receiptbutton.Click += new System.EventHandler(this.Receiptbutton_Click);
            // 
            // TotalPricetextBox
            // 
            this.TotalPricetextBox.Location = new System.Drawing.Point(116, 127);
            this.TotalPricetextBox.Multiline = true;
            this.TotalPricetextBox.Name = "TotalPricetextBox";
            this.TotalPricetextBox.Size = new System.Drawing.Size(119, 20);
            this.TotalPricetextBox.TabIndex = 8;
            // 
            // ItemQuantitytextBox
            // 
            this.ItemQuantitytextBox.Location = new System.Drawing.Point(116, 90);
            this.ItemQuantitytextBox.Multiline = true;
            this.ItemQuantitytextBox.Name = "ItemQuantitytextBox";
            this.ItemQuantitytextBox.Size = new System.Drawing.Size(119, 20);
            this.ItemQuantitytextBox.TabIndex = 7;
            this.ItemQuantitytextBox.TextChanged += new System.EventHandler(this.ItemQuantitytextBox_TextChanged);
            this.ItemQuantitytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemQuantitytextBox_KeyPress);
            // 
            // ItemPricetextBox
            // 
            this.ItemPricetextBox.Location = new System.Drawing.Point(114, 60);
            this.ItemPricetextBox.Multiline = true;
            this.ItemPricetextBox.Name = "ItemPricetextBox";
            this.ItemPricetextBox.Size = new System.Drawing.Size(121, 20);
            this.ItemPricetextBox.TabIndex = 6;
            this.ItemPricetextBox.TextChanged += new System.EventHandler(this.ItemPricetextBox_TextChanged);
            this.ItemPricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemPricetextBox_KeyPress);
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.Location = new System.Drawing.Point(114, 30);
            this.ItemNametextBox.Multiline = true;
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(121, 20);
            this.ItemNametextBox.TabIndex = 5;
            // 
            // TotalPricelabel
            // 
            this.TotalPricelabel.AutoSize = true;
            this.TotalPricelabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPricelabel.Location = new System.Drawing.Point(6, 127);
            this.TotalPricelabel.Name = "TotalPricelabel";
            this.TotalPricelabel.Size = new System.Drawing.Size(83, 20);
            this.TotalPricelabel.TabIndex = 4;
            this.TotalPricelabel.Text = "Total Price";
            // 
            // ItemQuantitylabel
            // 
            this.ItemQuantitylabel.AutoSize = true;
            this.ItemQuantitylabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemQuantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantitylabel.Location = new System.Drawing.Point(6, 90);
            this.ItemQuantitylabel.Name = "ItemQuantitylabel";
            this.ItemQuantitylabel.Size = new System.Drawing.Size(104, 20);
            this.ItemQuantitylabel.TabIndex = 3;
            this.ItemQuantitylabel.Text = "Item Quantity";
            // 
            // ItemPricelabel
            // 
            this.ItemPricelabel.AutoSize = true;
            this.ItemPricelabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPricelabel.Location = new System.Drawing.Point(6, 60);
            this.ItemPricelabel.Name = "ItemPricelabel";
            this.ItemPricelabel.Size = new System.Drawing.Size(80, 20);
            this.ItemPricelabel.TabIndex = 2;
            this.ItemPricelabel.Text = "Item Price";
            // 
            // ItemNamelabel
            // 
            this.ItemNamelabel.AutoSize = true;
            this.ItemNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNamelabel.Location = new System.Drawing.Point(6, 30);
            this.ItemNamelabel.Name = "ItemNamelabel";
            this.ItemNamelabel.Size = new System.Drawing.Size(87, 20);
            this.ItemNamelabel.TabIndex = 1;
            this.ItemNamelabel.Text = "Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ReturnedAmounttextBox);
            this.groupBox1.Controls.Add(this.PaidAmounttextBox);
            this.groupBox1.Controls.Add(this.ReturnedAmountlabel);
            this.groupBox1.Controls.Add(this.PaidAmountlabel);
            this.groupBox1.Controls.Add(this.PaymentTypecomboBox);
            this.groupBox1.Controls.Add(this.PaymentTypelabel);
            this.groupBox1.Controls.Add(this.Clearbutton);
            this.groupBox1.Controls.Add(this.Confirmtbutton);
            this.groupBox1.Controls.Add(this.TotalPaymenttextBox);
            this.groupBox1.Controls.Add(this.TotalPaymentlabel);
            this.groupBox1.Controls.Add(this.WithvatTotaltextBox);
            this.groupBox1.Controls.Add(this.VattextBox);
            this.groupBox1.Controls.Add(this.TotalPaytextBox);
            this.groupBox1.Controls.Add(this.WithvatTotallabel);
            this.groupBox1.Controls.Add(this.Vatlabel);
            this.groupBox1.Controls.Add(this.TotalPaylabel);
            this.groupBox1.Location = new System.Drawing.Point(26, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 302);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // ReturnedAmounttextBox
            // 
            this.ReturnedAmounttextBox.Location = new System.Drawing.Point(186, 220);
            this.ReturnedAmounttextBox.Multiline = true;
            this.ReturnedAmounttextBox.Name = "ReturnedAmounttextBox";
            this.ReturnedAmounttextBox.Size = new System.Drawing.Size(159, 20);
            this.ReturnedAmounttextBox.TabIndex = 52;
            this.ReturnedAmounttextBox.Visible = false;
            // 
            // PaidAmounttextBox
            // 
            this.PaidAmounttextBox.Location = new System.Drawing.Point(186, 188);
            this.PaidAmounttextBox.Multiline = true;
            this.PaidAmounttextBox.Name = "PaidAmounttextBox";
            this.PaidAmounttextBox.Size = new System.Drawing.Size(159, 20);
            this.PaidAmounttextBox.TabIndex = 51;
            this.PaidAmounttextBox.Visible = false;
            this.PaidAmounttextBox.TextChanged += new System.EventHandler(this.PaidAmounttextBox_TextChanged);
            this.PaidAmounttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaidAmounttextBox_KeyPress);
            // 
            // ReturnedAmountlabel
            // 
            this.ReturnedAmountlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnedAmountlabel.AutoSize = true;
            this.ReturnedAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedAmountlabel.Location = new System.Drawing.Point(15, 218);
            this.ReturnedAmountlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReturnedAmountlabel.Name = "ReturnedAmountlabel";
            this.ReturnedAmountlabel.Size = new System.Drawing.Size(136, 20);
            this.ReturnedAmountlabel.TabIndex = 50;
            this.ReturnedAmountlabel.Text = "Returned Amount";
            this.ReturnedAmountlabel.Visible = false;
            // 
            // PaidAmountlabel
            // 
            this.PaidAmountlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaidAmountlabel.AutoSize = true;
            this.PaidAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmountlabel.Location = new System.Drawing.Point(15, 186);
            this.PaidAmountlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PaidAmountlabel.Name = "PaidAmountlabel";
            this.PaidAmountlabel.Size = new System.Drawing.Size(100, 20);
            this.PaidAmountlabel.TabIndex = 49;
            this.PaidAmountlabel.Text = "Paid Amount";
            this.PaidAmountlabel.Visible = false;
            // 
            // PaymentTypecomboBox
            // 
            this.PaymentTypecomboBox.FormattingEnabled = true;
            this.PaymentTypecomboBox.Items.AddRange(new object[] {
            "cash",
            "bkash"});
            this.PaymentTypecomboBox.Location = new System.Drawing.Point(186, 155);
            this.PaymentTypecomboBox.Name = "PaymentTypecomboBox";
            this.PaymentTypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.PaymentTypecomboBox.TabIndex = 14;
            this.PaymentTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.PaymentTypecomboBox_SelectedIndexChanged);
            // 
            // PaymentTypelabel
            // 
            this.PaymentTypelabel.AutoSize = true;
            this.PaymentTypelabel.BackColor = System.Drawing.Color.Transparent;
            this.PaymentTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypelabel.Location = new System.Drawing.Point(15, 153);
            this.PaymentTypelabel.Name = "PaymentTypelabel";
            this.PaymentTypelabel.Size = new System.Drawing.Size(109, 20);
            this.PaymentTypelabel.TabIndex = 13;
            this.PaymentTypelabel.Text = "Payment Type";
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(212, 260);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(95, 25);
            this.Clearbutton.TabIndex = 10;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Confirmtbutton
            // 
            this.Confirmtbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmtbutton.Location = new System.Drawing.Point(66, 260);
            this.Confirmtbutton.Name = "Confirmtbutton";
            this.Confirmtbutton.Size = new System.Drawing.Size(95, 25);
            this.Confirmtbutton.TabIndex = 9;
            this.Confirmtbutton.Text = "Confirm";
            this.Confirmtbutton.UseVisualStyleBackColor = true;
            this.Confirmtbutton.Click += new System.EventHandler(this.Confirmtbutton_Click);
            // 
            // TotalPaymenttextBox
            // 
            this.TotalPaymenttextBox.Location = new System.Drawing.Point(186, 124);
            this.TotalPaymenttextBox.Multiline = true;
            this.TotalPaymenttextBox.Name = "TotalPaymenttextBox";
            this.TotalPaymenttextBox.Size = new System.Drawing.Size(159, 20);
            this.TotalPaymenttextBox.TabIndex = 12;
            // 
            // TotalPaymentlabel
            // 
            this.TotalPaymentlabel.AutoSize = true;
            this.TotalPaymentlabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPaymentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaymentlabel.Location = new System.Drawing.Point(15, 122);
            this.TotalPaymentlabel.Name = "TotalPaymentlabel";
            this.TotalPaymentlabel.Size = new System.Drawing.Size(110, 20);
            this.TotalPaymentlabel.TabIndex = 11;
            this.TotalPaymentlabel.Text = "Total Payment";
            // 
            // WithvatTotaltextBox
            // 
            this.WithvatTotaltextBox.Location = new System.Drawing.Point(186, 89);
            this.WithvatTotaltextBox.Multiline = true;
            this.WithvatTotaltextBox.Name = "WithvatTotaltextBox";
            this.WithvatTotaltextBox.Size = new System.Drawing.Size(159, 20);
            this.WithvatTotaltextBox.TabIndex = 8;
            // 
            // VattextBox
            // 
            this.VattextBox.Location = new System.Drawing.Point(186, 56);
            this.VattextBox.Multiline = true;
            this.VattextBox.Name = "VattextBox";
            this.VattextBox.Size = new System.Drawing.Size(159, 20);
            this.VattextBox.TabIndex = 6;
            this.VattextBox.TextChanged += new System.EventHandler(this.VattextBox_TextChanged);
            this.VattextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VattextBox_KeyPress);
            // 
            // TotalPaytextBox
            // 
            this.TotalPaytextBox.Location = new System.Drawing.Point(186, 25);
            this.TotalPaytextBox.Multiline = true;
            this.TotalPaytextBox.Name = "TotalPaytextBox";
            this.TotalPaytextBox.Size = new System.Drawing.Size(159, 20);
            this.TotalPaytextBox.TabIndex = 5;
            // 
            // WithvatTotallabel
            // 
            this.WithvatTotallabel.AutoSize = true;
            this.WithvatTotallabel.BackColor = System.Drawing.Color.Transparent;
            this.WithvatTotallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithvatTotallabel.Location = new System.Drawing.Point(15, 87);
            this.WithvatTotallabel.Name = "WithvatTotallabel";
            this.WithvatTotallabel.Size = new System.Drawing.Size(70, 20);
            this.WithvatTotallabel.TabIndex = 4;
            this.WithvatTotallabel.Text = "With Vat";
            // 
            // Vatlabel
            // 
            this.Vatlabel.AutoSize = true;
            this.Vatlabel.BackColor = System.Drawing.Color.Transparent;
            this.Vatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vatlabel.Location = new System.Drawing.Point(15, 56);
            this.Vatlabel.Name = "Vatlabel";
            this.Vatlabel.Size = new System.Drawing.Size(38, 20);
            this.Vatlabel.TabIndex = 2;
            this.Vatlabel.Text = "Vat ";
            // 
            // TotalPaylabel
            // 
            this.TotalPaylabel.AutoSize = true;
            this.TotalPaylabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaylabel.Location = new System.Drawing.Point(15, 25);
            this.TotalPaylabel.Name = "TotalPaylabel";
            this.TotalPaylabel.Size = new System.Drawing.Size(44, 20);
            this.TotalPaylabel.TabIndex = 1;
            this.TotalPaylabel.Text = "Total";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(412, 387);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(652, 228);
            this.listBox.TabIndex = 15;
            // 
            // PoswindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1076, 631);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReceiptgroupBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.CashiertextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ItemtextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PoswindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pos Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoswindowForm_FormClosing);
            this.Load += new System.EventHandler(this.PoswindowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ReceiptgroupBox.ResumeLayout(false);
            this.ReceiptgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CashiertextBox;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.GroupBox ReceiptgroupBox;
        private System.Windows.Forms.Button Orderbutton;
        private System.Windows.Forms.Button Receiptbutton;
        private System.Windows.Forms.TextBox TotalPricetextBox;
        private System.Windows.Forms.TextBox ItemQuantitytextBox;
        private System.Windows.Forms.TextBox ItemPricetextBox;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.Label TotalPricelabel;
        private System.Windows.Forms.Label ItemQuantitylabel;
        private System.Windows.Forms.Label ItemPricelabel;
        private System.Windows.Forms.Label ItemNamelabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ReturnedAmounttextBox;
        private System.Windows.Forms.TextBox PaidAmounttextBox;
        private System.Windows.Forms.Label ReturnedAmountlabel;
        private System.Windows.Forms.Label PaidAmountlabel;
        private System.Windows.Forms.ComboBox PaymentTypecomboBox;
        private System.Windows.Forms.Label PaymentTypelabel;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Confirmtbutton;
        private System.Windows.Forms.TextBox TotalPaymenttextBox;
        private System.Windows.Forms.Label TotalPaymentlabel;
        private System.Windows.Forms.TextBox WithvatTotaltextBox;
        private System.Windows.Forms.TextBox VattextBox;
        private System.Windows.Forms.TextBox TotalPaytextBox;
        private System.Windows.Forms.Label WithvatTotallabel;
        private System.Windows.Forms.Label Vatlabel;
        private System.Windows.Forms.Label TotalPaylabel;
        private System.Windows.Forms.ListBox listBox;
    }
}