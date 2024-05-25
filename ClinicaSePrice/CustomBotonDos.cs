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
    public class CustomBotonDos : Button
    {
        
        private int borderRadius = 20;

        public CustomBotonDos()
        {
            this.FlatStyle = FlatStyle.Flat; 
            this.FlatAppearance.BorderSize = 0; 
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(0x60, 0x3D, 0x8C);
            this.ForeColor = Color.White;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Avenir Next", 12f, FontStyle.Bold); 
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
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddLine(rect.Right, rect.Y + curveSize, rect.Right, rect.Bottom - curveSize);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddLine(rect.Right - curveSize, rect.Bottom, rect.X + curveSize, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
