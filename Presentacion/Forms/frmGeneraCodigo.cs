using Logica;
using Presentacion.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class frmGeneraCodigo : Form
    {
        LogicGenerica generica = new LogicGenerica();

        public frmGeneraCodigo()
        {
            InitializeComponent();
            OperacionesForms.PropiedadesForm(this);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string queGenerar = "E";
            if (rbEntidad.Checked)
                queGenerar = "E";
            if (rbDAO.Checked)
                queGenerar = "DAO";
            if (rbSP.Checked)
                queGenerar = "SP";
            string code =   generica.ObtenerCodigoEntidad(cbTablas.Text.ToUpper(),queGenerar);
            txtResultCodigo.Text = code;
            txtResultCodigo.ScrollBars = ScrollBars.Both;
        }

        private void frmGeneraCodigo_Load(object sender, EventArgs e)
        {
            cbTablas.DataSource = generica.ListarTablas();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if(txtResultCodigo.Text.Length > 5)
            Clipboard.SetText(txtResultCodigo.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo para seleccionar la ubicación del archivo
            SaveFileDialog dialogGuardar = new SaveFileDialog();
            dialogGuardar.Filter = "Clase de CSharp (*.cs)|*.cs";
            if (dialogGuardar.ShowDialog() == DialogResult.OK)
            {
                // Guardar el contenido del TextBox en el archivo seleccionado
                string rutaArchivo = dialogGuardar.FileName;
                string contenidoArchivo = txtResultCodigo.Text;
                File.WriteAllText(rutaArchivo, contenidoArchivo);
            }
        }
    }
}
