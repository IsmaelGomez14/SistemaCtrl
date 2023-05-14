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

namespace Presentacion.Forms
{
    public partial class frmGestionProducto : Form
    {
        public frmGestionProducto()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            OperacionesForms.LimpiarControles(this);
            txtNombre.Focus();
        }

        private void frmGestionProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
