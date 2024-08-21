using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
  public partial class Cadastrocortadorpage : ContentPage
  {
    //--------------------------------------------------------------------------------------------------
    // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
    // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
    // ClienteControle que irá criar/atualizar o Banco de Dados
    public Cortadores cortadores{ get; set; }
    Controles.CortadoresControle cortadoresControle = new Controles.CortadoresControle();

    //--------------------------------------------------------------------------------------------------

    public Cadastrocortadorpage()
    {
      InitializeComponent();
    }

    //--------------------------------------------------------------------------------------------------

    void VoltarClicked(object sender, EventArgs e)
    {
      Application.Current.MainPage = new Listacortadorespage();
    }

    //--------------------------------------------------------------------------------------------------
    // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
    // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (cortadores != null)
      {
        IdLabel.Text = cortadores.Id.ToString();
        NomeEntry.Text = cortadores.Nome;
        TelefoneEntry.Text = cortadores.Telefone;
      

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
     
      
    }

    //--------------------------------------------------------------------------------------------------

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
      if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
      {
        // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
       cortadores = new Modelos.Cortadores();
        if (!String.IsNullOrEmpty(IdLabel.Text))
         cortadores.Id = int.Parse(IdLabel.Text);
        else
         cortadores.Id = 0;
        cortadores.Nome = NomeEntry.Text;
       cortadores.Telefone = TelefoneEntry.Text;
       
        


        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        cortadoresControle.CriarOuAtualizar(cortadores);
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
    private async void ExcluirClicked(object sender, EventArgs e)
   {
     Application.Current.MainPage = new Listaclientespage();
   }

    //--------------------------------------------------------------------------------------------------
  }
}