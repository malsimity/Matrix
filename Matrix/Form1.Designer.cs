namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._tbMA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbNA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._dgvA = new System.Windows.Forms.DataGridView();
            this._tbMB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbNB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._dgvB = new System.Windows.Forms.DataGridView();
            this._butRandom = new System.Windows.Forms.Button();
            this._cbOp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._labOp = new System.Windows.Forms.Label();
            this._butConf = new System.Windows.Forms.Button();
            this._dgvC = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.saveC = new System.Windows.Forms.Button();
            this._butCalc = new System.Windows.Forms.Button();
            this._tbMC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._tbNC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._tbTimeC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // _tbMA
            // 
            this._tbMA.Location = new System.Drawing.Point(101, 39);
            this._tbMA.Name = "_tbMA";
            this._tbMA.Size = new System.Drawing.Size(60, 20);
            this._tbMA.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // _tbNA
            // 
            this._tbNA.Location = new System.Drawing.Point(15, 40);
            this._tbNA.Name = "_tbNA";
            this._tbNA.Size = new System.Drawing.Size(60, 20);
            this._tbNA.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размерность матрицы А";
            // 
            // _dgvA
            // 
            this._dgvA.AllowUserToAddRows = false;
            this._dgvA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._dgvA.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this._dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvA.ColumnHeadersVisible = false;
            this._dgvA.Location = new System.Drawing.Point(15, 69);
            this._dgvA.Name = "_dgvA";
            this._dgvA.RowHeadersVisible = false;
            this._dgvA.Size = new System.Drawing.Size(200, 200);
            this._dgvA.TabIndex = 5;
            // 
            // _tbMB
            // 
            this._tbMB.Location = new System.Drawing.Point(398, 42);
            this._tbMB.Name = "_tbMB";
            this._tbMB.Size = new System.Drawing.Size(60, 20);
            this._tbMB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "X";
            // 
            // _tbNB
            // 
            this._tbNB.Location = new System.Drawing.Point(309, 43);
            this._tbNB.Name = "_tbNB";
            this._tbNB.Size = new System.Drawing.Size(60, 20);
            this._tbNB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Размерность матрицы B";
            // 
            // _dgvB
            // 
            this._dgvB.AllowUserToAddRows = false;
            this._dgvB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._dgvB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this._dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvB.ColumnHeadersVisible = false;
            this._dgvB.Location = new System.Drawing.Point(258, 69);
            this._dgvB.Name = "_dgvB";
            this._dgvB.RowHeadersVisible = false;
            this._dgvB.Size = new System.Drawing.Size(200, 200);
            this._dgvB.TabIndex = 10;
            // 
            // _butRandom
            // 
            this._butRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._butRandom.Location = new System.Drawing.Point(15, 286);
            this._butRandom.Name = "_butRandom";
            this._butRandom.Size = new System.Drawing.Size(106, 57);
            this._butRandom.TabIndex = 15;
            this._butRandom.Text = "Сгенерировать значения матриц";
            this._butRandom.UseVisualStyleBackColor = true;
            this._butRandom.Click += new System.EventHandler(this._butRandom_Click);
            // 
            // _cbOp
            // 
            this._cbOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbOp.FormattingEnabled = true;
            this._cbOp.Items.AddRange(new object[] {
            "Сложение",
            "Произведение"});
            this._cbOp.Location = new System.Drawing.Point(127, 305);
            this._cbOp.Name = "_cbOp";
            this._cbOp.Size = new System.Drawing.Size(121, 21);
            this._cbOp.TabIndex = 16;
            this._cbOp.SelectedIndexChanged += new System.EventHandler(this._cbOp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Выбор оперции";
            // 
            // _labOp
            // 
            this._labOp.AutoSize = true;
            this._labOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labOp.Location = new System.Drawing.Point(221, 140);
            this._labOp.Name = "_labOp";
            this._labOp.Size = new System.Drawing.Size(31, 31);
            this._labOp.TabIndex = 18;
            this._labOp.Text = "+";
            // 
            // _butConf
            // 
            this._butConf.Location = new System.Drawing.Point(171, 12);
            this._butConf.Name = "_butConf";
            this._butConf.Size = new System.Drawing.Size(129, 51);
            this._butConf.TabIndex = 19;
            this._butConf.Text = "Подтверждение размерностей матриц";
            this._butConf.UseVisualStyleBackColor = true;
            this._butConf.Click += new System.EventHandler(this._butConf_Click);
            // 
            // _dgvC
            // 
            this._dgvC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._dgvC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this._dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvC.ColumnHeadersVisible = false;
            this._dgvC.Location = new System.Drawing.Point(501, 69);
            this._dgvC.Name = "_dgvC";
            this._dgvC.ReadOnly = true;
            this._dgvC.RowHeadersVisible = false;
            this._dgvC.Size = new System.Drawing.Size(200, 200);
            this._dgvC.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(464, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "=";
            // 
            // saveC
            // 
            this.saveC.Location = new System.Drawing.Point(498, 286);
            this.saveC.Name = "saveC";
            this.saveC.Size = new System.Drawing.Size(102, 47);
            this.saveC.TabIndex = 22;
            this.saveC.Text = "Сохранить матрицу";
            this.saveC.UseVisualStyleBackColor = true;
            this.saveC.Click += new System.EventHandler(this.saveC_Click);
            // 
            // _butCalc
            // 
            this._butCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._butCalc.Location = new System.Drawing.Point(309, 286);
            this._butCalc.Name = "_butCalc";
            this._butCalc.Size = new System.Drawing.Size(119, 47);
            this._butCalc.TabIndex = 23;
            this._butCalc.Text = "Вычислить матрицу С";
            this._butCalc.UseVisualStyleBackColor = true;
            this._butCalc.Click += new System.EventHandler(this._butCalc_Click);
            // 
            // _tbMC
            // 
            this._tbMC.Location = new System.Drawing.Point(612, 40);
            this._tbMC.Name = "_tbMC";
            this._tbMC.ReadOnly = true;
            this._tbMC.Size = new System.Drawing.Size(60, 20);
            this._tbMC.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "X";
            // 
            // _tbNC
            // 
            this._tbNC.Location = new System.Drawing.Point(524, 40);
            this._tbNC.Name = "_tbNC";
            this._tbNC.ReadOnly = true;
            this._tbNC.Size = new System.Drawing.Size(60, 20);
            this._tbNC.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Размерность матрицы C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Время расчёта (в мс)";
            // 
            // _tbTimeC
            // 
            this._tbTimeC.Location = new System.Drawing.Point(612, 313);
            this._tbTimeC.Name = "_tbTimeC";
            this._tbTimeC.ReadOnly = true;
            this._tbTimeC.Size = new System.Drawing.Size(112, 20);
            this._tbTimeC.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 355);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._tbTimeC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._tbMC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._tbNC);
            this.Controls.Add(this._butCalc);
            this.Controls.Add(this.saveC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._dgvC);
            this.Controls.Add(this._butConf);
            this.Controls.Add(this._labOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cbOp);
            this.Controls.Add(this._butRandom);
            this.Controls.Add(this._tbMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbNB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dgvB);
            this.Controls.Add(this._tbMA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbNA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dgvA);
            this.Name = "Form1";
            this.Text = "Широков М.О. гр. 3-47 лаб. №2";
            ((System.ComponentModel.ISupportInitialize)(this._dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _dgvA;
        private System.Windows.Forms.TextBox _tbMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbNB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView _dgvB;
        private System.Windows.Forms.Button _butRandom;
        private System.Windows.Forms.ComboBox _cbOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _labOp;
        private System.Windows.Forms.Button _butConf;
        private System.Windows.Forms.DataGridView _dgvC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveC;
        private System.Windows.Forms.Button _butCalc;
        private System.Windows.Forms.TextBox _tbMC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _tbNC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _tbTimeC;
    }
}

