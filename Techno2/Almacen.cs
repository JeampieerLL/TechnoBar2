using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techno2
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }


        public List<ProductoDto> ObtenerProductos()
        {
            try
            {
                using (DBCoviBarEntities db = new DBCoviBarEntities())
                {
                    var consulta = (from n in db.PRODUCTOS
                                    select new ProductoDto
                                    {
                                        Id_Producto = n.Id_Producto,
                                        Id_Categoria = n.Id_Categoria,
                                        Nombre = n.Nombre,
                                        Descripcion = n.Descripcion,
                                        stock = n.stock
                                    }
                                    ).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ObtenerProductos();
        }

        public void InsertarProducto(PRODUCTOS pRODUCTOS)
        {
            try
            {
                using (DBCoviBarEntities db = new DBCoviBarEntities())
                {
                    db.PRODUCTOS.Add(pRODUCTOS);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PRODUCTOS producto = new PRODUCTOS();
            producto.Id_Producto = txtIdProd.Text;
            producto.Id_Categoria = txtIdCat.Text;
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.stock = Int32.Parse(txtCantidad.Text);

            InsertarProducto(producto);
            MessageBox.Show("Producto agregado correctamente :D");
            dgvProductos.DataSource = ObtenerProductos();
        }

    }
}
