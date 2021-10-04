
namespace CashDrawerDemo
{
    partial class Form1
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
            this.btnDiscovery = new System.Windows.Forms.Button();
            this.btnOpenTill = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawerListView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDiscovery
            // 
            this.btnDiscovery.Location = new System.Drawing.Point(10, 7);
            this.btnDiscovery.Name = "btnDiscovery";
            this.btnDiscovery.Size = new System.Drawing.Size(217, 20);
            this.btnDiscovery.TabIndex = 0;
            this.btnDiscovery.Text = "Discover USB CashDrawers";
            this.btnDiscovery.UseVisualStyleBackColor = true;
            this.btnDiscovery.Click += new System.EventHandler(this.btnDiscovery_Click);
            // 
            // btnOpenTill
            // 
            this.btnOpenTill.Enabled = false;
            this.btnOpenTill.Location = new System.Drawing.Point(121, 206);
            this.btnOpenTill.Name = "btnOpenTill";
            this.btnOpenTill.Size = new System.Drawing.Size(106, 20);
            this.btnOpenTill.TabIndex = 1;
            this.btnOpenTill.Text = "Open Till";
            this.btnOpenTill.UseVisualStyleBackColor = true;
            this.btnOpenTill.Click += new System.EventHandler(this.btnOpenTill_Click);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Enabled = false;
            this.btnGetStatus.Location = new System.Drawing.Point(10, 206);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(105, 20);
            this.btnGetStatus.TabIndex = 2;
            this.btnGetStatus.Text = "Get Drawer Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(10, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 147);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "\r\n\r\n\r\n\r\n\r\nNo Star Cash Drawers found. Click on the \"discover\" button to get start" +
    "ed.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawerListView1
            // 
            this.drawerListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1});
            this.drawerListView1.FullRowSelect = true;
            this.drawerListView1.GridLines = true;
            this.drawerListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.drawerListView1.HideSelection = false;
            this.drawerListView1.Location = new System.Drawing.Point(10, 32);
            this.drawerListView1.MultiSelect = false;
            this.drawerListView1.Name = "drawerListView1";
            this.drawerListView1.Size = new System.Drawing.Size(217, 170);
            this.drawerListView1.TabIndex = 5;
            this.drawerListView1.UseCompatibleStateImageBehavior = false;
            this.drawerListView1.View = System.Windows.Forms.View.Details;
            this.drawerListView1.SelectedIndexChanged += new System.EventHandler(this.drawerListView1_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Drawer Name";
            this.columnHeader0.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Port No.";
            this.columnHeader1.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 237);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.drawerListView1);
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.btnOpenTill);
            this.Controls.Add(this.btnDiscovery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiscovery;
        private System.Windows.Forms.Button btnOpenTill;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView drawerListView1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

