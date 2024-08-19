using Microsoft.Maui.Controls;
using Controles;

using Modelos;

namespace ClassesTrools.Views
{
  public partial class Cadastrovendaspage : ContentPage
  {
    //--------------------------------------------------------------------------------------------------
    // Esse atributo "cliente" serve para a ListaClientes informar qual Cliente foi clicado na lista.
    // Será usado para preencher as Entry's com os dados do Cliente, assim como para ser enviado para o 
    // ClienteControle que irá criar/atualizar o Banco de Dados
    public Vendas vendas{ get; set; }
    Controles.VendasControle vendasControle = new Controles.VendasControle();

    //--------------------------------------------------------------------------------------------------

    public Cadastrovendaspage()
    {
      InitializeComponent();
    }

    //--------------------------------------------------------------------------------------------------

    void VoltarClicked(object sender, EventArgs e)
    {
      Application.Current.MainPage = new Relatoriovendaspage();
    }

    //--------------------------------------------------------------------------------------------------
    // OnAppearing -> Quando Aparecer: Esse método é executado quando a página é mostrada.
    // Nesse caso ao aparecer usaremos o "cliente" para preencher as Entry's
    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (vendas != null)
      {
        IdLabel.Text = vendas.Id.ToString();
        ClienteEntry.Text = vendas.Cliente;
        ProdutoEntry.Text = vendas.Produto;
        ValorEntry.Text = vendas.Valor;
        DescontoEntry.Text = vendas.Desconto;
      }
      else
        IdLabel.Text = "0";
    }

    //--------------------------------------------------------------------------------------------------
    // Método para limpar os dados da Entry
    private void OnApagarDadosClicked(object sender, EventArgs e)
    {
      IdLabel.Text = string.Empty;
      ClienteEntry.Text = string.Empty;
     ProdutoEntry.Text = string.Empty;
     ValorEntry.Text = string.Empty;
    DescontoEntry.Text  = string.Empty;
     
      
    }

    //--------------------------------------------------------------------------------------------------

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
      if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
      {
        // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
       vendas = new Modelos.Vendas();
        if (!String.IsNullOrEmpty(IdLabel.Text))
         vendas.Id = int.Parse(IdLabel.Text);
        else
        vendas.Id = 0;
        vendas.Cliente = ClienteEntry.Text;
       vendas.Produto = ProdutoEntry.Text;
       vendas.Valor = ValorEntry.Text;
       vendas.Desconto = DescontoEntry.Text;
       
        


        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        vendasControle.CriarOuAtualizar(vendas);
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
      if (String.IsNullOrEmpty(ClienteEntry.Text))
      {
        await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
        return false;
      }
      // Verifica se a Entry do Sobrenome está vazia
      else if (String.IsNullOrEmpty(ProdutoEntry.Text))
      {
        await DisplayAlert("Cadastrar", "O campo Produto é obrigatório", "OK");
        return false;
      }
      else if (String.IsNullOrEmpty(ValorEntry.Text))
      {
        await DisplayAlert("Cadastrar", "O campo Valor é obrigatório", "OK");
        return false;
      }

      else
        return true;
    }

    //--------------------------------------------------------------------------------------------------
  }
}