﻿using System;
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
    public partial class fContact : Form
    {
        int m, mx, my;
        public fContact()
        {
            InitializeComponent();
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
            Contacts contacts = new Contacts();
            contacts.Show();
        }

        private void fContact_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void fContact_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void fContact_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}