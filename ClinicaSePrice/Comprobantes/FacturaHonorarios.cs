using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Comprobantes
{
    public partial class frmFacturaHonorarios : Form
    {
        public string? nombre;
        public string? apellido;
        public string? dni;
        public string? fechaPago;
        public string? monto;
        public string? especialidad;
        public string? cantTurnos;
        public frmFacturaHonorarios()
        {
            InitializeComponent();
        }

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
        private void frmFacturaHonorarios_Load(object sender, EventArgs e)
        {
            lblNombreApe.Text = nombre + " " + apellido;
            lblDNI.Text = dni;
            lblEspecialidad.Text = especialidad;
            lblFechaPago.Text = fechaPago;
            lblCantTurnos.Text = cantTurnos;
            lblMonto.Text = monto;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void lblClinicaSePrice2_Click(object sender, EventArgs e)
        {

        }
    }

}
