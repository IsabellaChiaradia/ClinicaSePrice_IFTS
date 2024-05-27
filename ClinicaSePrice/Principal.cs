using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard_ClinicaSePrice.pesañas;
using Dashboard_ClinicaSePrice.Pages;
using ClinicaSePrice.Datos;
using ClinicaSePrice.Pages;

namespace Dashboard_ClinicaSePrice
{
    public partial class Principal : Form
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
        //----------------------------SEGUNDA PANTALLA-----------------------------//
        //-------------------------------------------------------------------------//
        // En este sector se encontrara con el codigo de la segunda ventana en la cual prodrá visualizar
        // los distintos botones de interaccion que conforman los PROCESOS requeridos por la cliente, según el análisis 
        //previo, por el momento el unico activo es Gestion de miembros y Pagos y facturacion, es importante mencionar que
        //la sección de gestion de miembros es la que contiene funcionalidad no asi la de pagos y facturacion, debido a que 
        //solo se utilizo para chequear la navegacion interna de paginas dentro del componente contenedor main.
        //A continuación se detalla en el código:
        //-------------------------------------------------------------------------//


        GestionTurnos uc;

        public Principal(string? nombre, string? apellido)
        {
            InitializeComponent();
            lblNombreUser.Text = $"{nombre} {apellido}";
            this.uc = new GestionTurnos();
            this.BackColor = Color.FromArgb(0x49, 0xA2, 0xCB);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        // ---------------------------- FUNCIONES ----------------------------

        private void agregarPaneles(UserControl userControl)
        {
            //Navegacion entre paneles que se encuentra en la carpeta Pages
            pnlContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            agregarPaneles(uc);
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnRegistroTurno_Click(object sender, EventArgs e)
        {
            GestionTurnos uc = new GestionTurnos();
            agregarPaneles(uc);
        }

        private void btnPagoTurno_Click(object sender, EventArgs e)
        {
            PagoAtencionMedica uc = new PagoAtencionMedica();
            agregarPaneles(uc);
        }

        private void btnPagoEstudio_Click(object sender, EventArgs e)
        {
            PagoEstudioClinico uc = new PagoEstudioClinico();
            agregarPaneles(uc);
        }

        private void btnControlinsumos_Click(object sender, EventArgs e)
        {
            CuotasVencidas uc = new CuotasVencidas();
            agregarPaneles(uc);
        }
    }
}