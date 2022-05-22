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
            this.txtIterasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(139, 15);
            this.textBoxNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(327, 29);
            this.textBoxNum.TabIndex = 0;
            // 
            // buttonTesPrima
            // 
            this.buttonTesPrima.Location = new System.Drawing.Point(15, 90);
            this.buttonTesPrima.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTesPrima.Name = "buttonTesPrima";
            this.buttonTesPrima.Size = new System.Drawing.Size(278, 35);
            this.buttonTesPrima.TabIndex = 10;
            this.buttonTesPrima.Text = "Rabin Miller";
            this.buttonTesPrima.UseVisualStyleBackColor = true;
            this.buttonTesPrima.Click += new System.EventHandler(this.buttonTesPrima_Click);
            // 
            // textBoxHasilRabinMiller
            // 
            this.textBoxHasilRabinMiller.Location = new System.Drawing.Point(13, 133);
            this.textBoxHasilRabinMiller.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHasilRabinMiller.Name = "textBoxHasilRabinMiller";
            this.textBoxHasilRabinMiller.ReadOnly = true;
            this.textBoxHasilRabinMiller.Size = new System.Drawing.Size(710, 29);
            this.textBoxHasilRabinMiller.TabIndex = 2;
            this.textBoxHasilRabinMiller.TabStop = false;
            // 
            // txtIterasi
            // 
            this.txtIterasi.Location = new System.Drawing.Point(139, 53);
            this.txtIterasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtIterasi.Name = "txtIterasi";
            this.txtIterasi.Size = new System.Drawing.Size(327, 29);
            this.txtIterasi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Angka diuji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jumlah Iterasi";
            // 
            // FormRabinMiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(742, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIterasi);
            this.Controls.Add(this.textBoxHasilRabinMiller);
            this.Controls.Add(this.buttonTesPrima);
            this.Controls.Add(this.textBoxNum);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRabinMiller";
            this.ShowIcon = false;
            this.Text = "Rabin Miller";
            this.Load += new System.EventHandler(this.FormRabinMiller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonTesPrima;
        private System.Windows.Forms.TextBox textBoxHasilRabinMiller;
        private System.Windows.Forms.TextBox txtIterasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}