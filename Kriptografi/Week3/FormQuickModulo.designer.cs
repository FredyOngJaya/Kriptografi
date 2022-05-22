namespace Kriptografi.Week3
{
    partial class FormQuickModulo
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
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDivisor = new System.Windows.Forms.NumericUpDown();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisor)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(15, 15);
            this.numericUpDownNumber.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(154, 29);
            this.numericUpDownNumber.TabIndex = 0;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            63738,
            0,
            0,
            0});
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(204, 15);
            this.numericUpDownPower.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPower.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(154, 29);
            this.numericUpDownPower.TabIndex = 1;
            this.numericUpDownPower.Value = new decimal(new int[] {
            45638,
            0,
            0,
            0});
            // 
            // numericUpDownDivisor
            // 
            this.numericUpDownDivisor.Location = new System.Drawing.Point(395, 15);
            this.numericUpDownDivisor.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDivisor.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownDivisor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDivisor.Name = "numericUpDownDivisor";
            this.numericUpDownDivisor.Size = new System.Drawing.Size(154, 29);
            this.numericUpDownDivisor.TabIndex = 2;
            this.numericUpDownDivisor.Value = new decimal(new int[] {
            65537,
            0,
            0,
            0});
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 53);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(153, 29);
            this.textBoxResult.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(15, 91);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(129, 28);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "^";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "%";
            // 
            // FormQuickModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(618, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.numericUpDownDivisor);
            this.Controls.Add(this.numericUpDownPower);
            this.Controls.Add(this.numericUpDownNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuickModulo";
            this.ShowIcon = false;
            this.Text = "Quick Modulo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.NumericUpDown numericUpDownDivisor;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}