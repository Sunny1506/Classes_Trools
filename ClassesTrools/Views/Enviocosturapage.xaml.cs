using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
  public partial class Enviocosturapage : ContentPage
  {
    //--------------------------------------------------------------------------------------------------
    // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
    // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
    // ClienteControle que irá criar/atualizar o Banco de Dados
    public Enviocostura enviocostura{ get; set; }
    Controles.EnviocosturaControle enviocosturaControle = new Controles.EnviocosturaControle();

    //--------------------------------------------------------------------------------------------------

    public Enviocosturapage()
    {
      InitializeComponent();
    }

    //--------------------------------------------------------------------------------------------------

    void VoltarClicked(object sender, EventArgs e)
    {
      Application.Current.MainPage = new Telainicial();

      CostureiroPicker.ItemsSource =enviocosturaControle.LerTodos();
      MateriaprimaPicker.ItemsSource = enviocosturaControle.LerTodos();
    }

    //--------------------------------------------------------------------------------------------------
    // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
    // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (enviocostura != null)
      {
        IdLabel.Text = enviocostura.Id.ToString();
        QuantidadeEntry.Text = enviocostura.Quantidade;

      

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
       enviocostura = new Modelos.Enviocostura();
        if (!String.IsNullOrEmpty(IdLabel.Text))
          enviocostura.Id = int.Parse(IdLabel.Text);
        else
         enviocostura.Id = 0;
        enviocostura.Quantidade = QuantidadeEntry.Text;
       
       
        


        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        enviocosturaControle.CriarOuAtualizar(enviocostura);
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