using SisVentas.Datos;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnIniciar, "Iniciar sesión ahora");
            this.toolTip1.SetToolTip(this.btnSalir, "Salir del Sistema");

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Estilo para el control de Título"
            //Drag Form
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);
        #endregion

        #region "Mis Métodos"
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.txtLogin_us.Text = "";
            this.txtPassword_us.Text = "";
            this.Show();
            this.txtLogin_us.Select();
        }
        #endregion

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable TablaLogin = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            TablaLogin = Datos.Login_us(txtLogin_us.Text,txtPassword_us.Text);
            if (TablaLogin.Rows.Count>0)
            {
                Frm_Principal oFrm_Principal = new Frm_Principal();
                oFrm_Principal.nCodigo_us = Convert.ToInt32(TablaLogin.Rows[0][0]);
                oFrm_Principal.cLogin_us= Convert.ToString(TablaLogin.Rows[0][1]);
                oFrm_Principal.cNombre_us= Convert.ToString(TablaLogin.Rows[0][2]);
                oFrm_Principal.cDescripcion_ru= Convert.ToString(TablaLogin.Rows[0][3]);
                oFrm_Principal.nCodigo_ru= Convert.ToInt32(TablaLogin.Rows[0][4]);
                oFrm_Principal.Show();
                oFrm_Principal.FormClosed += Logout;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Password no son válidas ... verifique",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
    }
}
