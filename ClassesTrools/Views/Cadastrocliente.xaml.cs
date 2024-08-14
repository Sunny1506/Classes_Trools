using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
    public partial class Cadastrocliente
    {
        ClientesControle clientesControle = new ClientesControle();
        public Cadastrocliente()
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


        }
        private async void ButtonSalvarButtonClicked(object sender, EventArgs args)
        {
            var cliente = new Clientes();
            cliente.Nome = NomeEntry.Text;
            cliente.CNPJ = CNPJEntry.Text;
            cliente.Telefone = TelEntry.Text;
            cliente.Endereço = EndereçoEntry.Text;
            cliente.Cidade = CidadeEntry.Text;
            cliente.Estado = EstadoEntry.Text;
            cliente.CEP = CEPEntry.Text;
            cliente.Email = EmailEntry.Text;
            clientesControle.CriarOuAtualizar(cliente);

            var resposta = await DisplayAlert("SALVAR", "DESEJA SALVAR?", "SIM", "NÃO");
            if (resposta)
            {
                Application.Current.MainPage = new Listaclientes();
            }

        }
        private async void ButtonVoltarTelaButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("CANCELAR", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {
                Application.Current.MainPage = new Listaclientes();
            }
        }
        private async void ButtonVoltarListaButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("VOLTAR TELA", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {
                Application.Current.MainPage = new Listaclientes();
            }
        }


    }
}