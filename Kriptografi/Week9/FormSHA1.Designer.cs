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
            this.dataGridViewNotSortAbleProses = new Kriptografi.DataGridViewNotSortAble();
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
            this.dataGridViewNotSortAbleProses.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewNotSortAbleProses.Name = "dataGridViewNotSortAbleProses";
            this.dataGridViewNotSortAbleProses.ReadOnly = true;
            this.dataGridViewNotSortAbleProses.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleProses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleProses.Size = new System.Drawing.Size(928, 452);
            this.dataGridViewNotSortAbleProses.TabIndex = 29;
            // 
            // FormSHA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.dataGridViewNotSortAbleProses);
            this.Controls.Add(this.buttonSHA1);
            this.Controls.Add(this.textBoxMessage);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSHA1";
            this.ShowIcon = false;
            this.Text = "SHA1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSHA1;
        private DataGridViewNotSortAble dataGridViewNotSortAbleProses;
    }
}