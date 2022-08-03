namespace ZellenSummierer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.File = new System.Windows.Forms.ColumnHeader();
            this.Betrag = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPfad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSumme = new System.Windows.Forms.TextBox();
            this.buttonSumme = new System.Windows.Forms.Button();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 494);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.File,
            this.Betrag});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(806, 494);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // File
            // 
            this.File.Text = "File";
            this.File.Width = 650;
            // 
            // Betrag
            // 
            this.Betrag.Text = "Betrag";
            this.Betrag.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelPfad);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSumme);
            this.panel2.Controls.Add(this.buttonSumme);
            this.panel2.Controls.Add(this.buttonOpenFolder);
            this.panel2.Location = new System.Drawing.Point(8, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 100);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(740, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "©Marcus Ferl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // labelPfad
            // 
            this.labelPfad.AutoSize = true;
            this.labelPfad.Location = new System.Drawing.Point(14, 69);
            this.labelPfad.Name = "labelPfad";
            this.labelPfad.Size = new System.Drawing.Size(81, 15);
            this.labelPfad.TabIndex = 6;
            this.labelPfad.Text = "Aktueller Pfad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(728, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Summe";
            // 
            // textBoxSumme
            // 
            this.textBoxSumme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSumme.Location = new System.Drawing.Point(681, 40);
            this.textBoxSumme.Name = "textBoxSumme";
            this.textBoxSumme.Size = new System.Drawing.Size(125, 29);
            this.textBoxSumme.TabIndex = 2;
            this.textBoxSumme.Text = "0";
            // 
            // buttonSumme
            // 
            this.buttonSumme.Location = new System.Drawing.Point(526, 25);
            this.buttonSumme.Name = "buttonSumme";
            this.buttonSumme.Size = new System.Drawing.Size(110, 50);
            this.buttonSumme.TabIndex = 5;
            this.buttonSumme.Text = "Summieren";
            this.buttonSumme.UseVisualStyleBackColor = true;
            this.buttonSumme.Click += new System.EventHandler(this.buttonSumme_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(14, 25);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(101, 32);
            this.buttonOpenFolder.TabIndex = 0;
            this.buttonOpenFolder.Text = "Ordner öffnen";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Carl Heinz Rechnungs Summierer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxSumme;
        private Label label2;
        private Button buttonSumme;
        private Button buttonOpenFolder;
        private Label labelPfad;
        private ListView listView1;
        private ColumnHeader File;
        private ColumnHeader Betrag;
        private Label label1;
        private Label label3;
    }
}