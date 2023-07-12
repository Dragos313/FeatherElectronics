namespace FeatherElectronics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAutentifica = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.cmbFunctie = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCurata);
            this.groupBox1.Controls.Add(this.btnAutentifica);
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.txtUtilizator);
            this.groupBox1.Controls.Add(this.cmbFunctie);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(540, 391);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autentificare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Functie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Utilizator";
            // 
            // btnCurata
            // 
            this.btnCurata.BackColor = System.Drawing.Color.Red;
            this.btnCurata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurata.ForeColor = System.Drawing.Color.White;
            this.btnCurata.Location = new System.Drawing.Point(353, 292);
            this.btnCurata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(151, 43);
            this.btnCurata.TabIndex = 2;
            this.btnCurata.Text = "Inchide";
            this.btnCurata.UseVisualStyleBackColor = false;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAutentifica
            // 
            this.btnAutentifica.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAutentifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutentifica.ForeColor = System.Drawing.Color.White;
            this.btnAutentifica.Location = new System.Drawing.Point(174, 292);
            this.btnAutentifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutentifica.Name = "btnAutentifica";
            this.btnAutentifica.Size = new System.Drawing.Size(151, 43);
            this.btnAutentifica.TabIndex = 2;
            this.btnAutentifica.Text = "Autentifica";
            this.btnAutentifica.UseVisualStyleBackColor = false;
            this.btnAutentifica.Click += new System.EventHandler(this.btnAutentifica_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(174, 220);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(330, 26);
            this.txtParola.TabIndex = 1;
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(174, 138);
            this.txtUtilizator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(330, 26);
            this.txtUtilizator.TabIndex = 1;
            // 
            // cmbFunctie
            // 
            this.cmbFunctie.FormattingEnabled = true;
            this.cmbFunctie.Items.AddRange(new object[] {
            "Functie",
            "Administrator",
            "Vanzator"});
            this.cmbFunctie.Location = new System.Drawing.Point(174, 49);
            this.cmbFunctie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFunctie.Name = "cmbFunctie";
            this.cmbFunctie.Size = new System.Drawing.Size(330, 28);
            this.cmbFunctie.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FeatherElectronics.Properties.Resources.Frame_1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.Button btnAutentifica;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.ComboBox cmbFunctie;
    }
}

