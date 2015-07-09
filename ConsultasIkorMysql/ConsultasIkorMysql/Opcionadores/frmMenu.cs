using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MdiTabStrip.Design;
using MdiTabStrip;

namespace ConsultasIkorMysql.Opcionadores
{
    /// <summary>
    /// Autor: 
    ///     Miguel Gutierrez Arroyo
    /// Fecha: 
    ///     2014/05/06
    /// 
    /// Descripcion: 
    ///     Menu Dinámico de la Aplicación
    /// Acciones: 
    ///     Desplegar Modulos
    /// 
    /// </summary> 
    public partial class frmMenu : ToolWindow
    {
        #region PROPIEDADES
        frmPrincipal mdipr;
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmMenu(Form frmMDI)
        {
            mdipr = (frmPrincipal)frmMDI;
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region METODOS
        #endregion METODOS
        #region EVENTOS
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
        #endregion EVENTOS

        private void frmMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStrip3_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
      
        }

        public void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmOpcionMysql frmMysql = new frmOpcionMysql(mdipr);
            clSeguridad.vCargaForma(frmMysql, mdipr, "Menú Principal");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

      
    }
}