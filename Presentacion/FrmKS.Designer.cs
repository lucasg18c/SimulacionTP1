namespace SimulacionTP1.Presentacion
{
    partial class FrmKS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadInt = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadNum = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvIntervalos = new System.Windows.Forms.DataGridView();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maxx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTabla);
            this.groupBox1.Controls.Add(this.txtCantidadInt);
            this.groupBox1.Controls.Add(this.lblIntervalos);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCantidadNum);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 552);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeight = 30;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.Location = new System.Drawing.Point(6, 159);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabla.Size = new System.Drawing.Size(224, 386);
            this.dgvTabla.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Iteración";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Números Aleatorios";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtCantidadInt
            // 
            this.txtCantidadInt.Location = new System.Drawing.Point(43, 108);
            this.txtCantidadInt.MaxLength = 3;
            this.txtCantidadInt.Name = "txtCantidadInt";
            this.txtCantidadInt.ShortcutsEnabled = false;
            this.txtCantidadInt.Size = new System.Drawing.Size(140, 22);
            this.txtCantidadInt.TabIndex = 5;
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(40, 89);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(139, 16);
            this.lblIntervalos.TabIndex = 4;
            this.lblIntervalos.Text = "Cantidad de Intervalos:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(40, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(137, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de Números:";
            // 
            // txtCantidadNum
            // 
            this.txtCantidadNum.Location = new System.Drawing.Point(43, 47);
            this.txtCantidadNum.MaxLength = 6;
            this.txtCantidadNum.Name = "txtCantidadNum";
            this.txtCantidadNum.ShortcutsEnabled = false;
            this.txtCantidadNum.Size = new System.Drawing.Size(140, 22);
            this.txtCantidadNum.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Black;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(18, 568);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(224, 40);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // dgvIntervalos
            // 
            this.dgvIntervalos.AllowUserToAddRows = false;
            this.dgvIntervalos.AllowUserToDeleteRows = false;
            this.dgvIntervalos.AllowUserToResizeColumns = false;
            this.dgvIntervalos.AllowUserToResizeRows = false;
            this.dgvIntervalos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntervalos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvIntervalos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntervalos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervalos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIntervalos.ColumnHeadersHeight = 30;
            this.dgvIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.F0,
            this.Fe,
            this.Po,
            this.Pe,
            this.PoAC,
            this.PeAC,
            this.Max,
            this.Maxx});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervalos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIntervalos.EnableHeadersVisualStyles = false;
            this.dgvIntervalos.Location = new System.Drawing.Point(263, 22);
            this.dgvIntervalos.MultiSelect = false;
            this.dgvIntervalos.Name = "dgvIntervalos";
            this.dgvIntervalos.ReadOnly = true;
            this.dgvIntervalos.RowHeadersVisible = false;
            this.dgvIntervalos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvIntervalos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIntervalos.Size = new System.Drawing.Size(706, 213);
            this.dgvIntervalos.TabIndex = 14;
            // 
            // histograma
            // 
            this.histograma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.histograma.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histograma.Legends.Add(legend1);
            this.histograma.Location = new System.Drawing.Point(263, 240);
            this.histograma.Name = "histograma";
            this.histograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.histograma.Size = new System.Drawing.Size(706, 374);
            this.histograma.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Desde";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hasta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // F0
            // 
            this.F0.HeaderText = "Fo";
            this.F0.Name = "F0";
            this.F0.ReadOnly = true;
            // 
            // Fe
            // 
            this.Fe.HeaderText = "Fe";
            this.Fe.Name = "Fe";
            this.Fe.ReadOnly = true;
            // 
            // Po
            // 
            this.Po.HeaderText = "Po";
            this.Po.Name = "Po";
            this.Po.ReadOnly = true;
            // 
            // Pe
            // 
            this.Pe.HeaderText = "Pe";
            this.Pe.Name = "Pe";
            this.Pe.ReadOnly = true;
            // 
            // PoAC
            // 
            this.PoAC.HeaderText = "Po(AC)";
            this.PoAC.Name = "PoAC";
            this.PoAC.ReadOnly = true;
            // 
            // PeAC
            // 
            this.PeAC.HeaderText = "Pe(AC)";
            this.PeAC.Name = "PeAC";
            this.PeAC.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.FillWeight = 150F;
            this.Max.HeaderText = "|Po(AC)-Pe(AC)|";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            // 
            // Maxx
            // 
            this.Maxx.HeaderText = "Max";
            this.Maxx.Name = "Maxx";
            this.Maxx.ReadOnly = true;
            // 
            // FrmKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 625);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.dgvIntervalos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmKS";
            this.Text = "Prueba de Kolmogorov-Smirnov";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ControlesUsuario.NumTextBox txtCantidadNum;
        private System.Windows.Forms.Label lblCantidad;
        private ControlesUsuario.NumTextBox txtCantidadInt;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.DataGridView dgvIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn F0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Po;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maxx;
    }
}