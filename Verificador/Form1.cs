using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verificador.Controllers;
using Verificador.Models;

namespace Verificador
{
    public partial class Form1 : Form
    {
        private List<Impuesto> impuestos;

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtProductoId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraerData();
            }
        }

        private void TraerData()
        {
            using (var db = new DymContext())
            {
                var prod = db.Producto.FirstOrDefault(x => x.ProductoId.Equals(TxtProductoId.Text.Trim()));
                if (prod != null)
                {
                    //ok
                    CargaListaImpuestos(prod);

                    TxtArticulo.Text = prod.ProductoId;
                    TxtDescripcion.Text = prod.Descripcion;
                    TxtPrecio.Text = GetPrecioSalida(prod.Precio1.ToString(), impuestos);
                    TxtStock.Text = prod.Stock.ToString();

                }
                else
                {
                    Limpiar();
                    TxtDescripcion.Text = "PRODUCTO NO ENCONTRADO";
                }
            }
        }
        private void Limpiar()
        {
            TxtDescripcion.Text = "";
            TxtArticulo.Text = "";
            TxtStock.Text = "";
            TxtPrecio.Text = "";
            pictureBox1.Image = null;
        }
        public static string GetPrecioSalida(string nPrecio, ICollection<Impuesto> impuestos)
        {
            decimal precio = 0M, acumulado = 0M;
            try
            {
                if (decimal.TryParse(nPrecio, out precio) && impuestos.Count > 0)
                    foreach (var i in impuestos)
                        acumulado += precio * i.Tasa;
                else
                    return "$1.00";
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio mal precio y/o margen invalidos");
            }
            return ((precio + acumulado).ToString("C"));
        }
        private Image GetImg(string ruta)
        {
            try
            {
                if (ruta == null)
                    return null;

                Image img = Image.FromFile(ruta);
                return img;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckConnection();
        }
        private void CheckConnection()
        {

            using (var db = new DymContext())
            {
                db.Producto.FirstOrDefault();
            }
        }
        private void CargaListaImpuestos(Producto producto)
        {

            impuestos = new List<Impuesto>();

            ImpuestoController impuestoController = new ImpuestoController();

            if (!producto.Impuesto1Id.Equals("SYS"))
            {
                var impuesto1 = impuestoController.SelectOne(producto.Impuesto1Id);
                if (impuesto1 != null)
                    impuestos.Add(impuesto1);
            }

            if (!producto.Impuesto2Id.Equals("SYS"))
            {
                var impuesto2 = impuestoController.SelectOne(producto.Impuesto2Id);
                if (impuesto2 != null)
                    impuestos.Add(impuesto2);
            }

            if (!producto.Impuesto3Id.Equals("SYS"))
            {
                var impuesto3 = impuestoController.SelectOne(producto.Impuesto3Id);
                if (impuesto3 != null)
                    impuestos.Add(impuesto3);
            }
        }
    }
}
