namespace WFAContact.Presentacion
{
    partial class Contacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gbtnMin = new Guna.UI.WinForms.GunaButton();
            this.gbtnMax = new Guna.UI.WinForms.GunaButton();
            this.gbtnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gLblBuscar = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.lContactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gbtnAgregar = new Guna.UI.WinForms.GunaButton();
            this.gbtnBuscar = new Guna.UI.WinForms.GunaButton();
            this.gTxtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.lContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdgvContactos = new Guna.UI.WinForms.GunaDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lContactBindingSource1)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 35;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gunaPanel1.Controls.Add(this.gbtnMin);
            this.gunaPanel1.Controls.Add(this.gbtnMax);
            this.gunaPanel1.Controls.Add(this.gbtnExit);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(942, 40);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            this.gunaPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseDown);
            this.gunaPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseMove);
            this.gunaPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseUp);
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
            this.gbtnMin.Location = new System.Drawing.Point(812, 0);
            this.gbtnMin.Name = "gbtnMin";
            this.gbtnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnMin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnMin.OnHoverImage = null;
            this.gbtnMin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnMin.Size = new System.Drawing.Size(40, 40);
            this.gbtnMin.TabIndex = 2;
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
            this.gbtnMax.Location = new System.Drawing.Point(852, 0);
            this.gbtnMax.Name = "gbtnMax";
            this.gbtnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnMax.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnMax.OnHoverImage = null;
            this.gbtnMax.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnMax.Size = new System.Drawing.Size(40, 40);
            this.gbtnMax.TabIndex = 1;
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
            this.gbtnExit.Location = new System.Drawing.Point(892, 0);
            this.gbtnExit.Name = "gbtnExit";
            this.gbtnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnExit.OnHoverImage = null;
            this.gbtnExit.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnExit.Size = new System.Drawing.Size(50, 40);
            this.gbtnExit.TabIndex = 0;
            this.gbtnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnExit.Click += new System.EventHandler(this.gbtnExit_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 583);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(942, 26);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gLblBuscar
            // 
            this.gLblBuscar.AutoSize = true;
            this.gLblBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Bold);
            this.gLblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gLblBuscar.Location = new System.Drawing.Point(27, 24);
            this.gLblBuscar.Name = "gLblBuscar";
            this.gLblBuscar.Size = new System.Drawing.Size(79, 25);
            this.gLblBuscar.TabIndex = 3;
            this.gLblBuscar.Text = "Buscar:";
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaPanel5);
            this.gunaPanel3.Controls.Add(this.gunaPanel4);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 40);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(942, 543);
            this.gunaPanel3.TabIndex = 4;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.Controls.Add(this.gdgvContactos);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 75);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(942, 468);
            this.gunaPanel5.TabIndex = 6;
            // 
            // lContactBindingSource1
            // 
            this.lContactBindingSource1.DataSource = typeof(WFAContact.Logica.lContact);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.gbtnAgregar);
            this.gunaPanel4.Controls.Add(this.gbtnBuscar);
            this.gunaPanel4.Controls.Add(this.gTxtBuscar);
            this.gunaPanel4.Controls.Add(this.gLblBuscar);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(942, 75);
            this.gunaPanel4.TabIndex = 5;
            // 
            // gbtnAgregar
            // 
            this.gbtnAgregar.AnimationHoverSpeed = 0.07F;
            this.gbtnAgregar.AnimationSpeed = 0.03F;
            this.gbtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAgregar.BaseColor = System.Drawing.Color.White;
            this.gbtnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAgregar.BorderSize = 2;
            this.gbtnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAgregar.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnAgregar.Image = global::WFAContact.Properties.Resources.icons8_add_new_48px;
            this.gbtnAgregar.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnAgregar.Location = new System.Drawing.Point(734, 14);
            this.gbtnAgregar.Name = "gbtnAgregar";
            this.gbtnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnAgregar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAgregar.OnHoverImage = global::WFAContact.Properties.Resources.icons8_add_new_48px_1;
            this.gbtnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnAgregar.Radius = 10;
            this.gbtnAgregar.Size = new System.Drawing.Size(139, 46);
            this.gbtnAgregar.TabIndex = 6;
            this.gbtnAgregar.Text = "Agregar";
            this.gbtnAgregar.Click += new System.EventHandler(this.gbtnAgregar_Click);
            // 
            // gbtnBuscar
            // 
            this.gbtnBuscar.AnimationHoverSpeed = 0.07F;
            this.gbtnBuscar.AnimationSpeed = 0.03F;
            this.gbtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gbtnBuscar.BaseColor = System.Drawing.Color.White;
            this.gbtnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBuscar.BorderSize = 2;
            this.gbtnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnBuscar.Image = global::WFAContact.Properties.Resources.icons8_google_web_search_60px;
            this.gbtnBuscar.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnBuscar.Location = new System.Drawing.Point(589, 14);
            this.gbtnBuscar.Name = "gbtnBuscar";
            this.gbtnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnBuscar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnBuscar.OnHoverImage = global::WFAContact.Properties.Resources.icons8_search_48px_1;
            this.gbtnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnBuscar.Radius = 10;
            this.gbtnBuscar.Size = new System.Drawing.Size(130, 46);
            this.gbtnBuscar.TabIndex = 5;
            this.gbtnBuscar.Text = "Buscar";
            this.gbtnBuscar.Click += new System.EventHandler(this.gbtnBuscar_Click);
            // 
            // gTxtBuscar
            // 
            this.gTxtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gTxtBuscar.BaseColor = System.Drawing.SystemColors.Window;
            this.gTxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtBuscar.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscar.Location = new System.Drawing.Point(112, 15);
            this.gTxtBuscar.Name = "gTxtBuscar";
            this.gTxtBuscar.PasswordChar = '\0';
            this.gTxtBuscar.Radius = 15;
            this.gTxtBuscar.SelectedText = "";
            this.gTxtBuscar.Size = new System.Drawing.Size(464, 45);
            this.gTxtBuscar.TabIndex = 4;
            // 
            // lContactBindingSource
            // 
            this.lContactBindingSource.DataSource = typeof(WFAContact.Logica.lContact);
            // 
            // gdgvContactos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdgvContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdgvContactos.AutoGenerateColumns = false;
            this.gdgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvContactos.BackgroundColor = System.Drawing.Color.White;
            this.gdgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.gdgvContactos.DataSource = this.lContactBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvContactos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdgvContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdgvContactos.EnableHeadersVisualStyles = false;
            this.gdgvContactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvContactos.Location = new System.Drawing.Point(0, 0);
            this.gdgvContactos.Name = "gdgvContactos";
            this.gdgvContactos.RowHeadersVisible = false;
            this.gdgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvContactos.Size = new System.Drawing.Size(942, 468);
            this.gdgvContactos.TabIndex = 0;
            this.gdgvContactos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgvContactos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvContactos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvContactos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvContactos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvContactos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvContactos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdgvContactos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvContactos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvContactos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvContactos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvContactos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvContactos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdgvContactos.ThemeStyle.HeaderStyle.Height = 21;
            this.gdgvContactos.ThemeStyle.ReadOnly = false;
            this.gdgvContactos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvContactos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvContactos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvContactos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvContactos.ThemeStyle.RowsStyle.Height = 22;
            this.gdgvContactos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvContactos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(942, 609);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contacts_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lContactBindingSource1)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gbtnMin;
        private Guna.UI.WinForms.GunaButton gbtnMax;
        private Guna.UI.WinForms.GunaButton gbtnExit;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaLabel gLblBuscar;
        private Guna.UI.WinForms.GunaTextBox gTxtBuscar;
        private Guna.UI.WinForms.GunaButton gbtnAgregar;
        private Guna.UI.WinForms.GunaButton gbtnBuscar;
        private System.Windows.Forms.BindingSource lContactBindingSource;
        private System.Windows.Forms.BindingSource lContactBindingSource1;
        private Guna.UI.WinForms.GunaDataGridView gdgvContactos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}