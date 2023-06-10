using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPetShop.Models
{
	public class Contacto
	{
		public int ContactoId { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Cedula { get; set; }
		public string Direccion { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public string Imagen { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

	}
}
