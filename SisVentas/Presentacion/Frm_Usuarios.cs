using SisVentas.Datos;
using SisVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo_us = 0;
        int nEstadoGuarda = 0;
        #endregion


        #region "Mis Métodos"
        private void Limpia_Texto()
        {
            txtLogin_us.Text = "";
            txtPassword_us.Text = "";
            txtNombre_us.Text = "";
            cmbRolUsuario.Text = "";
        }
        private void Estado_texto(bool lEstado)
        {
            txtLogin_us.Enabled = lEstado;
            txtPassword_us.Enabled = lEstado;
            txtNombre_us.Enabled = lEstado;
            cmbRolUsuario.Enabled = lEstado;

            txtBuscar.Enabled = !lEstado;
            dgvListado.Enabled = !lEstado;
            btnBuscar.Enabled = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnActualizar.Enabled = lEstado;
            btnEstado.Enabled = lEstado;
            btnRetornar.Enabled = lEstado;
        }

        private void Formato()
        {
            dgvListado.Columns[0].Width = 100;
            dgvListado.Columns[0].HeaderText = "CÓDIGO_US";
            dgvListado.Columns[1].Width = 140;
            dgvListado.Columns[1].HeaderText = "LOGIN";
            dgvListado.Columns[2].Width = 180;
            dgvListado.Columns[2].HeaderText = "NOMBRE";
            dgvListado.Columns[3].Width = 180;
            dgvListado.Columns[3].HeaderText = "ROL DEL USUARIO";
            dgvListado.Columns[4].Width = 100;
            dgvListado.Columns[4].HeaderText = "ACTIVO";
            dgvListado.Columns[5].Visible = false;
        }

        private void Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dgvListado.DataSource = Datos.Listado_us(cTexto);
            this.Formato();
        }

        private void Listado_ru()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                cmbRolUsuario.DataSource= Datos.Listado_ru();
                cmbRolUsuario.ValueMember = "codigo_ru";
                cmbRolUsuario.DisplayMember = "descripcion_ru";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvListado.CurrentRow.Cells["codigo_us"].Value)))
            {
                MessageBox.Show("Seleccione un registro válido",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_us = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_us"].Value);
                txtLogin_us.Text = dgvListado.CurrentRow.Cells["login_us"].Value.ToString();
                txtPassword_us.Text= "";
                txtNombre_us.Text= dgvListado.CurrentRow.Cells["nombre_us"].Value.ToString();
                cmbRolUsuario.Text = dgvListado.CurrentRow.Cells["descripcion_ru"].Value.ToString();
            }
        }
        #endregion
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo Registro
            this.Limpia_Texto();
            this.Estado_texto(true);
            this.Estado_BotonesProcesos(true);
            this.Estado_BotonesPrincipales(false);
            this.txtLogin_us.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.Limpia_Texto();
            this.Estado_texto(false);
            this.Estado_BotonesProcesos(false);
            this.Estado_BotonesPrincipales(true);
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_ru();
            this.Listado_us("%");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtLogin_us.Text==string.Empty ||
                txtPassword_us.Text==string.Empty ||
                txtNombre_us.Text==string.Empty ||
                cmbRolUsuario.Text==string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Procedemos a guardar la información
            {
                string Rpta;
                E_Usuarios oPro = new E_Usuarios();
                oPro.Codigo_us = nCodigo_us;
                oPro.Login_us = txtLogin_us.Text;
                oPro.Password_us = txtPassword_us.Text;
                oPro.Nombre_us= txtNombre_us.Text;
                oPro.Codigo_ru =Convert.ToInt32(cmbRolUsuario.SelectedValue);
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Guardar_us(nEstadoGuarda, oPro);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero==true)
                {
                    nEstadoGuarda = 0;
                    nCodigo_us = 0;
                    this.Limpia_Texto();
                    this.Estado_texto(false);
                    this.Estado_BotonesProcesos(false);
                    this.Estado_BotonesPrincipales(true);
                    this.Listado_us("%");
                    MessageBox.Show("Los datos han sido guardados correctamente en el código #" + Rpta.Trim(),
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; //Actualizar Registro            
            this.Estado_texto(true);
            txtLogin_us.Enabled = false;
            this.Estado_BotonesProcesos(true);
            this.Estado_BotonesPrincipales(false);
            this.txtNombre_us.Focus();
        }

        private void dgvListado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count>0)
            {
                string Rpta = "";
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Activo_us(Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_us"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_us("%");
                    MessageBox.Show("Proceso de estado actualizado",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta,
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
