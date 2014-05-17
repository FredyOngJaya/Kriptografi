namespace Kriptografi.Week6
{
    partial class FormAES
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.buttonKey = new System.Windows.Forms.Button();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnkripsiPlainText = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewProsesKey = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewKey = new Kriptografi.DataGridViewNotSortAble();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDownPutaran = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnkripsiCipherText = new System.Windows.Forms.TextBox();
            this.dataGridViewProsesEnkripsi = new Kriptografi.DataGridViewNotSortAble();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDekripsiPlainText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDekripsi = new System.Windows.Forms.Button();
            this.textBoxDekripsiCipherText = new System.Windows.Forms.TextBox();
            this.dataGridViewProsesDekripsi = new Kriptografi.DataGridViewNotSortAble();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKey)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPutaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(82, 13);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(204, 25);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.Text = "8432137890153456";
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(17, 16);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(31, 18);
            this.Key.TabIndex = 1;
            this.Key.Text = "Key";
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(294, 13);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(110, 26);
            this.buttonKey.TabIndex = 11;
            this.buttonKey.Text = "Key Schedule";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Location = new System.Drawing.Point(320, 13);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonEnkripsi.TabIndex = 16;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plain text";
            // 
            // textBoxEnkripsiPlainText
            // 
            this.textBoxEnkripsiPlainText.Location = new System.Drawing.Point(109, 13);
            this.textBoxEnkripsiPlainText.Name = "textBoxEnkripsiPlainText";
            this.textBoxEnkripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxEnkripsiPlainText.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 506);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Key);
            this.tabPage1.Controls.Add(this.dataGridViewProsesKey);
            this.tabPage1.Controls.Add(this.textBoxKey);
            this.tabPage1.Controls.Add(this.buttonKey);
            this.tabPage1.Controls.Add(this.dataGridViewKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Key Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProsesKey
            // 
            this.dataGridViewProsesKey.AllowUserToAddRows = false;
            this.dataGridViewProsesKey.AllowUserToDeleteRows = false;
            this.dataGridViewProsesKey.AllowUserToResizeColumns = false;
            this.dataGridViewProsesKey.AllowUserToResizeRows = false;
            this.dataGridViewProsesKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProsesKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProsesKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProsesKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProsesKey.Location = new System.Drawing.Point(7, 190);
            this.dataGridViewProsesKey.Name = "dataGridViewProsesKey";
            this.dataGridViewProsesKey.ReadOnly = true;
            this.dataGridViewProsesKey.RowHeadersVisible = false;
            this.dataGridViewProsesKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesKey.Size = new System.Drawing.Size(927, 247);
            this.dataGridViewProsesKey.TabIndex = 17;
            // 
            // dataGridViewKey
            // 
            this.dataGridViewKey.AllowUserToAddRows = false;
            this.dataGridViewKey.AllowUserToDeleteRows = false;
            this.dataGridViewKey.AllowUserToResizeColumns = false;
            this.dataGridViewKey.AllowUserToResizeRows = false;
            this.dataGridViewKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKey.Location = new System.Drawing.Point(7, 46);
            this.dataGridViewKey.Name = "dataGridViewKey";
            this.dataGridViewKey.ReadOnly = true;
            this.dataGridViewKey.RowHeadersVisible = false;
            this.dataGridViewKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewKey.Size = new System.Drawing.Size(927, 131);
            this.dataGridViewKey.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownPutaran);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxEnkripsiCipherText);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonEnkripsi);
            this.tabPage2.Controls.Add(this.textBoxEnkripsiPlainText);
            this.tabPage2.Controls.Add(this.dataGridViewProsesEnkripsi);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enkripsi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPutaran
            // 
            this.numericUpDownPutaran.Location = new System.Drawing.Point(551, 13);
            this.numericUpDownPutaran.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPutaran.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPutaran.Name = "numericUpDownPutaran";
            this.numericUpDownPutaran.Size = new System.Drawing.Size(34, 25);
            this.numericUpDownPutaran.TabIndex = 22;
            this.numericUpDownPutaran.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Putaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cipher text";
            // 
            // textBoxEnkripsiCipherText
            // 
            this.textBoxEnkripsiCipherText.Location = new System.Drawing.Point(732, 13);
            this.textBoxEnkripsiCipherText.Name = "textBoxEnkripsiCipherText";
            this.textBoxEnkripsiCipherText.ReadOnly = true;
            this.textBoxEnkripsiCipherText.Size = new System.Drawing.Size(204, 25);
            this.textBoxEnkripsiCipherText.TabIndex = 19;
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
            this.dataGridViewProsesEnkripsi.Location = new System.Drawing.Point(9, 45);
            this.dataGridViewProsesEnkripsi.Name = "dataGridViewProsesEnkripsi";
            this.dataGridViewProsesEnkripsi.ReadOnly = true;
            this.dataGridViewProsesEnkripsi.RowHeadersVisible = false;
            this.dataGridViewProsesEnkripsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesEnkripsi.Size = new System.Drawing.Size(927, 422);
            this.dataGridViewProsesEnkripsi.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxDekripsiPlainText);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.buttonDekripsi);
            this.tabPage3.Controls.Add(this.textBoxDekripsiCipherText);
            this.tabPage3.Controls.Add(this.dataGridViewProsesDekripsi);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dekripsi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Plain text";
            // 
            // textBoxDekripsiPlainText
            // 
            this.textBoxDekripsiPlainText.Location = new System.Drawing.Point(732, 13);
            this.textBoxDekripsiPlainText.Name = "textBoxDekripsiPlainText";
            this.textBoxDekripsiPlainText.ReadOnly = true;
            this.textBoxDekripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxDekripsiPlainText.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cipher text";
            // 
            // buttonDekripsi
            // 
            this.buttonDekripsi.Location = new System.Drawing.Point(320, 13);
            this.buttonDekripsi.Name = "buttonDekripsi";
            this.buttonDekripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonDekripsi.TabIndex = 23;
            this.buttonDekripsi.Text = "Dekripsi";
            this.buttonDekripsi.UseVisualStyleBackColor = true;
            this.buttonDekripsi.Click += new System.EventHandler(this.buttonDekripsi_Click);
            // 
            // textBoxDekripsiCipherText
            // 
            this.textBoxDekripsiCipherText.Location = new System.Drawing.Point(109, 13);
            this.textBoxDekripsiCipherText.Name = "textBoxDekripsiCipherText";
            this.textBoxDekripsiCipherText.ReadOnly = true;
            this.textBoxDekripsiCipherText.Size = new System.Drawing.Size(204, 25);
            this.textBoxDekripsiCipherText.TabIndex = 21;
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
            this.dataGridViewProsesDekripsi.TabIndex = 24;
            // 
            // FormAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormAES";
            this.ShowIcon = false;
            this.Text = "AES";
            this.Load += new System.EventHandler(this.FormAES_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKey)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPutaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Button buttonKey;
        private DataGridViewNotSortAble dataGridViewKey;
        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnkripsiPlainText;
        private DataGridViewNotSortAble dataGridViewProsesKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataGridViewNotSortAble dataGridViewProsesEnkripsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnkripsiCipherText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDekripsiPlainText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDekripsi;
        private System.Windows.Forms.TextBox textBoxDekripsiCipherText;
        private DataGridViewNotSortAble dataGridViewProsesDekripsi;
        private System.Windows.Forms.NumericUpDown numericUpDownPutaran;
        private System.Windows.Forms.Label label5;
    }
}