using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text =="" || txtContrasena.Text == "")
            {
                MessageBox.Show("Ingresar datos de usuario","Sistema de Control",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                frmMDI formMDI = new frmMDI();
                formMDI.Show();
                
            }
        }
    }
}
