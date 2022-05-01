namespace Restaurant_Management_System
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.ItemNamelabel = new System.Windows.Forms.Label();
            this.ItemNametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.PuechaseListbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchItemtextBox = new System.Windows.Forms.TextBox();
            this.CustomerNamelabel = new System.Windows.Forms.Label();
            this.CustomerNametextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdlabel = new System.Windows.Forms.Label();
            this.CustomerIdtextBox = new System.Windows.Forms.TextBox();
            this.TotalPricelabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemNamelabel
            // 
            this.ItemNamelabel.AutoSize = true;
            this.ItemNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNamelabel.Location = new System.Drawing.Point(21, 94);
            this.ItemNamelabel.Name = "ItemNamelabel";
            this.ItemNamelabel.Size = new System.Drawing.Size(87, 20);
            this.ItemNamelabel.TabIndex = 32;
            this.ItemNamelabel.Text = "Item Name";
            // 
            // ItemNametextBox
            // 
            this.ItemNametextBox.Location = new System.Drawing.Point(24, 124);
            this.ItemNametextBox.Multiline = true;
            this.ItemNametextBox.Name = "ItemNametextBox";
            this.ItemNametextBox.Size = new System.Drawing.Size(149, 20);
            this.ItemNametextBox.TabIndex = 31;
            this.ItemNametextBox.TextChanged += new System.EventHandler(this.ItemNametextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(25, 382);
            this.PricetextBox.Multiline = true;
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(116, 20);
            this.PricetextBox.TabIndex = 29;
            this.PricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PricetextBox_KeyPress);
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylabel.Location = new System.Drawing.Point(22, 297);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(68, 20);
            this.Quantitylabel.TabIndex = 28;
            this.Quantitylabel.Text = "Quantity";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(26, 322);
            this.QuantitytextBox.Multiline = true;
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(116, 20);
            this.QuantitytextBox.TabIndex = 27;
            this.QuantitytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityBox_KeyPress);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(21, 23);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(44, 20);
            this.Datelabel.TabIndex = 26;
            this.Datelabel.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 305);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // Removebutton
            // 
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(298, 339);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(70, 23);
            this.Removebutton.TabIndex = 35;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(201, 339);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 36;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(298, 379);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(70, 23);
            this.Searchbutton.TabIndex = 37;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.Location = new System.Drawing.Point(200, 379);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 38;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // PuechaseListbutton
            // 
            this.PuechaseListbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuechaseListbutton.Location = new System.Drawing.Point(384, 362);
            this.PuechaseListbutton.Name = "PuechaseListbutton";
            this.PuechaseListbutton.Size = new System.Drawing.Size(109, 23);
            this.PuechaseListbutton.TabIndex = 39;
            this.PuechaseListbutton.Text = "Purchase List";
            this.PuechaseListbutton.UseVisualStyleBackColor = true;
            this.PuechaseListbutton.Click += new System.EventHandler(this.PuechaseListbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Search Item Name ";
            // 
            // SearchItemtextBox
            // 
            this.SearchItemtextBox.Location = new System.Drawing.Point(672, 339);
            this.SearchItemtextBox.Multiline = true;
            this.SearchItemtextBox.Name = "SearchItemtextBox";
            this.SearchItemtextBox.Size = new System.Drawing.Size(116, 20);
            this.SearchItemtextBox.TabIndex = 41;
            // 
            // CustomerNamelabel
            // 
            this.CustomerNamelabel.AutoSize = true;
            this.CustomerNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNamelabel.Location = new System.Drawing.Point(21, 165);
            this.CustomerNamelabel.Name = "CustomerNamelabel";
            this.CustomerNamelabel.Size = new System.Drawing.Size(124, 20);
            this.CustomerNamelabel.TabIndex = 42;
            this.CustomerNamelabel.Text = "Customer Name";
            // 
            // CustomerNametextBox
            // 
            this.CustomerNametextBox.Location = new System.Drawing.Point(24, 197);
            this.CustomerNametextBox.Multiline = true;
            this.CustomerNametextBox.Name = "CustomerNametextBox";
            this.CustomerNametextBox.Size = new System.Drawing.Size(149, 20);
            this.CustomerNametextBox.TabIndex = 43;
            // 
            // CustomerIdlabel
            // 
            this.CustomerIdlabel.AutoSize = true;
            this.CustomerIdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdlabel.Location = new System.Drawing.Point(21, 233);
            this.CustomerIdlabel.Name = "CustomerIdlabel";
            this.CustomerIdlabel.Size = new System.Drawing.Size(96, 20);
            this.CustomerIdlabel.TabIndex = 44;
            this.CustomerIdlabel.Text = "Customer Id";
            // 
            // CustomerIdtextBox
            // 
            this.CustomerIdtextBox.Location = new System.Drawing.Point(26, 262);
            this.CustomerIdtextBox.Multiline = true;
            this.CustomerIdtextBox.Name = "CustomerIdtextBox";
            this.CustomerIdtextBox.Size = new System.Drawing.Size(116, 20);
            this.CustomerIdtextBox.TabIndex = 45;
            this.CustomerIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerIdtextBox_KeyPress);
            // 
            // TotalPricelabel
            // 
            this.TotalPricelabel.AutoSize = true;
            this.TotalPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPricelabel.Location = new System.Drawing.Point(535, 382);
            this.TotalPricelabel.Name = "TotalPricelabel";
            this.TotalPricelabel.Size = new System.Drawing.Size(116, 24);
            this.TotalPricelabel.TabIndex = 46;
            this.TotalPricelabel.Text = "Total Price:";
            this.TotalPricelabel.Visible = false;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(647, 382);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(56, 24);
            this.Totallabel.TabIndex = 47;
            this.Totallabel.Text = "Total";
            this.Totallabel.Visible = false;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(812, 443);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.TotalPricelabel);
            this.Controls.Add(this.CustomerIdtextBox);
            this.Controls.Add(this.CustomerIdlabel);
            this.Controls.Add(this.CustomerNametextBox);
            this.Controls.Add(this.CustomerNamelabel);
            this.Controls.Add(this.SearchItemtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PuechaseListbutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ItemNamelabel);
            this.Controls.Add(this.ItemNametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.Quantitylabel);
            this.Controls.Add(this.QuantitytextBox);
            this.Controls.Add(this.Datelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseForm";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemNamelabel;
        private System.Windows.Forms.TextBox ItemNametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button PuechaseListbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchItemtextBox;
        private System.Windows.Forms.Label CustomerNamelabel;
        private System.Windows.Forms.TextBox CustomerNametextBox;
        private System.Windows.Forms.Label CustomerIdlabel;
        private System.Windows.Forms.TextBox CustomerIdtextBox;
        private System.Windows.Forms.Label TotalPricelabel;
        private System.Windows.Forms.Label Totallabel;
    }
}