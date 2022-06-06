
namespace Formulario
{
    partial class Frm_ABM
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
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_nroCliente = new System.Windows.Forms.TextBox();
            this.lb_Documento = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.lb_code = new System.Windows.Forms.Label();
            this.lb_nroCliente = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(12, 31);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(185, 23);
            this.txt_Documento.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 75);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(185, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(13, 119);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(184, 23);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(12, 163);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(185, 23);
            this.txt_code.TabIndex = 3;
            // 
            // txt_nroCliente
            // 
            this.txt_nroCliente.Location = new System.Drawing.Point(12, 207);
            this.txt_nroCliente.Name = "txt_nroCliente";
            this.txt_nroCliente.ReadOnly = true;
            this.txt_nroCliente.Size = new System.Drawing.Size(185, 23);
            this.txt_nroCliente.TabIndex = 4;
            // 
            // lb_Documento
            // 
            this.lb_Documento.AutoSize = true;
            this.lb_Documento.Location = new System.Drawing.Point(13, 10);
            this.lb_Documento.Name = "lb_Documento";
            this.lb_Documento.Size = new System.Drawing.Size(113, 15);
            this.lb_Documento.TabIndex = 5;
            this.lb_Documento.Text = "Ingrese documento:";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(12, 57);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(93, 15);
            this.lb_Nombre.TabIndex = 6;
            this.lb_Nombre.Text = "Ingrese nombre:";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Location = new System.Drawing.Point(13, 101);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(93, 15);
            this.lb_Apellido.TabIndex = 7;
            this.lb_Apellido.Text = "Ingrese apellido:";
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Location = new System.Drawing.Point(12, 145);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(130, 15);
            this.lb_code.TabIndex = 8;
            this.lb_code.Text = "Ingrese código de Plan:";
            // 
            // lb_nroCliente
            // 
            this.lb_nroCliente.AutoSize = true;
            this.lb_nroCliente.Location = new System.Drawing.Point(12, 189);
            this.lb_nroCliente.Name = "lb_nroCliente";
            this.lb_nroCliente.Size = new System.Drawing.Size(108, 15);
            this.lb_nroCliente.TabIndex = 9;
            this.lb_nroCliente.Text = "Número de cliente:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 237);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(82, 39);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(112, 237);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 39);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(13, 292);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(81, 23);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(112, 292);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(83, 23);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Frm_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 337);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lb_nroCliente);
            this.Controls.Add(this.lb_code);
            this.Controls.Add(this.lb_Apellido);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.lb_Documento);
            this.Controls.Add(this.txt_nroCliente);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Documento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_nroCliente;
        private System.Windows.Forms.Label lb_Documento;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Apellido;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.Label lb_nroCliente;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}