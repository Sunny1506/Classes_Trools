using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Cadastrovendas
    {
        public Cadastrovendas()
        {
            InitializeComponent();
        }

        private async void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("CANCELAR", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {
                Application.Current.MainPage = new Listaprodutos();
            }
        }
        private async void ButtonSalvarButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("SALVAR", "DESEJA SALVAR?", "SIM", "NÃO");
            if (resposta)
            {
                Application.Current.MainPage = new Listaprodutos();
            }

        }
        private async void ButtonVoltarListaButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("VOLTAR TELA", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {
                Application.Current.MainPage = new Relatoriovendas();
            }
        }
    }
}