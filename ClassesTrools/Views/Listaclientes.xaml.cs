using Microsoft.Maui.Controls;


namespace ClassesTrools.Views
{
public partial class Listaclientes 
{
  Controles.ClientesControle clienteControle = new Controles.ClientesControle();

  public Listaclientes()
	{
		InitializeComponent();
    // Buscamos no banco de dados, via Controle, a lista de todos os Clientes cadastrados
    Listaclientes.ItemsSource = ClientesControle.LerTodos();
	}

  // Esse método será chamado toda vez que o usuário selecionar um cliente na lista
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroClientePage,
    // que é a página onde os dados do cliente podem ser criados/editados
    var page = new Cadastrocliente();
    // O passo seguinte é dizer para nova página qual cliente foi selecionado. Olhe o código da CadastroClientePage,
    // e verifique que lá terá um atributo público do tipo Cliente, chamado cliente.
    // Toda vez que se clica em um cliente na lista nessa página, setaremos na CadastroClientePage o atributo cliente 
    // com o cliente que foi clicado aqui.
    page.clientes = e.SelectedItem as Clientes;
    // Troca-se a página principal para a página que acabamos de criar
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
    // Quando a idéia é CRIAR um novo cliente, não é necessário setar o atributo "cliente" no CadastroClientePage,
    // sendo assim, apenas criamos a nova página
    Application.Current.MainPage = new Cadastrocliente();
  }
}
   // public partial class Listaclientes
    // {
        // public Listaclientes()
       //  {
            // InitializeComponent();
        // }
       // void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        //{
            // var page = new CadastroCliente();
            //  page.cliente = e.SelectedItem as Cliente;
            //   Application.Current.MainPage = page;
      //  }


       // private void ButtonVoltarButtonClicked(object sender, EventArgs args)
       // {

          //   Application.Current.MainPage = new Telainicial();

       //  }
        // private void ButtonCadastroButtonClicked(object sender, EventArgs args)
        // {

          //   Application.Current.MainPage = new Cadastrocliente();

      //   }
      //   private async void ButtonExcluirButtonClicked(object sender, EventArgs args)
      //   {
         //    var resposta = await DisplayAlert("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
          //   if (resposta)
           //  {
            // {
            // {
               //  Application.Current.MainPage = new Listaclientes();
           //  }
        // }
   //  }

 }