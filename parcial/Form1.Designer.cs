﻿namespace parcial
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
            this.iNGRESARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPARTAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOSTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNGRESARToolStripMenuItem,
            this.mOSTRARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNGRESARToolStripMenuItem
            // 
            this.iNGRESARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEPARTAMENTOSToolStripMenuItem});
            this.iNGRESARToolStripMenuItem.Name = "iNGRESARToolStripMenuItem";
            this.iNGRESARToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.iNGRESARToolStripMenuItem.Text = "INGRESAR";
            // 
            // dEPARTAMENTOSToolStripMenuItem
            // 
            this.dEPARTAMENTOSToolStripMenuItem.Name = "dEPARTAMENTOSToolStripMenuItem";
            this.dEPARTAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dEPARTAMENTOSToolStripMenuItem.Text = "DEPARTAMENTOS";
            // 
            // mOSTRARToolStripMenuItem
            // 
            this.mOSTRARToolStripMenuItem.Name = "mOSTRARToolStripMenuItem";
            this.mOSTRARToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mOSTRARToolStripMenuItem.Text = "MOSTRAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNGRESARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPARTAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOSTRARToolStripMenuItem;
    }
}

