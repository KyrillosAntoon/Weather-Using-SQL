namespace SQL_Practice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.list_ColdestCities = new System.Windows.Forms.ListBox();
            this.list_HottestCities = new System.Windows.Forms.ListBox();
            this.list_Lowest = new System.Windows.Forms.ListBox();
            this.list_Highest = new System.Windows.Forms.ListBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coldest Cities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hottest Cities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lowest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Highest";
            // 
            // list_ColdestCities
            // 
            this.list_ColdestCities.FormattingEnabled = true;
            this.list_ColdestCities.Location = new System.Drawing.Point(51, 104);
            this.list_ColdestCities.Name = "list_ColdestCities";
            this.list_ColdestCities.Size = new System.Drawing.Size(120, 95);
            this.list_ColdestCities.TabIndex = 5;
            // 
            // list_HottestCities
            // 
            this.list_HottestCities.FormattingEnabled = true;
            this.list_HottestCities.Location = new System.Drawing.Point(228, 104);
            this.list_HottestCities.Name = "list_HottestCities";
            this.list_HottestCities.Size = new System.Drawing.Size(120, 95);
            this.list_HottestCities.TabIndex = 6;
            // 
            // list_Lowest
            // 
            this.list_Lowest.FormattingEnabled = true;
            this.list_Lowest.Location = new System.Drawing.Point(51, 309);
            this.list_Lowest.Name = "list_Lowest";
            this.list_Lowest.Size = new System.Drawing.Size(120, 95);
            this.list_Lowest.TabIndex = 7;
            // 
            // list_Highest
            // 
            this.list_Highest.FormattingEnabled = true;
            this.list_Highest.Location = new System.Drawing.Point(228, 309);
            this.list_Highest.Name = "list_Highest";
            this.list_Highest.Size = new System.Drawing.Size(120, 95);
            this.list_Highest.TabIndex = 8;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(529, 104);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(154, 20);
            this.txt_Search.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search By City";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(565, 139);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(529, 178);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(154, 168);
            this.txt_Result.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.list_Highest);
            this.Controls.Add(this.list_Lowest);
            this.Controls.Add(this.list_HottestCities);
            this.Controls.Add(this.list_ColdestCities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_ColdestCities;
        private System.Windows.Forms.ListBox list_HottestCities;
        private System.Windows.Forms.ListBox list_Lowest;
        private System.Windows.Forms.ListBox list_Highest;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

