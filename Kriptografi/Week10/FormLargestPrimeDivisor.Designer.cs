namespace Kriptografi.Week10
{
    partial class FormLargestPrimeDivisor
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
            this.dataGridViewNotSortAbleInfo = new Kriptografi.DataGridViewNotSortAble();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSampai = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDari = new System.Windows.Forms.NumericUpDown();
            this.buttonListNumber = new System.Windows.Forms.Button();
            this.checkBoxWriteToFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSampai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotSortAbleInfo
            // 
            this.dataGridViewNotSortAbleInfo.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleInfo.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleInfo.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleInfo.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleInfo.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleInfo.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.Location = new System.Drawing.Point(16, 80);
            this.dataGridViewNotSortAbleInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNotSortAbleInfo.Name = "dataGridViewNotSortAbleInfo";
            this.dataGridViewNotSortAbleInfo.ReadOnly = true;
            this.dataGridViewNotSortAbleInfo.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleInfo.Size = new System.Drawing.Size(676, 315);
            this.dataGridViewNotSortAbleInfo.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "-";
            // 
            // numericUpDownSampai
            // 
            this.numericUpDownSampai.Location = new System.Drawing.Point(160, 12);
            this.numericUpDownSampai.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownSampai.Name = "numericUpDownSampai";
            this.numericUpDownSampai.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownSampai.TabIndex = 39;
            // 
            // numericUpDownDari
            // 
            this.numericUpDownDari.Location = new System.Drawing.Point(16, 12);
            this.numericUpDownDari.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownDari.Name = "numericUpDownDari";
            this.numericUpDownDari.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownDari.TabIndex = 38;
            // 
            // buttonListNumber
            // 
            this.buttonListNumber.Location = new System.Drawing.Point(286, 12);
            this.buttonListNumber.Name = "buttonListNumber";
            this.buttonListNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonListNumber.TabIndex = 37;
            this.buttonListNumber.Text = "List Number";
            this.buttonListNumber.UseVisualStyleBackColor = true;
            this.buttonListNumber.Click += new System.EventHandler(this.buttonListNumber_Click);
            // 
            // checkBoxWriteToFile
            // 
            this.checkBoxWriteToFile.AutoSize = true;
            this.checkBoxWriteToFile.Location = new System.Drawing.Point(16, 43);
            this.checkBoxWriteToFile.Name = "checkBoxWriteToFile";
            this.checkBoxWriteToFile.Size = new System.Drawing.Size(142, 22);
            this.checkBoxWriteToFile.TabIndex = 41;
            this.checkBoxWriteToFile.Text = "Write To number.txt";
            this.checkBoxWriteToFile.UseVisualStyleBackColor = true;
            // 
            // FormLargestPrimeDivisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(708, 412);
            this.Controls.Add(this.checkBoxWriteToFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSampai);
            this.Controls.Add(this.numericUpDownDari);
            this.Controls.Add(this.buttonListNumber);
            this.Controls.Add(this.dataGridViewNotSortAbleInfo);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLargestPrimeDivisor";
            this.ShowIcon = false;
            this.Text = "Largest Prime Divisor P-1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSampai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridViewNotSortAble dataGridViewNotSortAbleInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSampai;
        private System.Windows.Forms.NumericUpDown numericUpDownDari;
        private System.Windows.Forms.Button buttonListNumber;
        private System.Windows.Forms.CheckBox checkBoxWriteToFile;
    }
}