namespace VideotiendaWFApp.Views
{
    partial class FrmDominios
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
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.IblId = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnElimiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbxFiltro.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.btnLimpiar);
            this.gbxFiltro.Controls.Add(this.btnBuscar);
            this.gbxFiltro.Controls.Add(this.txtValor);
            this.gbxFiltro.Controls.Add(this.txtId);
            this.gbxFiltro.Controls.Add(this.txtTipo);
            this.gbxFiltro.Controls.Add(this.lblValor);
            this.gbxFiltro.Controls.Add(this.IblId);
            this.gbxFiltro.Controls.Add(this.lblTipo);
            this.gbxFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(908, 145);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Filtro de busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(629, 87);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(133, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 21);
            this.txtValor.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(475, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 21);
            this.txtId.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(133, 38);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(200, 21);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(34, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(98, 15);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor Dominio";
            // 
            // IblId
            // 
            this.IblId.AutoSize = true;
            this.IblId.Location = new System.Drawing.Point(368, 41);
            this.IblId.Name = "IblId";
            this.IblId.Size = new System.Drawing.Size(73, 15);
            this.IblId.TabIndex = 1;
            this.IblId.Text = "Id Domino";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(34, 38);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(93, 15);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo Dominio";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.grDatos);
            this.gbxDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(12, 163);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(908, 216);
            this.gbxDatos.TabIndex = 1;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Dominios";
            // 
            // grDatos
            // 
            this.grDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDatos.Location = new System.Drawing.Point(3, 17);
            this.grDatos.MultiSelect = false;
            this.grDatos.Name = "grDatos";
            this.grDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDatos.Size = new System.Drawing.Size(902, 196);
            this.grDatos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(59, 402);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(248, 402);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnElimiar
            // 
            this.btnElimiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimiar.Location = new System.Drawing.Point(487, 402);
            this.btnElimiar.Name = "btnElimiar";
            this.btnElimiar.Size = new System.Drawing.Size(100, 30);
            this.btnElimiar.TabIndex = 4;
            this.btnElimiar.Text = "Eliminar";
            this.btnElimiar.UseVisualStyleBackColor = true;
            this.btnElimiar.Click += new System.EventHandler(this.btnElimiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(767, 402);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmDominios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 453);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnElimiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxFiltro);
            this.Name = "FrmDominios";
            this.Text = "FrmDominios";
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label IblId;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnElimiar;
        private System.Windows.Forms.Button btnRegresar;
    }
}