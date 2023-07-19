using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionObserver.Entidades {
    public class Producto {
		public Producto() { }
		public Producto(string nombre, string categoria) {
			Random r = new Random();
			_id = r.Next();
			_nombre = nombre;
			_categoria = categoria;
		}
		private int _id;

		public int id {
			get { return _id; }
			set { _id = value; }
		}
		private string _nombre;

		public string nombre {
			get { return _nombre; }
			set { _nombre = value; }
		}
		private string _categoria;

		public string categoria {
			get { return _categoria; }
			set { _categoria = value; }
		}

	}
}
