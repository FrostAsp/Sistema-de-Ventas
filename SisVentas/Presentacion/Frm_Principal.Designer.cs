namespace SisVentas.Presentacion
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Pnl_opciones = new System.Windows.Forms.Panel();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Pnl_barraestado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDescripcion_ru = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_us = new System.Windows.Forms.Label();
            this.Pnl_contenido = new System.Windows.Forms.Panel();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnFamilias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.Pnl_opciones.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.Pnl_barraestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_opciones
            // 
            this.Pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(128)))), ((int)(((byte)(167)))));
            this.Pnl_opciones.Controls.Add(this.btnCerrarsesion);
            this.Pnl_opciones.Controls.Add(this.btnUsuarios);
            this.Pnl_opciones.Controls.Add(this.btnEmpresa);
            this.Pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_opciones.Location = new System.Drawing.Point(719, 0);
            this.Pnl_opciones.Name = "Pnl_opciones";
            this.Pnl_opciones.Size = new System.Drawing.Size(200, 570);
            this.Pnl_opciones.TabIndex = 0;
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.Location = new System.Drawing.Point(9, 501);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(182, 53);
            this.btnCerrarsesion.TabIndex = 2;
            this.btnCerrarsesion.Text = "Cerrar Sesión";
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(9, 96);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(182, 53);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(9, 24);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(182, 53);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.Pnl_titulo.Controls.Add(this.pctLogo);
            this.Pnl_titulo.Controls.Add(this.lblTitulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(719, 77);
            this.Pnl_titulo.TabIndex = 1;
            this.Pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseDown);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(13, 10);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(63, 58);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            this.pctLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctLogo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(82, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Ventas";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // Pnl_barraestado
            // 
            this.Pnl_barraestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.Pnl_barraestado.Controls.Add(this.pictureBox2);
            this.Pnl_barraestado.Controls.Add(this.lblDescripcion_ru);
            this.Pnl_barraestado.Controls.Add(this.pictureBox1);
            this.Pnl_barraestado.Controls.Add(this.lbl_nombre_us);
            this.Pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_barraestado.Location = new System.Drawing.Point(0, 485);
            this.Pnl_barraestado.Name = "Pnl_barraestado";
            this.Pnl_barraestado.Size = new System.Drawing.Size(719, 85);
            this.Pnl_barraestado.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblDescripcion_ru
            // 
            this.lblDescripcion_ru.AutoSize = true;
            this.lblDescripcion_ru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion_ru.Location = new System.Drawing.Point(52, 57);
            this.lblDescripcion_ru.Name = "lblDescripcion_ru";
            this.lblDescripcion_ru.Size = new System.Drawing.Size(78, 16);
            this.lblDescripcion_ru.TabIndex = 2;
            this.lblDescripcion_ru.Text = "Rol usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_us
            // 
            this.lbl_nombre_us.AutoSize = true;
            this.lbl_nombre_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_us.Location = new System.Drawing.Point(52, 22);
            this.lbl_nombre_us.Name = "lbl_nombre_us";
            this.lbl_nombre_us.Size = new System.Drawing.Size(57, 16);
            this.lbl_nombre_us.TabIndex = 0;
            this.lbl_nombre_us.Text = "Usuario:";
            // 
            // Pnl_contenido
            // 
            this.Pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Pnl_contenido.Controls.Add(this.BtnReportes);
            this.Pnl_contenido.Controls.Add(this.btnVentas);
            this.Pnl_contenido.Controls.Add(this.btnCompras);
            this.Pnl_contenido.Controls.Add(this.btnClientes);
            this.Pnl_contenido.Controls.Add(this.btnProveedores);
            this.Pnl_contenido.Controls.Add(this.btnFamilias);
            this.Pnl_contenido.Controls.Add(this.btnProductos);
            this.Pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenido.Location = new System.Drawing.Point(0, 77);
            this.Pnl_contenido.Name = "Pnl_contenido";
            this.Pnl_contenido.Size = new System.Drawing.Size(719, 408);
            this.Pnl_contenido.TabIndex = 3;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ImageKey = "contabilidad.png";
            this.BtnReportes.ImageList = this.imageList1;
            this.BtnReportes.Location = new System.Drawing.Point(367, 230);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(110, 100);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportes.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresa.png");
            this.imageList1.Images.SetKeyName(1, "724package_100522.png");
            this.imageList1.Images.SetKeyName(2, "1455554314_line-15_icon-icons.com_53330.png");
            this.imageList1.Images.SetKeyName(3, "proveedor.png");
            this.imageList1.Images.SetKeyName(4, "shoppaymentorderbuy-33_icon-icons.com_73869.png");
            this.imageList1.Images.SetKeyName(5, "punto-de-venta.png");
            this.imageList1.Images.SetKeyName(6, "comunidad.png");
            this.imageList1.Images.SetKeyName(7, "contabilidad.png");
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ImageKey = "punto-de-venta.png";
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(87, 230);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(110, 100);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ImageKey = "shoppaymentorderbuy-33_icon-icons.com_73869.png";
            this.btnCompras.ImageList = this.imageList1;
            this.btnCompras.Location = new System.Drawing.Point(229, 230);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(110, 100);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ImageKey = "comunidad.png";
            this.btnClientes.ImageList = this.imageList1;
            this.btnClientes.Location = new System.Drawing.Point(367, 76);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(110, 100);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ImageKey = "proveedor.png";
            this.btnProveedores.ImageList = this.imageList1;
            this.btnProveedores.Location = new System.Drawing.Point(509, 76);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(110, 100);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnFamilias
            // 
            this.btnFamilias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilias.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilias.ImageKey = "1455554314_line-15_icon-icons.com_53330.png";
            this.btnFamilias.ImageList = this.imageList1;
            this.btnFamilias.Location = new System.Drawing.Point(227, 76);
            this.btnFamilias.Name = "btnFamilias";
            this.btnFamilias.Size = new System.Drawing.Size(110, 100);
            this.btnFamilias.TabIndex = 2;
            this.btnFamilias.Text = "Familias Productos";
            this.btnFamilias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFamilias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFamilias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ImageKey = "724package_100522.png";
            this.btnProductos.ImageList = this.imageList1;
            this.btnProductos.Location = new System.Drawing.Point(85, 76);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(110, 100);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 570);
            this.Controls.Add(this.Pnl_contenido);
            this.Controls.Add(this.Pnl_barraestado);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Pnl_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas ver.1.0";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Pnl_opciones.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.Pnl_barraestado.ResumeLayout(false);
            this.Pnl_barraestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_opciones;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Panel Pnl_barraestado;
        private System.Windows.Forms.Panel Pnl_contenido;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnFamilias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lbl_nombre_us;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescripcion_ru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmpresa;
    }
}