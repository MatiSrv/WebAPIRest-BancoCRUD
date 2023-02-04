using Aplicacion.Datos;

namespace BancoClient.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (HelperDB.GetInstance().Logeo(txtUsuario.Text, txtContraseña.Text) == -1)
            {
                MessageBox.Show("Contraseña y/o usuario incorrecto","ATENCION");
            }
            else
            {
                Main frm = new Main();
                this.Hide();
                frm.ShowDialog();
                frm.StartPosition = FormStartPosition.CenterScreen;

            }
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            VerContra(false);
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            VerContra(true);
        }
        private void VerContra(bool v)
        {
            txtContraseña.UseSystemPasswordChar = v;
            pbOcultar.Visible = !v;
            pbMostrar.Visible = v;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogin1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}