using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Relatoriovendas 
    {
        public Relatoriovendas()
        {
            InitializeComponent();
        }
        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }
    }
}
