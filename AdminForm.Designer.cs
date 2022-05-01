namespace Restaurant_Management_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.StaffmenuStrip = new System.Windows.Forms.MenuStrip();
            this.customerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StaffmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffmenuStrip
            // 
            this.StaffmenuStrip.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.StaffmenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffmenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.StaffmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.foodListToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.StaffmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StaffmenuStrip.Name = "StaffmenuStrip";
            this.StaffmenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.StaffmenuStrip.Size = new System.Drawing.Size(689, 29);
            this.StaffmenuStrip.TabIndex = 7;
            this.StaffmenuStrip.Text = "menuStrip1";
            // 
            // customerRegistrationToolStripMenuItem
            // 
            this.customerRegistrationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerRegistrationToolStripMenuItem.Image")));
            this.customerRegistrationToolStripMenuItem.Name = "customerRegistrationToolStripMenuItem";
            this.customerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(194, 25);
            this.customerRegistrationToolStripMenuItem.Text = "Customer Registration";
            this.customerRegistrationToolStripMenuItem.Click += new System.EventHandler(this.customerRegistrationToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // foodListToolStripMenuItem
            // 
            this.foodListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("foodListToolStripMenuItem.Image")));
            this.foodListToolStripMenuItem.Name = "foodListToolStripMenuItem";
            this.foodListToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.foodListToolStripMenuItem.Text = "Food List";
            this.foodListToolStripMenuItem.Click += new System.EventHandler(this.foodListToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeToolStripMenuItem.Image")));
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.employeeToolStripMenuItem.Text = "Employee Details";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StaffmenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.StaffmenuStrip.ResumeLayout(false);
            this.StaffmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StaffmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem customerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}