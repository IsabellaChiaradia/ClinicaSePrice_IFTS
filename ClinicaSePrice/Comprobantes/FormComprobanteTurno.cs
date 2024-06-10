using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClinicaSePrice.Comprobantes
{
    public partial class FormComprobanteTurno : Form
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string NumSocio { get; set; }
        public string Correo { get; set; }
        public string FechaInscripcion { get; set; }
        //qr

        public FormComprobanteTurno(string nombre, string apellido, string dni, string numSocio, string correo, string fechaInscripcion)

        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.NumSocio = numSocio;
            this.Correo = correo;
            this.FechaInscripcion = fechaInscripcion;
        }

        private void ImprimirCarnet(object o, PrintPageEventArgs e)
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

        private void FormCarnet_Load(object sender, EventArgs e)
        {
            lblNombreSocio.Text = Nombre + " " + Apellido;
            lblDniSocio.Text = DNI;
            lblIDsocio.Text = NumSocio;
            lblMail.Text = Correo;
            lblFecha.Text = FechaInscripcion;


            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(DNI.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(150, 150)));

            pictureQr.BackgroundImage = imagen;
            imagen.Save("imagen.png", ImageFormat.Png);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(74, 102, 174);
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, borderColor, 3, ButtonBorderStyle.Solid,
        borderColor, 3, ButtonBorderStyle.Solid, borderColor, 3, ButtonBorderStyle.Solid, borderColor, 3, ButtonBorderStyle.Solid);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirCarnet);
            btnImprimirCarnet.Visible = false;
            btnVolver.Visible = false;
            pd.Print();
            btnImprimirCarnet.Visible = true;

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }




    }
}
