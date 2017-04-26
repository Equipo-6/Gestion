namespace Control_Escolar
{
    partial class Control_Escolar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Escolar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bjasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.constanciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudDeReinscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobanteDeSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.BackgroundImage = global::Control_Escolar.Properties.Resources.fondo_escolar_hofmann_para_album_classic_material_de_clase_escolares_29_classic_1200px;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.inscripcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(183, 388);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem,
            this.cambiosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bajasToolStripMenuItem,
            this.busquedaToolStripMenuItem2});
            this.alumnosToolStripMenuItem.Image = global::Control_Escolar.Properties.Resources.padron_estudiante;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(176, 27);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(184, 6);
            this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.cambiosToolStripMenuItem.Text = "Inscripcion";
            this.cambiosToolStripMenuItem.Click += new System.EventHandler(this.reinscripcionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 28);
            this.toolStripMenuItem1.Text = "Cambios";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem2
            // 
            this.busquedaToolStripMenuItem2.Name = "busquedaToolStripMenuItem2";
            this.busquedaToolStripMenuItem2.Size = new System.Drawing.Size(187, 28);
            this.busquedaToolStripMenuItem2.Text = "Busqueda";
            this.busquedaToolStripMenuItem2.Click += new System.EventHandler(this.busquedaToolStripMenuItem2_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem1,
            this.agregarToolStripMenuItem,
            this.bjasToolStripMenuItem,
            this.cambiosToolStripMenuItem1});
            this.profesoresToolStripMenuItem.Image = global::Control_Escolar.Properties.Resources.docente;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(176, 27);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem1
            // 
            this.busquedaToolStripMenuItem1.Name = "busquedaToolStripMenuItem1";
            this.busquedaToolStripMenuItem1.Size = new System.Drawing.Size(177, 28);
            this.busquedaToolStripMenuItem1.Text = "Busqueda";
            this.busquedaToolStripMenuItem1.Click += new System.EventHandler(this.busquedaToolStripMenuItem1_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.agregarToolStripMenuItem.Text = "Altas";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // bjasToolStripMenuItem
            // 
            this.bjasToolStripMenuItem.Name = "bjasToolStripMenuItem";
            this.bjasToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.bjasToolStripMenuItem.Text = "Bajas";
            this.bjasToolStripMenuItem.Click += new System.EventHandler(this.bjasToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem1
            // 
            this.cambiosToolStripMenuItem1.Name = "cambiosToolStripMenuItem1";
            this.cambiosToolStripMenuItem1.Size = new System.Drawing.Size(177, 28);
            this.cambiosToolStripMenuItem1.Text = "Cambios";
            this.cambiosToolStripMenuItem1.Click += new System.EventHandler(this.cambiosToolStripMenuItem1_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.constanciasToolStripMenuItem,
            this.boletasToolStripMenuItem,
            this.reglamentoToolStripMenuItem,
            this.tarjetaDePagoToolStripMenuItem,
            this.solicitudDeReinscripcionToolStripMenuItem,
            this.comprobanteDeSeguroToolStripMenuItem});
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(176, 27);
            this.inscripcionesToolStripMenuItem.Text = "Documentacion";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(331, 28);
            this.toolStripMenuItem2.Text = "Listas";
            // 
            // constanciasToolStripMenuItem
            // 
            this.constanciasToolStripMenuItem.Name = "constanciasToolStripMenuItem";
            this.constanciasToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.constanciasToolStripMenuItem.Text = "Constancias";
            // 
            // boletasToolStripMenuItem
            // 
            this.boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            this.boletasToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.boletasToolStripMenuItem.Text = "Boletas";
            // 
            // reglamentoToolStripMenuItem
            // 
            this.reglamentoToolStripMenuItem.Name = "reglamentoToolStripMenuItem";
            this.reglamentoToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.reglamentoToolStripMenuItem.Text = "Reglamento";
            // 
            // tarjetaDePagoToolStripMenuItem
            // 
            this.tarjetaDePagoToolStripMenuItem.Name = "tarjetaDePagoToolStripMenuItem";
            this.tarjetaDePagoToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.tarjetaDePagoToolStripMenuItem.Text = "Tarjeta de Pago";
            // 
            // solicitudDeReinscripcionToolStripMenuItem
            // 
            this.solicitudDeReinscripcionToolStripMenuItem.Name = "solicitudDeReinscripcionToolStripMenuItem";
            this.solicitudDeReinscripcionToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.solicitudDeReinscripcionToolStripMenuItem.Text = "Solicitud de Reinscripcion";
            // 
            // comprobanteDeSeguroToolStripMenuItem
            // 
            this.comprobanteDeSeguroToolStripMenuItem.Name = "comprobanteDeSeguroToolStripMenuItem";
            this.comprobanteDeSeguroToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.comprobanteDeSeguroToolStripMenuItem.Text = "Comprobante de Seguro ";
            // 
            // Control_Escolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Control_Escolar.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(890, 388);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Control_Escolar";
            this.Text = "Control Escolar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bjasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem constanciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudDeReinscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobanteDeSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator busquedaToolStripMenuItem;



    }
}

