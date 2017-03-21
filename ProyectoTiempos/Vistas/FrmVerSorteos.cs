using ProyectoTiempos.Controladores;
using ProyectoTiempos.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiempos.Vistas
{
    public partial class FrmVerSorteos : Form
    {
        private DataTable result;
        private Sorteo sorteo;
        private Logica log;
        public FrmVerSorteos()
        {
            InitializeComponent();
            result = new DataTable();
            sorteo = new Sorteo();
            log = new Logica();
            cargarCombo();
           
        }
      
        public void cargarCombo()
        {
            cbSorteo.DataSource = log.cargarCombo();
            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);

            }

          
        }
    }
}
