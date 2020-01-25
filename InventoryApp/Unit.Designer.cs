namespace InventoryApp
{
    partial class Unit
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
            this.gradientPanel2 = new InventoryApp.GradientPanel();
            this.buttonDeleteSelectedUnit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddNewUnit = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.DarkViolet;
            this.gradientPanel2.ColorTop = System.Drawing.Color.Navy;
            this.gradientPanel2.Controls.Add(this.buttonDeleteSelectedUnit);
            this.gradientPanel2.Controls.Add(this.dataGridView1);
            this.gradientPanel2.Controls.Add(this.buttonAddNewUnit);
            this.gradientPanel2.Controls.Add(this.txtUnit);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel2_Paint);
            // 
            // buttonDeleteSelectedUnit
            // 
            this.buttonDeleteSelectedUnit.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteSelectedUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDeleteSelectedUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteSelectedUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSelectedUnit.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteSelectedUnit.Location = new System.Drawing.Point(109, 178);
            this.buttonDeleteSelectedUnit.Name = "buttonDeleteSelectedUnit";
            this.buttonDeleteSelectedUnit.Size = new System.Drawing.Size(168, 28);
            this.buttonDeleteSelectedUnit.TabIndex = 16;
            this.buttonDeleteSelectedUnit.Text = "Delete Selected Unit";
            this.buttonDeleteSelectedUnit.UseVisualStyleBackColor = false;
            this.buttonDeleteSelectedUnit.Click += new System.EventHandler(this.buttonDeleteSelectedUnit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(456, 314);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonAddNewUnit
            // 
            this.buttonAddNewUnit.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUnit.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewUnit.Location = new System.Drawing.Point(109, 144);
            this.buttonAddNewUnit.Name = "buttonAddNewUnit";
            this.buttonAddNewUnit.Size = new System.Drawing.Size(168, 28);
            this.buttonAddNewUnit.TabIndex = 14;
            this.buttonAddNewUnit.Text = "Add New Unit";
            this.buttonAddNewUnit.UseVisualStyleBackColor = false;
            this.buttonAddNewUnit.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(109, 103);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(168, 20);
            this.txtUnit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Unit";
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel2);
            this.Name = "Unit";
            this.Text = "Add New Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddNewUnit;
        private System.Windows.Forms.Button buttonDeleteSelectedUnit;
    }
}