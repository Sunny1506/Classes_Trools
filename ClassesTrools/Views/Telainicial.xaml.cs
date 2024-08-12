using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Telainicial
    {
        public Telainicial()
        {
            InitializeComponent();
        }
        private void ButtonClienteButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listaclientes();

        }
        private void ButtonProdutoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listaprodutos();

        }
        private void ButtonMetaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Metadiaria();

        }
        private void ButtonEnviocorteButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Enviocorte();

        }
        private void ButtonEnviocosturaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Enviocostura();

        }
        private void ButtonEnvioacabamentoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Envioacabamento();

        }
        private void ButtonVendasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatoriovendas();

        }

        private void ButtonCortadoresButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listacortadores();

        }


    }
}
