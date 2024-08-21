using Microsoft.Maui.Controls;
using Modelos;


namespace ClassesTrools.Views
{
public partial class Relatoriospage : ContentPage
{
    public Relatoriospage ()
	{
		InitializeComponent();

	}

    private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }
        private void ButtonAcabamentoButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Relatorioacabamentopage();

        }
}
}