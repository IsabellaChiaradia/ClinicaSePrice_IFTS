using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_ClinicaSePrice
{
    //Clases derivadas personalizadas para crear propios componentes costumizados con estilos seleccionados según 
    //el diseño adaptado para la realizacion de la ui del sistema//
    public class CustomPanel  :  Panel
    {
        public CustomPanel()
        {
            //this.BorderStyle = BorderStyle.None;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            using (Pen pen = new Pen(Color.White, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}
