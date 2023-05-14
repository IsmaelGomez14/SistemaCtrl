using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion.Forms
{
    public partial class frmListaValores : Form
    {
        LogicGenerica generica = new LogicGenerica();
        LogicListaValoresCabecera logic = new LogicListaValoresCabecera();

        int paginaActual = 1;
        int ultimaPagina = 0;
        int registrosPagina = 10;
        double totalPaginas = 0;
        int totalRegistros = 0;

        public frmListaValores()
        {
            InitializeComponent();



            DataGridViewButtonColumn clmDetalle = new DataGridViewButtonColumn()
            {
                Name = "clmDetalle",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true,
                Text = "Detalle",
                Width = 50,
                HeaderText = "Detalle"
            };
            clmDetalle.CellTemplate.Style.BackColor = Color.AliceBlue;
            clmDetalle.CellTemplate.Style.SelectionBackColor = Color.CadetBlue;

            DataGridViewButtonColumn clmEdit = new DataGridViewButtonColumn()
            {
                Name = "clmEditar",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true,
                Text = "Editar",
                Width = 50,
                HeaderText = "Editar"
            };
            clmEdit.CellTemplate.Style.BackColor = Color.AliceBlue;
            clmEdit.CellTemplate.Style.SelectionBackColor = Color.CadetBlue;

            DataGridViewButtonColumn clmEliminar = new DataGridViewButtonColumn()
            {
                Name = "clmEliminar",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true,
                Text = "Eliminar",
                Width = 50,
                HeaderText = "Eliminar"
            };
            clmEliminar.CellTemplate.Style.BackColor = Color.AliceBlue;
            clmEliminar.CellTemplate.Style.SelectionBackColor = Color.CadetBlue;

            dgvPadres.Columns.Add(clmDetalle);
            dgvPadres.Columns.Add(clmEliminar);
            dgvPadres.Columns.Add(clmEdit);

            dgvPadres.Columns["clmEditar"].DisplayIndex = 1;
            dgvPadres.Columns["clmEliminar"].DisplayIndex = 2;
            dgvPadres.Columns["clmDetalle"].DisplayIndex = 3;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionListaValoresCabecera form = new frmGestionListaValoresCabecera(0);
            form.ShowDialog();
            paginaActual = 1;
            CargarDatos(paginaActual, registrosPagina);
        }

        private void frmListaValores_Load(object sender, EventArgs e)
        {
            CargarDatos(paginaActual, registrosPagina);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            CargarDatos(paginaActual, registrosPagina);
        }


        void CargarDatos(int pagina, int registros)
        {
            ListaValoresCabecera filtro = new ListaValoresCabecera();
    

                 filtro = new ListaValoresCabecera()
                {
                    Codigo = txtFiltroCodigo.Text.ToUpper(),
                    Nombre = txtFiltroNombre.Text.ToUpper()
                };

            dgvPadres.DataSource = logic.Paginacion(pagina, registros, filtro,out totalRegistros);

            totalPaginas = (int)Math.Ceiling(Decimal.Parse(totalRegistros.ToString()) / Decimal.Parse(registrosPagina.ToString()));
            ultimaPagina = (int)totalPaginas;

            lblNumPagina.Text = paginaActual.ToString();
            lblTotalPaginas.Text = totalPaginas.ToString();
        }

        private void btnPaginadoPrimero_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            CargarDatos(paginaActual, registrosPagina);
        }

        private void btnPaginadoUltimo_Click(object sender, EventArgs e)
        {
            paginaActual =(int) totalPaginas;
            CargarDatos(ultimaPagina, registrosPagina);
        }

        private void btnPaginadoAnterior_Click(object sender, EventArgs e)
        {
            if(paginaActual > 1)
            {
                paginaActual = paginaActual - 1;
                CargarDatos(paginaActual, registrosPagina);
            }
        }

        private void btnPaginadoSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual = paginaActual + 1;
                CargarDatos(paginaActual, registrosPagina);
            }
        }

        private void dgvPadres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPadres.Columns[e.ColumnIndex].Name == "clmEditar" && e.RowIndex >= 0)
            {

                int idValor = int.Parse( dgvPadres.Rows[e.RowIndex].Cells["clmId"].Value.ToString());

                frmGestionListaValoresCabecera form = new frmGestionListaValoresCabecera(idValor);
                form.ShowDialog();

                paginaActual = 1;
                CargarDatos(paginaActual, registrosPagina);


            }
            else if (dgvPadres.Columns[e.ColumnIndex].Name == "clmEliminar" &&  e.RowIndex >= 0)
            {
                int idValor = int.Parse(dgvPadres.Rows[e.RowIndex].Cells["clmId"].Value.ToString());

                if(idValor > 0)
                {
                    if (logic.Eliminar(idValor))
                    {
                        MessageBox.Show("Datos Eliminados", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    paginaActual = 1;
                    CargarDatos(paginaActual, registrosPagina);
                }


            }
            else if (dgvPadres.Columns[e.ColumnIndex].Name == "clmDetalle" &&  e.RowIndex >= 0)
            {
                MessageBox.Show("Detalle");
            }
        }
    }
}
