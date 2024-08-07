using Microsoft.Maui.Controls;

namespace ClassesTrools.Views
{
    public partial class Relatoriometadiaria
    {
        public Relatoriometadiaria()
        {
            InitializeComponent();
        }
        private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Metadiaria();

        }
    }
}
