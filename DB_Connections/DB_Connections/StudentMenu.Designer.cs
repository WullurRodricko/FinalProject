namespace DB_Connections
{
    partial class StudentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Yourmenu = new System.Windows.Forms.Label();
            this.backtomenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Yourmenu
            // 
            this.Yourmenu.AutoSize = true;
            this.Yourmenu.BackColor = System.Drawing.Color.Transparent;
            this.Yourmenu.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yourmenu.Location = new System.Drawing.Point(149, -1);
            this.Yourmenu.Name = "Yourmenu";
            this.Yourmenu.Size = new System.Drawing.Size(490, 57);
            this.Yourmenu.TabIndex = 1;
            this.Yourmenu.Text = "Here\'s Your Menu";
            this.Yourmenu.Click += new System.EventHandler(this.Yourmenu_Click);
            // 
            // backtomenu
            // 
            this.backtomenu.BackColor = System.Drawing.Color.Maroon;
            this.backtomenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backtomenu.Location = new System.Drawing.Point(667, 363);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(121, 38);
            this.backtomenu.TabIndex = 2;
            this.backtomenu.Text = "Back";
            this.backtomenu.UseVisualStyleBackColor = false;
            this.backtomenu.Click += new System.EventHandler(this.backtomenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enjoy!!";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Connections.Properties.Resources.depositphotos_185132844_stock_photo_empty_plate_fork_knife_white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backtomenu);
            this.Controls.Add(this.Yourmenu);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMenu";
            this.Text = "Student Menu";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Yourmenu;
        private System.Windows.Forms.Button backtomenu;
        private System.Windows.Forms.Label label1;
    }
}