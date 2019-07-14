namespace RacunarskaGrafika
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtNovaRec = new System.Windows.Forms.TextBox();
            this.pnlVesalica = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlovo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.txtC4 = new System.Windows.Forms.TextBox();
            this.txtC5 = new System.Windows.Forms.TextBox();
            this.txtC6 = new System.Windows.Forms.TextBox();
            this.txtMissed = new System.Windows.Forms.TextBox();
            this.lblLivesLeft = new System.Windows.Forms.Label();
            this.lblBrojPokusaja = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(330, 123);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(132, 53);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtNovaRec
            // 
            this.txtNovaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaRec.Location = new System.Drawing.Point(42, 123);
            this.txtNovaRec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNovaRec.MaxLength = 6;
            this.txtNovaRec.Multiline = true;
            this.txtNovaRec.Name = "txtNovaRec";
            this.txtNovaRec.Size = new System.Drawing.Size(278, 53);
            this.txtNovaRec.TabIndex = 1;
            this.txtNovaRec.TextChanged += new System.EventHandler(this.TxtNovaRec_TextChanged);
            // 
            // pnlVesalica
            // 
            this.pnlVesalica.BackColor = System.Drawing.Color.Orange;
            this.pnlVesalica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVesalica.Location = new System.Drawing.Point(1, 0);
            this.pnlVesalica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlVesalica.Name = "pnlVesalica";
            this.pnlVesalica.Size = new System.Drawing.Size(801, 850);
            this.pnlVesalica.TabIndex = 2;
            this.pnlVesalica.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(37, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slovo";
            // 
            // txtSlovo
            // 
            this.txtSlovo.Enabled = false;
            this.txtSlovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlovo.Location = new System.Drawing.Point(152, 373);
            this.txtSlovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSlovo.MaxLength = 1;
            this.txtSlovo.Multiline = true;
            this.txtSlovo.Name = "txtSlovo";
            this.txtSlovo.Size = new System.Drawing.Size(69, 45);
            this.txtSlovo.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(237, 373);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 45);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtC1
            // 
            this.txtC1.Enabled = false;
            this.txtC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1.Location = new System.Drawing.Point(42, 217);
            this.txtC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC1.Multiline = true;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(61, 46);
            this.txtC1.TabIndex = 6;
            // 
            // txtC2
            // 
            this.txtC2.Enabled = false;
            this.txtC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2.Location = new System.Drawing.Point(111, 217);
            this.txtC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC2.Multiline = true;
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(61, 46);
            this.txtC2.TabIndex = 7;
            // 
            // txtC3
            // 
            this.txtC3.Enabled = false;
            this.txtC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC3.Location = new System.Drawing.Point(182, 217);
            this.txtC3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC3.Multiline = true;
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(61, 46);
            this.txtC3.TabIndex = 8;
            // 
            // txtC4
            // 
            this.txtC4.Enabled = false;
            this.txtC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC4.Location = new System.Drawing.Point(259, 217);
            this.txtC4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC4.Multiline = true;
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(61, 46);
            this.txtC4.TabIndex = 9;
            // 
            // txtC5
            // 
            this.txtC5.Enabled = false;
            this.txtC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC5.Location = new System.Drawing.Point(330, 217);
            this.txtC5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC5.Multiline = true;
            this.txtC5.Name = "txtC5";
            this.txtC5.Size = new System.Drawing.Size(59, 46);
            this.txtC5.TabIndex = 10;
            // 
            // txtC6
            // 
            this.txtC6.Enabled = false;
            this.txtC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC6.Location = new System.Drawing.Point(398, 217);
            this.txtC6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC6.Multiline = true;
            this.txtC6.Name = "txtC6";
            this.txtC6.Size = new System.Drawing.Size(61, 46);
            this.txtC6.TabIndex = 11;
            // 
            // txtMissed
            // 
            this.txtMissed.Enabled = false;
            this.txtMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissed.Location = new System.Drawing.Point(152, 427);
            this.txtMissed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMissed.Multiline = true;
            this.txtMissed.Name = "txtMissed";
            this.txtMissed.Size = new System.Drawing.Size(165, 43);
            this.txtMissed.TabIndex = 12;
            // 
            // lblLivesLeft
            // 
            this.lblLivesLeft.AutoSize = true;
            this.lblLivesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesLeft.ForeColor = System.Drawing.Color.Gray;
            this.lblLivesLeft.Location = new System.Drawing.Point(37, 327);
            this.lblLivesLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivesLeft.Name = "lblLivesLeft";
            this.lblLivesLeft.Size = new System.Drawing.Size(52, 29);
            this.lblLivesLeft.TabIndex = 13;
            this.lblLivesLeft.Text = "Life";
            // 
            // lblBrojPokusaja
            // 
            this.lblBrojPokusaja.AutoSize = true;
            this.lblBrojPokusaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPokusaja.ForeColor = System.Drawing.Color.Gray;
            this.lblBrojPokusaja.Location = new System.Drawing.Point(146, 327);
            this.lblBrojPokusaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojPokusaja.Name = "lblBrojPokusaja";
            this.lblBrojPokusaja.Size = new System.Drawing.Size(26, 29);
            this.lblBrojPokusaja.TabIndex = 14;
            this.lblBrojPokusaja.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(37, 442);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Greske";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNovaRec);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.lblBrojPokusaja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLivesLeft);
            this.panel1.Controls.Add(this.txtSlovo);
            this.panel1.Controls.Add(this.txtMissed);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.txtC6);
            this.panel1.Controls.Add(this.txtC1);
            this.panel1.Controls.Add(this.txtC5);
            this.panel1.Controls.Add(this.txtC2);
            this.panel1.Controls.Add(this.txtC4);
            this.panel1.Controls.Add(this.txtC3);
            this.panel1.Location = new System.Drawing.Point(801, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 850);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(35, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Unesite rec od 6 slova";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1576, 852);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlVesalica);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtNovaRec;
        private System.Windows.Forms.Panel pnlVesalica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlovo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.TextBox txtC4;
        private System.Windows.Forms.TextBox txtC5;
        private System.Windows.Forms.TextBox txtC6;
        private System.Windows.Forms.TextBox txtMissed;
        private System.Windows.Forms.Label lblLivesLeft;
        private System.Windows.Forms.Label lblBrojPokusaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

