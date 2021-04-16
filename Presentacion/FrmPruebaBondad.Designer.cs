namespace SimulacionTP1.Presentacion
{
    partial class FrmPruebaBondad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadNumeros = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblValoresResultado = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.tablaProcedimiento = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Intervalos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadNumeros.Font = new System.Drawing.Font("Arial", 13F);
            this.txtCantidadNumeros.Location = new System.Drawing.Point(10, 30);
            this.txtCantidadNumeros.MaxLength = 6;
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.ShortcutsEnabled = false;
            this.txtCantidadNumeros.Size = new System.Drawing.Size(81, 27);
            this.txtCantidadNumeros.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerar.BackColor = System.Drawing.Color.Black;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(8, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(137, 41);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 80);
            this.panel1.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblValoresResultado);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(601, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 78);
            this.panel7.TabIndex = 25;
            // 
            // lblValoresResultado
            // 
            this.lblValoresResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValoresResultado.AutoSize = true;
            this.lblValoresResultado.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValoresResultado.Location = new System.Drawing.Point(16, 28);
            this.lblValoresResultado.Name = "lblValoresResultado";
            this.lblValoresResultado.Size = new System.Drawing.Size(323, 18);
            this.lblValoresResultado.TabIndex = 25;
            this.lblValoresResultado.Text = "Valor calculado: 10,2       Valor Tabulado: 12,5";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pbResultado);
            this.panel6.Controls.Add(this.lblResultado);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(194, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(407, 78);
            this.panel6.TabIndex = 24;
            // 
            // pbResultado
            // 
            this.pbResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbResultado.Image = global::SimulacionTP1.Properties.Resources.cheque;
            this.pbResultado.Location = new System.Drawing.Point(345, 17);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(46, 43);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultado.TabIndex = 1;
            this.pbResultado.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 13F);
            this.lblResultado.Location = new System.Drawing.Point(5, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(264, 21);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "No se rechaza la hipótesis nula.";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtCantidadNumeros);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cmbIntervalos);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 78);
            this.panel5.TabIndex = 23;
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.Font = new System.Drawing.Font("Arial", 13F);
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.ItemHeight = 19;
            this.cmbIntervalos.Location = new System.Drawing.Point(114, 29);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(58, 27);
            this.cmbIntervalos.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSerie);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 143);
            this.panel3.TabIndex = 28;
            // 
            // txtSerie
            // 
            this.txtSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSerie.Location = new System.Drawing.Point(0, 0);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(10);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerie.Size = new System.Drawing.Size(829, 143);
            this.txtSerie.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btnCopiar);
            this.panel4.Controls.Add(this.btnGenerar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(829, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 143);
            this.panel4.TabIndex = 2;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCopiar.BackColor = System.Drawing.Color.Black;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCopiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopiar.Location = new System.Drawing.Point(8, 76);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(137, 41);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.Text = "Copiar a Portapapeles";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.ClickBtnCopiar);
            // 
            // tablaProcedimiento
            // 
            this.tablaProcedimiento.AllowUserToAddRows = false;
            this.tablaProcedimiento.AllowUserToDeleteRows = false;
            this.tablaProcedimiento.AllowUserToResizeColumns = false;
            this.tablaProcedimiento.AllowUserToResizeRows = false;
            this.tablaProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProcedimiento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tablaProcedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProcedimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProcedimiento.ColumnHeadersHeight = 50;
            this.tablaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProcedimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProcedimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaProcedimiento.EnableHeadersVisualStyles = false;
            this.tablaProcedimiento.Location = new System.Drawing.Point(428, 80);
            this.tablaProcedimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablaProcedimiento.MultiSelect = false;
            this.tablaProcedimiento.Name = "tablaProcedimiento";
            this.tablaProcedimiento.ReadOnly = true;
            this.tablaProcedimiento.RowHeadersVisible = false;
            this.tablaProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaProcedimiento.Size = new System.Drawing.Size(553, 402);
            this.tablaProcedimiento.TabIndex = 30;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(428, 80);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 402);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // histograma
            // 
            this.histograma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.histograma.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea1);
            this.histograma.Dock = System.Windows.Forms.DockStyle.Left;
            this.histograma.Location = new System.Drawing.Point(0, 80);
            this.histograma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.histograma.Name = "histograma";
            this.histograma.Size = new System.Drawing.Size(428, 402);
            this.histograma.TabIndex = 29;
            this.histograma.Text = "chart1";
            // 
            // FrmPruebaBondad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 625);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tablaProcedimiento);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = true;
            this.Name = "FrmPruebaBondad";
            this.Text = "Prueba de Bondad";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ControlesUsuario.NumTextBox txtCantidadNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tablaProcedimiento;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private System.Windows.Forms.Label lblValoresResultado;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCopiar;
    }
}

