namespace WFAContact.Presentacion
{
    partial class fContact
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.gbtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gLblBuscar = new Guna.UI.WinForms.GunaLabel();
            this.gTxtDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.gTxtApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.gTxtTelefono = new Guna.UI.WinForms.GunaTextBox();
            this.gTxtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbtnMin = new Guna.UI.WinForms.GunaButton();
            this.gbtnMax = new Guna.UI.WinForms.GunaButton();
            this.gbtnExit = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 35;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 398);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbtnCancelar);
            this.panel4.Controls.Add(this.gbtnAceptar);
            this.panel4.Controls.Add(this.gunaLabel3);
            this.panel4.Controls.Add(this.gunaLabel2);
            this.panel4.Controls.Add(this.gunaLabel1);
            this.panel4.Controls.Add(this.gLblBuscar);
            this.panel4.Controls.Add(this.gTxtDireccion);
            this.panel4.Controls.Add(this.gTxtApellidos);
            this.panel4.Controls.Add(this.gTxtTelefono);
            this.panel4.Controls.Add(this.gTxtNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 329);
            this.panel4.TabIndex = 2;
            // 
            // gbtnCancelar
            // 
            this.gbtnCancelar.AnimationHoverSpeed = 0.07F;
            this.gbtnCancelar.AnimationSpeed = 0.03F;
            this.gbtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.gbtnCancelar.BaseColor = System.Drawing.Color.White;
            this.gbtnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnCancelar.BorderSize = 2;
            this.gbtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnCancelar.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnCancelar.Image = global::WFAContact.Properties.Resources.icons8_cancel_subscription_48px;
            this.gbtnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnCancelar.Location = new System.Drawing.Point(303, 260);
            this.gbtnCancelar.Name = "gbtnCancelar";
            this.gbtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnCancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnCancelar.OnHoverImage = global::WFAContact.Properties.Resources.icons8_cancel_subscription_48px_1;
            this.gbtnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnCancelar.Radius = 10;
            this.gbtnCancelar.Size = new System.Drawing.Size(153, 46);
            this.gbtnCancelar.TabIndex = 14;
            this.gbtnCancelar.Text = "Cancelar";
            this.gbtnCancelar.Click += new System.EventHandler(this.gbtnCancelar_Click);
            // 
            // gbtnAceptar
            // 
            this.gbtnAceptar.AnimationHoverSpeed = 0.07F;
            this.gbtnAceptar.AnimationSpeed = 0.03F;
            this.gbtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAceptar.BaseColor = System.Drawing.Color.White;
            this.gbtnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAceptar.BorderSize = 2;
            this.gbtnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAceptar.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnAceptar.Image = global::WFAContact.Properties.Resources.icons8_save_48px_3;
            this.gbtnAceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnAceptar.Location = new System.Drawing.Point(135, 260);
            this.gbtnAceptar.Name = "gbtnAceptar";
            this.gbtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnAceptar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAceptar.OnHoverImage = global::WFAContact.Properties.Resources.icons8_save_48px;
            this.gbtnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnAceptar.Radius = 10;
            this.gbtnAceptar.Size = new System.Drawing.Size(153, 46);
            this.gbtnAceptar.TabIndex = 13;
            this.gbtnAceptar.Text = "Aceptar";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaLabel3.Location = new System.Drawing.Point(23, 215);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(106, 25);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Dirección:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaLabel2.Location = new System.Drawing.Point(25, 93);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(104, 25);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Apellidos:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 154);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Telefono:";
            // 
            // gLblBuscar
            // 
            this.gLblBuscar.AutoSize = true;
            this.gLblBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Bold);
            this.gLblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gLblBuscar.Location = new System.Drawing.Point(37, 30);
            this.gLblBuscar.Name = "gLblBuscar";
            this.gLblBuscar.Size = new System.Drawing.Size(92, 25);
            this.gLblBuscar.TabIndex = 9;
            this.gLblBuscar.Text = "Nombre:";
            // 
            // gTxtDireccion
            // 
            this.gTxtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.gTxtDireccion.BaseColor = System.Drawing.SystemColors.Window;
            this.gTxtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtDireccion.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtDireccion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtDireccion.Location = new System.Drawing.Point(135, 206);
            this.gTxtDireccion.Name = "gTxtDireccion";
            this.gTxtDireccion.PasswordChar = '\0';
            this.gTxtDireccion.Radius = 15;
            this.gTxtDireccion.SelectedText = "";
            this.gTxtDireccion.Size = new System.Drawing.Size(321, 48);
            this.gTxtDireccion.TabIndex = 8;
            // 
            // gTxtApellidos
            // 
            this.gTxtApellidos.BackColor = System.Drawing.Color.Transparent;
            this.gTxtApellidos.BaseColor = System.Drawing.SystemColors.Window;
            this.gTxtApellidos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtApellidos.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtApellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtApellidos.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtApellidos.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtApellidos.Location = new System.Drawing.Point(135, 83);
            this.gTxtApellidos.Name = "gTxtApellidos";
            this.gTxtApellidos.PasswordChar = '\0';
            this.gTxtApellidos.Radius = 15;
            this.gTxtApellidos.SelectedText = "";
            this.gTxtApellidos.Size = new System.Drawing.Size(321, 48);
            this.gTxtApellidos.TabIndex = 7;
            // 
            // gTxtTelefono
            // 
            this.gTxtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.gTxtTelefono.BaseColor = System.Drawing.SystemColors.Window;
            this.gTxtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtTelefono.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtTelefono.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtTelefono.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtTelefono.Location = new System.Drawing.Point(135, 144);
            this.gTxtTelefono.Name = "gTxtTelefono";
            this.gTxtTelefono.PasswordChar = '\0';
            this.gTxtTelefono.Radius = 15;
            this.gTxtTelefono.SelectedText = "";
            this.gTxtTelefono.Size = new System.Drawing.Size(321, 48);
            this.gTxtTelefono.TabIndex = 6;
            // 
            // gTxtNombre
            // 
            this.gTxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.gTxtNombre.BaseColor = System.Drawing.SystemColors.Window;
            this.gTxtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtNombre.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNombre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNombre.Location = new System.Drawing.Point(135, 17);
            this.gTxtNombre.Name = "gTxtNombre";
            this.gTxtNombre.PasswordChar = '\0';
            this.gTxtNombre.Radius = 15;
            this.gTxtNombre.SelectedText = "";
            this.gTxtNombre.Size = new System.Drawing.Size(321, 48);
            this.gTxtNombre.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 31);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.gbtnMin);
            this.panel2.Controls.Add(this.gbtnMax);
            this.panel2.Controls.Add(this.gbtnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 38);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // gbtnMin
            // 
            this.gbtnMin.AnimationHoverSpeed = 0.07F;
            this.gbtnMin.AnimationSpeed = 0.03F;
            this.gbtnMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(61)))));
            this.gbtnMin.BorderColor = System.Drawing.Color.Black;
            this.gbtnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbtnMin.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnMin.ForeColor = System.Drawing.Color.White;
            this.gbtnMin.Image = global::WFAContact.Properties.Resources.min_64px;
            this.gbtnMin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnMin.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnMin.Location = new System.Drawing.Point(499, 0);
            this.gbtnMin.Name = "gbtnMin";
            this.gbtnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnMin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnMin.OnHoverImage = null;
            this.gbtnMin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnMin.Size = new System.Drawing.Size(40, 38);
            this.gbtnMin.TabIndex = 5;
            this.gbtnMin.Click += new System.EventHandler(this.gbtnMin_Click);
            // 
            // gbtnMax
            // 
            this.gbtnMax.AnimationHoverSpeed = 0.07F;
            this.gbtnMax.AnimationSpeed = 0.03F;
            this.gbtnMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.gbtnMax.BorderColor = System.Drawing.Color.Black;
            this.gbtnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbtnMax.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnMax.ForeColor = System.Drawing.Color.White;
            this.gbtnMax.Image = global::WFAContact.Properties.Resources.max_64px;
            this.gbtnMax.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnMax.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnMax.Location = new System.Drawing.Point(539, 0);
            this.gbtnMax.Name = "gbtnMax";
            this.gbtnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnMax.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnMax.OnHoverImage = null;
            this.gbtnMax.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnMax.Size = new System.Drawing.Size(40, 38);
            this.gbtnMax.TabIndex = 4;
            this.gbtnMax.Click += new System.EventHandler(this.gbtnMax_Click);
            // 
            // gbtnExit
            // 
            this.gbtnExit.AnimationHoverSpeed = 0.07F;
            this.gbtnExit.AnimationSpeed = 0.03F;
            this.gbtnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.gbtnExit.BorderColor = System.Drawing.Color.Black;
            this.gbtnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbtnExit.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnExit.ForeColor = System.Drawing.Color.White;
            this.gbtnExit.Image = global::WFAContact.Properties.Resources.exit_64px;
            this.gbtnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnExit.Location = new System.Drawing.Point(579, 0);
            this.gbtnExit.Name = "gbtnExit";
            this.gbtnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnExit.OnHoverImage = null;
            this.gbtnExit.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnExit.Size = new System.Drawing.Size(50, 38);
            this.gbtnExit.TabIndex = 3;
            this.gbtnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnExit.Click += new System.EventHandler(this.gbtnExit_Click);
            // 
            // fContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 398);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fContact";
            this.Text = "fContact";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton gbtnMin;
        private Guna.UI.WinForms.GunaButton gbtnMax;
        private Guna.UI.WinForms.GunaButton gbtnExit;
        private Guna.UI.WinForms.GunaTextBox gTxtNombre;
        private Guna.UI.WinForms.GunaTextBox gTxtTelefono;
        private Guna.UI.WinForms.GunaTextBox gTxtApellidos;
        private Guna.UI.WinForms.GunaTextBox gTxtDireccion;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gLblBuscar;
        private Guna.UI.WinForms.GunaButton gbtnCancelar;
        private Guna.UI.WinForms.GunaButton gbtnAceptar;
    }
}