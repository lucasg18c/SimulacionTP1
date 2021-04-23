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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.lblValoresResultado = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbIntervalo = new SimulacionTP1.Presentacion.ControlesUsuario.DatoCombo();
            this.txtCantidad = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblGUIVacio = new System.Windows.Forms.Label();
            this.tablaProcedimiento = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pbGUIVacio = new System.Windows.Forms.PictureBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGUIVacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(0, 443);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(196, 51);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 67);
            this.panel1.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblResultado);
            this.panel7.Controls.Add(this.pbResultado);
            this.panel7.Controls.Add(this.lblValoresResultado);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(173, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(671, 67);
            this.panel7.TabIndex = 25;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 13F);
            this.lblResultado.Location = new System.Drawing.Point(126, 19);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(264, 21);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "No se rechaza la hipótesis nula.";
            // 
            // pbResultado
            // 
            this.pbResultado.Image = global::SimulacionTP1.Properties.Resources.cheque;
            this.pbResultado.Location = new System.Drawing.Point(40, 9);
            this.pbResultado.Margin = new System.Windows.Forms.Padding(4);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(59, 54);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultado.TabIndex = 1;
            this.pbResultado.TabStop = false;
            // 
            // lblValoresResultado
            // 
            this.lblValoresResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValoresResultado.AutoSize = true;
            this.lblValoresResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoresResultado.Location = new System.Drawing.Point(471, 12);
            this.lblValoresResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValoresResultado.Name = "lblValoresResultado";
            this.lblValoresResultado.Size = new System.Drawing.Size(311, 21);
            this.lblValoresResultado.TabIndex = 25;
            this.lblValoresResultado.Text = "Valor calculado: 10,2   Valor Tabulado: 12,5";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 67);
            this.panel4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(56, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "TP1 Grupo 14";
            this.label7.Click += new System.EventHandler(this.ClickBtnVolver);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SimulacionTP1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClickBtnVolver);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cmbIntervalo);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(648, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 494);
            this.panel2.TabIndex = 31;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Location = new System.Drawing.Point(0, 387);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(196, 51);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.ClickBtnCopiar);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 5);
            this.panel3.TabIndex = 2;
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.cmbIntervalo.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.cmbIntervalo.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.cmbIntervalo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbIntervalo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbIntervalo.ForeColor = System.Drawing.Color.White;
            this.cmbIntervalo.Location = new System.Drawing.Point(0, 53);
            this.cmbIntervalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(196, 68);
            this.cmbIntervalo.TabIndex = 1;
            this.cmbIntervalo.Texto = "Intervalos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidad.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidad.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(0, 0);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(196, 53);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.Texto = "Cantidad";
            this.txtCantidad.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtCantidad.Valor = 10;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 494);
            this.panel5.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(616, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(32, 494);
            this.panel8.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(32, 531);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(584, 30);
            this.panel9.TabIndex = 34;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(32, 67);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(584, 30);
            this.panel10.TabIndex = 35;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblGUIVacio);
            this.panel11.Controls.Add(this.tablaProcedimiento);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.pbGUIVacio);
            this.panel11.Controls.Add(this.txtSerie);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(213, 97);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(403, 434);
            this.panel11.TabIndex = 37;
            // 
            // lblGUIVacio
            // 
            this.lblGUIVacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGUIVacio.AutoSize = true;
            this.lblGUIVacio.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblGUIVacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.lblGUIVacio.Location = new System.Drawing.Point(-6, 305);
            this.lblGUIVacio.Name = "lblGUIVacio";
            this.lblGUIVacio.Size = new System.Drawing.Size(301, 25);
            this.lblGUIVacio.TabIndex = 41;
            this.lblGUIVacio.Text = "Presione \"Generar\" para empezar...";
            // 
            // tablaProcedimiento
            // 
            this.tablaProcedimiento.AllowUserToAddRows = false;
            this.tablaProcedimiento.AllowUserToDeleteRows = false;
            this.tablaProcedimiento.AllowUserToResizeColumns = false;
            this.tablaProcedimiento.AllowUserToResizeRows = false;
            this.tablaProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProcedimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tablaProcedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProcedimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaProcedimiento.ColumnHeadersHeight = 50;
            this.tablaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaProcedimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaProcedimiento.EnableHeadersVisualStyles = false;
            this.tablaProcedimiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.tablaProcedimiento.Location = new System.Drawing.Point(0, 0);
            this.tablaProcedimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaProcedimiento.MultiSelect = false;
            this.tablaProcedimiento.Name = "tablaProcedimiento";
            this.tablaProcedimiento.ReadOnly = true;
            this.tablaProcedimiento.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tablaProcedimiento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProcedimiento.Size = new System.Drawing.Size(403, 309);
            this.tablaProcedimiento.TabIndex = 39;
            this.tablaProcedimiento.Visible = false;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 309);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(403, 19);
            this.panel12.TabIndex = 38;
            // 
            // pbGUIVacio
            // 
            this.pbGUIVacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbGUIVacio.Image = global::SimulacionTP1.Properties.Resources.dado;
            this.pbGUIVacio.Location = new System.Drawing.Point(38, 102);
            this.pbGUIVacio.Name = "pbGUIVacio";
            this.pbGUIVacio.Size = new System.Drawing.Size(200, 200);
            this.pbGUIVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGUIVacio.TabIndex = 40;
            this.pbGUIVacio.TabStop = false;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSerie.ForeColor = System.Drawing.Color.White;
            this.txtSerie.Location = new System.Drawing.Point(0, 328);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerie.Size = new System.Drawing.Size(403, 106);
            this.txtSerie.TabIndex = 37;
            this.txtSerie.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(197, 97);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(16, 434);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // histograma
            // 
            this.histograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.histograma.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea2);
            this.histograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histograma.Location = new System.Drawing.Point(32, 97);
            this.histograma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.histograma.Name = "histograma";
            this.histograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.histograma.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(197)))))};
            series3.ChartArea = "ChartArea1";
            series3.Name = "Fo";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Fe";
            this.histograma.Series.Add(series3);
            this.histograma.Series.Add(series4);
            this.histograma.Size = new System.Drawing.Size(165, 434);
            this.histograma.TabIndex = 39;
            this.histograma.Text = "chart1";
            this.histograma.Visible = false;
            // 
            // FrmPruebaBondad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = true;
            this.Name = "FrmPruebaBondad";
            this.Text = "Prueba de Bondad";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGUIVacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValoresResultado;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlesUsuario.DatoTxtNum txtCantidad;
        private ControlesUsuario.DatoCombo cmbIntervalo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private System.Windows.Forms.DataGridView tablaProcedimiento;
        private System.Windows.Forms.Label lblGUIVacio;
        private System.Windows.Forms.PictureBox pbGUIVacio;
    }
}

