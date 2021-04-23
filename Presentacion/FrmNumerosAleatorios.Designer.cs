using SimulacionTP1.Presentacion.ControlesUsuario;

namespace SimulacionTP1.Presentacion
{
    partial class FrmNumerosAleatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNumerosAleatorios));
            this.rbMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtG = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.txtK = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.txtM = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.txtA = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.txtC = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.txtX = new SimulacionTP1.Presentacion.ControlesUsuario.DatoTxtNum();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tablaNumeros = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbGUIVacio = new System.Windows.Forms.PictureBox();
            this.lblGUIVacio = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGUIVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMultiplicativo
            // 
            this.rbMultiplicativo.AutoSize = true;
            this.rbMultiplicativo.Location = new System.Drawing.Point(117, 31);
            this.rbMultiplicativo.Margin = new System.Windows.Forms.Padding(4);
            this.rbMultiplicativo.Name = "rbMultiplicativo";
            this.rbMultiplicativo.Size = new System.Drawing.Size(216, 24);
            this.rbMultiplicativo.TabIndex = 11;
            this.rbMultiplicativo.Text = "Congruencial Multiplicativo";
            this.rbMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Checked = true;
            this.rbLineal.Location = new System.Drawing.Point(117, 7);
            this.rbLineal.Margin = new System.Windows.Forms.Padding(4);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(162, 24);
            this.rbLineal.TabIndex = 10;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Congruencial Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.ClickRadioButton);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 60);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 60);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.ClickBtnVolver);
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
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel5.Controls.Add(this.btnExportar);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.txtG);
            this.panel5.Controls.Add(this.txtK);
            this.panel5.Controls.Add(this.txtM);
            this.panel5.Controls.Add(this.txtA);
            this.panel5.Controls.Add(this.txtC);
            this.panel5.Controls.Add(this.txtX);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(598, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 501);
            this.panel5.TabIndex = 16;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Location = new System.Drawing.Point(0, 388);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(246, 54);
            this.btnExportar.TabIndex = 25;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.ClickBtnExportar);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 442);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(246, 5);
            this.panel10.TabIndex = 24;
            // 
            // txtG
            // 
            this.txtG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtG.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtG.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtG.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtG.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG.ForeColor = System.Drawing.Color.White;
            this.txtG.Location = new System.Drawing.Point(0, 265);
            this.txtG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(246, 53);
            this.txtG.TabIndex = 22;
            this.txtG.Texto = "Valor ( g )";
            this.txtG.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtG.Valor = 0;
            // 
            // txtK
            // 
            this.txtK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtK.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtK.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtK.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtK.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK.ForeColor = System.Drawing.Color.White;
            this.txtK.Location = new System.Drawing.Point(0, 212);
            this.txtK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(246, 53);
            this.txtK.TabIndex = 21;
            this.txtK.Texto = "Valor ( k )";
            this.txtK.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtK.Valor = 0;
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtM.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtM.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtM.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtM.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.ForeColor = System.Drawing.Color.White;
            this.txtM.Location = new System.Drawing.Point(0, 159);
            this.txtM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(246, 53);
            this.txtM.TabIndex = 20;
            this.txtM.Texto = "Módulo ( m )";
            this.txtM.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtM.Valor = 1024;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtA.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtA.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtA.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtA.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.Location = new System.Drawing.Point(0, 106);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(246, 53);
            this.txtA.TabIndex = 19;
            this.txtA.Texto = "Constante ( a )";
            this.txtA.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtA.Valor = 161;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtC.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtC.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtC.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtC.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.White;
            this.txtC.Location = new System.Drawing.Point(0, 53);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(246, 53);
            this.txtC.TabIndex = 18;
            this.txtC.Texto = "Constante ( c )";
            this.txtC.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtC.Valor = 3;
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtX.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtX.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtX.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.ForeColor = System.Drawing.Color.White;
            this.txtX.Location = new System.Drawing.Point(0, 0);
            this.txtX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(246, 53);
            this.txtX.TabIndex = 17;
            this.txtX.Texto = "Semilla ( x )";
            this.txtX.TipoDato = SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.txtX.Valor = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 54);
            this.panel3.TabIndex = 16;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(246, 54);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel6.Controls.Add(this.rbMultiplicativo);
            this.panel6.Controls.Add(this.rbLineal);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(598, 62);
            this.panel6.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 39);
            this.panel1.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 400);
            this.panel7.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(548, 161);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(50, 400);
            this.panel9.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(50, 522);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(498, 39);
            this.panel8.TabIndex = 22;
            // 
            // tablaNumeros
            // 
            this.tablaNumeros.AllowUserToAddRows = false;
            this.tablaNumeros.AllowUserToDeleteRows = false;
            this.tablaNumeros.AllowUserToResizeColumns = false;
            this.tablaNumeros.AllowUserToResizeRows = false;
            this.tablaNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaNumeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tablaNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaNumeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaNumeros.ColumnHeadersHeight = 35;
            this.tablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numeros});
            this.tablaNumeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaNumeros.EnableHeadersVisualStyles = false;
            this.tablaNumeros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.tablaNumeros.Location = new System.Drawing.Point(50, 161);
            this.tablaNumeros.Margin = new System.Windows.Forms.Padding(4);
            this.tablaNumeros.MultiSelect = false;
            this.tablaNumeros.Name = "tablaNumeros";
            this.tablaNumeros.ReadOnly = true;
            this.tablaNumeros.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaNumeros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaNumeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaNumeros.Size = new System.Drawing.Size(498, 361);
            this.tablaNumeros.TabIndex = 23;
            this.tablaNumeros.Visible = false;
            // 
            // iteracion
            // 
            this.iteracion.FillWeight = 60F;
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            // 
            // numeros
            // 
            this.numeros.HeaderText = "Números Aleatorios";
            this.numeros.Name = "numeros";
            this.numeros.ReadOnly = true;
            // 
            // pbGUIVacio
            // 
            this.pbGUIVacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbGUIVacio.Image = global::SimulacionTP1.Properties.Resources.dado;
            this.pbGUIVacio.Location = new System.Drawing.Point(218, 209);
            this.pbGUIVacio.Name = "pbGUIVacio";
            this.pbGUIVacio.Size = new System.Drawing.Size(200, 200);
            this.pbGUIVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGUIVacio.TabIndex = 24;
            this.pbGUIVacio.TabStop = false;
            // 
            // lblGUIVacio
            // 
            this.lblGUIVacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGUIVacio.AutoSize = true;
            this.lblGUIVacio.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblGUIVacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.lblGUIVacio.Location = new System.Drawing.Point(174, 412);
            this.lblGUIVacio.Name = "lblGUIVacio";
            this.lblGUIVacio.Size = new System.Drawing.Size(301, 25);
            this.lblGUIVacio.TabIndex = 25;
            this.lblGUIVacio.Text = "Presione \"Generar\" para empezar...";
            // 
            // FrmNumerosAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.lblGUIVacio);
            this.Controls.Add(this.pbGUIVacio);
            this.Controls.Add(this.tablaNumeros);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = true;
            this.Name = "FrmNumerosAleatorios";
            this.Text = "Números Pseudoaleatorios";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGUIVacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbMultiplicativo;
        private System.Windows.Forms.RadioButton rbLineal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private DatoTxtNum txtG;
        private DatoTxtNum txtK;
        private DatoTxtNum txtM;
        private DatoTxtNum txtA;
        private DatoTxtNum txtC;
        private DatoTxtNum txtX;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView tablaNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeros;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pbGUIVacio;
        private System.Windows.Forms.Label lblGUIVacio;
    }
}