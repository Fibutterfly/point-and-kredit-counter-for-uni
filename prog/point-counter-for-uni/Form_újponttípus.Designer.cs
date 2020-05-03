namespace point_counter_for_uni
{
    partial class Form_újponttípus
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgw_minmaxtbl = new point_counter_for_uni.default_dataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.second_label9 = new point_counter_for_uni.second_label();
            this.second_label10 = new point_counter_for_uni.second_label();
            this.second_label11 = new point_counter_for_uni.second_label();
            this.cB_típus = new point_counter_for_uni.second_comboBox();
            this.tB_max = new point_counter_for_uni.second_textbox();
            this.tB_min = new point_counter_for_uni.second_textbox();
            this.but_addtype = new point_counter_for_uni.second_button();
            this.but_ok = new point_counter_for_uni.second_button();
            this.but_nope = new point_counter_for_uni.second_button();
            this.addmaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.típusnévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.típusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_minmaxtbl)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addmaxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.Controls.Add(this.dgw_minmaxtbl, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // dgw_minmaxtbl
            // 
            this.dgw_minmaxtbl.AllowUserToAddRows = false;
            this.dgw_minmaxtbl.AllowUserToDeleteRows = false;
            this.dgw_minmaxtbl.AutoGenerateColumns = false;
            this.dgw_minmaxtbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_minmaxtbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_minmaxtbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_minmaxtbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.típusnévDataGridViewTextBoxColumn,
            this.típusidDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn});
            this.dgw_minmaxtbl.DataSource = this.addmaxBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_minmaxtbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_minmaxtbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_minmaxtbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.dgw_minmaxtbl.Location = new System.Drawing.Point(443, 3);
            this.dgw_minmaxtbl.Name = "dgw_minmaxtbl";
            this.dgw_minmaxtbl.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_minmaxtbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dgw_minmaxtbl.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_minmaxtbl.Size = new System.Drawing.Size(354, 444);
            this.dgw_minmaxtbl.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel5.Controls.Add(this.second_label9, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.second_label10, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.second_label11, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.cB_típus, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.tB_max, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.tB_min, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.but_addtype, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.but_ok, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.but_nope, 3, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(434, 444);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // second_label9
            // 
            this.second_label9.AutoSize = true;
            this.second_label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.second_label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label9.Location = new System.Drawing.Point(11, 120);
            this.second_label9.Name = "second_label9";
            this.second_label9.Size = new System.Drawing.Size(124, 13);
            this.second_label9.TabIndex = 0;
            this.second_label9.Text = "Típus";
            this.second_label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // second_label10
            // 
            this.second_label10.AutoSize = true;
            this.second_label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.second_label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label10.Location = new System.Drawing.Point(154, 120);
            this.second_label10.Name = "second_label10";
            this.second_label10.Size = new System.Drawing.Size(124, 13);
            this.second_label10.TabIndex = 1;
            this.second_label10.Text = "Max";
            this.second_label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // second_label11
            // 
            this.second_label11.AutoSize = true;
            this.second_label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.second_label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.second_label11.Location = new System.Drawing.Point(297, 120);
            this.second_label11.Name = "second_label11";
            this.second_label11.Size = new System.Drawing.Size(124, 13);
            this.second_label11.TabIndex = 2;
            this.second_label11.Text = "Min";
            this.second_label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cB_típus
            // 
            this.cB_típus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cB_típus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cB_típus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_típus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cB_típus.FormattingEnabled = true;
            this.cB_típus.Location = new System.Drawing.Point(11, 136);
            this.cB_típus.Name = "cB_típus";
            this.cB_típus.Size = new System.Drawing.Size(124, 21);
            this.cB_típus.TabIndex = 3;
            // 
            // tB_max
            // 
            this.tB_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.tB_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tB_max.Location = new System.Drawing.Point(154, 136);
            this.tB_max.Name = "tB_max";
            this.tB_max.Size = new System.Drawing.Size(124, 20);
            this.tB_max.TabIndex = 4;
            // 
            // tB_min
            // 
            this.tB_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.tB_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tB_min.Location = new System.Drawing.Point(297, 136);
            this.tB_min.Name = "tB_min";
            this.tB_min.Size = new System.Drawing.Size(124, 20);
            this.tB_min.TabIndex = 5;
            // 
            // but_addtype
            // 
            this.but_addtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.but_addtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_addtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_addtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_addtype.Location = new System.Drawing.Point(297, 313);
            this.but_addtype.Name = "but_addtype";
            this.but_addtype.Size = new System.Drawing.Size(124, 60);
            this.but_addtype.TabIndex = 6;
            this.but_addtype.Text = "új pont típus felvétele";
            this.but_addtype.UseVisualStyleBackColor = false;
            // 
            // but_ok
            // 
            this.but_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.but_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_ok.Location = new System.Drawing.Point(11, 379);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(124, 62);
            this.but_ok.TabIndex = 7;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = false;
            // 
            // but_nope
            // 
            this.but_nope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.but_nope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_nope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_nope.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_nope.Location = new System.Drawing.Point(154, 379);
            this.but_nope.Name = "but_nope";
            this.but_nope.Size = new System.Drawing.Size(124, 62);
            this.but_nope.TabIndex = 8;
            this.but_nope.Text = "Mégse";
            this.but_nope.UseVisualStyleBackColor = false;
            // 
            // addmaxBindingSource
            // 
            this.addmaxBindingSource.DataSource = typeof(point_counter_for_uni.add_max);
            // 
            // típusnévDataGridViewTextBoxColumn
            // 
            this.típusnévDataGridViewTextBoxColumn.DataPropertyName = "Típus_név";
            this.típusnévDataGridViewTextBoxColumn.HeaderText = "Típus_név";
            this.típusnévDataGridViewTextBoxColumn.Name = "típusnévDataGridViewTextBoxColumn";
            this.típusnévDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // típusidDataGridViewTextBoxColumn
            // 
            this.típusidDataGridViewTextBoxColumn.DataPropertyName = "Típus_id";
            this.típusidDataGridViewTextBoxColumn.HeaderText = "Típus_id";
            this.típusidDataGridViewTextBoxColumn.Name = "típusidDataGridViewTextBoxColumn";
            this.típusidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_újponttípus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "Form_újponttípus";
            this.Text = "Form_újponttípus";
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_minmaxtbl)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addmaxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private default_dataGridView dgw_minmaxtbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private second_label second_label9;
        private second_label second_label10;
        private second_label second_label11;
        private second_comboBox cB_típus;
        private second_textbox tB_max;
        private second_textbox tB_min;
        private second_button but_addtype;
        private second_button but_ok;
        private second_button but_nope;
        private System.Windows.Forms.DataGridViewTextBoxColumn típusnévDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn típusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addmaxBindingSource;
    }
}