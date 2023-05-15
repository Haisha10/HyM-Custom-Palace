
namespace Presentacion
{
    partial class Administrador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.cbxUsuariosEstado = new System.Windows.Forms.ComboBox();
            this.tbxUsuariosTelefono = new System.Windows.Forms.TextBox();
            this.tbxUsuariosCorreo = new System.Windows.Forms.TextBox();
            this.tbxUsuariosDni = new System.Windows.Forms.TextBox();
            this.btnUsuariosLimpiar = new System.Windows.Forms.Button();
            this.btnUsuariosEliminar = new System.Windows.Forms.Button();
            this.tbxUsuariosApellido = new System.Windows.Forms.TextBox();
            this.tbxUsuariosNombre = new System.Windows.Forms.TextBox();
            this.btnUsuariosModificar = new System.Windows.Forms.Button();
            this.tbxUsuariosContrasena = new System.Windows.Forms.TextBox();
            this.btnUsuariosAgregar = new System.Windows.Forms.Button();
            this.tbxUsuariosUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.tbxClienteTelefono = new System.Windows.Forms.TextBox();
            this.tbxClienteCorreo = new System.Windows.Forms.TextBox();
            this.tbxClienteDni = new System.Windows.Forms.TextBox();
            this.btnClienteLimpiar = new System.Windows.Forms.Button();
            this.btnClienteEliminar = new System.Windows.Forms.Button();
            this.tbxClienteApellido = new System.Windows.Forms.TextBox();
            this.tbxClienteNombre = new System.Windows.Forms.TextBox();
            this.btnClienteModificar = new System.Windows.Forms.Button();
            this.btnClienteAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.gbMascotas = new System.Windows.Forms.GroupBox();
            this.tbxMascotaEdad = new System.Windows.Forms.TextBox();
            this.btnMascotaLimpiar = new System.Windows.Forms.Button();
            this.btnMascotaEliminar = new System.Windows.Forms.Button();
            this.tbxMascotaTipo = new System.Windows.Forms.TextBox();
            this.tbxMascotaNombre = new System.Windows.Forms.TextBox();
            this.btnMascotaModificar = new System.Windows.Forms.Button();
            this.btnMascotaAgregar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgMascotas = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.gbMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnMascotas);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Controls.Add(this.btnUsuarios);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(16, 375);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMascotas.FlatAppearance.BorderSize = 0;
            this.btnMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMascotas.Location = new System.Drawing.Point(16, 101);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(114, 32);
            this.btnMascotas.TabIndex = 3;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = false;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(16, 63);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(114, 32);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.Location = new System.Drawing.Point(16, 25);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(114, 32);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.gbUsuarios.Controls.Add(this.cbxUsuariosEstado);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosTelefono);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosCorreo);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosDni);
            this.gbUsuarios.Controls.Add(this.btnUsuariosLimpiar);
            this.gbUsuarios.Controls.Add(this.btnUsuariosEliminar);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosApellido);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosNombre);
            this.gbUsuarios.Controls.Add(this.btnUsuariosModificar);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosContrasena);
            this.gbUsuarios.Controls.Add(this.btnUsuariosAgregar);
            this.gbUsuarios.Controls.Add(this.tbxUsuariosUsuario);
            this.gbUsuarios.Controls.Add(this.label8);
            this.gbUsuarios.Controls.Add(this.label7);
            this.gbUsuarios.Controls.Add(this.label6);
            this.gbUsuarios.Controls.Add(this.label5);
            this.gbUsuarios.Controls.Add(this.label4);
            this.gbUsuarios.Controls.Add(this.label3);
            this.gbUsuarios.Controls.Add(this.label2);
            this.gbUsuarios.Controls.Add(this.label1);
            this.gbUsuarios.Controls.Add(this.dgUsuarios);
            this.gbUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbUsuarios.Location = new System.Drawing.Point(170, 12);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(617, 425);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Usuarios";
            // 
            // cbxUsuariosEstado
            // 
            this.cbxUsuariosEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsuariosEstado.FormattingEnabled = true;
            this.cbxUsuariosEstado.Items.AddRange(new object[] {
            "Recepcionista",
            "Administrador",
            "Inactivo"});
            this.cbxUsuariosEstado.Location = new System.Drawing.Point(115, 278);
            this.cbxUsuariosEstado.Name = "cbxUsuariosEstado";
            this.cbxUsuariosEstado.Size = new System.Drawing.Size(168, 24);
            this.cbxUsuariosEstado.TabIndex = 3;
            // 
            // tbxUsuariosTelefono
            // 
            this.tbxUsuariosTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosTelefono.Location = new System.Drawing.Point(392, 328);
            this.tbxUsuariosTelefono.Name = "tbxUsuariosTelefono";
            this.tbxUsuariosTelefono.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosTelefono.TabIndex = 8;
            // 
            // tbxUsuariosCorreo
            // 
            this.tbxUsuariosCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosCorreo.Location = new System.Drawing.Point(392, 300);
            this.tbxUsuariosCorreo.Name = "tbxUsuariosCorreo";
            this.tbxUsuariosCorreo.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosCorreo.TabIndex = 7;
            // 
            // tbxUsuariosDni
            // 
            this.tbxUsuariosDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosDni.Location = new System.Drawing.Point(392, 275);
            this.tbxUsuariosDni.Name = "tbxUsuariosDni";
            this.tbxUsuariosDni.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosDni.TabIndex = 6;
            // 
            // btnUsuariosLimpiar
            // 
            this.btnUsuariosLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuariosLimpiar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuariosLimpiar.Location = new System.Drawing.Point(446, 374);
            this.btnUsuariosLimpiar.Name = "btnUsuariosLimpiar";
            this.btnUsuariosLimpiar.Size = new System.Drawing.Size(114, 32);
            this.btnUsuariosLimpiar.TabIndex = 12;
            this.btnUsuariosLimpiar.Text = "Limpiar";
            this.btnUsuariosLimpiar.UseVisualStyleBackColor = false;
            this.btnUsuariosLimpiar.Click += new System.EventHandler(this.btnUsuariosLimpiar_Click);
            // 
            // btnUsuariosEliminar
            // 
            this.btnUsuariosEliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuariosEliminar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuariosEliminar.Location = new System.Drawing.Point(306, 374);
            this.btnUsuariosEliminar.Name = "btnUsuariosEliminar";
            this.btnUsuariosEliminar.Size = new System.Drawing.Size(114, 32);
            this.btnUsuariosEliminar.TabIndex = 11;
            this.btnUsuariosEliminar.Text = "Eliminar";
            this.btnUsuariosEliminar.UseVisualStyleBackColor = false;
            this.btnUsuariosEliminar.Click += new System.EventHandler(this.btnUsuariosEliminar_Click);
            // 
            // tbxUsuariosApellido
            // 
            this.tbxUsuariosApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosApellido.Location = new System.Drawing.Point(392, 248);
            this.tbxUsuariosApellido.Name = "tbxUsuariosApellido";
            this.tbxUsuariosApellido.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosApellido.TabIndex = 5;
            // 
            // tbxUsuariosNombre
            // 
            this.tbxUsuariosNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosNombre.Location = new System.Drawing.Point(392, 221);
            this.tbxUsuariosNombre.Name = "tbxUsuariosNombre";
            this.tbxUsuariosNombre.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosNombre.TabIndex = 4;
            // 
            // btnUsuariosModificar
            // 
            this.btnUsuariosModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuariosModificar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuariosModificar.Location = new System.Drawing.Point(170, 374);
            this.btnUsuariosModificar.Name = "btnUsuariosModificar";
            this.btnUsuariosModificar.Size = new System.Drawing.Size(114, 32);
            this.btnUsuariosModificar.TabIndex = 10;
            this.btnUsuariosModificar.Text = "Modificar";
            this.btnUsuariosModificar.UseVisualStyleBackColor = false;
            this.btnUsuariosModificar.Click += new System.EventHandler(this.btnUsuariosModificar_Click);
            // 
            // tbxUsuariosContrasena
            // 
            this.tbxUsuariosContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosContrasena.Location = new System.Drawing.Point(115, 249);
            this.tbxUsuariosContrasena.Name = "tbxUsuariosContrasena";
            this.tbxUsuariosContrasena.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosContrasena.TabIndex = 2;
            // 
            // btnUsuariosAgregar
            // 
            this.btnUsuariosAgregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuariosAgregar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuariosAgregar.Location = new System.Drawing.Point(38, 374);
            this.btnUsuariosAgregar.Name = "btnUsuariosAgregar";
            this.btnUsuariosAgregar.Size = new System.Drawing.Size(114, 32);
            this.btnUsuariosAgregar.TabIndex = 9;
            this.btnUsuariosAgregar.Text = "Agregar";
            this.btnUsuariosAgregar.UseVisualStyleBackColor = false;
            this.btnUsuariosAgregar.Click += new System.EventHandler(this.btnUsuariosAgregar_Click);
            // 
            // tbxUsuariosUsuario
            // 
            this.tbxUsuariosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuariosUsuario.Location = new System.Drawing.Point(115, 221);
            this.tbxUsuariosUsuario.Name = "tbxUsuariosUsuario";
            this.tbxUsuariosUsuario.Size = new System.Drawing.Size(168, 22);
            this.tbxUsuariosUsuario.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgUsuarios.Location = new System.Drawing.Point(17, 24);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.Size = new System.Drawing.Size(582, 169);
            this.dgUsuarios.TabIndex = 0;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);
            // 
            // gbClientes
            // 
            this.gbClientes.BackColor = System.Drawing.Color.Transparent;
            this.gbClientes.Controls.Add(this.tbxClienteTelefono);
            this.gbClientes.Controls.Add(this.tbxClienteCorreo);
            this.gbClientes.Controls.Add(this.tbxClienteDni);
            this.gbClientes.Controls.Add(this.btnClienteLimpiar);
            this.gbClientes.Controls.Add(this.btnClienteEliminar);
            this.gbClientes.Controls.Add(this.tbxClienteApellido);
            this.gbClientes.Controls.Add(this.tbxClienteNombre);
            this.gbClientes.Controls.Add(this.btnClienteModificar);
            this.gbClientes.Controls.Add(this.btnClienteAgregar);
            this.gbClientes.Controls.Add(this.label9);
            this.gbClientes.Controls.Add(this.label10);
            this.gbClientes.Controls.Add(this.label11);
            this.gbClientes.Controls.Add(this.label12);
            this.gbClientes.Controls.Add(this.label13);
            this.gbClientes.Controls.Add(this.dgClientes);
            this.gbClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbClientes.Location = new System.Drawing.Point(170, 13);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(617, 425);
            this.gbClientes.TabIndex = 1;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // tbxClienteTelefono
            // 
            this.tbxClienteTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClienteTelefono.Location = new System.Drawing.Point(252, 322);
            this.tbxClienteTelefono.Name = "tbxClienteTelefono";
            this.tbxClienteTelefono.Size = new System.Drawing.Size(168, 22);
            this.tbxClienteTelefono.TabIndex = 5;
            // 
            // tbxClienteCorreo
            // 
            this.tbxClienteCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClienteCorreo.Location = new System.Drawing.Point(252, 294);
            this.tbxClienteCorreo.Name = "tbxClienteCorreo";
            this.tbxClienteCorreo.Size = new System.Drawing.Size(168, 22);
            this.tbxClienteCorreo.TabIndex = 4;
            // 
            // tbxClienteDni
            // 
            this.tbxClienteDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClienteDni.Location = new System.Drawing.Point(252, 269);
            this.tbxClienteDni.Name = "tbxClienteDni";
            this.tbxClienteDni.Size = new System.Drawing.Size(168, 22);
            this.tbxClienteDni.TabIndex = 3;
            // 
            // btnClienteLimpiar
            // 
            this.btnClienteLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteLimpiar.FlatAppearance.BorderSize = 0;
            this.btnClienteLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClienteLimpiar.Location = new System.Drawing.Point(446, 374);
            this.btnClienteLimpiar.Name = "btnClienteLimpiar";
            this.btnClienteLimpiar.Size = new System.Drawing.Size(114, 32);
            this.btnClienteLimpiar.TabIndex = 9;
            this.btnClienteLimpiar.Text = "Limpiar";
            this.btnClienteLimpiar.UseVisualStyleBackColor = false;
            this.btnClienteLimpiar.Click += new System.EventHandler(this.btnClientesLimpiar_Click);
            // 
            // btnClienteEliminar
            // 
            this.btnClienteEliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteEliminar.FlatAppearance.BorderSize = 0;
            this.btnClienteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClienteEliminar.Location = new System.Drawing.Point(306, 374);
            this.btnClienteEliminar.Name = "btnClienteEliminar";
            this.btnClienteEliminar.Size = new System.Drawing.Size(114, 32);
            this.btnClienteEliminar.TabIndex = 8;
            this.btnClienteEliminar.Text = "Eliminar";
            this.btnClienteEliminar.UseVisualStyleBackColor = false;
            this.btnClienteEliminar.Click += new System.EventHandler(this.btnClientesEliminar_Click);
            // 
            // tbxClienteApellido
            // 
            this.tbxClienteApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClienteApellido.Location = new System.Drawing.Point(252, 242);
            this.tbxClienteApellido.Name = "tbxClienteApellido";
            this.tbxClienteApellido.Size = new System.Drawing.Size(168, 22);
            this.tbxClienteApellido.TabIndex = 2;
            // 
            // tbxClienteNombre
            // 
            this.tbxClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClienteNombre.Location = new System.Drawing.Point(252, 215);
            this.tbxClienteNombre.Name = "tbxClienteNombre";
            this.tbxClienteNombre.Size = new System.Drawing.Size(168, 22);
            this.tbxClienteNombre.TabIndex = 1;
            // 
            // btnClienteModificar
            // 
            this.btnClienteModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteModificar.FlatAppearance.BorderSize = 0;
            this.btnClienteModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClienteModificar.Location = new System.Drawing.Point(170, 374);
            this.btnClienteModificar.Name = "btnClienteModificar";
            this.btnClienteModificar.Size = new System.Drawing.Size(114, 32);
            this.btnClienteModificar.TabIndex = 7;
            this.btnClienteModificar.Text = "Modificar";
            this.btnClienteModificar.UseVisualStyleBackColor = false;
            this.btnClienteModificar.Click += new System.EventHandler(this.btnClientesModificar_Click);
            // 
            // btnClienteAgregar
            // 
            this.btnClienteAgregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteAgregar.FlatAppearance.BorderSize = 0;
            this.btnClienteAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClienteAgregar.Location = new System.Drawing.Point(38, 374);
            this.btnClienteAgregar.Name = "btnClienteAgregar";
            this.btnClienteAgregar.Size = new System.Drawing.Size(114, 32);
            this.btnClienteAgregar.TabIndex = 6;
            this.btnClienteAgregar.Text = "Agregar";
            this.btnClienteAgregar.UseVisualStyleBackColor = false;
            this.btnClienteAgregar.Click += new System.EventHandler(this.btnClientesAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Correo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "DNI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Apellido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(180, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombre";
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgClientes.Location = new System.Drawing.Point(17, 24);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(582, 169);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // gbMascotas
            // 
            this.gbMascotas.BackColor = System.Drawing.Color.Transparent;
            this.gbMascotas.Controls.Add(this.tbxMascotaEdad);
            this.gbMascotas.Controls.Add(this.btnMascotaLimpiar);
            this.gbMascotas.Controls.Add(this.btnMascotaEliminar);
            this.gbMascotas.Controls.Add(this.tbxMascotaTipo);
            this.gbMascotas.Controls.Add(this.tbxMascotaNombre);
            this.gbMascotas.Controls.Add(this.btnMascotaModificar);
            this.gbMascotas.Controls.Add(this.btnMascotaAgregar);
            this.gbMascotas.Controls.Add(this.label16);
            this.gbMascotas.Controls.Add(this.label17);
            this.gbMascotas.Controls.Add(this.label18);
            this.gbMascotas.Controls.Add(this.dgMascotas);
            this.gbMascotas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMascotas.Location = new System.Drawing.Point(171, 14);
            this.gbMascotas.Name = "gbMascotas";
            this.gbMascotas.Size = new System.Drawing.Size(617, 425);
            this.gbMascotas.TabIndex = 1;
            this.gbMascotas.TabStop = false;
            this.gbMascotas.Text = "Mascotas";
            // 
            // tbxMascotaEdad
            // 
            this.tbxMascotaEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMascotaEdad.Location = new System.Drawing.Point(252, 269);
            this.tbxMascotaEdad.Name = "tbxMascotaEdad";
            this.tbxMascotaEdad.Size = new System.Drawing.Size(168, 22);
            this.tbxMascotaEdad.TabIndex = 3;
            // 
            // btnMascotaLimpiar
            // 
            this.btnMascotaLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMascotaLimpiar.FlatAppearance.BorderSize = 0;
            this.btnMascotaLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotaLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMascotaLimpiar.Location = new System.Drawing.Point(446, 374);
            this.btnMascotaLimpiar.Name = "btnMascotaLimpiar";
            this.btnMascotaLimpiar.Size = new System.Drawing.Size(114, 32);
            this.btnMascotaLimpiar.TabIndex = 7;
            this.btnMascotaLimpiar.Text = "Limpiar";
            this.btnMascotaLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnMascotaEliminar
            // 
            this.btnMascotaEliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMascotaEliminar.FlatAppearance.BorderSize = 0;
            this.btnMascotaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotaEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMascotaEliminar.Location = new System.Drawing.Point(306, 374);
            this.btnMascotaEliminar.Name = "btnMascotaEliminar";
            this.btnMascotaEliminar.Size = new System.Drawing.Size(114, 32);
            this.btnMascotaEliminar.TabIndex = 6;
            this.btnMascotaEliminar.Text = "Eliminar";
            this.btnMascotaEliminar.UseVisualStyleBackColor = false;
            this.btnMascotaEliminar.Click += new System.EventHandler(this.btnMascotaEliminar_Click);
            // 
            // tbxMascotaTipo
            // 
            this.tbxMascotaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMascotaTipo.Location = new System.Drawing.Point(252, 242);
            this.tbxMascotaTipo.Name = "tbxMascotaTipo";
            this.tbxMascotaTipo.Size = new System.Drawing.Size(168, 22);
            this.tbxMascotaTipo.TabIndex = 2;
            // 
            // tbxMascotaNombre
            // 
            this.tbxMascotaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMascotaNombre.Location = new System.Drawing.Point(252, 215);
            this.tbxMascotaNombre.Name = "tbxMascotaNombre";
            this.tbxMascotaNombre.Size = new System.Drawing.Size(168, 22);
            this.tbxMascotaNombre.TabIndex = 1;
            // 
            // btnMascotaModificar
            // 
            this.btnMascotaModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMascotaModificar.FlatAppearance.BorderSize = 0;
            this.btnMascotaModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotaModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMascotaModificar.Location = new System.Drawing.Point(170, 374);
            this.btnMascotaModificar.Name = "btnMascotaModificar";
            this.btnMascotaModificar.Size = new System.Drawing.Size(114, 32);
            this.btnMascotaModificar.TabIndex = 5;
            this.btnMascotaModificar.Text = "Modificar";
            this.btnMascotaModificar.UseVisualStyleBackColor = false;
            this.btnMascotaModificar.Click += new System.EventHandler(this.btnMascotaModificar_Click);
            // 
            // btnMascotaAgregar
            // 
            this.btnMascotaAgregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMascotaAgregar.FlatAppearance.BorderSize = 0;
            this.btnMascotaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotaAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMascotaAgregar.Location = new System.Drawing.Point(38, 374);
            this.btnMascotaAgregar.Name = "btnMascotaAgregar";
            this.btnMascotaAgregar.Size = new System.Drawing.Size(114, 32);
            this.btnMascotaAgregar.TabIndex = 4;
            this.btnMascotaAgregar.Text = "Agregar";
            this.btnMascotaAgregar.UseVisualStyleBackColor = false;
            this.btnMascotaAgregar.Click += new System.EventHandler(this.btnMascotaAgregar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(142, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Edad (meses)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(142, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tipo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(142, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nombre";
            // 
            // dgMascotas
            // 
            this.dgMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMascotas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgMascotas.Location = new System.Drawing.Point(97, 23);
            this.dgMascotas.Name = "dgMascotas";
            this.dgMascotas.Size = new System.Drawing.Size(436, 167);
            this.dgMascotas.TabIndex = 0;
            this.dgMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMascotas_CellClick);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 454);
            this.Controls.Add(this.gbMascotas);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbClientes);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.gbMascotas.ResumeLayout(false);
            this.gbMascotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.ComboBox cbxUsuariosEstado;
        private System.Windows.Forms.TextBox tbxUsuariosTelefono;
        private System.Windows.Forms.TextBox tbxUsuariosCorreo;
        private System.Windows.Forms.TextBox tbxUsuariosDni;
        private System.Windows.Forms.Button btnUsuariosEliminar;
        private System.Windows.Forms.TextBox tbxUsuariosApellido;
        private System.Windows.Forms.TextBox tbxUsuariosNombre;
        private System.Windows.Forms.Button btnUsuariosModificar;
        private System.Windows.Forms.TextBox tbxUsuariosContrasena;
        private System.Windows.Forms.Button btnUsuariosAgregar;
        private System.Windows.Forms.TextBox tbxUsuariosUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button btnUsuariosLimpiar;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.TextBox tbxClienteTelefono;
        private System.Windows.Forms.TextBox tbxClienteCorreo;
        private System.Windows.Forms.TextBox tbxClienteDni;
        private System.Windows.Forms.Button btnClienteLimpiar;
        private System.Windows.Forms.Button btnClienteEliminar;
        private System.Windows.Forms.TextBox tbxClienteApellido;
        private System.Windows.Forms.TextBox tbxClienteNombre;
        private System.Windows.Forms.Button btnClienteModificar;
        private System.Windows.Forms.Button btnClienteAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.GroupBox gbMascotas;
        private System.Windows.Forms.TextBox tbxMascotaEdad;
        private System.Windows.Forms.Button btnMascotaLimpiar;
        private System.Windows.Forms.Button btnMascotaEliminar;
        private System.Windows.Forms.TextBox tbxMascotaTipo;
        private System.Windows.Forms.TextBox tbxMascotaNombre;
        private System.Windows.Forms.Button btnMascotaModificar;
        private System.Windows.Forms.Button btnMascotaAgregar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgMascotas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

