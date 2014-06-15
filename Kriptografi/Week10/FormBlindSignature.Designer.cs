namespace Kriptografi.Week10
{
    partial class FormBlindSignature
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
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRandomD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHitungE = new System.Windows.Forms.Button();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.buttonHitungN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotientN = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.labelTotienN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRandomK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.dataGridViewNotSortAbleInfo = new Kriptografi.DataGridViewNotSortAble();
            this.dataGridViewNotSortAbleEEA = new Kriptografi.DataGridViewNotSortAble();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleEEA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(93, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 25);
            this.textBoxP.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "P";
            // 
            // buttonRandomD
            // 
            this.buttonRandomD.Location = new System.Drawing.Point(299, 87);
            this.buttonRandomD.Name = "buttonRandomD";
            this.buttonRandomD.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomD.TabIndex = 22;
            this.buttonRandomD.Text = "Random D";
            this.buttonRandomD.UseVisualStyleBackColor = true;
            this.buttonRandomD.Click += new System.EventHandler(this.buttonRandomD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Q";
            // 
            // buttonHitungE
            // 
            this.buttonHitungE.Location = new System.Drawing.Point(299, 118);
            this.buttonHitungE.Name = "buttonHitungE";
            this.buttonHitungE.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungE.TabIndex = 24;
            this.buttonHitungE.Text = "Hitung E";
            this.buttonHitungE.UseVisualStyleBackColor = true;
            this.buttonHitungE.Click += new System.EventHandler(this.buttonHitungE_Click);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(93, 43);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(200, 25);
            this.textBoxQ.TabIndex = 17;
            // 
            // buttonHitungN
            // 
            this.buttonHitungN.Location = new System.Drawing.Point(299, 43);
            this.buttonHitungN.Name = "buttonHitungN";
            this.buttonHitungN.Size = new System.Drawing.Size(156, 25);
            this.buttonHitungN.TabIndex = 18;
            this.buttonHitungN.Text = "Hitung N dan Totient N";
            this.buttonHitungN.UseVisualStyleBackColor = true;
            this.buttonHitungN.Click += new System.EventHandler(this.buttonHitungN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "D";
            // 
            // textBoxTotientN
            // 
            this.textBoxTotientN.Location = new System.Drawing.Point(546, 43);
            this.textBoxTotientN.Name = "textBoxTotientN";
            this.textBoxTotientN.ReadOnly = true;
            this.textBoxTotientN.Size = new System.Drawing.Size(200, 25);
            this.textBoxTotientN.TabIndex = 20;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(93, 87);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(200, 25);
            this.textBoxD.TabIndex = 21;
            // 
            // labelTotienN
            // 
            this.labelTotienN.AutoSize = true;
            this.labelTotienN.Location = new System.Drawing.Point(493, 46);
            this.labelTotienN.Name = "labelTotienN";
            this.labelTotienN.Size = new System.Drawing.Size(44, 18);
            this.labelTotienN.TabIndex = 11;
            this.labelTotienN.Text = "totient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "E";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(546, 12);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(200, 25);
            this.textBoxN.TabIndex = 19;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(93, 118);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.ReadOnly = true;
            this.textBoxE.Size = new System.Drawing.Size(200, 25);
            this.textBoxE.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "N";
            // 
            // buttonRandomK
            // 
            this.buttonRandomK.Location = new System.Drawing.Point(752, 87);
            this.buttonRandomK.Name = "buttonRandomK";
            this.buttonRandomK.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomK.TabIndex = 32;
            this.buttonRandomK.Text = "Random K";
            this.buttonRandomK.UseVisualStyleBackColor = true;
            this.buttonRandomK.Click += new System.EventHandler(this.buttonRandomK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "K";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(546, 87);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(200, 25);
            this.textBoxK.TabIndex = 31;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(299, 169);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(89, 25);
            this.buttonSign.TabIndex = 35;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Plaintext";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(93, 169);
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.Size = new System.Drawing.Size(200, 25);
            this.textBoxPlaintext.TabIndex = 34;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(394, 169);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(89, 25);
            this.buttonVerify.TabIndex = 36;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
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
            this.dataGridViewNotSortAbleInfo.Location = new System.Drawing.Point(12, 344);
            this.dataGridViewNotSortAbleInfo.Name = "dataGridViewNotSortAbleInfo";
            this.dataGridViewNotSortAbleInfo.ReadOnly = true;
            this.dataGridViewNotSortAbleInfo.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleInfo.Size = new System.Drawing.Size(920, 146);
            this.dataGridViewNotSortAbleInfo.TabIndex = 37;
            // 
            // dataGridViewNotSortAbleEEA
            // 
            this.dataGridViewNotSortAbleEEA.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleEEA.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleEEA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleEEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleEEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleEEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleEEA.Location = new System.Drawing.Point(12, 200);
            this.dataGridViewNotSortAbleEEA.Name = "dataGridViewNotSortAbleEEA";
            this.dataGridViewNotSortAbleEEA.ReadOnly = true;
            this.dataGridViewNotSortAbleEEA.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleEEA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleEEA.Size = new System.Drawing.Size(920, 138);
            this.dataGridViewNotSortAbleEEA.TabIndex = 29;
            // 
            // FormBlindSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.dataGridViewNotSortAbleInfo);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPlaintext);
            this.Controls.Add(this.buttonRandomK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.dataGridViewNotSortAbleEEA);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandomD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHitungE);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.buttonHitungN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTotientN);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.labelTotienN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormBlindSignature";
            this.ShowIcon = false;
            this.Text = "Tanda Tangan Buta";
            this.Load += new System.EventHandler(this.FormBlindSignature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleEEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRandomD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHitungE;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Button buttonHitungN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotientN;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelTotienN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label3;
        private DataGridViewNotSortAble dataGridViewNotSortAbleEEA;
        private System.Windows.Forms.Button buttonRandomK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Button buttonVerify;
        private DataGridViewNotSortAble dataGridViewNotSortAbleInfo;
    }
}