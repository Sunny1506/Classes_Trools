using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Listacortadores
    {
        public Listacortadores()
        {
            InitializeComponent();
        }
           var resposta = await DisplayAlert ("EXCLUIR" "DESEJA EXCLUIR?" "SIM" "NÃO");
    if (resposta == "SIM")
    {
        
    }   
    }
}
