using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Enviocorte
    {
        public Enviocorte()
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
        private async void ButtonVoltarButtonClicked (object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("CANCELAR", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
            if (resposta)
            {
                    Application.Current.MainPage = new Telainicial();
            }

        }
         private void ButtonCortadoresButtonClicked(object sender, EventArgs args)
        {
var page = new Listacortadores();
page.Paraondevoltar = new Enviocorte();
            Application.Current.MainPage = page;

        }
       
    }
}