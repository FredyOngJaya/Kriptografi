namespace Kriptografi.Week7
{
    partial class FormLFSR
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
            this.treeViewBit = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBit = new System.Windows.Forms.NumericUpDown();
            this.buttonSetBit = new System.Windows.Forms.Button();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLFSR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownBuang = new System.Windows.Forms.NumericUpDown();
            this.radioButtonShiftLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonShiftRight = new System.Windows.Forms.RadioButton();
            this.dataGridViewProsesLFSR = new Kriptografi.DataGridViewNotSortAble();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownNKunci = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNBitKunci = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewListKey = new Kriptografi.DataGridViewNotSortAble();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesLFSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNKunci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNBitKunci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListKey)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewBit
            // 
            this.treeViewBit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewBit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewBit.CheckBoxes = true;
            this.treeViewBit.Location = new System.Drawing.Point(12, 43);
            this.treeViewBit.Name = "treeViewBit";
            this.treeViewBit.Size = new System.Drawing.Size(139, 451);
            this.treeViewBit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bit";
            // 
            // numericUpDownBit
            // 
            this.numericUpDownBit.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBit.Location = new System.Drawing.Point(60, 12);
            this.numericUpDownBit.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownBit.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBit.Name = "numericUpDownBit";
            this.numericUpDownBit.Size = new System.Drawing.Size(41, 25);
            this.numericUpDownBit.TabIndex = 2;
            this.numericUpDownBit.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // buttonSetBit
            // 
            this.buttonSetBit.Location = new System.Drawing.Point(107, 11);
            this.buttonSetBit.Name = "buttonSetBit";
            this.buttonSetBit.Size = new System.Drawing.Size(44, 25);
            this.buttonSetBit.TabIndex = 3;
            this.buttonSetBit.Text = "Set";
            this.buttonSetBit.UseVisualStyleBackColor = true;
            this.buttonSetBit.Click += new System.EventHandler(this.buttonSetBit_Click);
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(231, 11);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(210, 25);
            this.textBoxSeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seed Text";
            // 
            // buttonLFSR
            // 
            this.buttonLFSR.Location = new System.Drawing.Point(447, 11);
            this.buttonLFSR.Name = "buttonLFSR";
            this.buttonLFSR.Size = new System.Drawing.Size(52, 25);
            this.buttonLFSR.TabIndex = 6;
            this.buttonLFSR.Text = "LFSR";
            this.buttonLFSR.UseVisualStyleBackColor = true;
            this.buttonLFSR.Click += new System.EventHandler(this.buttonLFSR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Buang";
            // 
            // numericUpDownBuang
            // 
            this.numericUpDownBuang.Location = new System.Drawing.Point(588, 11);
            this.numericUpDownBuang.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownBuang.Name = "numericUpDownBuang";
            this.numericUpDownBuang.Size = new System.Drawing.Size(41, 25);
            this.numericUpDownBuang.TabIndex = 22;
            this.numericUpDownBuang.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // radioButtonShiftLeft
            // 
            this.radioButtonShiftLeft.AutoSize = true;
            this.radioButtonShiftLeft.Location = new System.Drawing.Point(160, 43);
            this.radioButtonShiftLeft.Name = "radioButtonShiftLeft";
            this.radioButtonShiftLeft.Size = new System.Drawing.Size(115, 22);
            this.radioButtonShiftLeft.TabIndex = 24;
            this.radioButtonShiftLeft.TabStop = true;
            this.radioButtonShiftLeft.Text = "Shift Left Mode";
            this.radioButtonShiftLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonShiftRight
            // 
            this.radioButtonShiftRight.AutoSize = true;
            this.radioButtonShiftRight.Location = new System.Drawing.Point(288, 43);
            this.radioButtonShiftRight.Name = "radioButtonShiftRight";
            this.radioButtonShiftRight.Size = new System.Drawing.Size(123, 22);
            this.radioButtonShiftRight.TabIndex = 25;
            this.radioButtonShiftRight.TabStop = true;
            this.radioButtonShiftRight.Text = "Shift Right Mode";
            this.radioButtonShiftRight.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProsesLFSR
            // 
            this.dataGridViewProsesLFSR.AllowUserToAddRows = false;
            this.dataGridViewProsesLFSR.AllowUserToDeleteRows = false;
            this.dataGridViewProsesLFSR.AllowUserToResizeColumns = false;
            this.dataGridViewProsesLFSR.AllowUserToResizeRows = false;
            this.dataGridViewProsesLFSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProsesLFSR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProsesLFSR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProsesLFSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProsesLFSR.Location = new System.Drawing.Point(157, 71);
            this.dataGridViewProsesLFSR.Name = "dataGridViewProsesLFSR";
            this.dataGridViewProsesLFSR.ReadOnly = true;
            this.dataGridViewProsesLFSR.RowHeadersVisible = false;
            this.dataGridViewProsesLFSR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesLFSR.Size = new System.Drawing.Size(783, 289);
            this.dataGridViewProsesLFSR.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Jumlah Kunci";
            // 
            // numericUpDownNKunci
            // 
            this.numericUpDownNKunci.Location = new System.Drawing.Point(588, 42);
            this.numericUpDownNKunci.Name = "numericUpDownNKunci";
            this.numericUpDownNKunci.Size = new System.Drawing.Size(41, 25);
            this.numericUpDownNKunci.TabIndex = 43;
            this.numericUpDownNKunci.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Bit Kunci";
            // 
            // numericUpDownNBitKunci
            // 
            this.numericUpDownNBitKunci.Location = new System.Drawing.Point(702, 42);
            this.numericUpDownNBitKunci.Name = "numericUpDownNBitKunci";
            this.numericUpDownNBitKunci.Size = new System.Drawing.Size(50, 25);
            this.numericUpDownNBitKunci.TabIndex = 41;
            this.numericUpDownNBitKunci.Value = new decimal(new int[] {
            16,
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
            this.dataGridViewListKey.Location = new System.Drawing.Point(157, 366);
            this.dataGridViewListKey.Name = "dataGridViewListKey";
            this.dataGridViewListKey.ReadOnly = true;
            this.dataGridViewListKey.RowHeadersVisible = false;
            this.dataGridViewListKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewListKey.Size = new System.Drawing.Size(783, 128);
            this.dataGridViewListKey.TabIndex = 45;
            // 
            // FormLFSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.dataGridViewListKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownNKunci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownNBitKunci);
            this.Controls.Add(this.radioButtonShiftRight);
            this.Controls.Add(this.radioButtonShiftLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownBuang);
            this.Controls.Add(this.dataGridViewProsesLFSR);
            this.Controls.Add(this.buttonLFSR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.buttonSetBit);
            this.Controls.Add(this.numericUpDownBit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewBit);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormLFSR";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LFSR";
            this.Load += new System.EventHandler(this.FormLFSR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesLFSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNKunci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNBitKunci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBit;
        private System.Windows.Forms.Button buttonSetBit;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLFSR;
        private DataGridViewNotSortAble dataGridViewProsesLFSR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownBuang;
        private System.Windows.Forms.RadioButton radioButtonShiftLeft;
        private System.Windows.Forms.RadioButton radioButtonShiftRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownNKunci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNBitKunci;
        private DataGridViewNotSortAble dataGridViewListKey;
    }
}