using AccesoDB;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAppDiscos
{
    public partial class frmBuscar : Form
    {
        private List<Discos> listaDiscos;
        
        public frmBuscar()
        {
            InitializeComponent();
        }
        private void frmBuscar_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumnas();
        }
        private void cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            Discos selecionado;
            selecionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            if (selecionado == null)
                MessageBox.Show("Seleccione un disco.");
            Form1 vistaPrevia = new Form1(selecionado);
            vistaPrevia.ShowDialog();
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco Agregar = new frmAltaDisco();
            Agregar.ShowDialog();
            cargar();
        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            Discos selecionado;
            selecionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            if (selecionado == null)
                MessageBox.Show("Seleccione un disco.");
            frmAltaDisco Modificar = new frmAltaDisco(selecionado);
            Modificar.ShowDialog();
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void bttEliFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void bttEliLogi_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar (bool logico = false)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos selecionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    selecionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(selecionado.Id);
                    else
                        negocio.eliminar(selecionado.Id);
                    MessageBox.Show("Eliminado");
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
