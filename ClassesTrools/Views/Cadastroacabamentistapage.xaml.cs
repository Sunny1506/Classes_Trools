using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
  public partial class Cadastroacabamentistapage : ContentPage
  {
    //--------------------------------------------------------------------------------------------------
    // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
    // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
    // ClienteControle que irá criar/atualizar o Banco de Dados
    public Acabamentista acabamentista{ get; set; }
    Controles.AcabamentistaControle acabamentistaControle = new Controles.AcabamentistaControle();

    //--------------------------------------------------------------------------------------------------

    public Cadastroacabamentistapage()
    {
      InitializeComponent();
    }

    //--------------------------------------------------------------------------------------------------

    void VoltarClicked(object sender, EventArgs e)
    {
      Application.Current.MainPage = new Listaacabamentistaspage();
    }

    //--------------------------------------------------------------------------------------------------
    // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
    // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (acabamentista != null)
      {
        IdLabel.Text = acabamentista.Id.ToString();
        NomeEntry.Text = acabamentista.Nome;
        TelefoneEntry.Text = acabamentista.Telefone;
        DataEntry.Text = acabamentista.Data;
      

      }
      else
        IdLabel.Text = "0";
    }

    //--------------------------------------------------------------------------------------------------
    // Método para limpar os dados da Entry
    private void OnApagarDadosClicked(object sender, EventArgs e)
    {
      IdLabel.Text = string.Empty;
      NomeEntry.Text = string.Empty;
      TelefoneEntry.Text = string.Empty;
      DataEntry.Text = string.Empty;
     
      
    }
     private async void OnApagarAcabamentistasClicked(object sender, EventArgs e)
  {
    // Verifica se estamos editando um cliente ou criando um cliente
    // Se estiver criando, não se pode apagar, já que não se tem um `cliente.Id`
    if (acabamentista == null || acabamentista.Id < 1)
      await DisplayAlert("Erro", "Nenhum acabamentista para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse acabamentista?","Excluir Acabamentista","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      // Apaga do Banco de Dados
      acabamentistaControle.Apagar(acabamentista.Id);
      // Volta para a tela de Lista
      // Esse código abaixo pode ser um:
      // await NavigationPage.PopAsync();
      // Se você veio pra cá com um 
      // await Navigation.PushAsync(new CadastroClientePage);
      Application.Current.MainPage = new Listaacabamentistaspage(); 
    }
  }
    //--------------------------------------------------------------------------------------------------

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
      if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
      {
        // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
       acabamentista = new Modelos.Acabamentista();
        if (!String.IsNullOrEmpty(IdLabel.Text))
          acabamentista.Id = int.Parse(IdLabel.Text);
        else
         acabamentista.Id = 0;
        acabamentista.Nome = NomeEntry.Text;
        acabamentista.Telefone = TelefoneEntry.Text;
        acabamentista.Data = DataEntry.Text;
       
        


        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        acabamentistaControle.CriarOuAtualizar(acabamentista);
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
      if (String.IsNullOrEmpty(NomeEntry.Text))
      {
        await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
        return false;
      }
      // Verifica se a Entry do Sobrenome está vazia
      else if (String.IsNullOrEmpty(TelefoneEntry.Text))
      {
        await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
        return false;
      }

      else
        return true;
    }

    //--------------------------------------------------------------------------------------------------
  }
}