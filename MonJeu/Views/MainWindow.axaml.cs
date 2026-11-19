// Views/MainWindow.axaml.cs
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using MonJeu.ViewModels;

namespace MonJeu.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(WeakReferenceMessenger.Default);
    }
}