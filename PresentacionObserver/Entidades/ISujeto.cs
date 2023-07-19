using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionObserver.Entidades {
    interface ISujeto {
        void subscribir(IObserver observer, string categoria);
        void desubscribir(IObserver observer, string categoria);
        void notificar(Producto producto);
    }
}
