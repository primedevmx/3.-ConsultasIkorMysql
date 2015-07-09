using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Data.Common;
using System.IO;
using System.Xml;
using System.Linq;
using Microsoft.ApplicationBlocks.Data;

namespace ConsultasIkorMysql
{
    public class mSeguridad
    {
        #region PROPIEDADES PRIVADAS
        //Int -->
        private int _idStatusPCB;

        //String-->
        private string _strUsuarioSistema = "";
        private string _strConnFB = "";
        private string _strConnSQL = "";
        private string _strStatusPCB = "";
        private string _strDescripcionEstatusPCB = "";

        //Bool-->
        private bool _bUsuarioAdmin = false;
        private bool _bUsuarioProduc = false;
        private bool _bAplicaReglas = false;
        #endregion PROPIEDADES PRIVADAS
        #region PROPIEDADES PUBLICAS
        //Int-->
        public int idStatusPCB
        {
            get
            {
                return this._idStatusPCB;
            }
            set
            {
                this._idStatusPCB = value;
            }
        }
        //String-->
        public string strUsuarioSistema
        {
            get
            {
                return this._strUsuarioSistema;
            }
            set
            {
                this._strUsuarioSistema = value;
            }
        }
        //String-->
        public string strStatusPCB
        {
            get
            {
                return this._strStatusPCB;
            }
            set
            {
                this._strStatusPCB = value;
            }
        }
        //String-->
        public string strDescripcionEstatusPCB
        {
            get
            {
                return this._strDescripcionEstatusPCB;
            }
            set
            {
                this._strDescripcionEstatusPCB = value;
            }
        }
        //String Connection->>
        public string strConnection
        {
            get
            {
                return this._strConnFB = Properties.Settings.Default.InstanciaServerMysql;
            }
            set
            {
                this._strConnFB = value;
            }
        }
        public string strConnSQL
        {
            get
            {
                return this._strConnSQL = Properties.Settings.Default.InstanciaServerSql;
            }
            set
            {
                this._strConnSQL = value;
            }
        }
       
        //Bool-->
        public bool bUsuarioAdmin
        {
            get
            {
                return this._bUsuarioAdmin;
            }
            set
            {
                this._bUsuarioAdmin = value;
            }
        }
        public bool bUsuarioProduc
        {
            get
            {
                return this._bUsuarioProduc;
            }
            set
            {
                this._bUsuarioProduc = value;
            }
        }
        public bool bAplicaReglas
        {
            get
            {
                return this._bAplicaReglas;
            }
            set
            {
                this._bAplicaReglas = value;
            }
        }
        #endregion PROPIEDADES PUBLICAS
        #region METODOS PUBLICOS
        public DataTable dtObtieneTablas(string strBD)
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strSalida = "";

            strCommand = "SHOW FULL TABLES FROM " + strBD;                  

            try
            {
                //Consulta->>
                dsReturn =
                    MYSQL.MySqlHelper.ExecuteDataSet(this.strConnection, strCommand);
          
            }
            catch (Exception EX)
            {
                dsReturn = null;
            }

            return dsReturn.Tables[0];
        
        }
        #endregion METODOS PUBLICOS
    }
}
