namespace Kriptografi.Week8
{
    partial class FormPrimeList
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
            this.dataGridViewNotSortAblePrima = new Kriptografi.DataGridViewNotSortAble();
            this.buttonShowPrime = new System.Windows.Forms.Button();
            this.numericUpDownDari = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSampai = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAblePrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSampai)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotSortAblePrima
            // 
            this.dataGridViewNotSortAblePrima.AllowUserToAddRows = false;
            this.dataGridViewNotSortAblePrima.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAblePrima.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAblePrima.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAblePrima.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAblePrima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAblePrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAblePrima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAblePrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAblePrima.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewNotSortAblePrima.Name = "dataGridViewNotSortAblePrima";
            this.dataGridViewNotSortAblePrima.ReadOnly = true;
            this.dataGridViewNotSortAblePrima.RowHeadersVisible = false;
            this.dataGridViewNotSortAblePrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAblePrima.Size = new System.Drawing.Size(649, 353);
            this.dataGridViewNotSortAblePrima.TabIndex = 29;
            // 
            // buttonShowPrime
            // 
            this.buttonShowPrime.Location = new System.Drawing.Point(282, 11);
            this.buttonShowPrime.Name = "buttonShowPrime";
            this.buttonShowPrime.Size = new System.Drawing.Size(75, 23);
            this.buttonShowPrime.TabIndex = 30;
            this.buttonShowPrime.Text = "List Prima";
            this.buttonShowPrime.UseVisualStyleBackColor = true;
            this.buttonShowPrime.Click += new System.EventHandler(this.buttonShowPrime_Click);
            // 
            // numericUpDownDari
            // 
            this.numericUpDownDari.Location = new System.Drawing.Point(12, 11);
            this.numericUpDownDari.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDari.Name = "numericUpDownDari";
            this.numericUpDownDari.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownDari.TabIndex = 31;
            // 
            // numericUpDownSampai
            // 
            this.numericUpDownSampai.Location = new System.Drawing.Point(156, 11);
            this.numericUpDownSampai.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSampai.Name = "numericUpDownSampai";
            this.numericUpDownSampai.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownSampai.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "-";
            // 
            // FormPrimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(673, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSampai);
            this.Controls.Add(this.numericUpDownDari);
            this.Controls.Add(this.buttonShowPrime);
            this.Controls.Add(this.dataGridViewNotSortAblePrima);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrimeList";
            this.ShowIcon = false;
            this.Text = "List Prima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAblePrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSampai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridViewNotSortAble dataGridViewNotSortAblePrima;
        private System.Windows.Forms.Button buttonShowPrime;
        private System.Windows.Forms.NumericUpDown numericUpDownDari;
        private System.Windows.Forms.NumericUpDown numericUpDownSampai;
        private System.Windows.Forms.Label label1;

    }
}