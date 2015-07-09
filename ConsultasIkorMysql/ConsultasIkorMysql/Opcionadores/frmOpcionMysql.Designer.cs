namespace ConsultasIkorMysql.Opcionadores
{
    partial class frmOpcionMysql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcionMysql));
            this.btnRegistros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.TSL_TITTLE = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServidorMysql = new System.Windows.Forms.Button();
            this.tspTittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackgroundImage = global::ConsultasIkorMysql.Properties.Resources.google_blog_search_1281;
            this.btnRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistros.Location = new System.Drawing.Point(243, 53);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(156, 131);
            this.btnRegistros.TabIndex = 0;
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "[Consultar Registros]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::ConsultasIkorMysql.Properties.Resources.images1;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_TITTLE,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(713, 25);
            this.tspTittle.TabIndex = 4;
            // 
            // TSL_TITTLE
            // 
            this.TSL_TITTLE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_TITTLE.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSL_TITTLE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TSL_TITTLE.Name = "TSL_TITTLE";
            this.TSL_TITTLE.Size = new System.Drawing.Size(177, 22);
            this.TSL_TITTLE.Text = "  Seleccione su opción  <- ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.Image = global::ConsultasIkorMysql.Properties.Resources.delete_32;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "[Servidor Mysql]";
            // 
            // btnServidorMysql
            // 
            this.btnServidorMysql.Image = global::ConsultasIkorMysql.Properties.Resources.mysql_128;
            this.btnServidorMysql.Location = new System.Drawing.Point(32, 53);
            this.btnServidorMysql.Name = "btnServidorMysql";
            this.btnServidorMysql.Size = new System.Drawing.Size(156, 131);
            this.btnServidorMysql.TabIndex = 6;
            this.btnServidorMysql.UseVisualStyleBackColor = true;
            this.btnServidorMysql.Click += new System.EventHandler(this.btnServidorMysql_Click);
            // 
            // frmOpcionMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnServidorMysql);
            this.Controls.Add(this.tspTittle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcionMysql";
            this.Text = "  Seleccione su opción <- ";
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel TSL_TITTLE;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnServidorMysql;
    }
}