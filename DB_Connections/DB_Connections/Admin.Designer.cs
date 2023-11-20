namespace DB_Connections
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.SupplyInput = new System.Windows.Forms.Button();
            this.StudentMenuInput = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // SupplyInput
            // 
            this.SupplyInput.BackColor = System.Drawing.Color.Transparent;
            this.SupplyInput.BackgroundImage = global::DB_Connections.Properties.Resources.layoutMENU;
            this.SupplyInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupplyInput.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyInput.Location = new System.Drawing.Point(187, 125);
            this.SupplyInput.Name = "SupplyInput";
            this.SupplyInput.Size = new System.Drawing.Size(145, 214);
            this.SupplyInput.TabIndex = 2;
            this.SupplyInput.Text = "INPUT \r\nFood Supply";
            this.SupplyInput.UseVisualStyleBackColor = false;
            this.SupplyInput.Click += new System.EventHandler(this.SupplyInput_Click);
            // 
            // StudentMenuInput
            // 
            this.StudentMenuInput.BackColor = System.Drawing.Color.Transparent;
            this.StudentMenuInput.BackgroundImage = global::DB_Connections.Properties.Resources.layoutMENU;
            this.StudentMenuInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentMenuInput.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentMenuInput.Location = new System.Drawing.Point(458, 125);
            this.StudentMenuInput.Name = "StudentMenuInput";
            this.StudentMenuInput.Size = new System.Drawing.Size(145, 214);
            this.StudentMenuInput.TabIndex = 3;
            this.StudentMenuInput.Text = "INPUT \r\nStudent Menu";
            this.StudentMenuInput.UseVisualStyleBackColor = false;
            this.StudentMenuInput.Click += new System.EventHandler(this.StudentMenuInput_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = global::DB_Connections.Properties.Resources.layoutLOGOUT;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Location = new System.Drawing.Point(741, 394);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(47, 44);
            this.logout.TabIndex = 4;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOGOUT";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Connections.Properties.Resources.unklab2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.StudentMenuInput);
            this.Controls.Add(this.SupplyInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Eatery Inventory Assistant (Admin)";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SupplyInput;
        private System.Windows.Forms.Button StudentMenuInput;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
    }
}