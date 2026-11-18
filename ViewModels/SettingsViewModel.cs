// ViewModels/SettingsViewModel.cs

using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia;
using Avalonia.Styling;
using System;


namespace MonJeu.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    public string InfoText => "Paramètres / Réglages";

    [ObservableProperty]
    private double soundVolume = 100;

    [ObservableProperty]
    private double musicVolume = 100;

    [ObservableProperty]
    private bool visualEffectsEnabled = true;

    [ObservableProperty]
    private bool fullscreenEnabled = false;

    [ObservableProperty]
    private bool darkModeEnabled = false;

    partial void OnDarkModeEnabledChanged(bool value)
    {
        if (value == true){
            Application.Current!.RequestedThemeVariant = ThemeVariant.Dark;
        }
        else{
            Application.Current!.RequestedThemeVariant = ThemeVariant.Light;
        }
    }
        partial void OnSoundVolumeChanged(double value)
    {
        Console.WriteLine($"Nouveau volume : {value}%");
    }
        partial void OnMusicVolumeChanged(double value)
    {
        Console.WriteLine($"Nouveau volume : {value}%");
    }

}
