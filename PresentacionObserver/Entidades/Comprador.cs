using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionObserver.Entidades {
    public class Comprador : IObserver {
        private string _nombre;

        public string nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Comprador(string nombre) {
            _nombre = nombre;
        }
        public void Update(Producto producto) {
            MessageBox.Show("El comprador " + nombre +" recibió una notificación por un producto nuevo: " + producto.nombre);
        }
    }
}
