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
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtA = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtG = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK = new SimulacionTP1.Presentacion.ControlesUsuario.NumTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.tablaNumeros = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raíz";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(22, 169);
            this.txtX.MaxLength = 8;
            this.txtX.Name = "txtX";
            this.txtX.ShortcutsEnabled = false;
            this.txtX.Size = new System.Drawing.Size(140, 25);
            this.txtX.TabIndex = 1;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(126, 430);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(153, 43);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(22, 315);
            this.txtA.MaxLength = 8;
            this.txtA.Name = "txtA";
            this.txtA.ShortcutsEnabled = false;
            this.txtA.Size = new System.Drawing.Size(140, 25);
            this.txtA.TabIndex = 4;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constante Multiplicativa (a)";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(207, 169);
            this.txtC.MaxLength = 8;
            this.txtC.Name = "txtC";
            this.txtC.ShortcutsEnabled = false;
            this.txtC.Size = new System.Drawing.Size(140, 25);
            this.txtC.TabIndex = 6;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Constante Aditiva (c)";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(207, 315);
            this.txtM.MaxLength = 8;
            this.txtM.Name = "txtM";
            this.txtM.ShortcutsEnabled = false;
            this.txtM.Size = new System.Drawing.Size(140, 25);
            this.txtM.TabIndex = 8;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Módulo (m)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 369);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(207, 242);
            this.txtG.MaxLength = 8;
            this.txtG.Name = "txtG";
            this.txtG.ShortcutsEnabled = false;
            this.txtG.Size = new System.Drawing.Size(140, 25);
            this.txtG.TabIndex = 16;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Constante (g)";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(22, 242);
            this.txtK.MaxLength = 8;
            this.txtK.Name = "txtK";
            this.txtK.ShortcutsEnabled = false;
            this.txtK.Size = new System.Drawing.Size(140, 25);
            this.txtK.TabIndex = 14;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Constante (k)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMultiplicativo);
            this.groupBox2.Controls.Add(this.rbLineal);
            this.groupBox2.Location = new System.Drawing.Point(20, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método";
            // 
            // rbMultiplicativo
            // 
            this.rbMultiplicativo.AutoSize = true;
            this.rbMultiplicativo.Location = new System.Drawing.Point(25, 56);
            this.rbMultiplicativo.Name = "rbMultiplicativo";
            this.rbMultiplicativo.Size = new System.Drawing.Size(177, 21);
            this.rbMultiplicativo.TabIndex = 11;
            this.rbMultiplicativo.Text = "Congruencial Multiplicativo";
            this.rbMultiplicativo.UseVisualStyleBackColor = true;
            this.rbMultiplicativo.CheckedChanged += new System.EventHandler(this.rbMultiplicativo_CheckedChanged);
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Checked = true;
            this.rbLineal.Location = new System.Drawing.Point(25, 29);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(136, 21);
            this.rbLineal.TabIndex = 10;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Congruencial Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // tablaNumeros
            // 
            this.tablaNumeros.AllowUserToAddRows = false;
            this.tablaNumeros.AllowUserToDeleteRows = false;
            this.tablaNumeros.AllowUserToResizeColumns = false;
            this.tablaNumeros.AllowUserToResizeRows = false;
            this.tablaNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaNumeros.ColumnHeadersHeight = 30;
            this.tablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numeros});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaNumeros.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaNumeros.EnableHeadersVisualStyles = false;
            this.tablaNumeros.Location = new System.Drawing.Point(406, 29);
            this.tablaNumeros.MultiSelect = false;
            this.tablaNumeros.Name = "tablaNumeros";
            this.tablaNumeros.ReadOnly = true;
            this.tablaNumeros.RowHeadersVisible = false;
            this.tablaNumeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaNumeros.Size = new System.Drawing.Size(328, 468);
            this.tablaNumeros.TabIndex = 11;
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
            // FrmNumerosAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 511);
            this.Controls.Add(this.tablaNumeros);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmNumerosAleatorios";
            this.Text = "Numeros Aleatorios";
            this.Load += new System.EventHandler(this.FrmNumerosAleatorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NumTextBox txtX;
        private System.Windows.Forms.Button btnGenerar;
        private NumTextBox txtA;
        private System.Windows.Forms.Label label2;
        private NumTextBox txtC;
        private System.Windows.Forms.Label label3;
        private NumTextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaNumeros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMultiplicativo;
        private System.Windows.Forms.RadioButton rbLineal;
        private NumTextBox txtG;
        private System.Windows.Forms.Label label6;
        private NumTextBox txtK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeros;
    }
}