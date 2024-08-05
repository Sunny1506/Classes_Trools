using Microsoft.Maui.Controls;


namespace ClassesTrools.Views
{
    public partial class Listaprodutos
    {
        public Listaprodutos()
        {
            InitializeComponent();
        }

   private async void ButtonDeleteProdutos (object sender, EventArgs args)
{
 	 var resposta = await DisplayAlert ("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
    if (resposta)
    {
        
    }    
}    
    }

}