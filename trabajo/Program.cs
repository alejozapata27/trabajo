using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDeCambio
{
    public partial class wCasaDeCambio : Form
    {
        public wCasaDeCambio()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        private void IniciarFormulario()
        {
            try
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";

                #region [llenar combo ciudad]
                cmbCiudad.Items.Clear();
                cmbCiudad.Items.Add("Bogota");
                cmbCiudad.Items.Add("Cali");
                cmbCiudad.Items.Add("Medellin");
                cmbCiudad.Items.Add("Santa Marta");
                #endregion

                #region [llenar combo moneda origen]
                cmbMonedaOrigen.Items.Clear();
                cmbMonedaOrigen.Items.Add("Peso colombiano - COP");
                cmbMonedaOrigen.Items.Add("Dolar Americano - USD");
                cmbMonedaOrigen.Items.Add("Euro - EUR");
                cmbMonedaOrigen.Items.Add("Libra Esterlina - GBP");
                cmbMonedaOrigen.Items.Add("Yuan - CNY");
                #endregion

                #region [llenar combo moneda destino]
                cmbMonedaDestino.Items.Clear();
                cmbMonedaDestino.Items.Add("Peso colombiano - COP");
                cmbMonedaDestino.Items.Add("Dolar Americano - USD");
                cmbMonedaDestino.Items.Add("Euro - EUR");
                cmbMonedaDestino.Items.Add("Libra Esterlina - GBP");
                cmbMonedaDestino.Items.Add("Yuan - CNY");
                #endregion

                rdoEfectivo.Checked = true;

                txtCantidadValorCambiar.Text = "";
                txtValorCanje.Text = "";

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCambiar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: \t" + txtNombre.Text + "\r\n" + "Apellido: \t" + txtApellido.Text + "\r\n" + "Direccion: \t" + txtDireccion.Text + "\r\n" + "Telefono: \t" + txtTelefono.Text + "\r\n" + "Ciudad: \t" + cmbCiudad.Text + "\r\n" + "Moneda origen: \t" + cmbMonedaOrigen.Text + "\r\n" + "Moneda destino: \t" + cmbMonedaDestino.Text + "\r\n");
            MessageBox.Show("Resultado: \t" + grpResultado);

            Double a = Convert.ToDouble(txtCantidadValorCambiar.Text);
            Double b = Convert.ToDouble(txtValorCanje.Text);
            Double r = a * b;
            grpResultado.Text = r.ToString();
        }


    }
}
