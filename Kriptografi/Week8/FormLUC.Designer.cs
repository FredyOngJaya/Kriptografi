namespace Kriptografi.Week8
{
    partial class FormLUC
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
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelTotientNPPlusQPlus = new System.Windows.Forms.Label();
            this.textBoxTotientNPPlusQPlus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDPMinQMin = new System.Windows.Forms.TextBox();
            this.buttonHitungN = new System.Windows.Forms.Button();
            this.buttonHitungD = new System.Windows.Forms.Button();
            this.buttonRandomE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlRSA = new System.Windows.Forms.TabControl();
            this.tabPageKey = new System.Windows.Forms.TabPage();
            this.dataGridViewNotSortAbleEEA = new Kriptografi.DataGridViewNotSortAble();
            this.textBoxTotientNPMinQMin = new System.Windows.Forms.TextBox();
            this.textBoxTotientNPMinQPlus = new System.Windows.Forms.TextBox();
            this.labelTotientNPMinQMin = new System.Windows.Forms.Label();
            this.textBoxTotientNPPlusQMin = new System.Windows.Forms.TextBox();
            this.labelTotientNPMinQPlus = new System.Windows.Forms.Label();
            this.labelTotientNPPlusQMin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDPMinQPlus = new System.Windows.Forms.TextBox();
            this.textBoxDPPlusQMin = new System.Windows.Forms.TextBox();
            this.textBoxDPPlusQPlus = new System.Windows.Forms.TextBox();
            this.tabPageEnkripsi = new System.Windows.Forms.TabPage();
            this.dataGridViewProsesEnkripsi = new Kriptografi.DataGridViewNotSortAble();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.textBoxEnkripsiPlainText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDekripsiPlainText = new System.Windows.Forms.TextBox();
            this.buttonDekripsi = new System.Windows.Forms.Button();
            this.dataGridViewProsesDekripsi = new Kriptografi.DataGridViewNotSortAble();
            this.checkBoxShowEnkripsiDetail = new System.Windows.Forms.CheckBox();
            this.checkBoxShowDekripsiDetail = new System.Windows.Forms.CheckBox();
            this.tabControlRSA.SuspendLayout();
            this.tabPageKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleEEA)).BeginInit();
            this.tabPageEnkripsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(102, 6);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 25);
            this.textBoxP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Q";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(102, 37);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(200, 25);
            this.textBoxQ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "N";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(102, 68);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(200, 25);
            this.textBoxN.TabIndex = 4;
            // 
            // labelTotientNPPlusQPlus
            // 
            this.labelTotientNPPlusQPlus.AutoSize = true;
            this.labelTotientNPPlusQPlus.Location = new System.Drawing.Point(6, 133);
            this.labelTotientNPPlusQPlus.Name = "labelTotientNPPlusQPlus";
            this.labelTotientNPPlusQPlus.Size = new System.Drawing.Size(44, 18);
            this.labelTotientNPPlusQPlus.TabIndex = 0;
            this.labelTotientNPPlusQPlus.Text = "totient";
            // 
            // textBoxTotientNPPlusQPlus
            // 
            this.textBoxTotientNPPlusQPlus.Location = new System.Drawing.Point(102, 130);
            this.textBoxTotientNPPlusQPlus.Name = "textBoxTotientNPPlusQPlus";
            this.textBoxTotientNPPlusQPlus.ReadOnly = true;
            this.textBoxTotientNPPlusQPlus.Size = new System.Drawing.Size(200, 25);
            this.textBoxTotientNPPlusQPlus.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "E";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(102, 99);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(200, 25);
            this.textBoxE.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "D";
            // 
            // textBoxDPMinQMin
            // 
            this.textBoxDPMinQMin.Location = new System.Drawing.Point(368, 223);
            this.textBoxDPMinQMin.Name = "textBoxDPMinQMin";
            this.textBoxDPMinQMin.ReadOnly = true;
            this.textBoxDPMinQMin.Size = new System.Drawing.Size(200, 25);
            this.textBoxDPMinQMin.TabIndex = 8;
            // 
            // buttonHitungN
            // 
            this.buttonHitungN.Location = new System.Drawing.Point(308, 37);
            this.buttonHitungN.Name = "buttonHitungN";
            this.buttonHitungN.Size = new System.Drawing.Size(156, 25);
            this.buttonHitungN.TabIndex = 3;
            this.buttonHitungN.Text = "Hitung N dan Totient N";
            this.buttonHitungN.UseVisualStyleBackColor = true;
            this.buttonHitungN.Click += new System.EventHandler(this.buttonHitungN_Click);
            // 
            // buttonHitungD
            // 
            this.buttonHitungD.Location = new System.Drawing.Point(403, 99);
            this.buttonHitungD.Name = "buttonHitungD";
            this.buttonHitungD.Size = new System.Drawing.Size(89, 25);
            this.buttonHitungD.TabIndex = 9;
            this.buttonHitungD.Text = "Hitung D";
            this.buttonHitungD.UseVisualStyleBackColor = true;
            this.buttonHitungD.Click += new System.EventHandler(this.buttonHitungD_Click);
            // 
            // buttonRandomE
            // 
            this.buttonRandomE.Location = new System.Drawing.Point(308, 99);
            this.buttonRandomE.Name = "buttonRandomE";
            this.buttonRandomE.Size = new System.Drawing.Size(89, 25);
            this.buttonRandomE.TabIndex = 7;
            this.buttonRandomE.Text = "Random E";
            this.buttonRandomE.UseVisualStyleBackColor = true;
            this.buttonRandomE.Click += new System.EventHandler(this.buttonRandomE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Publikasikan N dan E sebagai kunci publik, sedangkan P, Q ,dan D sebagai kunci pr" +
                "ivat";
            // 
            // tabControlRSA
            // 
            this.tabControlRSA.Controls.Add(this.tabPageKey);
            this.tabControlRSA.Controls.Add(this.tabPageEnkripsi);
            this.tabControlRSA.Controls.Add(this.tabPage3);
            this.tabControlRSA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRSA.Location = new System.Drawing.Point(0, 0);
            this.tabControlRSA.Name = "tabControlRSA";
            this.tabControlRSA.SelectedIndex = 0;
            this.tabControlRSA.Size = new System.Drawing.Size(952, 506);
            this.tabControlRSA.TabIndex = 11;
            // 
            // tabPageKey
            // 
            this.tabPageKey.Controls.Add(this.dataGridViewNotSortAbleEEA);
            this.tabPageKey.Controls.Add(this.textBoxP);
            this.tabPageKey.Controls.Add(this.label6);
            this.tabPageKey.Controls.Add(this.label1);
            this.tabPageKey.Controls.Add(this.buttonRandomE);
            this.tabPageKey.Controls.Add(this.label2);
            this.tabPageKey.Controls.Add(this.buttonHitungD);
            this.tabPageKey.Controls.Add(this.textBoxQ);
            this.tabPageKey.Controls.Add(this.buttonHitungN);
            this.tabPageKey.Controls.Add(this.label4);
            this.tabPageKey.Controls.Add(this.textBoxTotientNPMinQMin);
            this.tabPageKey.Controls.Add(this.textBoxTotientNPMinQPlus);
            this.tabPageKey.Controls.Add(this.labelTotientNPMinQMin);
            this.tabPageKey.Controls.Add(this.textBoxTotientNPPlusQMin);
            this.tabPageKey.Controls.Add(this.labelTotientNPMinQPlus);
            this.tabPageKey.Controls.Add(this.textBoxTotientNPPlusQPlus);
            this.tabPageKey.Controls.Add(this.labelTotientNPPlusQMin);
            this.tabPageKey.Controls.Add(this.textBoxE);
            this.tabPageKey.Controls.Add(this.labelTotientNPPlusQPlus);
            this.tabPageKey.Controls.Add(this.label14);
            this.tabPageKey.Controls.Add(this.label13);
            this.tabPageKey.Controls.Add(this.label12);
            this.tabPageKey.Controls.Add(this.label5);
            this.tabPageKey.Controls.Add(this.textBoxN);
            this.tabPageKey.Controls.Add(this.textBoxDPMinQPlus);
            this.tabPageKey.Controls.Add(this.textBoxDPPlusQMin);
            this.tabPageKey.Controls.Add(this.textBoxDPPlusQPlus);
            this.tabPageKey.Controls.Add(this.textBoxDPMinQMin);
            this.tabPageKey.Controls.Add(this.label3);
            this.tabPageKey.Location = new System.Drawing.Point(4, 27);
            this.tabPageKey.Name = "tabPageKey";
            this.tabPageKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKey.Size = new System.Drawing.Size(944, 475);
            this.tabPageKey.TabIndex = 0;
            this.tabPageKey.Text = "Key";
            this.tabPageKey.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNotSortAbleEEA
            // 
            this.dataGridViewNotSortAbleEEA.AllowUserToAddRows = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToDeleteRows = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToOrderColumns = true;
            this.dataGridViewNotSortAbleEEA.AllowUserToResizeColumns = false;
            this.dataGridViewNotSortAbleEEA.AllowUserToResizeRows = false;
            this.dataGridViewNotSortAbleEEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotSortAbleEEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotSortAbleEEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotSortAbleEEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSortAbleEEA.Location = new System.Drawing.Point(6, 272);
            this.dataGridViewNotSortAbleEEA.Name = "dataGridViewNotSortAbleEEA";
            this.dataGridViewNotSortAbleEEA.ReadOnly = true;
            this.dataGridViewNotSortAbleEEA.RowHeadersVisible = false;
            this.dataGridViewNotSortAbleEEA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotSortAbleEEA.Size = new System.Drawing.Size(930, 195);
            this.dataGridViewNotSortAbleEEA.TabIndex = 29;
            // 
            // textBoxTotientNPMinQMin
            // 
            this.textBoxTotientNPMinQMin.Location = new System.Drawing.Point(102, 223);
            this.textBoxTotientNPMinQMin.Name = "textBoxTotientNPMinQMin";
            this.textBoxTotientNPMinQMin.ReadOnly = true;
            this.textBoxTotientNPMinQMin.Size = new System.Drawing.Size(200, 25);
            this.textBoxTotientNPMinQMin.TabIndex = 5;
            // 
            // textBoxTotientNPMinQPlus
            // 
            this.textBoxTotientNPMinQPlus.Location = new System.Drawing.Point(102, 192);
            this.textBoxTotientNPMinQPlus.Name = "textBoxTotientNPMinQPlus";
            this.textBoxTotientNPMinQPlus.ReadOnly = true;
            this.textBoxTotientNPMinQPlus.Size = new System.Drawing.Size(200, 25);
            this.textBoxTotientNPMinQPlus.TabIndex = 5;
            // 
            // labelTotientNPMinQMin
            // 
            this.labelTotientNPMinQMin.AutoSize = true;
            this.labelTotientNPMinQMin.Location = new System.Drawing.Point(6, 226);
            this.labelTotientNPMinQMin.Name = "labelTotientNPMinQMin";
            this.labelTotientNPMinQMin.Size = new System.Drawing.Size(44, 18);
            this.labelTotientNPMinQMin.TabIndex = 0;
            this.labelTotientNPMinQMin.Text = "totient";
            // 
            // textBoxTotientNPPlusQMin
            // 
            this.textBoxTotientNPPlusQMin.Location = new System.Drawing.Point(102, 161);
            this.textBoxTotientNPPlusQMin.Name = "textBoxTotientNPPlusQMin";
            this.textBoxTotientNPPlusQMin.ReadOnly = true;
            this.textBoxTotientNPPlusQMin.Size = new System.Drawing.Size(200, 25);
            this.textBoxTotientNPPlusQMin.TabIndex = 5;
            // 
            // labelTotientNPMinQPlus
            // 
            this.labelTotientNPMinQPlus.AutoSize = true;
            this.labelTotientNPMinQPlus.Location = new System.Drawing.Point(6, 195);
            this.labelTotientNPMinQPlus.Name = "labelTotientNPMinQPlus";
            this.labelTotientNPMinQPlus.Size = new System.Drawing.Size(44, 18);
            this.labelTotientNPMinQPlus.TabIndex = 0;
            this.labelTotientNPMinQPlus.Text = "totient";
            // 
            // labelTotientNPPlusQMin
            // 
            this.labelTotientNPPlusQMin.AutoSize = true;
            this.labelTotientNPPlusQMin.Location = new System.Drawing.Point(6, 164);
            this.labelTotientNPPlusQMin.Name = "labelTotientNPPlusQMin";
            this.labelTotientNPPlusQMin.Size = new System.Drawing.Size(44, 18);
            this.labelTotientNPPlusQMin.TabIndex = 0;
            this.labelTotientNPPlusQMin.Text = "totient";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(345, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "D";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "D";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "D";
            // 
            // textBoxDPMinQPlus
            // 
            this.textBoxDPMinQPlus.Location = new System.Drawing.Point(368, 192);
            this.textBoxDPMinQPlus.Name = "textBoxDPMinQPlus";
            this.textBoxDPMinQPlus.ReadOnly = true;
            this.textBoxDPMinQPlus.Size = new System.Drawing.Size(200, 25);
            this.textBoxDPMinQPlus.TabIndex = 8;
            // 
            // textBoxDPPlusQMin
            // 
            this.textBoxDPPlusQMin.Location = new System.Drawing.Point(368, 161);
            this.textBoxDPPlusQMin.Name = "textBoxDPPlusQMin";
            this.textBoxDPPlusQMin.ReadOnly = true;
            this.textBoxDPPlusQMin.Size = new System.Drawing.Size(200, 25);
            this.textBoxDPPlusQMin.TabIndex = 8;
            // 
            // textBoxDPPlusQPlus
            // 
            this.textBoxDPPlusQPlus.Location = new System.Drawing.Point(368, 130);
            this.textBoxDPPlusQPlus.Name = "textBoxDPPlusQPlus";
            this.textBoxDPPlusQPlus.ReadOnly = true;
            this.textBoxDPPlusQPlus.Size = new System.Drawing.Size(200, 25);
            this.textBoxDPPlusQPlus.TabIndex = 8;
            // 
            // tabPageEnkripsi
            // 
            this.tabPageEnkripsi.Controls.Add(this.checkBoxShowEnkripsiDetail);
            this.tabPageEnkripsi.Controls.Add(this.dataGridViewProsesEnkripsi);
            this.tabPageEnkripsi.Controls.Add(this.numericUpDownBlockSize);
            this.tabPageEnkripsi.Controls.Add(this.label8);
            this.tabPageEnkripsi.Controls.Add(this.label7);
            this.tabPageEnkripsi.Controls.Add(this.buttonEnkripsi);
            this.tabPageEnkripsi.Controls.Add(this.textBoxEnkripsiPlainText);
            this.tabPageEnkripsi.Location = new System.Drawing.Point(4, 27);
            this.tabPageEnkripsi.Name = "tabPageEnkripsi";
            this.tabPageEnkripsi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnkripsi.Size = new System.Drawing.Size(944, 475);
            this.tabPageEnkripsi.TabIndex = 1;
            this.tabPageEnkripsi.Text = "Enkripsi";
            this.tabPageEnkripsi.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProsesEnkripsi
            // 
            this.dataGridViewProsesEnkripsi.AllowUserToAddRows = false;
            this.dataGridViewProsesEnkripsi.AllowUserToDeleteRows = false;
            this.dataGridViewProsesEnkripsi.AllowUserToOrderColumns = true;
            this.dataGridViewProsesEnkripsi.AllowUserToResizeColumns = false;
            this.dataGridViewProsesEnkripsi.AllowUserToResizeRows = false;
            this.dataGridViewProsesEnkripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProsesEnkripsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProsesEnkripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProsesEnkripsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProsesEnkripsi.Location = new System.Drawing.Point(8, 45);
            this.dataGridViewProsesEnkripsi.Name = "dataGridViewProsesEnkripsi";
            this.dataGridViewProsesEnkripsi.ReadOnly = true;
            this.dataGridViewProsesEnkripsi.RowHeadersVisible = false;
            this.dataGridViewProsesEnkripsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesEnkripsi.Size = new System.Drawing.Size(927, 422);
            this.dataGridViewProsesEnkripsi.TabIndex = 27;
            // 
            // numericUpDownBlockSize
            // 
            this.numericUpDownBlockSize.Location = new System.Drawing.Point(551, 13);
            this.numericUpDownBlockSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownBlockSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBlockSize.Name = "numericUpDownBlockSize";
            this.numericUpDownBlockSize.Size = new System.Drawing.Size(34, 25);
            this.numericUpDownBlockSize.TabIndex = 24;
            this.numericUpDownBlockSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Blok size ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Plain text";
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Location = new System.Drawing.Point(320, 13);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonEnkripsi.TabIndex = 19;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // textBoxEnkripsiPlainText
            // 
            this.textBoxEnkripsiPlainText.Location = new System.Drawing.Point(109, 13);
            this.textBoxEnkripsiPlainText.Name = "textBoxEnkripsiPlainText";
            this.textBoxEnkripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxEnkripsiPlainText.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxShowDekripsiDetail);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxDekripsiPlainText);
            this.tabPage3.Controls.Add(this.buttonDekripsi);
            this.tabPage3.Controls.Add(this.dataGridViewProsesDekripsi);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 475);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Dekripsi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Plain text";
            // 
            // textBoxDekripsiPlainText
            // 
            this.textBoxDekripsiPlainText.Location = new System.Drawing.Point(98, 14);
            this.textBoxDekripsiPlainText.Name = "textBoxDekripsiPlainText";
            this.textBoxDekripsiPlainText.ReadOnly = true;
            this.textBoxDekripsiPlainText.Size = new System.Drawing.Size(204, 25);
            this.textBoxDekripsiPlainText.TabIndex = 25;
            // 
            // buttonDekripsi
            // 
            this.buttonDekripsi.Location = new System.Drawing.Point(308, 13);
            this.buttonDekripsi.Name = "buttonDekripsi";
            this.buttonDekripsi.Size = new System.Drawing.Size(110, 26);
            this.buttonDekripsi.TabIndex = 23;
            this.buttonDekripsi.Text = "Dekripsi";
            this.buttonDekripsi.UseVisualStyleBackColor = true;
            this.buttonDekripsi.Click += new System.EventHandler(this.buttonDekripsi_Click);
            // 
            // dataGridViewProsesDekripsi
            // 
            this.dataGridViewProsesDekripsi.AllowUserToAddRows = false;
            this.dataGridViewProsesDekripsi.AllowUserToDeleteRows = false;
            this.dataGridViewProsesDekripsi.AllowUserToResizeColumns = false;
            this.dataGridViewProsesDekripsi.AllowUserToResizeRows = false;
            this.dataGridViewProsesDekripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProsesDekripsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProsesDekripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProsesDekripsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProsesDekripsi.Location = new System.Drawing.Point(9, 45);
            this.dataGridViewProsesDekripsi.Name = "dataGridViewProsesDekripsi";
            this.dataGridViewProsesDekripsi.ReadOnly = true;
            this.dataGridViewProsesDekripsi.RowHeadersVisible = false;
            this.dataGridViewProsesDekripsi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProsesDekripsi.Size = new System.Drawing.Size(927, 422);
            this.dataGridViewProsesDekripsi.TabIndex = 24;
            // 
            // checkBoxShowEnkripsiDetail
            // 
            this.checkBoxShowEnkripsiDetail.AutoSize = true;
            this.checkBoxShowEnkripsiDetail.Location = new System.Drawing.Point(635, 15);
            this.checkBoxShowEnkripsiDetail.Name = "checkBoxShowEnkripsiDetail";
            this.checkBoxShowEnkripsiDetail.Size = new System.Drawing.Size(162, 22);
            this.checkBoxShowEnkripsiDetail.TabIndex = 29;
            this.checkBoxShowEnkripsiDetail.Text = "Tunjukan Proses Detail";
            this.checkBoxShowEnkripsiDetail.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowDekripsiDetail
            // 
            this.checkBoxShowDekripsiDetail.AutoSize = true;
            this.checkBoxShowDekripsiDetail.Location = new System.Drawing.Point(439, 16);
            this.checkBoxShowDekripsiDetail.Name = "checkBoxShowDekripsiDetail";
            this.checkBoxShowDekripsiDetail.Size = new System.Drawing.Size(162, 22);
            this.checkBoxShowDekripsiDetail.TabIndex = 30;
            this.checkBoxShowDekripsiDetail.Text = "Tunjukan Proses Detail";
            this.checkBoxShowDekripsiDetail.UseVisualStyleBackColor = true;
            // 
            // FormLUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.tabControlRSA);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormLUC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUC";
            this.Load += new System.EventHandler(this.FormRSA_Load);
            this.tabControlRSA.ResumeLayout(false);
            this.tabPageKey.ResumeLayout(false);
            this.tabPageKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSortAbleEEA)).EndInit();
            this.tabPageEnkripsi.ResumeLayout(false);
            this.tabPageEnkripsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesEnkripsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProsesDekripsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelTotientNPPlusQPlus;
        private System.Windows.Forms.TextBox textBoxTotientNPPlusQPlus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDPMinQMin;
        private System.Windows.Forms.Button buttonHitungN;
        private System.Windows.Forms.Button buttonHitungD;
        private System.Windows.Forms.Button buttonRandomE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControlRSA;
        private System.Windows.Forms.TabPage tabPageKey;
        private System.Windows.Forms.TabPage tabPageEnkripsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.TextBox textBoxEnkripsiPlainText;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockSize;
        private System.Windows.Forms.Label label8;
        private DataGridViewNotSortAble dataGridViewProsesEnkripsi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDekripsiPlainText;
        private System.Windows.Forms.Button buttonDekripsi;
        private DataGridViewNotSortAble dataGridViewProsesDekripsi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDPMinQPlus;
        private System.Windows.Forms.TextBox textBoxDPPlusQMin;
        private System.Windows.Forms.TextBox textBoxDPPlusQPlus;
        private System.Windows.Forms.TextBox textBoxTotientNPMinQMin;
        private System.Windows.Forms.TextBox textBoxTotientNPMinQPlus;
        private System.Windows.Forms.Label labelTotientNPMinQMin;
        private System.Windows.Forms.TextBox textBoxTotientNPPlusQMin;
        private System.Windows.Forms.Label labelTotientNPMinQPlus;
        private System.Windows.Forms.Label labelTotientNPPlusQMin;
        private DataGridViewNotSortAble dataGridViewNotSortAbleEEA;
        private System.Windows.Forms.CheckBox checkBoxShowEnkripsiDetail;
        private System.Windows.Forms.CheckBox checkBoxShowDekripsiDetail;
    }
}