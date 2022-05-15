using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI_ITSAV_UA_LERDO
{
    public partial class CoordinaciónIngresosPropiosServiciosEscolares : Form
    {
        public CoordinaciónIngresosPropiosServiciosEscolares()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoordinaciónIngresosPropiosServiciosEscolares_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.sCIDataSet.Articulos);

        }
    }
}
