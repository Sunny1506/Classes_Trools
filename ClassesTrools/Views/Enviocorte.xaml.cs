using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class  Enviocorte
    {
        public Enviocorte()
        {
            InitializeComponent();
        }
         var resposta = await DisplayAlert ("SALVAR" "DESEJA SALVAR?" "SIM" "NÃO");
    if (resposta == "SIM")
    {
        
    }   
    var resposta = await DisplayAlert ("CANCELAR" "DESEJA VOLTAR? É POSSÍVEL QUE AS INFORMAÇÕES NÃO SEJAM SALVAS " "VOLTAR" "CANCELAR");
    if (resposta == "VOLTAR")
    {
        
    } 
    }
}