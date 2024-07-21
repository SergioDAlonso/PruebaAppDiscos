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
using AccesoDB;
using static System.Net.Mime.MediaTypeNames;

namespace PruebaAppDiscos
{
    public partial class frmAltaDisco : Form
    {
        private Discos discos = null;
        public frmAltaDisco()
        {
            InitializeComponent();
        }
        public frmAltaDisco (Discos discos)
        {
            InitializeComponent();
            this.discos = discos;
            Text = "Modificar";
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos nuevo = new Discos();
            try
            {
                nuevo.Id = int.Parse(txbNumero.Text);
                nuevo.Titulo = txbTitulo.Text;
                nuevo.FechaLanzamiento = DateTime.Parse(txbFecha.Text);
                nuevo.CantCanciones = int.Parse(txbCantCanc.Text);
                nuevo.UrlImagenTapa = txbUrlImagenTapa.Text;

                negocio.agregar(nuevo);
                MessageBox.Show("Disco Agregado");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estilo = new EstiloNegocio();
            TipoEdicionNegocio Tipo = new TipoEdicionNegocio();
            try
            {
                cbxEstilo.DataSource = estilo.listar();
                cbxEstilo.ValueMember = "id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxTipo.DataSource = Tipo.listar();
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

                throw ex;
            }
        }
        private void cargarImagen(string Imagen)
        {
            try
            {
                pcbTapa.Load(Imagen);
            }
            catch (Exception)
            {
                pcbTapa.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");

            }
        }
    }
}
