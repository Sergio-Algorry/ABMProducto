using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMProducto
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

            lblSalida.Text = "";
        }

        #region Evento
        private void btCrear_Click(object sender, EventArgs e)
        {
            lblSalida.Text = ArmarSalida();
            LimpiaTxt();
        }
        #endregion

        #region Metodos
        private string ArmarSalida()
        {
            string salida = lblSalida.Text 
                            + "\r\n"
                            + txtCodigo.Text + " - " + txtNombre.Text;

            return salida;
        }

        private void LimpiaTxt()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCodigo.Focus();  
        }
        #endregion
    }
}
