using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Utils;
using Entidad;
using Logica;

namespace Presentacion.Forms
{
    public partial class frmGestionListaValoresCabecera : Form
    {
        private int idValor = 0;
        LogicListaValoresCabecera logic = new LogicListaValoresCabecera();
        public frmGestionListaValoresCabecera( int id)
        {
            InitializeComponent();
            OperacionesForms.PropiedadesForm(this);
            idValor = id;
        }

        private void frmGestionListaValoresCabecera_Load(object sender, EventArgs e)
        {
            if(idValor > 0)
            {
                ListaValoresCabecera obj = logic.Obtener(idValor);
                if(obj != null)
                {
                    txtCodigo.Text = obj.Codigo;
                    txtNombre.Text = obj.Nombre;
                    txtDescripcion.Text = obj.Descripcion;
                    chbEstado.Checked = obj.Estado;
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            OperacionesForms.LimpiarControles(this);
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            ListaValoresCabecera obj = new ListaValoresCabecera()
            {
                Codigo = txtCodigo.Text.ToUpper(),
                Nombre = txtNombre.Text.ToUpper(),
                Descripcion = txtDescripcion.Text.ToUpper(),
                Estado = chbEstado.Checked
            };

            if (idValor == 0)
            {
                if (logic.Insertar(obj))
                {
                    MessageBox.Show("Datos registrados", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OperacionesForms.LimpiarControles(this);
                    txtCodigo.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar datos", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                obj.Id = idValor;
                if (logic.Actualizar(obj))
                {
                    MessageBox.Show("Datos actualizados", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OperacionesForms.LimpiarControles(this);
                    txtCodigo.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar datos", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            


        }
    }
}
