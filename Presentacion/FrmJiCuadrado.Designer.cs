namespace SimulacionTP1.Presentacion
{
    partial class FrmJiCuadrado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gdrDesde = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaNumeros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadIntervalos = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.txtCantidadNumeros = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cantidad de Intervalos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad Números";
            // 
            // gdrDesde
            // 
            this.gdrDesde.AllowUserToAddRows = false;
            this.gdrDesde.AllowUserToDeleteRows = false;
            this.gdrDesde.AllowUserToResizeColumns = false;
            this.gdrDesde.AllowUserToResizeRows = false;
            this.gdrDesde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdrDesde.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdrDesde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrDesde.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrDesde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdrDesde.ColumnHeadersHeight = 30;
            this.gdrDesde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdrDesde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.fo,
            this.fe,
            this.c,
            this.c2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdrDesde.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdrDesde.EnableHeadersVisualStyles = false;
            this.gdrDesde.Location = new System.Drawing.Point(263, 22);
            this.gdrDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdrDesde.MultiSelect = false;
            this.gdrDesde.Name = "gdrDesde";
            this.gdrDesde.ReadOnly = true;
            this.gdrDesde.RowHeadersVisible = false;
            this.gdrDesde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gdrDesde.Size = new System.Drawing.Size(706, 213);
            this.gdrDesde.TabIndex = 24;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // c2
            // 
            this.c2.HeaderText = "C (AC)";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // histo
            // 
            this.histo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.histo.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.histo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histo.Legends.Add(legend1);
            this.histo.Location = new System.Drawing.Point(263, 240);
            this.histo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.histo.Name = "histo";
            this.histo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.histo.Size = new System.Drawing.Size(706, 374);
            this.histo.TabIndex = 25;
            this.histo.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaNumeros);
            this.groupBox1.Controls.Add(this.txtCantidadIntervalos);
            this.groupBox1.Controls.Add(this.txtCantidadNumeros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(236, 552);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos ";
            // 
            // tablaNumeros
            // 
            this.tablaNumeros.AllowUserToAddRows = false;
            this.tablaNumeros.AllowUserToDeleteRows = false;
            this.tablaNumeros.AllowUserToResizeColumns = false;
            this.tablaNumeros.AllowUserToResizeRows = false;
            this.tablaNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaNumeros.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tablaNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaNumeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaNumeros.ColumnHeadersHeight = 30;
            this.tablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaNumeros.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaNumeros.EnableHeadersVisualStyles = false;
            this.tablaNumeros.Location = new System.Drawing.Point(6, 159);
            this.tablaNumeros.MultiSelect = false;
            this.tablaNumeros.Name = "tablaNumeros";
            this.tablaNumeros.ReadOnly = true;
            this.tablaNumeros.RowHeadersVisible = false;
            this.tablaNumeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaNumeros.Size = new System.Drawing.Size(224, 386);
            this.tablaNumeros.TabIndex = 27;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtCantidadIntervalos
            // 
            this.txtCantidadIntervalos.Location = new System.Drawing.Point(30, 111);
            this.txtCantidadIntervalos.MaxLength = 3;
            this.txtCantidadIntervalos.Name = "txtCantidadIntervalos";
            this.txtCantidadIntervalos.ShortcutsEnabled = false;
            this.txtCantidadIntervalos.Size = new System.Drawing.Size(181, 22);
            this.txtCantidadIntervalos.TabIndex = 1;
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.Location = new System.Drawing.Point(30, 50);
            this.txtCantidadNumeros.MaxLength = 6;
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.ShortcutsEnabled = false;
            this.txtCantidadNumeros.Size = new System.Drawing.Size(181, 22);
            this.txtCantidadNumeros.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Black;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(20, 574);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(224, 40);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // FrmJiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 625);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.histo);
            this.Controls.Add(this.gdrDesde);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmJiCuadrado";
            this.Text = "Prueba de Ji-Cuadrada";
            ((System.ComponentModel.ISupportInitialize)(this.gdrDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdrDesde;
        private System.Windows.Forms.DataVisualization.Charting.Chart histo;
        private System.Windows.Forms.GroupBox groupBox1;
        private ControlesUsuario.NumTextBox txtCantidadNumeros;
        private ControlesUsuario.NumTextBox txtCantidadIntervalos;
        private System.Windows.Forms.DataGridView tablaNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
    }
}

