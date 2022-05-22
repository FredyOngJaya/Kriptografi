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
            this.btnPrecompute100 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrecompute10 = new System.Windows.Forms.Button();
            this.btnPrecompute1000 = new System.Windows.Forms.Button();
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
            this.dataGridViewNotSortAblePrima.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewNotSortAblePrima.Name = "dataGridViewNotSortAblePrima";
            this.dataGridViewNotSortAblePrima.ReadOnly = true;
            this.dataGridViewNotSortAblePrima.RowHeadersVisible = false;
            this.dataGridViewNotSortAblePrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAblePrima.Size = new System.Drawing.Size(689, 452);
            this.dataGridViewNotSortAblePrima.TabIndex = 29;
            // 
            // buttonShowPrime
            // 
            this.buttonShowPrime.Location = new System.Drawing.Point(282, 12);
            this.buttonShowPrime.Name = "buttonShowPrime";
            this.buttonShowPrime.Size = new System.Drawing.Size(218, 23);
            this.buttonShowPrime.TabIndex = 30;
            this.buttonShowPrime.Text = "List Prima (default max 1 000 000)";
            this.buttonShowPrime.UseVisualStyleBackColor = true;
            this.buttonShowPrime.Click += new System.EventHandler(this.buttonShowPrime_Click);
            // 
            // numericUpDownDari
            // 
            this.numericUpDownDari.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownDari.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDari.Name = "numericUpDownDari";
            this.numericUpDownDari.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDari.TabIndex = 31;
            // 
            // numericUpDownSampai
            // 
            this.numericUpDownSampai.Location = new System.Drawing.Point(156, 12);
            this.numericUpDownSampai.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownSampai.Name = "numericUpDownSampai";
            this.numericUpDownSampai.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSampai.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "-";
            // 
            // btnPrecompute100
            // 
            this.btnPrecompute100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrecompute100.Location = new System.Drawing.Point(12, 561);
            this.btnPrecompute100.Name = "btnPrecompute100";
            this.btnPrecompute100.Size = new System.Drawing.Size(424, 30);
            this.btnPrecompute100.TabIndex = 35;
            this.btnPrecompute100.Text = "Pre-compute 2 - 100.000.000 prime number";
            this.btnPrecompute100.UseVisualStyleBackColor = true;
            this.btnPrecompute100.Click += new System.EventHandler(this.btnPrecompute100_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Jika ingin bilangan prima di atas 1 000 000 pre compute terlebih dahulu";
            // 
            // btnPrecompute10
            // 
            this.btnPrecompute10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrecompute10.Location = new System.Drawing.Point(12, 525);
            this.btnPrecompute10.Name = "btnPrecompute10";
            this.btnPrecompute10.Size = new System.Drawing.Size(424, 30);
            this.btnPrecompute10.TabIndex = 37;
            this.btnPrecompute10.Text = "Pre-compute 2 - 10.000.000 prime number";
            this.btnPrecompute10.UseVisualStyleBackColor = true;
            this.btnPrecompute10.Click += new System.EventHandler(this.btnPrecompute10_Click);
            // 
            // btnPrecompute1000
            // 
            this.btnPrecompute1000.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrecompute1000.Location = new System.Drawing.Point(12, 597);
            this.btnPrecompute1000.Name = "btnPrecompute1000";
            this.btnPrecompute1000.Size = new System.Drawing.Size(424, 30);
            this.btnPrecompute1000.TabIndex = 38;
            this.btnPrecompute1000.Text = "Pre-compute 2 - 1 000.000.000 prime number (warning very slow)";
            this.btnPrecompute1000.UseVisualStyleBackColor = true;
            this.btnPrecompute1000.Click += new System.EventHandler(this.btnPrecompute1000_Click);
            // 
            // FormPrimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(713, 639);
            this.Controls.Add(this.btnPrecompute1000);
            this.Controls.Add(this.btnPrecompute10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrecompute100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSampai);
            this.Controls.Add(this.numericUpDownDari);
            this.Controls.Add(this.buttonShowPrime);
            this.Controls.Add(this.dataGridViewNotSortAblePrima);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnPrecompute100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrecompute10;
        private System.Windows.Forms.Button btnPrecompute1000;
    }
}