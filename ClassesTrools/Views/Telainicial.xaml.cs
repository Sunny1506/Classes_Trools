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
        private void ButtonCortadorButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listacortadores();

        }
        private void ButtonCostureirosButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listacostureiros();

        }
        private void ButtonAcabamentistasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listaacabamentistas();

        }
        private void ButtonVendasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatoriovendas();

        }



    }
}
