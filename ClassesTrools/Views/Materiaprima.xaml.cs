using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Materiaprima
    {
        public Materiaprima()
        {
            InitializeComponent();
        }
        private async void ButtonSalvar(object sender, EventArgs args)
        {
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
    }
}