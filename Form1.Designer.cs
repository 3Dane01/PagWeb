﻿namespace PagWeb
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.goButton = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.ComboBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonOrdenarAscendente = new System.Windows.Forms.Button();
            this.buttonOrdenarFecha = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.volverToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.toolStripMenuItem1.Text = "Regresar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 62);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1122, 517);
            this.webView.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webView.TabIndex = 4;
            this.webView.ZoomFactor = 1D;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(901, 28);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 26);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Ir";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.FormattingEnabled = true;
            this.addressBar.Location = new System.Drawing.Point(12, 30);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(883, 24);
            this.addressBar.TabIndex = 8;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(901, 5);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOrdenarAscendente
            // 
            this.buttonOrdenarAscendente.Location = new System.Drawing.Point(982, 28);
            this.buttonOrdenarAscendente.Name = "buttonOrdenarAscendente";
            this.buttonOrdenarAscendente.Size = new System.Drawing.Size(152, 23);
            this.buttonOrdenarAscendente.TabIndex = 10;
            this.buttonOrdenarAscendente.Text = "Ordenar ascendente";
            this.buttonOrdenarAscendente.UseVisualStyleBackColor = true;
            this.buttonOrdenarAscendente.Click += new System.EventHandler(this.buttonOrdenarAscendente_Click);
            // 
            // buttonOrdenarFecha
            // 
            this.buttonOrdenarFecha.Location = new System.Drawing.Point(982, 5);
            this.buttonOrdenarFecha.Name = "buttonOrdenarFecha";
            this.buttonOrdenarFecha.Size = new System.Drawing.Size(152, 23);
            this.buttonOrdenarFecha.TabIndex = 11;
            this.buttonOrdenarFecha.Text = "Ordenar por Fecha";
            this.buttonOrdenarFecha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 664);
            this.Controls.Add(this.buttonOrdenarFecha);
            this.Controls.Add(this.buttonOrdenarAscendente);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Explorador Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ComboBox addressBar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonOrdenarAscendente;
        private System.Windows.Forms.Button buttonOrdenarFecha;
    }
}

