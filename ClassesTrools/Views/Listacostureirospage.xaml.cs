using Microsoft.Maui.Controls;
using Modelos;


namespace ClassesTrools.Views
{
public partial class Listacostureirospage 
{
  Controles.CostureirosControle costureirosControle= new Controles.CostureirosControle();

  public Listacostureirospage()
	{
		InitializeComponent();
    // Buscamos no banco de dados, via Controle, a lista de todos os Clientes cadastrados
   ListaCostureiros.ItemsSource = costureirosControle.LerTodos();
	}

  // Esse método será chamado toda vez que o usuário selecionar um cliente na lista
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroClientePage,
    // que é a página onde os dados do cliente podem ser criados/editados
    var page = new Cadastrocostureiropage();
    // O passo seguinte é dizer para nova página qual cliente foi selecionado. Olhe o código da CadastroClientePage,
    // e verifique que lá terá um atributo público do tipo Cliente, chamado cliente.
    // Toda vez que se clica em um cliente na lista nessa página, setaremos na CadastroClientePage o atributo cliente 
    // com o cliente que foi clicado aqui.
    page.costureiros = e.SelectedItem as Costureiros;
    // Troca-se a página principal para a página que acabamos de criar
    Application.Current.MainPage = page;
  }

  void NovoCostureiroClicked(object sender, EventArgs e)
  {
    // Quando a idéia é CRIAR um novo cliente, não é necessário setar o atributo "cliente" no CadastroClientePage,
    // sendo assim, apenas criamos a nova página
    Application.Current.MainPage = new Cadastrocostureiropage();
  }
  private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }
}
}