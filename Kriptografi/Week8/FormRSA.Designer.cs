﻿namespace Kriptografi.Week8
{
    partial class FormRSA
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonHitungN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlRSA = new System.Windows.Forms.TabControl();
            this.tabPageKey = new System.Windows.Forms.TabPage();
            this.dataGridViewNotSortAbleEEA = new Kriptografi.DataGridViewNotSortAble();
            this.buttonRandomD = new System.Windows.Forms.Button();
            this.buttonHitungE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotientN = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.labelTotienN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.tabPageEnkripsi = new System.Windows.Forms.TabPage();
            this.checkBoxShowEnkripsiDetail = new System.Windows.Forms.CheckBox();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.textBoxEnkripsiPlainText = new System.Windows.Forms.TextBox();
            this.dataGridViewProsesEnkripsi = new Kriptografi.DataGridViewNotSortAble();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxShowDekripsiDetail = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDekripsiPlainText = new System.Windows.Forms.TextBox();
            this.buttonDekripsi = new System.Windows.Forms.Button();
            this.dataGridViewProsesDekripsi = new Kriptografi.DataGridViewNotSortAble();
            this.tabControlRSA.SuspendLayout();
            this.tabPageKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleEEA)).BeginInit();
            this.tabPageEnkripsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(59, 6);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 25);
            this.textBoxP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Q";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(59, 37);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(200, 25);
            this.textBoxQ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "N";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(59, 68);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(200, 25);
            this.textBoxN.TabIndex = 4;
            // 
            // buttonHitungN
            // 
            this.buttonHitungN.Location = new System.Drawing.Point(265, 37);
            this.buttonHitungN.Name = "buttonHitungN";
            this.buttonHitungN.Size = new System.Drawing.Size(156, 25);
            this.buttonHitungN.TabIndex = 3;
            this.buttonHitungN.Text = "Hitung N dan Totient N";
            this.buttonHitungN.UseVisualStyleBackColor = true;
            this.buttonHitungN.Click += new System.EventHandler(this.buttonHitungN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Publikasikan N dan E sebagai kunci publik, sedangkan P, Q ,dan D sebagai kunci pr" +
                "ivat";
            // 
            // tabControlRSA
            // 
            this.tabControlRSA.Controls.Add(this.tabPageKey);
            this.tabControlRSA.Controls.Add(this.tabPageEnkripsi);
            this.tabControlRSA.Controls.Add(this.tabPage3);
            this.tabControlRSA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRSA.Location = new System.Drawing.Point(0, 0);
            this.tabControlRSA.Name = "tabControlRSA";
            this.tabControlRSA.SelectedIndex = 0;
            this.tabControlRSA.Size = new System.Drawing.Size(952, 506);
            this.tabControlRSA.TabIndex = 11;
            // 
            // tabPageKey
            // 
            this.tabPageKey.Controls.Add(this.dataGridViewNotSortAbleEEA);
            this.tabPageKey.Controls.Add(this.textBoxP);
            this.tabPageKey.Controls.Add(this.label6);
            this.tabPageKey.Controls.Add(this.label1);
            this.tabPageKey.Controls.Add(this.buttonRandomD);
            this.tabPageKey.Controls.Add(this.label2);
            this.tabPageKey.Controls.Add(this.buttonHitungE);
            this.tabPageKey.Controls.Add(this.textBoxQ);
            this.tabPageKey.Controls.Add(this.buttonHitungN);
            this.tabPageKey.Controls.Add(this.label4);
            this.tabPageKey.Controls.Add(this.textBoxTotientN);
            this.tabPageKey.Controls.Add(this.textBoxD);
            this.tabPageKey.Controls.Add(this.labelTotienN);
            this.tabPageKey.Controls.Add(this.label5);
            this.tabPageKey.Controls.Add(this.textBoxN);
            this.tabPageKey.Controls.Add(this.textBoxE);
            this.tabPageKey.Controls.Add(this.label3);
            this.tabPageKey.Location = new System.Drawing.Point(4, 27);
            this.tabPageKey.Name = "tabPageKey";
            this.tabPageKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKey.Size = new System.Drawing.Size(944, 475);
            this.tabPageKey.TabIndex = 0;
            this.tabPageKey.Text = "Key";
            this.tabPageKey.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNotSortAbleEEA
            // 
            this.dataGridViewNotSortAbleEEA.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleEEA.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleEEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleEEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleEEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleEEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleEEA.Location = new System.Drawing.Point(8, 219);
            this.dataGridViewNotSortAbleEEA.Name = "dataGridViewNotSortAbleEEA";
            this.dataGridViewNotSortAbleEEA.ReadOnly = true;
            this.dataGridViewNotSortAbleEEA.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleEEA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleEEA.Size = new System.Drawing.Size(928, 248);
            this.dataGridViewNotSortAbleEEA.TabIndex = 28;
            // 
            // buttonRandomD
            // 
            this.buttonRandomD.Location = new System.Drawing.Point(265, 130);
            this.buttonRandomD.Name = "buttonRandomD";
            this.buttonRandomD.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomD.TabIndex = 7;
            this.buttonRandomD.Text = "Random D";
            this.buttonRandomD.UseVisualStyleBackColor = true;
            this.buttonRandomD.Click += new System.EventHandler(this.buttonRandomD_Click);
            // 
            // buttonHitungE
            // 
            this.buttonHitungE.Location = new System.Drawing.Point(265, 161);
            this.buttonHitungE.Name = "buttonHitungE";
            this.buttonHitungE.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungE.TabIndex = 9;
            this.buttonHitungE.Text = "Hitung E";
            this.buttonHitungE.UseVisualStyleBackColor = true;
            this.buttonHitungE.Click += new System.EventHandler(this.buttonHitungE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "D";
            // 
            // textBoxTotientN
            // 
            this.textBoxTotientN.Location = new System.Drawing.Point(59, 99);
            this.textBoxTotientN.Name = "textBoxTotientN";
            this.textBoxTotientN.ReadOnly = true;
            this.textBoxTotientN.Size = new System.Drawing.Size(200, 25);
            this.textBoxTotientN.TabIndex = 5;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(59, 130);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(200, 25);
            this.textBoxD.TabIndex = 6;
            // 
            // labelTotienN
            // 
            this.labelTotienN.AutoSize = true;
            this.labelTotienN.Location = new System.Drawing.Point(6, 102);
            this.labelTotienN.Name = "labelTotienN";
            this.labelTotienN.Size = new System.Drawing.Size(44, 18);
            this.labelTotienN.TabIndex = 0;
            this.labelTotienN.Text = "totient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "E";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(59, 161);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.ReadOnly = true;
            this.textBoxE.Size = new System.Drawing.Size(200, 25);
            this.textBoxE.TabIndex = 8;
            // 
            // tabPageEnkripsi
            // 
            this.tabPageEnkripsi.Controls.Add(this.checkBoxShowEnkripsiDetail);
            this.tabPageEnkripsi.Controls.Add(this.numericUpDownBlockSize);
            this.tabPageEnkripsi.Controls.Add(this.label8);
            this.tabPageEnkripsi.Controls.Add(this.label7);
            this.tabPageEnkripsi.Controls.Add(this.buttonEnkripsi);
            this.tabPageEnkripsi.Controls.Add(this.textBoxEnkripsiPlainText);
            this.tabPageEnkripsi.Controls.Add(this.dataGridViewProsesEnkripsi);
            this.tabPageEnkripsi.Location = new System.Drawing.Point(4, 27);
            this.tabPageEnkripsi.Name = "tabPageEnkripsi";
            this.tabPageEnkripsi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnkripsi.Size = new System.Drawing.Size(944, 475);
            this.tabPageEnkripsi.TabIndex = 1;
            this.tabPageEnkripsi.Text = "Enkripsi";
            this.tabPageEnkripsi.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowEnkripsiDetail
            // 
            this.checkBoxShowEnkripsiDetail.AutoSize = true;
            this.checkBoxShowEnkripsiDetail.Location = new System.Drawing.Point(637, 15);
            this.checkBoxShowEnkripsiDetail.Name = "checkBoxShowEnkripsiDetail";
            this.checkBoxShowEnkripsiDetail.Size = new System.Drawing.Size(162, 22);
            this.checkBoxShowEnkripsiDetail.TabIndex = 28;
            this.checkBoxShowEnkripsiDetail.Text = "Tunjukan Proses Detail";
            this.checkBoxShowEnkripsiDetail.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBlockSize
            // 
            this.numericUpDownBlockSize.Location = new System.Drawing.Point(551, 13);
            this.numericUpDownBlockSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownBlockSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBlockSize.Name = "numericUpDownBlockSize";
            this.numericUpDownBlockSize.Size = new System.Drawing.Size(50, 25);
            this.numericUpDownBlockSize.TabIndex = 24;
            this.numericUpDownBlockSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Blok size ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Plain text";
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Location = new System.Drawing.Point(320, 13);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonEnkripsi.TabIndex = 19;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // textBoxEnkripsiPlainText
            // 
            this.textBoxEnkripsiPlainText.Location = new System.Drawing.Point(109, 13);
            this.textBoxEnkripsiPlainText.Name = "textBoxEnkripsiPlainText";
            this.textBoxEnkripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxEnkripsiPlainText.TabIndex = 17;
            // 
            // dataGridViewProsesEnkripsi
            // 
            this.dataGridViewProsesEnkripsi.AllowUserToAddRows = false;
            this.dataGridViewProsesEnkripsi.AllowUserToDeleteRows = false;
            this.dataGridViewProsesEnkripsi.AllowUserToOrderColumns = true;
            this.dataGridViewProsesEnkripsi.AllowUserToResizeColumns = false;
            this.dataGridViewProsesEnkripsi.AllowUserToResizeRows = false;
            this.dataGridViewProsesEnkripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProsesEnkripsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProsesEnkripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProsesEnkripsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProsesEnkripsi.Location = new System.Drawing.Point(8, 45);
            this.dataGridViewProsesEnkripsi.Name = "dataGridViewProsesEnkripsi";
            this.dataGridViewProsesEnkripsi.ReadOnly = true;
            this.dataGridViewProsesEnkripsi.RowHeadersVisible = false;
            this.dataGridViewProsesEnkripsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesEnkripsi.Size = new System.Drawing.Size(927, 422);
            this.dataGridViewProsesEnkripsi.TabIndex = 30;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxShowDekripsiDetail);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxDekripsiPlainText);
            this.tabPage3.Controls.Add(this.buttonDekripsi);
            this.tabPage3.Controls.Add(this.dataGridViewProsesDekripsi);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 475);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Dekripsi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowDekripsiDetail
            // 
            this.checkBoxShowDekripsiDetail.AutoSize = true;
            this.checkBoxShowDekripsiDetail.Location = new System.Drawing.Point(435, 16);
            this.checkBoxShowDekripsiDetail.Name = "checkBoxShowDekripsiDetail";
            this.checkBoxShowDekripsiDetail.Size = new System.Drawing.Size(162, 22);
            this.checkBoxShowDekripsiDetail.TabIndex = 29;
            this.checkBoxShowDekripsiDetail.Text = "Tunjukan Proses Detail";
            this.checkBoxShowDekripsiDetail.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Plain text";
            // 
            // textBoxDekripsiPlainText
            // 
            this.textBoxDekripsiPlainText.Location = new System.Drawing.Point(96, 14);
            this.textBoxDekripsiPlainText.Name = "textBoxDekripsiPlainText";
            this.textBoxDekripsiPlainText.ReadOnly = true;
            this.textBoxDekripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxDekripsiPlainText.TabIndex = 24;
            // 
            // buttonDekripsi
            // 
            this.buttonDekripsi.Location = new System.Drawing.Point(306, 13);
            this.buttonDekripsi.Name = "buttonDekripsi";
            this.buttonDekripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonDekripsi.TabIndex = 25;
            this.buttonDekripsi.Text = "Dekripsi";
            this.buttonDekripsi.UseVisualStyleBackColor = true;
            this.buttonDekripsi.Click += new System.EventHandler(this.buttonDekripsi_Click);
            // 
            // dataGridViewProsesDekripsi
            // 
            this.dataGridViewProsesDekripsi.AllowUserToAddRows = false;
            this.dataGridViewProsesDekripsi.AllowUserToDeleteRows = false;
            this.dataGridViewProsesDekripsi.AllowUserToResizeColumns = false;
            this.dataGridViewProsesDekripsi.AllowUserToResizeRows = false;
            this.dataGridViewProsesDekripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProsesDekripsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProsesDekripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProsesDekripsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProsesDekripsi.Location = new System.Drawing.Point(9, 45);
            this.dataGridViewProsesDekripsi.Name = "dataGridViewProsesDekripsi";
            this.dataGridViewProsesDekripsi.ReadOnly = true;
            this.dataGridViewProsesDekripsi.RowHeadersVisible = false;
            this.dataGridViewProsesDekripsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesDekripsi.Size = new System.Drawing.Size(927, 422);
            this.dataGridViewProsesDekripsi.TabIndex = 30;
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.tabControlRSA);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormRSA";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA (Rivest Shamir Adleman)";
            this.Load += new System.EventHandler(this.FormRSA_Load);
            this.tabControlRSA.ResumeLayout(false);
            this.tabPageKey.ResumeLayout(false);
            this.tabPageKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleEEA)).EndInit();
            this.tabPageEnkripsi.ResumeLayout(false);
            this.tabPageEnkripsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonHitungN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControlRSA;
        private System.Windows.Forms.TabPage tabPageKey;
        private System.Windows.Forms.TabPage tabPageEnkripsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.TextBox textBoxEnkripsiPlainText;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockSize;
        private System.Windows.Forms.Label label8;
        private DataGridViewNotSortAble dataGridViewProsesEnkripsi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDekripsiPlainText;
        private System.Windows.Forms.Button buttonDekripsi;
        private DataGridViewNotSortAble dataGridViewProsesDekripsi;
        private System.Windows.Forms.Button buttonRandomD;
        private System.Windows.Forms.Button buttonHitungE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotientN;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelTotienN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.CheckBox checkBoxShowEnkripsiDetail;
        private System.Windows.Forms.CheckBox checkBoxShowDekripsiDetail;
        private DataGridViewNotSortAble dataGridViewNotSortAbleEEA;
    }
}