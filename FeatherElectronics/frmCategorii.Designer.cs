namespace FeatherElectronics
{
    partial class frmCategorii
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorii));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCatID = new System.Windows.Forms.Label();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdCat = new System.Windows.Forms.Button();
            this.rtbCatDesc = new System.Windows.Forms.RichTextBox();
            this.txtCatDen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.lblCatID);
            this.groupBox1.Controls.Add(this.btnActualizare);
            this.groupBox1.Controls.Add(this.btnStergere);
            this.groupBox1.Controls.Add(this.btnAdCat);
            this.groupBox1.Controls.Add(this.rtbCatDesc);
            this.groupBox1.Controls.Add(this.txtCatDen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(514, 332);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga categorie";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.ForeColor = System.Drawing.Color.Indigo;
            this.lblCatID.Location = new System.Drawing.Point(157, 21);
            this.lblCatID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(52, 18);
            this.lblCatID.TabIndex = 10;
            this.lblCatID.Text = "label4";
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.Indigo;
            this.btnActualizare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizare.ForeColor = System.Drawing.Color.White;
            this.btnActualizare.Location = new System.Drawing.Point(233, 230);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(132, 46);
            this.btnActualizare.TabIndex = 9;
            this.btnActualizare.Text = "Actualizeaza";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.Red;
            this.btnStergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(373, 230);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(132, 46);
            this.btnStergere.TabIndex = 7;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdCat
            // 
            this.btnAdCat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdCat.ForeColor = System.Drawing.Color.White;
            this.btnAdCat.Location = new System.Drawing.Point(93, 230);
            this.btnAdCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdCat.Name = "btnAdCat";
            this.btnAdCat.Size = new System.Drawing.Size(132, 46);
            this.btnAdCat.TabIndex = 8;
            this.btnAdCat.Text = "Adauga";
            this.btnAdCat.UseVisualStyleBackColor = false;
            this.btnAdCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // rtbCatDesc
            // 
            this.rtbCatDesc.Location = new System.Drawing.Point(195, 102);
            this.rtbCatDesc.Margin = new System.Windows.Forms.Padding(4);
            this.rtbCatDesc.Name = "rtbCatDesc";
            this.rtbCatDesc.Size = new System.Drawing.Size(310, 75);
            this.rtbCatDesc.TabIndex = 6;
            this.rtbCatDesc.Text = "";
            // 
            // txtCatDen
            // 
            this.txtCatDen.Location = new System.Drawing.Point(195, 54);
            this.txtCatDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatDen.Name = "txtCatDen";
            this.txtCatDen.Size = new System.Drawing.Size(310, 24);
            this.txtCatDen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descriere categorie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumire categorie:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 333);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // frmCategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCategorii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorii";
            this.Load += new System.EventHandler(this.frmCategorii_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdCat;
        private System.Windows.Forms.RichTextBox rtbCatDesc;
        private System.Windows.Forms.TextBox txtCatDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}