namespace Kriptografi.Week3
{
    partial class FormGF
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
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCalcBiner = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCalcHex = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalcBiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalcHex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num 1";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumber1.Location = new System.Drawing.Point(85, 12);
            this.textBoxNumber1.MaxLength = 2;
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber1.TabIndex = 1;
            this.textBoxNumber1.Text = "7F";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumber2.Location = new System.Drawing.Point(85, 40);
            this.textBoxNumber2.MaxLength = 2;
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber2.TabIndex = 3;
            this.textBoxNumber2.Text = "89";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num 2";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(85, 96);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDivisor.Location = new System.Drawing.Point(85, 68);
            this.textBoxDivisor.MaxLength = 2;
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.ReadOnly = true;
            this.textBoxDivisor.Size = new System.Drawing.Size(100, 22);
            this.textBoxDivisor.TabIndex = 6;
            this.textBoxDivisor.Text = "11B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Divisor";
            // 
            // dataGridViewCalcBiner
            // 
            this.dataGridViewCalcBiner.AllowUserToAddRows = false;
            this.dataGridViewCalcBiner.AllowUserToDeleteRows = false;
            this.dataGridViewCalcBiner.AllowUserToResizeColumns = false;
            this.dataGridViewCalcBiner.AllowUserToResizeRows = false;
            this.dataGridViewCalcBiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCalcBiner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCalcBiner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCalcBiner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalcBiner.ColumnHeadersVisible = false;
            this.dataGridViewCalcBiner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewCalcBiner.Location = new System.Drawing.Point(191, 12);
            this.dataGridViewCalcBiner.Name = "dataGridViewCalcBiner";
            this.dataGridViewCalcBiner.ReadOnly = true;
            this.dataGridViewCalcBiner.RowHeadersVisible = false;
            this.dataGridViewCalcBiner.Size = new System.Drawing.Size(291, 482);
            this.dataGridViewCalcBiner.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // dataGridViewCalcHex
            // 
            this.dataGridViewCalcHex.AllowUserToAddRows = false;
            this.dataGridViewCalcHex.AllowUserToDeleteRows = false;
            this.dataGridViewCalcHex.AllowUserToResizeColumns = false;
            this.dataGridViewCalcHex.AllowUserToResizeRows = false;
            this.dataGridViewCalcHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCalcHex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCalcHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCalcHex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalcHex.ColumnHeadersVisible = false;
            this.dataGridViewCalcHex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewCalcHex.Location = new System.Drawing.Point(501, 12);
            this.dataGridViewCalcHex.Name = "dataGridViewCalcHex";
            this.dataGridViewCalcHex.ReadOnly = true;
            this.dataGridViewCalcHex.RowHeadersVisible = false;
            this.dataGridViewCalcHex.Size = new System.Drawing.Size(439, 482);
            this.dataGridViewCalcHex.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // FormGF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.dataGridViewCalcHex);
            this.Controls.Add(this.dataGridViewCalcBiner);
            this.Controls.Add(this.textBoxDivisor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGF";
            this.ShowIcon = false;
            this.Text = "GF Multiplication";
            this.Load += new System.EventHandler(this.FormGF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalcBiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalcHex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCalcBiner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridViewCalcHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

