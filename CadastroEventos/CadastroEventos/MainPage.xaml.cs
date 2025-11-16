using CadastroEventos.Models;

namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    private Evento evento = new Evento();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private async void OnRegistrarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(evento.Nome))
        {
            await DisplayAlert("Atenção", "Informe o nome do evento.", "OK");
            return;
        }

        if (evento.DataFim < evento.DataInicio)
        {
            await DisplayAlert("Atenção", "A data de término não pode ser anterior à data de início.", "OK");
            return;
        }

        await Navigation.PushAsync(new EventSummaryPage(evento));
    }
}
