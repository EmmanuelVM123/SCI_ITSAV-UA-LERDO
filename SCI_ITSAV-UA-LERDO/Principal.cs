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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        private void PersonalizarDiseño()
        {
            subMenu.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
             
        }

        private void OcultarSubMenus()
        {
            if (subMenu.Visible == false)
                subMenu.Visible = false;
            if (panel1.Visible == false)
                panel1.Visible = false;
            if (panel2.Visible == false)
                panel2.Visible=false;                        
        }
        
        private void MostrarSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;  
            }
            else 
                subMenu.Visible = false;

        }

        private void btnInventarioAreas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new CoordinaciónIngresosPropiosServiciosEscolares());

            OcultarSubMenus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel2);
        }
        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFomularioHijo.Controls.Add(formularioHijo);
            panelFomularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ServiciosGenerales());

            OcultarSubMenus();
        }
    }
}
