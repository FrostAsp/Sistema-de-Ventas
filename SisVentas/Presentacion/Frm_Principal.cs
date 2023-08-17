using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Mis Variables"
        internal int nCodigo_us { get; set; }
        internal string cLogin_us { get; set; } 
        internal string cNombre_us { get; set; }
        internal string cDescripcion_ru { get; set; }
        internal int nCodigo_ru { get; set; }
        #endregion

        #region "Estilo para el control de Título"
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);
        #endregion

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_nombre_us.Text = "Usuario: " + cNombre_us;
            lblDescripcion_ru.Text= "Rol usuario: "+ cDescripcion_ru;
        }

        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pctLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Deseas cerrar sesión del Sistema?",
                                     "Aviso del Sistema",
                                     MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1) //Solo los Administradores del Sistema
            {
                Frm_Usuarios oFrm_us = new Frm_Usuarios();
                oFrm_us.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se tiene permiso para esta opción",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }

            

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
