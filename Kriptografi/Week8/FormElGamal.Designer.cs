namespace Kriptografi.Week8
{
    partial class FormElGamal
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
            this.tabControlRSA = new System.Windows.Forms.TabControl();
            this.tabPageKey = new System.Windows.Forms.TabPage();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.buttonHitungY = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelTotienN = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageEnkripsi = new System.Windows.Forms.TabPage();
            this.buttonRandomK = new System.Windows.Forms.Button();
            this.checkBoxShowEnkripsiDetail = new System.Windows.Forms.CheckBox();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.textBoxEnkripsiPlainText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxShowDekripsiDetail = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDekripsiPlainText = new System.Windows.Forms.TextBox();
            this.buttonDekripsi = new System.Windows.Forms.Button();
            this.dataGridViewNotSortAbleKey = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewProsesEnkripsi = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewProsesDekripsi = new Kriptografi.DataGridViewNotSortAble();
            this.tabControlRSA.SuspendLayout();
            this.tabPageKey.SuspendLayout();
            this.tabPageEnkripsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).BeginInit();
            this.SuspendLayout();
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
            this.tabControlRSA.TabIndex = 12;
            // 
            // tabPageKey
            // 
            this.tabPageKey.Controls.Add(this.dataGridViewNotSortAbleKey);
            this.tabPageKey.Controls.Add(this.textBoxP);
            this.tabPageKey.Controls.Add(this.label6);
            this.tabPageKey.Controls.Add(this.label1);
            this.tabPageKey.Controls.Add(this.label2);
            this.tabPageKey.Controls.Add(this.textBoxG);
            this.tabPageKey.Controls.Add(this.buttonHitungY);
            this.tabPageKey.Controls.Add(this.textBoxY);
            this.tabPageKey.Controls.Add(this.labelTotienN);
            this.tabPageKey.Controls.Add(this.textBoxX);
            this.tabPageKey.Controls.Add(this.label3);
            this.tabPageKey.Location = new System.Drawing.Point(4, 27);
            this.tabPageKey.Name = "tabPageKey";
            this.tabPageKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKey.Size = new System.Drawing.Size(944, 475);
            this.tabPageKey.TabIndex = 0;
            this.tabPageKey.Text = "Key";
            this.tabPageKey.UseVisualStyleBackColor = true;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(59, 6);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 25);
            this.textBoxP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Publikasikan N dan E sebagai kunci publik, sedangkan P, Q ,dan D sebagai kunci pr" +
                "ivat";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "G";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(59, 37);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(200, 25);
            this.textBoxG.TabIndex = 2;
            // 
            // buttonHitungY
            // 
            this.buttonHitungY.Location = new System.Drawing.Point(265, 68);
            this.buttonHitungY.Name = "buttonHitungY";
            this.buttonHitungY.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungY.TabIndex = 4;
            this.buttonHitungY.Text = "Hitung Y";
            this.buttonHitungY.UseVisualStyleBackColor = true;
            this.buttonHitungY.Click += new System.EventHandler(this.buttonHitungY_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(59, 99);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(200, 25);
            this.textBoxY.TabIndex = 5;
            // 
            // labelTotienN
            // 
            this.labelTotienN.AutoSize = true;
            this.labelTotienN.Location = new System.Drawing.Point(6, 102);
            this.labelTotienN.Name = "labelTotienN";
            this.labelTotienN.Size = new System.Drawing.Size(17, 18);
            this.labelTotienN.TabIndex = 0;
            this.labelTotienN.Text = "Y";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(59, 68);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(200, 25);
            this.textBoxX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            // 
            // tabPageEnkripsi
            // 
            this.tabPageEnkripsi.Controls.Add(this.buttonRandomK);
            this.tabPageEnkripsi.Controls.Add(this.checkBoxShowEnkripsiDetail);
            this.tabPageEnkripsi.Controls.Add(this.numericUpDownBlockSize);
            this.tabPageEnkripsi.Controls.Add(this.label8);
            this.tabPageEnkripsi.Controls.Add(this.label4);
            this.tabPageEnkripsi.Controls.Add(this.label7);
            this.tabPageEnkripsi.Controls.Add(this.textBoxK);
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
            // buttonRandomK
            // 
            this.buttonRandomK.Location = new System.Drawing.Point(411, 12);
            this.buttonRandomK.Name = "buttonRandomK";
            this.buttonRandomK.Size = new System.Drawing.Size(78, 26);
            this.buttonRandomK.TabIndex = 19;
            this.buttonRandomK.Text = "Random K";
            this.buttonRandomK.UseVisualStyleBackColor = true;
            this.buttonRandomK.Click += new System.EventHandler(this.buttonRandomK_Click);
            // 
            // checkBoxShowEnkripsiDetail
            // 
            this.checkBoxShowEnkripsiDetail.AutoSize = true;
            this.checkBoxShowEnkripsiDetail.Location = new System.Drawing.Point(773, 15);
            this.checkBoxShowEnkripsiDetail.Name = "checkBoxShowEnkripsiDetail";
            this.checkBoxShowEnkripsiDetail.Size = new System.Drawing.Size(162, 22);
            this.checkBoxShowEnkripsiDetail.TabIndex = 22;
            this.checkBoxShowEnkripsiDetail.Text = "Tunjukan Proses Detail";
            this.checkBoxShowEnkripsiDetail.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBlockSize
            // 
            this.numericUpDownBlockSize.Location = new System.Drawing.Point(690, 14);
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
            this.numericUpDownBlockSize.TabIndex = 21;
            this.numericUpDownBlockSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Blok size ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "K";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Plain text";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(310, 13);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(95, 25);
            this.textBoxK.TabIndex = 18;
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Location = new System.Drawing.Point(495, 12);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonEnkripsi.TabIndex = 20;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // textBoxEnkripsiPlainText
            // 
            this.textBoxEnkripsiPlainText.Location = new System.Drawing.Point(77, 13);
            this.textBoxEnkripsiPlainText.Name = "textBoxEnkripsiPlainText";
            this.textBoxEnkripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxEnkripsiPlainText.TabIndex = 17;
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
            this.textBoxDekripsiPlainText.TabIndex = 25;
            // 
            // buttonDekripsi
            // 
            this.buttonDekripsi.Location = new System.Drawing.Point(306, 13);
            this.buttonDekripsi.Name = "buttonDekripsi";
            this.buttonDekripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonDekripsi.TabIndex = 26;
            this.buttonDekripsi.Text = "Dekripsi";
            this.buttonDekripsi.UseVisualStyleBackColor = true;
            this.buttonDekripsi.Click += new System.EventHandler(this.buttonDekripsi_Click);
            // 
            // dataGridViewNotSortAbleKey
            // 
            this.dataGridViewNotSortAbleKey.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleKey.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleKey.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleKey.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleKey.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleKey.Location = new System.Drawing.Point(8, 148);
            this.dataGridViewNotSortAbleKey.Name = "dataGridViewNotSortAbleKey";
            this.dataGridViewNotSortAbleKey.ReadOnly = true;
            this.dataGridViewNotSortAbleKey.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleKey.Size = new System.Drawing.Size(928, 319);
            this.dataGridViewNotSortAbleKey.TabIndex = 28;
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
            this.dataGridViewProsesEnkripsi.TabIndex = 27;
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
            // FormElGamal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.tabControlRSA);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormElGamal";
            this.ShowIcon = false;
            this.Text = "El Gamal";
            this.Load += new System.EventHandler(this.FormElGamal_Load);
            this.tabControlRSA.ResumeLayout(false);
            this.tabPageKey.ResumeLayout(false);
            this.tabPageKey.PerformLayout();
            this.tabPageEnkripsi.ResumeLayout(false);
            this.tabPageEnkripsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRSA;
        private System.Windows.Forms.TabPage tabPageKey;
        private DataGridViewNotSortAble dataGridViewNotSortAbleKey;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Button buttonHitungY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelTotienN;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageEnkripsi;
        private System.Windows.Forms.CheckBox checkBoxShowEnkripsiDetail;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.TextBox textBoxEnkripsiPlainText;
        private DataGridViewNotSortAble dataGridViewProsesEnkripsi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBoxShowDekripsiDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDekripsiPlainText;
        private System.Windows.Forms.Button buttonDekripsi;
        private DataGridViewNotSortAble dataGridViewProsesDekripsi;
        private System.Windows.Forms.Button buttonRandomK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxK;

    }
}