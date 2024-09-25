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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            var listaCategorias = await _categoriaService.GetCategory("");

            dgvCategorias.DataSource = listaCategorias;
        }
    }
}
