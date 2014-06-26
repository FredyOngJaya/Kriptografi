namespace Kriptografi.Week10
{
    partial class FormSchnorrSignature
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
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.buttonRandomK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonHitungY = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelTotienN = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewNotSortAbleFaktorPrimaP1 = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleProses = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleInfo = new Kriptografi.DataGridViewNotSortAble();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleFaktorPrimaP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(387, 167);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(89, 25);
            this.buttonVerify.TabIndex = 58;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(292, 167);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(89, 25);
            this.buttonSign.TabIndex = 57;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Plaintext";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(86, 167);
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.Size = new System.Drawing.Size(200, 25);
            this.textBoxPlaintext.TabIndex = 56;
            // 
            // buttonRandomK
            // 
            this.buttonRandomK.Location = new System.Drawing.Point(292, 136);
            this.buttonRandomK.Name = "buttonRandomK";
            this.buttonRandomK.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomK.TabIndex = 54;
            this.buttonRandomK.Text = "Random K";
            this.buttonRandomK.UseVisualStyleBackColor = true;
            this.buttonRandomK.Click += new System.EventHandler(this.buttonRandomK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "K";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(86, 136);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(200, 25);
            this.textBoxK.TabIndex = 53;
            // 
            // buttonHitungY
            // 
            this.buttonHitungY.Location = new System.Drawing.Point(292, 74);
            this.buttonHitungY.Name = "buttonHitungY";
            this.buttonHitungY.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungY.TabIndex = 49;
            this.buttonHitungY.Text = "Hitung Y";
            this.buttonHitungY.UseVisualStyleBackColor = true;
            this.buttonHitungY.Click += new System.EventHandler(this.buttonHitungY_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(86, 105);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(200, 25);
            this.textBoxY.TabIndex = 50;
            // 
            // labelTotienN
            // 
            this.labelTotienN.AutoSize = true;
            this.labelTotienN.Location = new System.Drawing.Point(12, 108);
            this.labelTotienN.Name = "labelTotienN";
            this.labelTotienN.Size = new System.Drawing.Size(17, 18);
            this.labelTotienN.TabIndex = 48;
            this.labelTotienN.Text = "Y";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(86, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 25);
            this.textBoxP.TabIndex = 45;
            this.textBoxP.Leave += new System.EventHandler(this.textBoxP_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "G";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(86, 43);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(200, 25);
            this.textBoxG.TabIndex = 46;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(86, 74);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(200, 25);
            this.textBoxX.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Faktor Prima dari P-1";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(465, 39);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(200, 25);
            this.textBoxQ.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Q";
            // 
            // dataGridViewNotSortAbleFaktorPrimaP1
            // 
            this.dataGridViewNotSortAbleFaktorPrimaP1.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleFaktorPrimaP1.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleFaktorPrimaP1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleFaktorPrimaP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleFaktorPrimaP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleFaktorPrimaP1.ColumnHeadersVisible = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.Location = new System.Drawing.Point(671, 40);
            this.dataGridViewNotSortAbleFaktorPrimaP1.Name = "dataGridViewNotSortAbleFaktorPrimaP1";
            this.dataGridViewNotSortAbleFaktorPrimaP1.ReadOnly = true;
            this.dataGridViewNotSortAbleFaktorPrimaP1.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleFaktorPrimaP1.Size = new System.Drawing.Size(278, 148);
            this.dataGridViewNotSortAbleFaktorPrimaP1.TabIndex = 60;
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
            this.dataGridViewNotSortAbleProses.Location = new System.Drawing.Point(12, 362);
            this.dataGridViewNotSortAbleProses.Name = "dataGridViewNotSortAbleProses";
            this.dataGridViewNotSortAbleProses.ReadOnly = true;
            this.dataGridViewNotSortAbleProses.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleProses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleProses.Size = new System.Drawing.Size(937, 146);
            this.dataGridViewNotSortAbleProses.TabIndex = 59;
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
            this.dataGridViewNotSortAbleInfo.Location = new System.Drawing.Point(12, 198);
            this.dataGridViewNotSortAbleInfo.Name = "dataGridViewNotSortAbleInfo";
            this.dataGridViewNotSortAbleInfo.ReadOnly = true;
            this.dataGridViewNotSortAbleInfo.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleInfo.Size = new System.Drawing.Size(937, 148);
            this.dataGridViewNotSortAbleInfo.TabIndex = 51;
            // 
            // FormSchnorrSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(961, 520);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewNotSortAbleFaktorPrimaP1);
            this.Controls.Add(this.dataGridViewNotSortAbleProses);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPlaintext);
            this.Controls.Add(this.buttonRandomK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.dataGridViewNotSortAbleInfo);
            this.Controls.Add(this.buttonHitungY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelTotienN);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSchnorrSignature";
            this.ShowIcon = false;
            this.Text = "Schnorr Signature";
            this.Load += new System.EventHandler(this.FormSchnorrSignature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleFaktorPrimaP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridViewNotSortAble dataGridViewNotSortAbleProses;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Button buttonRandomK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxK;
        private DataGridViewNotSortAble dataGridViewNotSortAbleInfo;
        private System.Windows.Forms.Button buttonHitungY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelTotienN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label3;
        private DataGridViewNotSortAble dataGridViewNotSortAbleFaktorPrimaP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label5;

    }
}