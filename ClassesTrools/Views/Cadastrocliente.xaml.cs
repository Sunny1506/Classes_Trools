using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Cadastrocliente
    {
        public Cadastrocliente()
        {
            InitializeComponent();
        }

     var resposta = await DisplayAlert ("EXCLUIR" "DESEJA EXCLUIR?" "SIM" "NÃO");
    if (resposta == "SIM")
    {
        
    }    
     await DisplayAlert ("VALIDAÇÃO" "DADOS INVÁLIDOS" "OK");
     
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