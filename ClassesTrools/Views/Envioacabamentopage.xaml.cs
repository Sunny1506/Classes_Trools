using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
  public partial class Envioacabamentopage : ContentPage
  {
    //--------------------------------------------------------------------------------------------------
    // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
    // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
    // ClienteControle que irá criar/atualizar o Banco de Dados
    public Envioacabamento envioacabamento{ get; set; }
    Controles.EnvioacabamentoControle envioacabamentoControle = new Controles.EnvioacabamentoControle();

    //--------------------------------------------------------------------------------------------------

    public Envioacabamentopage()
    {
      InitializeComponent();
    }

    //--------------------------------------------------------------------------------------------------

    void VoltarClicked(object sender, EventArgs e)
    {
      Application.Current.MainPage = new Relatorioacabamentopage();

      AcabamentistaPicker.ItemsSource =envioacabamentoControle.LerTodos();
      MateriaprimaPicker.ItemsSource = envioacabamentoControle.LerTodos();
    }

    //--------------------------------------------------------------------------------------------------
    // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
    // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (envioacabamento != null)
      {
        IdLabel.Text = envioacabamento.Id.ToString();
        QuantidadeEntry.Text = envioacabamento.Quantidade;
        DataEntry.Text = envioacabamento.Data;

      

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
       DataEntry.Text = string.Empty;
      
     
      
    }
    private async void OnApagarAcabamentoClicked(object sender, EventArgs e)
  {
    // Verifica se estamos editando um cliente ou criando um cliente
    // Se estiver criando, não se pode apagar, já que não se tem um `cliente.Id`
    if (envioacabamento == null || envioacabamento.Id < 1)
      await DisplayAlert("Erro", "Nenhum envio para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse envio?","Excluir envio","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      // Apaga do Banco de Dados
      envioacabamentoControle.Apagar(envioacabamento.Id);
      // Volta para a tela de Lista
      // Esse código abaixo pode ser um:
      // await NavigationPage.PopAsync();
      // Se você veio pra cá com um 
      // await Navigation.PushAsync(new CadastroClientePage);
      Application.Current.MainPage = new Envioacabamentopage(); 
    }
  }

    //--------------------------------------------------------------------------------------------------

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
      if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
      {
        // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
       envioacabamento = new Modelos.Envioacabamento();
        if (!String.IsNullOrEmpty(IdLabel.Text))
          envioacabamento.Id = int.Parse(IdLabel.Text);
        else
         envioacabamento.Id = 0;
        envioacabamento.Quantidade = QuantidadeEntry.Text;
       
       
        


        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        envioacabamentoControle.CriarOuAtualizar(envioacabamento);
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