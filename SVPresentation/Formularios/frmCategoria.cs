using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.ViewModels;
using SVServices.Interface;

namespace SVPresentation.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IMedidaService _medidaService;
        public frmCategoria(ICategoriaService categoriaService, IMedidaService medidaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _medidaService = medidaService;
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
            dgvCategorias.Columns["IdMedida"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
        }
        private async void frmCategoria_Load(object sender, EventArgs e)
        {
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

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await ViewCategory(txtBuscar.Text);
        }
    }
}
