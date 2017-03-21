﻿namespace ProyectoTiempos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosPremiadosEnSorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeGanadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionDElaCasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblJugador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timerValidacion = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracion,
            this.sorteosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Josue Mora";
            // 
            // configuracion
            // 
            this.configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSorteoToolStripMenuItem,
            this.numerosPremiadosEnSorteoToolStripMenuItem,
            this.tablaDeGanadoresToolStripMenuItem,
            this.configuracionDElaCasaToolStripMenuItem});
            this.configuracion.Name = "configuracion";
            this.configuracion.Size = new System.Drawing.Size(95, 20);
            this.configuracion.Text = "Configuracion";
            // 
            // crearSorteoToolStripMenuItem
            // 
            this.crearSorteoToolStripMenuItem.Name = "crearSorteoToolStripMenuItem";
            this.crearSorteoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.crearSorteoToolStripMenuItem.Text = "Sorteo";
            this.crearSorteoToolStripMenuItem.Click += new System.EventHandler(this.crearSorteoToolStripMenuItem_Click);
            // 
            // numerosPremiadosEnSorteoToolStripMenuItem
            // 
            this.numerosPremiadosEnSorteoToolStripMenuItem.Name = "numerosPremiadosEnSorteoToolStripMenuItem";
            this.numerosPremiadosEnSorteoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.numerosPremiadosEnSorteoToolStripMenuItem.Text = "Numeros Premiados en Sorteo";
            this.numerosPremiadosEnSorteoToolStripMenuItem.Click += new System.EventHandler(this.numerosPremiadosEnSorteoToolStripMenuItem_Click);
            // 
            // tablaDeGanadoresToolStripMenuItem
            // 
            this.tablaDeGanadoresToolStripMenuItem.Name = "tablaDeGanadoresToolStripMenuItem";
            this.tablaDeGanadoresToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.tablaDeGanadoresToolStripMenuItem.Text = "Tabla de Ganadores";
            this.tablaDeGanadoresToolStripMenuItem.Click += new System.EventHandler(this.tablaDeGanadoresToolStripMenuItem_Click);
            // 
            // configuracionDElaCasaToolStripMenuItem
            // 
            this.configuracionDElaCasaToolStripMenuItem.Name = "configuracionDElaCasaToolStripMenuItem";
            this.configuracionDElaCasaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.configuracionDElaCasaToolStripMenuItem.Text = "Configuracion de la Casa";
            this.configuracionDElaCasaToolStripMenuItem.Click += new System.EventHandler(this.configuracionDElaCasaToolStripMenuItem_Click);
            // 
            // sorteosToolStripMenuItem
            // 
            this.sorteosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponiblesToolStripMenuItem,
            this.jugarToolStripMenuItem});
            this.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem";
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sorteosToolStripMenuItem.Text = "Sorteos";
            // 
            // disponiblesToolStripMenuItem
            // 
            this.disponiblesToolStripMenuItem.Name = "disponiblesToolStripMenuItem";
            this.disponiblesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.disponiblesToolStripMenuItem.Text = "Ver Sorteos";
            this.disponiblesToolStripMenuItem.Click += new System.EventHandler(this.disponiblesToolStripMenuItem_Click);
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.jugarToolStripMenuItem.Text = "Jugar";
            this.jugarToolStripMenuItem.Click += new System.EventHandler(this.jugarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(535, 9);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(0, 13);
            this.lblJugador.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(603, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerValidacion
            // 
            this.timerValidacion.Enabled = true;
            this.timerValidacion.Interval = 10000;
            this.timerValidacion.Tick += new System.EventHandler(this.timerValidacion_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "JPS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem configuracion;
        private System.Windows.Forms.ToolStripMenuItem numerosPremiadosEnSorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeGanadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionDElaCasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSorteoToolStripMenuItem;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerValidacion;
    }
}



