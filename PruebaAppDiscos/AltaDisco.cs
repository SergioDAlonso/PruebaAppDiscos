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
            try
            {
                
                if (discos == null)
                    discos = new Discos();
                discos.Titulo = txbTitulo.Text;
                discos.FechaLanzamiento = dtFecha.Value;
                discos.CantCanciones = int.Parse(txbCantCanc.Text);
                discos.UrlImagenTapa = txbUrlImagenTapa.Text;
                discos.Estilo = (Estilo)cbxEstilo.SelectedItem;
                discos.TipoEdicion = (TipoEdicion)cbxTipo.SelectedItem;
                
                if (discos.Id != 0)
                {
                    negocio.modificar(discos);
                    MessageBox.Show("Disco Modificado");
                    Close();
                }
                else
                {
                    negocio.agregar(discos);
                    MessageBox.Show("Disco Agregado");
                }
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
                cbxEstilo.ValueMember = "Id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxTipo.DataSource = Tipo.listar();
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";
                
                if (discos != null)
                {
                    txbTitulo.Text = discos.Titulo;
                    dtFecha.Value = discos.FechaLanzamiento;
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

        private void txbUrlImagenTapa_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagenTapa.Text);
        }
    }
}
