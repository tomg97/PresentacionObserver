using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionObserver.Entidades {
    public class Marketplace : ISujeto {
        private Dictionary<string, List<IObserver>> observers = new Dictionary<string, List<IObserver>>();
        private Dictionary<string, List<Producto>> productosPorCategoria = new Dictionary<string, List<Producto>>();
        public void agregarProducto(string categoria, Producto producto) {
            if (!productosPorCategoria.ContainsKey(categoria)) {
                productosPorCategoria[categoria] = new List<Producto>();
            }
            productosPorCategoria[categoria].Add(producto);
            notificar(producto);
        }

        public void desubscribir(IObserver observer, string categoria) {
            if (observers.ContainsKey(categoria)) {
                observers[categoria].Remove(observer);
            } else {
                MessageBox.Show("El comprador no está suscrito a esa categoría. Vuelva a elegir");
            }
        }

        public void notificar(Producto producto) {
            if(observers.ContainsKey(producto.categoria)) {
                foreach (IObserver observer in observers[producto.categoria]) {
                    observer.Update(producto);
                }
            }
        }

        public void subscribir(IObserver observer, string categoria) {
            if (!observers.ContainsKey(categoria)) {
                observers[categoria] = new List<IObserver>();
            }
            observers[categoria].Add(observer);
        }
        public Dictionary<string, List<IObserver>> verCompradoresEnCategoria() {
            return observers;
        }
    }
}
