
namespace Presentacion.Forms
{
    partial class frmGeneraCodigo
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEntidad = new System.Windows.Forms.RadioButton();
            this.rbDAO = new System.Windows.Forms.RadioButton();
            this.rbSP = new System.Windows.Forms.RadioButton();
            this.txtResultCodigo = new System.Windows.Forms.TextBox();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(38, 346);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 35);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSP);
            this.groupBox1.Controls.Add(this.rbDAO);
            this.groupBox1.Controls.Add(this.rbEntidad);
            this.groupBox1.Location = new System.Drawing.Point(38, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigos disponibles";
            // 
            // rbEntidad
            // 
            this.rbEntidad.AutoSize = true;
            this.rbEntidad.Checked = true;
            this.rbEntidad.Location = new System.Drawing.Point(46, 52);
            this.rbEntidad.Name = "rbEntidad";
            this.rbEntidad.Size = new System.Drawing.Size(77, 21);
            this.rbEntidad.TabIndex = 0;
            this.rbEntidad.TabStop = true;
            this.rbEntidad.Text = "Entidad";
            this.rbEntidad.UseVisualStyleBackColor = true;
            // 
            // rbDAO
            // 
            this.rbDAO.AutoSize = true;
            this.rbDAO.Location = new System.Drawing.Point(46, 104);
            this.rbDAO.Name = "rbDAO";
            this.rbDAO.Size = new System.Drawing.Size(59, 21);
            this.rbDAO.TabIndex = 1;
            this.rbDAO.Text = "DAO";
            this.rbDAO.UseVisualStyleBackColor = true;
            // 
            // rbSP
            // 
            this.rbSP.AutoSize = true;
            this.rbSP.Location = new System.Drawing.Point(46, 156);
            this.rbSP.Name = "rbSP";
            this.rbSP.Size = new System.Drawing.Size(132, 21);
            this.rbSP.TabIndex = 2;
            this.rbSP.Text = "Store procedure";
            this.rbSP.UseVisualStyleBackColor = true;
            // 
            // txtResultCodigo
            // 
            this.txtResultCodigo.Location = new System.Drawing.Point(373, 63);
            this.txtResultCodigo.Multiline = true;
            this.txtResultCodigo.Name = "txtResultCodigo";
            this.txtResultCodigo.Size = new System.Drawing.Size(659, 401);
            this.txtResultCodigo.TabIndex = 3;
            // 
            // cbTablas
            // 
            this.cbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(38, 54);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(304, 24);
            this.cbTablas.TabIndex = 4;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(471, 26);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(92, 31);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(373, 30);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 27);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGeneraCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 476);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.txtResultCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerar);
            this.Name = "frmGeneraCodigo";
            this.Text = "frmGeneraCodigo";
            this.Load += new System.EventHandler(this.frmGeneraCodigo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSP;
        private System.Windows.Forms.RadioButton rbDAO;
        private System.Windows.Forms.RadioButton rbEntidad;
        private System.Windows.Forms.TextBox txtResultCodigo;
        private System.Windows.Forms.ComboBox cbTablas;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}