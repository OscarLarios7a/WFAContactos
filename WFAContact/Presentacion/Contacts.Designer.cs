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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gbtnExit = new Guna.UI.WinForms.GunaButton();
            this.gbtnMax = new Guna.UI.WinForms.GunaButton();
            this.gbtnMin = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
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
            this.gunaPanel1.Size = new System.Drawing.Size(885, 40);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseDown);
            this.gunaPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseMove);
            this.gunaPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseUp);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 555);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(885, 26);
            this.gunaPanel2.TabIndex = 1;
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
            this.gbtnExit.Location = new System.Drawing.Point(835, 0);
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
            this.gbtnMax.Location = new System.Drawing.Point(795, 0);
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
            this.gbtnMin.Location = new System.Drawing.Point(755, 0);
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
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 581);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gbtnMin;
        private Guna.UI.WinForms.GunaButton gbtnMax;
        private Guna.UI.WinForms.GunaButton gbtnExit;
    }
}