// ViewModels/HomeViewModel.cs
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MonJeu.Messages;

namespace MonJeu.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;
    private readonly SettingsViewModel _settingsViewModel;

    public string Greeting => "Bienvenue sur l'écran d'accueil !";

    public HomeViewModel(IMessenger messenger, SettingsViewModel settingsViewModel)
    {
        _messenger = messenger;
        _settingsViewModel = settingsViewModel;
    }

    [RelayCommand]
    private void NavigateToSettings()
    {
        // Envoi d'un message demandant la navigation
        _messenger.Send(new NavigationMessage(_settingsViewModel));
    }
}