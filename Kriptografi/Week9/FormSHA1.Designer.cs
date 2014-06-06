namespace Kriptografi.Week9
{
    partial class FormSHA1
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSHA1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewNotSortAbleF = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleInfo = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleW = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleK = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleProses = new Kriptografi.DataGridViewNotSortAble();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(847, 25);
            this.textBoxMessage.TabIndex = 0;
            // 
            // buttonSHA1
            // 
            this.buttonSHA1.Location = new System.Drawing.Point(865, 13);
            this.buttonSHA1.Name = "buttonSHA1";
            this.buttonSHA1.Size = new System.Drawing.Size(75, 23);
            this.buttonSHA1.TabIndex = 1;
            this.buttonSHA1.Text = "SHA-1";
            this.buttonSHA1.UseVisualStyleBackColor = true;
            this.buttonSHA1.Click += new System.EventHandler(this.buttonSHA1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nilai K";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Proses";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nilai W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Info";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "ft(B,C,D)";
            // 
            // dataGridViewNotSortAbleF
            // 
            this.dataGridViewNotSortAbleF.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleF.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleF.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleF.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleF.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleF.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleF.Location = new System.Drawing.Point(735, 179);
            this.dataGridViewNotSortAbleF.Name = "dataGridViewNotSortAbleF";
            this.dataGridViewNotSortAbleF.ReadOnly = true;
            this.dataGridViewNotSortAbleF.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleF.Size = new System.Drawing.Size(205, 90);
            this.dataGridViewNotSortAbleF.TabIndex = 37;
            // 
            // dataGridViewNotSortAbleInfo
            // 
            this.dataGridViewNotSortAbleInfo.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleInfo.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleInfo.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleInfo.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleInfo.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleInfo.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewNotSortAbleInfo.Name = "dataGridViewNotSortAbleInfo";
            this.dataGridViewNotSortAbleInfo.ReadOnly = true;
            this.dataGridViewNotSortAbleInfo.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleInfo.Size = new System.Drawing.Size(717, 180);
            this.dataGridViewNotSortAbleInfo.TabIndex = 35;
            // 
            // dataGridViewNotSortAbleW
            // 
            this.dataGridViewNotSortAbleW.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleW.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleW.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleW.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleW.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleW.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleW.Location = new System.Drawing.Point(735, 293);
            this.dataGridViewNotSortAbleW.Name = "dataGridViewNotSortAbleW";
            this.dataGridViewNotSortAbleW.ReadOnly = true;
            this.dataGridViewNotSortAbleW.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleW.Size = new System.Drawing.Size(205, 201);
            this.dataGridViewNotSortAbleW.TabIndex = 33;
            // 
            // dataGridViewNotSortAbleK
            // 
            this.dataGridViewNotSortAbleK.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleK.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleK.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleK.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleK.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleK.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleK.Location = new System.Drawing.Point(735, 65);
            this.dataGridViewNotSortAbleK.Name = "dataGridViewNotSortAbleK";
            this.dataGridViewNotSortAbleK.ReadOnly = true;
            this.dataGridViewNotSortAbleK.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleK.Size = new System.Drawing.Size(205, 90);
            this.dataGridViewNotSortAbleK.TabIndex = 30;
            // 
            // dataGridViewNotSortAbleProses
            // 
            this.dataGridViewNotSortAbleProses.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleProses.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleProses.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleProses.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleProses.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleProses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleProses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleProses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleProses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleProses.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleProses.Location = new System.Drawing.Point(12, 269);
            this.dataGridViewNotSortAbleProses.Name = "dataGridViewNotSortAbleProses";
            this.dataGridViewNotSortAbleProses.ReadOnly = true;
            this.dataGridViewNotSortAbleProses.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleProses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleProses.Size = new System.Drawing.Size(717, 225);
            this.dataGridViewNotSortAbleProses.TabIndex = 29;
            // 
            // FormSHA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewNotSortAbleF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewNotSortAbleInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewNotSortAbleW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNotSortAbleK);
            this.Controls.Add(this.dataGridViewNotSortAbleProses);
            this.Controls.Add(this.buttonSHA1);
            this.Controls.Add(this.textBoxMessage);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormSHA1";
            this.ShowIcon = false;
            this.Text = "SHA1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSHA1;
        private DataGridViewNotSortAble dataGridViewNotSortAbleProses;
        private DataGridViewNotSortAble dataGridViewNotSortAbleK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataGridViewNotSortAble dataGridViewNotSortAbleW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DataGridViewNotSortAble dataGridViewNotSortAbleInfo;
        private DataGridViewNotSortAble dataGridViewNotSortAbleF;
        private System.Windows.Forms.Label label5;
    }
}