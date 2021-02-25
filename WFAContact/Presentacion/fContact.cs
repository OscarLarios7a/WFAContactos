using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAContact.Logica;
using WFAContact.Datos;

namespace WFAContact.Presentacion
{
    public partial class fContact : Form
    {
        //Declaracion  de la variable de conexion 
        private dContactData data;
        private lContact lcontact;
        int m, mx, my;
        public fContact()
        {
            InitializeComponent();
            data = new dContactData();
        }

        private void gbtnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private void gbtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void gbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Contacts contacts = new Contacts();
            //contacts.Show();
            ((Contacts)this.Owner).PopulateContacts();
        }

       
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void gbtnCancelar_Click(object sender, EventArgs e)
        {
            //Mando a llamar a mi metodo Privado de Limpiar caja
            limpiarCajasTxt();
        }

        private void gbtnAceptar_Click(object sender, EventArgs e)
        {
            insertarContacto();
            limpiarCajasTxt();
            this.Close();
            ((Contacts)this.Owner).PopulateContacts();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region METODOS PRIVADOS
        private void limpiarCajasTxt()
        {
            gTxtNombre.Clear();
            gTxtApellidos.Clear();
            gTxtTelefono.Clear();
            gTxtDireccion.Clear();
            gTxtNombre.Focus();
        }

        private void insertarContacto()
        {
            lContact contact = new lContact();
            contact.Nombres = gTxtNombre.Text;
            contact.Apellidos = gTxtApellidos.Text;
            contact.Telefono = gTxtTelefono.Text;
            contact.Direccion = gTxtDireccion.Text;

            contact.Id = lcontact != null ? lcontact.Id : 0;

            data.guardarContact(contact);
        }

        public void loadContact(lContact contact)
        {
            lcontact = contact;
            if (contact!=null)
            {
                limpiarFContact();
                gTxtNombre.Text = contact.Nombres;
                gTxtApellidos.Text = contact.Apellidos;
                gTxtTelefono.Text = contact.Telefono;
                gTxtDireccion.Text = contact.Direccion;
            }
        }
        // Limpiar el Formulario de fContact 
        private void limpiarFContact()
        {
            gTxtNombre.Text = string.Empty;
            gTxtApellidos.Text = string.Empty;
            gTxtTelefono.Text = string.Empty;
            gTxtDireccion.Text = string.Empty;
           
        }

        #endregion


    }
}
