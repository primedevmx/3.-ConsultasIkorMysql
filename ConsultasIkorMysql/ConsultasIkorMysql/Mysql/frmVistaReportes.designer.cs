namespace ConsultasIkorMysql.Mysql
{
    partial class frmVistaReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaReportes));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroReporteSalida = new ConsultasIkorMysql.uctrlTablaConFiltro();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLimpiarP = new System.Windows.Forms.ToolStripButton();
            this.tsbGeneraReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNombreTabla = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBDs = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tspTittle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::ConsultasIkorMysql.Properties.Resources.images1;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(791, 25);
            this.tspTittle.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(157, 22);
            this.toolStripLabel1.Text = "   Consulta de registros ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.uctrlTablaConFiltroReporteSalida);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 472);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Si requiere generar filtros comparativos en su consulta, puede utilizar los signo" +
    "s [<>] en el campo de texto de la consulta ->>";
            // 
            // uctrlTablaConFiltroReporteSalida
            // 
            this.uctrlTablaConFiltroReporteSalida.bContador = true;
            this.uctrlTablaConFiltroReporteSalida.bFiltro = true;
            this.uctrlTablaConFiltroReporteSalida.bMostrarGrip = false;
            this.uctrlTablaConFiltroReporteSalida.bTabStopFiltros = false;
            this.uctrlTablaConFiltroReporteSalida.DataSource = null;
            this.uctrlTablaConFiltroReporteSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroReporteSalida.dtrAgregarFila = null;
            this.uctrlTablaConFiltroReporteSalida.Location = new System.Drawing.Point(3, 55);
            this.uctrlTablaConFiltroReporteSalida.Name = "uctrlTablaConFiltroReporteSalida";
            this.uctrlTablaConFiltroReporteSalida.Size = new System.Drawing.Size(785, 414);
            this.uctrlTablaConFiltroReporteSalida.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::ConsultasIkorMysql.Properties.Resources.images__1_;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExcel,
            this.toolStripSeparator1,
            this.tsbLimpiarP,
            this.tsbGeneraReporte});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(785, 39);
            this.toolStrip1.TabIndex = 7;
            // 
            // tsbExcel
            // 
            this.tsbExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExcel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbExcel.Image = global::ConsultasIkorMysql.Properties.Resources.excel_32;
            this.tsbExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(75, 36);
            this.tsbExcel.Text = "Excel";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbLimpiarP
            // 
            this.tsbLimpiarP.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLimpiarP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbLimpiarP.Image = global::ConsultasIkorMysql.Properties.Resources.monitor_321;
            this.tsbLimpiarP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLimpiarP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiarP.Name = "tsbLimpiarP";
            this.tsbLimpiarP.Size = new System.Drawing.Size(166, 36);
            this.tsbLimpiarP.Text = "Limpiar Pantalla";
            this.tsbLimpiarP.Click += new System.EventHandler(this.tsbLimpiarP_Click);
            // 
            // tsbGeneraReporte
            // 
            this.tsbGeneraReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGeneraReporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGeneraReporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbGeneraReporte.Image = global::ConsultasIkorMysql.Properties.Resources.engineering_32;
            this.tsbGeneraReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGeneraReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGeneraReporte.Name = "tsbGeneraReporte";
            this.tsbGeneraReporte.Size = new System.Drawing.Size(207, 36);
            this.tsbGeneraReporte.Text = "Genere su Reporte <<-";
            this.tsbGeneraReporte.Click += new System.EventHandler(this.tsbGeneraReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbNombreTabla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBDs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescione la Tecla [F1] para Generar su Reporte  ->> Presione [F2] para descargar" +
    " su [EXCEL] ->>";
            // 
            // cmbNombreTabla
            // 
            this.cmbNombreTabla.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbNombreTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreTabla.FormattingEnabled = true;
            this.cmbNombreTabla.Location = new System.Drawing.Point(406, 28);
            this.cmbNombreTabla.Name = "cmbNombreTabla";
            this.cmbNombreTabla.Size = new System.Drawing.Size(329, 21);
            this.cmbNombreTabla.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre de la tabla";
            // 
            // cmbBDs
            // 
            this.cmbBDs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbBDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBDs.FormattingEnabled = true;
            this.cmbBDs.Location = new System.Drawing.Point(81, 28);
            this.cmbBDs.Name = "cmbBDs";
            this.cmbBDs.Size = new System.Drawing.Size(211, 21);
            this.cmbBDs.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Base de Datos";
            // 
            // frmVistaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVistaReportes";
            this.Text = "Visualización  de Reportes";
            this.Load += new System.EventHandler(this.frmVistaReportes_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNombreTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBDs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsbGeneraReporte;
        private System.Windows.Forms.ToolStripButton tsbExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private uctrlTablaConFiltro uctrlTablaConFiltroReporteSalida;
        private System.Windows.Forms.ToolStripButton tsbLimpiarP;
    }
}