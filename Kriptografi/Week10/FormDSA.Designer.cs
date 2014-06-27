namespace Kriptografi.Week10
{
    partial class FormDSA
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
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonHitungG = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.buttonRandomX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonHitungY = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelTotienN = new System.Windows.Forms.Label();
            this.buttonRandomK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.dataGridViewNotSortAbleProses = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleInfo = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleFaktorPrimaP1 = new Kriptografi.DataGridViewNotSortAble();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleFaktorPrimaP1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(89, 43);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(200, 25);
            this.textBoxQ.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Faktor Prima dari P-1";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(89, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 25);
            this.textBoxP.TabIndex = 69;
            this.textBoxP.Leave += new System.EventHandler(this.textBoxP_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "G";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(89, 105);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(200, 25);
            this.textBoxG.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "H";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(89, 74);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(200, 25);
            this.textBoxH.TabIndex = 73;
            // 
            // buttonHitungG
            // 
            this.buttonHitungG.Location = new System.Drawing.Point(295, 74);
            this.buttonHitungG.Name = "buttonHitungG";
            this.buttonHitungG.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungG.TabIndex = 74;
            this.buttonHitungG.Text = "Hitung G";
            this.buttonHitungG.UseVisualStyleBackColor = true;
            this.buttonHitungG.Click += new System.EventHandler(this.buttonHitungG_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(390, 229);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(89, 25);
            this.buttonVerify.TabIndex = 80;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(295, 229);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(89, 25);
            this.buttonSign.TabIndex = 79;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 77;
            this.label7.Text = "Plaintext";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(89, 229);
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.Size = new System.Drawing.Size(200, 25);
            this.textBoxPlaintext.TabIndex = 78;
            // 
            // buttonRandomX
            // 
            this.buttonRandomX.Location = new System.Drawing.Point(295, 136);
            this.buttonRandomX.Name = "buttonRandomX";
            this.buttonRandomX.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomX.TabIndex = 83;
            this.buttonRandomX.Text = "Random X";
            this.buttonRandomX.UseVisualStyleBackColor = true;
            this.buttonRandomX.Click += new System.EventHandler(this.buttonRandomX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 81;
            this.label6.Text = "X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(89, 136);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(200, 25);
            this.textBoxX.TabIndex = 82;
            // 
            // buttonHitungY
            // 
            this.buttonHitungY.Location = new System.Drawing.Point(295, 167);
            this.buttonHitungY.Name = "buttonHitungY";
            this.buttonHitungY.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungY.TabIndex = 85;
            this.buttonHitungY.Text = "Hitung Y";
            this.buttonHitungY.UseVisualStyleBackColor = true;
            this.buttonHitungY.Click += new System.EventHandler(this.buttonHitungY_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(89, 167);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(200, 25);
            this.textBoxY.TabIndex = 86;
            // 
            // labelTotienN
            // 
            this.labelTotienN.AutoSize = true;
            this.labelTotienN.Location = new System.Drawing.Point(12, 170);
            this.labelTotienN.Name = "labelTotienN";
            this.labelTotienN.Size = new System.Drawing.Size(17, 18);
            this.labelTotienN.TabIndex = 84;
            this.labelTotienN.Text = "Y";
            // 
            // buttonRandomK
            // 
            this.buttonRandomK.Location = new System.Drawing.Point(295, 198);
            this.buttonRandomK.Name = "buttonRandomK";
            this.buttonRandomK.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomK.TabIndex = 89;
            this.buttonRandomK.Text = "Random K";
            this.buttonRandomK.UseVisualStyleBackColor = true;
            this.buttonRandomK.Click += new System.EventHandler(this.buttonRandomK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "K";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(89, 198);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(200, 25);
            this.textBoxK.TabIndex = 88;
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
            this.dataGridViewNotSortAbleProses.Location = new System.Drawing.Point(12, 400);
            this.dataGridViewNotSortAbleProses.Name = "dataGridViewNotSortAbleProses";
            this.dataGridViewNotSortAbleProses.ReadOnly = true;
            this.dataGridViewNotSortAbleProses.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleProses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleProses.Size = new System.Drawing.Size(906, 110);
            this.dataGridViewNotSortAbleProses.TabIndex = 76;
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
            this.dataGridViewNotSortAbleInfo.Location = new System.Drawing.Point(12, 260);
            this.dataGridViewNotSortAbleInfo.Name = "dataGridViewNotSortAbleInfo";
            this.dataGridViewNotSortAbleInfo.ReadOnly = true;
            this.dataGridViewNotSortAbleInfo.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleInfo.Size = new System.Drawing.Size(906, 134);
            this.dataGridViewNotSortAbleInfo.TabIndex = 75;
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
            this.dataGridViewNotSortAbleFaktorPrimaP1.Location = new System.Drawing.Point(553, 36);
            this.dataGridViewNotSortAbleFaktorPrimaP1.Name = "dataGridViewNotSortAbleFaktorPrimaP1";
            this.dataGridViewNotSortAbleFaktorPrimaP1.ReadOnly = true;
            this.dataGridViewNotSortAbleFaktorPrimaP1.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleFaktorPrimaP1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleFaktorPrimaP1.Size = new System.Drawing.Size(365, 147);
            this.dataGridViewNotSortAbleFaktorPrimaP1.TabIndex = 64;
            // 
            // FormDSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(930, 522);
            this.Controls.Add(this.buttonRandomK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.buttonHitungY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelTotienN);
            this.Controls.Add(this.buttonRandomX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPlaintext);
            this.Controls.Add(this.dataGridViewNotSortAbleProses);
            this.Controls.Add(this.dataGridViewNotSortAbleInfo);
            this.Controls.Add(this.buttonHitungG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewNotSortAbleFaktorPrimaP1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDSA";
            this.ShowIcon = false;
            this.Text = "Digital Signature Algorithm (DSA)";
            this.Load += new System.EventHandler(this.FormDSA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleProses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleFaktorPrimaP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DataGridViewNotSortAble dataGridViewNotSortAbleFaktorPrimaP1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button buttonHitungG;
        private DataGridViewNotSortAble dataGridViewNotSortAbleProses;
        private DataGridViewNotSortAble dataGridViewNotSortAbleInfo;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Button buttonRandomX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonHitungY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelTotienN;
        private System.Windows.Forms.Button buttonRandomK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxK;
    }
}