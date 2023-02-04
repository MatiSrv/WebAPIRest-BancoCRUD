using Aplicacion.Servicios.Implementacion;
using Aplicacion.Servicios.Interfaces;
using Aplicacion.Dominio;
using System.Data;
using BancoClient.Client;
using Newtonsoft.Json;

namespace BancoClient.Presentacion
{
    public partial class FormCuentas : Form
    {
        public FormCuentas()
        {
            InitializeComponent();
            Servicio = new Servicio();

        }
        private IServicio Servicio;
       // private bool Editar;

        private async void FormCuentas_Load(object sender, EventArgs e)
        {
            await CargarCuentas();
            await CargarCboCli(cboCliente);
            await CargarCboCli(cboBuscarCli);
            Habilitar(true);
            LimpiarCampos();
            IniciarFiltros();
        }

        private async Task CargarCuentas()
        {
            dgvCuentas.Rows.Clear();
            string url = "https://localhost:7107/api/cuentas";
            var data = await ClientSingleton.GetClient().GetAsync(url);
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(data);
            List<Cuenta> lcuentas = lst;

            foreach (Cuenta c in lcuentas)
            {
                dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
            }
        }
        private async Task CargarCboCli(ComboBox comboBox)
        {
            string url = "https://localhost:7107/api/clientes";
            var data = await ClientSingleton.GetClient().GetAsync(url);
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(data);

            comboBox.DataSource = lst;
            comboBox.DisplayMember = "NombreCompleto";
            comboBox.ValueMember = "Id";
        }


        private void Habilitar(bool v)
        {
            btnAgregarCta.Enabled = v;

            btnEliminar.Enabled = v;

            btnCancelar.Enabled = !v;
            txtCBU.Enabled = !v;
            txtSaldo.Enabled = !v;
            cboCliente.Enabled = !v;
            cboTipoCuenta.Enabled = !v;
            dtpFecha.Enabled = !v;
            btnAgregar.Enabled = !v;
            btnGenerar.Enabled = !v;
        }
        private void LimpiarCampos()
        {
            txtCBU.Clear();
            txtSaldo.Clear();
            txtSaldo.Text = ",00";
            cboCliente.SelectedIndex = 0;
            cboTipoCuenta.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
        }
        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UltimoMov_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCta_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarCampos();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidacionCampos())
            {
                Habilitar(true);

                Cuenta c = new Cuenta();
                AbstraerCuenta(c);
                bool result = await AltaCta(c);
                if (result)
                {
                    await CargarCuentas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
              
            }
        }
        private async Task<bool> AltaCta(Cuenta c)
        {
            string url = "https://localhost:7107/api/cuentas";
            string CuentaJson = JsonConvert.SerializeObject(c);

            var result = await ClientSingleton.GetClient().PostAsync(url, CuentaJson);
            return result.Equals("true");
        }

        private bool ValidacionCampos()
        {
            if (txtCBU.Text == String.Empty)
            {
                MessageBox.Show("La cuenta debe tener un CBU", "Registro de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtSaldo.Text == String.Empty)
            {
                MessageBox.Show("La cuenta debe tener un CBU", "Registro de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void AbstraerCuenta(Cuenta c)
        {
            long cbu;
            double saldo;

            cbu = Convert.ToInt64(txtCBU.Text);
            saldo = Convert.ToDouble(txtSaldo.Text);
            c.Cbu = cbu;
            c.Saldo = saldo;
            c.CodTipoCuenta = cboTipoCuenta.SelectedIndex + 1;
            c.UltimoMovimiento = dtpFecha.Value;
            Cliente cliente = (Cliente)cboCliente.SelectedItem;
            c.CodCli = cliente.Id;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count > 0)
            {
                int cod = Convert.ToInt32(dgvCuentas.CurrentRow.Cells[0].Value);
                //Servicio.BajaCuenta(cod);
                var result = await EliminacionCta(cod);
                if (result)
                {
                    await CargarCuentas();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error >:o");
                }
            }
            else
                MessageBox.Show("Debe Seleccionar una cuenta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private async Task<bool> EliminacionCta(int cod)
        {
            string url = "https://localhost:7107/api/cuentas/";

            var result = await ClientSingleton.GetClient().DeleteAsyncCta(url, cod);

            return result.Equals("true");
         }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var number = string.Concat(Enumerable.Range(0, 15).Select(x => random.Next(0, 10)));
            txtCBU.Clear();
            txtCBU.Text = number;
        }

        private void cboBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cboBuscar.Text == "Tipo de Cuenta")
            {
                cboBuscarTipoCuenta.Visible = true;
                cboBuscarCli.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
            }
            if (cboBuscar.Text == "Cliente")
            {
                cboBuscarCli.Visible = true;
                cboBuscarTipoCuenta.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
            }
            if (cboBuscar.Text == "Fecha de Movimientos")
            {

                lblDesde.Visible = true;
                lblHasta.Visible = true;
                dtpDesde.Visible = true;
                dtpHasta.Visible = true;
                cboBuscarTipoCuenta.Visible = false;
                cboBuscarCli.Visible = false;
            }

        }
        private void IniciarFiltros()
        {
            cboBuscarCli.Visible = false;
            cboBuscarTipoCuenta.Visible = false;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (cboBuscar.Text == "Tipo de Cuenta")
                {
                    string tc = cboBuscarTipoCuenta.Text;
                    dgvCuentas.Rows.Clear();
                    List<Cuenta> lcuentas = await CargarCuentasTC(tc);
                    foreach (Cuenta c in lcuentas)
                    {
                        dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
                    }
                }
                if (cboBuscar.Text == "Cliente")
                {
                    dgvCuentas.Rows.Clear();


                    Cliente cli = (Cliente)cboBuscarCli.SelectedItem;
                    List<Cuenta> lcuentas = await CargarCuentasCli(cli.Dni);
                    foreach (Cuenta c in lcuentas)
                    {
                        dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
                    }
                }
                if (cboBuscar.Text == "Fecha de Movimientos")
                {
                    dgvCuentas.Rows.Clear();

                    DateTime desde = dtpDesde.Value;
                    DateTime hasta = dtpHasta.Value;
                    
                    List<Cuenta> lcuentas = await CargarCuentasFec(desde, hasta);
                    foreach (Cuenta c in lcuentas)
                    {
                        dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
                    }
                }
            }

        }

        private async Task<List<Cuenta>> CargarCuentasTC(string tc)
        {
            dgvCuentas.Rows.Clear();
            string url = "https://localhost:7107/api/cuentas/tipocuenta?tc="+tc;
            var data = await ClientSingleton.GetClient().GetAsync(url);
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(data);
            List<Cuenta> lcuentas = lst;

            return lst;
        }
        private async Task<List<Cuenta>> CargarCuentasCli(int dni)
        {
            dgvCuentas.Rows.Clear();
            string url = "https://localhost:7107/api/cuentas/cliente?dni="+dni;
            var data = await ClientSingleton.GetClient().GetAsync(url);
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(data);
            List<Cuenta> lcuentas = lst;

            return lst;
        }
        private async Task<List<Cuenta>> CargarCuentasFec(DateTime desde, DateTime hasta)
        {
            dgvCuentas.Rows.Clear();

            string url = "https://localhost:7107/api/cuentas/fechas?desde=" + desde.ToString("dd/MM/yyyy")+"&hasta="+hasta.ToString("dd/MM/yyyy");
            var data = await ClientSingleton.GetClient().GetAsync(url);
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(data);
            List<Cuenta> lcuentas = lst;

            return lst;
        }
        private bool Validacion()
        {
            if (cboBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro", "Busqueda de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboBuscar.SelectedIndex > -1 && cboBuscarCli.SelectedIndex == -1 && !cboTipoCuenta.Enabled)
            {
                MessageBox.Show("Seleccione un Cliente", "Busqueda de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboBuscar.SelectedIndex > -1 && cboBuscarTipoCuenta.SelectedIndex == -1 && !cboBuscarCli.Enabled)
            {
                MessageBox.Show("Seleccione un tipo de cuenta", "Busqueda de cuentas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;

        }

        private async void LimpiarFiltro_Click(object sender, EventArgs e)
        {
            cboBuscar.SelectedIndex = -1;
            cboBuscarCli.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            cboBuscarCli.Visible = false;
            cboBuscarTipoCuenta.Visible = false;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
            dgvCuentas.Rows.Clear();
             await CargarCuentas();
        }

        private void cboBuscarCli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
