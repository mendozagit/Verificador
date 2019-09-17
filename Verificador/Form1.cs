using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verificador.Models;

namespace Verificador
{
    public partial class Form1 : Form
    {
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
                    TxtArticulo.Text = prod.ProductoId;
                    TxtDescripcion.Text = prod.Descripcion;
                    TxtPrecio.Text = Math.Round(prod.Precio1, 2).ToString();
                    TxtStock.Text = prod.Stock.ToString();

                }
                else
                {
                    TxtDescripcion.Text = "PRODUCTO NO ENCONTRADO";
                }
            }
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

    }
}
