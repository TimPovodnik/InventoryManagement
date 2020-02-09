namespace InventoryApp
{
    partial class home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Load = new System.Windows.Forms.Button();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.buttonPurchaseProduct = new System.Windows.Forms.Button();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonAddNewSupplier = new System.Windows.Forms.Button();
            this.buttonAddNewUnit = new System.Windows.Forms.Button();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxActiveDot = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActiveDot)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.Transparent;
            this.Load.Cursor = System.Windows.Forms.Cursors.Default;
            this.Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Load.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.Load.ForeColor = System.Drawing.Color.Black;
            this.Load.Location = new System.Drawing.Point(266, 434);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(174, 34);
            this.Load.TabIndex = 43;
            this.Load.Text = "Naloži Podatke";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // chartStock
            // 
            this.chartStock.BackColor = System.Drawing.Color.Transparent;
            this.chartStock.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartStock.Legends.Add(legend5);
            this.chartStock.Location = new System.Drawing.Point(187, 128);
            this.chartStock.Name = "chartStock";
            this.chartStock.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartStock.Series.Add(series5);
            this.chartStock.Size = new System.Drawing.Size(409, 300);
            this.chartStock.TabIndex = 5;
            this.chartStock.Text = "Stock";
            this.chartStock.UseWaitCursor = true;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Controls.Add(this.buttonHelp);
            this.sidePanel.Controls.Add(this.buttonPurchaseProduct);
            this.sidePanel.Controls.Add(this.buttonAddNewProduct);
            this.sidePanel.Controls.Add(this.buttonAddNewSupplier);
            this.sidePanel.Controls.Add(this.buttonAddNewUnit);
            this.sidePanel.Controls.Add(this.buttonAddNewUser);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(187, 550);
            this.sidePanel.TabIndex = 45;
            // 
            // buttonPurchaseProduct
            // 
            this.buttonPurchaseProduct.BackColor = System.Drawing.Color.Transparent;
            this.buttonPurchaseProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPurchaseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPurchaseProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchaseProduct.ForeColor = System.Drawing.Color.White;
            this.buttonPurchaseProduct.Location = new System.Drawing.Point(0, 230);
            this.buttonPurchaseProduct.Name = "buttonPurchaseProduct";
            this.buttonPurchaseProduct.Size = new System.Drawing.Size(187, 39);
            this.buttonPurchaseProduct.TabIndex = 52;
            this.buttonPurchaseProduct.Text = "Kupi Izdelek";
            this.buttonPurchaseProduct.UseVisualStyleBackColor = false;
            this.buttonPurchaseProduct.Click += new System.EventHandler(this.buttonPurchaseProduct_Click);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewProduct.Location = new System.Drawing.Point(0, 185);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(187, 39);
            this.buttonAddNewProduct.TabIndex = 51;
            this.buttonAddNewProduct.Text = "Dodaj Izdelek";
            this.buttonAddNewProduct.UseVisualStyleBackColor = false;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonAddNewSupplier
            // 
            this.buttonAddNewSupplier.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewSupplier.Location = new System.Drawing.Point(0, 140);
            this.buttonAddNewSupplier.Name = "buttonAddNewSupplier";
            this.buttonAddNewSupplier.Size = new System.Drawing.Size(187, 39);
            this.buttonAddNewSupplier.TabIndex = 50;
            this.buttonAddNewSupplier.Text = "Dodaj Dobavitelja";
            this.buttonAddNewSupplier.UseVisualStyleBackColor = false;
            this.buttonAddNewSupplier.Click += new System.EventHandler(this.buttonAddNewSupplier_Click);
            // 
            // buttonAddNewUnit
            // 
            this.buttonAddNewUnit.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUnit.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewUnit.Location = new System.Drawing.Point(0, 95);
            this.buttonAddNewUnit.Name = "buttonAddNewUnit";
            this.buttonAddNewUnit.Size = new System.Drawing.Size(187, 39);
            this.buttonAddNewUnit.TabIndex = 49;
            this.buttonAddNewUnit.Text = "Dodaj Enoto";
            this.buttonAddNewUnit.UseVisualStyleBackColor = false;
            this.buttonAddNewUnit.Click += new System.EventHandler(this.buttonAddNewUnit_Click);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewUser.Location = new System.Drawing.Point(0, 50);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(187, 39);
            this.buttonAddNewUser.TabIndex = 48;
            this.buttonAddNewUser.Text = "Dodaj Uporabnika";
            this.buttonAddNewUser.UseVisualStyleBackColor = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Navy;
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(187, 42);
            this.logoPanel.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ERŠ Inventory";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.pictureBoxActiveDot);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.labelUser);
            this.headerPanel.Controls.Add(this.labelX);
            this.headerPanel.Controls.Add(this.buttonLogOut);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(187, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(624, 42);
            this.headerPanel.TabIndex = 46;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.White;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(449, 18);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(51, 16);
            this.labelUser.TabIndex = 50;
            this.labelUser.Text = "Admin";
            this.labelUser.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Transparent;
            this.labelX.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Black;
            this.labelX.Location = new System.Drawing.Point(601, 10);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(22, 22);
            this.labelX.TabIndex = 49;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOut.Location = new System.Drawing.Point(528, 7);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 28);
            this.buttonLogOut.TabIndex = 48;
            this.buttonLogOut.Text = "Odjava";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label3.Location = new System.Drawing.Point(331, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Aktiven Skrbnik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "ZALOGA";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(0, 275);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(187, 39);
            this.buttonHelp.TabIndex = 53;
            this.buttonHelp.Text = "Pomoč";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::InventoryApp.Properties.Resources.circularRAM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(625, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 156);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxActiveDot
            // 
            this.pictureBoxActiveDot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxActiveDot.BackgroundImage = global::InventoryApp.Properties.Resources.avtiveDot1;
            this.pictureBoxActiveDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxActiveDot.Location = new System.Drawing.Point(437, 18);
            this.pictureBoxActiveDot.Name = "pictureBoxActiveDot";
            this.pictureBoxActiveDot.Size = new System.Drawing.Size(15, 14);
            this.pictureBoxActiveDot.TabIndex = 52;
            this.pictureBoxActiveDot.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 54;
            this.button1.Text = "Vizitka";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.chartStock);
            this.Controls.Add(this.Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActiveDot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button buttonPurchaseProduct;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonAddNewSupplier;
        private System.Windows.Forms.Button buttonAddNewUnit;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBoxActiveDot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button button1;
    }
}



