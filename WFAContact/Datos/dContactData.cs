using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAContact.Logica;

namespace WFAContact.Datos
{
    public class dContactData
    {
        private dConexion cnx;
        

        //generando el constructor
        public dContactData(){
            cnx = new dConexion();
        }


        public lContact guardarContact(lContact contact)
        {
            if (contact.Id == 0)
            {
               cnx.insertContact(contact);
            }
            //else {
            //    //cnx.updateContact; 
            //}
            return contact;
        }
        public List<lContact> getContacts()
        {
            return cnx.getContacts();
        }
    }
}
