namespace Restaurant_Management_System
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.Customernamelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Idlabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.Customerlistbutton = new System.Windows.Forms.Button();
            this.Totallabel = new System.Windows.Forms.Label();
            this.TotalCustomerlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Customernamelabel
            // 
            this.Customernamelabel.AutoSize = true;
            this.Customernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Customernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customernamelabel.ForeColor = System.Drawing.Color.White;
            this.Customernamelabel.Location = new System.Drawing.Point(29, 28);
            this.Customernamelabel.Name = "Customernamelabel";
            this.Customernamelabel.Size = new System.Drawing.Size(118, 18);
            this.Customernamelabel.TabIndex = 0;
            this.Customernamelabel.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Contact";
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(32, 59);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(180, 21);
            this.NametextBox.TabIndex = 2;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContacttextBox.Location = new System.Drawing.Point(32, 290);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(180, 21);
            this.ContacttextBox.TabIndex = 3;
            this.ContacttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContacttextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Address";
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddresstextBox.Location = new System.Drawing.Point(32, 212);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(180, 21);
            this.AddresstextBox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 305);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Insertbutton
            // 
            this.Insertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbutton.ForeColor = System.Drawing.Color.White;
            this.Insertbutton.Location = new System.Drawing.Point(32, 339);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(75, 23);
            this.Insertbutton.TabIndex = 7;
            this.Insertbutton.Text = "Insert";
            this.Insertbutton.UseVisualStyleBackColor = false;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(137, 339);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(32, 380);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.ForeColor = System.Drawing.Color.White;
            this.Searchbutton.Location = new System.Drawing.Point(137, 380);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 10;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.ForeColor = System.Drawing.Color.White;
            this.Searchlabel.Location = new System.Drawing.Point(360, 357);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(140, 18);
            this.Searchlabel.TabIndex = 11;
            this.Searchlabel.Text = "Search Customer Id";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(532, 357);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(180, 21);
            this.SearchtextBox.TabIndex = 12;
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.BackColor = System.Drawing.Color.Transparent;
            this.Idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel.ForeColor = System.Drawing.Color.White;
            this.Idlabel.Location = new System.Drawing.Point(29, 101);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(89, 18);
            this.Idlabel.TabIndex = 13;
            this.Idlabel.Text = "Customer Id";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdtextBox.Location = new System.Drawing.Point(32, 136);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(180, 21);
            this.IdtextBox.TabIndex = 14;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // Customerlistbutton
            // 
            this.Customerlistbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Customerlistbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerlistbutton.ForeColor = System.Drawing.Color.White;
            this.Customerlistbutton.Location = new System.Drawing.Point(235, 380);
            this.Customerlistbutton.Name = "Customerlistbutton";
            this.Customerlistbutton.Size = new System.Drawing.Size(75, 23);
            this.Customerlistbutton.TabIndex = 15;
            this.Customerlistbutton.Text = "List";
            this.Customerlistbutton.UseVisualStyleBackColor = false;
            this.Customerlistbutton.Click += new System.EventHandler(this.Customerlistbutton_Click);
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.Color.Transparent;
            this.Totallabel.Location = new System.Drawing.Point(578, 405);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(56, 24);
            this.Totallabel.TabIndex = 49;
            this.Totallabel.Text = "Total";
            this.Totallabel.Visible = false;
            this.Totallabel.Click += new System.EventHandler(this.Totallabel_Click);
            // 
            // TotalCustomerlabel
            // 
            this.TotalCustomerlabel.AutoSize = true;
            this.TotalCustomerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCustomerlabel.ForeColor = System.Drawing.Color.Transparent;
            this.TotalCustomerlabel.Location = new System.Drawing.Point(425, 405);
            this.TotalCustomerlabel.Name = "TotalCustomerlabel";
            this.TotalCustomerlabel.Size = new System.Drawing.Size(157, 24);
            this.TotalCustomerlabel.TabIndex = 48;
            this.TotalCustomerlabel.Text = "Total Customer:";
            this.TotalCustomerlabel.Visible = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(757, 464);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.TotalCustomerlabel);
            this.Controls.Add(this.Customerlistbutton);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customernamelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customernamelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insertbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button Customerlistbutton;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Label TotalCustomerlabel;
    }
}