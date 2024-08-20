using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
  public partial class Enviocortepage : ContentPage
  {
    //--------------------------------------------------------------------------------------------------
    // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
    // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
    // ClienteControle que irá criar/atualizar o Banco de Dados
    public Enviocorte enviocorte{ get; set; }
    Controles.EnviocorteControle enviocorteControle = new Controles.EnviocorteControle();

    //--------------------------------------------------------------------------------------------------

    public Enviocortepage()
    {
      InitializeComponent();
    }

    //--------------------------------------------------------------------------------------------------

    void VoltarClicked(object sender, EventArgs e)
    {
      Application.Current.MainPage = new Telainicial();

      CortadorPicker.ItemsSource =CortadoresControle.LerTodos();
      MateriaprimaPicker.ItemsSource = MateriaprimaControle.LerTodos();
    }

    //--------------------------------------------------------------------------------------------------
    // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
    // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (enviocorte != null)
      {
        IdLabel.Text = enviocorte.Id.ToString();
        QuantidadeEntry.Text = enviocorte.Quantidade;

      

      }
      else
        IdLabel.Text = "0";
    }

    //--------------------------------------------------------------------------------------------------
    // Método para limpar os dados da Entry
    private void OnApagarDadosClicked(object sender, EventArgs e)
    {
      IdLabel.Text = string.Empty;
      QuantidadeEntry.Text = string.Empty;
      
     
      
    }

    //--------------------------------------------------------------------------------------------------

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
      if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
      {
        // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
       enviocorte = new Modelos.Enviocorte();
        if (!String.IsNullOrEmpty(IdLabel.Text))
          enviocorte.Id = int.Parse(IdLabel.Text);
        else
         enviocorte.Id = 0;
        enviocorte.Quantidade = QuantidadeEntry.Text;
       
       
        


        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        enviocorteControle.CriarOuAtualizar(enviocorte);
        // Mostra a mensagem de sucesso
        await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
      }
    }

    //--------------------------------------------------------------------------------------------------
    // Esse método pode ser escrito de várias maneiras. A idéia é que você valide os dados antes de 
    // preencher o objeto (Modelo). 
    // Perceba que além da retornar false (para indicar erro), também mostra qual o erro
    private async Task<bool> VerificaSeDadosEstaoCorretos()
    {
      // Verifica se a Entry do Nome está vazia
      if (String.IsNullOrEmpty(QuantidadeEntry.Text))
      {
        await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
        return false;
      }
  

      else
        return true;
    }

    //--------------------------------------------------------------------------------------------------
  }
}