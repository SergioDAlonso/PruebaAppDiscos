using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoDB;


namespace PruebaAppDiscos
{
    public partial class Form1 : Form
    {
        private Discos discos = null;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Discos discos)
        {
            InitializeComponent();
            this.discos = discos;
            Text = "Vista Previa";
        }

        private void abrirBuscar()
        {
            frmBuscar ventana = new frmBuscar();
            ventana.ShowDialog();
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            abrirBuscar();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            EstiloNegocio estilo = new EstiloNegocio();
            TipoEdicionNegocio tipo = new TipoEdicionNegocio(); 

            try
            {
                cbxEstilo.DataSource = estilo.listar();
                cbxEstilo.ValueMember = "Id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxTipo.DataSource = tipo.listar();
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";

                if (discos != null)
                {
                    txbNumero.Text = discos.Id.ToString();
                    txbTitulo.Text = discos.Titulo;
                    txbFecha.Text = discos.FechaLanzamiento.ToString();
                    txbCantCanc.Text = discos.CantCanciones.ToString();
                    txbUrlImagenTapa.Text = discos.UrlImagenTapa;
                    cargarImagen(discos.UrlImagenTapa);
                    cbxEstilo.SelectedValue = discos.Estilo.Id;
                    cbxTipo.SelectedValue = discos.TipoEdicion.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbTapa.Load(imagen);
            }
            catch (Exception)
            {
                pcbTapa.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacte a mantenimiento. Disculpe las molestias.");
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirBuscar();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            abrirBuscar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDisco Agregar = new frmAltaDisco();
            Agregar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione el Disco a modificar.");
            abrirBuscar();
        }

        private void eliminarLogicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione el Disco a eliminar.");
            abrirBuscar();
        }
    }
}

