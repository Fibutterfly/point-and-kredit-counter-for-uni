namespace point_counter_for_uni
{
    partial class Form_újtárgy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgw_subchose = new point_counter_for_uni.default_dataGridView();
            this.tárgynévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tárgykódDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elégségesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.közepesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aláírásosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectchooserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_kód = new point_counter_for_uni.second_textbox();
            this.tb_név = new point_counter_for_uni.second_textbox();
            this.second_label1 = new point_counter_for_uni.second_label();
            this.second_label2 = new point_counter_for_uni.second_label();
            this.but_nope = new point_counter_for_uni.second_button();
            this.but_újlistaelem = new point_counter_for_uni.second_button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.second_label3 = new point_counter_for_uni.second_label();
            this.second_label4 = new point_counter_for_uni.second_label();
            this.tB_year = new point_counter_for_uni.second_textbox();
            this.cB_félév = new point_counter_for_uni.second_comboBox();
            this.second_button1 = new point_counter_for_uni.second_button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_subchose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectchooserBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgw_subchose, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgw_subchose
            // 
            this.dgw_subchose.AllowUserToAddRows = false;
            this.dgw_subchose.AllowUserToDeleteRows = false;
            this.dgw_subchose.AutoGenerateColumns = false;
            this.dgw_subchose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_subchose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_subchose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_subchose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tárgynévDataGridViewTextBoxColumn,
            this.uniDataGridViewTextBoxColumn,
            this.tárgykódDataGridViewTextBoxColumn,
            this.elégségesDataGridViewTextBoxColumn,
            this.közepesDataGridViewTextBoxColumn,
            this.jóDataGridViewTextBoxColumn,
            this.jelesDataGridViewTextBoxColumn,
            this.aláírásosDataGridViewTextBoxColumn});
            this.dgw_subchose.DataSource = this.subjectchooserBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_subchose.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_subchose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_subchose.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.dgw_subchose.Location = new System.Drawing.Point(3, 3);
            this.dgw_subchose.Name = "dgw_subchose";
            this.dgw_subchose.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_subchose.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dgw_subchose.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw_subchose.Size = new System.Drawing.Size(845, 354);
            this.dgw_subchose.TabIndex = 0;
            // 
            // tárgynévDataGridViewTextBoxColumn
            // 
            this.tárgynévDataGridViewTextBoxColumn.DataPropertyName = "Tárgy_név";
            this.tárgynévDataGridViewTextBoxColumn.HeaderText = "Tárgy_név";
            this.tárgynévDataGridViewTextBoxColumn.Name = "tárgynévDataGridViewTextBoxColumn";
            this.tárgynévDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniDataGridViewTextBoxColumn
            // 
            this.uniDataGridViewTextBoxColumn.DataPropertyName = "Uni";
            this.uniDataGridViewTextBoxColumn.HeaderText = "Uni";
            this.uniDataGridViewTextBoxColumn.Name = "uniDataGridViewTextBoxColumn";
            this.uniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tárgykódDataGridViewTextBoxColumn
            // 
            this.tárgykódDataGridViewTextBoxColumn.DataPropertyName = "Tárgy_kód";
            this.tárgykódDataGridViewTextBoxColumn.HeaderText = "Tárgy_kód";
            this.tárgykódDataGridViewTextBoxColumn.Name = "tárgykódDataGridViewTextBoxColumn";
            this.tárgykódDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elégségesDataGridViewTextBoxColumn
            // 
            this.elégségesDataGridViewTextBoxColumn.DataPropertyName = "Elégséges";
            this.elégségesDataGridViewTextBoxColumn.HeaderText = "Elégséges";
            this.elégségesDataGridViewTextBoxColumn.Name = "elégségesDataGridViewTextBoxColumn";
            this.elégségesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // közepesDataGridViewTextBoxColumn
            // 
            this.közepesDataGridViewTextBoxColumn.DataPropertyName = "Közepes";
            this.közepesDataGridViewTextBoxColumn.HeaderText = "Közepes";
            this.közepesDataGridViewTextBoxColumn.Name = "közepesDataGridViewTextBoxColumn";
            this.közepesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jóDataGridViewTextBoxColumn
            // 
            this.jóDataGridViewTextBoxColumn.DataPropertyName = "Jó";
            this.jóDataGridViewTextBoxColumn.HeaderText = "Jó";
            this.jóDataGridViewTextBoxColumn.Name = "jóDataGridViewTextBoxColumn";
            this.jóDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jelesDataGridViewTextBoxColumn
            // 
            this.jelesDataGridViewTextBoxColumn.DataPropertyName = "Jeles";
            this.jelesDataGridViewTextBoxColumn.HeaderText = "Jeles";
            this.jelesDataGridViewTextBoxColumn.Name = "jelesDataGridViewTextBoxColumn";
            this.jelesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aláírásosDataGridViewTextBoxColumn
            // 
            this.aláírásosDataGridViewTextBoxColumn.DataPropertyName = "Aláírásos";
            this.aláírásosDataGridViewTextBoxColumn.HeaderText = "Aláírásos";
            this.aláírásosDataGridViewTextBoxColumn.Name = "aláírásosDataGridViewTextBoxColumn";
            this.aláírásosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectchooserBindingSource
            // 
            this.subjectchooserBindingSource.DataSource = typeof(point_counter_for_uni.subject_chooser);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.but_nope, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.but_újlistaelem, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 84);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(146, 78);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.tb_kód, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tb_név, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.second_label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.second_label2, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(130, 72);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tb_kód
            // 
            this.tb_kód.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.tb_kód.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_kód.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_kód.Location = new System.Drawing.Point(55, 3);
            this.tb_kód.Name = "tb_kód";
            this.tb_kód.Size = new System.Drawing.Size(72, 20);
            this.tb_kód.TabIndex = 0;
            // 
            // tb_név
            // 
            this.tb_név.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.tb_név.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_név.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_név.Location = new System.Drawing.Point(55, 39);
            this.tb_név.Name = "tb_név";
            this.tb_név.Size = new System.Drawing.Size(72, 20);
            this.tb_név.TabIndex = 1;
            // 
            // second_label1
            // 
            this.second_label1.AutoSize = true;
            this.second_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label1.Location = new System.Drawing.Point(3, 0);
            this.second_label1.Name = "second_label1";
            this.second_label1.Size = new System.Drawing.Size(26, 13);
            this.second_label1.TabIndex = 2;
            this.second_label1.Text = "Kód";
            // 
            // second_label2
            // 
            this.second_label2.AutoSize = true;
            this.second_label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label2.Location = new System.Drawing.Point(3, 36);
            this.second_label2.Name = "second_label2";
            this.second_label2.Size = new System.Drawing.Size(27, 13);
            this.second_label2.TabIndex = 3;
            this.second_label2.Text = "Név";
            // 
            // but_nope
            // 
            this.but_nope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.but_nope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_nope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_nope.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_nope.Location = new System.Drawing.Point(676, 3);
            this.but_nope.Name = "but_nope";
            this.but_nope.Size = new System.Drawing.Size(146, 78);
            this.but_nope.TabIndex = 2;
            this.but_nope.Text = "Megszakítás";
            this.but_nope.UseVisualStyleBackColor = false;
            // 
            // but_újlistaelem
            // 
            this.but_újlistaelem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.but_újlistaelem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_újlistaelem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_újlistaelem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_újlistaelem.Location = new System.Drawing.Point(457, 3);
            this.but_újlistaelem.Name = "but_újlistaelem";
            this.but_újlistaelem.Size = new System.Drawing.Size(146, 78);
            this.but_újlistaelem.TabIndex = 1;
            this.but_újlistaelem.Text = "Újtárgy a listába";
            this.but_újlistaelem.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.second_button1, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(238, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(146, 78);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.second_label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.second_label4, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tB_year, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.cB_félév, 0, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(67, 72);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // second_label3
            // 
            this.second_label3.AutoSize = true;
            this.second_label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label3.Location = new System.Drawing.Point(3, 0);
            this.second_label3.Name = "second_label3";
            this.second_label3.Size = new System.Drawing.Size(56, 12);
            this.second_label3.TabIndex = 0;
            this.second_label3.Text = "second_label3";
            // 
            // second_label4
            // 
            this.second_label4.AutoSize = true;
            this.second_label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label4.Location = new System.Drawing.Point(3, 35);
            this.second_label4.Name = "second_label4";
            this.second_label4.Size = new System.Drawing.Size(56, 12);
            this.second_label4.TabIndex = 1;
            this.second_label4.Text = "second_label4";
            // 
            // tB_year
            // 
            this.tB_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.tB_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tB_year.Location = new System.Drawing.Point(3, 15);
            this.tB_year.Name = "tB_year";
            this.tB_year.Size = new System.Drawing.Size(61, 20);
            this.tB_year.TabIndex = 2;
            // 
            // cB_félév
            // 
            this.cB_félév.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cB_félév.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cB_félév.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_félév.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cB_félév.FormattingEnabled = true;
            this.cB_félév.Location = new System.Drawing.Point(3, 50);
            this.cB_félév.Name = "cB_félév";
            this.cB_félév.Size = new System.Drawing.Size(61, 21);
            this.cB_félév.TabIndex = 3;
            // 
            // second_button1
            // 
            this.second_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.second_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_button1.Location = new System.Drawing.Point(76, 3);
            this.second_button1.Name = "second_button1";
            this.second_button1.Size = new System.Drawing.Size(67, 23);
            this.second_button1.TabIndex = 1;
            this.second_button1.Text = "second_button1";
            this.second_button1.UseVisualStyleBackColor = false;
            // 
            // Form_újtárgy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_újtárgy";
            this.Text = "Form_újtárgy";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_subchose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectchooserBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private default_dataGridView dgw_subchose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private second_textbox tb_kód;
        private second_textbox tb_név;
        private second_label second_label1;
        private second_label second_label2;
        private second_button but_nope;
        private second_button but_újlistaelem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tárgynévDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tárgykódDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elégségesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn közepesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jóDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aláírásosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectchooserBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private second_label second_label3;
        private second_label second_label4;
        private second_textbox tB_year;
        private second_comboBox cB_félév;
        private second_button second_button1;
    }
}