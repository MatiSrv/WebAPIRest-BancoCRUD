using Aplicacion.Servicios.Implementacion;
using Aplicacion.Servicios.Interfaces;
using Aplicacion.Dominio;
using BancoClient.Client;
using Newtonsoft.Json;
using Aplicacion.Datos.Interfaces;

namespace BancoClient.Presentacion
{

    public partial class FormClientes : Form
    {
        private bool Editar;
        Cliente clienteselct;
        
        public FormClientes()
        {
            InitializeComponent();
            Servicio = new Servicio();
            clienteselct = new Cliente();
            txtID.Enabled = false;


        }
        private IServicio Servicio;
        private async void FormClientes_Load_1(object sender, EventArgs e)
        {
            await CargarClientes();
            HabilitarCampos(false);
            txtID.Enabled = false;
        }
        //private async void FormClientes_Load(object sender, EventArgs e)
        //{
            
        //}

        private async Task CargarClientes()
        {
            dgvClientes.Rows.Clear();
            string url = "https://localhost:7107/api/clientes";
            var data = await ClientSingleton.GetClient().GetAsync(url);
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            List<Cliente> lClientes = lst;

            foreach (Cliente c in lClientes)
            {
                dgvClientes.Rows.Add(c.Id, c.Nombre, c.Apellido, c.Dni);
            }
        }
   
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtNombre.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos(false);
        }
        private void HabilitarCampos(bool v)
        {
            txtApellido.Enabled = v;
            txtDNI.Enabled = v;
            txtNombre.Enabled = v;
            btnAceptar.Enabled = v;
            btnCancelar.Enabled = v;

            btnAgregarCli.Enabled = !v;
            btnEditar.Enabled = !v;
            btnEliminar.Enabled = !v;
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            Editar = false;
            txtDNI.Enabled = true;
            HabilitarCampos(true);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;




            if (dgvClientes.SelectedRows.Count > 0)
            {
                HabilitarCampos(true);
                txtDNI.Enabled = false;
                txtID.Enabled = false;
                txtID.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtDNI.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            }
            else
                MessageBox.Show("Debe Seleccionar un cliente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {
                try
                {
                    int dni = Convert.ToInt32(dgvClientes.CurrentRow.Cells[3].Value.ToString());
                    int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                    var result = await EliminacionCli(dni);
                    if (!Servicio.TieneCuentas(id))
                    {
                        if (result)
                        {
                            await CargarClientes();
                            MessageBox.Show("Cuenta eliminada con exito");
                        }
                    }
                   

                }
                catch (Exception)
                {
                    MessageBox.Show("El cliente aun posee cuentas activas, por favor, primero elimine dichas cuenta");
                }
            }
            else
                MessageBox.Show("Debe Seleccionar un cliente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (Editar == false)
                {
                    clienteselct = new Cliente();
                    clienteselct.Nombre = txtNombre.Text;
                    clienteselct.Apellido = txtApellido.Text;
                    clienteselct.Dni = Convert.ToInt32(txtDNI.Text);

                    var result = await AltaCli(clienteselct);
                    if (result)
                    {
                        await CargarClientes();
                        LimpiarCampos();
                        HabilitarCampos(false);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error >:O"  );

                    }
                }
                 
                if (Editar == true)
                {
                    
                        clienteselct = new Cliente();
                        clienteselct.Id = Convert.ToInt32(txtID.Text);
                        clienteselct.Nombre = txtNombre.Text;
                        clienteselct.Apellido = txtApellido.Text;
                        clienteselct.Dni = Convert.ToInt32(txtDNI.Text);


                        var result = await ModificacionCli(clienteselct);
                        if (result)
                        {
                            await CargarClientes();
                            LimpiarCampos();
                            HabilitarCampos(false);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error >:O");

                       }
                    

                }
            }
        }

        private async Task<bool> AltaCli(Cliente c)
        {
            string url = "https://localhost:7107/api/clientes";
            string ClienteJson = JsonConvert.SerializeObject(c);

            var result = await ClientSingleton.GetClient().PostAsync(url, ClienteJson);
            return result.Equals("true");
        }

            private async Task<bool> ModificacionCli(Cliente c)
            {
                string url = "https://localhost:7107/api/clientes";
                string ClienteJson = JsonConvert.SerializeObject(c);

                var result = await ClientSingleton.GetClient().PutAsync(url, ClienteJson);
                return result.Equals("true");
            }
        private async Task<bool> EliminacionCli(int id)
        {
            string url = "https://localhost:7107/api/clientes/{id}"; 

            var result = await ClientSingleton.GetClient().DeleteAsync(url,id);

            return result.Equals("true");
        }



        /*
         ------------------------------------------------------------------------------------------
        -----------------------------------------VALIDACIONES---------------------------------------
        ------------------------------------------------------------------------------------------
         */

        private bool Validacion()
        {
            if (txtApellido.Text == String.Empty)
            {
                MessageBox.Show("El cliente debe tener un apellido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtDNI.Text == String.Empty)
            {
                MessageBox.Show("El cliente debe tener un numero de DNI", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }
            if (txtNombre.Text == String.Empty) {
                MessageBox.Show("El cliente debe tener un nombre", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsControl(e.KeyChar)||char.IsSeparator(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) )
            {
                return;
            }
            e.Handled = true;
        }

       
    }


}
