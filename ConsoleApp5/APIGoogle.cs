using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Contacts;
using Google.GData.Client;
using Google.GData.Extensions;


namespace ConsoleApp5
{
    class APIGoogle
    {


    }

    
    public class GMail
    {
        /// <summary>
        /// Datos de una cuenta
        /// </summary>
        public struct Account
        {
            /// <summary>
            /// Nombre de la cuenta
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Dirección de correo de la cuenta
            /// </summary>
            public string Address { get; set; }
        }

        /// <summary>
        /// Nos devuelve la lista de contactos con su e-mail
        /// </summary>
        /// <param name="Account">Cuenta de correo del usuario</param>
        /// <param name="Password">Contraseña</param>
        /// <returns>Lista de contactos</returns>
        public static List<Account> GetContacts(string Account, string Password)
        {
            List<Account> objResult = new List<Account>();
            RequestSettings objRS = new RequestSettings("Aplicación de ejemplo", Account, Password);
            ContactsRequest objCR = new ContactsRequest(objRS);

            var objFeed = objCR.GetContacts();

            foreach (Contact objContact in objFeed.Entries)
                foreach (EMail objEmail in objContact.Emails)
                    objResult.Add(new Account()
                    {
                        Title = objContact.Title,
                        Address = objEmail.Address
                    });

            return objResult;
        }
    }
}
