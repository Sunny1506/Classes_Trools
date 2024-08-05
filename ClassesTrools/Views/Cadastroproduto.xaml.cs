using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Cadastroproduto
    {
        public Cadastroproduto()
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
        private async void ButtonDadosInválidos(object sender, EventArgs args)
        {
            await DisplayAlert("VALIDAÇÃO", "DADOS INVÁLIDOS", "OK");

            var resposta = await DisplayAlert("SALVAR", "DESEJA SALVAR?", "SIM", "NÃO");
            if (resposta)
            {

            }
        }
        private async void ButtonVoltar(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("CANCELAR", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {

            }
        }
   
    private async void ButtonNaoEncontrado(object sender, EventArgs args)
    {
        var resposta = await DisplayAlert("CLIENTE NÃO ENCONTRADO", "CLIENTE NÃO ENCONTRADO, DESEJA CADASTRAR CLIENTE?", "CADASTRAR", "CANCELAR");
        if (resposta)
        {

        }

    }

   }
}


