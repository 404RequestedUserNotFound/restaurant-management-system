namespace Restaurant_Management_System
{
    partial class FoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Showfood = new System.Windows.Forms.Button();
            this.Foodsearchbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FoodSearch = new System.Windows.Forms.Button();
            this.DeleteFood = new System.Windows.Forms.Button();
            this.UpdateFood = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddFood = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(610, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total Number of availavle foods";
            // 
            // Showfood
            // 
            this.Showfood.Location = new System.Drawing.Point(450, 362);
            this.Showfood.Name = "Showfood";
            this.Showfood.Size = new System.Drawing.Size(231, 25);
            this.Showfood.TabIndex = 32;
            this.Showfood.Text = "Show Available Foods";
            this.Showfood.UseVisualStyleBackColor = true;
            this.Showfood.Click += new System.EventHandler(this.Showfood_Click);
            // 
            // Foodsearchbox
            // 
            this.Foodsearchbox.Location = new System.Drawing.Point(585, 336);
            this.Foodsearchbox.Name = "Foodsearchbox";
            this.Foodsearchbox.Size = new System.Drawing.Size(96, 20);
            this.Foodsearchbox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Enter Food Id to search";
            // 
            // FoodSearch
            // 
            this.FoodSearch.Location = new System.Drawing.Point(164, 286);
            this.FoodSearch.Name = "FoodSearch";
            this.FoodSearch.Size = new System.Drawing.Size(174, 25);
            this.FoodSearch.TabIndex = 29;
            this.FoodSearch.Text = "Search Food Item";
            this.FoodSearch.UseVisualStyleBackColor = true;
            this.FoodSearch.Click += new System.EventHandler(this.FoodSearch_Click);
            // 
            // DeleteFood
            // 
            this.DeleteFood.Location = new System.Drawing.Point(46, 286);
            this.DeleteFood.Name = "DeleteFood";
            this.DeleteFood.Size = new System.Drawing.Size(112, 25);
            this.DeleteFood.TabIndex = 28;
            this.DeleteFood.Text = "Delete Food Item";
            this.DeleteFood.UseVisualStyleBackColor = true;
            this.DeleteFood.Click += new System.EventHandler(this.DeleteFood_Click);
            // 
            // UpdateFood
            // 
            this.UpdateFood.Location = new System.Drawing.Point(164, 255);
            this.UpdateFood.Name = "UpdateFood";
            this.UpdateFood.Size = new System.Drawing.Size(174, 25);
            this.UpdateFood.TabIndex = 27;
            this.UpdateFood.Text = "Update Food Item";
            this.UpdateFood.UseVisualStyleBackColor = true;
            this.UpdateFood.Click += new System.EventHandler(this.UpdateFood_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Food Item Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "List of Food Items";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Food Item ID";
            // 
            // AddFood
            // 
            this.AddFood.Location = new System.Drawing.Point(46, 255);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(112, 25);
            this.AddFood.TabIndex = 21;
            this.AddFood.Text = "Add To Food Item";
            this.AddFood.UseVisualStyleBackColor = true;
            this.AddFood.Click += new System.EventHandler(this.AddFood_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(320, 179);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Food Item Name";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(817, 449);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Showfood);
            this.Controls.Add(this.Foodsearchbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FoodSearch);
            this.Controls.Add(this.DeleteFood);
            this.Controls.Add(this.UpdateFood);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddFood);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Showfood;
        private System.Windows.Forms.TextBox Foodsearchbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FoodSearch;
        private System.Windows.Forms.Button DeleteFood;
        private System.Windows.Forms.Button UpdateFood;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}