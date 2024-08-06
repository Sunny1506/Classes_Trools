using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Listacortadores
    {
        public Listacortadores()
        {
            InitializeComponent();
        }
        private async void ButtonDelete(object sender, EventArgs args)
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

            Application.Current.MainPage = new Cadastrocortador();

        }
    }
}
