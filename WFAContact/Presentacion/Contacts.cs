using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAContact.Presentacion
{
    public partial class Contacts : Form
    {
        int m, mx, my;
        public Contacts()
        {
            InitializeComponent();
        }

        private void gbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void gunaPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void gunaPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void gbtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void gbtnAgregar_Click(object sender, EventArgs e)
        {
            OpenContactDialog();

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void gbtnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }
        #region Metodos Privados
        //Metodos privados para manipular los datos 
        private void OpenContactDialog()
        {
            this.Hide();
            fContact fcontact = new fContact();
            fcontact.Enabled = true;
            fcontact.Show();
        }
        #endregion



    }
}
