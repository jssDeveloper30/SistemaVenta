using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.ViewModels;
using SVRepository.Entities;
using SVServices.Interface;

namespace SVPresentation.Formularios
{
    public partial class FrmCategoria : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IMedidaService _medidaService;
        public FrmCategoria(ICategoriaService categoriaService, IMedidaService medidaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _medidaService = medidaService;
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
                    tab.Parent = tabControlMain;
                }
            }
        }

        private async Task ViewCategory(string search = "")
        {
            var listaCategorias = await _categoriaService.GetCategory(search);

            var ListVM = listaCategorias.Select(item => new CategoriaViewModel
            {
                IdCategoria = item.IdCategoria,
                Nombre = item.Nombre,
                IdMedida = item.RefMedida.IdMedida,
                Medida = item.RefMedida.Nombre,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvCategorias.DataSource = ListVM;

            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["IdMedida"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
        }
        private async void FrmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvCategorias.ImplementarConfiguracion("Editar");
            await ViewCategory("");
            dgvCategorias.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

            OpcionCombo[] itemsHabilitado = new OpcionCombo[]
            {
                new OpcionCombo{Texto="Si", Valor = 1},
                new OpcionCombo{Texto="No", Valor = 0}
            };

            var listaMedida = await _medidaService.GetListSize();
            var items = listaMedida.Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdMedida }).ToArray();

            cmbMedidaNuevo.InsertarItems(items);
            cmbMedidaEditar.InsertarItems(items);

            cmbHabilitado.InsertarItems(itemsHabilitado);
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await ViewCategory(txbBuscar.Text);
        }

        private void BtnNuevoLista_Click(object sender, EventArgs e)
        {
            txbNombreNuevo.Text = "";
            cmbMedidaNuevo.SelectedIndex = 0;
            txbNombreNuevo.Select();
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabNuevo.Name];

            MostrarTab(tabNuevo.Name);
        }

        private void BtnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }



        private async void BtnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el nombre");
                return;
            }

            var item = (OpcionCombo)cmbMedidaNuevo.SelectedItem!;
            _ = item.Texto;
            var objeto = new Categoria
            {
                Nombre = txbNombreNuevo.Text.Trim(),
                RefMedida = new Medida { IdMedida = item.Valor }
            };

            var respuesta = await _categoriaService.CreateCategory(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await ViewCategory();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var categoriaSelecionada = (CategoriaViewModel)dgvCategorias.CurrentRow.DataBoundItem;

                txbNombreEditar.Text = categoriaSelecionada.Nombre.ToString();

                cmbMedidaEditar.EstablecerValor(categoriaSelecionada.IdMedida);
                cmbHabilitado.EstablecerValor(categoriaSelecionada.Activo);

                MostrarTab(tabEditar.Name);

                txbNombreEditar.Select();
            }
        }

        private void BtnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void BtnGuardarEditar_Click(object sender, EventArgs e)
        {
            if(txbNombreEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el nombre");
                return;
            }

            var categoriaSelecionada = (CategoriaViewModel)dgvCategorias.CurrentRow.DataBoundItem;

            var objeto = new Categoria
            {
                IdCategoria = categoriaSelecionada.IdCategoria,
                Nombre = txbNombreEditar.Text.Trim(),
                RefMedida = new Medida { IdMedida = ((OpcionCombo)cmbMedidaEditar.SelectedItem!).Valor },
                Activo = ((OpcionCombo)cmbHabilitado.SelectedItem!).Valor
            };

            var respuesta = await _categoriaService.EditCategory(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await ViewCategory();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
