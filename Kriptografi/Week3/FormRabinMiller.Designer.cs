namespace Kriptografi.Week3
{
    partial class FormRabinMiller
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
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonTesPrima = new System.Windows.Forms.Button();
            this.textBoxHasilRabinMiller = new System.Windows.Forms.TextBox();
            this.dataGridViewTes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(12, 12);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(255, 25);
            this.textBoxNum.TabIndex = 0;
            // 
            // buttonTesPrima
            // 
            this.buttonTesPrima.Location = new System.Drawing.Point(12, 43);
            this.buttonTesPrima.Name = "buttonTesPrima";
            this.buttonTesPrima.Size = new System.Drawing.Size(100, 28);
            this.buttonTesPrima.TabIndex = 1;
            this.buttonTesPrima.Text = "Rabin Miller";
            this.buttonTesPrima.UseVisualStyleBackColor = true;
            this.buttonTesPrima.Click += new System.EventHandler(this.buttonTesPrima_Click);
            // 
            // textBoxHasilRabinMiller
            // 
            this.textBoxHasilRabinMiller.Location = new System.Drawing.Point(12, 77);
            this.textBoxHasilRabinMiller.Name = "textBoxHasilRabinMiller";
            this.textBoxHasilRabinMiller.ReadOnly = true;
            this.textBoxHasilRabinMiller.Size = new System.Drawing.Size(553, 25);
            this.textBoxHasilRabinMiller.TabIndex = 2;
            // 
            // dataGridViewTes
            // 
            this.dataGridViewTes.AllowUserToAddRows = false;
            this.dataGridViewTes.AllowUserToDeleteRows = false;
            this.dataGridViewTes.AllowUserToResizeColumns = false;
            this.dataGridViewTes.AllowUserToResizeRows = false;
            this.dataGridViewTes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTes.ColumnHeadersVisible = false;
            this.dataGridViewTes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewTes.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewTes.Name = "dataGridViewTes";
            this.dataGridViewTes.ReadOnly = true;
            this.dataGridViewTes.RowHeadersVisible = false;
            this.dataGridViewTes.Size = new System.Drawing.Size(553, 249);
            this.dataGridViewTes.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(553, 25);
            this.textBox1.TabIndex = 9;
            // 
            // FormRabinMiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(577, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewTes);
            this.Controls.Add(this.textBoxHasilRabinMiller);
            this.Controls.Add(this.buttonTesPrima);
            this.Controls.Add(this.textBoxNum);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRabinMiller";
            this.ShowIcon = false;
            this.Text = "Rabin Miller";
            this.Load += new System.EventHandler(this.FormRabinMiller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonTesPrima;
        private System.Windows.Forms.TextBox textBoxHasilRabinMiller;
        private System.Windows.Forms.DataGridView dataGridViewTes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox1;
    }
}