using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto form = new FormProducto();
            form.Show();
        }

        private void btnSupermercado_Click(object sender, EventArgs e)
        {
            FormSupermercado form = new FormSupermercado();
            form.Show();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            FormProductoxSupermercado form = new FormProductoxSupermercado();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
