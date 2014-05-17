namespace Kriptografi.Week4
{
    partial class FormChineseRemainderTheorem
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewCRT = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonHitungCRT = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCRT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X =";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(47, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(200, 25);
            this.textBoxNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "mod";
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(294, 12);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(200, 25);
            this.textBoxDivisor.TabIndex = 3;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(12, 43);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(135, 29);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.Text = "Tambah Persamaan";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewCRT
            // 
            this.dataGridViewCRT.AllowUserToAddRows = false;
            this.dataGridViewCRT.AllowUserToDeleteRows = false;
            this.dataGridViewCRT.AllowUserToResizeColumns = false;
            this.dataGridViewCRT.AllowUserToResizeRows = false;
            this.dataGridViewCRT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCRT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCRT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCRT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.number,
            this.mod,
            this.divisor});
            this.dataGridViewCRT.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewCRT.MultiSelect = false;
            this.dataGridViewCRT.Name = "dataGridViewCRT";
            this.dataGridViewCRT.ReadOnly = true;
            this.dataGridViewCRT.RowHeadersVisible = false;
            this.dataGridViewCRT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCRT.Size = new System.Drawing.Size(486, 318);
            this.dataGridViewCRT.TabIndex = 9;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 41;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 78;
            // 
            // mod
            // 
            this.mod.HeaderText = "mod";
            this.mod.Name = "mod";
            this.mod.ReadOnly = true;
            this.mod.Width = 60;
            // 
            // divisor
            // 
            this.divisor.HeaderText = "divisor";
            this.divisor.Name = "divisor";
            this.divisor.ReadOnly = true;
            this.divisor.Width = 72;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 25);
            this.textBox1.TabIndex = 10;
            // 
            // buttonHitungCRT
            // 
            this.buttonHitungCRT.Location = new System.Drawing.Point(12, 402);
            this.buttonHitungCRT.Name = "buttonHitungCRT";
            this.buttonHitungCRT.Size = new System.Drawing.Size(204, 29);
            this.buttonHitungCRT.TabIndex = 11;
            this.buttonHitungCRT.Text = "Chinese Remainder Theorem";
            this.buttonHitungCRT.UseVisualStyleBackColor = true;
            this.buttonHitungCRT.Click += new System.EventHandler(this.buttonHitungCRT_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(363, 43);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(135, 29);
            this.buttonHapus.TabIndex = 12;
            this.buttonHapus.Text = "Hapus Persamaan";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // FormChineseRemainderTheorem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(510, 474);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonHitungCRT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewCRT);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxDivisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChineseRemainderTheorem";
            this.ShowIcon = false;
            this.Text = "Chinese Remainder Theorem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewCRT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonHitungCRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisor;
        private System.Windows.Forms.Button buttonHapus;
    }
}