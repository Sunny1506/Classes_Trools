using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Listaacabamentistas
    {
        public Listaacabamentistas()
        {
            InitializeComponent();
        }
          private async void ButtonDelete (object sender, EventArgs args)
{
 	 var resposta = await DisplayAlert ("EXCLUIR", "DESEJA EXCLUIR?", "SIM", "NÃO");
    if (resposta)
    {
        
    }    
}    
    }
}