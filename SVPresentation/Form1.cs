using SVServices.Interface;

namespace SVPresentation
{
    public partial class Form1 : Form
    {
        private readonly IMedidaService _medidaService;
        public Form1(IMedidaService medidaService)
        {
            InitializeComponent();
            _medidaService = medidaService;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var list = await _medidaService.GetListSize();
        }
    }
}
