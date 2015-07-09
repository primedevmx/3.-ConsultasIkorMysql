using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ConsultasIkorMysql.Mysql
{
    public partial class frmVistaReportes : Form
    {
        #region PROPIEDADES
        mSeguridad _mSec = new mSeguridad();
        DataSet _dsLoad = new DataSet();
        DataTable _dtREPORTE;
        DataTable _dtMAIN;
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmVistaReportes()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void frmVistaReportes_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmVistaReportes_KeyDown);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            //Cargado de Datos->>
            if (!bCargarDatos())
            {
                this.groupBox1.Enabled = false;
                this.groupBox2.Enabled = false;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tsbExcel_Click(object sender, EventArgs e)
        {
            DataSet dsTemp = new DataSet();
            DataTable dtTemp = (DataTable)uctrlTablaConFiltroReporteSalida.gridDatos.DataSource;

            if (dtTemp != null && dtTemp.Rows.Count > 0)
            {
                dsTemp.Tables.Add(dtTemp.Copy());
            }
            else
            {
                MessageBox.Show("Antes de Exportar a [Excel], necesita generar una búsqueda... ", "Mensaje"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int size = -1;

            saveFileDialog1.Filter =
                "Excel|*.xls|Excel 2010|*.xlsx";
            saveFileDialog1.Title = "Seleccione la ubicación del archivo";
            saveFileDialog1.FilterIndex = 1;

            DialogResult result = saveFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                string file = saveFileDialog1.FileName;
                try
                {

                    if (CrearExcel_DS(dsTemp, file) == "EXITO")
                    {

                        MessageBox.Show("Se ha Generado correctamente el archivo de Excel en la siguiente ruta: \n\r" +
                            file ,"Mensaje del Sistema" ,MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else {
                        MessageBox.Show("Ocurrió un problema a generar el archivo de Excel");
                                            
                    }

                }
                catch
                {
                    MessageBox.Show("Ocurrió un problema a generar el archivo de Excel");
                }
            }
        }

        private void tsbGeneraReporte_Click(object sender, EventArgs e)
        {
            //Salidadel Reporte->>
            _dtMAIN = new DataTable("CONSULTA_DEL_REPORTE");
            DataTable dtTemp = new DataTable();
            UserControls.SplashScreenFormV2 FRMSPLSH
                     = new UserControls.SplashScreenFormV2("Obteniendo información del sistema... "
                         , "Espere un momento por favor... ");

            string strCommand = "";
            int intCounter = 0;

            strCommand = "SELECT * FROM " + cmbNombreTabla.Text.Trim();       

            //Previa Verificación->>
            string strErr;
            if (!bVerificaInfo(out strErr))
            {
                MessageBox.Show(strErr, "Verificar Datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {            

                if (uctrlTablaConFiltroReporteSalida.Filtro != null && uctrlTablaConFiltroReporteSalida.Filtro.Count > 0)
                {

                    foreach (KeyValuePair<string, string> Par in uctrlTablaConFiltroReporteSalida.Filtro)
                    {
                        if (intCounter == 0)
                        {
                            strCommand += " WHERE cast( " + Par.Key + " as char(1024) )  like  \"" + Par.Value + "%\"   ";
                        }
                        else
                        {
                            strCommand += " AND cast( " + Par.Key + " as char(1024) )  like    \"" + Par.Value + "%\"   ";
                        }

                        intCounter++;
                    }

                }
                else
                {
                    //OBTIENE CONSULTA->>
                    DataTable dTFirst =
                        MYSQL.MySqlHelper.ExecuteDataSet(_mSec.strConnection, strCommand + " where 0=1").Tables[0];

                    if (dTFirst != null)
                    {
                        uctrlTablaConFiltroReporteSalida.DataSource = dTFirst.Copy();
                        uctrlTablaConFiltroReporteSalida.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        return;

                    }                   
                                 
                }

                if (uctrlTablaConFiltroReporteSalida.Filtro == null && uctrlTablaConFiltroReporteSalida.Filtro.Count == 0)
                {
                    DialogResult reply = MessageBox.Show("¿Está seguro de generar su reporte sin filtros?",
                        "Advertencia Verificar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reply == DialogResult.No)
                    {
                        return;
                    }
                }
             
                FRMSPLSH.Show();
                FRMSPLSH.Refresh();

                //Consulta->>
                _dtMAIN =
                    MYSQL.MySqlHelper.ExecuteDataSet(_mSec.strConnection, strCommand).Tables[0];

                if (_dtMAIN != null && _dtMAIN.Rows.Count > 0)
                {
                    uctrlTablaConFiltroReporteSalida.DataSource = _dtMAIN.Copy();
                    uctrlTablaConFiltroReporteSalida.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception EX)
            {
                string strSalida = EX.Message + "\r\n \r\n - No se ha establecido la conexión correctamente."
                            + " \r\n \r\n ";
                MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN CON LA BD SELECCIONADA-"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            FRMSPLSH.Close();
            FRMSPLSH.Dispose();


        }                       

        private void frmVistaReportes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                tsbGeneraReporte_Click(null,null);
            }
            if (e.KeyCode.ToString() == "F2")
            {
                tsbExcel_Click(null, null);
            }
        }

        private void tsbLimpiarP_Click(object sender, EventArgs e)
        {
            uctrlTablaConFiltroReporteSalida.DataSource = null;
            cmbNombreTabla.SelectedIndex = -1;
        }

        #endregion EVENTOS
        #region METODOS
        public string CrearExcel_DS(DataSet DS, string strFile)
        {
            Cursor.Current = Cursors.WaitCursor;

            #region CREACION DE VARIABLES
            Excel.Application eAplicacion = new Excel.Application();
            Excel.Workbook eLibro = null;
            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            #endregion
            #region CUERPO
            try
            {
                #region Crear Libro
                try { eLibro = eAplicacion.Workbooks.Add(System.Reflection.Missing.Value); }
                catch
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    eLibro = eAplicacion.Workbooks.Add(System.Reflection.Missing.Value);
                }
                #endregion
                #region Crear Hojas
                foreach (DataTable dtbHoja in DS.Tables)
                {
                    int intColumnas = dtbHoja.Columns.Count;
                    #region HOJA Excel
                    Excel.Worksheet eHoja = DS.Tables.IndexOf(dtbHoja) < 3 ?
                        (Excel.Worksheet)eAplicacion.Sheets[DS.Tables.IndexOf(dtbHoja) + 1] :
                        (Excel.Worksheet)eAplicacion.Sheets.Add(eAplicacion.Sheets[DS.Tables.IndexOf(dtbHoja)], Type.Missing, Type.Missing, Type.Missing);
                    eHoja.Name = dtbHoja.TableName;

                    Excel.Range rCeldas = eHoja.Cells[1, 1];

                    Excel.Range rRango = eHoja.UsedRange; ;
                    
                    #region COLUMNAS
                    rRango = rCeldas[1, 1];
                    for (int i = 0; i < dtbHoja.Columns.Count; i++)
                        eHoja.Cells[1, 1 + i] = dtbHoja.Columns[i].ColumnName;
                    #endregion
                    #region LLENDO DE FILAS
                    int intFila = 2;
                    int intValor = 0;
                    foreach (DataRow dtrDatos in dtbHoja.Rows)
                    {
                        //rRango = (Excel.Range)rCeldas.get_Range(rCeldas[intFila, 1], rCeldas[intFila, dtbHoja.Columns.Count]);
                        rRango = rCeldas[intFila, dtbHoja.Columns.Count];

                        for (int i = 0; i < dtbHoja.Columns.Count; i++)
                            eHoja.Cells[intFila, 1 + i] = Int32.TryParse(dtrDatos[dtbHoja.Columns[i]].ToString(), out intValor) ?
                                intValor.ToString() : (dtrDatos[dtbHoja.Columns[i]].ToString().Contains("'") ?
                                dtrDatos[dtbHoja.Columns[i]].ToString() : "'" + dtrDatos[dtbHoja.Columns[i]].ToString());
                        intFila++;
                    }
                    #endregion
                    #endregion
                }
                #endregion
                #region GUARDAR EXCEL
                eAplicacion.DisplayAlerts = false;
                eLibro.SaveAs(strFile,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value);
                #endregion
                return "EXITO";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                #region CERRAR LIBRO
                if (eLibro != null)
                    eLibro.Close(false, null, null);
                eAplicacion.Quit();
                System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI;
                #endregion
            }
            #endregion

            Cursor.Current = Cursors.Arrow;

        }
        private bool bCargarDatos()
        {
            bool bRet = true;
            try
            {
                #region COMBO 1
                string strDB = Properties.Settings.Default.strBDmain;
                DataTable dtTem = new DataTable();
                DataColumn dc1 = new DataColumn("idDB");
                DataColumn dc2 = new DataColumn("strNombreBD");
                dtTem.Columns.Add(dc1);
                dtTem.Columns.Add(dc2);
                DataRow DR = dtTem.NewRow();
                DR[0] = 1;
                DR[1] = strDB;
                dtTem.Rows.Add(DR);
                cmbBDs.DataSource = dtTem.Copy();
                cmbBDs.ValueMember = "idDB";
                cmbBDs.DisplayMember = "strNombreBD";
                #endregion COMBO 1

                #region COMBO 2
                DataTable dTemp2 = _mSec.dtObtieneTablas(strDB.Trim());
                cmbNombreTabla.DataSource = dTemp2.Copy();
                cmbNombreTabla.ValueMember = dTemp2.Columns[0].ColumnName.Trim();
                cmbNombreTabla.DisplayMember = dTemp2.Columns[0].ColumnName.Trim();
                cmbNombreTabla.SelectedIndex = -1;
                #endregion COMBO 2
            }
            catch {
                MessageBox.Show("Favor de verificar que se haya establecido correctamente la conexión con su servidor Mysql."
                    ,"Advertencia");
                bRet = false;
            }

            return bRet;
        }
        private bool bVerificaInfo(out string err)
        {
            err = "";
            if (cmbBDs.Text == "") { err = "Debe Especificar la Base de Datos del Reporte."; }
            else if (cmbNombreTabla.Text == "") { err = "Debe Especificar el [Nombre de la Tabla] de la Base de Datos."; }

            return (err == "");
        }
        #endregion METODOS
    }
}
