namespace Restaurant_Management_System
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Totallabel = new System.Windows.Forms.Label();
            this.emptextSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Showemp = new System.Windows.Forms.Button();
            this.Empsearchbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empsearch = new System.Windows.Forms.Button();
            this.removeemp = new System.Windows.Forms.Button();
            this.Updateemp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emptextId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Addemp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emptextname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 53;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(297, 247);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(131, 13);
            this.Totallabel.TabIndex = 52;
            this.Totallabel.Text = "Total Number of employee";
            // 
            // emptextSalary
            // 
            this.emptextSalary.Location = new System.Drawing.Point(157, 152);
            this.emptextSalary.Name = "emptextSalary";
            this.emptextSalary.Size = new System.Drawing.Size(100, 20);
            this.emptextSalary.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Enter Employee Salary";
            // 
            // TypecomboBox1
            // 
            this.TypecomboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypecomboBox1.FormattingEnabled = true;
            this.TypecomboBox1.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Staff",
            "Cheff"});
            this.TypecomboBox1.Location = new System.Drawing.Point(157, 195);
            this.TypecomboBox1.Name = "TypecomboBox1";
            this.TypecomboBox1.Size = new System.Drawing.Size(100, 24);
            this.TypecomboBox1.TabIndex = 49;
            // 
            // Showemp
            // 
            this.Showemp.Location = new System.Drawing.Point(529, 371);
            this.Showemp.Name = "Showemp";
            this.Showemp.Size = new System.Drawing.Size(241, 25);
            this.Showemp.TabIndex = 48;
            this.Showemp.Text = "Show Employee";
            this.Showemp.UseVisualStyleBackColor = true;
            this.Showemp.Click += new System.EventHandler(this.Showemp_Click);
            // 
            // Empsearchbox
            // 
            this.Empsearchbox.Location = new System.Drawing.Point(670, 340);
            this.Empsearchbox.Name = "Empsearchbox";
            this.Empsearchbox.Size = new System.Drawing.Size(100, 20);
            this.Empsearchbox.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Enter employee ID to search";
            // 
            // empsearch
            // 
            this.empsearch.Location = new System.Drawing.Point(157, 374);
            this.empsearch.Name = "empsearch";
            this.empsearch.Size = new System.Drawing.Size(174, 25);
            this.empsearch.TabIndex = 45;
            this.empsearch.Text = "Search Employee";
            this.empsearch.UseVisualStyleBackColor = true;
            this.empsearch.Click += new System.EventHandler(this.empsearch_Click);
            // 
            // removeemp
            // 
            this.removeemp.Location = new System.Drawing.Point(39, 374);
            this.removeemp.Name = "removeemp";
            this.removeemp.Size = new System.Drawing.Size(112, 25);
            this.removeemp.TabIndex = 44;
            this.removeemp.Text = "Remove Employee";
            this.removeemp.UseVisualStyleBackColor = true;
            this.removeemp.Click += new System.EventHandler(this.removeemp_Click);
            // 
            // Updateemp
            // 
            this.Updateemp.Location = new System.Drawing.Point(157, 343);
            this.Updateemp.Name = "Updateemp";
            this.Updateemp.Size = new System.Drawing.Size(174, 25);
            this.Updateemp.TabIndex = 43;
            this.Updateemp.Text = "Update Employee Details";
            this.Updateemp.UseVisualStyleBackColor = true;
            this.Updateemp.Click += new System.EventHandler(this.Updateemp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Employee Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "List of Empployee";
            // 
            // emptextId
            // 
            this.emptextId.Location = new System.Drawing.Point(157, 109);
            this.emptextId.Name = "emptextId";
            this.emptextId.Size = new System.Drawing.Size(100, 20);
            this.emptextId.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Enter Employee Id";
            // 
            // Addemp
            // 
            this.Addemp.Location = new System.Drawing.Point(39, 343);
            this.Addemp.Name = "Addemp";
            this.Addemp.Size = new System.Drawing.Size(112, 25);
            this.Addemp.TabIndex = 38;
            this.Addemp.Text = "Add Emplyee";
            this.Addemp.UseVisualStyleBackColor = true;
            this.Addemp.Click += new System.EventHandler(this.Addemp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 192);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // emptextname
            // 
            this.emptextname.Location = new System.Drawing.Point(157, 66);
            this.emptextname.Name = "emptextname";
            this.emptextname.Size = new System.Drawing.Size(100, 20);
            this.emptextname.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter Employee Name";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(793, 506);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.emptextSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TypecomboBox1);
            this.Controls.Add(this.Showemp);
            this.Controls.Add(this.Empsearchbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empsearch);
            this.Controls.Add(this.removeemp);
            this.Controls.Add(this.Updateemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emptextId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addemp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.emptextname);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox emptextSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypecomboBox1;
        private System.Windows.Forms.Button Showemp;
        private System.Windows.Forms.TextBox Empsearchbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button empsearch;
        private System.Windows.Forms.Button removeemp;
        private System.Windows.Forms.Button Updateemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emptextId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addemp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox emptextname;
        private System.Windows.Forms.Label label1;
    }
}