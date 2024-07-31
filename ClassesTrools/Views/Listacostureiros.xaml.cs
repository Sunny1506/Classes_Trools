using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Listacostureiros
    {
        public Listacostureiros()
        {
            InitializeComponent();
        }
           var resposta = await DisplayAlert ("EXCLUIR" "DESEJA EXCLUIR?" "SIM" "NÃO");
    if (resposta == "SIM")
    {
        
    }   
    }
}