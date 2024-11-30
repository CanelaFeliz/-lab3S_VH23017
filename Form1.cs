using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3S_VH23017
{
    public partial class Form1 : Form
    {
        int limite = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguienteCliente_Click(object sender, EventArgs e)
        {
            string[] nombre = new string[limite];
            string[] idioma = new string[limite];
            int[] telefono = new int[limite];
            int[] horas = new int[limite];
            int precioHora;

            limite = Convert.ToInt16(txtCantClientes.Text);

            nombre[limite] = txtNombre.Text;
            idioma[limite] = txtIdioma.Text;
            telefono[limite] = Convert.ToInt32(txtTelefono.Text);
            horas[limite] = Convert.ToInt32(txtHoras.Text);

            precioHora = horas[limite]* 25;

            dgvRegistros.Rows.Add(nombre[limite], telefono[limite], idioma[limite], horas[limite], precioHora);
        }
    }
}
