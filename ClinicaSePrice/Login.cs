using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
//----------------------------PRIMERA PANTALLA-----------------------------//
//-------------------------------------------------------------------------//
// En este sector se encontrara con el codigo de la primera ventana que prodrá visualizar
// antes de seguir avanzando es importante chequear la carpeta "Datos" ya que la misma contiene
//la programacion necesario para la conexion a la BD y el registro del administrador para su ingreso
//posteriormente el evento del boton es quien ejecuta el ingreso del admin.
//Aqui se podra observar ademas, eventos de limpieza de textbox como de ocultar la contraseña.
//-------------------------------------------------------------------------//
namespace Dashboard_ClinicaSePrice

{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void Login_Shown(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPassword.Text;

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            ClinicaSePrice.Datos.Usuario dato = new ClinicaSePrice.Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(usuario, password);//Se activa el metodo de la clase Usuario instanciada como dato, recordar que
            //este metodo activa el procedimiento almacenado "IngresoLogin"
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                string nombre = tablaLogin.Rows[0]["Nombre"].ToString();
                string apellido = tablaLogin.Rows[0]["Apellido"].ToString();

                MessageBox.Show($"Bienvenido, {nombre} {apellido}", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Principal dashboardForm = new Principal(nombre, apellido);
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ---------------------------- EVENTOS DE TEXTBOX ----------------------------

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}