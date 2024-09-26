using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.ViewModels;
using SVRepository.Entities;
using SVServices.Interface;

namespace SVPresentation.Formularios
{
    public partial class FrmProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        public FrmProducto(ICategoriaService categoriaService, IProductoService productoService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _productoService = productoService;
        }
        public void MostrarTab(string tabName)
        {
            var tabsMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };

            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = this.tabControlMain;
                }
            }
        }
        private async Task ViewProduct(string search = "")
        {
            var listaProductos = await _productoService.GetProduct(search);

            var ListVM = listaProductos.Select(item => new ProductoViewModel
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Descripcion = item.Descripcion,
                IdCategoria = item.RefCategoria.IdCategoria,
                Categoria = item.RefCategoria.Nombre,
                PrecioCompra = item.PrecioCompra.ToString("0.00"),
                PrecioVenta = item.PrecioVenta.ToString("0.00"),
                Cantidad = item.Cantidad,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvProductos.DataSource = ListVM;

            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Descripcion"].Width = 200;
        }
        private async void FrmProducto_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvProductos.ImplementarConfiguracion("Editar");
            dgvProductos.ImplementarConfiguracion("Eliminar");
            txbPrecioCompraNuevo.ValidarNumero();
            txbPrecioCompraEditar.ValidarNumero();
            txbPrecioVentaNuevo.ValidarNumero();
            txbPrecioVentaEditar.ValidarNumero();
            await ViewProduct("");
            dgvProductos.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

            OpcionCombo[] itemsHabilitado =
            [
                new() {Texto="Si", Valor = 1},
                new() {Texto="No", Valor = 0}
            ];

            var listaCategoria = await _categoriaService.GetCategory();
            var items = listaCategoria
                .Where(item => item.Activo == 1)
                .Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdCategoria })
                .ToArray();

            cmbCategoriaNuevo.InsertarItems(items);
            cmbCategoriaEditar.InsertarItems(items);

            cmbHabilitado.InsertarItems(itemsHabilitado);
        }
        private async void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            await ViewProduct(txbBuscar.Text);
        }
        private void BtnNuevoLista_Click_1(object sender, EventArgs e)
        {
            cmbCategoriaNuevo.SelectedIndex = 0;
            txbCodigoNuevo.Text = "";
            txbDescripcionNuevo.Text = "";
            txbPrecioCompraNuevo.Text = "";
            txbPrecioVentaNuevo.Text = "";
            txbCantidadNuevo.Value = 0;
            cmbCategoriaNuevo.Select();

            MostrarTab(tabNuevo.Name);
        }

        private void BtnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void BtnGuardarNuevo_Click(object sender, EventArgs e)
        {
            //if (txbCodigoNuevo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Debe ingresar el codigo");
            //    return;
            //}
            //if (txbDescripcionNuevo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Debe ingresar la descripcion");
            //    return;
            //}
            //if (txbPrecioCompraNuevo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Debe ingresar el precio de compra");
            //    return;
            //}
            //if (txbPrecioVentaNuevo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Debe ingresar el precio de venta");
            //    return;
            //}
            switch ("")
            {
                case var _ when txbCodigoNuevo.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar el codigo");
                    break;
                case var _ when txbDescripcionNuevo.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar la descripcion");
                    break;
                case var _ when txbPrecioCompraNuevo.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar el precio de compra");
                    break;
                case var _ when txbPrecioVentaNuevo.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar el precio de venta");
                    break;
                case var _ when txbCantidadNuevo.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar la cantidad");
                    break;
            }

            decimal preciocompra = 0;
            decimal precioventa = 0;

            if (!decimal.TryParse(txbPrecioCompraNuevo.Text, out preciocompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioCompraNuevo.Select();
                return;
            }

            if (!decimal.TryParse(txbPrecioVentaNuevo.Text, out precioventa))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioVentaNuevo.Select();
                return;
            }

            var objeto = new Producto
            {
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cmbCategoriaNuevo.SelectedItem!).Valor },
                Codigo = txbCodigoNuevo.Text.Trim(),
                Descripcion = txbDescripcionNuevo.Text.Trim(),
                PrecioCompra = preciocompra,
                PrecioVenta = precioventa,
                Cantidad = Convert.ToInt32(txbCantidadNuevo.Value)
            };

            var response = await _productoService.CreateProduct(objeto);

            if (response != "")
            {
                MessageBox.Show(response);
            }
            else
            {
                await ViewProduct();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var productoSelecionado = (ProductoViewModel)dgvProductos.CurrentRow.DataBoundItem;

                cmbCategoriaEditar.EstablecerValor(productoSelecionado.IdCategoria);
                txbCodigoEditar.Text = productoSelecionado.Codigo;
                txbDescripcionEditar.Text = productoSelecionado.Descripcion;
                txbPrecioCompraEditar.Text = productoSelecionado.PrecioCompra;
                txbPrecioVentaEditar.Text = productoSelecionado.PrecioVenta;
                txbCantidadEditar.Value = productoSelecionado.Cantidad;
                cmbHabilitado.EstablecerValor(productoSelecionado.Activo);

                MostrarTab(tabEditar.Name);

                cmbCategoriaEditar.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            switch ("")
            {
                case var _ when txbCodigoEditar.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar el codigo");
                    break;
                case var _ when txbDescripcionEditar.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar la descripcion");
                    break;
                case var _ when txbPrecioCompraEditar.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar el precio de compra");
                    break;
                case var _ when txbPrecioVentaEditar.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar el precio de venta");
                    break;
                case var _ when txbCantidadEditar.Text.Trim() == "":
                    MessageBox.Show("Debe ingresar la cantidad");
                    break;
            }

            decimal preciocompra = 0;
            decimal precioventa = 0;

            if (!decimal.TryParse(txbPrecioCompraEditar.Text, out preciocompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioCompraEditar.Select();
                return;
            }

            if (!decimal.TryParse(txbPrecioVentaEditar.Text, out precioventa))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioVentaNuevo.Select();
                return;
            }

            var productoSelecionado = (ProductoViewModel)dgvProductos.CurrentRow.DataBoundItem;

            var objeto = new Producto
            {
                IdProducto = productoSelecionado.IdProducto,
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cmbCategoriaEditar.SelectedItem!).Valor },
                Codigo = txbCodigoEditar.Text.Trim(),
                Descripcion = txbDescripcionEditar.Text.Trim(),
                PrecioCompra = preciocompra,
                PrecioVenta = precioventa,
                Cantidad = Convert.ToInt32(txbCantidadEditar.Value)
            };

            var response = await _productoService.EditProduct(objeto);

            if (response != "")
            {
                MessageBox.Show(response);
            }
            else
            {
                await ViewProduct();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
