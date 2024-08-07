using Microsoft.Maui.Controls;


namespace ClassesTrools.Views
{
    public partial class Listaprodutos
    {
        public Listaprodutos()
        {
            InitializeComponent();
        }

        private async void ButtonDeleteProdutos(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
            if (resposta)
            {

            }
        }
        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }


        private void ButtonCadastroButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Cadastroproduto();

        }

        private async void ButtonExcluirButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
            if (resposta)
            {
                Application.Current.MainPage = new Listaprodutos();
            }
        }

    }
}