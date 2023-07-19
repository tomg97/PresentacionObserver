using PresentacionObserver.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionObserver {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            List<Comprador> compradores = new List<Comprador>();
            Comprador comprador1 = new Comprador("Comprador 1");
            Comprador comprador2 = new Comprador("Comprador 2");
            Comprador comprador3 = new Comprador("Comprador 3");
            Comprador comprador4 = new Comprador("Comprador 4");
            Comprador comprador5 = new Comprador("Comprador 5");
            compradores.Add(comprador1);
            compradores.Add(comprador2);
            compradores.Add(comprador3);
            compradores.Add(comprador4);
            compradores.Add(comprador5);
            cbAddComp.DataSource = compradores;
            cbAddComp.DisplayMember = "nombre";
        }
        Marketplace marketplace = new Marketplace();
        List<Producto> productos = new List<Producto>();

        private void button1_Click(object sender, EventArgs e) {
            Producto producto = new Producto(txtProducto.Text, cbAddP.Text);
            productos.Add(producto);
            marketplace.agregarProducto(producto.categoria, producto);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }

        private void btnAddS_Click(object sender, EventArgs e) {
            Comprador comprador = (Comprador)cbAddComp.SelectedItem;
            string categoria = cbAddS.Text;
            marketplace.subscribir(comprador, categoria);
            MessageBox.Show("Se ha suscrito al comprador " + comprador.nombre + " a la categoría " + categoria);
            txtProducto.Clear();
        }

        private void btnRemP_Click(object sender, EventArgs e) {
            Comprador comprador = (Comprador)cbAddComp.SelectedItem;
            string categoria = cbAddS.Text;
            marketplace.desubscribir(comprador, categoria);
            MessageBox.Show("Se ha desuscrito al comprador " + comprador.nombre + " a la categoría " + categoria);
        }
    }
}
