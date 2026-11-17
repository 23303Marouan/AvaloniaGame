// Messages/NavigationMessage.cs
using CommunityToolkit.Mvvm.Messaging.Messages;
using MonJeu.ViewModels;

namespace MonJeu.Messages;

public class NavigationMessage : ValueChangedMessage<ViewModelBase>
{
    public NavigationMessage(ViewModelBase viewModel) : base(viewModel)
    {
    }
}