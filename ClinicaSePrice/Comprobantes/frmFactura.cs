using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Comprobantes
{
    public partial class frmFactura : Form
    {

        public string? nombre;
        public string? apellido;
        public string? dni;
        public string? fechaPago;
        public string? fechaVenc;
        public string? formaDePago;
        public string? monto;
        public string? tipoMiembro;
        public string? actividad;
        public string? interes;


        public frmFactura()
        {
            InitializeComponent();
        }

        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblNombreApe.Text = nombre + " " + apellido;
            lblDNI.Text = dni;
            lblFechaPago.Text = fechaPago;
            lblFechaVenc.Text = fechaVenc;
            lblMonto.Text = monto;
            lblFormaPago.Text = formaDePago;
            lblCaracter.Text = tipoMiembro;
            lblActividad.Text = actividad;
            lblInteres.Text = interes;

            if (string.IsNullOrWhiteSpace(actividad))
            {
                lblActividad.Hide();
                lblTituloActividad.Hide();
            }
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            btnImprimirFactura.Visible = false;
            btnVolver.Visible = false;
            pd.Print();
            btnImprimirFactura.Visible = true;

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
