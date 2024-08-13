using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Listacostureiros
    {
        public Listacostureiros()
        {
            InitializeComponent();
        }
        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }
        private void ButtonCadastroButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Cadastrocostureiro();

        }
        private async void ButtonExcluirButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
            if (resposta)
            {
                Application.Current.MainPage = new Listacostureiros();
            }
        }
    }
}