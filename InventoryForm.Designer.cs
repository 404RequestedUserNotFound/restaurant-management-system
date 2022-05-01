namespace Restaurant_Management_System
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.Idlabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.Productnamelabel = new System.Windows.Forms.Label();
            this.ProductNametextBox = new System.Windows.Forms.TextBox();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Inventorylistbutton = new System.Windows.Forms.Button();
            this.Totalinventorylabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.BackColor = System.Drawing.Color.Transparent;
            this.Idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel.ForeColor = System.Drawing.Color.Transparent;
            this.Idlabel.Location = new System.Drawing.Point(33, 30);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(92, 20);
            this.Idlabel.TabIndex = 4;
            this.Idlabel.Text = "Inventory Id";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(37, 68);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(118, 20);
            this.IdtextBox.TabIndex = 5;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // Productnamelabel
            // 
            this.Productnamelabel.AutoSize = true;
            this.Productnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Productnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productnamelabel.ForeColor = System.Drawing.Color.Transparent;
            this.Productnamelabel.Location = new System.Drawing.Point(33, 116);
            this.Productnamelabel.Name = "Productnamelabel";
            this.Productnamelabel.Size = new System.Drawing.Size(110, 20);
            this.Productnamelabel.TabIndex = 6;
            this.Productnamelabel.Text = "Product Name";
            // 
            // ProductNametextBox
            // 
            this.ProductNametextBox.Location = new System.Drawing.Point(37, 150);
            this.ProductNametextBox.Name = "ProductNametextBox";
            this.ProductNametextBox.Size = new System.Drawing.Size(118, 20);
            this.ProductNametextBox.TabIndex = 7;
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(37, 235);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantitytextBox.TabIndex = 8;
            this.QuantitytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantitytextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 225);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Gray;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Addbutton.Location = new System.Drawing.Point(37, 295);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 13;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.Color.Gray;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.ForeColor = System.Drawing.Color.Transparent;
            this.Removebutton.Location = new System.Drawing.Point(136, 295);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(75, 23);
            this.Removebutton.TabIndex = 14;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Gray;
            this.Editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Editbutton.Location = new System.Drawing.Point(37, 339);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 15;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.Gray;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Searchbutton.Location = new System.Drawing.Point(136, 339);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 16;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.ForeColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Location = new System.Drawing.Point(263, 298);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(147, 20);
            this.Searchlabel.TabIndex = 17;
            this.Searchlabel.Text = "Search Inventory Id";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(416, 297);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(130, 20);
            this.SearchtextBox.TabIndex = 18;
            // 
            // Inventorylistbutton
            // 
            this.Inventorylistbutton.BackColor = System.Drawing.Color.Gray;
            this.Inventorylistbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventorylistbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Inventorylistbutton.Location = new System.Drawing.Point(235, 339);
            this.Inventorylistbutton.Name = "Inventorylistbutton";
            this.Inventorylistbutton.Size = new System.Drawing.Size(75, 23);
            this.Inventorylistbutton.TabIndex = 19;
            this.Inventorylistbutton.Text = "List";
            this.Inventorylistbutton.UseVisualStyleBackColor = false;
            this.Inventorylistbutton.Click += new System.EventHandler(this.Inventorylistbutton_Click);
            // 
            // Totalinventorylabel
            // 
            this.Totalinventorylabel.AutoSize = true;
            this.Totalinventorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalinventorylabel.ForeColor = System.Drawing.Color.White;
            this.Totalinventorylabel.Location = new System.Drawing.Point(365, 339);
            this.Totalinventorylabel.Name = "Totalinventorylabel";
            this.Totalinventorylabel.Size = new System.Drawing.Size(153, 24);
            this.Totalinventorylabel.TabIndex = 47;
            this.Totalinventorylabel.Text = "Total Inventory:";
            this.Totalinventorylabel.Visible = false;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.Color.White;
            this.Totallabel.Location = new System.Drawing.Point(513, 339);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(62, 24);
            this.Totallabel.TabIndex = 48;
            this.Totallabel.Text = "Total ";
            this.Totallabel.Visible = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(619, 398);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Totalinventorylabel);
            this.Controls.Add(this.Inventorylistbutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantitytextBox);
            this.Controls.Add(this.ProductNametextBox);
            this.Controls.Add(this.Productnamelabel);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Idlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label Productnamelabel;
        private System.Windows.Forms.TextBox ProductNametextBox;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Inventorylistbutton;
        private System.Windows.Forms.Label Totalinventorylabel;
        private System.Windows.Forms.Label Totallabel;
    }
}