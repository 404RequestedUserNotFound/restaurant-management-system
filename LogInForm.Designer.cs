namespace Restaurant_Management_System
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Typelabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.PasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.ResetlinkLabel = new System.Windows.Forms.LinkLabel();
            this.CreateaccountlinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.Location = new System.Drawing.Point(135, 314);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 28);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "Log In";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(295, 314);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(85, 28);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.Black;
            this.Namelabel.Location = new System.Drawing.Point(96, 111);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(133, 29);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "User Name";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.Black;
            this.Passwordlabel.Location = new System.Drawing.Point(96, 165);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(128, 29);
            this.Passwordlabel.TabIndex = 4;
            this.Passwordlabel.Text = "Password";
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.BackColor = System.Drawing.Color.Transparent;
            this.Typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typelabel.Location = new System.Drawing.Point(96, 214);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(120, 25);
            this.Typelabel.TabIndex = 5;
            this.Typelabel.Text = "User Type";
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(295, 111);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(126, 29);
            this.NametextBox.TabIndex = 0;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(295, 168);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(126, 26);
            this.PasswordtextBox.TabIndex = 7;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Staff"});
            this.TypecomboBox.Location = new System.Drawing.Point(295, 214);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(121, 24);
            this.TypecomboBox.TabIndex = 8;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged);
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.AutoSize = true;
            this.PasswordcheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordcheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordcheckBox.Location = new System.Drawing.Point(306, 259);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(115, 17);
            this.PasswordcheckBox.TabIndex = 9;
            this.PasswordcheckBox.Text = "Show Password";
            this.PasswordcheckBox.UseVisualStyleBackColor = false;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.PasswordcheckBox_CheckedChanged);
            // 
            // ResetlinkLabel
            // 
            this.ResetlinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.ResetlinkLabel.AutoSize = true;
            this.ResetlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResetlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetlinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ResetlinkLabel.Location = new System.Drawing.Point(302, 284);
            this.ResetlinkLabel.Name = "ResetlinkLabel";
            this.ResetlinkLabel.Size = new System.Drawing.Size(114, 15);
            this.ResetlinkLabel.TabIndex = 10;
            this.ResetlinkLabel.TabStop = true;
            this.ResetlinkLabel.Text = "Forgot Password";
            this.ResetlinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.ResetlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetlinkLabel_LinkClicked);
            // 
            // CreateaccountlinkLabel
            // 
            this.CreateaccountlinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.CreateaccountlinkLabel.AutoSize = true;
            this.CreateaccountlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateaccountlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateaccountlinkLabel.LinkColor = System.Drawing.Color.Black;
            this.CreateaccountlinkLabel.Location = new System.Drawing.Point(98, 284);
            this.CreateaccountlinkLabel.Name = "CreateaccountlinkLabel";
            this.CreateaccountlinkLabel.Size = new System.Drawing.Size(123, 15);
            this.CreateaccountlinkLabel.TabIndex = 11;
            this.CreateaccountlinkLabel.TabStop = true;
            this.CreateaccountlinkLabel.Text = "Create an Account";
            this.CreateaccountlinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.CreateaccountlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateaccountlinkLabel_LinkClicked);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(486, 486);
            this.Controls.Add(this.CreateaccountlinkLabel);
            this.Controls.Add(this.ResetlinkLabel);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.TypecomboBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.Typelabel);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbutton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInForm_FormClosing);
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.CheckBox PasswordcheckBox;
        private System.Windows.Forms.LinkLabel ResetlinkLabel;
        private System.Windows.Forms.LinkLabel CreateaccountlinkLabel;
    }
}

