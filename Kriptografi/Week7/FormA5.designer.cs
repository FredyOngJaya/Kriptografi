namespace Kriptografi.Week7
{
    partial class FormA5
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNBitKunci = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownNKunci = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewListKey = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewKey = new Kriptografi.DataGridViewNotSortAble();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNBitKunci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNKunci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKey)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key (8 karakter / 64 bit)";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(163, 12);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 25);
            this.textBoxKey.TabIndex = 1;
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(269, 12);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(75, 25);
            this.buttonKey.TabIndex = 2;
            this.buttonKey.Text = "A5";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Bit Kunci";
            // 
            // numericUpDownNBitKunci
            // 
            this.numericUpDownNBitKunci.Location = new System.Drawing.Point(678, 13);
            this.numericUpDownNBitKunci.Name = "numericUpDownNBitKunci";
            this.numericUpDownNBitKunci.Size = new System.Drawing.Size(50, 25);
            this.numericUpDownNBitKunci.TabIndex = 37;
            this.numericUpDownNBitKunci.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Jumlah Kunci";
            // 
            // numericUpDownNKunci
            // 
            this.numericUpDownNKunci.Location = new System.Drawing.Point(518, 12);
            this.numericUpDownNKunci.Name = "numericUpDownNKunci";
            this.numericUpDownNKunci.Size = new System.Drawing.Size(50, 25);
            this.numericUpDownNKunci.TabIndex = 39;
            this.numericUpDownNKunci.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dataGridViewListKey
            // 
            this.dataGridViewListKey.AllowUserToAddRows = false;
            this.dataGridViewListKey.AllowUserToDeleteRows = false;
            this.dataGridViewListKey.AllowUserToResizeColumns = false;
            this.dataGridViewListKey.AllowUserToResizeRows = false;
            this.dataGridViewListKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListKey.Location = new System.Drawing.Point(12, 380);
            this.dataGridViewListKey.Name = "dataGridViewListKey";
            this.dataGridViewListKey.ReadOnly = true;
            this.dataGridViewListKey.RowHeadersVisible = false;
            this.dataGridViewListKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewListKey.Size = new System.Drawing.Size(992, 150);
            this.dataGridViewListKey.TabIndex = 18;
            // 
            // dataGridViewKey
            // 
            this.dataGridViewKey.AllowUserToAddRows = false;
            this.dataGridViewKey.AllowUserToDeleteRows = false;
            this.dataGridViewKey.AllowUserToResizeColumns = false;
            this.dataGridViewKey.AllowUserToResizeRows = false;
            this.dataGridViewKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKey.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewKey.Name = "dataGridViewKey";
            this.dataGridViewKey.ReadOnly = true;
            this.dataGridViewKey.RowHeadersVisible = false;
            this.dataGridViewKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewKey.Size = new System.Drawing.Size(992, 331);
            this.dataGridViewKey.TabIndex = 18;
            // 
            // FormA5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownNKunci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNBitKunci);
            this.Controls.Add(this.dataGridViewListKey);
            this.Controls.Add(this.dataGridViewKey);
            this.Controls.Add(this.buttonKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormA5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A5";
            this.Load += new System.EventHandler(this.FormA5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNBitKunci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNKunci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonKey;
        private DataGridViewNotSortAble dataGridViewKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNBitKunci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownNKunci;
        private DataGridViewNotSortAble dataGridViewListKey;
    }
}