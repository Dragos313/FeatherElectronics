namespace FeatherElectronics
{
    partial class frmVanzare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVanzare));
            this.btnFactura = new System.Windows.Forms.Button();
            this.txtNrFactura = new System.Windows.Forms.TextBox();
            this.dataGridView2_Produs = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.btnPrintare = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnReimprospatare = new System.Windows.Forms.Button();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.dataGridView1_Comanda = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Produs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Comanda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Location = new System.Drawing.Point(871, 342);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(108, 48);
            this.btnFactura.TabIndex = 32;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // txtNrFactura
            // 
            this.txtNrFactura.BackColor = System.Drawing.Color.Thistle;
            this.txtNrFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrFactura.Location = new System.Drawing.Point(688, 349);
            this.txtNrFactura.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNrFactura.Name = "txtNrFactura";
            this.txtNrFactura.Size = new System.Drawing.Size(152, 32);
            this.txtNrFactura.TabIndex = 31;
            // 
            // dataGridView2_Produs
            // 
            this.dataGridView2_Produs.AllowUserToAddRows = false;
            this.dataGridView2_Produs.AllowUserToDeleteRows = false;
            this.dataGridView2_Produs.AllowUserToResizeRows = false;
            this.dataGridView2_Produs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2_Produs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2_Produs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2_Produs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Produs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2_Produs.Location = new System.Drawing.Point(24, 86);
            this.dataGridView2_Produs.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView2_Produs.Name = "dataGridView2_Produs";
            this.dataGridView2_Produs.RowHeadersVisible = false;
            this.dataGridView2_Produs.RowHeadersWidth = 51;
            this.dataGridView2_Produs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_Produs.ShowEditingIcon = false;
            this.dataGridView2_Produs.Size = new System.Drawing.Size(451, 322);
            this.dataGridView2_Produs.TabIndex = 30;
            this.dataGridView2_Produs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_Produs_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(501, 418);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(853, 322);
            this.dataGridView1.TabIndex = 29;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(24, 34);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(332, 34);
            this.cmbCategorie.TabIndex = 28;
            // 
            // btnPrintare
            // 
            this.btnPrintare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrintare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintare.ForeColor = System.Drawing.Color.White;
            this.btnPrintare.Location = new System.Drawing.Point(991, 342);
            this.btnPrintare.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrintare.Name = "btnPrintare";
            this.btnPrintare.Size = new System.Drawing.Size(108, 48);
            this.btnPrintare.TabIndex = 26;
            this.btnPrintare.Text = "Printare";
            this.btnPrintare.UseVisualStyleBackColor = false;
            this.btnPrintare.Click += new System.EventHandler(this.btnPrintare_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCauta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.White;
            this.btnCauta.Location = new System.Drawing.Point(368, 29);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(107, 45);
            this.btnCauta.TabIndex = 25;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReimprospatare
            // 
            this.btnReimprospatare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReimprospatare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReimprospatare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReimprospatare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprospatare.ForeColor = System.Drawing.Color.White;
            this.btnReimprospatare.Location = new System.Drawing.Point(501, 29);
            this.btnReimprospatare.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReimprospatare.Name = "btnReimprospatare";
            this.btnReimprospatare.Size = new System.Drawing.Size(108, 48);
            this.btnReimprospatare.TabIndex = 24;
            this.btnReimprospatare.Text = "Refresh";
            this.btnReimprospatare.UseVisualStyleBackColor = false;
            this.btnReimprospatare.Click += new System.EventHandler(this.btnReimprospatare_Click);
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdaugaComanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaComanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaComanda.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaComanda.Location = new System.Drawing.Point(368, 639);
            this.btnAdaugaComanda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(107, 48);
            this.btnAdaugaComanda.TabIndex = 27;
            this.btnAdaugaComanda.Text = "Adauga";
            this.btnAdaugaComanda.UseVisualStyleBackColor = false;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // dataGridView1_Comanda
            // 
            this.dataGridView1_Comanda.AllowUserToAddRows = false;
            this.dataGridView1_Comanda.AllowUserToResizeColumns = false;
            this.dataGridView1_Comanda.AllowUserToResizeRows = false;
            this.dataGridView1_Comanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Comanda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_Comanda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1_Comanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1_Comanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Comanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.numeProdus,
            this.Pret,
            this.Cantitate,
            this.Total});
            this.dataGridView1_Comanda.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1_Comanda.Location = new System.Drawing.Point(501, 86);
            this.dataGridView1_Comanda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1_Comanda.Name = "dataGridView1_Comanda";
            this.dataGridView1_Comanda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1_Comanda.RowHeadersVisible = false;
            this.dataGridView1_Comanda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1_Comanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Comanda.Size = new System.Drawing.Size(854, 229);
            this.dataGridView1_Comanda.TabIndex = 23;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ID";
            this.ProdID.MinimumWidth = 6;
            this.ProdID.Name = "ProdID";
            // 
            // numeProdus
            // 
            this.numeProdus.HeaderText = "Nume produs";
            this.numeProdus.MinimumWidth = 6;
            this.numeProdus.Name = "numeProdus";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 6;
            this.Pret.Name = "Pret";
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 6;
            this.Cantitate.Name = "Cantitate";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // txtCantitate
            // 
            this.txtCantitate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantitate.ForeColor = System.Drawing.Color.Maroon;
            this.txtCantitate.Location = new System.Drawing.Point(159, 594);
            this.txtCantitate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(316, 32);
            this.txtCantitate.TabIndex = 22;
            // 
            // txtPret
            // 
            this.txtPret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPret.ForeColor = System.Drawing.Color.Maroon;
            this.txtPret.Location = new System.Drawing.Point(159, 544);
            this.txtPret.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPret.Name = "txtPret";
            this.txtPret.ReadOnly = true;
            this.txtPret.Size = new System.Drawing.Size(316, 32);
            this.txtPret.TabIndex = 21;
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeProdus.ForeColor = System.Drawing.Color.Maroon;
            this.txtNumeProdus.Location = new System.Drawing.Point(159, 498);
            this.txtNumeProdus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.ReadOnly = true;
            this.txtNumeProdus.Size = new System.Drawing.Size(316, 32);
            this.txtNumeProdus.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Maroon;
            this.txtId.Location = new System.Drawing.Point(159, 456);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(316, 32);
            this.txtId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(20, 601);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cantitate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(20, 551);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(20, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Produs:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblTotal.Location = new System.Drawing.Point(1218, 342);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 25);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(515, 354);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Numar Factura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(1131, 344);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(20, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(1218, 30);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 25);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "01.01.2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(1149, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Data:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmVanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1369, 762);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.txtNrFactura);
            this.Controls.Add(this.dataGridView2_Produs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.btnPrintare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnReimprospatare);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.dataGridView1_Comanda);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmVanzare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanzare";
            this.Load += new System.EventHandler(this.frmVanzare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Produs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Comanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.TextBox txtNrFactura;
        private System.Windows.Forms.DataGridView dataGridView2_Produs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Button btnPrintare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnReimprospatare;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.DataGridView dataGridView1_Comanda;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}