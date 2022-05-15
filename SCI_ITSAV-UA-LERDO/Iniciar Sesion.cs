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
    public partial class Iniciar_Sesion : Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conectar a la base de datos por medio de procedimiento validar que el existe el usuario
            //Valirdar si los campos están llenos
            if (this.Valida())
            {
                //Mandar a llamar el procedimiento de usuaario para validar si existe
                this.usuarioTableAdapter.Fill(this.sciDataSet.Usuario, this.txtUsuario.Text.Trim(), this.txtContraseña.Text.Trim());
                //si existe el usuario
                if (this.sciDataSet.Usuario.Rows.Count > 0)
                {
                    //El usuario existe; ingresamos a la pantalla principal
                    Principal main = new Principal();
                    this.Hide();
                    main.ShowDialog();  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Usuario y/o la Contraseñas son inconrrectos", "Valida Usuario", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool resultado = true;
            //Validar el campo usuario
            if (this.txtUsuario.Text.Trim()=="")
            {
                resultado = false;
                this.errorProvider1.SetError(this.txtUsuario, "¡Este campo es requerido!");
            }
            //Validar el campo Contraseña
            if (this.txtContraseña.Text.Trim() == "")
            {
                resultado = false;
                this.errorProvider1.SetError(this.txtContraseña, "¡Este campo es requerido!");
            }
            return resultado;
        }
    }
}
