
namespace Presentacion.Forms
{
    partial class frmListaValores
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
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlPaginado = new System.Windows.Forms.Panel();
            this.btnPaginadoPrimero = new System.Windows.Forms.Button();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.btnPaginadoAnterior = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaginadoSiguiente = new System.Windows.Forms.Button();
            this.lblNumPagina = new System.Windows.Forms.Label();
            this.btnPaginadoUltimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPadres = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.txtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlPaginado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadres)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1085, 115);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(93, 39);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 116);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 39);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlPaginado
            // 
            this.pnlPaginado.Controls.Add(this.btnPaginadoPrimero);
            this.pnlPaginado.Controls.Add(this.lblTotalPaginas);
            this.pnlPaginado.Controls.Add(this.btnPaginadoAnterior);
            this.pnlPaginado.Controls.Add(this.label3);
            this.pnlPaginado.Controls.Add(this.btnPaginadoSiguiente);
            this.pnlPaginado.Controls.Add(this.lblNumPagina);
            this.pnlPaginado.Controls.Add(this.btnPaginadoUltimo);
            this.pnlPaginado.Controls.Add(this.label1);
            this.pnlPaginado.Location = new System.Drawing.Point(21, 474);
            this.pnlPaginado.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPaginado.Name = "pnlPaginado";
            this.pnlPaginado.Size = new System.Drawing.Size(1157, 47);
            this.pnlPaginado.TabIndex = 9;
            // 
            // btnPaginadoPrimero
            // 
            this.btnPaginadoPrimero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaginadoPrimero.Location = new System.Drawing.Point(865, 4);
            this.btnPaginadoPrimero.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaginadoPrimero.Name = "btnPaginadoPrimero";
            this.btnPaginadoPrimero.Size = new System.Drawing.Size(63, 31);
            this.btnPaginadoPrimero.TabIndex = 2;
            this.btnPaginadoPrimero.Text = "<<";
            this.btnPaginadoPrimero.UseVisualStyleBackColor = false;
            this.btnPaginadoPrimero.Click += new System.EventHandler(this.btnPaginadoPrimero_Click);
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.Location = new System.Drawing.Point(191, 11);
            this.lblTotalPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(29, 20);
            this.lblTotalPaginas.TabIndex = 3;
            this.lblTotalPaginas.Text = "10";
            // 
            // btnPaginadoAnterior
            // 
            this.btnPaginadoAnterior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaginadoAnterior.Location = new System.Drawing.Point(936, 4);
            this.btnPaginadoAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaginadoAnterior.Name = "btnPaginadoAnterior";
            this.btnPaginadoAnterior.Size = new System.Drawing.Size(63, 31);
            this.btnPaginadoAnterior.TabIndex = 2;
            this.btnPaginadoAnterior.Text = "<";
            this.btnPaginadoAnterior.UseVisualStyleBackColor = false;
            this.btnPaginadoAnterior.Click += new System.EventHandler(this.btnPaginadoAnterior_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "de";
            // 
            // btnPaginadoSiguiente
            // 
            this.btnPaginadoSiguiente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaginadoSiguiente.Location = new System.Drawing.Point(1007, 4);
            this.btnPaginadoSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaginadoSiguiente.Name = "btnPaginadoSiguiente";
            this.btnPaginadoSiguiente.Size = new System.Drawing.Size(63, 31);
            this.btnPaginadoSiguiente.TabIndex = 2;
            this.btnPaginadoSiguiente.Text = ">";
            this.btnPaginadoSiguiente.UseVisualStyleBackColor = false;
            this.btnPaginadoSiguiente.Click += new System.EventHandler(this.btnPaginadoSiguiente_Click);
            // 
            // lblNumPagina
            // 
            this.lblNumPagina.AutoSize = true;
            this.lblNumPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPagina.Location = new System.Drawing.Point(87, 11);
            this.lblNumPagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPagina.Name = "lblNumPagina";
            this.lblNumPagina.Size = new System.Drawing.Size(19, 20);
            this.lblNumPagina.TabIndex = 3;
            this.lblNumPagina.Text = "0";
            // 
            // btnPaginadoUltimo
            // 
            this.btnPaginadoUltimo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaginadoUltimo.Location = new System.Drawing.Point(1077, 4);
            this.btnPaginadoUltimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaginadoUltimo.Name = "btnPaginadoUltimo";
            this.btnPaginadoUltimo.Size = new System.Drawing.Size(63, 31);
            this.btnPaginadoUltimo.TabIndex = 2;
            this.btnPaginadoUltimo.Text = ">>";
            this.btnPaginadoUltimo.UseVisualStyleBackColor = false;
            this.btnPaginadoUltimo.Click += new System.EventHandler(this.btnPaginadoUltimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Página";
            // 
            // dgvPadres
            // 
            this.dgvPadres.AllowUserToAddRows = false;
            this.dgvPadres.AllowUserToDeleteRows = false;
            this.dgvPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvPadres.Location = new System.Drawing.Point(21, 162);
            this.dgvPadres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPadres.MultiSelect = false;
            this.dgvPadres.Name = "dgvPadres";
            this.dgvPadres.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPadres.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPadres.RowHeadersVisible = false;
            this.dgvPadres.RowHeadersWidth = 51;
            this.dgvPadres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPadres.Size = new System.Drawing.Size(1157, 304);
            this.dgvPadres.TabIndex = 8;
            this.dgvPadres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadres_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtFiltroNombre);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.txtFiltroCodigo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1157, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(276, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(273, 49);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(392, 22);
            this.txtFiltroNombre.TabIndex = 5;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(72, 21);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(73, 21);
            this.rbNombre.TabIndex = 4;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Código";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // txtFiltroCodigo
            // 
            this.txtFiltroCodigo.Location = new System.Drawing.Point(69, 49);
            this.txtFiltroCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroCodigo.Name = "txtFiltroCodigo";
            this.txtFiltroCodigo.Size = new System.Drawing.Size(155, 22);
            this.txtFiltroCodigo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1032, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 53);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "Id";
            this.clmId.HeaderText = "Id";
            this.clmId.MinimumWidth = 6;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            this.clmId.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Codigo";
            this.Column3.HeaderText = "Código";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nombre";
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descripcion";
            this.Column2.HeaderText = "Descripcion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Estado";
            this.Column4.HeaderText = "Estado";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 80;
            // 
            // frmListaValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 537);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlPaginado);
            this.Controls.Add(this.dgvPadres);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaValores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Valores";
            this.Load += new System.EventHandler(this.frmListaValores_Load);
            this.pnlPaginado.ResumeLayout(false);
            this.pnlPaginado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadres)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlPaginado;
        private System.Windows.Forms.Button btnPaginadoPrimero;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Button btnPaginadoAnterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPaginadoSiguiente;
        private System.Windows.Forms.Label lblNumPagina;
        private System.Windows.Forms.Button btnPaginadoUltimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPadres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.TextBox txtFiltroCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}