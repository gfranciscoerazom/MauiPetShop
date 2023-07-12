using System;
namespace MauiPetShop.Models
{
    public class Cliente
    {
        public int ClienteId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Numero
        {
            get;
            set;
        }

        public string Contrasena
        {
            get;
            set;
        }

        public bool IsAdmin
        {
            get;
            set;
        } = false;

        public string Foto
        {
            get;
            set;
        } = "https://www.pngall.com/wp-content/uploads/5/Profile-Avatar-PNG-Picture.png";
    }
}

