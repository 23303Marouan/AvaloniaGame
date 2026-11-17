// ViewModels/HomeViewModel.cs
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MonJeu.Messages;

namespace MonJeu.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;

    public string Greeting => "Bienvenue sur l'écran d'accueil !";

    public HomeViewModel(IMessenger messenger)
    {
        _messenger = messenger;
    }

    [RelayCommand]
    private void NavigateToSettings()
    {
        // Envoi d'un message demandant la navigation
        _messenger.Send(new NavigationMessage(new SettingsViewModel()));
    }
}
