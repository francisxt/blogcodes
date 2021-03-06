﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
        }       

        private void btMostrarHijo1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Hijo1 form = Application.OpenForms.OfType<Hijo1>().FirstOrDefault();
            Hijo1 hijo1 = form ?? new Hijo1();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void btMostrarHijo2_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Hijo2>().FirstOrDefault();
            Hijo2 hijo = form ?? new Hijo2();
            AddFormInPanel(hijo);
        }

        /// <summary>
        /// Agrega en un Panel un formulario
        /// </summary>
        /// <param name="formHijo">Instancia del formulario a agregar</param>
        private void AddFormInPanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
           
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        
    }
}
