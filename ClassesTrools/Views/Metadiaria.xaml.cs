using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Metadiaria
    {
        public Metadiaria()
        {
            InitializeComponent();
        }
     await DisplayAlert ("VALIDAÇÃO" "META NÃO BATIDA" "OK");
     await DisplayAlert ("VALIDAÇÃO" "META BATIDA, PARABÉNS" "OK");
     
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