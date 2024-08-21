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

            Application.Current.MainPage = new Listaclientespage();

        }
        private void ButtonProdutoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listaprodutospage();

        }
          private void ButtonUnidadeButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Unidadepage();

        }
        private void ButtonMateriaprimaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Materiaprimapage();

        }
         private void ButtonRelatoriosButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatoriospage();

        }
        private void ButtonEnviocorteButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatoriocortepage();

        }
        private void ButtonEnviocosturaButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatoriocosturapage();

        }
        private void ButtonEnvioacabamentoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatorioacabamentopage();

        }
        private void ButtonVendasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatoriovendaspage();

        }

        private void ButtonCortadoresButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listacortadorespage();

        }
         private void ButtonCostureirosButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listacostureirospage();

        }
         private void ButtonAcabamentistasButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Listaacabamentistaspage();

        }


    }
}
