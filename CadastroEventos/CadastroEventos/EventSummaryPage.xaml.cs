using CadastroEventos.Models;

namespace CadastroEventos;

public partial class EventSummaryPage : ContentPage
{
    public EventSummaryPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
