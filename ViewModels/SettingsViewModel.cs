// ViewModels/SettingsViewModel.cs

using CommunityToolkit.Mvvm.ComponentModel;

namespace MonJeu.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    public string InfoText => "Paramètres / Réglages";

    [ObservableProperty]
    private bool soundEnabled = true;

    [ObservableProperty]
    private bool musicEnabled = true;

    [ObservableProperty]
    private bool visualEffectsEnabled = true;

    [ObservableProperty]
    private bool fullscreenEnabled = false;

    [ObservableProperty]
    private bool darkModeEnabled = false;
}
