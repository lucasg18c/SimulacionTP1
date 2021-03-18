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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX0 = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtA = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tablaNumeros = new System.Windows.Forms.DataGridView();
            this.numeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raíz";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(207, 51);
            this.txtX0.MaxLength = 8;
            this.txtX0.Name = "txtX0";
            this.txtX0.ShortcutsEnabled = false;
            this.txtX0.Size = new System.Drawing.Size(121, 25);
            this.txtX0.TabIndex = 1;
            this.txtX0.TextChanged += new System.EventHandler(this.DatoModificado);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(401, 206);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 43);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(20, 117);
            this.txtA.MaxLength = 8;
            this.txtA.Name = "txtA";
            this.txtA.ShortcutsEnabled = false;
            this.txtA.Size = new System.Drawing.Size(158, 25);
            this.txtA.TabIndex = 4;
            this.txtA.TextChanged += new System.EventHandler(this.DatoModificado);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constante Multiplicativa (a)";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(207, 117);
            this.txtC.MaxLength = 8;
            this.txtC.Name = "txtC";
            this.txtC.ShortcutsEnabled = false;
            this.txtC.Size = new System.Drawing.Size(121, 25);
            this.txtC.TabIndex = 6;
            this.txtC.TextChanged += new System.EventHandler(this.DatoModificado);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Constante Aditiva (c)";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(360, 51);
            this.txtM.MaxLength = 8;
            this.txtM.Name = "txtM";
            this.txtM.ShortcutsEnabled = false;
            this.txtM.Size = new System.Drawing.Size(121, 25);
            this.txtM.TabIndex = 8;
            this.txtM.TextChanged += new System.EventHandler(this.DatoModificado);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Módulo (m)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMetodo);
            this.groupBox1.Controls.Add(this.txtM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtX0);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(20, 51);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(158, 25);
            this.cmbMetodo.TabIndex = 10;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Método";
            // 
            // tablaNumeros
            // 
            this.tablaNumeros.AllowUserToAddRows = false;
            this.tablaNumeros.AllowUserToDeleteRows = false;
            this.tablaNumeros.AllowUserToResizeColumns = false;
            this.tablaNumeros.AllowUserToResizeRows = false;
            this.tablaNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaNumeros.ColumnHeadersHeight = 30;
            this.tablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeros});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaNumeros.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaNumeros.EnableHeadersVisualStyles = false;
            this.tablaNumeros.Location = new System.Drawing.Point(12, 206);
            this.tablaNumeros.MultiSelect = false;
            this.tablaNumeros.Name = "tablaNumeros";
            this.tablaNumeros.ReadOnly = true;
            this.tablaNumeros.RowHeadersVisible = false;
            this.tablaNumeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaNumeros.Size = new System.Drawing.Size(368, 351);
            this.tablaNumeros.TabIndex = 11;
            // 
            // numeros
            // 
            this.numeros.HeaderText = "Números Aleatorios";
            this.numeros.Name = "numeros";
            this.numeros.ReadOnly = true;
            // 
            // FrmNumerosAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 569);
            this.Controls.Add(this.tablaNumeros);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmNumerosAleatorios";
            this.Text = "Numeros Aleatorios";
            this.Load += new System.EventHandler(this.FrmNumerosAleatorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NumTextBox txtX0;
        private System.Windows.Forms.Button btnGenerar;
        private NumTextBox txtA;
        private System.Windows.Forms.Label label2;
        private NumTextBox txtC;
        private System.Windows.Forms.Label label3;
        private NumTextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tablaNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeros;
    }
}