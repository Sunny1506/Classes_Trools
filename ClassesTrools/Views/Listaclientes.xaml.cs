using Microsoft.Maui.Controls;


namespace ClassesTrools.Views
{
    public partial class Listaclientes
    {
        public Listaclientes()
        {
            InitializeComponent();
        }
       // void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        //{
            // var page = new CadastroCliente();
            //  page.cliente = e.SelectedItem as Cliente;
            //   Application.Current.MainPage = page;
      //  }


        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }
        private void ButtonCadastroButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Cadastrocliente();

        }
        private async void ButtonExcluirButtonClicked(object sender, EventArgs args)
        {
            var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
            if (resposta)
            {
                Application.Current.MainPage = new Listaclientes();
            }
        }
    }

}