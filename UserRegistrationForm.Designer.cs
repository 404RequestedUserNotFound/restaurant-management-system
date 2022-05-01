namespace Restaurant_Management_System
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.Namelabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Typelabel = new System.Windows.Forms.Label();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.PasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Phonenumberlabel = new System.Windows.Forms.Label();
            this.PhonenumbertextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Singupbutton = new System.Windows.Forms.Button();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(26, 27);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(86, 16);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "User Name";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(26, 55);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(52, 16);
            this.Emaillabel.TabIndex = 1;
            this.Emaillabel.Text = "E-Mail";
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.Location = new System.Drawing.Point(26, 85);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(66, 16);
            this.Addresslabel.TabIndex = 2;
            this.Addresslabel.Text = "Address";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(26, 114);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(76, 16);
            this.Passwordlabel.TabIndex = 3;
            this.Passwordlabel.Text = "Password";
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typelabel.Location = new System.Drawing.Point(26, 150);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(81, 16);
            this.Typelabel.TabIndex = 4;
            this.Typelabel.Text = "User Type";
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Staff"});
            this.TypecomboBox.Location = new System.Drawing.Point(156, 150);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(102, 21);
            this.TypecomboBox.TabIndex = 5;
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.Location = new System.Drawing.Point(262, 114);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(15, 24);
            this.PasswordcheckBox.TabIndex = 6;
            this.PasswordcheckBox.Text = "PasswprdcheckBox";
            this.PasswordcheckBox.UseVisualStyleBackColor = true;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.PasswordcheckBox_CheckedChanged);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(156, 115);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox.TabIndex = 7;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(156, 85);
            this.AddresstextBox.Multiline = true;
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(100, 20);
            this.AddresstextBox.TabIndex = 8;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(156, 55);
            this.EmailtextBox.Multiline = true;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailtextBox.TabIndex = 9;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(156, 23);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 10;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gender";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(26, 221);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(41, 16);
            this.Datelabel.TabIndex = 15;
            this.Datelabel.Text = "Date";
            // 
            // Phonenumberlabel
            // 
            this.Phonenumberlabel.AutoSize = true;
            this.Phonenumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonenumberlabel.Location = new System.Drawing.Point(26, 260);
            this.Phonenumberlabel.Name = "Phonenumberlabel";
            this.Phonenumberlabel.Size = new System.Drawing.Size(110, 16);
            this.Phonenumberlabel.TabIndex = 19;
            this.Phonenumberlabel.Text = "Phone Number";
            // 
            // PhonenumbertextBox
            // 
            this.PhonenumbertextBox.Location = new System.Drawing.Point(156, 260);
            this.PhonenumbertextBox.Multiline = true;
            this.PhonenumbertextBox.Name = "PhonenumbertextBox";
            this.PhonenumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.PhonenumbertextBox.TabIndex = 20;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.Location = new System.Drawing.Point(156, 318);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 29);
            this.Loginbutton.TabIndex = 21;
            this.Loginbutton.Text = "Log In";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Singupbutton
            // 
            this.Singupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singupbutton.Location = new System.Drawing.Point(29, 318);
            this.Singupbutton.Name = "Singupbutton";
            this.Singupbutton.Size = new System.Drawing.Size(75, 29);
            this.Singupbutton.TabIndex = 22;
            this.Singupbutton.Text = "Sign Up";
            this.Singupbutton.UseVisualStyleBackColor = true;
            this.Singupbutton.Click += new System.EventHandler(this.Singupbutton_Click);
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleradioButton.Location = new System.Drawing.Point(219, 182);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(73, 19);
            this.FemaleradioButton.TabIndex = 13;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleradioButton.Location = new System.Drawing.Point(156, 182);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(57, 19);
            this.MaleradioButton.TabIndex = 11;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(156, 221);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 23;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 404);
            this.dataGridView1.TabIndex = 26;
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1069, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Singupbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PhonenumbertextBox);
            this.Controls.Add(this.Phonenumberlabel);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.FemaleradioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaleradioButton);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.TypecomboBox);
            this.Controls.Add(this.Typelabel);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Namelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingupForm_FormClosing);
            this.Shown += new System.EventHandler(this.NametextBox_TextChanged);
            this.Move += new System.EventHandler(this.NametextBox_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.CheckBox PasswordcheckBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Phonenumberlabel;
        private System.Windows.Forms.TextBox PhonenumbertextBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Singupbutton;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}