using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Cadastroproduto
    {
        public Cadastroproduto()
        {
            InitializeComponent();
        }
        private async void ButtonDeleteButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
            if (resposta)
            {

            }
        }
        private async void ButtonDadosInválidosButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("VALIDAÇÃO", "DADOS INVÁLIDOS", "OK");

            var resposta = await DisplayAlert("SALVAR", "DESEJA SALVAR?", "SIM", "NÃO");
            if (resposta)
            {

            }
        }
        private async void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("CANCELAR", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {
                 Application.Current.MainPage = new Listaprodutos();
            }
        }
   
    private async void ButtonNaoEncontradoButtonClicked(object sender, EventArgs args)
    {
        var resposta = await DisplayAlert("CLIENTE NÃO ENCONTRADO", "CLIENTE NÃO ENCONTRADO, DESEJA CADASTRAR CLIENTE?", "CADASTRAR", "CANCELAR");
        if (resposta)
        {

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
                 Application.Current.MainPage = new Listaprodutos();
            }
        }

   }
}


