using ClinicaSePrice.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Pages
{
    public partial class HonorariosMedicos : UserControl
    {
        public HonorariosMedicos()
        {
            InitializeComponent();
        }

        private void HonorariosMedicos_Load(object sender, EventArgs e)
        {
            cargarTipoLiquidacion();
        }

        public class TipoLiquidacion
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public TipoLiquidacion(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }
        }

        // Luego, en tu método cargarTipoLiquidacion
        private void cargarTipoLiquidacion()
        {
            var tiposLiquidacion = new List<TipoLiquidacion>
    {
            new TipoLiquidacion(0, "Seleccione Liquidación"),
            new TipoLiquidacion(1, "Diaria"),
            new TipoLiquidacion(2, "Semanal"),
            new TipoLiquidacion(3, "Mensual")
    };

            cmbTipoLiquidacion.DisplayMember = "Nombre";
            cmbTipoLiquidacion.ValueMember = "Id";
            cmbTipoLiquidacion.DataSource = tiposLiquidacion;

            cmbTipoLiquidacion.SelectedIndex = 0;
        }

        
    }
}
