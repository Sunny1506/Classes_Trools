using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Listacortadores
    {
        public Page Paraondevoltar;
        public Listacortadores()
        {
            InitializeComponent();
        }
        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = Paraondevoltar;

        }
        private void ButtonCadastroButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Cadastrocortador();

        }
        private async void ButtonExcluirButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
            if (resposta)
            {
                Application.Current.MainPage = new Listacortadores();
            }
        }
         private void ButtonVoltarEnvioButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Enviocorte();

        }
    }

}
