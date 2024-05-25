using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; //libreria de dibujos
using System.Drawing.Drawing2D;

namespace Dashboard_ClinicaSePrice
{
    //Clases derivadas personalizadas para crear propios componentes costumizados con estilos seleccionados según 
    //el diseño adaptado para la realizacion de la ui del sistema//
    public class Boton : Button
    {
        private int borderZise = 0;
        private int borderRadius = 20;

        public Boton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(0x4A, 0x66, 0xAE);
            this.ForeColor = Color.White;
            this.Padding = new Padding(30, 0, 0, 0); 
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Font = new Font("Avenir Next", 12f, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = GetFigurePath(ClientRectangle, borderRadius);
            this.Region = new Region(path);

            using (Pen pen = new Pen(Color.FromArgb(0x4A, 0x66, 0xAE)))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddLine(rect.X + curveSize, rect.Y, rect.Right, rect.Y);
            path.AddLine(rect.Right, rect.Bottom, rect.X + curveSize, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
