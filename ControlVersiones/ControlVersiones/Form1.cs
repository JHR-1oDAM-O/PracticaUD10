using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVersiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tListaSocios.Text = "El socio con nombre " +
            tNombre.Text + " y apellidos " + tApellidos.Text +
            ", con teléfono " + tTelefono.Text +
            " ha sido registado correctamente";
        }
    }
}
