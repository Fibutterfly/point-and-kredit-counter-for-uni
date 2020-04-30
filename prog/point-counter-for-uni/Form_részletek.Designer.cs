namespace point_counter_for_uni
{
    partial class Form_részletek
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgw_összesített = new point_counter_for_uni.default_dataGridView();
            this.pontidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumbytypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.but_új = new point_counter_for_uni.button_default();
            this.but_mód = new point_counter_for_uni.button_default();
            this.but_del = new point_counter_for_uni.button_default();
            this.dgw_részletek = new point_counter_for_uni.default_dataGridView();
            this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.point1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_összesített)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumbytypesBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_részletek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgw_részletek, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.dgw_összesített, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 193);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgw_összesített
            // 
            this.dgw_összesített.AutoGenerateColumns = false;
            this.dgw_összesített.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_összesített.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_összesített.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_összesített.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pontidDataGridViewTextBoxColumn,
            this.pontnevDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.pontDataGridViewTextBoxColumn});
            this.dgw_összesített.DataSource = this.sumbytypesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_összesített.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_összesített.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_összesített.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.dgw_összesített.Location = new System.Drawing.Point(201, 3);
            this.dgw_összesített.Name = "dgw_összesített";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_összesített.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dgw_összesített.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_összesített.Size = new System.Drawing.Size(590, 187);
            this.dgw_összesített.TabIndex = 0;
            // 
            // pontidDataGridViewTextBoxColumn
            // 
            this.pontidDataGridViewTextBoxColumn.DataPropertyName = "Pont_id";
            this.pontidDataGridViewTextBoxColumn.HeaderText = "Pont_id";
            this.pontidDataGridViewTextBoxColumn.Name = "pontidDataGridViewTextBoxColumn";
            // 
            // pontnevDataGridViewTextBoxColumn
            // 
            this.pontnevDataGridViewTextBoxColumn.DataPropertyName = "Pont_nev";
            this.pontnevDataGridViewTextBoxColumn.HeaderText = "Pont_nev";
            this.pontnevDataGridViewTextBoxColumn.Name = "pontnevDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // pontDataGridViewTextBoxColumn
            // 
            this.pontDataGridViewTextBoxColumn.DataPropertyName = "Pont";
            this.pontDataGridViewTextBoxColumn.HeaderText = "Pont";
            this.pontDataGridViewTextBoxColumn.Name = "pontDataGridViewTextBoxColumn";
            // 
            // sumbytypesBindingSource
            // 
            this.sumbytypesBindingSource.DataSource = typeof(point_counter_for_uni.sum_by_types);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.but_új, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.but_mód, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.but_del, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 187);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // but_új
            // 
            this.but_új.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.but_új.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_új.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_új.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_új.Location = new System.Drawing.Point(3, 127);
            this.but_új.Name = "but_új";
            this.but_új.Size = new System.Drawing.Size(186, 57);
            this.but_új.TabIndex = 2;
            this.but_új.Text = "új sor mentése";
            this.but_új.UseVisualStyleBackColor = false;
            // 
            // but_mód
            // 
            this.but_mód.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.but_mód.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_mód.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_mód.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_mód.Location = new System.Drawing.Point(3, 65);
            this.but_mód.Name = "but_mód";
            this.but_mód.Size = new System.Drawing.Size(186, 56);
            this.but_mód.TabIndex = 1;
            this.but_mód.Text = "módosított sor mentése";
            this.but_mód.UseVisualStyleBackColor = false;
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.but_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_del.Location = new System.Drawing.Point(3, 3);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(186, 56);
            this.but_del.TabIndex = 0;
            this.but_del.Text = "kijelölt sor törlése";
            this.but_del.UseVisualStyleBackColor = false;
            // 
            // dgw_részletek
            // 
            this.dgw_részletek.AutoGenerateColumns = false;
            this.dgw_részletek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_részletek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_részletek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_részletek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.point1DataGridViewTextBoxColumn,
            this.pTFKDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dgw_részletek.DataSource = this.pointBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_részletek.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_részletek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_részletek.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.dgw_részletek.Location = new System.Drawing.Point(3, 202);
            this.dgw_részletek.Name = "dgw_részletek";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_részletek.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dgw_részletek.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw_részletek.Size = new System.Drawing.Size(794, 245);
            this.dgw_részletek.TabIndex = 1;
            // 
            // pointBindingSource
            // 
            this.pointBindingSource.DataSource = typeof(point_counter_for_uni.Point);
            // 
            // point1DataGridViewTextBoxColumn
            // 
            this.point1DataGridViewTextBoxColumn.DataPropertyName = "Point1";
            this.point1DataGridViewTextBoxColumn.HeaderText = "Point1";
            this.point1DataGridViewTextBoxColumn.Name = "point1DataGridViewTextBoxColumn";
            // 
            // pTFKDataGridViewTextBoxColumn
            // 
            this.pTFKDataGridViewTextBoxColumn.DataPropertyName = "PT_FK";
            this.pTFKDataGridViewTextBoxColumn.DataSource = this.sumbytypesBindingSource;
            this.pTFKDataGridViewTextBoxColumn.DisplayMember = "Pont_nev";
            this.pTFKDataGridViewTextBoxColumn.HeaderText = "PT_FK";
            this.pTFKDataGridViewTextBoxColumn.Name = "pTFKDataGridViewTextBoxColumn";
            this.pTFKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pTFKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pTFKDataGridViewTextBoxColumn.ValueMember = "Pont_id";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // Form_részletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_részletek";
            this.Text = "Form_részletek";
            this.Load += new System.EventHandler(this.Form_részletek_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_összesített)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumbytypesBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_részletek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private default_dataGridView dgw_részletek;
        private default_dataGridView dgw_összesített;
        private System.Windows.Forms.BindingSource pointBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sumbytypesBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private button_default but_új;
        private button_default but_mód;
        private button_default but_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn point1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pTFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
    }
}