
namespace DovizOffice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.BtnDolarAlis = new System.Windows.Forms.Button();
            this.BtnDolarSatis = new System.Windows.Forms.Button();
            this.BtnEuroAlis = new System.Windows.Forms.Button();
            this.BtnEuroSatis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paraTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dovizOfficeDataSet = new DovizOffice.DovizOfficeDataSet();
            this.tblKasaTableAdapter = new DovizOffice.DovizOfficeDataSetTableAdapters.TblKasaTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizOfficeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarAlis.ForeColor = System.Drawing.Color.White;
            this.LblDolarAlis.Location = new System.Drawing.Point(137, 50);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(23, 25);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            this.LblDolarAlis.TextChanged += new System.EventHandler(this.LblDolarAlis_TextChanged);
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSatis.ForeColor = System.Drawing.Color.White;
            this.LblDolarSatis.Location = new System.Drawing.Point(137, 97);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(23, 25);
            this.LblDolarSatis.TabIndex = 3;
            this.LblDolarSatis.Text = "0";
            this.LblDolarSatis.TextChanged += new System.EventHandler(this.LblDolarSatis_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış:";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSatis.ForeColor = System.Drawing.Color.White;
            this.LblEuroSatis.Location = new System.Drawing.Point(137, 217);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(23, 25);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            this.LblEuroSatis.TextChanged += new System.EventHandler(this.LblEuroSatis_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış:";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroAlis.ForeColor = System.Drawing.Color.White;
            this.LblEuroAlis.Location = new System.Drawing.Point(137, 170);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(23, 25);
            this.LblEuroAlis.TabIndex = 5;
            this.LblEuroAlis.Text = "0";
            this.LblEuroAlis.TextChanged += new System.EventHandler(this.LblEuroAlis_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kur:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 240);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSatisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSatisYap.Location = new System.Drawing.Point(90, 178);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(258, 34);
            this.BtnSatisYap.TabIndex = 14;
            this.BtnSatisYap.Text = "İşlem Yap";
            this.BtnSatisYap.UseVisualStyleBackColor = false;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(90, 128);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(258, 30);
            this.TxtTutar.TabIndex = 96;
            this.TxtTutar.TextChanged += new System.EventHandler(this.TxtTutar_TextChanged);
            this.TxtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTutar_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tutar:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(90, 78);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(258, 30);
            this.TxtMiktar.TabIndex = 95;
            this.TxtMiktar.TextChanged += new System.EventHandler(this.TxtMiktar_TextChanged);
            this.TxtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMiktar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Miktar:";
            // 
            // TxtKur
            // 
            this.TxtKur.Enabled = false;
            this.TxtKur.Location = new System.Drawing.Point(90, 29);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(258, 30);
            this.TxtKur.TabIndex = 9;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // BtnDolarAlis
            // 
            this.BtnDolarAlis.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDolarAlis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDolarAlis.Location = new System.Drawing.Point(218, 45);
            this.BtnDolarAlis.Name = "BtnDolarAlis";
            this.BtnDolarAlis.Size = new System.Drawing.Size(35, 34);
            this.BtnDolarAlis.TabIndex = 10;
            this.BtnDolarAlis.Text = "...";
            this.BtnDolarAlis.UseVisualStyleBackColor = false;
            this.BtnDolarAlis.Click += new System.EventHandler(this.BtnDolarAlis_Click);
            // 
            // BtnDolarSatis
            // 
            this.BtnDolarSatis.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDolarSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDolarSatis.Location = new System.Drawing.Point(218, 92);
            this.BtnDolarSatis.Name = "BtnDolarSatis";
            this.BtnDolarSatis.Size = new System.Drawing.Size(35, 34);
            this.BtnDolarSatis.TabIndex = 11;
            this.BtnDolarSatis.Text = "...";
            this.BtnDolarSatis.UseVisualStyleBackColor = false;
            this.BtnDolarSatis.Click += new System.EventHandler(this.BtnDolarSatis_Click);
            // 
            // BtnEuroAlis
            // 
            this.BtnEuroAlis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEuroAlis.Location = new System.Drawing.Point(218, 165);
            this.BtnEuroAlis.Name = "BtnEuroAlis";
            this.BtnEuroAlis.Size = new System.Drawing.Size(35, 34);
            this.BtnEuroAlis.TabIndex = 12;
            this.BtnEuroAlis.Text = "...";
            this.BtnEuroAlis.UseVisualStyleBackColor = true;
            this.BtnEuroAlis.Click += new System.EventHandler(this.BtnEuroAlis_Click);
            // 
            // BtnEuroSatis
            // 
            this.BtnEuroSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEuroSatis.Location = new System.Drawing.Point(218, 212);
            this.BtnEuroSatis.Name = "BtnEuroSatis";
            this.BtnEuroSatis.Size = new System.Drawing.Size(35, 34);
            this.BtnEuroSatis.TabIndex = 13;
            this.BtnEuroSatis.Text = "...";
            this.BtnEuroSatis.UseVisualStyleBackColor = true;
            this.BtnEuroSatis.Click += new System.EventHandler(this.BtnEuroSatis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paraTuruDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKasaBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(510, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 127);
            this.dataGridView1.TabIndex = 18;
            // 
            // paraTuruDataGridViewTextBoxColumn
            // 
            this.paraTuruDataGridViewTextBoxColumn.DataPropertyName = "ParaTuru";
            this.paraTuruDataGridViewTextBoxColumn.HeaderText = "Döviz Adı";
            this.paraTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paraTuruDataGridViewTextBoxColumn.Name = "paraTuruDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // tblKasaBindingSource
            // 
            this.tblKasaBindingSource.DataMember = "TblKasa";
            this.tblKasaBindingSource.DataSource = this.dovizOfficeDataSet;
            // 
            // dovizOfficeDataSet
            // 
            this.dovizOfficeDataSet.DataSetName = "DovizOfficeDataSet";
            this.dovizOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKasaTableAdapter
            // 
            this.tblKasaTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEuroSatis);
            this.Controls.Add(this.BtnEuroAlis);
            this.Controls.Add(this.BtnDolarSatis);
            this.Controls.Add(this.BtnDolarAlis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizOfficeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDolarAlis;
        private System.Windows.Forms.Button BtnDolarSatis;
        private System.Windows.Forms.Button BtnEuroAlis;
        private System.Windows.Forms.Button BtnEuroSatis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DovizOfficeDataSet dovizOfficeDataSet;
        private System.Windows.Forms.BindingSource tblKasaBindingSource;
        private DovizOfficeDataSetTableAdapters.TblKasaTableAdapter tblKasaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}

