using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace BancoClient.Presentacion
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }
        //VER QUE ONDA EL ELIMINAR DE CLIENTES

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int Wmsg, int wParam,int IParam);

        Form FormActual;
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximize.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaximize.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormClientes());
        }

        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCuentas());
        }

        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(Formhijo);
            panelContenedor.Tag = Formhijo;
            
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        private void LogoBanco_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Remove(FormActual);
        }

        
        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dddd d MMMM yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir del programa?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
