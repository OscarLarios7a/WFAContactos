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
using WFAContact.Presentacion;


namespace WFAContact.Presentacion
{
    public partial class Contacts : Form
    {
        //creo una variable global para el listado de contactos
        private dContactData data;
        
        int m, mx, my;
        public Contacts()
        {
            InitializeComponent();
            data = new dContactData();
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
            PopulateContacts();
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

        

        private void gdgvContactos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ////declaracion de un objeto para manipular la celda donde damos click
            //DataGridViewLinkCell cell = (DataGridViewLinkCell)gdgvContactos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //fContact _fcontact = new fContact();
            //if (cell.Value.ToString() == "Editar")
            //{
                
            //    _fcontact.loadContact(new lContact
            //    {
            //        Id = int.Parse(gdgvContactos.Rows[e.RowIndex].Cells[0].Value.ToString()),
            //        Nombres = gdgvContactos.Rows[e.RowIndex].Cells[1].Value.ToString(),
            //        Apellidos = gdgvContactos.Rows[e.RowIndex].Cells[2].Value.ToString(),
            //        Telefono = gdgvContactos.Rows[e.RowIndex].Cells[3].Value.ToString(),
            //        Direccion = gdgvContactos.Rows[e.RowIndex].Cells[4].Value.ToString(),
            //    });
            //    _fcontact.ShowDialog(this);
            //}
            
        }

        private void gdgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //declaracion de un objeto para manipular la celda donde damos click
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gdgvContactos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            fContact _fcontact = new fContact();
            if (cell.Value.ToString() == "Editar")
            {

                _fcontact.loadContact(new lContact
                {
                    Id = int.Parse(gdgvContactos.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Nombres = gdgvContactos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Apellidos = gdgvContactos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Telefono = gdgvContactos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Direccion = gdgvContactos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                _fcontact.ShowDialog(this);
            }
        }
        #region Metodos Privados
        //Metodos privados para manipular los datos 
        private void OpenContactDialog()
        {
            //this.Hide();
            fContact fcontact = new fContact();
            //fcontact.Enabled = true;
            fcontact.ShowDialog(this);
        }
        public void PopulateContacts()
        {
            List<lContact> contacts = data.getContacts();
            gdgvContactos.DataSource = contacts;
        }
        #endregion



    }
}
