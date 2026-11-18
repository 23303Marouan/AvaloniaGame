// ViewModels/MainWindowViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MonJeu.Messages;


namespace MonJeu.ViewModels;

public partial class MainWindowViewModel : ViewModelBase, IRecipient<NavigationMessage>
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    private readonly HomeViewModel _homeViewModel;
    private readonly SettingsViewModel _settingsViewModel;
    private readonly LevelsViewModel _levelsViewModel;
    private readonly IMessenger _messenger;

    public MainWindowViewModel(IMessenger messenger)
    {
        _messenger = messenger;
        _messenger.Register<NavigationMessage>(this); // S'abonner aux messages

        // Passer le messenger aux ViewModels qui en ont besoin
        _homeViewModel = new HomeViewModel(_messenger);
        _settingsViewModel = new SettingsViewModel();
        _levelsViewModel = new LevelsViewModel();
        _currentViewModel = _homeViewModel;
    }

    // Méthode appelée quand un NavigationMessage est reçu
    public void Receive(NavigationMessage message)
    {
        CurrentViewModel = message.Value;
    }

    [RelayCommand]
    private void NavigateToHome()
    {
        _messenger.Send(new NavigationMessage(_homeViewModel));
    }

    [RelayCommand]
    private void NavigateToSettings()
    {
        _messenger.Send(new NavigationMessage(_settingsViewModel));
    }

    [RelayCommand]
    private void NavigateToLevels()
    {
        _messenger.Send(new NavigationMessage(_levelsViewModel));
    }
}

