using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
  public partial class Metadiaria
  {
    public Metadiaria()
    {
      InitializeComponent();

    }
    private async void ButtonMetaNaoBatidaButtonClicked(object sender, EventArgs args)
    {
      await DisplayAlert("VALIDAÇÃO", "META NÃO BATIDA", "OK");
    }
    private async void ButtonMetaBatida(object sender, EventArgs args)
    {
      await DisplayAlert("VALIDAÇÃO", "META BATIDA", "PARABÉNS", "OK");
    }


    private async void ButtonSalvarButtonClicked(object sender, EventArgs args)
    {
      var resposta = await DisplayAlert("SALVAR", "DESEJA SALVAR?", "SIM", "NÃO");
      if (resposta)
      {
        Application.Current.MainPage = new Metadiaria();
      }
    }
    private async void ButtonVoltarTelaButtonClicked(object sender, EventArgs args)
    {
      var resposta = await DisplayAlert("CANCELAR", "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS", "VOLTAR", "CANCELAR");
      if (resposta)
      {
        Application.Current.MainPage = new Telainicial();
      }


    }
    private void ButtonVoltarButtonClicked(object sender, EventArgs args)
    {

      Application.Current.MainPage = new Telainicial();

    }
    private void ButtonRelatorioButtonClicked(object sender, EventArgs args)
    {

      Application.Current.MainPage = new Relatoriometadiaria();

    }
  }
}