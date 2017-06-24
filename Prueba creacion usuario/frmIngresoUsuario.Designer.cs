namespace Prueba_creacion_usuario
{
    partial class frmIngresoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsMenuNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsMenuAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsMenuGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.stsEstado = new System.Windows.Forms.StatusStrip();
            this.tssEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.stsEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(142, 70);
            this.txtNombreUsuario.MaxLength = 75;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(284, 22);
            this.txtNombreUsuario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(142, 109);
            this.txtLoginUsuario.MaxLength = 20;
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtLoginUsuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(142, 147);
            this.txtClaveUsuario.MaxLength = 20;
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtClaveUsuario.TabIndex = 2;
            this.txtClaveUsuario.UseSystemPasswordChar = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuNuevo,
            this.tsMenuAgregar,
            this.tsMenuGuardar,
            this.toolStripSeparator});
            this.tsMenu.Location = new System.Drawing.Point(0, 28);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(444, 27);
            this.tsMenu.TabIndex = 9;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsMenuNuevo
            // 
            this.tsMenuNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMenuNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuNuevo.Image")));
            this.tsMenuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuNuevo.Name = "tsMenuNuevo";
            this.tsMenuNuevo.Size = new System.Drawing.Size(24, 24);
            this.tsMenuNuevo.Text = "&New";
            this.tsMenuNuevo.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // tsMenuAgregar
            // 
            this.tsMenuAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMenuAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuAgregar.Image")));
            this.tsMenuAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuAgregar.Name = "tsMenuAgregar";
            this.tsMenuAgregar.Size = new System.Drawing.Size(24, 24);
            this.tsMenuAgregar.Text = "&Open";
            this.tsMenuAgregar.Click += new System.EventHandler(this.tsMenuAgregar_Click);
            // 
            // tsMenuGuardar
            // 
            this.tsMenuGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMenuGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuGuardar.Image")));
            this.tsMenuGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuGuardar.Name = "tsMenuGuardar";
            this.tsMenuGuardar.Size = new System.Drawing.Size(24, 24);
            this.tsMenuGuardar.Text = "&Save";
            this.tsMenuGuardar.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // stsEstado
            // 
            this.stsEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssEstado});
            this.stsEstado.Location = new System.Drawing.Point(0, 193);
            this.stsEstado.Name = "stsEstado";
            this.stsEstado.Size = new System.Drawing.Size(444, 22);
            this.stsEstado.TabIndex = 10;
            this.stsEstado.Text = "statusStrip1";
            // 
            // tssEstado
            // 
            this.tssEstado.Name = "tssEstado";
            this.tssEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // frmIngresoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 215);
            this.Controls.Add(this.stsEstado);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.txtClaveUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmIngresoUsuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de usuario";
            this.Load += new System.EventHandler(this.frmIngresoUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.stsEstado.ResumeLayout(false);
            this.stsEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsMenuNuevo;
        private System.Windows.Forms.ToolStripButton tsMenuAgregar;
        private System.Windows.Forms.ToolStripButton tsMenuGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.StatusStrip stsEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
    }
}

