
namespace Formulario
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_darkMode = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Hora = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmFyH = new System.Windows.Forms.Timer(this.components);
            this.rtb_Servicios = new System.Windows.Forms.RichTextBox();
            this.lb_Servicios = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_List = new System.Windows.Forms.Label();
            this.txt_nroCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_GuardarNuevosDatos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.chb_darkMode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_Hora);
            this.panel1.Controls.Add(this.lb_Fecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 138);
            this.panel1.TabIndex = 0;
            // 
            // chb_darkMode
            // 
            this.chb_darkMode.AutoSize = true;
            this.chb_darkMode.ForeColor = System.Drawing.Color.White;
            this.chb_darkMode.Location = new System.Drawing.Point(15, 23);
            this.chb_darkMode.Name = "chb_darkMode";
            this.chb_darkMode.Size = new System.Drawing.Size(81, 19);
            this.chb_darkMode.TabIndex = 5;
            this.chb_darkMode.Text = "DarkMode";
            this.chb_darkMode.UseVisualStyleBackColor = true;
            this.chb_darkMode.CheckedChanged += new System.EventHandler(this.chb_darkMode_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(178, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 118);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Hora
            // 
            this.lb_Hora.AutoSize = true;
            this.lb_Hora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Hora.Location = new System.Drawing.Point(1015, 112);
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(42, 21);
            this.lb_Hora.TabIndex = 3;
            this.lb_Hora.Text = "hora";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Fecha.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lb_Fecha.Location = new System.Drawing.Point(1015, 19);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Fecha.Size = new System.Drawing.Size(41, 19);
            this.lb_Fecha.TabIndex = 2;
            this.lb_Fecha.Text = "fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(358, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al Menu!";
            // 
            // tmFyH
            // 
            this.tmFyH.Tick += new System.EventHandler(this.tmFyH_Tick);
            // 
            // rtb_Servicios
            // 
            this.rtb_Servicios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_Servicios.DetectUrls = false;
            this.rtb_Servicios.Location = new System.Drawing.Point(12, 178);
            this.rtb_Servicios.Name = "rtb_Servicios";
            this.rtb_Servicios.ReadOnly = true;
            this.rtb_Servicios.Size = new System.Drawing.Size(443, 202);
            this.rtb_Servicios.TabIndex = 1;
            this.rtb_Servicios.Text = "";
            // 
            // lb_Servicios
            // 
            this.lb_Servicios.AutoSize = true;
            this.lb_Servicios.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Servicios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Servicios.Location = new System.Drawing.Point(94, 138);
            this.lb_Servicios.Name = "lb_Servicios";
            this.lb_Servicios.Size = new System.Drawing.Size(266, 37);
            this.lb_Servicios.TabIndex = 2;
            this.lb_Servicios.Text = "Servicios ofrecidos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(613, 383);
            this.dataGridView1.TabIndex = 4;
            // 
            // lb_List
            // 
            this.lb_List.AutoSize = true;
            this.lb_List.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_List.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_List.Location = new System.Drawing.Point(649, 131);
            this.lb_List.Name = "lb_List";
            this.lb_List.Size = new System.Drawing.Size(232, 37);
            this.lb_List.TabIndex = 5;
            this.lb_List.Text = "Lista de Clientes:";
            // 
            // txt_nroCliente
            // 
            this.txt_nroCliente.Location = new System.Drawing.Point(29, 71);
            this.txt_nroCliente.Name = "txt_nroCliente";
            this.txt_nroCliente.Size = new System.Drawing.Size(149, 23);
            this.txt_nroCliente.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btn_Buscar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_nroCliente);
            this.panel2.Location = new System.Drawing.Point(251, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 170);
            this.panel2.TabIndex = 7;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(29, 111);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(149, 32);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.Text = "Buscar Cliente";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(29, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese numero de Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Busqueda de Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.btn_Agregar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(35, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 113);
            this.panel3.TabIndex = 10;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 62);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(149, 32);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Agregar Cliente";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(23, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Añadir Cliente";
            // 
            // btn_GuardarNuevosDatos
            // 
            this.btn_GuardarNuevosDatos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_GuardarNuevosDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarNuevosDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_GuardarNuevosDatos.Location = new System.Drawing.Point(35, 526);
            this.btn_GuardarNuevosDatos.Name = "btn_GuardarNuevosDatos";
            this.btn_GuardarNuevosDatos.Size = new System.Drawing.Size(171, 35);
            this.btn_GuardarNuevosDatos.TabIndex = 11;
            this.btn_GuardarNuevosDatos.Text = "Guardar Datos";
            this.btn_GuardarNuevosDatos.UseVisualStyleBackColor = false;
            this.btn_GuardarNuevosDatos.Click += new System.EventHandler(this.btn_GuardarNuevosDatos_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 573);
            this.Controls.Add(this.btn_GuardarNuevosDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_List);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_Servicios);
            this.Controls.Add(this.rtb_Servicios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software de Obvio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Windows Form item generated code
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmFyH;
        private System.Windows.Forms.Label lb_Hora;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtb_Servicios;
        private System.Windows.Forms.Label lb_Servicios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_List;
        private System.Windows.Forms.TextBox txt_nroCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_GuardarNuevosDatos;
        private System.Windows.Forms.CheckBox chb_darkMode;
        #endregion

        /// <summary>
        /// Esta funcion se encarga de cargar el archivo de texto que contiene la informacion de 
        /// los servicios y asignarsela al RichTextBox.Text
        /// </summary>
        /// <param name="path"></param>
        /// <param name="servicios"></param>



    }



}

